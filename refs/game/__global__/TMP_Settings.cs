public class TMP_Settings : ScriptableObject // TypeDefIndex: 14958
{
	// Fields
	private static TMP_Settings s_Instance; // 0x0
	[SerializeField]
	internal string assetVersion; // 0x18
	internal static string s_CurrentAssetVersion; // 0x8
	[FormerlySerializedAs("m_enableWordWrapping")]
	[SerializeField]
	private TextWrappingModes m_TextWrappingMode; // 0x20
	[SerializeField]
	private bool m_enableKerning; // 0x24
	[SerializeField]
	private List<OTL_FeatureTag> m_ActiveFontFeatures; // 0x28
	[SerializeField]
	private bool m_enableExtraPadding; // 0x30
	[SerializeField]
	private bool m_enableTintAllSprites; // 0x31
	[SerializeField]
	private bool m_enableParseEscapeCharacters; // 0x32
	[SerializeField]
	private bool m_EnableRaycastTarget; // 0x33
	[SerializeField]
	private bool m_GetFontFeaturesAtRuntime; // 0x34
	[SerializeField]
	private int m_missingGlyphCharacter; // 0x38
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; // 0x3C
	[SerializeField]
	private bool m_warningsDisabled; // 0x3D
	[SerializeField]
	private TMP_FontAsset m_defaultFontAsset; // 0x40
	[SerializeField]
	private string m_defaultFontAssetPath; // 0x48
	[SerializeField]
	private float m_defaultFontSize; // 0x50
	[SerializeField]
	private float m_defaultAutoSizeMinRatio; // 0x54
	[SerializeField]
	private float m_defaultAutoSizeMaxRatio; // 0x58
	[SerializeField]
	private Vector2 m_defaultTextMeshProTextContainerSize; // 0x5C
	[SerializeField]
	private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x64
	[SerializeField]
	private bool m_autoSizeTextContainer; // 0x6C
	[SerializeField]
	private bool m_IsTextObjectScaleStatic; // 0x6D
	[SerializeField]
	private List<TMP_FontAsset> m_fallbackFontAssets; // 0x70
	[SerializeField]
	private bool m_matchMaterialPreset; // 0x78
	[SerializeField]
	private bool m_HideSubTextObjects; // 0x79
	[SerializeField]
	private TMP_SpriteAsset m_defaultSpriteAsset; // 0x80
	[SerializeField]
	private string m_defaultSpriteAssetPath; // 0x88
	[SerializeField]
	private bool m_enableEmojiSupport; // 0x90
	[SerializeField]
	private uint m_MissingCharacterSpriteUnicode; // 0x94
	[SerializeField]
	private List<TMP_Asset> m_EmojiFallbackTextAssets; // 0x98
	[SerializeField]
	private string m_defaultColorGradientPresetsPath; // 0xA0
	[SerializeField]
	private TMP_StyleSheet m_defaultStyleSheet; // 0xA8
	[SerializeField]
	private string m_StyleSheetsResourcePath; // 0xB0
	[SerializeField]
	private TextAsset m_leadingCharacters; // 0xB8
	[SerializeField]
	private TextAsset m_followingCharacters; // 0xC0
	[SerializeField]
	private TMP_Settings.LineBreakingTable m_linebreakingRules; // 0xC8
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0xD0

	// Properties
	public static string version { get; }
	public static TextWrappingModes textWrappingMode { get; }
	[Obsolete("The "enableKerning" property has been deprecated. Use the "fontFeatures" property to control what features are enabled by default on newly created text components.")]
	public static bool enableKerning { get; }
	public static List<OTL_FeatureTag> fontFeatures { get; }
	public static bool enableExtraPadding { get; }
	public static bool enableTintAllSprites { get; }
	public static bool enableParseEscapeCharacters { get; }
	public static bool enableRaycastTarget { get; }
	public static bool getFontFeaturesAtRuntime { get; }
	public static int missingGlyphCharacter { get; set; }
	public static bool clearDynamicDataOnBuild { get; }
	public static bool warningsDisabled { get; }
	public static TMP_FontAsset defaultFontAsset { get; set; }
	public static string defaultFontAssetPath { get; }
	public static float defaultFontSize { get; }
	public static float defaultTextAutoSizingMinRatio { get; }
	public static float defaultTextAutoSizingMaxRatio { get; }
	public static Vector2 defaultTextMeshProTextContainerSize { get; }
	public static Vector2 defaultTextMeshProUITextContainerSize { get; }
	public static bool autoSizeTextContainer { get; }
	public static bool isTextObjectScaleStatic { get; set; }
	public static List<TMP_FontAsset> fallbackFontAssets { get; set; }
	public static bool matchMaterialPreset { get; }
	public static bool hideSubTextObjects { get; }
	public static TMP_SpriteAsset defaultSpriteAsset { get; set; }
	public static string defaultSpriteAssetPath { get; }
	public static bool enableEmojiSupport { get; set; }
	public static uint missingCharacterSpriteUnicode { get; set; }
	public static List<TMP_Asset> emojiFallbackTextAssets { get; set; }
	public static string defaultColorGradientPresetsPath { get; }
	public static TMP_StyleSheet defaultStyleSheet { get; set; }
	public static string styleSheetsResourcePath { get; }
	public static TextAsset leadingCharacters { get; }
	public static TextAsset followingCharacters { get; }
	public static TMP_Settings.LineBreakingTable linebreakingRules { get; }
	public static bool useModernHangulLineBreakingRules { get; set; }
	public static TMP_Settings instance { get; }
	internal static bool isTMPSettingsNull { get; }

	// Methods

	// RVA: 0x2C28D70 Offset: 0x2C27770 VA: 0x182C28D70
	public static string get_version() { }

	// RVA: 0x2C27BF0 Offset: 0x2C265F0 VA: 0x182C27BF0
	internal void SetAssetVersion() { }

	// RVA: 0x2C28CC0 Offset: 0x2C276C0 VA: 0x182C28CC0
	public static TextWrappingModes get_textWrappingMode() { }

	// RVA: 0x2C28370 Offset: 0x2C26D70 VA: 0x182C28370
	public static bool get_enableKerning() { }

	// RVA: 0x2C285D0 Offset: 0x2C26FD0 VA: 0x182C285D0
	public static List<OTL_FeatureTag> get_fontFeatures() { }

	// RVA: 0x2C28320 Offset: 0x2C26D20 VA: 0x182C28320
	public static bool get_enableExtraPadding() { }

	// RVA: 0x2C284D0 Offset: 0x2C26ED0 VA: 0x182C284D0
	public static bool get_enableTintAllSprites() { }

	// RVA: 0x2C28430 Offset: 0x2C26E30 VA: 0x182C28430
	public static bool get_enableParseEscapeCharacters() { }

	// RVA: 0x2C28480 Offset: 0x2C26E80 VA: 0x182C28480
	public static bool get_enableRaycastTarget() { }

	// RVA: 0x2C28620 Offset: 0x2C27020 VA: 0x182C28620
	public static bool get_getFontFeaturesAtRuntime() { }

	// RVA: 0x2C28C10 Offset: 0x2C27610 VA: 0x182C28C10
	public static int get_missingGlyphCharacter() { }

	// RVA: 0x2C29140 Offset: 0x2C27B40 VA: 0x182C29140
	public static void set_missingGlyphCharacter(int value) { }

	// RVA: 0x2C27E10 Offset: 0x2C26810 VA: 0x182C27E10
	public static bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x2C28DA0 Offset: 0x2C277A0 VA: 0x182C28DA0
	public static bool get_warningsDisabled() { }

	// RVA: 0x2C27F10 Offset: 0x2C26910 VA: 0x182C27F10
	public static TMP_FontAsset get_defaultFontAsset() { }

	// RVA: 0x2C28DF0 Offset: 0x2C277F0 VA: 0x182C28DF0
	public static void set_defaultFontAsset(TMP_FontAsset value) { }

	// RVA: 0x2C27EC0 Offset: 0x2C268C0 VA: 0x182C27EC0
	public static string get_defaultFontAssetPath() { }

	// RVA: 0x2C27F60 Offset: 0x2C26960 VA: 0x182C27F60
	public static float get_defaultFontSize() { }

	// RVA: 0x2C28140 Offset: 0x2C26B40 VA: 0x182C28140
	public static float get_defaultTextAutoSizingMinRatio() { }

	// RVA: 0x2C280E0 Offset: 0x2C26AE0 VA: 0x182C280E0
	public static float get_defaultTextAutoSizingMaxRatio() { }

	// RVA: 0x2C281A0 Offset: 0x2C26BA0 VA: 0x182C281A0
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	// RVA: 0x2C28200 Offset: 0x2C26C00 VA: 0x182C28200
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	// RVA: 0x2C27DC0 Offset: 0x2C267C0 VA: 0x182C27DC0
	public static bool get_autoSizeTextContainer() { }

	// RVA: 0x2C28A10 Offset: 0x2C27410 VA: 0x182C28A10
	public static bool get_isTextObjectScaleStatic() { }

	// RVA: 0x2C29080 Offset: 0x2C27A80 VA: 0x182C29080
	public static void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x2C28520 Offset: 0x2C26F20 VA: 0x182C28520
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x2C29010 Offset: 0x2C27A10 VA: 0x182C29010
	public static void set_fallbackFontAssets(List<TMP_FontAsset> value) { }

	// RVA: 0x2C28B60 Offset: 0x2C27560 VA: 0x182C28B60
	public static bool get_matchMaterialPreset() { }

	// RVA: 0x2C28670 Offset: 0x2C27070 VA: 0x182C28670
	public static bool get_hideSubTextObjects() { }

	// RVA: 0x2C28020 Offset: 0x2C26A20 VA: 0x182C28020
	public static TMP_SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x2C28E60 Offset: 0x2C27860 VA: 0x182C28E60
	public static void set_defaultSpriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x2C27FC0 Offset: 0x2C269C0 VA: 0x182C27FC0
	public static string get_defaultSpriteAssetPath() { }

	// RVA: 0x2C282C0 Offset: 0x2C26CC0 VA: 0x182C282C0
	public static bool get_enableEmojiSupport() { }

	// RVA: 0x2C28FB0 Offset: 0x2C279B0 VA: 0x182C28FB0
	public static void set_enableEmojiSupport(bool value) { }

	// RVA: 0x2C28BB0 Offset: 0x2C275B0 VA: 0x182C28BB0
	public static uint get_missingCharacterSpriteUnicode() { }

	// RVA: 0x2C290E0 Offset: 0x2C27AE0 VA: 0x182C290E0
	public static void set_missingCharacterSpriteUnicode(uint value) { }

	// RVA: 0x2C28260 Offset: 0x2C26C60 VA: 0x182C28260
	public static List<TMP_Asset> get_emojiFallbackTextAssets() { }

	// RVA: 0x2C28F40 Offset: 0x2C27940 VA: 0x182C28F40
	public static void set_emojiFallbackTextAssets(List<TMP_Asset> value) { }

	// RVA: 0x2C27E60 Offset: 0x2C26860 VA: 0x182C27E60
	public static string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x2C28080 Offset: 0x2C26A80 VA: 0x182C28080
	public static TMP_StyleSheet get_defaultStyleSheet() { }

	// RVA: 0x2C28ED0 Offset: 0x2C278D0 VA: 0x182C28ED0
	public static void set_defaultStyleSheet(TMP_StyleSheet value) { }

	// RVA: 0x2C28C60 Offset: 0x2C27660 VA: 0x182C28C60
	public static string get_styleSheetsResourcePath() { }

	// RVA: 0x2C28A60 Offset: 0x2C27460 VA: 0x182C28A60
	public static TextAsset get_leadingCharacters() { }

	// RVA: 0x2C28570 Offset: 0x2C26F70 VA: 0x182C28570
	public static TextAsset get_followingCharacters() { }

	// RVA: 0x2C28AC0 Offset: 0x2C274C0 VA: 0x182C28AC0
	public static TMP_Settings.LineBreakingTable get_linebreakingRules() { }

	// RVA: 0x2C28D10 Offset: 0x2C27710 VA: 0x182C28D10
	public static bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x2C291A0 Offset: 0x2C27BA0 VA: 0x182C291A0
	public static void set_useModernHangulLineBreakingRules(bool value) { }

	// RVA: 0x2C286C0 Offset: 0x2C270C0 VA: 0x182C286C0
	public static TMP_Settings get_instance() { }

	// RVA: 0x2C28990 Offset: 0x2C27390 VA: 0x182C28990
	internal static bool get_isTMPSettingsNull() { }

	// RVA: 0x2C278E0 Offset: 0x2C262E0 VA: 0x182C278E0
	public static TMP_Settings LoadDefaultSettings() { }

	// RVA: 0x2C276E0 Offset: 0x2C260E0 VA: 0x182C276E0
	public static TMP_Settings GetSettings() { }

	// RVA: 0x2C27630 Offset: 0x2C26030 VA: 0x182C27630
	public static TMP_FontAsset GetFontAsset() { }

	// RVA: 0x2C27780 Offset: 0x2C26180 VA: 0x182C27780
	public static TMP_SpriteAsset GetSpriteAsset() { }

	// RVA: 0x2C27830 Offset: 0x2C26230 VA: 0x182C27830
	public static TMP_StyleSheet GetStyleSheet() { }

	// RVA: 0x2C27A20 Offset: 0x2C26420 VA: 0x182C27A20
	public static void LoadLinebreakingRules() { }

	// RVA: 0x2C27560 Offset: 0x2C25F60 VA: 0x182C27560
	private static HashSet<uint> GetCharacters(TextAsset file) { }

	// RVA: 0x2C27CD0 Offset: 0x2C266D0 VA: 0x182C27CD0
	public void .ctor() { }

	// RVA: 0x2C27C60 Offset: 0x2C26660 VA: 0x182C27C60
	private static void .cctor() { }
}
