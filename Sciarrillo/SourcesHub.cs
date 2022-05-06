#nullable enable
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public class SourcesHub : ISourcesHub
    {
        private readonly IList<IFrSource> _sources;

        public SourcesHub()
        {
            _sources = new List<IFrSource>();
        }
        
        public SourcesHub(IEnumerable<IFrSource> sources)
        {
            _sources = new List<IFrSource>(sources);
        }

        public IList<IFrSource> GetAll() => _sources.ToImmutableList();

        public IList<Vec3F> GetAllPositions() => _sources.Select(x => x.Position).ToList().ToImmutableList();
        
        public IList<IFrSource> GetPlaying() => _sources.Where(x=>x.IsPlaying.Equals(true)).ToList().ToImmutableList();
        
        public IFrSource? GetSource(int id)
        {
            try
            {
                return _sources.First(x => x.Id.Equals(id));
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public IFrSource? GetSourceFromPos(Vec3F position)
        {
            try
            {
                return _sources.First(x => x.Position.Equals(position));
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public void AddSource(IFrSource s)
        {
            if (!_sources.Contains(s))
            {
                _sources.Add(s);
            }
        }

        public void RemoveSource(IFrSource s) => _sources.Remove(s);

        public void PlayAll() => _sources.ToList().ForEach(x=>x.Play());

        public void PauseAll() => _sources.ToList().ForEach(x=>x.Pause());

        public void StopAll() => _sources.ToList().ForEach(x=>x.Stop());
        
        public void GenerateAllSources(int buffer) => _sources.ToList().ForEach(x=>x.GenerateSource(buffer));

        public void DeleteALl()
        {
            _sources.ToList().ForEach(x=>x.Delete());
            _sources.Clear();
        }
    }
}