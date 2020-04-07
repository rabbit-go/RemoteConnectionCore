using UnityEngine;

namespace RemoteConnectionCore.HeadTracking.Domain
{
    [System.Serializable]
    public class HeadData
    {
        public Vector3 headPosition;
        public Vector3 headRotation;
        public HeadData()
        {

        }
        public HeadData(Vector3 headPosition, Vector3 headRotation)
        {
            this.headPosition = headPosition;
            this.headRotation = headRotation;
        }
    }
}