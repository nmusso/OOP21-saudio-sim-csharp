using NUnit.Framework;
using OOP_saudio_sim_csharp.Lugaresi;
using OOP_saudio_sim_csharp.Utility;
using System.Collections.Generic;

namespace Test
{

    public class TestSpace
    {
        private static readonly Vec3F _Center = new Vec3F(5f);
        private readonly ISpaceFactory _spaceFac = new SpaceFactory();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetLimit()
        {
            ISpace spc = _spaceFac.CreateDefaultSpace();
            Assert.AreEqual(spc.XMax, 10f);
            spc.YMax = 0f;
            Assert.AreNotEqual(spc.YMax, 10f);
        }

        [Test]
        public void TestBorder()
        {
            ISpace spc = _spaceFac.CreateDefaultSpace();
            Assert.IsFalse(spc.IsAvailable(new Vec3F(_Center.X * _Center.X), new List<Vec3F>()));
            Assert.IsTrue(spc.IsAvailable(_Center, new List<Vec3F>()));
        }

        [Test]
        public void TesBusyPos()
        {
            ISpace spc = _spaceFac.CreateDefaultSpace();
            List<Vec3F> listPos = new List<Vec3F>();

            Assert.IsTrue(spc.IsAvailable(_Center, listPos));
            listPos.Add(_Center);
            Assert.IsFalse(spc.IsAvailable(_Center, listPos));
        }

    }
}
