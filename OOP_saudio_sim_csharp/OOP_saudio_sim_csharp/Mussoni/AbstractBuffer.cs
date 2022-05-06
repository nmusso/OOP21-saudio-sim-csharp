using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Mussoni
{
    public abstract class AbstractBuffer : IBuffer
    {
        public string FilePath { get; }

        public int ID { get; private set; }

        public AbstractBuffer(string file)
        {
            FilePath = file;
            GenerateBuffer();
        }

        private void GenerateBuffer()
        {
            try
            {
                using (IAudioStream stream = GetAudioStream())
                {
                    int sampleSize = stream.GetSampleSize();
                    int sampleRate = stream.GetSampleRate();
                    byte[] byteArray = new byte[stream.Available()];
                    stream.Read(byteArray);

                    if (stream.GetChannels() == 2)
                        ConvertToMono.Convert(ref byteArray);

                    MemoryStream audioBuffer = GetByteBuffer(byteArray);

                    ID = OpenAl.AlGenBuffer();
                    OpenAl.AlBufferData(ID, sampleSize, audioBuffer, sampleRate);
                }
            }
            catch (IOException e)
            {
                throw new ALFormatException("Error during generating buffer", e);
            }
        }

        protected abstract IAudioStream GetAudioStream();

        private MemoryStream GetByteBuffer(byte[] byteArray)
        {
            MemoryStream buffer = new MemoryStream();

            using (BinaryWriter writer = new BinaryWriter(buffer))
            {
                foreach (byte b in byteArray)
                    writer.Write(b);
            }

            return buffer;
        }
    }
}
