using RemoteConnectionCore.EyeTracking.Application;
using RemoteConnectionCore.EyeTracking.Domain;
using RemoteConnectionCore.EyeTracking.Presentation.Model;
using UniRx;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.EyeTracking.Presentation.Presenter
{
    public class DebugEyeDataSendPresenter : MonoBehaviour
    {
        // Start is called before the first frame update
        private readonly Subject<EyeData> eyeDataAsObservable;
        readonly EyeData eyeData = new EyeData();
        private EyeDataSendModel eyeDataSendModel;

        [Inject]
        public void Init(EyeDataSendModel eyeDataSendModel)
        {
            this.eyeDataSendModel = eyeDataSendModel;
        }

        public void Update()
        {
            eyeData.LeftEyeRotationX = Mathf.Cos(Time.time) * 40;
            eyeData.LeftEyeRotationY = Mathf.Sin(Time.time) * 40;
            eyeData.RightEyeRotationX = Mathf.Cos(Time.time) * 40;
            eyeData.RightEyeRotationY = Mathf.Sin(Time.time) * 40;
            eyeData.RightEyeOpeness = Mathf.Abs(Mathf.Cos(Time.time));
            eyeData.LeftEyeOpeness = Mathf.Abs(Mathf.Sin(Time.time));
            eyeDataSendModel.SendEyeData(eyeData);
        }
    }
}