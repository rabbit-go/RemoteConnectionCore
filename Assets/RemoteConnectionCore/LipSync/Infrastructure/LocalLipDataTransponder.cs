using System;
using System.Collections.Generic;
using System.Reflection;
using RemoteConnectionCore.LipSync.Domain;

namespace RemoteConnectionCore.LipSync.Infrastructure
{
    public class LocalLipDataTransponder : ILipDataSender, ILipDataReceiver
    {
        private readonly FieldInfo[] fieldInfos;
        private readonly List<IObserver<LipDataTools.LipData>> lipDataAsObserverList = new List<IObserver<LipDataTools.LipData>>();

        public LocalLipDataTransponder()
        {
            fieldInfos = typeof(LipDataTools.LipData).GetFields();
        }

        public void Send(LipDataTools.LipData sendData)
        {
            foreach (var eyeDataAsObserver in lipDataAsObserverList)
            {
                eyeDataAsObserver.OnNext(sendData);
            }
        }
        public void DataReceiveRegister(IObserver<LipDataTools.LipData> eyeDataAsObserver)
        {
            this.lipDataAsObserverList.Add(eyeDataAsObserver);
        }
    }
}