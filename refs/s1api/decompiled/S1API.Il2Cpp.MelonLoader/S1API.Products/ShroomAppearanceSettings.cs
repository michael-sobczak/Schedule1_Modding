using Il2CppScheduleOne.Product;
using UnityEngine;

namespace S1API.Products;

public sealed class ShroomAppearanceSettings
{
	internal readonly ShroomAppearanceSettings S1AppearanceSettings;

	public static Color32 DefaultPrimaryColor => ShroomAppearanceSettings.DefaultPrimaryColor;

	public static Color32 DefaultSecondaryColor => ShroomAppearanceSettings.DefaultSecondaryColor;

	public static Color32 DefaultSpotsColor => ShroomAppearanceSettings.DefaultSpotsColor;

	public Color32 PrimaryColor => S1AppearanceSettings.PrimaryColor;

	public Color32 SecondaryColor => S1AppearanceSettings.SecondaryColor;

	public bool HasSpots => S1AppearanceSettings.HasSpots;

	public Color32 SpotsColor => S1AppearanceSettings.SpotsColor;

	internal ShroomAppearanceSettings(ShroomAppearanceSettings settings)
	{
		S1AppearanceSettings = settings;
	}

	public bool IsUninitialized()
	{
		return S1AppearanceSettings.IsUnintialized();
	}
}
