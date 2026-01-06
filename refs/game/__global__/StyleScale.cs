public struct StyleScale : IStyleValue<Scale>, IEquatable<StyleScale> // TypeDefIndex: 6821
{
	// Fields
	private Scale m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x10

	// Properties
	public Scale value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2F03B50 Offset: 0x2F02550 VA: 0x182F03B50 Slot: 4
	public Scale get_value() { }

	// RVA: 0x1E13C60 Offset: 0x1E12660 VA: 0x181E13C60 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2F03B40 Offset: 0x2F02540 VA: 0x182F03B40
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x18CC9C0 Offset: 0x18CB3C0 VA: 0x1818CC9C0
	internal void .ctor(Scale v, StyleKeyword keyword) { }

	// RVA: 0x2F03C10 Offset: 0x2F02610 VA: 0x182F03C10
	public static bool op_Equality(StyleScale lhs, StyleScale rhs) { }

	// RVA: 0x2F03C80 Offset: 0x2F02680 VA: 0x182F03C80
	public static StyleScale op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x2F03920 Offset: 0x2F02320 VA: 0x182F03920 Slot: 6
	public bool Equals(StyleScale other) { }

	// RVA: 0x2F03990 Offset: 0x2F02390 VA: 0x182F03990 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F03A70 Offset: 0x2F02470 VA: 0x182F03A70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F03AD0 Offset: 0x2F024D0 VA: 0x182F03AD0 Slot: 3
	public override string ToString() { }
}
