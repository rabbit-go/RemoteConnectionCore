namespace RemoteConnectionCore.EyeTracking.Domain
{
    public interface IEyeDataSender
    {
        void Send(EyeData sendData);
    }
}