public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat> // TypeDefIndex: 6815
{
	// Fields
	private float m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x4

	// Properties
	public float value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2F011A0 Offset: 0x2EFFBA0 VA: 0x182F011A0 Slot: 4
	public float get_value() { }

	// RVA: 0x11EB070 Offset: 0x11E9A70 VA: 0x1811EB070 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2F01180 Offset: 0x2EFFB80 VA: 0x182F01180
	public void .ctor(float v) { }

	// RVA: 0x2F01190 Offset: 0x2EFFB90 VA: 0x182F01190
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x14DE9E0 Offset: 0x14DD3E0 VA: 0x1814DE9E0
	internal void .ctor(float v, StyleKeyword keyword) { }

	// RVA: 0x2F011B0 Offset: 0x2EFFBB0 VA: 0x182F011B0
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	// RVA: 0x2F011E0 Offset: 0x2EFFBE0 VA: 0x182F011E0
	public static StyleFloat op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x2ED1BE0 Offset: 0x2ED05E0 VA: 0x182ED1BE0
	public static StyleFloat op_Implicit(float v) { }

	// RVA: 0x2F010F0 Offset: 0x2EFFAF0 VA: 0x182F010F0 Slot: 6
	public bool Equals(StyleFloat other) { }

	// RVA: 0x2F01040 Offset: 0x2EFFA40 VA: 0x182F01040 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2ED19B0 Offset: 0x2ED03B0 VA: 0x182ED19B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F01120 Offset: 0x2EFFB20 VA: 0x182F01120 Slot: 3
	public override string ToString() { }
}
