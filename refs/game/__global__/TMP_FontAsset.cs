public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 14898
{
	// Fields
	[SerializeField]
	internal string m_SourceFontFileGUID; // 0x98
	[SerializeField]
	internal FontAssetCreationSettings m_CreationSettings; // 0xA0
	[SerializeField]
	private Font m_SourceFontFile; // 0x100
	[SerializeField]
	private string m_SourceFontFilePath; // 0x108
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; // 0x110
	[SerializeField]
	internal bool InternalDynamicOS; // 0x114
	private int m_FamilyNameHashCode; // 0x118
	private int m_StyleNameHashCode; // 0x11C
	[SerializeField]
	internal List<Glyph> m_GlyphTable; // 0x120
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0x128
	[SerializeField]
	internal List<TMP_Character> m_CharacterTable; // 0x130
	internal Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0x138
	internal Texture2D m_AtlasTexture; // 0x140
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; // 0x148
	[SerializeField]
	internal int m_AtlasTextureIndex; // 0x150
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; // 0x154
	[SerializeField]
	private bool m_GetFontFeatures; // 0x155
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; // 0x156
	[SerializeField]
	internal int m_AtlasWidth; // 0x158
	[SerializeField]
	internal int m_AtlasHeight; // 0x15C
	[SerializeField]
	internal int m_AtlasPadding; // 0x160
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; // 0x164
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects; // 0x168
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects; // 0x170
	[SerializeField]
	internal TMP_FontFeatureTable m_FontFeatureTable; // 0x178
	[SerializeField]
	internal bool m_ShouldReimportFontFeatures; // 0x180
	[SerializeField]
	internal List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x188
	[SerializeField]
	private TMP_FontWeightPair[] m_FontWeightTable; // 0x190
	[SerializeField]
	private TMP_FontWeightPair[] fontWeights; // 0x198
	public float normalStyle; // 0x1A0
	public float normalSpacingOffset; // 0x1A4
	public float boldStyle; // 0x1A8
	public float boldSpacing; // 0x1AC
	public byte italicStyle; // 0x1B0
	public byte tabSize; // 0x1B1
	internal bool IsFontAssetLookupTablesDirty; // 0x1B2
	[SerializeField]
	private FaceInfo_Legacy m_fontInfo; // 0x1B8
	[SerializeField]
	internal List<TMP_Glyph> m_glyphInfoList; // 0x1C0
	[FormerlySerializedAs("m_kerningInfo")]
	[SerializeField]
	internal KerningTable m_KerningTable; // 0x1C8
	[SerializeField]
	private List<TMP_FontAsset> fallbackFontAssets; // 0x1D0
	[SerializeField]
	public Texture2D atlas; // 0x1D8
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x0
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x8
	private static ProfilerMarker k_TryAddGlyphMarker; // 0x10
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x18
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x20
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; // 0x28
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x30
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; // 0x38
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x40
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x48
	private static string s_DefaultMaterialSuffix; // 0x50
	private static HashSet<int> k_SearchedFontAssetLookup; // 0x58
	private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x60
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x68
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x70
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x78
	private List<Glyph> m_GlyphsToRender; // 0x1E0
	private List<Glyph> m_GlyphsRendered; // 0x1E8
	private List<uint> m_GlyphIndexList; // 0x1F0
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1F8
	internal List<uint> m_GlyphsToAdd; // 0x200
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x208
	internal List<TMP_Character> m_CharactersToAdd; // 0x210
	internal HashSet<uint> m_CharactersToAddLookup; // 0x218
	internal List<uint> s_MissingCharacterList; // 0x220
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x228
	internal static uint[] k_GlyphIndexArray; // 0x80

	// Properties
	public FontAssetCreationSettings creationSettings { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	internal int familyNameHashCode { get; set; }
	internal int styleNameHashCode { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<TMP_Character> characterTable { get; set; }
	public Dictionary<uint, TMP_Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	public int atlasTextureCount { get; }
	public bool isMultiAtlasTexturesEnabled { get; set; }
	public bool getFontFeatures { get; set; }
	internal bool clearDynamicDataOnBuild { get; set; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	public TMP_FontFeatureTable fontFeatureTable { get; set; }
	public List<TMP_FontAsset> fallbackFontAssetTable { get; set; }
	public TMP_FontWeightPair[] fontWeightTable { get; set; }
	[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
	public FaceInfo_Legacy fontInfo { get; }

	// Methods

	// RVA: 0x2BE9C80 Offset: 0x2BE8680 VA: 0x182BE9C80
	public FontAssetCreationSettings get_creationSettings() { }

	// RVA: 0x2BE9E30 Offset: 0x2BE8830 VA: 0x182BE9E30
	public void set_creationSettings(FontAssetCreationSettings value) { }

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public Font get_sourceFontFile() { }

	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x21FCF70 Offset: 0x21FB970 VA: 0x1821FCF70
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x21FD300 Offset: 0x21FBD00 VA: 0x1821FD300
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x2BE9CD0 Offset: 0x2BE86D0 VA: 0x182BE9CD0
	internal int get_familyNameHashCode() { }

	// RVA: 0x7EDA60 Offset: 0x7EC460 VA: 0x1807EDA60
	internal void set_familyNameHashCode(int value) { }

	// RVA: 0x2BE9DA0 Offset: 0x2BE87A0 VA: 0x182BE9DA0
	internal int get_styleNameHashCode() { }

	// RVA: 0x9C2380 Offset: 0x9C0D80 VA: 0x1809C2380
	internal void set_styleNameHashCode(int value) { }

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x2BE9D60 Offset: 0x2BE8760 VA: 0x182BE9D60
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	public List<TMP_Character> get_characterTable() { }

	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0
	internal void set_characterTable(List<TMP_Character> value) { }

	// RVA: 0x2BE9C40 Offset: 0x2BE8640 VA: 0x182BE9C40
	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	// RVA: 0x2BE9BA0 Offset: 0x2BE85A0 VA: 0x182BE9BA0
	public Texture2D get_atlasTexture() { }

	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x79A930 Offset: 0x799330 VA: 0x18079A930
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x2BE9B90 Offset: 0x2BE8590 VA: 0x182BE9B90
	public int get_atlasTextureCount() { }

	// RVA: 0x513130 Offset: 0x511B30 VA: 0x180513130
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x2BE9E90 Offset: 0x2BE8890 VA: 0x182BE9E90
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x2BE9D50 Offset: 0x2BE8750 VA: 0x182BE9D50
	public bool get_getFontFeatures() { }

	// RVA: 0x2BE9E80 Offset: 0x2BE8880 VA: 0x182BE9E80
	public void set_getFontFeatures(bool value) { }

	// RVA: 0xD45550 Offset: 0xD43F50 VA: 0x180D45550
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0xD47220 Offset: 0xD45C20 VA: 0x180D47220
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x858090 Offset: 0x856A90 VA: 0x180858090
	public int get_atlasWidth() { }

	// RVA: 0x8580A0 Offset: 0x856AA0 VA: 0x1808580A0
	internal void set_atlasWidth(int value) { }

	// RVA: 0x7C7530 Offset: 0x7C5F30 VA: 0x1807C7530
	public int get_atlasHeight() { }

	// RVA: 0x7C7600 Offset: 0x7C6000 VA: 0x1807C7600
	internal void set_atlasHeight(int value) { }

	// RVA: 0x79A8B0 Offset: 0x7992B0 VA: 0x18079A8B0
	public int get_atlasPadding() { }

	// RVA: 0x7C7640 Offset: 0x7C6040 VA: 0x1807C7640
	internal void set_atlasPadding(int value) { }

	// RVA: 0x71DB70 Offset: 0x71C570 VA: 0x18071DB70
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x2BE9E20 Offset: 0x2BE8820 VA: 0x182BE9E20
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x6BFCC0 Offset: 0x6BE6C0 VA: 0x1806BFCC0
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x74C8F0 Offset: 0x74B2F0 VA: 0x18074C8F0
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	// RVA: 0x73B380 Offset: 0x739D80 VA: 0x18073B380
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x73B4F0 Offset: 0x739EF0 VA: 0x18073B4F0
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public FaceInfo_Legacy get_fontInfo() { }

	// RVA: 0x2BE08A0 Offset: 0x2BDF2A0 VA: 0x182BE08A0
	public static TMP_FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	// RVA: 0x2BE10C0 Offset: 0x2BDFAC0 VA: 0x182BE10C0
	public static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	// RVA: 0x2BE0F50 Offset: 0x2BDF950 VA: 0x182BE0F50
	private static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x2BE0AD0 Offset: 0x2BDF4D0 VA: 0x182BE0AD0
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x2BE0DD0 Offset: 0x2BDF7D0 VA: 0x182BE0DD0
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x2BE0C70 Offset: 0x2BDF670 VA: 0x182BE0C70
	private static TMP_FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x2BE0280 Offset: 0x2BDEC80 VA: 0x182BE0280
	private static TMP_FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x2BE3C70 Offset: 0x2BE2670 VA: 0x182BE3C70
	private void OnDestroy() { }

	// RVA: 0x2BE3DB0 Offset: 0x2BE27B0 VA: 0x182BE3DB0
	public void ReadFontAssetDefinition() { }

	// RVA: 0x2BE2B10 Offset: 0x2BE1510 VA: 0x182BE2B10
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x2BE2FB0 Offset: 0x2BE19B0 VA: 0x182BE2FB0
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x2BE2900 Offset: 0x2BE1300 VA: 0x182BE2900
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x2BE34D0 Offset: 0x2BE1ED0 VA: 0x182BE34D0
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	// RVA: 0x2BE3230 Offset: 0x2BE1C30 VA: 0x182BE3230
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x2BE3770 Offset: 0x2BE2170 VA: 0x182BE3770
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x2BE3930 Offset: 0x2BE2330 VA: 0x182BE3930
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x2BDFA40 Offset: 0x2BDE440 VA: 0x182BDFA40
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x2BDF720 Offset: 0x2BDE120 VA: 0x182BDF720
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = False) { }

	// RVA: 0x2BDE900 Offset: 0x2BDD300 VA: 0x182BDE900
	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character) { }

	// RVA: 0x2BE3AF0 Offset: 0x2BE24F0 VA: 0x182BE3AF0
	private FontEngineError LoadFontFace() { }

	// RVA: 0x2BE4B00 Offset: 0x2BE3500 VA: 0x182BE4B00
	internal void SortCharacterTable() { }

	// RVA: 0x2BE4CD0 Offset: 0x2BE36D0 VA: 0x182BE4CD0
	internal void SortGlyphTable() { }

	// RVA: 0x2BE4C80 Offset: 0x2BE3680 VA: 0x182BE4C80
	internal void SortFontFeatureTable() { }

	// RVA: 0x2BE47F0 Offset: 0x2BE31F0 VA: 0x182BE47F0
	internal void SortAllTables() { }

	// RVA: 0x2BE1800 Offset: 0x2BE0200 VA: 0x182BE1800
	public bool HasCharacter(int character) { }

	// RVA: 0x2BE1880 Offset: 0x2BE0280 VA: 0x182BE1880
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x2BE15B0 Offset: 0x2BDFFB0 VA: 0x182BE15B0
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x2BE1E90 Offset: 0x2BE0890 VA: 0x182BE1E90
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x2BE2010 Offset: 0x2BE0A10 VA: 0x182BE2010
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x2BE2740 Offset: 0x2BE1140 VA: 0x182BE2740
	public bool HasCharacters(string text) { }

	// RVA: 0x2BE1340 Offset: 0x2BDFD40 VA: 0x182BE1340
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x2BE1260 Offset: 0x2BDFC60 VA: 0x182BE1260
	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	// RVA: 0x2BE1440 Offset: 0x2BDFE40 VA: 0x182BE1440
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x2BE1520 Offset: 0x2BDFF20 VA: 0x182BE1520
	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	// RVA: 0x2BE43F0 Offset: 0x2BE2DF0 VA: 0x182BE43F0
	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) { }

	// RVA: 0x2BE86F0 Offset: 0x2BE70F0 VA: 0x182BE86F0
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x2BE42B0 Offset: 0x2BE2CB0 VA: 0x182BE42B0
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	// RVA: 0x2BE8160 Offset: 0x2BE6B60 VA: 0x182BE8160
	internal static void UpdateAtlasTexturesInQueue() { }

	// RVA: 0x2BE8530 Offset: 0x2BE6F30 VA: 0x182BE8530
	internal static void UpdateFontAssetsInUpdateQueue() { }

	// RVA: 0x2BE6FE0 Offset: 0x2BE59E0 VA: 0x182BE6FE0
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x2BE5730 Offset: 0x2BE4130 VA: 0x182BE5730
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x2BE6350 Offset: 0x2BE4D50 VA: 0x182BE6350
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x2BE6380 Offset: 0x2BE4D80 VA: 0x182BE6380
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x2BDE970 Offset: 0x2BDD370 VA: 0x182BDE970
	internal bool AddGlyphInternal(uint glyphIndex) { }

	// RVA: 0x2BE7010 Offset: 0x2BE5A10 VA: 0x182BE7010
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	// RVA: 0x2BE4E50 Offset: 0x2BE3850 VA: 0x182BE4E50
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	// RVA: 0x2BE7B00 Offset: 0x2BE6500 VA: 0x182BE7B00
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void TryAddGlyphsToAtlasTextures() { }

	// RVA: 0x2BE7660 Offset: 0x2BE6060 VA: 0x182BE7660
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x2BE4540 Offset: 0x2BE2F40 VA: 0x182BE4540
	private void SetupNewAtlasTexture() { }

	// RVA: 0x2BE7FB0 Offset: 0x2BE69B0 VA: 0x182BE7FB0
	internal void UpdateAtlasTexture() { }

	// RVA: 0x2BE8920 Offset: 0x2BE7320 VA: 0x182BE8920
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x2BE8A30 Offset: 0x2BE7430 VA: 0x182BE8A30
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x2BE2800 Offset: 0x2BE1200 VA: 0x182BE2800
	internal void ImportFontFeatures() { }

	// RVA: 0x2BE8AE0 Offset: 0x2BE74E0 VA: 0x182BE8AE0
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	// RVA: 0x2BE8ED0 Offset: 0x2BE78D0 VA: 0x182BE8ED0
	internal void UpdateLigatureSubstitutionRecords() { }

	// RVA: 0x2BDE990 Offset: 0x2BDD390 VA: 0x182BDE990
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	// RVA: 0x2BE8B50 Offset: 0x2BE7550 VA: 0x182BE8B50
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x2BDF3F0 Offset: 0x2BDDDF0 VA: 0x182BDF3F0
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	// RVA: 0x2BE8BC0 Offset: 0x2BE75C0 VA: 0x182BE8BC0
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	// RVA: 0x2BE82E0 Offset: 0x2BE6CE0 VA: 0x182BE82E0
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	// RVA: 0x2BDEDD0 Offset: 0x2BDD7D0 VA: 0x182BDEDD0
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	// RVA: 0x2BDF0E0 Offset: 0x2BDDAE0 VA: 0x182BDF0E0
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	// RVA: -1 Offset: -1
	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBB4D0 Offset: 0xEB9ED0 VA: 0x180EBB4D0
	|-TMP_FontAsset.CopyListDataToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2BE8390 Offset: 0x2BE6D90 VA: 0x182BE8390
	internal void UpdateFontAssetData() { }

	// RVA: 0x2BE0110 Offset: 0x2BDEB10 VA: 0x182BE0110
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x2BDFED0 Offset: 0x2BDE8D0 VA: 0x182BDFED0
	internal void ClearCharacterAndGlyphTablesInternal() { }

	// RVA: 0x2BE0160 Offset: 0x2BDEB60 VA: 0x182BE0160
	internal void ClearFontFeaturesInternal() { }

	// RVA: 0x2BDFF00 Offset: 0x2BDE900 VA: 0x182BDFF00
	private void ClearCharacterAndGlyphTables() { }

	// RVA: 0x2BE0180 Offset: 0x2BDEB80 VA: 0x182BE0180
	private void ClearFontFeaturesTables() { }

	// RVA: 0x2BDFC70 Offset: 0x2BDE670 VA: 0x182BDFC70
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x2BE1170 Offset: 0x2BDFB70 VA: 0x182BE1170
	private void DestroyAtlasTextures() { }

	// RVA: 0x2BE8F40 Offset: 0x2BE7940 VA: 0x182BE8F40
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	// RVA: 0x2BE97B0 Offset: 0x2BE81B0 VA: 0x182BE97B0
	public void .ctor() { }

	// RVA: 0x2BE9380 Offset: 0x2BE7D80 VA: 0x182BE9380
	private static void .cctor() { }
}
