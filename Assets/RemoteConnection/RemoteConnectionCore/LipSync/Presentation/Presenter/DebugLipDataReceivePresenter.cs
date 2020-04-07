using RemoteConnectionCore.LipSync.Domain;
using RemoteConnectionCore.LipSync.Presentation.Model;
using UniRx;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.LipSync.Presentation.Presenter
{
    public class DebugLipDataReceivePresenter : MonoBehaviour
    {
        private readonly Subject<OVRLipSync.Frame> headDataSubject = new Subject<OVRLipSync.Frame>();

        [Inject]
        public void Init(LipDataReceiveModel lipDataReceiveModel)
        {
            lipDataReceiveModel.Register(headDataSubject);
            headDataSubject.Subscribe(receivedData =>
            {
                Debug.Log("frameDelay" + receivedData.frameDelay
                                         + "frameNumber" + receivedData.frameNumber
                                         + "laughterScore" + receivedData.laughterScore
                                         + "Visemes" + receivedData.Visemes);
            });
        }
    }
}