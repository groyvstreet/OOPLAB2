using System.Reflection;

namespace Lab2.PluginBase
{
    internal class PluginManager
    {
        public List<IPlugin> Plugins = new List<IPlugin>();

        public void ScanPlugins(string directory)
        {
            foreach (var file in Directory.EnumerateFiles(directory, "*.dll", SearchOption.AllDirectories))
            {
                try
                {
                    var asm = Assembly.LoadFile(file);

                    foreach (var type in asm.GetTypes())
                    {
                        var i = type.GetInterface("IPlugin");

                        if (i != null)
                        {
                            var fullname = type.FullName;

                            if (fullname != null)
                            {
                                var plugin = asm.CreateInstance(fullname) as IPlugin;

                                if (plugin != null)
                                {
                                    Plugins.Add(plugin);
                                }
                            }
                        }
                    }
                }
                catch
                {
                }
            }
        }
    }
}
