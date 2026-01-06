public struct StyleCursor : IStyleValue<Cursor>, IEquatable<StyleCursor> // TypeDefIndex: 6811
{
	// Fields
	private Cursor m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x18

	// Properties
	public Cursor value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2F00F20 Offset: 0x2EFF920 VA: 0x182F00F20 Slot: 4
	public Cursor get_value() { }

	// RVA: 0x10EB2A0 Offset: 0x10E9CA0 VA: 0x1810EB2A0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2F00ED0 Offset: 0x2EFF8D0 VA: 0x182F00ED0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x2F00F00 Offset: 0x2EFF900 VA: 0x182F00F00
	internal void .ctor(Cursor v, StyleKeyword keyword) { }

	// RVA: 0x2F00F70 Offset: 0x2EFF970 VA: 0x182F00F70
	public static bool op_Equality(StyleCursor lhs, StyleCursor rhs) { }

	// RVA: 0x2F00FE0 Offset: 0x2EFF9E0 VA: 0x182F00FE0
	public static StyleCursor op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x2F00D00 Offset: 0x2EFF700 VA: 0x182F00D00 Slot: 6
	public bool Equals(StyleCursor other) { }

	// RVA: 0x2F00D70 Offset: 0x2EFF770 VA: 0x182F00D70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F00E40 Offset: 0x2EFF840 VA: 0x182F00E40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F00E60 Offset: 0x2EFF860 VA: 0x182F00E60 Slot: 3
	public override string ToString() { }
}
