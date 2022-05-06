using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_saudio_sim_csharp.Mussoni
{
    public class ResourceBuffer : AbstractBuffer
    {
        public ResourceBuffer(string file) : base(file)
        {
        }

        protected override IAudioStream GetAudioStream() => new AudioStream(base.FilePath);
    }
}
