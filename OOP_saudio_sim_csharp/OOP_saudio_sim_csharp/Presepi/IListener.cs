namespace OOP_saudio_sim_csharp.Presepi
{
    public interface IListener
    {
        Context CurrentContext { get; }
        Vec3F Position { get; set; }
        
        void SetOrientation(Vec3F up, Vec3F at);
        
        Vec3F AtOrientation { get; set; }

        Vec3F UpOrientation { get; }
    }
}