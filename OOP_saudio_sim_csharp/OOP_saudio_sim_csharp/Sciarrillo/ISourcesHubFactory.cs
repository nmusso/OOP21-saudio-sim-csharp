using System.Collections.Generic;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public interface ISourcesHubFactory
    {
        SourcesHub CreateSourcesHub();
        
        SourcesHub CreateSourcesHubFromSet(IList<IFrSource> sources);
    }
}