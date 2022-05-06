using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP_saudio_sim_csharp.Mussoni
{
    public class PathBuffer : AbstractBuffer
    {
        public PathBuffer(string file) : base(file)
        {
        }

        protected override IAudioStream GetAudioStream()
        {
            return LoadFile(base.FilePath) ? new AudioStream(base.FilePath) : throw new FileNotFoundException();
        }

        private bool LoadFile(string path)
        {
            return true;
        }
    }
}
