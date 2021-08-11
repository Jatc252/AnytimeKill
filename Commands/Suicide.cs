using CommandSystem;
using RemoteAdmin;
using System;

namespace AnytimeKill.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    class Suicide : ICommand
    {
        public string Command { get; } = "kill";

        public string[] Aliases { get; } = { "suicide" };

        public string Description { get; } = "Kills you on command";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender player)
            {
                try
                {
                    player.CharacterClassManager.SetClassID(RoleType.Spectator);
                    response = "Suicided";
                    return true;
                }
                catch (Exception ex)
                {
                    response = "Error";
                    Exiled.API.Features.Log.Error($"Error suiciding {player.PlayerId}: {ex}");
                    return false;
                }
            }
            else
            {
                response = "Please run in-game";
                return false;
            }
        }
    }
}
