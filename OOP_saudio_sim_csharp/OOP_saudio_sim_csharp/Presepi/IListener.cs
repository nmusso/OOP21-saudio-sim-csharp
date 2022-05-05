namespace OOP_presepi_csharp
{
    public interface IListener
    {
        Context CurrentContext { get; }
        Vec3f Position { get; set; }
        
        void SetOrientation(Vec3f up, Vec3f at);
        
        Vec3f AtOrientation { get; set; }

        Vec3f UpOrientation { get; }
    }
}