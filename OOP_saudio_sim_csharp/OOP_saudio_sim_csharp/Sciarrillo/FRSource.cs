namespace OOP_saudio_sim_csharp.Sciarrillo
{
    public class FRSource : Source, IFRSource
    {
        public SourceType Type { get; set; }
        
        public FRSource(SourceType type) : base()
        {
        }

        public FRSource(int position, SourceType type) : base(position)
        {
        }
    }
}