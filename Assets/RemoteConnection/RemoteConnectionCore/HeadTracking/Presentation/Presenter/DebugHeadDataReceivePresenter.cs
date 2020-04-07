using RemoteConnectionCore.HeadTracking.Domain;
using RemoteConnectionCore.HeadTracking.Presentation.Model;
using UniRx;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.HeadTracking.Presentation.Presenter
{
    public class DebugHeadDataReceivePresenter : MonoBehaviour
    {
        private readonly Subject<HeadData> headDataSubject = new Subject<HeadData>();

        [Inject]
        public void Init(HeadDataReceiveModel headDataReceiveModel)
        {
            headDataReceiveModel.Register(headDataSubject);
            headDataSubject.Subscribe(receivedData =>
            {
                Debug.Log("headPosition" + receivedData.headPosition
                                  + "headRotation" + receivedData.headRotation);
            });
        }
    }
}