public class ProfileFeatureDefinition // TypeDefIndex: 443
{
	// Fields
	public string featureKey; // 0x10
	public string[] featureKeys; // 0x18
	public ProfileFeatureDefinition.FeatureType featureType; // 0x20
	public string shaderKeyword; // 0x28
	public string[] shaderKeywords; // 0x30
	public string[] dropdownLabels; // 0x38
	public int dropdownSelectedIndex; // 0x40
	public string name; // 0x48
	public bool value; // 0x50
	public string tooltip; // 0x58
	public string dependsOnFeature; // 0x60
	public bool dependsOnValue; // 0x68
	public bool isShaderKeywordFeature; // 0x69

	// Methods

	// RVA: 0x9E01B0 Offset: 0x9DEBB0 VA: 0x1809E01B0
	public static ProfileFeatureDefinition CreateShaderFeature(string featureKey, string shaderKeyword, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip) { }

	// RVA: 0x9E00A0 Offset: 0x9DEAA0 VA: 0x1809E00A0
	public static ProfileFeatureDefinition CreateShaderFeatureDropdown(string[] featureKeys, string[] shaderKeywords, string[] labels, int selectedIndex, string name, string dependsOnFeature, bool dependsOnValue, string tooltip) { }

	// RVA: 0x9DFFE0 Offset: 0x9DE9E0 VA: 0x1809DFFE0
	public static ProfileFeatureDefinition CreateBooleanFeature(string featureKey, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
