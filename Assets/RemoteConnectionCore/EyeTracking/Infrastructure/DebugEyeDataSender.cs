using System.Reflection;
using RemoteConnectionCore.EyeTracking.Domain;
using UnityEngine;
using UniRx;

namespace RemoteConnectionCore.EyeTracking.Infrastructure
{
    public class DebugEyeDataSender : IEyeDataSender
    {
        private readonly FieldInfo[] fieldInfos;

        public DebugEyeDataSender()
        {
            fieldInfos = typeof(EyeData).GetFields();
        }

        public void Send(EyeData sendData)
        {
            foreach (var fieldInfo in fieldInfos)
            {
                Debug.Log(fieldInfo.Name + fieldInfo.GetValue(sendData));
            }
        }
    }
}