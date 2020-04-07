using System;
using RemoteConnectionCore.EyeTracking.Application;
using RemoteConnectionCore.EyeTracking.Domain;
using UniRx;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.EyeTracking.Presentation.Model
{
    public class EyeDataReceiveModel
    {
        private DataReceiveService dataReceiveService;

        [Inject]
        public void Init(DataReceiveService dataReceiveService)
        {
            this.dataReceiveService = dataReceiveService;
        }

        public void Register(IObserver<EyeData> eyedata)
        {
            dataReceiveService.DataReceiveRegister(eyedata);
        }
    }
}