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
            ISource s = new Source();
            
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
            ISource s = new Source();
            
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
            float x = 1.0f;
            float y = -10.0f;
            float z = 0.5f;

            ISource s = new Source(new Vec3F(0.0f));
            Assert.Equals(s.Position, new Vec3F(0.0f)); //TODO fix equals in Vec3F
            Vec3F pos = new Vec3F(x, y, z);
            s.Position = pos;
            Assert.Equals(s.Position, pos);
        }
        
        [Test]
        public void TestBasicFRSource() //TODO implement equals in SourceType
        {
            IFRSource frs = new FRSource(SourceType.Full);
            
            Assert.Equals(frs.Type, SourceType.Full);
            frs.Type = SourceType.High;
            Assert.Equals(frs.Type, SourceType.High);
            frs.Type = SourceType.Mid;
            Assert.Equals(frs.Type, SourceType.Mid);
            frs.Type = SourceType.Low;
            Assert.Equals(frs.Type, SourceType.Low);
        }
        
        [Test]
        public void TestAdvancedFRSource()
        {
            IFRSource frs = new FRSource(SourceType.Full);
            
            frs.Type=SourceType.High;
            Assert.Equals(frs.Type, SourceType.High);
            frs.Type = SourceType.Full;
            Assert.Equals(frs.Type, SourceType.Full);
            frs.Type = SourceType.Low;
            Assert.Equals(frs.Type, SourceType.Low);
            frs.Type = SourceType.Low;
            Assert.Equals(frs.Type, SourceType.Low);
            frs.Type = SourceType.Full;
            Assert.Equals(frs.Type, SourceType.Full);
        }
        
        [Test]
        public void TestSourcesHub()
        {
            ISourcesHub sHub = new SourcesHub();
             //TODO

        }
        
    }
}