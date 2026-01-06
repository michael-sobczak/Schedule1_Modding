public struct TMP_Offset // TypeDefIndex: 14869
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly TMP_Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; set; }
	public float right { get; set; }
	public float top { get; set; }
	public float bottom { get; set; }
	public float horizontal { get; set; }
	public float vertical { get; set; }
	public static TMP_Offset zero { get; }

	// Methods

	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780
	public float get_left() { }

	// RVA: 0x4D53B0 Offset: 0x4D3DB0 VA: 0x1804D53B0
	public void set_left(float value) { }

	// RVA: 0x474770 Offset: 0x473170 VA: 0x180474770
	public float get_right() { }

	// RVA: 0x4D5390 Offset: 0x4D3D90 VA: 0x1804D5390
	public void set_right(float value) { }

	// RVA: 0x4747A0 Offset: 0x4731A0 VA: 0x1804747A0
	public float get_top() { }

	// RVA: 0x4D53A0 Offset: 0x4D3DA0 VA: 0x1804D53A0
	public void set_top(float value) { }

	// RVA: 0x474790 Offset: 0x473190 VA: 0x180474790
	public float get_bottom() { }

	// RVA: 0x4D5380 Offset: 0x4D3D80 VA: 0x1804D5380
	public void set_bottom(float value) { }

	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780
	public float get_horizontal() { }

	// RVA: 0x29289C0 Offset: 0x29273C0 VA: 0x1829289C0
	public void set_horizontal(float value) { }

	// RVA: 0x4747A0 Offset: 0x4731A0 VA: 0x1804747A0
	public float get_vertical() { }

	// RVA: 0x2BEA490 Offset: 0x2BE8E90 VA: 0x182BEA490
	public void set_vertical(float value) { }

	// RVA: 0x2BEA380 Offset: 0x2BE8D80 VA: 0x182BEA380
	public static TMP_Offset get_zero() { }

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x2BEA360 Offset: 0x2BE8D60 VA: 0x182BEA360
	public void .ctor(float horizontal, float vertical) { }

	// RVA: 0x214CBC0 Offset: 0x214B5C0 VA: 0x18214CBC0
	public static bool op_Equality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x2BEA3E0 Offset: 0x2BE8DE0 VA: 0x182BEA3E0
	public static bool op_Inequality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x1F65040 Offset: 0x1F63A40 VA: 0x181F65040
	public static TMP_Offset op_Multiply(TMP_Offset a, float b) { }

	// RVA: 0x2BEA2D0 Offset: 0x2BE8CD0 VA: 0x182BEA2D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2BEA270 Offset: 0x2BE8C70 VA: 0x182BEA270 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2BEA1F0 Offset: 0x2BE8BF0 VA: 0x182BEA1F0
	public bool Equals(TMP_Offset other) { }

	// RVA: 0x2BEA320 Offset: 0x2BE8D20 VA: 0x182BEA320
	private static void .cctor() { }
}
