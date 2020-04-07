using System;
using RemoteConnectionCore.LipSync.Domain;
using Zenject;

namespace RemoteConnectionCore.LipSync.Application
{
    public class DataReceiveService
    {
        private readonly ILipDataReceiver dataReceiver;

        [Inject]
        public DataReceiveService(ILipDataReceiver dataReceiver)
        {
            this.dataReceiver = dataReceiver;
        }

        public void DataReceiveRegister(IObserver<LipDataTools.LipData> dataAsObserver)
        {
            dataReceiver.DataReceiveRegister(dataAsObserver);
        }
    }
}