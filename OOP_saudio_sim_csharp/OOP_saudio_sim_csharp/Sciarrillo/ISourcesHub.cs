#nullable enable
using System.Collections.Generic;
using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public interface ISourcesHub
    {
        IList<IFrSource> GetAll();

        IList<Vec3F> GetAllPositions();

        IList<IFrSource> GetPlaying();

        IFrSource? GetSource(int id);

        IFrSource? GetSourceFromPos(Vec3F position);

        void AddSource(IFrSource s);

        void RemoveSource(IFrSource s);

        void PlayAll();

        void PauseAll();

        void StopAll();

        void GenerateAllSources(int buffer);

        void DeleteALl();
    }
}