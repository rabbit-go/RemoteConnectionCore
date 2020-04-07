using RemoteConnectionCore.EyeTracking.Application;
using RemoteConnectionCore.EyeTracking.Domain;
using RemoteConnectionCore.EyeTracking.Infrastructure;
using RemoteConnectionCore.EyeTracking.Presentation.Model;
using Zenject;

namespace RemoteConnectionCore.EyeTracking.Presentation
{
    public class ReceiveBaseInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<EyeDataReceiveModel>().AsCached();
            Container.Bind<DataReceiveService>().AsCached();
        }
    }
}