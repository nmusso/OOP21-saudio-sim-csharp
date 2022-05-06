using System;
using System.Collections.Generic;
using System.Text;
using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Lugaresi
{
    public interface ISpace
    {
        float XMax { get; set; }

        float YMax { get; set; }

        bool IsAvailable(Vec3F pos, List<Vec3F> position);
    }
}
