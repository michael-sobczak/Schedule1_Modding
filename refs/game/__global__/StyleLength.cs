public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength> // TypeDefIndex: 6819
{
	// Fields
	private Length m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x8

	// Properties
	public Length value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2F01B70 Offset: 0x2F00570 VA: 0x182F01B70 Slot: 4
	public Length get_value() { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2F01AA0 Offset: 0x2F004A0 VA: 0x182F01AA0
	public void .ctor(float v) { }

	// RVA: 0x2F01B40 Offset: 0x2F00540 VA: 0x182F01B40
	public void .ctor(Length v) { }

	// RVA: 0x2F01B00 Offset: 0x2F00500 VA: 0x182F01B00
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x2F01B10 Offset: 0x2F00510 VA: 0x182F01B10
	internal void .ctor(Length v, StyleKeyword keyword) { }

	// RVA: 0x2F01B90 Offset: 0x2F00590 VA: 0x182F01B90
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	// RVA: 0x2F01C10 Offset: 0x2F00610 VA: 0x182F01C10
	public static StyleLength op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x2F01C30 Offset: 0x2F00630 VA: 0x182F01C30
	public static StyleLength op_Implicit(float v) { }

	// RVA: 0x2F01BD0 Offset: 0x2F005D0 VA: 0x182F01BD0
	public static StyleLength op_Implicit(Length v) { }

	// RVA: 0x2F018A0 Offset: 0x2F002A0 VA: 0x182F018A0 Slot: 6
	public bool Equals(StyleLength other) { }

	// RVA: 0x2F01910 Offset: 0x2F00310 VA: 0x182F01910 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F01A00 Offset: 0x2F00400 VA: 0x182F01A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F01A30 Offset: 0x2F00430 VA: 0x182F01A30 Slot: 3
	public override string ToString() { }
}
