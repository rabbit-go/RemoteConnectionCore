using System.Reflection;
using RemoteConnectionCore.LipSync.Domain;
using UnityEngine;
using UniRx;

namespace RemoteConnectionCore.LipSync.Infrastructure
{
    public class DebugLipDataSender : ILipDataSender
    {
        private readonly FieldInfo[] fieldInfos;

        public DebugLipDataSender()
        {
            fieldInfos = typeof(LipDataTools.LipData).GetFields();
        }

        public void Send(LipDataTools.LipData sendData)
        {
            foreach (var fieldInfo in fieldInfos)
            {
                Debug.Log(fieldInfo.Name + fieldInfo.GetValue(sendData));
            }
        }
    }
}