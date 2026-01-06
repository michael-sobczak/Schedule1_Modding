public struct TMP_GlyphValueRecord // TypeDefIndex: 14914
{
	// Fields
	[SerializeField]
	internal float m_XPlacement; // 0x0
	[SerializeField]
	internal float m_YPlacement; // 0x4
	[SerializeField]
	internal float m_XAdvance; // 0x8
	[SerializeField]
	internal float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; set; }

	// Methods

	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780
	public float get_xPlacement() { }

	// RVA: 0x4D53B0 Offset: 0x4D3DB0 VA: 0x1804D53B0
	public void set_xPlacement(float value) { }

	// RVA: 0x474770 Offset: 0x473170 VA: 0x180474770
	public float get_yPlacement() { }

	// RVA: 0x4D5390 Offset: 0x4D3D90 VA: 0x1804D5390
	public void set_yPlacement(float value) { }

	// RVA: 0x4747A0 Offset: 0x4731A0 VA: 0x1804747A0
	public float get_xAdvance() { }

	// RVA: 0x4D53A0 Offset: 0x4D3DA0 VA: 0x1804D53A0
	public void set_xAdvance(float value) { }

	// RVA: 0x474790 Offset: 0x473190 VA: 0x180474790
	public float get_yAdvance() { }

	// RVA: 0x4D5380 Offset: 0x4D3D80 VA: 0x1804D5380
	public void set_yAdvance(float value) { }

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x22D2A70 Offset: 0x22D1470 VA: 0x1822D2A70
	internal void .ctor(GlyphValueRecord_Legacy valueRecord) { }

	// RVA: 0x2BEBCC0 Offset: 0x2BEA6C0 VA: 0x182BEBCC0
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0x2BEEB30 Offset: 0x2BED530 VA: 0x182BEEB30
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }
}
