using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using OOP_saudio_sim_csharp.Sciarrillo;

namespace OOP_saudio_sim_csharp.Utility
{
    public class OpenAl
    {
        private static int _sourceId = 0;
        private static int _bufferId = 0;
        private static int _contextId = 1;
        
        public static void SetPosition(float x, float y, float z)
        {
        }
        
        public static void SetOrientation(float[] values)
        {
        }
        
        public static void SetValue()
        {
        }

        public static int AlGenSources() => ++_sourceId;

        public static int AlGenBuffer() => ++_bufferId;

        public static void AlSource3f(int id, float x, float y, float z)
        {
        }

        public static void AlPlay(int id)
        {
        }
        
        public static void AlPause(int id)
        {
        }
        
        public static void AlStop(int id)
        {
        }

        public static void AlSourcei(int buffer)
        {
        }

        public static void AlDeleteSources(int id)
        {
        }
        public static void AlBufferData(int id, int sampleSize, MemoryStream buffer, int sampleRate)
        {
        }

        public static void ApplyFilter(IFrSource s, SourceType type)
        {
        }

        public static int GetContextID() => _contextId;
    }
}