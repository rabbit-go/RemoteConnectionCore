using System.Collections.Generic;
using RemoteConnectionCore.HeadTracking.Domain;
using RemoteConnectionCore.HeadTracking.Presentation.Model;
using UniRx;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.HeadTracking.Presentation.Presenter
{
    public class HeadDataReceivePresenter : MonoBehaviour
    {
        [SerializeField] Transform headBone;
        private Subject<HeadData> headDataSubject = new Subject<HeadData>();

        [Inject]
        public void Init(HeadDataReceiveModel headDataReceiveModel)
        {
            headDataReceiveModel.Register(headDataSubject);
            headDataSubject.Subscribe(receivedData =>
            {
                headBone.localRotation = Quaternion.Euler(receivedData.headRotation);
                headBone.localPosition = receivedData.headPosition;
            });
        }
    }
}