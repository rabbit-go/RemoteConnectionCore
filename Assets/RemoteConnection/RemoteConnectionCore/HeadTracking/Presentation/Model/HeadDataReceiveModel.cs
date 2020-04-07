using System;
using RemoteConnectionCore.HeadTracking.Application;
using RemoteConnectionCore.HeadTracking.Domain;
using UniRx;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.HeadTracking.Presentation.Model
{
    public class HeadDataReceiveModel 
    {
        private DataReceiveService dataReceiveService;

        [Inject]
        public void Init(DataReceiveService dataReceiveService)
        {
            this.dataReceiveService = dataReceiveService;
        }

        public void Register(IObserver<HeadData> headData)
        {
            dataReceiveService.DataReceiveRegister(headData);
        }
    }
}