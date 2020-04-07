using System;
using System.Collections.Generic;
using System.Reflection;
using RemoteConnectionCore.HeadTracking.Domain;

namespace RemoteConnectionCore.HeadTracking.Infrastructure
{
    public class LocalHeadDataTransponder : IHeadDataSender, IHeadDataReceiver
    {
        private readonly FieldInfo[] fieldInfos;
        private List<IObserver<HeadData>> eyeDataAsObserverList = new List<IObserver<HeadData>>();

        public LocalHeadDataTransponder()
        {
            fieldInfos = typeof(HeadData).GetFields();
        }

        public void Send(HeadData sendData)
        {
            foreach (var eyeDataAsObserver in eyeDataAsObserverList)
            {
                eyeDataAsObserver.OnNext(sendData);
            }
        }
        public void DataReceiveRegister(IObserver<HeadData> eyeDataAsObserver)
        {
            this.eyeDataAsObserverList.Add(eyeDataAsObserver);
        }
    }
}