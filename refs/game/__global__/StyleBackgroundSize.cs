public struct StyleBackgroundSize : IStyleValue<BackgroundSize>, IEquatable<StyleBackgroundSize> // TypeDefIndex: 6809
{
	// Fields
	private BackgroundSize m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x14

	// Properties
	public BackgroundSize value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2EFF9B0 Offset: 0x2EFE3B0 VA: 0x182EFF9B0 Slot: 4
	public BackgroundSize get_value() { }

	// RVA: 0x1667070 Offset: 0x1665A70 VA: 0x181667070 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2EFF9A0 Offset: 0x2EFE3A0 VA: 0x182EFF9A0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x2EFF980 Offset: 0x2EFE380 VA: 0x182EFF980
	internal void .ctor(BackgroundSize v, StyleKeyword keyword) { }

	// RVA: 0x2EFF9E0 Offset: 0x2EFE3E0 VA: 0x182EFF9E0
	public static bool op_Equality(StyleBackgroundSize lhs, StyleBackgroundSize rhs) { }

	// RVA: 0x2EFFA80 Offset: 0x2EFE480 VA: 0x182EFFA80
	public static StyleBackgroundSize op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x2EFF850 Offset: 0x2EFE250 VA: 0x182EFF850 Slot: 6
	public bool Equals(StyleBackgroundSize other) { }

	// RVA: 0x2EFF730 Offset: 0x2EFE130 VA: 0x182EFF730 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2EFF8F0 Offset: 0x2EFE2F0 VA: 0x182EFF8F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2EFF910 Offset: 0x2EFE310 VA: 0x182EFF910 Slot: 3
	public override string ToString() { }
}
