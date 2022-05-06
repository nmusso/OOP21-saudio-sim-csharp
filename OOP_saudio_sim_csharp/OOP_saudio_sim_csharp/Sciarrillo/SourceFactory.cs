using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public class SourceFactory : ISourceFactory
    {
        public Source CreateSource() => new Source();
        
        public Source CreateSourceWithPosition(Vec3F position) => new Source(position);

        public FrSource CreateDefaultFrSource() => new FrSource(SourceType.Full);

        public FrSource CreateFrSource(SourceType type) => new FrSource(type);

        public FrSource CreateFrSourceWithPosition(Vec3F position, SourceType type) => new FrSource(position, type);
    }
}