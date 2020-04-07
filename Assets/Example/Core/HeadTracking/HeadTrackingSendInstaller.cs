using RemoteConnectionCore.HeadTracking.Application;
using RemoteConnectionCore.HeadTracking.Presentation.Model;
using Zenject;

namespace Example.Core.HeadTracking
{
    public class HeadTrackingSendInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<HeadDataSendModel>().AsCached();
            Container.Bind<DataSenderService>().AsCached();
        }
    }
}