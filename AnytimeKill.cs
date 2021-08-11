using Exiled.API.Enums;
using Exiled.API.Features;
using System;

namespace AnytimeKill
{
    public class AnytimeKill : Plugin<Config>
    {
        private static readonly AnytimeKill Singleton = new AnytimeKill();
        public override string Name { get; } = "AnytimeKill";
        public override string Author { get; } = "Jatc251";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 11, 1);
        public override string Prefix { get; } = "anytimekill";
        public override PluginPriority Priority { get; } = PluginPriority.Medium;
        public static AnytimeKill Instance => Singleton;

        private AnytimeKill()
        {

        }

        public override void OnEnabled()
        {
            if (Config.IsEnabled)
            {
                Log.Debug("Thanks for using AnytimeKill by Jatc251");
            }

        }
    }
}
