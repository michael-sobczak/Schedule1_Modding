public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate> // TypeDefIndex: 6822
{
	// Fields
	private Translate m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x18

	// Properties
	public Translate value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2F06110 Offset: 0x2F04B10 VA: 0x182F06110 Slot: 4
	public Translate get_value() { }

	// RVA: 0x10EB2A0 Offset: 0x10E9CA0 VA: 0x1810EB2A0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2F060F0 Offset: 0x2F04AF0 VA: 0x182F060F0
	public void .ctor(Translate v) { }

	// RVA: 0x2F036E0 Offset: 0x2F020E0 VA: 0x182F036E0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x2F03710 Offset: 0x2F02110 VA: 0x182F03710
	internal void .ctor(Translate v, StyleKeyword keyword) { }

	// RVA: 0x2F061C0 Offset: 0x2F04BC0 VA: 0x182F061C0
	public static bool op_Equality(StyleTranslate lhs, StyleTranslate rhs) { }

	// RVA: 0x2F038F0 Offset: 0x2F022F0 VA: 0x182F038F0
	public static StyleTranslate op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x2F06250 Offset: 0x2F04C50 VA: 0x182F06250
	public static StyleTranslate op_Implicit(Translate v) { }

	// RVA: 0x2F05EC0 Offset: 0x2F048C0 VA: 0x182F05EC0 Slot: 6
	public bool Equals(StyleTranslate other) { }

	// RVA: 0x2F05F50 Offset: 0x2F04950 VA: 0x182F05F50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F06050 Offset: 0x2F04A50 VA: 0x182F06050 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F06070 Offset: 0x2F04A70 VA: 0x182F06070 Slot: 3
	public override string ToString() { }
}
