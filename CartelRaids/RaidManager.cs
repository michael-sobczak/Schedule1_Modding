using System.Collections.Generic;
using Il2CppFishNet;
using S1API.Cartel;
using S1API.Property;
using UnityEngine;

namespace CartelRaids;

/// <summary>
/// Manages cartel raid mechanics including spawning goons and tracking active raids.
/// </summary>
public class RaidManager
{
    private static RaidManager _instance;
    public static RaidManager Instance => _instance ??= new RaidManager();

    private readonly List<CartelGoon> _activeGoons = new();
    private bool _raidActive;
    private PropertyWrapper _targetProperty;

    /// <summary>
    /// Whether a raid is currently active.
    /// </summary>
    public bool IsRaidActive => _raidActive;

    /// <summary>
    /// Number of active goons in the current raid.
    /// </summary>
    public int ActiveGoonCount => _activeGoons.Count;

    /// <summary>
    /// Gets all owned properties the player has.
    /// </summary>
    public List<PropertyWrapper> GetOwnedProperties()
    {
        return PropertyManager.GetOwnedProperties();
    }

    /// <summary>
    /// Starts a raid on the specified property with the given configuration.
    /// </summary>
    public bool StartRaid(RaidConfig config)
    {
        if (_raidActive)
        {
            Core.Logger?.Warning("A raid is already in progress!");
            return false;
        }

        // Check if we're on server (required for spawning)
        if (!InstanceFinder.IsServer)
        {
            Core.Logger?.Warning("Only the host can start raids!");
            return false;
        }

        var ownedProperties = GetOwnedProperties();
        if (ownedProperties.Count == 0)
        {
            Core.Logger?.Warning("No owned properties to raid!");
            return false;
        }

        if (config.SelectedPropertyIndex < 0 || config.SelectedPropertyIndex >= ownedProperties.Count)
        {
            Core.Logger?.Warning("Invalid property selection!");
            return false;
        }

        _targetProperty = ownedProperties[config.SelectedPropertyIndex];
        
        // Get the cartel and goon manager
        var cartel = Cartel.Instance;
        if (cartel == null)
        {
            Core.Logger?.Warning("Cartel system not available!");
            return false;
        }

        var goonManager = cartel.GoonPool;
        if (goonManager == null)
        {
            Core.Logger?.Warning("Goon pool not available!");
            return false;
        }

        if (goonManager.AvailableGoonCount < config.GoonCount)
        {
            Core.Logger?.Warning($"Not enough goons available! Need {config.GoonCount}, have {goonManager.AvailableGoonCount}");
            return false;
        }

        // Get spawn position
        Vector3 spawnPosition = config.SpawnAtInterior 
            ? _targetProperty.InteriorSpawnPosition 
            : _targetProperty.ExteriorSpawnPosition;

        // Add some randomization to spawn positions
        var spawnPositions = GenerateSpawnPositions(spawnPosition, config.GoonCount);

        Core.Logger?.Msg($"Starting raid on {_targetProperty.PropertyName} with {config.GoonCount} goons");

        // Spawn goons
        var spawnedGoons = goonManager.SpawnGoonsAtPositions(spawnPositions);
        
        foreach (var goon in spawnedGoons)
        {
            // Set weapon
            if (!string.IsNullOrEmpty(config.WeaponPath))
            {
                goon.SetDefaultWeapon(config.WeaponPath);
            }

            // Order to attack player
            goon.AttackPlayer();
            
            _activeGoons.Add(goon);
        }

        _raidActive = true;
        Core.Logger?.Msg($"Raid started! {_activeGoons.Count} goons attacking {_targetProperty.PropertyName}");

        return true;
    }

    /// <summary>
    /// Generates spread out spawn positions around a center point.
    /// </summary>
    private Vector3[] GenerateSpawnPositions(Vector3 center, int count)
    {
        var positions = new Vector3[count];
        float radius = 2f;

        for (int i = 0; i < count; i++)
        {
            float angle = (360f / count) * i * Mathf.Deg2Rad;
            float offsetX = Mathf.Cos(angle) * radius;
            float offsetZ = Mathf.Sin(angle) * radius;
            positions[i] = center + new Vector3(offsetX, 0, offsetZ);
        }

        return positions;
    }

    /// <summary>
    /// Called every frame to update raid state.
    /// </summary>
    public void Update()
    {
        if (!_raidActive) return;

        // Remove dead/despawned goons from tracking
        _activeGoons.RemoveAll(goon => 
            goon == null || 
            !goon.IsSpawned || 
            !goon.IsConscious);

        // Check if raid is over
        if (_activeGoons.Count == 0)
        {
            EndRaid();
        }
    }

    /// <summary>
    /// Ends the current raid.
    /// </summary>
    private void EndRaid()
    {
        _raidActive = false;
        _targetProperty = null;
        Core.Logger?.Msg("Raid ended! All attackers have been eliminated.");
    }

    /// <summary>
    /// Force stops all active raids and despawns goons.
    /// </summary>
    public void StopAllRaids()
    {
        foreach (var goon in _activeGoons)
        {
            try
            {
                goon?.Despawn();
            }
            catch { /* Ignore errors during cleanup */ }
        }

        _activeGoons.Clear();
        _raidActive = false;
        _targetProperty = null;
        Core.Logger?.Msg("All raids stopped.");
    }

    /// <summary>
    /// Resets the singleton instance (for scene changes).
    /// </summary>
    public static void Reset()
    {
        _instance?.StopAllRaids();
        _instance = null;
    }
}

