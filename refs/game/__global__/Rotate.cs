public struct Rotate : IEquatable<Rotate> // TypeDefIndex: 6807
{
	// Fields
	private Angle m_Angle; // 0x0
	private Vector3 m_Axis; // 0x8
	private bool m_IsNone; // 0x14

	// Properties
	public Angle angle { get; set; }
	internal Vector3 axis { get; }

	// Methods

	// RVA: 0x2EFF0F0 Offset: 0x2EFDAF0 VA: 0x182EFF0F0
	public void .ctor(Angle angle) { }

	// RVA: 0x2EFEEF0 Offset: 0x2EFD8F0 VA: 0x182EFEEF0
	internal static Rotate Initial() { }

	// RVA: 0x2EFEF80 Offset: 0x2EFD980 VA: 0x182EFEF80
	public static Rotate None() { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public Angle get_angle() { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void set_angle(Angle value) { }

	// RVA: 0xB0F630 Offset: 0xB0E030 VA: 0x180B0F630
	internal Vector3 get_axis() { }

	// RVA: 0x2EFF140 Offset: 0x2EFDB40 VA: 0x182EFF140
	public static bool op_Equality(Rotate lhs, Rotate rhs) { }

	// RVA: 0x2EFF230 Offset: 0x2EFDC30 VA: 0x182EFF230
	public static bool op_Inequality(Rotate lhs, Rotate rhs) { }

	// RVA: 0x2EFED40 Offset: 0x2EFD740 VA: 0x182EFED40 Slot: 4
	public bool Equals(Rotate other) { }

	// RVA: 0x2EFECA0 Offset: 0x2EFD6A0 VA: 0x182EFECA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2EFEE20 Offset: 0x2EFD820 VA: 0x182EFEE20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2EFF080 Offset: 0x2EFDA80 VA: 0x182EFF080 Slot: 3
	public override string ToString() { }

	// RVA: 0x2EFF020 Offset: 0x2EFDA20 VA: 0x182EFF020
	internal Quaternion ToQuaternion() { }
}
