namespace RemoteConnectionCore.LipSync.Domain
{
    public interface ILipDataSender
    {
        void Send(LipDataTools.LipData sendData);
    }
}