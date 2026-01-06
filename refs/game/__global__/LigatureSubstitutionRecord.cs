internal struct LigatureSubstitutionRecord // TypeDefIndex: 18701
{
	// Fields
	[NativeName("componentGlyphs")]
	[SerializeField]
	private uint[] m_ComponentGlyphIDs; // 0x0
	[SerializeField]
	[NativeName("ligatureGlyph")]
	private uint m_LigatureGlyphID; // 0x8

	// Properties
	public uint[] componentGlyphIDs { get; }
	public uint ligatureGlyphID { get; }

	// Methods

	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	public uint[] get_componentGlyphIDs() { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	public uint get_ligatureGlyphID() { }
}
