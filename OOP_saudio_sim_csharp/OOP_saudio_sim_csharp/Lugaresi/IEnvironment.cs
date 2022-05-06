using System;
using System.Collections.Generic;
using System.Text;
using OOP_saudio_sim_csharp.Mussoni;
using OOP_saudio_sim_csharp.Presepi;
using OOP_saudio_sim_csharp.Sciarrillo;
using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Lugaresi
{
    public interface IEnvironment
    {
        ISourcesHub Sources { get; }

        IListener Listener { get; }

        ISpace Space { get; }

        void AddSourceToSourcesHub(IFrSource source);

        void RemoveSourceFromSourcesHub(IFrSource sourceToRemove);

        void MoveSource(IFrSource source, Vec3F pos);

    }
}
