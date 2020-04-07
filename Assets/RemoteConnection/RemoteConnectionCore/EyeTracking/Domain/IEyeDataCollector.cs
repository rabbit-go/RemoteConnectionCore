using System;

namespace RemoteConnectionCore.EyeTracking.Domain
{
    public interface IEyeDataCollector
    {
        IObservable<EyeData> EyeDataAsObservable { get; }
    }
}