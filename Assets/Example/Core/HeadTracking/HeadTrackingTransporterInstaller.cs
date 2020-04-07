using RemoteConnectionCore.HeadTracking.Infrastructure;
using Zenject;

namespace Example.Core.HeadTracking
{
    public class HeadTrackingTransporterInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<LocalHeadDataTransponder>().AsCached();
        }
    }
}