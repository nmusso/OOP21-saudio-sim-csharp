using NUnit.Framework;
using OOP_saudio_sim_csharp.Mussoni;
using System.IO;

namespace Test
{
    public class TestBuffer
    {
        public static readonly string Path = "";

        [Test]
        public void TestCreateFromPath()
        {
            IBufferFactory factory = new BufferFactoryBasic();

            IBuffer buf = factory.CreateBufferFromPath(Path);
            Assert.AreNotEqual(0, buf.ID);
            buf = factory.CreateBufferFromPath(Path);
            Assert.AreNotEqual(0, buf.ID);
            buf = factory.CreateBufferFromPath(Path);
            Assert.AreNotEqual(0, buf.ID);
            buf = factory.CreateBufferFromPath(Path);
            Assert.AreNotEqual(0, buf.ID);
        }

        [Test]
        public void TestCreateFromResource()
        {
            IBufferFactory factory = new BufferFactoryBasic();

            IBuffer buf = factory.CreateBufferFromResource(Path);
            Assert.AreNotEqual(0, buf.ID);
            buf = factory.CreateBufferFromResource(Path);
            Assert.AreNotEqual(0, buf.ID);
            buf = factory.CreateBufferFromResource(Path);
            Assert.AreNotEqual(0, buf.ID);
            buf = factory.CreateBufferFromResource(Path);
            Assert.AreNotEqual(0, buf.ID);
        }
    }
}