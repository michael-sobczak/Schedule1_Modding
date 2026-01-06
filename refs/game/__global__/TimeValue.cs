public struct TimeValue : IEquatable<TimeValue> // TypeDefIndex: 6829
{
	// Fields
	private float m_Value; // 0x0
	private TimeUnit m_Unit; // 0x4

	// Properties
	public float value { get; }
	public TimeUnit unit { get; }

	// Methods

	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780
	public float get_value() { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public TimeUnit get_unit() { }

	// RVA: 0x2F01180 Offset: 0x2EFFB80 VA: 0x182F01180
	public void .ctor(float value) { }

	// RVA: 0x14DE9E0 Offset: 0x14DD3E0 VA: 0x1814DE9E0
	public void .ctor(float value, TimeUnit unit) { }

	// RVA: 0x2ED1BE0 Offset: 0x2ED05E0 VA: 0x182ED1BE0
	public static TimeValue op_Implicit(float value) { }

	// RVA: 0x2ED1BB0 Offset: 0x2ED05B0 VA: 0x182ED1BB0
	public static bool op_Equality(TimeValue lhs, TimeValue rhs) { }

	// RVA: 0x2EFDEC0 Offset: 0x2EFC8C0 VA: 0x182EFDEC0
	public static bool op_Inequality(TimeValue lhs, TimeValue rhs) { }

	// RVA: 0x2ED1980 Offset: 0x2ED0380 VA: 0x182ED1980 Slot: 4
	public bool Equals(TimeValue other) { }

	// RVA: 0x2F0ABF0 Offset: 0x2F095F0 VA: 0x182F0ABF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2ED19B0 Offset: 0x2ED03B0 VA: 0x182ED19B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F0ACA0 Offset: 0x2F096A0 VA: 0x182F0ACA0 Slot: 3
	public override string ToString() { }
}
