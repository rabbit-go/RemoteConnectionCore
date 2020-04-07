using RemoteConnectionCore.LipSync.Domain;

namespace RemoteConnectionCore.LipSync.Application
{
    public class DataSenderService
    {
        private readonly ILipDataSender dataSender;

        public DataSenderService(ILipDataSender dataSender)
        {
            this.dataSender = dataSender;
        }

        public void Send(LipDataTools.LipData sendData)
        {
            dataSender.Send(sendData);
        }
    }
}