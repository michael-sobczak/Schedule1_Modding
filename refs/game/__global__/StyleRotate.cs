public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate> // TypeDefIndex: 6820
{
	// Fields
	private Rotate m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x18

	// Properties
	public Rotate value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2F03730 Offset: 0x2F02130 VA: 0x182F03730 Slot: 4
	public Rotate get_value() { }

	// RVA: 0x10EB2A0 Offset: 0x10E9CA0 VA: 0x1810EB2A0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2F036E0 Offset: 0x2F020E0 VA: 0x182F036E0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x2F03710 Offset: 0x2F02110 VA: 0x182F03710
	internal void .ctor(Rotate v, StyleKeyword keyword) { }

	// RVA: 0x2F03860 Offset: 0x2F02260 VA: 0x182F03860
	public static bool op_Equality(StyleRotate lhs, StyleRotate rhs) { }

	// RVA: 0x2F038F0 Offset: 0x2F022F0 VA: 0x182F038F0
	public static StyleRotate op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x2F035B0 Offset: 0x2F01FB0 VA: 0x182F035B0 Slot: 6
	public bool Equals(StyleRotate other) { }

	// RVA: 0x2F034B0 Offset: 0x2F01EB0 VA: 0x182F034B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F03640 Offset: 0x2F02040 VA: 0x182F03640 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F03660 Offset: 0x2F02060 VA: 0x182F03660 Slot: 3
	public override string ToString() { }
}
