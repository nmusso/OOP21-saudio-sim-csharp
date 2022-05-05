using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_saudio_sim_csharp.Mussoni
{
    public interface IBufferFactory
    {
        IBuffer CreateBufferFromPath(string file);
        IBuffer CreateBufferFromResource(string file);
    }
}
