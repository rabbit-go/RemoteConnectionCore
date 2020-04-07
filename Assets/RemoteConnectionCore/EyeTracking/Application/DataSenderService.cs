using RemoteConnectionCore.EyeTracking.Domain;

namespace RemoteConnectionCore.EyeTracking.Application
{
    public class DataSenderService
    {
        private readonly IEyeDataSender eyeDataSender;

        public DataSenderService(IEyeDataSender eyeDataSender)
        {
            this.eyeDataSender = eyeDataSender;
        }

        public void Send(EyeData sendData)
        {
            eyeDataSender.Send(sendData);
        }
    }
}