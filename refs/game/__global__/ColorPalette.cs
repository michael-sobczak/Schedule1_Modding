public sealed class ColorPalette // TypeDefIndex: 17205
{
	// Fields
	private int _flags; // 0x10
	private Color[] _entries; // 0x18

	// Properties
	public Color[] Entries { get; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Color[] get_Entries() { }

	// RVA: 0x214FD90 Offset: 0x214E790 VA: 0x18214FD90
	internal void .ctor() { }

	// RVA: 0x214F9E0 Offset: 0x214E3E0 VA: 0x18214F9E0
	internal void ConvertFromMemory(IntPtr memory) { }

	// RVA: 0x214FB70 Offset: 0x214E570 VA: 0x18214FB70
	internal IntPtr ConvertToMemory() { }
}
