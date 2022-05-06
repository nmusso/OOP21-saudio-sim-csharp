using System.Collections.Generic;
using NUnit.Framework;
using OOP_saudio_sim_csharp.Sciarrillo;
using OOP_saudio_sim_csharp.Utility;

namespace Test
{
    public class TestSources
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBasicPlayPauseStop()
        {
            ISourceFactory sf = new SourceFactory();
            ISource s = sf.CreateSource();

            s.Play();
            Assert.True(s.IsPlaying);
            s.Pause();
            Assert.False(s.IsPlaying);
            s.Play();
            s.Stop();
            Assert.False(s.IsPlaying);
        }
        
        [Test]
        public void TestAdvancedPlayPauseStop()
        {
            ISourceFactory sf = new SourceFactory();
            ISource s = sf.CreateSource();
            
            s.Play();
            s.Pause();
            s.Play();
            Assert.True(s.IsPlaying);
            s.Stop();
            s.Play();
            Assert.True(s.IsPlaying);
            s.Pause();
            s.Stop();
            s.Play();
            Assert.True(s.IsPlaying);
        }
        
        [Test]
        public void TestBasicChangePosition()
        {
            const float x = 1.0f;
            const float y = -10.0f;
            const float z = 0.5f;
            ISourceFactory sf = new SourceFactory();
            
            ISource s = sf.CreateDefaultFrSource();
            Assert.AreEqual(s.Position, new Vec3F(0.0f));
            var pos = new Vec3F(x, y, z);
            s.Position = pos;
            Assert.AreEqual(s.Position, pos);
        }
        
        [Test]
        public void TestBasicFrSource()
        {
            ISourceFactory sf = new SourceFactory();
            IFrSource frs = sf.CreateDefaultFrSource();
            
            Assert.AreEqual(frs.Type, SourceType.Full);
            frs.Type = SourceType.High;
            Assert.AreEqual(frs.Type, SourceType.High);
            frs.Type = SourceType.Mid;
            Assert.AreEqual(frs.Type, SourceType.Mid);
            frs.Type = SourceType.Low;
            Assert.AreEqual(frs.Type, SourceType.Low);
        }
        
        [Test]
        public void TestAdvancedFrSource()
        {
            ISourceFactory sf = new SourceFactory();
            IFrSource frs = sf.CreateDefaultFrSource();
            
            frs.Type=SourceType.High;
            Assert.AreEqual(frs.Type, SourceType.High);
            frs.Type = SourceType.Full;
            Assert.AreEqual(frs.Type, SourceType.Full);
            frs.Type = SourceType.Low;
            Assert.AreEqual(frs.Type, SourceType.Low);
            frs.Type = SourceType.Low;
            Assert.AreEqual(frs.Type, SourceType.Low);
            frs.Type = SourceType.Full;
            Assert.AreEqual(frs.Type, SourceType.Full);
        }
        
        [Test]
        public void TestSourcesHub()
        {
            ISourcesHubFactory sfHub = new SourcesHubFactory();
            ISourceFactory sf = new SourceFactory();
            
            ISourcesHub sHub = sfHub.CreateSourcesHub();
            IFrSource s1 = sf.CreateDefaultFrSource();
            IFrSource s2 = sf.CreateDefaultFrSource();
            IFrSource s3 = sf.CreateDefaultFrSource();

            var origin = new Vec3F(0.0f);
            var fiveV = new Vec3F(5.0f);
            
            sHub.AddSource(s1);
            sHub.AddSource(s2);
            sHub.AddSource(s3);
            
            Assert.AreEqual(sHub.GetAll(), new List<IFrSource>() { s1, s2, s3 });
            Assert.AreEqual(sHub.GetAllPositions(), new List<Vec3F>() { origin, origin, origin });
            
            sHub.PlayAll();
            Assert.AreEqual(sHub.GetPlaying(), new List<IFrSource>() { s1, s2, s3 });
            sHub.PauseAll();
            Assert.IsEmpty(sHub.GetPlaying());
            sHub.PlayAll();
            Assert.AreEqual(sHub.GetPlaying(), new List<IFrSource>() { s1, s2, s3 });
            sHub.StopAll();
            Assert.IsEmpty(sHub.GetPlaying());

            Assert.AreEqual(sHub.GetSourceFromPos(fiveV), null);
            s3.Position = fiveV;
            Assert.AreEqual(sHub.GetSourceFromPos(fiveV), s3);
            Assert.AreEqual(sHub.GetSource(s3.Id), s3);
            
            sHub.RemoveSource(s3);
            Assert.AreEqual(sHub.GetSourceFromPos(fiveV), null);
            Assert.AreEqual(sHub.GetSource(s3.Id), null);
            
            sHub.DeleteALl();
            Assert.IsEmpty(sHub.GetAll());
        }
    }
}