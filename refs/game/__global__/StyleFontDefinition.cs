public struct StyleFontDefinition : IStyleValue<FontDefinition>, IEquatable<StyleFontDefinition> // TypeDefIndex: 6817
{
	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private FontDefinition m_Value; // 0x8

	// Properties
	public FontDefinition value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2F01380 Offset: 0x2EFFD80 VA: 0x182F01380 Slot: 4
	public FontDefinition get_value() { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2F01360 Offset: 0x2EFFD60 VA: 0x182F01360
	public void .ctor(FontDefinition f) { }

	// RVA: 0x2F01340 Offset: 0x2EFFD40 VA: 0x182F01340
	internal void .ctor(FontDefinition f, StyleKeyword keyword) { }

	// RVA: 0x2F013A0 Offset: 0x2EFFDA0 VA: 0x182F013A0
	public static StyleFontDefinition op_Implicit(FontDefinition f) { }

	// RVA: 0x2F012C0 Offset: 0x2EFFCC0 VA: 0x182F012C0 Slot: 6
	public bool Equals(StyleFontDefinition other) { }

	// RVA: 0x2F01200 Offset: 0x2EFFC00 VA: 0x182F01200 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F01310 Offset: 0x2EFFD10 VA: 0x182F01310 Slot: 2
	public override int GetHashCode() { }
}
