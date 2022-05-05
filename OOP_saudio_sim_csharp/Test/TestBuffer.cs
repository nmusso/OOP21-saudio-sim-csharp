using NUnit.Framework;
using OOP_saudio_sim_csharp.Mussoni;

namespace Test
{
    public class TestBuffer
    {
        const string PATH = "";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateFromPath()
        {
            IBufferFactory factory = new BufferFactoryBasic();

            IBuffer buf = factory.CreateBufferFromPath(PATH);
            Assert.AreNotEqual(0, buf.GetID());
            buf = factory.CreateBufferFromPath(PATH);
            Assert.AreNotEqual(0, buf.GetID());
            buf = factory.CreateBufferFromPath(PATH);
            Assert.AreNotEqual(0, buf.GetID());
            buf = factory.CreateBufferFromPath(PATH);
            Assert.AreNotEqual(0, buf.GetID());
        }

        [Test]
        public void TestCreateFromResource()
        {
            IBufferFactory factory = new BufferFactoryBasic();

            IBuffer buf = factory.CreateBufferFromResource(PATH);
            Assert.AreNotEqual(0, buf.GetID());
            buf = factory.CreateBufferFromResource(PATH);
            Assert.AreNotEqual(0, buf.GetID());
            buf = factory.CreateBufferFromResource(PATH);
            Assert.AreNotEqual(0, buf.GetID());
            buf = factory.CreateBufferFromResource(PATH);
            Assert.AreNotEqual(0, buf.GetID());
        }
    }
}