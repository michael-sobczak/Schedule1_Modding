public abstract class TextElement // TypeDefIndex: 16725
{
	// Fields
	[SerializeField]
	protected TextElementType m_ElementType; // 0x10
	[SerializeField]
	internal uint m_Unicode; // 0x14
	internal TextAsset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField]
	internal uint m_GlyphIndex; // 0x28
	[SerializeField]
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TextAsset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x1E02840 Offset: 0x1E01240 VA: 0x181E02840
	public TextElementType get_elementType() { }

	// RVA: 0x1667070 Offset: 0x1665A70 VA: 0x181667070
	public uint get_unicode() { }

	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_unicode(uint value) { }

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	public TextAsset get_textAsset() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_textAsset(TextAsset value) { }

	// RVA: 0x1E09860 Offset: 0x1E08260 VA: 0x181E09860
	public Glyph get_glyph() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_glyph(Glyph value) { }

	// RVA: 0x1263FC0 Offset: 0x12629C0 VA: 0x181263FC0
	public uint get_glyphIndex() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_glyphIndex(uint value) { }

	// RVA: 0x2D2B1E0 Offset: 0x2D29BE0 VA: 0x182D2B1E0
	public float get_scale() { }

	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40
	public void set_scale(float value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
