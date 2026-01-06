public struct GlyphValueRecord : IEquatable<GlyphValueRecord> // TypeDefIndex: 18693
{
	// Fields
	[SerializeField]
	[NativeName("xPlacement")]
	private float m_XPlacement; // 0x0
	[SerializeField]
	[NativeName("yPlacement")]
	private float m_YPlacement; // 0x4
	[NativeName("xAdvance")]
	[SerializeField]
	private float m_XAdvance; // 0x8
	[SerializeField]
	[NativeName("yAdvance")]
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; }

	// Methods

	// RVA: 0x454BB0 Offset: 0x4535B0 VA: 0x180454BB0
	public float get_xPlacement() { }

	// RVA: 0x4D53B0 Offset: 0x4D3DB0 VA: 0x1804D53B0
	public void set_xPlacement(float value) { }

	// RVA: 0x454BC0 Offset: 0x4535C0 VA: 0x180454BC0
	public float get_yPlacement() { }

	// RVA: 0x4D5390 Offset: 0x4D3D90 VA: 0x1804D5390
	public void set_yPlacement(float value) { }

	// RVA: 0x454BA0 Offset: 0x4535A0 VA: 0x180454BA0
	public float get_xAdvance() { }

	// RVA: 0x4D53A0 Offset: 0x4D3DA0 VA: 0x1804D53A0
	public void set_xAdvance(float value) { }

	// RVA: 0x454B90 Offset: 0x453590 VA: 0x180454B90
	public float get_yAdvance() { }

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x2D4AEA0 Offset: 0x2D498A0 VA: 0x182D4AEA0
	public static GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	// RVA: 0x2D4AE50 Offset: 0x2D49850 VA: 0x182D4AE50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2D4AD70 Offset: 0x2D49770 VA: 0x182D4AD70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2D4ADD0 Offset: 0x2D497D0 VA: 0x182D4ADD0 Slot: 4
	public bool Equals(GlyphValueRecord other) { }
}
