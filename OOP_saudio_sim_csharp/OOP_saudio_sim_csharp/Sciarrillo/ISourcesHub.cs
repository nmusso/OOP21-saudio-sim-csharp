using System.Collections.Generic;
using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public interface ISourcesHub
    {
        ISet<FRSource> GetAll();

        IList<Vec3F> GetAllPositions();

        ISet<FRSource> GetPlaying();

        FRSource? GetSource(int id);

        FRSource? GetSourceFromPos(Vec3F position);

        void AddSource(FRSource s);

        void RemoveSource(FRSource s);

        void PlayAll();

        void PauseAll();

        void StopAll();

        void GenerateAllSources(int buffer);

        void DeleteALl();
    }
}