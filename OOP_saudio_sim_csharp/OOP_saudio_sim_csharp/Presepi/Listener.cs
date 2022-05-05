using  OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Presepi
{
    public class Listener:IListener
    {
        public Context CurrentContext { get; private set; }
        
        private Vec3F _position;
        public Vec3F Position
        {
            get => _position;
            set
            {
                _position = value;
                //OpenAL.SetPosition(_position);
            }
        }
        
        private Vec3F _atOrientation;
        public Vec3F AtOrientation
        {
            get => _atOrientation;
            set
            {
                _atOrientation = value;
                //OpenAL.SetOrientation(null); /*TODO rivedere*/
            }
        }

        public Vec3F UpOrientation { get; private set; }

        public Listener(Context context, Vec3F position, Vec3F up, Vec3F at)
        {
            CurrentContext = context;
            Position = position;
            SetOrientation(up, at);
            //OpenAL.SetValue();
        }
        public Listener(Context context, Vec3F position) : this(context, position, new Vec3F(0.0f, 0.0f, -1.0f), new Vec3F(0.0f, 1.0f, 0.0f))
        {
        }

        public Listener(Context context) : this(context, new Vec3F(0.0f))
        {
        }
        
        public void SetOrientation(Vec3F up, Vec3F at)
        {
            AtOrientation = at;
            UpOrientation = up;
            float[] atUpVec = { this.UpOrientation.X, this.UpOrientation.Y, this.UpOrientation.Z,
                this.AtOrientation.X, this.AtOrientation.Y, this.AtOrientation.Z };
            //OpenAL.SetOrientation(atUpVec);
        }
    }
}