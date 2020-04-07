using RemoteConnectionCore.HeadTracking.Application;
using RemoteConnectionCore.HeadTracking.Presentation.Model;
using RemoteConnectionCore.HeadTracking.Domain;
using UniRx;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.HeadTracking.Presentation.Presenter
{
    public class DebugHeadDataSendPresenter : MonoBehaviour
    {
        // Start is called before the first frame update
        private readonly Subject<HeadData> eyeDataAsObservable;
        readonly HeadData headData = new HeadData();
        private HeadDataSendModel headDataSendModel;

        [Inject]
        public void Init(HeadDataSendModel headDataSendModel)
        {
            this.headDataSendModel = headDataSendModel;
        }

        public void Update()
        {
            headData.headPosition = new Vector3(Mathf.Cos(Time.time) * 0.01f, Mathf.Sin(Time.time) * 0.02f,
                -Mathf.Sin(Time.time) * 0.04f);
            headData.headRotation = new Vector3(Mathf.Cos(Time.time) * 18, Mathf.Sin(Time.time) * 18,
                -Mathf.Sin(Time.time) * 18);
            headDataSendModel.SendData(headData);
        }
    }
}