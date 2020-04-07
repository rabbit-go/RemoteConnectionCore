using RemoteConnectionCore.HeadTracking.Application;
using RemoteConnectionCore.HeadTracking.Domain;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.HeadTracking.Presentation.Model
{
    public class HeadDataSendModel 
    {
        private DataSenderService dataSenderService;
        [Inject]
        public void Init(DataSenderService dataSenderService)
        {
            this.dataSenderService = dataSenderService;
        }

        public void SendData(HeadData headData)
        {
            dataSenderService.Send(headData);
        }
    }
}