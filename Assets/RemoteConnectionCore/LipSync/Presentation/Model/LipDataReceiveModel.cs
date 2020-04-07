using System;
using RemoteConnectionCore.LipSync.Domain;
using RemoteConnectionCore.LipSync.Application;
using UniRx;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.LipSync.Presentation.Model
{
    public class LipDataReceiveModel 
    {
        private DataReceiveService dataReceiveService;

        [Inject]
        public void Init(DataReceiveService dataReceiveService)
        {
            this.dataReceiveService = dataReceiveService;
        }

        public void Register(IObserver<OVRLipSync.Frame> lipData)
        {
            var sub = new Subject<LipDataTools.LipData>();
            var x = sub.Select(data => new OVRLipSync.Frame()
            {
                frameDelay = data.frameDelay, frameNumber = data.frameNumber,
                laughterScore = data.laughterScore, Visemes = data.Visemes
            });
            x.Subscribe(lipData);
            dataReceiveService.DataReceiveRegister(sub);
        }
    }
}