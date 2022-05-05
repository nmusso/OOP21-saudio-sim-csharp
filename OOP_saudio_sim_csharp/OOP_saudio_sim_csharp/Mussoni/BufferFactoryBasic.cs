using System;
using System.Collections.Generic;
using System.Text;

namespace Buffer
{
    public class BufferFactoryBasic : IBufferFactory
    {
        public IBuffer CreateBufferFromPath(string file) => new PathBuffer(file);

        public IBuffer CreateBufferFromResource(string file) => new ResourceBuffer(file);
    }
}
