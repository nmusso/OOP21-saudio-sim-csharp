using NUnit.Framework;
using OOP_saudio_sim_csharp.Presepi;
using OOP_saudio_sim_csharp.Sciarrillo;
using OOP_saudio_sim_csharp.Lugaresi;
using System.Collections.Generic;

namespace Test
{
    class TestEnvironment
    {
        private readonly IList<IFrSource> _sources = new List<IFrSource>();
        private readonly ISourcesHubFactory _shFac = new SourcesHubFactory();
        private readonly ISourceFactory _sourceFac = new SourceFactory();
        private readonly IListenerFactory _listenerFactory = new ListenerFactory();
        private IListener _listener;
        private readonly IEnvironmentFactory envFac = new EnvironmentFactory();

        [SetUp]
        public void Setup()
        {
            _listener = _listenerFactory.CreateListener(new Context());
        }

        [Test]
        public void TestSimplePlayStop()
        {
            this._sources.Add(this._sourceFac.CreateDefaultFrSource());
            this._sources.Add(this._sourceFac.CreateDefaultFrSource());
            IEnvironment env = envFac.CreateNEnvironment(new List<IFrSource>(this._sources), _listener);

            env.Sources.PlayAll();
            Assert.AreEqual(env.Sources.GetPlaying(), this._sources);
            env.Sources.StopAll();
            Assert.AreNotEqual(env.Sources.GetPlaying(), this._sources);
        }

        [Test]
        public void TestAddSource()
        {
            this._sources.Add(this._sourceFac.CreateDefaultFrSource());
            this._sources.Add(this._sourceFac.CreateDefaultFrSource());
            IEnvironment env = envFac.CreateNEnvironment(new List<IFrSource>(this._sources), _listener);

            Assert.AreEqual(env.Sources.GetAll().Count, this._sources.Count);
            env.Sources.AddSource(this._sourceFac.CreateDefaultFrSource());
            Assert.AreEqual(env.Sources.GetAll().Count, this._sources.Count +1);
        }

        [Test]
        public void TestGetX()
        {
            IFrSource source1 = this._sourceFac.CreateDefaultFrSource();
            IFrSource source2 = this._sourceFac.CreateDefaultFrSource();
            IFrSource source3 = this._sourceFac.CreateDefaultFrSource();

            this._sources.Add(source1);
            this._sources.Add(source2);
            this._sources.Add(source3);
            IEnvironment env = envFac.CreateNEnvironment(new List<IFrSource>(this._sources), _listener);

            Assert.AreEqual(env.Sources.GetSource(source1.Id), source1);
            Assert.AreEqual(env.Sources.GetSource(source3.Id), source3);
            Assert.AreNotEqual(env.Sources.GetSource(source1.Id), source3);
        }

        [Test]
        public void TestListener()
        {
            this._sources.Add(this._sourceFac.CreateDefaultFrSource());
            this._sources.Add(this._sourceFac.CreateDefaultFrSource());
            IEnvironment env = envFac.CreateNEnvironment(new List<IFrSource>(this._sources), _listener);

            Assert.AreEqual(env.Listener, _listener);
        }
    }
}
