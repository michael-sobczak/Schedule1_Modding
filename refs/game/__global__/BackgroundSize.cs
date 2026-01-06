public struct BackgroundSize : IEquatable<BackgroundSize> // TypeDefIndex: 6171
{
	// Fields
	private BackgroundSizeType m_SizeType; // 0x0
	private Length m_X; // 0x4
	private Length m_Y; // 0xC

	// Properties
	public BackgroundSizeType sizeType { get; set; }
	public Length x { get; set; }
	public Length y { get; set; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public BackgroundSizeType get_sizeType() { }

	// RVA: 0x2DA94F0 Offset: 0x2DA7EF0 VA: 0x182DA94F0
	public void set_sizeType(BackgroundSizeType value) { }

	// RVA: 0x1CD2DD0 Offset: 0x1CD17D0 VA: 0x181CD2DD0
	public Length get_x() { }

	// RVA: 0x2DA9650 Offset: 0x2DA8050 VA: 0x182DA9650
	public void set_x(Length value) { }

	// RVA: 0x2DA9550 Offset: 0x2DA7F50 VA: 0x182DA9550
	public Length get_y() { }

	// RVA: 0x2DA9660 Offset: 0x2DA8060 VA: 0x182DA9660
	public void set_y(Length value) { }

	// RVA: 0x2DA94E0 Offset: 0x2DA7EE0 VA: 0x182DA94E0
	public void .ctor(Length sizeX, Length sizeY) { }

	// RVA: 0x2DA94F0 Offset: 0x2DA7EF0 VA: 0x182DA94F0
	public void .ctor(BackgroundSizeType sizeType) { }

	// RVA: 0x2DA93C0 Offset: 0x2DA7DC0 VA: 0x182DA93C0
	internal static BackgroundSize Initial() { }

	// RVA: 0x2DA9240 Offset: 0x2DA7C40 VA: 0x182DA9240 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2DA9310 Offset: 0x2DA7D10 VA: 0x182DA9310 Slot: 4
	public bool Equals(BackgroundSize other) { }

	// RVA: 0x2DA9370 Offset: 0x2DA7D70 VA: 0x182DA9370 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2DA9560 Offset: 0x2DA7F60 VA: 0x182DA9560
	public static bool op_Equality(BackgroundSize style1, BackgroundSize style2) { }

	// RVA: 0x2DA95D0 Offset: 0x2DA7FD0 VA: 0x182DA95D0
	public static bool op_Inequality(BackgroundSize style1, BackgroundSize style2) { }

	// RVA: 0x2DA9420 Offset: 0x2DA7E20 VA: 0x182DA9420 Slot: 3
	public override string ToString() { }
}
