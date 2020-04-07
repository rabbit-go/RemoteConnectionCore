using System;
using UnityEngine;

namespace RemoteConnectionCore.LipSync.Domain
{
    public class LipDataTools
    {
        public enum Viseme
        {
            sil,
            PP,
            FF,
            TH,
            DD,
            kk,
            CH,
            SS,
            nn,
            RR,
            aa,
            E,
            ih,
            oh,
            ou
        };
        public static readonly int VisemeCount = Enum.GetNames(typeof(Viseme)).Length;
        [System.Serializable]
        public class LipData
        {
            public int frameNumber;    // count from start of recognition
            public int frameDelay;     // in ms
            public float[] Visemes = new float[VisemeCount];       // Array of floats for viseme frame. Size of Viseme Count, above
            public float laughterScore; // probability of laughter presence.
            public LipData()
            {

            }
        }
        
    }
    
    
}