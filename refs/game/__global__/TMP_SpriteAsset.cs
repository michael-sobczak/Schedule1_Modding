public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 14964
{
	// Fields
	internal Dictionary<int, int> m_NameLookup; // 0x98
	internal Dictionary<uint, int> m_GlyphIndexLookup; // 0xA0
	public Texture spriteSheet; // 0xA8
	[SerializeField]
	private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0xB0
	internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
	[SerializeField]
	[FormerlySerializedAs("m_SpriteGlyphTable")]
	private List<TMP_SpriteGlyph> m_GlyphTable; // 0xC0
	internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
	public List<TMP_Sprite> spriteInfoList; // 0xD0
	[SerializeField]
	public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0xD8
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xE0
	private static HashSet<int> k_searchedSpriteAssets; // 0x0

	// Properties
	public List<TMP_SpriteCharacter> spriteCharacterTable { get; set; }
	public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get; set; }
	public List<TMP_SpriteGlyph> spriteGlyphTable { get; set; }

	// Methods

	// RVA: 0x2C2B610 Offset: 0x2C2A010 VA: 0x182C2B610
	public List<TMP_SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	internal void set_spriteCharacterTable(List<TMP_SpriteCharacter> value) { }

	// RVA: 0x2C2B5D0 Offset: 0x2C29FD0 VA: 0x182C2B5D0
	public Dictionary<uint, TMP_SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x4B6CA0 Offset: 0x4B56A0 VA: 0x1804B6CA0
	internal void set_spriteCharacterLookupTable(Dictionary<uint, TMP_SpriteCharacter> value) { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public List<TMP_SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	internal void set_spriteGlyphTable(List<TMP_SpriteGlyph> value) { }

	// RVA: 0x2C29510 Offset: 0x2C27F10 VA: 0x182C29510
	private void Awake() { }

	// RVA: 0x2C29590 Offset: 0x2C27F90 VA: 0x182C29590
	private Material GetDefaultSpriteMaterial() { }

	// RVA: 0x2C2AA10 Offset: 0x2C29410 VA: 0x182C2AA10
	public void UpdateLookupTables() { }

	// RVA: 0x2C29660 Offset: 0x2C28060 VA: 0x182C29660
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x2C29770 Offset: 0x2C28170 VA: 0x182C29770
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	// RVA: 0x2C296F0 Offset: 0x2C280F0 VA: 0x182C296F0
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x2C2A170 Offset: 0x2C28B70 VA: 0x182C2A170
	public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x2C29F20 Offset: 0x2C28920 VA: 0x182C29F20
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x2C2A0B0 Offset: 0x2C28AB0 VA: 0x182C2A0B0
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x2C29A60 Offset: 0x2C28460 VA: 0x182C29A60
	public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x2C298D0 Offset: 0x2C282D0 VA: 0x182C298D0
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x2C29810 Offset: 0x2C28210 VA: 0x182C29810
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x2C2A890 Offset: 0x2C29290 VA: 0x182C2A890
	public void SortGlyphTable() { }

	// RVA: 0x2C2A440 Offset: 0x2C28E40 VA: 0x182C2A440
	internal void SortCharacterTable() { }

	// RVA: 0x2C2A5C0 Offset: 0x2C28FC0 VA: 0x182C2A5C0
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x2C2AFF0 Offset: 0x2C299F0 VA: 0x182C2AFF0
	private void UpgradeSpriteAsset() { }

	// RVA: 0x2C2B500 Offset: 0x2C29F00 VA: 0x182C2B500
	public void .ctor() { }
}
