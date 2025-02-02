using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Loader;
namespace SCPSL_Framework.GameRoles.SCPs
{
    public class SCP106 : SCPRole
    {
        public SCP106()
        {
            SCPNumber = "106";
            Health = 2500;
            Abilities = new string[] { "PocketDimension", "WalkThroughWalls" };
        }
    }
}