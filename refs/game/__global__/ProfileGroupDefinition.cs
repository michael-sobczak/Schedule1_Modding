public class ProfileGroupDefinition // TypeDefIndex: 448
{
	// Fields
	public ProfileGroupDefinition.GroupType type; // 0x10
	public ProfileGroupDefinition.FormatStyle formatStyle; // 0x14
	public ProfileGroupDefinition.RebuildType rebuildType; // 0x18
	public string propertyKey; // 0x20
	public string groupName; // 0x28
	public Color color; // 0x30
	public SpherePoint spherePoint; // 0x40
	public float minimumValue; // 0x48
	public float maximumValue; // 0x4C
	public float value; // 0x50
	public bool boolValue; // 0x54
	public Texture2D texture; // 0x58
	public string tooltip; // 0x60
	public string dependsOnFeature; // 0x68
	public bool dependsOnValue; // 0x70

	// Methods

	// RVA: 0x9E0580 Offset: 0x9DEF80 VA: 0x1809E0580
	public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string tooltip) { }

	// RVA: 0x9E0630 Offset: 0x9DF030 VA: 0x1809E0630
	public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x9E05D0 Offset: 0x9DEFD0 VA: 0x1809E05D0
	public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x9E0690 Offset: 0x9DF090 VA: 0x1809E0690
	public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, ProfileGroupDefinition.RebuildType rebuildType, ProfileGroupDefinition.FormatStyle formatStyle, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x9E0400 Offset: 0x9DEE00 VA: 0x1809E0400
	public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, string tooltip) { }

	// RVA: 0x9E0530 Offset: 0x9DEF30 VA: 0x1809E0530
	public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, string dependsOnFeature, bool dependsOnValue, string tooltip) { }

	// RVA: 0x9E0440 Offset: 0x9DEE40 VA: 0x1809E0440
	public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x9E08D0 Offset: 0x9DF2D0 VA: 0x1809E08D0
	public static ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, string tooltip) { }

	// RVA: 0x9E07A0 Offset: 0x9DF1A0 VA: 0x1809E07A0
	public static ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x9E0A30 Offset: 0x9DF430 VA: 0x1809E0A30
	public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, string tooltip) { }

	// RVA: 0x9E09F0 Offset: 0x9DF3F0 VA: 0x1809E09F0
	public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x9E0A60 Offset: 0x9DF460 VA: 0x1809E0A60
	public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x9E0310 Offset: 0x9DED10 VA: 0x1809E0310
	public static ProfileGroupDefinition BoolGroupDefinition(string groupName, string propKey, bool value, string dependsOnKeyword, bool dependsOnValue, string tooltip) { }

	// RVA: 0x9E0B60 Offset: 0x9DF560 VA: 0x1809E0B60
	public void .ctor() { }
}
