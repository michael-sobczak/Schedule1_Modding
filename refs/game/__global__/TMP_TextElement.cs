public class TMP_TextElement // TypeDefIndex: 14993
{
	// Fields
	[SerializeField]
	internal TextElementType m_ElementType; // 0x10
	[SerializeField]
	internal uint m_Unicode; // 0x14
	internal TMP_Asset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField]
	internal uint m_GlyphIndex; // 0x28
	[SerializeField]
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TMP_Asset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public TextElementType get_elementType() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public uint get_unicode() { }

	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_unicode(uint value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public TMP_Asset get_textAsset() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_textAsset(TMP_Asset value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Glyph get_glyph() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_glyph(Glyph value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public uint get_glyphIndex() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_glyphIndex(uint value) { }

	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float get_scale() { }

	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40
	public void set_scale(float value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
