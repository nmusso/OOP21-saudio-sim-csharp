using System.Collections.Generic;
using System.Runtime.InteropServices;
using OOP_saudio_sim_csharp.Sciarrillo;

namespace OOP_saudio_sim_csharp.Utility
{
    public class OpenAl
    {
        private static int _sourceId = 0;
        
        public static void SetPosition(float x, float y, float z)
        {
        }
        
        public static void SetOrientation(float[] values)
        {
        }
        
        public static void SetValue()
        {
        }

        public static int AlGenSources()
        {
            return _sourceId++;
        }

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

        public static void ApplyFilter(IFRSource s, SourceType type)
        {
        }
    }
}