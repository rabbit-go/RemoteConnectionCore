using Zenject;

namespace RemoteConnectionCore.EyeTracking.Infrastructure
{
    public class LocalInfrastructureInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<LocalEyeDataTransponder>().AsCached();
        }
    }
}
