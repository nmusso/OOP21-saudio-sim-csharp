namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public interface ISource
    {
        int Position { get; set; }
        int Id { get; }
        bool IsPlaying { get; }
        
        void Play();

        void Pause();

        void Stop();

        void GenerateSource(int buffer);

        void Delete();
    }
}