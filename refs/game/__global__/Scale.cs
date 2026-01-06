public struct Scale : IEquatable<Scale> // TypeDefIndex: 6808
{
	// Fields
	private Vector3 m_Scale; // 0x0
	private bool m_IsNone; // 0xC

	// Properties
	public Vector3 value { get; }

	// Methods

	// RVA: 0x2EFF5E0 Offset: 0x2EFDFE0 VA: 0x182EFF5E0
	public void .ctor(Vector3 scale) { }

	// RVA: 0x2EFF4A0 Offset: 0x2EFDEA0 VA: 0x182EFF4A0
	internal static Scale Initial() { }

	// RVA: 0x2EFF5A0 Offset: 0x2EFDFA0 VA: 0x182EFF5A0
	public static Scale None() { }

	// RVA: 0x5762D0 Offset: 0x574CD0 VA: 0x1805762D0
	public Vector3 get_value() { }

	// RVA: 0x2EFF680 Offset: 0x2EFE080 VA: 0x182EFF680
	public static bool op_Equality(Scale lhs, Scale rhs) { }

	// RVA: 0x2EFF6E0 Offset: 0x2EFE0E0 VA: 0x182EFF6E0
	public static bool op_Inequality(Scale lhs, Scale rhs) { }

	// RVA: 0x2EFF320 Offset: 0x2EFDD20 VA: 0x182EFF320 Slot: 4
	public bool Equals(Scale other) { }

	// RVA: 0x2EFF370 Offset: 0x2EFDD70 VA: 0x182EFF370 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2EFF440 Offset: 0x2EFDE40 VA: 0x182EFF440 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CB77C0 Offset: 0x2CB61C0 VA: 0x182CB77C0 Slot: 3
	public override string ToString() { }
}
