using System;

namespace RemoteConnectionCore.HeadTracking.Domain
{
    public interface IHeadDataReceiver
    {
        void DataReceiveRegister(IObserver<HeadData> eyeDataAsObserver);
    }
}