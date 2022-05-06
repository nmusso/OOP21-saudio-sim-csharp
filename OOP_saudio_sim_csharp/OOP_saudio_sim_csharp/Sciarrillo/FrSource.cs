using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public class FrSource : Source, IFrSource
    {
        private SourceType _type;

        public SourceType Type
        {
            get => _type;
            set
            {
                _type = value;
                OpenAl.ApplyFilter(this,value);
            } 
        }

        public FrSource(SourceType type)
        {
            Type = type;
        }

        public FrSource(Vec3F position, SourceType type) : base(position)
        {
            Type = type;
        }
    }
}