using RemoteConnectionCore.HeadTracking.Application;
using RemoteConnectionCore.HeadTracking.Presentation.Model;
using Zenject;

namespace Example.Core.HeadTracking
{
    public class HeadTrackingReceiveInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<HeadDataReceiveModel>().AsCached();
            Container.Bind<DataReceiveService>().AsCached();
        }
    }
}