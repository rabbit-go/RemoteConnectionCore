using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RemoteConnectionCore.Transporter
{
    public interface ITransporter
    {
        void Send<T>(T data);

    }
}
