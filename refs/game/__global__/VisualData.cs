internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData> // TypeDefIndex: 6802
{
	// Fields
	public Color backgroundColor; // 0x0
	public Background backgroundImage; // 0x10
	public BackgroundPosition backgroundPositionX; // 0x30
	public BackgroundPosition backgroundPositionY; // 0x3C
	public BackgroundRepeat backgroundRepeat; // 0x48
	public BackgroundSize backgroundSize; // 0x50
	public Color borderBottomColor; // 0x64
	public Length borderBottomLeftRadius; // 0x74
	public Length borderBottomRightRadius; // 0x7C
	public Color borderLeftColor; // 0x84
	public Color borderRightColor; // 0x94
	public Color borderTopColor; // 0xA4
	public Length borderTopLeftRadius; // 0xB4
	public Length borderTopRightRadius; // 0xBC
	public float opacity; // 0xC4
	public OverflowInternal overflow; // 0xC8

	// Methods

	// RVA: 0x2EFAB70 Offset: 0x2EF9570 VA: 0x182EFAB70 Slot: 4
	public VisualData Copy() { }

	// RVA: 0x2F12C50 Offset: 0x2F11650 VA: 0x182F12C50 Slot: 5
	public void CopyFrom(ref VisualData other) { }

	// RVA: 0x2F13170 Offset: 0x2F11B70 VA: 0x182F13170
	public static bool op_Equality(VisualData lhs, VisualData rhs) { }

	// RVA: 0x2F12D70 Offset: 0x2F11770 VA: 0x182F12D70 Slot: 6
	public bool Equals(VisualData other) { }

	// RVA: 0x2F12EA0 Offset: 0x2F118A0 VA: 0x182F12EA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F12FD0 Offset: 0x2F119D0 VA: 0x182F12FD0 Slot: 2
	public override int GetHashCode() { }
}
