using Zenject;

namespace RemoteConnectionCore.EyeTracking.Application
{
    public class SendApplicationInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<DataSenderService>();
        }
    }
}