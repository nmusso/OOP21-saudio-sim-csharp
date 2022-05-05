#nullable enable
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public class SourcesHub : ISourcesHub
    {
        private readonly IList<IFRSource> _sources;

        public SourcesHub()
        {
            _sources = new List<IFRSource>();
        }
        
        public SourcesHub(IList<IFRSource> sources)
        {
            _sources = new List<IFRSource>();
            _sources = sources;
        }

        public IList<IFRSource> GetAll()
        {
            return new ReadOnlyCollection<IFRSource>(_sources);
        }

        public IList<Vec3F> GetAllPositions()
        {
            return  _sources.Select(x => x.Position).ToList().AsReadOnly();
        }

        public IList<IFRSource> GetPlaying()
        {
            return _sources.Where(x=>x.IsPlaying.Equals(true)).ToList().AsReadOnly();
        }

        public IFRSource? GetSource(int id)
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

        public IFRSource? GetSourceFromPos(Vec3F position)
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

        public void AddSource(IFRSource s)
        {
            if (!_sources.Contains(s))
            {
                _sources.Add(s);
            }
        }

        public void RemoveSource(IFRSource s)
        {
            _sources.Remove(s);
        }

        public void PlayAll()
        {
            _sources.ToList().ForEach(x=>x.Play());
        }

        public void PauseAll()
        {
            _sources.ToList().ForEach(x=>x.Pause());
        }

        public void StopAll()
        {
            _sources.ToList().ForEach(x=>x.Stop());
        }

        public void GenerateAllSources(int buffer)
        {
            _sources.ToList().ForEach(x=>x.GenerateSource(buffer));
        }

        public void DeleteALl()
        {
            _sources.ToList().ForEach(x=>x.Delete());
            _sources.Clear();
        }
    }
}