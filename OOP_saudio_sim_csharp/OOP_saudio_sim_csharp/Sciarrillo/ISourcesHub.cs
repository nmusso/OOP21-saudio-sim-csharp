#nullable enable
using System.Collections.Generic;
using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public interface ISourcesHub
    {
        IList<IFRSource> GetAll();

        IList<Vec3F> GetAllPositions();

        IList<IFRSource> GetPlaying();

        IFRSource? GetSource(int id);

        IFRSource? GetSourceFromPos(Vec3F position);

        void AddSource(IFRSource s);

        void RemoveSource(IFRSource s);

        void PlayAll();

        void PauseAll();

        void StopAll();

        void GenerateAllSources(int buffer);

        void DeleteALl();
    }
}