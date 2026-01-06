using System.Collections.Generic;
using Il2CppInterop.Runtime.Attributes;
using S1API.Property;
using UnityEngine;

namespace CartelRaids;

/// <summary>
/// IMGUI-based debug menu for configuring and triggering cartel raids.
/// Press F7 to toggle visibility.
/// </summary>
public class DebugMenu : MonoBehaviour
{
    private bool _isVisible;
    private Rect _windowRect = new(20, 20, 400, 500);
    private RaidConfig _config = new();
    
    private List<PropertyWrapper> _cachedProperties = new();
    private string[] _propertyNames = System.Array.Empty<string>();
    private float _lastPropertyRefresh;
    private const float PROPERTY_REFRESH_INTERVAL = 2f;

    private int _selectedWeaponIndex;
    private Vector2 _scrollPosition;

    // GUI Styles
    private GUIStyle _windowStyle;
    private GUIStyle _headerStyle;
    private GUIStyle _buttonStyle;
    private GUIStyle _labelStyle;
    private GUIStyle _boxStyle;
    private bool _stylesInitialized;
    
    // Cached delegate for IL2CPP compatibility
    private GUI.WindowFunction _windowFunction;

    private void Awake()
    {
        // Cache the delegate for IL2CPP compatibility
        _windowFunction = new GUI.WindowFunction(DrawWindowInternal);
    }

    public void ToggleVisibility()
    {
        _isVisible = !_isVisible;
        if (_isVisible)
        {
            RefreshProperties();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    [HideFromIl2Cpp]
    private void InitStyles()
    {
        if (_stylesInitialized) return;

        _windowStyle = new GUIStyle(GUI.skin.window)
        {
            fontSize = 14,
            fontStyle = FontStyle.Bold
        };

        _headerStyle = new GUIStyle(GUI.skin.label)
        {
            fontSize = 16,
            fontStyle = FontStyle.Bold,
            alignment = TextAnchor.MiddleCenter
        };
        _headerStyle.normal.textColor = new Color(1f, 0.5f, 0.2f);

        _buttonStyle = new GUIStyle(GUI.skin.button)
        {
            fontSize = 13,
            fontStyle = FontStyle.Bold
        };

        _labelStyle = new GUIStyle(GUI.skin.label)
        {
            fontSize = 12
        };

        _boxStyle = new GUIStyle(GUI.skin.box)
        {
            padding = new RectOffset(10, 10, 10, 10)
        };

        _stylesInitialized = true;
    }

    [HideFromIl2Cpp]
    private void RefreshProperties()
    {
        _cachedProperties = RaidManager.Instance.GetOwnedProperties();
        _propertyNames = new string[_cachedProperties.Count];
        
        for (int i = 0; i < _cachedProperties.Count; i++)
        {
            _propertyNames[i] = _cachedProperties[i].PropertyName;
        }

        // Clamp selection to valid range
        if (_config.SelectedPropertyIndex >= _cachedProperties.Count)
        {
            _config.SelectedPropertyIndex = Mathf.Max(0, _cachedProperties.Count - 1);
        }

        _lastPropertyRefresh = Time.time;
    }

    private void OnGUI()
    {
        if (!_isVisible) return;

        InitStyles();

        // Auto-refresh properties periodically
        if (Time.time - _lastPropertyRefresh > PROPERTY_REFRESH_INTERVAL)
        {
            RefreshProperties();
        }

        if (_windowFunction == null)
        {
            _windowFunction = new GUI.WindowFunction(DrawWindowInternal);
        }
        _windowRect = GUI.Window(12345, _windowRect, _windowFunction, "Cartel Raids Debug Menu", _windowStyle);
    }

    private void DrawWindowInternal(int windowId)
    {
        _scrollPosition = GUILayout.BeginScrollView(_scrollPosition);

        GUILayout.Space(10);

        // Header
        GUILayout.Label("CARTEL RAID CONFIGURATION", _headerStyle);
        GUILayout.Space(15);

        // Status Section
        DrawStatusSection();
        GUILayout.Space(15);

        // Configuration Section
        DrawConfigurationSection();
        GUILayout.Space(15);

        // Actions Section
        DrawActionsSection();

        GUILayout.EndScrollView();

        // Make window draggable
        GUI.DragWindow(new Rect(0, 0, 10000, 30));
    }

    [HideFromIl2Cpp]
    private void DrawStatusSection()
    {
        GUILayout.BeginVertical(_boxStyle);
        GUILayout.Label("STATUS", _headerStyle);
        GUILayout.Space(5);

        var raidStatus = RaidManager.Instance.IsRaidActive ? "RAID IN PROGRESS" : "No active raid";
        var statusColor = RaidManager.Instance.IsRaidActive ? "red" : "green";
        GUILayout.Label($"Status: <color={statusColor}>{raidStatus}</color>", _labelStyle);

        if (RaidManager.Instance.IsRaidActive)
        {
            GUILayout.Label($"Active Goons: {RaidManager.Instance.ActiveGoonCount}", _labelStyle);
        }

        GUILayout.Label($"Owned Properties: {_cachedProperties.Count}", _labelStyle);

        GUILayout.EndVertical();
    }

    [HideFromIl2Cpp]
    private void DrawConfigurationSection()
    {
        GUILayout.BeginVertical(_boxStyle);
        GUILayout.Label("RAID SETTINGS", _headerStyle);
        GUILayout.Space(10);

        // Property Selection
        GUILayout.Label("Target Property:", _labelStyle);
        if (_propertyNames.Length > 0)
        {
            _config.SelectedPropertyIndex = GUILayout.SelectionGrid(
                _config.SelectedPropertyIndex,
                _propertyNames,
                1,
                _buttonStyle
            );
        }
        else
        {
            GUILayout.Label("<color=yellow>No owned properties!</color>", _labelStyle);
        }

        GUILayout.Space(10);

        // Goon Count
        GUILayout.Label($"Number of Goons: {_config.GoonCount}", _labelStyle);
        _config.GoonCount = Mathf.RoundToInt(GUILayout.HorizontalSlider(_config.GoonCount, 1, 10));

        GUILayout.Space(10);

        // Weapon Selection
        GUILayout.Label("Weapon:", _labelStyle);
        var weaponNames = new string[RaidConfig.WeaponOptions.Length];
        for (int i = 0; i < RaidConfig.WeaponOptions.Length; i++)
        {
            weaponNames[i] = RaidConfig.WeaponOptions[i].Name;
            if (RaidConfig.WeaponOptions[i].Path == _config.WeaponPath)
            {
                _selectedWeaponIndex = i;
            }
        }

        int newWeaponIndex = GUILayout.SelectionGrid(_selectedWeaponIndex, weaponNames, 2, _buttonStyle);
        if (newWeaponIndex != _selectedWeaponIndex)
        {
            _selectedWeaponIndex = newWeaponIndex;
            _config.WeaponPath = RaidConfig.WeaponOptions[_selectedWeaponIndex].Path;
        }

        GUILayout.Space(10);

        // Spawn Location
        GUILayout.Label("Spawn Location:", _labelStyle);
        GUILayout.BeginHorizontal();
        if (GUILayout.Toggle(!_config.SpawnAtInterior, "Exterior", _buttonStyle))
        {
            _config.SpawnAtInterior = false;
        }
        if (GUILayout.Toggle(_config.SpawnAtInterior, "Interior", _buttonStyle))
        {
            _config.SpawnAtInterior = true;
        }
        GUILayout.EndHorizontal();

        GUILayout.EndVertical();
    }

    [HideFromIl2Cpp]
    private void DrawActionsSection()
    {
        GUILayout.BeginVertical(_boxStyle);
        GUILayout.Label("ACTIONS", _headerStyle);
        GUILayout.Space(10);

        // Start Raid Button
        GUI.enabled = !RaidManager.Instance.IsRaidActive && _cachedProperties.Count > 0;
        GUI.backgroundColor = new Color(0.8f, 0.2f, 0.2f);
        if (GUILayout.Button("START RAID", _buttonStyle, GUILayout.Height(40)))
        {
            bool success = RaidManager.Instance.StartRaid(_config);
            if (success)
            {
                Core.Logger?.Msg("Raid started successfully!");
            }
        }
        GUI.backgroundColor = Color.white;
        GUI.enabled = true;

        GUILayout.Space(5);

        // Stop Raid Button
        GUI.enabled = RaidManager.Instance.IsRaidActive;
        GUI.backgroundColor = new Color(0.6f, 0.6f, 0.2f);
        if (GUILayout.Button("STOP RAID", _buttonStyle, GUILayout.Height(30)))
        {
            RaidManager.Instance.StopAllRaids();
        }
        GUI.backgroundColor = Color.white;
        GUI.enabled = true;

        GUILayout.Space(10);

        // Refresh Properties Button
        if (GUILayout.Button("Refresh Properties", _buttonStyle))
        {
            RefreshProperties();
        }

        GUILayout.Space(10);

        // Close Button
        if (GUILayout.Button("Close (F7)", _buttonStyle))
        {
            _isVisible = false;
        }

        GUILayout.EndVertical();
    }

    private void Update()
    {
        // Close menu with Escape
        if (_isVisible && Input.GetKeyDown(KeyCode.Escape))
        {
            _isVisible = false;
        }
    }
}

