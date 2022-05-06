using OOP_saudio_sim_csharp.Presepi;
using OOP_saudio_sim_csharp.Sciarrillo;
using OOP_saudio_sim_csharp.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_saudio_sim_csharp.Lugaresi
{
    public class Environment : IEnvironment
    {
        public ISourcesHub Sources { get; }

        public IListener Listener { get; }

        public ISpace Space { get; }

        public Environment(ISourcesHub sh, IListener listener, ISpace spc)
        {
            this.Sources = sh;
            this.Listener = listener;
            this.Space = spc;
        }

        public void AddSourceToSourcesHub(IFrSource source) => this.Sources.AddSource(source);

        public void MoveSource(IFrSource source, Vec3F pos)
        {
            try
            {
                this.Sources.GetSource(source.Id).Position = pos;
            }
            catch (InvalidOperationException) { }
        }

        public void RemoveSourceFromSourcesHub(IFrSource sourceToRemove)
        {
            this.Sources.RemoveSource(sourceToRemove);
            sourceToRemove.Delete();
        }
    }
}
