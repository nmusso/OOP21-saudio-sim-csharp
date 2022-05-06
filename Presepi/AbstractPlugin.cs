namespace OOP_saudio_sim_csharp.Presepi
{
    public abstract class AbstractPlugin : IPlugin
    {
        public bool IsEnabled { get; private set; }

        public void Enable()
        {
            IsEnabled = true;
            RestoreSettings();
        }

        protected abstract void SaveSettings();

        public void Disable()
        {
            SaveSettings();
            IsEnabled = false;
        }

        protected abstract void RestoreSettings();

        public string GetClassName() => this.GetType().Name;
        

        public override int GetHashCode() => GetClassName().GetHashCode();

        public override bool Equals(object obj) => obj is IPlugin p && p.GetClassName().Equals(this.GetClassName());

    }
}