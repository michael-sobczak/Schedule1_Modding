public class FontAsset : TextAsset // TypeDefIndex: 16705
{
	// Fields
	[SerializeField]
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; // 0x40
	[SerializeField]
	private Font m_SourceFontFile; // 0x98
	[SerializeField]
	private string m_SourceFontFilePath; // 0xA0
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; // 0xA8
	[SerializeField]
	internal bool InternalDynamicOS; // 0xAC
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0xB0
	private int m_FamilyNameHashCode; // 0x110
	private int m_StyleNameHashCode; // 0x114
	[SerializeField]
	internal List<Glyph> m_GlyphTable; // 0x118
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0x120
	[SerializeField]
	internal List<Character> m_CharacterTable; // 0x128
	internal Dictionary<uint, Character> m_CharacterLookupDictionary; // 0x130
	internal Texture2D m_AtlasTexture; // 0x138
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; // 0x140
	[SerializeField]
	internal int m_AtlasTextureIndex; // 0x148
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; // 0x14C
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; // 0x14D
	[SerializeField]
	internal int m_AtlasWidth; // 0x150
	[SerializeField]
	internal int m_AtlasHeight; // 0x154
	[SerializeField]
	internal int m_AtlasPadding; // 0x158
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; // 0x15C
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects; // 0x160
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects; // 0x168
	[SerializeField]
	internal FontFeatureTable m_FontFeatureTable; // 0x170
	[SerializeField]
	internal List<FontAsset> m_FallbackFontAssetTable; // 0x178
	[SerializeField]
	private FontWeightPair[] m_FontWeightTable; // 0x180
	[FormerlySerializedAs("normalStyle")]
	[SerializeField]
	internal float m_RegularStyleWeight; // 0x188
	[FormerlySerializedAs("normalSpacingOffset")]
	[SerializeField]
	internal float m_RegularStyleSpacing; // 0x18C
	[SerializeField]
	[FormerlySerializedAs("boldStyle")]
	internal float m_BoldStyleWeight; // 0x190
	[FormerlySerializedAs("boldSpacing")]
	[SerializeField]
	internal float m_BoldStyleSpacing; // 0x194
	[FormerlySerializedAs("italicStyle")]
	[SerializeField]
	internal byte m_ItalicStyleSlant; // 0x198
	[SerializeField]
	[FormerlySerializedAs("tabSize")]
	internal byte m_TabMultiple; // 0x199
	internal bool IsFontAssetLookupTablesDirty; // 0x19A
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x0
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x8
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x10
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x18
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; // 0x28
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x30
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x38
	private static ProfilerMarker k_TryAddGlyphMarker; // 0x40
	private static string s_DefaultMaterialSuffix; // 0x48
	private static HashSet<int> k_SearchedFontAssetLookup; // 0x50
	private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x58
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x60
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x68
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x70
	private List<Glyph> m_GlyphsToRender; // 0x1A0
	private List<Glyph> m_GlyphsRendered; // 0x1A8
	private List<uint> m_GlyphIndexList; // 0x1B0
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1B8
	internal List<uint> m_GlyphsToAdd; // 0x1C0
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x1C8
	internal List<Character> m_CharactersToAdd; // 0x1D0
	internal HashSet<uint> m_CharactersToAddLookup; // 0x1D8
	internal List<uint> s_MissingCharacterList; // 0x1E0
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x1E8
	internal static uint[] k_GlyphIndexArray; // 0x78

	// Properties
	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	public FaceInfo faceInfo { get; set; }
	internal int familyNameHashCode { get; set; }
	internal int styleNameHashCode { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<Character> characterTable { get; set; }
	public Dictionary<uint, Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	public int atlasTextureCount { get; }
	public bool isMultiAtlasTexturesEnabled { get; set; }
	internal bool clearDynamicDataOnBuild { get; set; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	public FontFeatureTable fontFeatureTable { get; set; }
	public List<FontAsset> fallbackFontAssetTable { get; set; }
	public FontWeightPair[] fontWeightTable { get; set; }
	public float regularStyleWeight { get; set; }
	public float regularStyleSpacing { get; set; }
	public float boldStyleWeight { get; set; }
	public float boldStyleSpacing { get; set; }
	public byte italicStyleSlant { get; set; }
	public byte tabMultiple { get; set; }

	// Methods

	// RVA: 0x2D55C30 Offset: 0x2D54630 VA: 0x182D55C30
	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	// RVA: 0x2D55E30 Offset: 0x2D54830 VA: 0x182D55E30
	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	// RVA: 0x2D0E160 Offset: 0x2D0CB60 VA: 0x182D0E160
	public Font get_sourceFontFile() { }

	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x2D55A20 Offset: 0x2D54420 VA: 0x182D55A20
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x587060 Offset: 0x585A60 VA: 0x180587060
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x2D55B80 Offset: 0x2D54580 VA: 0x182D55B80
	public FaceInfo get_faceInfo() { }

	// RVA: 0x2D55DE0 Offset: 0x2D547E0 VA: 0x182D55DE0
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x2D55BE0 Offset: 0x2D545E0 VA: 0x182D55BE0
	internal int get_familyNameHashCode() { }

	// RVA: 0x21FD300 Offset: 0x21FBD00 VA: 0x1821FD300
	internal void set_familyNameHashCode(int value) { }

	// RVA: 0x2D55D30 Offset: 0x2D54730 VA: 0x182D55D30
	internal int get_styleNameHashCode() { }

	// RVA: 0xD00680 Offset: 0xCFF080 VA: 0x180D00680
	internal void set_styleNameHashCode(int value) { }

	// RVA: 0x2D55CE0 Offset: 0x2D546E0 VA: 0x182D55CE0
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x2D55CA0 Offset: 0x2D546A0 VA: 0x182D55CA0
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x2D55B60 Offset: 0x2D54560 VA: 0x182D55B60
	public List<Character> get_characterTable() { }

	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	internal void set_characterTable(List<Character> value) { }

	// RVA: 0x2D55B20 Offset: 0x2D54520 VA: 0x182D55B20
	public Dictionary<uint, Character> get_characterLookupTable() { }

	// RVA: 0x2D55A50 Offset: 0x2D54450 VA: 0x182D55A50
	public Texture2D get_atlasTexture() { }

	// RVA: 0x1E12370 Offset: 0x1E10D70 VA: 0x181E12370
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x6FB0A0 Offset: 0x6F9AA0 VA: 0x1806FB0A0
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x2D55A40 Offset: 0x2D54440 VA: 0x182D55A40
	public int get_atlasTextureCount() { }

	// RVA: 0x2D55CF0 Offset: 0x2D546F0 VA: 0x182D55CF0
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x78C520 Offset: 0x78AF20 VA: 0x18078C520
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x2D55B70 Offset: 0x2D54570 VA: 0x182D55B70
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x2D55DD0 Offset: 0x2D547D0 VA: 0x182D55DD0
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x2D55AF0 Offset: 0x2D544F0 VA: 0x182D55AF0
	public int get_atlasWidth() { }

	// RVA: 0x653B00 Offset: 0x652500 VA: 0x180653B00
	internal void set_atlasWidth(int value) { }

	// RVA: 0x2D55A00 Offset: 0x2D54400 VA: 0x182D55A00
	public int get_atlasHeight() { }

	// RVA: 0x2D55DA0 Offset: 0x2D547A0 VA: 0x182D55DA0
	internal void set_atlasHeight(int value) { }

	// RVA: 0x2D55A10 Offset: 0x2D54410 VA: 0x182D55A10
	public int get_atlasPadding() { }

	// RVA: 0x8580A0 Offset: 0x856AA0 VA: 0x1808580A0
	internal void set_atlasPadding(int value) { }

	// RVA: 0x2D55A30 Offset: 0x2D54430 VA: 0x182D55A30
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x7C7600 Offset: 0x7C6000 VA: 0x1807C7600
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x2D55D90 Offset: 0x2D54790 VA: 0x182D55D90
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x618140 Offset: 0x616B40 VA: 0x180618140
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x2D55C90 Offset: 0x2D54690 VA: 0x182D55C90
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x2D55C70 Offset: 0x2D54670 VA: 0x182D55C70
	public FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0
	internal void set_fontFeatureTable(FontFeatureTable value) { }

	// RVA: 0x2D55BD0 Offset: 0x2D545D0 VA: 0x182D55BD0
	public List<FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x74C8F0 Offset: 0x74B2F0 VA: 0x18074C8F0
	public void set_fallbackFontAssetTable(List<FontAsset> value) { }

	// RVA: 0x2D55C80 Offset: 0x2D54680 VA: 0x182D55C80
	public FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x73B4D0 Offset: 0x739ED0 VA: 0x18073B4D0
	internal void set_fontWeightTable(FontWeightPair[] value) { }

	// RVA: 0x2D55D20 Offset: 0x2D54720 VA: 0x182D55D20
	public float get_regularStyleWeight() { }

	// RVA: 0x726510 Offset: 0x724F10 VA: 0x180726510
	public void set_regularStyleWeight(float value) { }

	// RVA: 0x2D55D10 Offset: 0x2D54710 VA: 0x182D55D10
	public float get_regularStyleSpacing() { }

	// RVA: 0x726480 Offset: 0x724E80 VA: 0x180726480
	public void set_regularStyleSpacing(float value) { }

	// RVA: 0x2D55B10 Offset: 0x2D54510 VA: 0x182D55B10
	public float get_boldStyleWeight() { }

	// RVA: 0x2D55DC0 Offset: 0x2D547C0 VA: 0x182D55DC0
	public void set_boldStyleWeight(float value) { }

	// RVA: 0x2D55B00 Offset: 0x2D54500 VA: 0x182D55B00
	public float get_boldStyleSpacing() { }

	// RVA: 0x2D55DB0 Offset: 0x2D547B0 VA: 0x182D55DB0
	public void set_boldStyleSpacing(float value) { }

	// RVA: 0x2D55D00 Offset: 0x2D54700 VA: 0x182D55D00
	public byte get_italicStyleSlant() { }

	// RVA: 0x88C240 Offset: 0x88AC40 VA: 0x18088C240
	public void set_italicStyleSlant(byte value) { }

	// RVA: 0x2D55D80 Offset: 0x2D54780 VA: 0x182D55D80
	public byte get_tabMultiple() { }

	// RVA: 0x2D55E80 Offset: 0x2D54880 VA: 0x182D55E80
	public void set_tabMultiple(byte value) { }

	// RVA: 0x2D4D4A0 Offset: 0x2D4BEA0 VA: 0x182D4D4A0
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	// RVA: 0x2D4D3F0 Offset: 0x2D4BDF0 VA: 0x182D4D3F0
	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	// RVA: 0x2D4D210 Offset: 0x2D4BC10 VA: 0x182D4D210
	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 2, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x2D4D370 Offset: 0x2D4BD70 VA: 0x182D4D370
	public static FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x2D4D6C0 Offset: 0x2D4C0C0 VA: 0x182D4D6C0
	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x2D4D8C0 Offset: 0x2D4C2C0 VA: 0x182D4D8C0
	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x2D4CC60 Offset: 0x2D4B660 VA: 0x182D4CC60
	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Awake() { }

	// RVA: 0x2D4FAD0 Offset: 0x2D4E4D0 VA: 0x182D4FAD0
	private void OnDestroy() { }

	// RVA: 0x2D4FC00 Offset: 0x2D4E600 VA: 0x182D4FC00
	public void ReadFontAssetDefinition() { }

	// RVA: 0x2D4ED40 Offset: 0x2D4D740 VA: 0x182D4ED40
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x2D4ED90 Offset: 0x2D4D790 VA: 0x182D4ED90
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x2D4EB60 Offset: 0x2D4D560 VA: 0x182D4EB60
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x2D4F280 Offset: 0x2D4DC80 VA: 0x182D4F280
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	// RVA: 0x2D4F010 Offset: 0x2D4DA10 VA: 0x182D4F010
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x2D4F560 Offset: 0x2D4DF60 VA: 0x182D4F560
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x2D4F750 Offset: 0x2D4E150 VA: 0x182D4F750
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x2D4C3E0 Offset: 0x2D4ADE0 VA: 0x182D4C3E0
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x2D4C0C0 Offset: 0x2D4AAC0 VA: 0x182D4C0C0
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = False) { }

	// RVA: 0x2D4C050 Offset: 0x2D4AA50 VA: 0x182D4C050
	internal void AddCharacterToLookupCache(uint unicode, Character character) { }

	// RVA: 0x2D4F940 Offset: 0x2D4E340 VA: 0x182D4F940
	private FontEngineError LoadFontFace() { }

	// RVA: 0x2D50890 Offset: 0x2D4F290 VA: 0x182D50890
	internal void SortCharacterTable() { }

	// RVA: 0x2D50A60 Offset: 0x2D4F460 VA: 0x182D50A60
	internal void SortGlyphTable() { }

	// RVA: 0x2D50A10 Offset: 0x2D4F410 VA: 0x182D50A10
	internal void SortFontFeatureTable() { }

	// RVA: 0x2D50580 Offset: 0x2D4EF80 VA: 0x182D50580
	internal void SortAllTables() { }

	// RVA: 0x2D4E420 Offset: 0x2D4CE20 VA: 0x182D4E420
	public bool HasCharacter(int character) { }

	// RVA: 0x2D4E490 Offset: 0x2D4CE90 VA: 0x182D4E490
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x2D4E0A0 Offset: 0x2D4CAA0 VA: 0x182D4E0A0
	public bool HasCharacter(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x2D4DE50 Offset: 0x2D4C850 VA: 0x182D4DE50
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x2D4EA00 Offset: 0x2D4D400 VA: 0x182D4EA00
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x2D4E560 Offset: 0x2D4CF60 VA: 0x182D4E560
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x2D4E4B0 Offset: 0x2D4CEB0 VA: 0x182D4E4B0
	public bool HasCharacters(string text) { }

	// RVA: 0x2D4DC70 Offset: 0x2D4C670 VA: 0x182D4DC70
	public static string GetCharacters(FontAsset fontAsset) { }

	// RVA: 0x2D4DB90 Offset: 0x2D4C590 VA: 0x182D4DB90
	public static int[] GetCharactersArray(FontAsset fontAsset) { }

	// RVA: 0x2D4DD70 Offset: 0x2D4C770 VA: 0x182D4DD70
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x2D501A0 Offset: 0x2D4EBA0 VA: 0x182D501A0
	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	// RVA: 0x2D547E0 Offset: 0x2D531E0 VA: 0x182D547E0
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x2D50060 Offset: 0x2D4EA60 VA: 0x182D50060
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	// RVA: 0x2D540F0 Offset: 0x2D52AF0 VA: 0x182D540F0
	internal static void UpdateAtlasTexturesInQueue() { }

	// RVA: 0x2D54480 Offset: 0x2D52E80 VA: 0x182D54480
	internal static void UpdateFontAssetsInUpdateQueue() { }

	// RVA: 0x2D51670 Offset: 0x2D50070 VA: 0x182D51670
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x2D516A0 Offset: 0x2D500A0 VA: 0x182D516A0
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x2D51640 Offset: 0x2D50040 VA: 0x182D51640
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x2D522D0 Offset: 0x2D50CD0 VA: 0x182D522D0
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x2D52EC0 Offset: 0x2D518C0 VA: 0x182D52EC0
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	// RVA: 0x2D50BE0 Offset: 0x2D4F5E0 VA: 0x182D50BE0
	internal bool TryAddCharacterInternal(uint unicode, out Character character, bool shouldGetFontFeatures = False) { }

	// RVA: 0x2D53C10 Offset: 0x2D52610 VA: 0x182D53C10
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out Character character, bool shouldGetFontFeatures = False) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void TryAddGlyphsToAtlasTextures() { }

	// RVA: 0x2D53770 Offset: 0x2D52170 VA: 0x182D53770
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x2D502F0 Offset: 0x2D4ECF0 VA: 0x182D502F0
	private void SetupNewAtlasTexture() { }

	// RVA: 0x2D54090 Offset: 0x2D52A90 VA: 0x182D54090
	private void UpdateAllFontFeatures() { }

	// RVA: 0x2D54DE0 Offset: 0x2D537E0 VA: 0x182D54DE0
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x2D549A0 Offset: 0x2D533A0 VA: 0x182D549A0
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes) { }

	// RVA: -1 Offset: -1
	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBB4D0 Offset: 0xEB9ED0 VA: 0x180EBB4D0
	|-FontAsset.CopyListDataToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2D4C850 Offset: 0x2D4B250 VA: 0x182D4C850
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x2D4C820 Offset: 0x2D4B220 VA: 0x182D4C820
	internal void ClearFontAssetDataInternal(bool clearFontFeatures = False) { }

	// RVA: 0x2D54270 Offset: 0x2D52C70 VA: 0x182D54270
	internal void UpdateFontAssetData() { }

	// RVA: 0x2D4C970 Offset: 0x2D4B370 VA: 0x182D4C970
	internal void ClearFontAssetTables(bool clearFontFeatures) { }

	// RVA: 0x2D4C5E0 Offset: 0x2D4AFE0 VA: 0x182D4C5E0
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x2D4DAA0 Offset: 0x2D4C4A0 VA: 0x182D4DAA0
	private void DestroyAtlasTextures() { }

	// RVA: 0x2D55660 Offset: 0x2D54060 VA: 0x182D55660
	public void .ctor() { }

	// RVA: 0x2D55270 Offset: 0x2D53C70 VA: 0x182D55270
	private static void .cctor() { }
}
