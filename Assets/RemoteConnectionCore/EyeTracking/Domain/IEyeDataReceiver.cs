using System;

namespace RemoteConnectionCore.EyeTracking.Domain
{
    public interface IEyeDataReceiver
    {
        void DataReceiveRegister(IObserver<EyeData> eyeDataAsObserver);
    }
}