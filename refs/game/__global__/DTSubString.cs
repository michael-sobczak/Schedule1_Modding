internal struct DTSubString // TypeDefIndex: 3643
{
	// Fields
	internal ReadOnlySpan<char> s; // 0x0
	internal int index; // 0x10
	internal int length; // 0x14
	internal DTSubStringType type; // 0x18
	internal int value; // 0x1C

	// Properties
	internal char Item { get; }

	// Methods

	// RVA: 0x1C5FBE0 Offset: 0x1C5E5E0 VA: 0x181C5FBE0
	internal char get_Item(int relativeIndex) { }
}
