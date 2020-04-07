using System;
using System.Collections.Generic;
using System.Reflection;
using RemoteConnectionCore.EyeTracking.Domain;

namespace RemoteConnectionCore.EyeTracking.Infrastructure
{
    public class LocalEyeDataTransponder : IEyeDataSender, IEyeDataReceiver
    {
        private readonly FieldInfo[] fieldInfos;
        private List<IObserver<EyeData>> eyeDataAsObserverList = new List<IObserver<EyeData>>();

        public LocalEyeDataTransponder()
        {
            fieldInfos = typeof(EyeData).GetFields();
        }

        public void Send(EyeData sendData)
        {
            foreach (var eyeDataAsObserver in eyeDataAsObserverList)
            {
                eyeDataAsObserver.OnNext(sendData);
            }
        }
        public void DataReceiveRegister(IObserver<EyeData> eyeDataAsObserver)
        {
            this.eyeDataAsObserverList.Add(eyeDataAsObserver);
        }
    }
}