using System;

namespace RemoteConnectionCore.LipSync.Domain
{
    public interface ILipDataCollector
    {
        IObservable<LipDataTools.LipData> LipDataAsObservable { get; }
    }
}