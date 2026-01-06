internal struct Offset // TypeDefIndex: 16742
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; }
	public float right { get; }
	public float top { get; }
	public float bottom { get; }
	public static Offset zero { get; }

	// Methods

	// RVA: 0x454BB0 Offset: 0x4535B0 VA: 0x180454BB0
	public float get_left() { }

	// RVA: 0x454BC0 Offset: 0x4535C0 VA: 0x180454BC0
	public float get_right() { }

	// RVA: 0x454BA0 Offset: 0x4535A0 VA: 0x180454BA0
	public float get_top() { }

	// RVA: 0x454B90 Offset: 0x453590 VA: 0x180454B90
	public float get_bottom() { }

	// RVA: 0x2D7DB90 Offset: 0x2D7C590 VA: 0x182D7DB90
	public static Offset get_zero() { }

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x214CBC0 Offset: 0x214B5C0 VA: 0x18214CBC0
	public static bool op_Equality(Offset lhs, Offset rhs) { }

	// RVA: 0x2CA37E0 Offset: 0x2CA21E0 VA: 0x182CA37E0
	public static Offset op_Multiply(Offset a, float b) { }

	// RVA: 0x2D7DB00 Offset: 0x2D7C500 VA: 0x182D7DB00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2D7DAA0 Offset: 0x2D7C4A0 VA: 0x182D7DAA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2D7DB50 Offset: 0x2D7C550 VA: 0x182D7DB50
	private static void .cctor() { }
}
