using System;
using Archipelago.MultiClient.Net;
using Archipelago.MultiClient.Net.Enums;
using BepInEx;
using BepInEx.Logging;

namespace Rubinite_Archipelago_Client;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;
        
    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

        //Temp Test Code (Very cursed delete later
        Logger.LogInfo("Connecting to AP and lying about it");
        try
        {
            ArchipelagoSession session = ArchipelagoSessionFactory.CreateSession("archipelago.gg", 39353);

            LoginResult result = session.TryConnectAndLogin("Refunct", "abefunct", ItemsHandlingFlags.NoItems);
            session.Say("Test");
        } catch (Exception e)
        {
            Logger.LogError(e);
            Logger.LogInfo($"Failed to connect {e}");
        }
        Logger.LogInfo("Connected and Said Test");

    }
}
