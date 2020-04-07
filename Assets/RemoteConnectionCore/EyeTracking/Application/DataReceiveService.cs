using System;
using RemoteConnectionCore.EyeTracking.Domain;
using Zenject;

namespace RemoteConnectionCore.EyeTracking.Application
{
    public class DataReceiveService
    {
        private readonly IEyeDataReceiver eyeDataReceiver;

        [Inject]
        public DataReceiveService(IEyeDataReceiver eyeDataReceiver)
        {
            this.eyeDataReceiver = eyeDataReceiver;
        }

        public void DataReceiveRegister(IObserver<EyeData> eyeDataAsObserver)
        {
            eyeDataReceiver.DataReceiveRegister(eyeDataAsObserver);
        }
    }
}