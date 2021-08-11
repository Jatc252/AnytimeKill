using Exiled.API.Interfaces;
using System.ComponentModel;

namespace AnytimeKill
{
    public sealed class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Will the plugin outout debug information?")]
        public bool Debug { get; set; } = false;
        public string ConfigVersion { get; private set; } = "1";
    }
}
