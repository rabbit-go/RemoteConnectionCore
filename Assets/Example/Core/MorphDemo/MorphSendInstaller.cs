using RemoteConnectionCore.LipSync.Application;
using RemoteConnectionCore.LipSync.Presentation.Model;
using Zenject;

public class MorphSendInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<LipDataSendModel>().AsCached();
        Container.Bind<DataSenderService>().AsCached();
    }
}