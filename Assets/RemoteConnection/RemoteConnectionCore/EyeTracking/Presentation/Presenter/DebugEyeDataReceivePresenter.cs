using RemoteConnectionCore.EyeTracking.Domain;
using RemoteConnectionCore.EyeTracking.Presentation.Model;
using UniRx;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.EyeTracking.Presentation.Presenter
{
    public class DebugEyeDataReceivePresenter : MonoBehaviour
    {
        private Subject<EyeData> eyeDataSubject = new Subject<EyeData>();

        [Inject]
        public void Init(EyeDataReceiveModel eyeDataReceiveModel)
        {
            eyeDataReceiveModel.Register(eyeDataSubject);
            eyeDataSubject.Subscribe(receivedData =>
            {
                Debug.Log("LeftX" + receivedData.LeftEyeRotationX
                                  + "LeftY" + receivedData.LeftEyeRotationY
                                  + "RightX" + receivedData.RightEyeRotationX
                                  + "RightY" + receivedData.RightEyeRotationY);
            });
        }
    }
}