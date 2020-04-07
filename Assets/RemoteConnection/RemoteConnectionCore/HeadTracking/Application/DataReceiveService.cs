using System;
using RemoteConnectionCore.HeadTracking.Domain;
using Zenject;

namespace RemoteConnectionCore.HeadTracking.Application
{
    public class DataReceiveService
    {
        private readonly IHeadDataReceiver eyeDataReceiver;

        [Inject]
        public DataReceiveService(IHeadDataReceiver dataReceiver)
        {
            this.eyeDataReceiver = dataReceiver;
        }

        public void DataReceiveRegister(IObserver<HeadData> dataAsObserver)
        {
            eyeDataReceiver.DataReceiveRegister(dataAsObserver);
        }
    }
}