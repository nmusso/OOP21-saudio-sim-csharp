using System;
using System.Collections.Generic;
using System.Text;

namespace Buffer
{
    public class ResourceBuffer : AbstractBuffer
    {
        public ResourceBuffer(string file) : base(file)
        {
        }

        protected override IAudioStream GetAudioStream()
        {
            return new AudioStream(base.GetFile());
        }
    }
}
