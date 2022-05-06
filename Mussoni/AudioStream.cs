using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_saudio_sim_csharp.Mussoni
{
    public class AudioStream : IAudioStream
    {
        private readonly string _filePath;

        public AudioStream(string filePath)
        {
            _filePath = filePath;
        }

        public int Available()
        {
            return 1;
        }

        public void Dispose()
        {
        }

        public int GetChannels()
        {
            return 1;
        }

        public int GetSampleRate()
        {
            return 44100;
        }

        public int GetSampleSize()
        {
            return 0;
        }

        public void Read(byte[] array)
        {
        }
    }
}
