public struct DisplayInfo : IEquatable<DisplayInfo> // TypeDefIndex: 11644
{
	// Fields
	internal ulong handle; // 0x0
	public int width; // 0x8
	public int height; // 0xC
	public RefreshRate refreshRate; // 0x10
	public RectInt workArea; // 0x18
	public string name; // 0x28

	// Methods

	// RVA: 0x1812170 Offset: 0x1810B70 VA: 0x181812170 Slot: 4
	public bool Equals(DisplayInfo other) { }
}
