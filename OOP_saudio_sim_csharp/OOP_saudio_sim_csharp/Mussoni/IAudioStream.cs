using System;
using System.Collections.Generic;
using System.Text;

namespace Buffer
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
