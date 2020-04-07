using Zenject;

namespace RemoteConnectionCore.EyeTracking.Application
{
    public class ReceiveApplicationInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<DataReceiveService>();
        }
    }
}