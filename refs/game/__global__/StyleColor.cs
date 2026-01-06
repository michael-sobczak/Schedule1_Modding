public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor> // TypeDefIndex: 6810
{
	// Fields
	private Color m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x10

	// Properties
	public Color value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2EFFCC0 Offset: 0x2EFE6C0 VA: 0x182EFFCC0 Slot: 4
	public Color get_value() { }

	// RVA: 0x1E13C60 Offset: 0x1E12660 VA: 0x181E13C60 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x1BB81F0 Offset: 0x1BB6BF0 VA: 0x181BB81F0
	public void .ctor(Color v) { }

	// RVA: 0x18CC9C0 Offset: 0x18CB3C0 VA: 0x1818CC9C0
	internal void .ctor(Color v, StyleKeyword keyword) { }

	// RVA: 0x2EFFCE0 Offset: 0x2EFE6E0 VA: 0x182EFFCE0
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	// RVA: 0x2EFFD60 Offset: 0x2EFE760 VA: 0x182EFFD60
	public static StyleColor op_Implicit(Color v) { }

	// RVA: 0x2EFFAB0 Offset: 0x2EFE4B0 VA: 0x182EFFAB0 Slot: 6
	public bool Equals(StyleColor other) { }

	// RVA: 0x2EFFB30 Offset: 0x2EFE530 VA: 0x182EFFB30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2EFFC30 Offset: 0x2EFE630 VA: 0x182EFFC30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2EFFC50 Offset: 0x2EFE650 VA: 0x182EFFC50 Slot: 3
	public override string ToString() { }
}
