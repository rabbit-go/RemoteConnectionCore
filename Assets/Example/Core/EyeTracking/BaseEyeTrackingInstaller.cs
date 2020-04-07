using RemoteConnectionCore.EyeTracking.Application;
using RemoteConnectionCore.EyeTracking.Infrastructure;
using RemoteConnectionCore.EyeTracking.Presentation;
using Zenject;

namespace RemoteConnectionCore.EyeTracking
{
    public class BaseEyeTrackingInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<LocalEyeDataTransponder>().AsCached();
            
        }
    }
}