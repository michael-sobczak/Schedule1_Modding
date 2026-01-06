public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont> // TypeDefIndex: 6816
{
	// Fields
	private Font m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x8

	// Properties
	public Font value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2F01690 Offset: 0x2F00090 VA: 0x182F01690 Slot: 4
	public Font get_value() { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2F01680 Offset: 0x2F00080 VA: 0x182F01680
	public void .ctor(Font v) { }

	// RVA: 0x2F01670 Offset: 0x2F00070 VA: 0x182F01670
	internal void .ctor(Font v, StyleKeyword keyword) { }

	// RVA: 0x2F016A0 Offset: 0x2F000A0 VA: 0x182F016A0
	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	// RVA: 0x2F01710 Offset: 0x2F00110 VA: 0x182F01710
	public static StyleFont op_Implicit(Font v) { }

	// RVA: 0x2F01500 Offset: 0x2EFFF00 VA: 0x182F01500 Slot: 6
	public bool Equals(StyleFont other) { }

	// RVA: 0x2F013F0 Offset: 0x2EFFDF0 VA: 0x182F013F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F01580 Offset: 0x2EFFF80 VA: 0x182F01580 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F01610 Offset: 0x2F00010 VA: 0x182F01610 Slot: 3
	public override string ToString() { }
}
