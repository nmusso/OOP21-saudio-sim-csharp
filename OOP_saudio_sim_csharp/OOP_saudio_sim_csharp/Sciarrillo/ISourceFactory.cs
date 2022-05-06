using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public interface ISourceFactory
    {
        Source CreateSource();
        
        Source CreateSourceWithPosition(Vec3F position);
        
        FrSource CreateDefaultFrSource();
        
        FrSource CreateFrSource(SourceType type);
        
        FrSource CreateFrSourceWithPosition(Vec3F position, SourceType type);
    }
}