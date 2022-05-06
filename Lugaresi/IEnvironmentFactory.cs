using System;
using System.Collections.Generic;
using System.Text;
using OOP_saudio_sim_csharp.Presepi;
using OOP_saudio_sim_csharp.Sciarrillo;

namespace OOP_saudio_sim_csharp.Lugaresi
{
    public interface IEnvironmentFactory
    {
        IEnvironment CreateVoidEnvironment();

        IEnvironment CreateNEnvironment(IList<IFrSource> sources, IListener listener, ISpace spc = null);
    }
}
