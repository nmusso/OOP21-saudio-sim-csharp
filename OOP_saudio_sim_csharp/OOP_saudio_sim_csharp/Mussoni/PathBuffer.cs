using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Buffer
{
    public class PathBuffer : AbstractBuffer
    {
        public PathBuffer(string file) : base(file)
        {
        }

        protected override IAudioStream GetAudioStream()
        {
            if (!LoadFile(base.GetFile()))
            {
                throw new FileNotFoundException();
            }

            return new AudioStream(base.GetFile());
        }

        private bool LoadFile(string path)
        {
            return true;
        }
    }
}
