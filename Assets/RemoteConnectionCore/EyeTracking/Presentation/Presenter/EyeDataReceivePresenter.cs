using System.Collections.Generic;
using RemoteConnectionCore.EyeTracking.Domain;
using RemoteConnectionCore.EyeTracking.Presentation.Model;
using UniRx;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.EyeTracking.Presentation.Presenter
{
    public class EyeDataReceivePresenter : MonoBehaviour
    {
        [SerializeField] SkinnedMeshRenderer meshRenderer;
        [SerializeField] Transform rightEyeBone;
        [SerializeField] SetTransform rightEyeBoneTransform;
        [SerializeField] Transform leftEyeBone;
        [SerializeField] SetTransform leftEyeBoneTransform;
        [SerializeField] float intensity = 1f;

        [SerializeField] string rightEyeOpenessMorphName;
        [SerializeField] string leftEyeOpenessMorphName;
        Dictionary<string, int> morphIndexDic = new Dictionary<string, int>();
        Vector3 rightInitRotation;
        Vector3 leftInitRotation;
        private Subject<EyeData> eyeDataSubject = new Subject<EyeData>();

        [Inject]
        public void Init(EyeDataReceiveModel eyeDataReceiveModel)
        {
            morphIndexDic.Add("rightEyeOpenessMorphName",
                meshRenderer.sharedMesh.GetBlendShapeIndex(rightEyeOpenessMorphName));
            morphIndexDic.Add("leftEyeOpenessMorphName",
                meshRenderer.sharedMesh.GetBlendShapeIndex(leftEyeOpenessMorphName));
            rightInitRotation = rightEyeBone.localRotation.eulerAngles;
            leftInitRotation = leftEyeBone.localRotation.eulerAngles;
            eyeDataReceiveModel.Register(eyeDataSubject);
            eyeDataSubject.Subscribe(receivedData =>
            {
                rightEyeBone.localRotation =
                    Quaternion.Euler(rightInitRotation + rightEyeBoneTransform.translateTransform(
                                         new Vector3(receivedData.RightEyeRotationY * intensity,
                                             receivedData.RightEyeRotationX * intensity, 0)));
                leftEyeBone.localRotation =
                    Quaternion.Euler(leftInitRotation + leftEyeBoneTransform.translateTransform(
                                         new Vector3(receivedData.RightEyeRotationY * intensity,
                                             receivedData.RightEyeRotationX * intensity, 0)));
                meshRenderer.SetBlendShapeWeight(morphIndexDic["rightEyeOpenessMorphName"],
                    100 - (100 * receivedData.RightEyeOpeness));
                meshRenderer.SetBlendShapeWeight(morphIndexDic["leftEyeOpenessMorphName"],
                    100 - (100 * receivedData.RightEyeOpeness));
            });
        }
    }
}