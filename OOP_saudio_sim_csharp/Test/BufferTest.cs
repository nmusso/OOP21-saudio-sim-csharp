using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Buffer
{
    [TestClass]
    public class BufferTest
    {
        const string PATH = "dir";

        [TestMethod]
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

        [TestMethod]
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

        /*[TestMethod]
        public void TestGetFromCache()
        {
            IBufferFactory factory = new BufferFactoryWithCache();

            IBuffer buffer = factory.CreateBufferFromPath(PATH);
            Assert.AreNotEqual(0, buffer.GetID());

            int same = buffer.GetID();
            buffer = factory.CreateBufferFromPath(PATH);
            Assert.AreEqual(same, buffer.GetID()); 
            
            same = buffer.GetID();
            buffer = factory.CreateBufferFromPath(PATH);
            Assert.AreEqual(same, buffer.GetID());
        }*/
    }
}
