public class TextSettings : ScriptableObject // TypeDefIndex: 16759
{
	// Fields
	[SerializeField]
	protected string m_Version; // 0x18
	[SerializeField]
	[FormerlySerializedAs("m_defaultFontAsset")]
	protected FontAsset m_DefaultFontAsset; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_defaultFontAssetPath")]
	protected string m_DefaultFontAssetPath; // 0x28
	[FormerlySerializedAs("m_fallbackFontAssets")]
	[SerializeField]
	protected List<FontAsset> m_FallbackFontAssets; // 0x30
	[SerializeField]
	[FormerlySerializedAs("m_matchMaterialPreset")]
	protected bool m_MatchMaterialPreset; // 0x38
	[FormerlySerializedAs("m_missingGlyphCharacter")]
	[SerializeField]
	protected int m_MissingCharacterUnicode; // 0x3C
	[SerializeField]
	protected bool m_ClearDynamicDataOnBuild; // 0x40
	[SerializeField]
	[FormerlySerializedAs("m_defaultSpriteAsset")]
	protected SpriteAsset m_DefaultSpriteAsset; // 0x48
	[FormerlySerializedAs("m_defaultSpriteAssetPath")]
	[SerializeField]
	protected string m_DefaultSpriteAssetPath; // 0x50
	[SerializeField]
	protected List<SpriteAsset> m_FallbackSpriteAssets; // 0x58
	[SerializeField]
	protected uint m_MissingSpriteCharacterUnicode; // 0x60
	[SerializeField]
	[FormerlySerializedAs("m_defaultStyleSheet")]
	protected TextStyleSheet m_DefaultStyleSheet; // 0x68
	[SerializeField]
	protected string m_StyleSheetsResourcePath; // 0x70
	[SerializeField]
	[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
	protected string m_DefaultColorGradientPresetsPath; // 0x78
	[SerializeField]
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; // 0x80
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0x88
	[FormerlySerializedAs("m_warningsDisabled")]
	[SerializeField]
	protected bool m_DisplayWarnings; // 0x89
	internal Dictionary<int, FontAsset> m_FontLookup; // 0x90
	private List<TextSettings.FontReferenceMap> m_FontReferences; // 0x98

	// Properties
	public string version { get; set; }
	public FontAsset defaultFontAsset { get; set; }
	public string defaultFontAssetPath { get; set; }
	public List<FontAsset> fallbackFontAssets { get; set; }
	public bool matchMaterialPreset { get; set; }
	public int missingCharacterUnicode { get; set; }
	public bool clearDynamicDataOnBuild { get; set; }
	public SpriteAsset defaultSpriteAsset { get; set; }
	public string defaultSpriteAssetPath { get; set; }
	public List<SpriteAsset> fallbackSpriteAssets { get; set; }
	public uint missingSpriteCharacterUnicode { get; set; }
	public TextStyleSheet defaultStyleSheet { get; set; }
	public string styleSheetsResourcePath { get; set; }
	public string defaultColorGradientPresetsPath { get; set; }
	public UnicodeLineBreakingRules lineBreakingRules { get; set; }
	public bool useModernHangulLineBreakingRules { get; set; }
	public bool displayWarnings { get; set; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_version() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_version(string value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public FontAsset get_defaultFontAsset() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_defaultFontAsset(FontAsset value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_defaultFontAssetPath() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_defaultFontAssetPath(string value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public List<FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_fallbackFontAssets(List<FontAsset> value) { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_matchMaterialPreset() { }

	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	public void set_matchMaterialPreset(bool value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public int get_missingCharacterUnicode() { }

	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	public void set_missingCharacterUnicode(int value) { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	public void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_defaultSpriteAsset(SpriteAsset value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_defaultSpriteAssetPath() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_defaultSpriteAssetPath(string value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public List<SpriteAsset> get_fallbackSpriteAssets() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_fallbackSpriteAssets(List<SpriteAsset> value) { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public uint get_missingSpriteCharacterUnicode() { }

	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	public void set_missingSpriteCharacterUnicode(uint value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public TextStyleSheet get_defaultStyleSheet() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_defaultStyleSheet(TextStyleSheet value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public string get_styleSheetsResourcePath() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_styleSheetsResourcePath(string value) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_defaultColorGradientPresetsPath(string value) { }

	// RVA: 0x2D87740 Offset: 0x2D86140 VA: 0x182D87740
	public UnicodeLineBreakingRules get_lineBreakingRules() { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	public void set_lineBreakingRules(UnicodeLineBreakingRules value) { }

	// RVA: 0x2D877D0 Offset: 0x2D861D0 VA: 0x182D877D0
	public bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0xDA2C80 Offset: 0xDA1680 VA: 0x180DA2C80
	public void set_useModernHangulLineBreakingRules(bool value) { }

	// RVA: 0x143EDF0 Offset: 0x143D7F0 VA: 0x18143EDF0
	public bool get_displayWarnings() { }

	// RVA: 0x143F010 Offset: 0x143DA10 VA: 0x18143F010
	public void set_displayWarnings(bool value) { }

	// RVA: 0x2D87570 Offset: 0x2D85F70 VA: 0x182D87570
	private void OnEnable() { }

	// RVA: 0x2D87330 Offset: 0x2D85D30 VA: 0x182D87330
	protected void InitializeFontReferenceLookup() { }

	// RVA: 0x2D86F70 Offset: 0x2D85970 VA: 0x182D86F70
	protected FontAsset GetCachedFontAssetInternal(Font font) { }

	// RVA: 0x2D87610 Offset: 0x2D86010 VA: 0x182D87610
	public void .ctor() { }
}
