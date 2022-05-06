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
            if (!LoadFile(base.File))
                throw new FileNotFoundException();

            return new AudioStream(base.File);
        }

        private bool LoadFile(string path)
        {
            return true;
        }
    }
}
