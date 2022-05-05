using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Buffer
{
    public interface IOpenAL
    {
        int ALGenBuffer();
        void ALBufferData(int id, int sampleSize, MemoryStream buffer, int sampleRate);
    }
}
