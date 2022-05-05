using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP_saudio_sim_csharp.Mussoni
{
    public interface IOpenAL
    {
        int ALGenBuffer();
        void ALBufferData(int id, int sampleSize, MemoryStream buffer, int sampleRate);
    }
}
