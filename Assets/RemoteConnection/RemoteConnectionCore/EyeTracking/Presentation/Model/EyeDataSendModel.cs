using RemoteConnectionCore.EyeTracking.Application;
using RemoteConnectionCore.EyeTracking.Domain;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.EyeTracking.Presentation.Model
{
    public class EyeDataSendModel
    {
        private DataSenderService dataSenderService;
        [Inject]
        public void Init(DataSenderService dataSenderService)
        {
            this.dataSenderService = dataSenderService;
        }

        public void SendEyeData(EyeData eyeData)
        {
            dataSenderService.Send(eyeData);
        }
    }
}