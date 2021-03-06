using System.Linq;
using NUnit.Framework;
using OOP_saudio_sim_csharp.Presepi;
using OOP_saudio_sim_csharp.Sciarrillo;
using OOP_saudio_sim_csharp.Utility;

namespace Test
{
    public class TestListener
    {
        private readonly IListenerFactory _lsFactory = new ListenerFactory();
        

        [Test]
        public void TestDefaultPosition()
        {
            IListener listener = _lsFactory.CreateListener(new Context());
            Assert.AreEqual(listener.Position, new Vec3F(0.0f));
            Assert.AreEqual(listener.AtOrientation, new Vec3F(0.0f, 1.0f, 0.0f));
            Assert.AreEqual(listener.UpOrientation, new Vec3F(0.0f, 0.0f ,-1.0f));
            
            var position = new Vec3F(2.0f); 
            listener.Position = position;
            Assert.AreEqual(listener.Position, position);
            
        }

        [Test]
        public void TestOrientation()
        {
            IListener listener = _lsFactory.CreateListener(new Context());
            var atLin = new Vec3F(1.0f, 0.0f, 0.0f);
            var upLin = new Vec3F(0.0f, 0.0f, 1.0f);
            
            listener.SetOrientation(upLin, atLin);
            Assert.AreEqual(listener.AtOrientation, atLin);
            Assert.AreEqual(listener.UpOrientation, upLin);

        }

        [Test]
        public void TestFactory()
        {
            var context = new Context();
            IListener listener = _lsFactory.CreateListener(context);
            IListener listener2 = _lsFactory.CreateListener(context);
            var pos = new Vec3F(3.0f);
            
            Assert.AreEqual(listener, listener2);

            listener = _lsFactory.CreateListenerWithPos(context, pos);
            Assert.AreEqual(listener.Position, pos);

            var at = new Vec3F(2.0f, 0.0f, 0.0f);
            var up = new Vec3F(0.0f, 1.0f, 1.0f);
            listener2 = _lsFactory.CreateListenerOriented(context, pos, up, at);
            
            Assert.AreEqual(listener2.Position, pos);
            Assert.AreEqual(listener2.AtOrientation, at);
            Assert.AreEqual(listener2.UpOrientation, up);

        }

        [Test]
        public void TestAddRemovePlugin()
        {
            IListener listener = _lsFactory.CreateListener(new Context());
            var mng = new PluginManager();
            var soundL = new SoundLevelMeterPlugin(listener);
            
            mng.AddPlugin(soundL);
            Assert.True(mng.GetPlugins().Contains(soundL));
            Assert.IsNotEmpty(mng.GetPlugins());
            
            mng.RemovePlugin(soundL);
            Assert.IsEmpty(mng.GetPlugins());
            
            mng.AddPlugin(soundL);
            mng.AddPlugin(soundL);
            Assert.AreEqual(mng.GetPlugins().Count, 1);
        }

        [Test]
        public void TestEnableDisablePlugin()
        {
            IListener listener = _lsFactory.CreateListener(new Context());
            var mng = new PluginManager();
            var soundL = new SoundLevelMeterPlugin(listener);

            mng.AddPlugin(soundL);
            
            mng.DisableAll();
            mng.GetPlugins().ToList().ForEach(p => Assert.False(p.IsEnabled));
            
            soundL.Enable();
            Assert.True(mng.GetPlugins().First(p => p.Equals(soundL)).IsEnabled);
            
        }

        [Test]
        public void TestSoundLevelMeterPlugin()
        {
            const int maxBit = 255;
            IListener listener = _lsFactory.CreateListener(new Context());
            var plugin = new SoundLevelMeterPlugin(listener);
            ISourceFactory sourceFac = new SourceFactory();
            ISourcesHubFactory sourcesFac = new SourcesHubFactory();
            ISourcesHub sources = sourcesFac.CreateSourcesHub();
            
            Assert.True(plugin.IsEnabled);
            Assert.IsNull(plugin.Sources);
            Assert.AreEqual(plugin.GetRgbColor(), new Vec3F(maxBit));
            
            listener.Position = new Vec3F(2.0f);
            IFrSource source = sourceFac.CreateFrSourceWithPosition(new Vec3F(2.0f), SourceType.Full);
            sources.AddSource(source);
            
            plugin.Sources = sources;
            Assert.IsNotNull(plugin.Sources);
            Assert.AreEqual(plugin.GetRgbColor(), new Vec3F(maxBit));
            
            source.Play();
            Assert.AreEqual(plugin.GetRgbColor(), new Vec3F(maxBit, 0.0f, 0.0f));
            
            plugin.Disable();
            Assert.False(plugin.IsEnabled);
            Assert.AreEqual(plugin.GetRgbColor(), new Vec3F(maxBit));
            
        }

    }
}