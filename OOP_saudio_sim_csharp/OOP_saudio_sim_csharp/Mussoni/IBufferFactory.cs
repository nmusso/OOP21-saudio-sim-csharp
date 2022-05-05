using System;
using System.Collections.Generic;
using System.Text;

namespace Buffer
{
    public interface IBufferFactory
    {
        IBuffer CreateBufferFromPath(string file);
        IBuffer CreateBufferFromResource(string file);
    }
}
