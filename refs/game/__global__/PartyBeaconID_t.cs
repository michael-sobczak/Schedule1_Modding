public struct PartyBeaconID_t : IEquatable<PartyBeaconID_t>, IComparable<PartyBeaconID_t> // TypeDefIndex: 14810
{
	// Fields
	public static readonly PartyBeaconID_t Invalid; // 0x0
	public ulong m_PartyBeaconID; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong value) { }

	// RVA: 0xC7C0D0 Offset: 0xC7AAD0 VA: 0x180C7C0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCB0BA0 Offset: 0xCAF5A0 VA: 0x180CB0BA0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7BE00 Offset: 0xC7A800 VA: 0x180C7BE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(PartyBeaconID_t x, PartyBeaconID_t y) { }

	// RVA: 0xCB0C80 Offset: 0xCAF680 VA: 0x180CB0C80
	public static bool op_Inequality(PartyBeaconID_t x, PartyBeaconID_t y) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static PartyBeaconID_t op_Explicit(ulong value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(PartyBeaconID_t that) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 4
	public bool Equals(PartyBeaconID_t other) { }

	// RVA: 0xC7BD50 Offset: 0xC7A750 VA: 0x180C7BD50 Slot: 5
	public int CompareTo(PartyBeaconID_t other) { }

	// RVA: 0xCB0C40 Offset: 0xCAF640 VA: 0x180CB0C40
	private static void .cctor() { }
}
