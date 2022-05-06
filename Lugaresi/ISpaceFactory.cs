using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_saudio_sim_csharp.Lugaresi
{
    public interface ISpaceFactory 
    {
        ISpace CreateDefaultSpace();

        ISpace CreateCustomizedSpace(float x, float y);
    }
}