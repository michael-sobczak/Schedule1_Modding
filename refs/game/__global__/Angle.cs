public struct Angle : IEquatable<Angle> // TypeDefIndex: 6768
{
	// Fields
	private float m_Value; // 0x0
	private Angle.Unit m_Unit; // 0x4

	// Properties
	public float value { get; }

	// Methods

	// RVA: 0x2ED19D0 Offset: 0x2ED03D0 VA: 0x182ED19D0
	internal static Angle None() { }

	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780
	public float get_value() { }

	// RVA: 0x14DE9E0 Offset: 0x14DD3E0 VA: 0x1814DE9E0
	public void .ctor(float value, AngleUnit unit) { }

	// RVA: 0x14DE9E0 Offset: 0x14DD3E0 VA: 0x1814DE9E0
	private void .ctor(float value, Angle.Unit unit) { }

	// RVA: 0x2ED19F0 Offset: 0x2ED03F0 VA: 0x182ED19F0
	public float ToDegrees() { }

	// RVA: 0x2ED1BE0 Offset: 0x2ED05E0 VA: 0x182ED1BE0
	public static Angle op_Implicit(float value) { }

	// RVA: 0x2ED1BB0 Offset: 0x2ED05B0 VA: 0x182ED1BB0
	public static bool op_Equality(Angle lhs, Angle rhs) { }

	// RVA: 0x2ED1980 Offset: 0x2ED0380 VA: 0x182ED1980 Slot: 4
	public bool Equals(Angle other) { }

	// RVA: 0x2ED18D0 Offset: 0x2ED02D0 VA: 0x182ED18D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2ED19B0 Offset: 0x2ED03B0 VA: 0x182ED19B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2ED1A50 Offset: 0x2ED0450 VA: 0x182ED1A50 Slot: 3
	public override string ToString() { }
}
