public struct Length : IEquatable<Length> // TypeDefIndex: 6806
{
	// Fields
	internal const float k_MaxValue = 8388608;
	[SerializeField]
	private float m_Value; // 0x0
	[SerializeField]
	private Length.Unit m_Unit; // 0x4

	// Properties
	public float value { get; set; }
	public LengthUnit unit { get; }

	// Methods

	// RVA: 0x2EFDC90 Offset: 0x2EFC690 VA: 0x182EFDC90
	public static Length Percent(float value) { }

	// RVA: 0x2EFDB80 Offset: 0x2EFC580 VA: 0x182EFDB80
	public static Length Auto() { }

	// RVA: 0x2EFDC70 Offset: 0x2EFC670 VA: 0x182EFDC70
	public static Length None() { }

	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780
	public float get_value() { }

	// RVA: 0x2EFDEF0 Offset: 0x2EFC8F0 VA: 0x182EFDEF0
	public void set_value(float value) { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public LengthUnit get_unit() { }

	// RVA: 0x2EFDC50 Offset: 0x2EFC650 VA: 0x182EFDC50
	public bool IsAuto() { }

	// RVA: 0x2EFDC60 Offset: 0x2EFC660 VA: 0x182EFDC60
	public bool IsNone() { }

	// RVA: 0x2EFDE50 Offset: 0x2EFC850 VA: 0x182EFDE50
	public void .ctor(float value) { }

	// RVA: 0x2EFDE20 Offset: 0x2EFC820 VA: 0x182EFDE20
	public void .ctor(float value, LengthUnit unit) { }

	// RVA: 0x2EFDE20 Offset: 0x2EFC820 VA: 0x182EFDE20
	private void .ctor(float value, Length.Unit unit) { }

	// RVA: 0x2EFDE80 Offset: 0x2EFC880 VA: 0x182EFDE80
	public static Length op_Implicit(float value) { }

	// RVA: 0x2ED1BB0 Offset: 0x2ED05B0 VA: 0x182ED1BB0
	public static bool op_Equality(Length lhs, Length rhs) { }

	// RVA: 0x2EFDEC0 Offset: 0x2EFC8C0 VA: 0x182EFDEC0
	public static bool op_Inequality(Length lhs, Length rhs) { }

	// RVA: 0x2ED1980 Offset: 0x2ED0380 VA: 0x182ED1980 Slot: 4
	public bool Equals(Length other) { }

	// RVA: 0x2EFDBA0 Offset: 0x2EFC5A0 VA: 0x182EFDBA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2ED19B0 Offset: 0x2ED03B0 VA: 0x182ED19B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2EFDCD0 Offset: 0x2EFC6D0 VA: 0x182EFDCD0 Slot: 3
	public override string ToString() { }
}
