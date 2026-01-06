public class PanelTextSettings : TextSettings // TypeDefIndex: 6912
{
	// Fields
	private static PanelTextSettings s_DefaultPanelTextSettings; // 0x0
	internal static Func<string, Object> EditorGUIUtilityLoad; // 0x8
	internal static Func<SystemLanguage> GetCurrentLanguage; // 0x10
	internal static readonly string s_DefaultEditorPanelTextSettingPath; // 0x18

	// Properties
	internal static PanelTextSettings defaultPanelTextSettings { get; }

	// Methods

	// RVA: 0x2EFE5B0 Offset: 0x2EFCFB0 VA: 0x182EFE5B0
	internal static PanelTextSettings get_defaultPanelTextSettings() { }

	// RVA: 0x2EFDF30 Offset: 0x2EFC930 VA: 0x182EFDF30
	internal static void UpdateLocalizationFontAsset() { }

	// RVA: 0x2EFDF20 Offset: 0x2EFC920 VA: 0x182EFDF20
	internal FontAsset GetCachedFontAsset(Font font) { }

	// RVA: 0x2EFE5A0 Offset: 0x2EFCFA0 VA: 0x182EFE5A0
	public void .ctor() { }

	// RVA: 0x2EFE530 Offset: 0x2EFCF30 VA: 0x182EFE530
	private static void .cctor() { }
}
