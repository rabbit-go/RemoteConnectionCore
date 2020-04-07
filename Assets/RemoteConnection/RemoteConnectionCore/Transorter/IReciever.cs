using System;
namespace RemoteConnectionCore.Transporter
{
    public interface IReciever
    {
        void Register<T>(Action<T> action);
    }
}
