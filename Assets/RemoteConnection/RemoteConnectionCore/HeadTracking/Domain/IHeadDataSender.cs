namespace RemoteConnectionCore.HeadTracking.Domain
{
    public interface IHeadDataSender
    {
        void Send(HeadData sendData);
    }
}