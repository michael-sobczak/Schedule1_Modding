public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt> // TypeDefIndex: 6818
{
	// Fields
	private int m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x4

	// Properties
	public int value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x11EB250 Offset: 0x11E9C50 VA: 0x1811EB250 Slot: 4
	public int get_value() { }

	// RVA: 0x11EB070 Offset: 0x11E9A70 VA: 0x1811EB070 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2F01190 Offset: 0x2EFFB90 VA: 0x182F01190
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x11EB010 Offset: 0x11E9A10 VA: 0x1811EB010
	internal void .ctor(int v, StyleKeyword keyword) { }

	// RVA: 0x2F01880 Offset: 0x2F00280 VA: 0x182F01880
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	// RVA: 0x2F011E0 Offset: 0x2EFFBE0 VA: 0x182F011E0
	public static StyleInt op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x2F017F0 Offset: 0x2F001F0 VA: 0x182F017F0 Slot: 6
	public bool Equals(StyleInt other) { }

	// RVA: 0x2F01750 Offset: 0x2F00150 VA: 0x182F01750 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CF79A0 Offset: 0x2CF63A0 VA: 0x182CF79A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F01820 Offset: 0x2F00220 VA: 0x182F01820 Slot: 3
	public override string ToString() { }
}
