public struct TransformOrigin : IEquatable<TransformOrigin> // TypeDefIndex: 6830
{
	// Fields
	private Length m_X; // 0x0
	private Length m_Y; // 0x8
	private float m_Z; // 0x10

	// Properties
	public Length x { get; set; }
	public Length y { get; set; }
	public float z { get; }

	// Methods

	// RVA: 0x2F0B840 Offset: 0x2F0A240 VA: 0x182F0B840
	public void .ctor(Length x, Length y, float z) { }

	// RVA: 0x2F0B650 Offset: 0x2F0A050 VA: 0x182F0B650
	public static TransformOrigin Initial() { }

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

	// RVA: 0x2F0B850 Offset: 0x2F0A250 VA: 0x182F0B850
	public static bool op_Equality(TransformOrigin lhs, TransformOrigin rhs) { }

	// RVA: 0x2F0B8F0 Offset: 0x2F0A2F0 VA: 0x182F0B8F0
	public static bool op_Inequality(TransformOrigin lhs, TransformOrigin rhs) { }

	// RVA: 0x2F0B410 Offset: 0x2F09E10 VA: 0x182F0B410 Slot: 4
	public bool Equals(TransformOrigin other) { }

	// RVA: 0x2F0B4B0 Offset: 0x2F09EB0 VA: 0x182F0B4B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F0B5D0 Offset: 0x2F09FD0 VA: 0x182F0B5D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F0B6D0 Offset: 0x2F0A0D0 VA: 0x182F0B6D0 Slot: 3
	public override string ToString() { }
}
