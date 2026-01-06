public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow> // TypeDefIndex: 6823
{
	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private TextShadow m_Value; // 0x4

	// Properties
	public TextShadow value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2F05950 Offset: 0x2F04350 VA: 0x182F05950 Slot: 4
	public TextShadow get_value() { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2F05900 Offset: 0x2F04300 VA: 0x182F05900
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x2F05930 Offset: 0x2F04330 VA: 0x182F05930
	internal void .ctor(TextShadow v, StyleKeyword keyword) { }

	// RVA: 0x2F059A0 Offset: 0x2F043A0 VA: 0x182F059A0
	public static bool op_Equality(StyleTextShadow lhs, StyleTextShadow rhs) { }

	// RVA: 0x2F05A50 Offset: 0x2F04450 VA: 0x182F05A50
	public static StyleTextShadow op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x2F057A0 Offset: 0x2F041A0 VA: 0x182F057A0 Slot: 6
	public bool Equals(StyleTextShadow other) { }

	// RVA: 0x2F05670 Offset: 0x2F04070 VA: 0x182F05670 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F05850 Offset: 0x2F04250 VA: 0x182F05850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F05890 Offset: 0x2F04290 VA: 0x182F05890 Slot: 3
	public override string ToString() { }
}
