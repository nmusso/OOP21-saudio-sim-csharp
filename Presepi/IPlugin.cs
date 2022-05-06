namespace OOP_saudio_sim_csharp.Presepi
{
    public interface IPlugin
    {
        void Enable();
        
        void Disable();
        
        bool IsEnabled { get; }
        
        string GetClassName();
    }
}