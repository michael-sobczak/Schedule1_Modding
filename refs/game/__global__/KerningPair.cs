public class KerningPair // TypeDefIndex: 14905
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("AscII_Left")]
	private uint m_FirstGlyph; // 0x10
	[SerializeField]
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAs("AscII_Right")]
	[SerializeField]
	private uint m_SecondGlyph; // 0x24
	[SerializeField]
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAs("XadvanceOffset")]
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField]
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public uint get_firstGlyph() { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_firstGlyph(uint value) { }

	// RVA: 0x54B810 Offset: 0x54A210 VA: 0x18054B810
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public uint get_secondGlyph() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_secondGlyph(uint value) { }

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0x2BEBE90 Offset: 0x2BEA890 VA: 0x182BEBE90
	public void .ctor() { }

	// RVA: 0x2BEBDE0 Offset: 0x2BEA7E0 VA: 0x182BEBDE0
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0x2BEBE30 Offset: 0x2BEA830 VA: 0x182BEBE30
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0x2BEBD40 Offset: 0x2BEA740 VA: 0x182BEBD40
	internal void ConvertLegacyKerningData() { }

	// RVA: 0x2BEBD50 Offset: 0x2BEA750 VA: 0x182BEBD50
	private static void .cctor() { }
}
