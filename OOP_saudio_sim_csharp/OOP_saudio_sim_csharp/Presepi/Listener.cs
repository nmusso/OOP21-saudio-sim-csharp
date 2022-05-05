using System.Net.WebSockets;

namespace OOP_presepi_csharp
{
    public class Listener:IListener
    {
        public Context CurrentContext { get; private set; }
        
        private Vec3f _position;
        public Vec3f Position
        {
            get => _position;
            set
            {
                _position = value;
                OpenAL.SetPosition(_position);
            }
        }
        
        private Vec3f _atOrientation;
        public Vec3f AtOrientation
        {
            get => _atOrientation;
            set
            {
                _atOrientation = value;
                OpenAL.SetOrientation(null); /*TODO rivedere*/
            }
        }

        public Vec3f UpOrientation { get; private set; }

        public Listener(Context context, Vec3f position, Vec3f up, Vec3f at)
        {
            CurrentContext = context;
            Position = position;
            SetOrientation(up, at);
            OpenAL.SetValue();
        }
        public Listener(Context context, Vec3f position) : this(context, position, new Vec3f(0.0f, 0.0f, -1.0f), new Vec3f(0.0f, 1.0f, 0.0f))
        {
        }

        public Listener(Context context) : this(context, new Vec3f(0.0f))
        {
        }
        
        public void SetOrientation(Vec3f up, Vec3f at)
        {
            AtOrientation = at;
            UpOrientation = up;
            float[] atUpVec = { this.UpOrientation.X, this.UpOrientation.Y, this.UpOrientation.Z,
                this.AtOrientation.X, this.AtOrientation.Y, this.AtOrientation.Z };
            OpenAL.SetOrientation(atUpVec);
        }
    }
}