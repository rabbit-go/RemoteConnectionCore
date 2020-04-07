using RemoteConnectionCore.LipSync.Presentation.Model;
using RemoteConnectionCore.LipSync.Domain;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using Zenject;

namespace RemoteConnectionCore.LipSync.Presentation.Presenter
{
    public class LipSyncFrameDataSendPresenter : MonoBehaviour
    {
        // smoothing amount
        [Range(1, 100)]
        [Tooltip("Smoothing of 1 will yield only the current predicted viseme, 100 will yield an extremely smooth viseme response.")]
        public int smoothAmount = 70;
        [Inject]void Init(LipDataSendModel lipDataSendModel)
        {
            var lipSyncContext = GetComponent<OVRLipSyncContextBase>();
            this.UpdateAsObservable().Subscribe(_ =>
            {
                if (lipSyncContext != null)
                {
                    // get the current viseme frame
                    OVRLipSync.Frame frame = lipSyncContext.GetCurrentPhonemeFrame();
                    if (frame != null)
                    {
                        lipDataSendModel.SendData(frame);
                    }
                    // Update smoothing value
                    if (smoothAmount != lipSyncContext.Smoothing)
                    {
                        lipSyncContext.Smoothing = smoothAmount;
                    }
                }
            });
        }
    }
}
