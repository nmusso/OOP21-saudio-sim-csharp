using OOP_saudio_sim_csharp.Presepi;
using OOP_saudio_sim_csharp.Sciarrillo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_saudio_sim_csharp.Lugaresi
{
    public class EnvironmentFactory : IEnvironmentFactory
    {
        private readonly IListenerFactory listenerFac = new ListenerFactory();
        private readonly ISpaceFactory spcFac = new SpaceFactory();
        private readonly ISourcesHubFactory shFac = new SourcesHubFactory();

        public IEnvironment CreateNEnvironment(IList<IFrSource> sources, IListener listener, ISpace spc = null) => new Environment(shFac.CreateSourcesHubFromSet(sources), listenerFac.CreateListener(new Context()), spcFac.CreateDefaultSpace());

        public IEnvironment CreateVoidEnvironment() => new Environment(shFac.CreateSourcesHub(), listenerFac.CreateListener(new Context()), spcFac.CreateDefaultSpace());
    }
}
