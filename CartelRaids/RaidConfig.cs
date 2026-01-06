using S1API.Entities.Equippables;

namespace CartelRaids;

/// <summary>
/// Configuration settings for cartel raids.
/// </summary>
public class RaidConfig
{
    /// <summary>
    /// Number of cartel goons to spawn in the raid.
    /// </summary>
    public int GoonCount { get; set; } = 3;

    /// <summary>
    /// Weapon asset path for the goons.
    /// </summary>
    public string WeaponPath { get; set; } = Weapon.M1911;

    /// <summary>
    /// Selected property index (from owned properties list).
    /// </summary>
    public int SelectedPropertyIndex { get; set; } = 0;

    /// <summary>
    /// Whether the raid should spawn at interior or exterior.
    /// </summary>
    public bool SpawnAtInterior { get; set; } = false;

    /// <summary>
    /// Available weapon options for the UI.
    /// </summary>
    public static readonly (string Name, string Path)[] WeaponOptions = new[]
    {
        ("M1911 Pistol", Weapon.M1911),
        ("Revolver", Weapon.Revolver),
        ("Pump Shotgun", Weapon.PumpShotgun),
        ("Knife", Weapon.Knife),
        ("Broken Bottle", Weapon.BrokenBottle),
        ("Taser", Weapon.Taser),
        ("Baton", Misc.Baton),
        ("Hammer", Misc.Hammer),
    };

    /// <summary>
    /// Gets the display name for the current weapon.
    /// </summary>
    public string GetCurrentWeaponName()
    {
        foreach (var option in WeaponOptions)
        {
            if (option.Path == WeaponPath)
                return option.Name;
        }
        return "Unknown";
    }
}

