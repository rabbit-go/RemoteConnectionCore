using System.Reflection;
using RemoteConnectionCore.HeadTracking.Domain;
using UnityEngine;
using UniRx;

namespace RemoteConnectionCore.HeadTracking.Infrastructure
{
    public class DebugHeadDataSender : IHeadDataSender
    {
        private readonly FieldInfo[] fieldInfos;

        public DebugHeadDataSender()
        {
            fieldInfos = typeof(HeadData).GetFields();
        }

        public void Send(HeadData sendData)
        {
            foreach (var fieldInfo in fieldInfos)
            {
                Debug.Log(fieldInfo.Name + fieldInfo.GetValue(sendData));
            }
        }
    }
}