using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public class Source : ISource
    {
        private Vec3F _position;
        public Vec3F Position
        {
            get => _position;
            set
            {
                _position = value;
                OpenAl.alSource3f(Id,value.X,value.Y,value.Z);
            }
        }
        public int Id { get; }
        public bool IsPlaying { get; private set; }

        public Source()
        {
            Id = OpenAl.alGenSources();
            Position = new Vec3F(0.0f);
        }
        
        public Source(Vec3F position)
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