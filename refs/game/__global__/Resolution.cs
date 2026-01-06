public struct Resolution // TypeDefIndex: 11657
{
	// Fields
	private int m_Width; // 0x0
	private int m_Height; // 0x4
	private RefreshRate m_RefreshRate; // 0x8

	// Properties
	public int width { get; }
	public int height { get; }
	public RefreshRate refreshRateRatio { get; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public int get_width() { }

	// RVA: 0x11EB070 Offset: 0x11E9A70 VA: 0x1811EB070
	public int get_height() { }

	// RVA: 0x1CD2DF0 Offset: 0x1CD17F0 VA: 0x181CD2DF0
	public RefreshRate get_refreshRateRatio() { }

	// RVA: 0x2C9F160 Offset: 0x2C9DB60 VA: 0x182C9F160 Slot: 3
	public override string ToString() { }
}
