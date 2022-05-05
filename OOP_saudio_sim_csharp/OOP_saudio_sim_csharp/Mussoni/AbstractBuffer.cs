using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Mussoni
{
    public abstract class AbstractBuffer : IBuffer
    {
        private readonly string _file;
        private int _id;

        public AbstractBuffer(string file)
        {
            _file = file;
            GenerateBuffer();
        }

        public string GetFile() => _file;

        public int GetID() => _id;

        private void GenerateBuffer()
        {
            try
            {
                using (IAudioStream stream = GetAudioStream())
                {
                    byte[] byteArray = new byte[stream.Available()];
                    stream.Read(byteArray);
                    int sampleSize = stream.GetSampleSize();
                    int sampleRate = stream.GetSampleRate();

                    if (stream.GetChannels() == 2)
                    {
                        ConvertToMono.Convert(byteArray);
                    }

                    MemoryStream audioBuffer = GetByteBuffer(byteArray);

                    _id = OpenAl.AlGenBuffer();
                    OpenAl.AlBufferData(_id, sampleSize, audioBuffer, sampleRate);
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
                {
                    writer.Write(b);
                }
            }

            return buffer;
        }
    }
}
