using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_saudio_sim_csharp.Mussoni
{
    public interface IAudioStream : IDisposable
    {
        int GetChannels();
        int GetSampleSize();
        int GetSampleRate();
        int Available();
        void Read(byte[] array);
    }
}
