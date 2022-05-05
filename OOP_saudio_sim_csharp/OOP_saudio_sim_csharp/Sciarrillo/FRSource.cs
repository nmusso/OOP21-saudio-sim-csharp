using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public class FRSource : Source, IFRSource
    {
        public SourceType Type { get; set; }
        
        public FRSource(SourceType type) : base()
        {
        }

        public FRSource(Vec3F position, SourceType type) : base(position)
        {
        }
    }
}