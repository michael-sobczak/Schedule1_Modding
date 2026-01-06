public struct BackgroundPosition : IEquatable<BackgroundPosition> // TypeDefIndex: 6168
{
	// Fields
	public BackgroundPositionKeyword keyword; // 0x0
	public Length offset; // 0x4

	// Methods

	// RVA: 0x2DA8AE0 Offset: 0x2DA74E0 VA: 0x182DA8AE0
	public void .ctor(BackgroundPositionKeyword keyword) { }

	// RVA: 0x1330BC0 Offset: 0x132F5C0 VA: 0x181330BC0
	public void .ctor(BackgroundPositionKeyword keyword, Length offset) { }

	// RVA: 0x2DA89F0 Offset: 0x2DA73F0 VA: 0x182DA89F0
	internal static BackgroundPosition Initial() { }

	// RVA: 0x2DA8900 Offset: 0x2DA7300 VA: 0x182DA8900 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2DA88B0 Offset: 0x2DA72B0 VA: 0x182DA88B0 Slot: 4
	public bool Equals(BackgroundPosition other) { }

	// RVA: 0x2DA89B0 Offset: 0x2DA73B0 VA: 0x182DA89B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2DA8B20 Offset: 0x2DA7520 VA: 0x182DA8B20
	public static bool op_Equality(BackgroundPosition style1, BackgroundPosition style2) { }

	// RVA: 0x2DA8B90 Offset: 0x2DA7590 VA: 0x182DA8B90
	public static bool op_Inequality(BackgroundPosition style1, BackgroundPosition style2) { }

	// RVA: 0x2DA8A40 Offset: 0x2DA7440 VA: 0x182DA8A40 Slot: 3
	public override string ToString() { }
}
