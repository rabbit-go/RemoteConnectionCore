using RemoteConnectionCore.LipSync.Application;
using RemoteConnectionCore.LipSync.Presentation.Model;
using UnityEngine;
using Zenject;

public class MorphRecieveInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<LipDataReceiveModel>().AsCached();
        Container.Bind<DataReceiveService>().AsCached();
    }
}