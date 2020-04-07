
using RemoteConnectionCore.LipSync.Domain;
using RemoteConnectionCore.LipSync.Presentation.Model;
using UniRx;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.LipSync.Presentation.Presenter
{
    public class DebugLipDataSendPresenter : MonoBehaviour
    {
        // Start is called before the first frame update
        private readonly Subject<LipDataTools.LipData> eyeDataAsObservable;
        readonly LipDataTools.LipData lipData = new LipDataTools.LipData();
        private LipDataSendModel lipDataSendModel;

        [Inject]
        public void Init(LipDataSendModel lipDataSendModel)
        {
            this.lipDataSendModel = lipDataSendModel;
        }

        public void Update()
        {
            var lipdata = new OVRLipSync.Frame();
            lipDataSendModel.SendData(lipdata);
        }
    }
}