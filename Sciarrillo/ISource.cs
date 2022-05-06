using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public interface ISource
    {
        Vec3F Position { get; set; }
        int Id { get; }
        bool IsPlaying { get; }
        
        void Play();

        void Pause();

        void Stop();

        void GenerateSource(int buffer);

        void Delete();
    }
}