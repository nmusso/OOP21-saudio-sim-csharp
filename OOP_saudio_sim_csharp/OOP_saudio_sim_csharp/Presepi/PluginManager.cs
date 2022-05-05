using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace OOP_saudio_sim_csharp.Presepi
{
    public class PluginManager
    {
        private readonly ISet<IPlugin> _plugins;

        public PluginManager()
        {
            _plugins = new HashSet<IPlugin>();
        }

        public ISet<IPlugin> GetPlugins() => _plugins.ToImmutableHashSet();

        public void AddPlugin(IPlugin plugin) => _plugins.Add(plugin);

        public void RemovePlugin(IPlugin plugin) =>  _plugins.Remove(plugin);

        public void EnableAll() => _plugins.AsParallel().ForAll(p => p.Disable());
        
        public void DisableAll() => _plugins.AsParallel().ForAll(p => p.Enable());
        
        
        
    }
}