using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(CartelRaids.Core), "CartelRaids", "1.0.0", "micha", null)]
[assembly: MelonGame("TVGS", "Schedule I")]

namespace CartelRaids;

/// <summary>
/// Main mod entry point for CartelRaids.
/// Introduces cartel raid mechanics where player properties can be attacked by cartel members.
/// </summary>
public class Core : MelonMod
{
    public static Core Instance { get; private set; }
    public static MelonLogger.Instance Logger => Instance?.LoggerInstance;

    private DebugMenu _debugMenu;
    private bool _isInGame;

    public override void OnInitializeMelon()
    {
        Instance = this;
        LoggerInstance.Msg("CartelRaids initialized. Press F7 to open the debug menu.");
    }

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        if (sceneName == "Main")
        {
            _isInGame = true;
            LoggerInstance.Msg("Game scene loaded - CartelRaids ready.");
        }
    }

    public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
    {
        if (sceneName == "Main")
        {
            _isInGame = false;
            RaidManager.Instance?.StopAllRaids();
        }
    }

    public override void OnUpdate()
    {
        if (!_isInGame) return;

        // Toggle debug menu with F7
        if (Input.GetKeyDown(KeyCode.F7))
        {
            if (_debugMenu == null)
            {
                var go = new GameObject("CartelRaids_DebugMenu");
                UnityEngine.Object.DontDestroyOnLoad(go);
                _debugMenu = go.AddComponent<DebugMenu>();
            }
            else
            {
                _debugMenu.ToggleVisibility();
            }
        }

        // Update raid manager
        RaidManager.Instance?.Update();
    }
}
