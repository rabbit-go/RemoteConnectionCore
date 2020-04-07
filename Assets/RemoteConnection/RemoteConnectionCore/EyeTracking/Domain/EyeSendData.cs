namespace RemoteConnectionCore.EyeTracking.Domain
{
    /// Rotation is Degree(-180 to 180)正面右向き正上向き正
    /// Blink is normalizefloat(-1(close) to 1(open))
    [System.Serializable]
    public class EyeData
    {
        public string name;
        public float RightEyeRotationX;
        public float RightEyeRotationY;
        public float LeftEyeRotationX;
        public float LeftEyeRotationY;
        public float RightEyeOpeness;
        public float LeftEyeOpeness;
    }
}