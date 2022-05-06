using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_saudio_sim_csharp.Lugaresi
{
    public class SpaceFactory : ISpaceFactory
    {
        private const float Dim = 10;
        public ISpace CreateDefaultSpace() => new Space(Dim, Dim);

        public ISpace CreateCustomizedSpace(float x, float y) => new Space(x, y);
    }
}