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
                OpenAl.AlSource3f(Id,value.X,value.Y,value.Z);
            }
        }
        public int Id { get; }
        public bool IsPlaying { get; private set; }

        public Source()
        {
            Id = OpenAl.AlGenSources();
            Position = new Vec3F(0.0f);
        }
        
        public Source(Vec3F position)
        {
            Id = OpenAl.AlGenSources();
            Position = position;
        }

        public void Play()
        {
            IsPlaying = true;
            OpenAl.AlPlay(Id);
        }

        public void Pause()
        {
            IsPlaying = false;
            OpenAl.AlPause(Id);
        }

        public void Stop()
        {
            IsPlaying = false;
            OpenAl.AlStop(Id);
        }

        public void GenerateSource(int buffer)
        {
            OpenAl.AlSourcei(buffer);
        }

        public void Delete()
        {
            OpenAl.AlDeleteSources(Id);
        }
    }
}