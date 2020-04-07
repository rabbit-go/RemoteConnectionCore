using RemoteConnectionCore.LipSync.Infrastructure;
using Zenject;

namespace Example.Core.MorphDemo
{
    public class MorphTransportInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<LocalLipDataTransponder>().AsCached();
        }
    }
}