using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP_saudio_sim_csharp.Mussoni
{
    public class OpenAL : IOpenAL
    {
        public void ALBufferData(int id, int sampleSize, MemoryStream buffer, int sampleRate)
        {
        }

        public int ALGenBuffer()
        {
            return new Random().Next(1, 255);
        }
    }
}
