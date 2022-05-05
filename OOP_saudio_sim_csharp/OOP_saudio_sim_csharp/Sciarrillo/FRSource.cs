using System.Runtime.InteropServices;
using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public class FRSource : Source, IFRSource
    {
        private SourceType _type;

        public SourceType Type
        {
            get => _type;
            set
            {
                _type = value;
                OpenAl.ApplyFilter(this,value);
            } 
        }

        public FRSource(SourceType type) : base()
        {
            Type = type;
        }

        public FRSource(Vec3F position, SourceType type) : base(position)
        {
            Type = type;
        }
    }
}