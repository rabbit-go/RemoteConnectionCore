using RemoteConnectionCore.HeadTracking.Domain;

namespace RemoteConnectionCore.HeadTracking.Application
{
    public class DataSenderService
    {
        private readonly IHeadDataSender dataSender;

        public DataSenderService(IHeadDataSender dataSender)
        {
            this.dataSender = dataSender;
        }

        public void Send(HeadData sendData)
        {
            dataSender.Send(sendData);
        }
    }
}