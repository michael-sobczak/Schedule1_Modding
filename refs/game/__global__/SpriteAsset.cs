public class SpriteAsset : TextAsset // TypeDefIndex: 16718
{
	// Fields
	internal Dictionary<int, int> m_NameLookup; // 0x38
	internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x40
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0x48
	[FormerlySerializedAs("spriteSheet")]
	[SerializeField]
	internal Texture m_SpriteAtlasTexture; // 0xA8
	[SerializeField]
	private List<SpriteCharacter> m_SpriteCharacterTable; // 0xB0
	internal Dictionary<uint, SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
	[SerializeField]
	private List<SpriteGlyph> m_SpriteGlyphTable; // 0xC0
	internal Dictionary<uint, SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
	[SerializeField]
	public List<SpriteAsset> fallbackSpriteAssets; // 0xD0
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xD8
	private static HashSet<int> k_searchedSpriteAssets; // 0x0

	// Properties
	public FaceInfo faceInfo { get; set; }
	public Texture spriteSheet { get; set; }
	public List<SpriteCharacter> spriteCharacterTable { get; set; }
	public Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable { get; set; }
	public List<SpriteGlyph> spriteGlyphTable { get; set; }

	// Methods

	// RVA: 0x2D5B250 Offset: 0x2D59C50 VA: 0x182D5B250
	public FaceInfo get_faceInfo() { }

	// RVA: 0x2D5B310 Offset: 0x2D59D10 VA: 0x182D5B310
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x2D0E150 Offset: 0x2D0CB50 VA: 0x182D0E150
	public Texture get_spriteSheet() { }

	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	internal void set_spriteSheet(Texture value) { }

	// RVA: 0x2D5B2D0 Offset: 0x2D59CD0 VA: 0x182D5B2D0
	public List<SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	internal void set_spriteCharacterTable(List<SpriteCharacter> value) { }

	// RVA: 0x2D5B290 Offset: 0x2D59C90 VA: 0x182D5B290
	public Dictionary<uint, SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x4B6CA0 Offset: 0x4B56A0 VA: 0x1804B6CA0
	internal void set_spriteCharacterLookupTable(Dictionary<uint, SpriteCharacter> value) { }

	// RVA: 0x2D0E220 Offset: 0x2D0CC20 VA: 0x182D0E220
	public List<SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	internal void set_spriteGlyphTable(List<SpriteGlyph> value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Awake() { }

	// RVA: 0x2D5AC30 Offset: 0x2D59630 VA: 0x182D5AC30
	public void UpdateLookupTables() { }

	// RVA: 0x2D59AE0 Offset: 0x2D584E0 VA: 0x182D59AE0
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x2D59BB0 Offset: 0x2D585B0 VA: 0x182D59BB0
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	// RVA: 0x2D59B70 Offset: 0x2D58570 VA: 0x182D59B70
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x2D5A480 Offset: 0x2D58E80 VA: 0x182D5A480
	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x2D5A230 Offset: 0x2D58C30 VA: 0x182D5A230
	private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x2D5A3C0 Offset: 0x2D58DC0 VA: 0x182D5A3C0
	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x2D59EB0 Offset: 0x2D588B0 VA: 0x182D59EB0
	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings) { }

	// RVA: 0x2D59C50 Offset: 0x2D58650 VA: 0x182D59C50
	private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x2D59DF0 Offset: 0x2D587F0 VA: 0x182D59DF0
	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x2D5AAB0 Offset: 0x2D594B0 VA: 0x182D5AAB0
	public void SortGlyphTable() { }

	// RVA: 0x2D5A660 Offset: 0x2D59060 VA: 0x182D5A660
	internal void SortCharacterTable() { }

	// RVA: 0x2D5A7E0 Offset: 0x2D591E0 VA: 0x182D5A7E0
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x2D5B180 Offset: 0x2D59B80 VA: 0x182D5B180
	public void .ctor() { }
}
