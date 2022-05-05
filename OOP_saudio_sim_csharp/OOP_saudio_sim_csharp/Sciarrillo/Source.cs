namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public class Source : ISource
    {
        public int Position { get; set; } //lib
        public int Id { get; }
        public bool IsPlaying { get; private set; }

        public Source()
        {
            Id = 0; //lib
            Position = 0; //lib
        }
        
        public Source(int position)
        {
            Id = 0; //lib
            Position = position; //lib
        }

        public void Play()
        {
            IsPlaying = true;
            //lib call
        }

        public void Pause()
        {
            IsPlaying = false;
            //lib call
        }

        public void Stop()
        {
            IsPlaying = false;
            //lib call
        }

        public void GenerateSource(int buffer)
        {
            //lib call
        }

        public void Delete()
        {
            //lib call
        }
    }
}