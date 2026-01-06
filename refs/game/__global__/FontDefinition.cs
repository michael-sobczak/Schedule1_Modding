public struct FontDefinition : IEquatable<FontDefinition> // TypeDefIndex: 6778
{
	// Fields
	private Font m_Font; // 0x0
	private FontAsset m_FontAsset; // 0x8

	// Properties
	public Font font { get; }
	public FontAsset fontAsset { get; }

	// Methods

	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	public Font get_font() { }

	// RVA: 0x1CD2DF0 Offset: 0x1CD17F0 VA: 0x181CD2DF0
	public FontAsset get_fontAsset() { }

	// RVA: 0x2ED7C80 Offset: 0x2ED6680 VA: 0x182ED7C80
	public static FontDefinition FromFont(Font f) { }

	// RVA: 0x2ED7E10 Offset: 0x2ED6810 VA: 0x182ED7E10
	public static FontDefinition FromSDFFont(FontAsset f) { }

	// RVA: 0x2ED7CC0 Offset: 0x2ED66C0 VA: 0x182ED7CC0
	internal static FontDefinition FromObject(object obj) { }

	// RVA: 0x2ED7F40 Offset: 0x2ED6940 VA: 0x182ED7F40
	internal bool IsEmpty() { }

	// RVA: 0x2ED7FD0 Offset: 0x2ED69D0 VA: 0x182ED7FD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2ED7C30 Offset: 0x2ED6630 VA: 0x182ED7C30 Slot: 4
	public bool Equals(FontDefinition other) { }

	// RVA: 0x2ED7B80 Offset: 0x2ED6580 VA: 0x182ED7B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2ED7E50 Offset: 0x2ED6850 VA: 0x182ED7E50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2ED7C30 Offset: 0x2ED6630 VA: 0x182ED7C30
	public static bool op_Equality(FontDefinition left, FontDefinition right) { }

	// RVA: 0x2ED8060 Offset: 0x2ED6A60 VA: 0x182ED8060
	public static bool op_Inequality(FontDefinition left, FontDefinition right) { }
}
