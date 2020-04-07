using System;

namespace RemoteConnectionCore.HeadTracking.Domain
{
    public interface IHeadDataCollector
    {
        IObservable<HeadData> HeadDataAsObservable { get; }
    }
}