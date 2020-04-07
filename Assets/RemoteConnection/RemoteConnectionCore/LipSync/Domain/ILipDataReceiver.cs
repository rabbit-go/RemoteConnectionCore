using System;

namespace RemoteConnectionCore.LipSync.Domain
{
    public interface ILipDataReceiver
    {
        void DataReceiveRegister(IObserver<LipDataTools.LipData> eyeDataAsObserver);
    }
}