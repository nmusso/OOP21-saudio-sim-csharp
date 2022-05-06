using System.Collections.Generic;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public class SourcesHubFactory : ISourcesHubFactory
    {
        public SourcesHub CreateSourcesHub() => new SourcesHub();

        public SourcesHub CreateSourcesHubFromSet(IList<IFrSource> sources) => new SourcesHub(sources);
    }
}