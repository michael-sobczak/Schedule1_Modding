public struct Translate : IEquatable<Translate> // TypeDefIndex: 6831
{
	// Fields
	private Length m_X; // 0x0
	private Length m_Y; // 0x8
	private float m_Z; // 0x10
	private bool m_isNone; // 0x14

	// Properties
	public Length x { get; set; }
	public Length y { get; set; }
	public float z { get; }

	// Methods

	// RVA: 0x2F0C170 Offset: 0x2F0AB70 VA: 0x182F0C170
	public void .ctor(Length x, Length y, float z) { }

	// RVA: 0x2F0BFD0 Offset: 0x2F0A9D0 VA: 0x182F0BFD0
	public static Translate None() { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public Length get_x() { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void set_x(Length value) { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public Length get_y() { }

	// RVA: 0x1CD2E00 Offset: 0x1CD1800 VA: 0x181CD2E00
	public void set_y(Length value) { }

	// RVA: 0x4747B0 Offset: 0x4731B0 VA: 0x1804747B0
	public float get_z() { }

	// RVA: 0x2F0C190 Offset: 0x2F0AB90 VA: 0x182F0C190
	public static bool op_Equality(Translate lhs, Translate rhs) { }

	// RVA: 0x2F0C2A0 Offset: 0x2F0ACA0 VA: 0x182F0C2A0
	public static bool op_Inequality(Translate lhs, Translate rhs) { }

	// RVA: 0x2F0BEC0 Offset: 0x2F0A8C0 VA: 0x182F0BEC0 Slot: 4
	public bool Equals(Translate other) { }

	// RVA: 0x2F0BF10 Offset: 0x2F0A910 VA: 0x182F0BF10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F0B5D0 Offset: 0x2F09FD0 VA: 0x182F0B5D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F0C000 Offset: 0x2F0AA00 VA: 0x182F0C000 Slot: 3
	public override string ToString() { }
}
