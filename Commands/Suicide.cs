using CommandSystem;
using RemoteAdmin;
using System;

namespace AnytimeKill.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    class Suicide : ICommand
    {
        public string Command { get; } = "suicide";
        public string[] Aliases { get; } = {};
        public string Description { get; } = "Kills you on command";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender player)
            {
                try
                {
                    player.CharacterClassManager.SetClassID(RoleType.Spectator, CharacterClassManager.SpawnReason.Died);
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
