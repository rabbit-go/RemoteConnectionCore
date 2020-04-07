using RemoteConnectionCore.LipSync.Application;
using RemoteConnectionCore.LipSync.Domain;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.LipSync.Presentation.Model
{
    public class LipDataSendModel 
    {
        private DataSenderService dataSenderService;
        [Inject]
        public void Init(DataSenderService dataSenderService)
        {
            this.dataSenderService = dataSenderService;
        }

        public void SendData(OVRLipSync.Frame lipData)
        {
            var data = new LipDataTools.LipData()
            {
                frameDelay = lipData.frameDelay,
                frameNumber = lipData.frameNumber,
                laughterScore = lipData.laughterScore,
                Visemes = lipData.Visemes
            };
            dataSenderService.Send(data);
        }
    }
}