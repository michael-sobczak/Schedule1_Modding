public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t> // TypeDefIndex: 14782
{
	// Fields
	public static readonly SteamItemInstanceID_t Invalid; // 0x0
	public ulong m_SteamItemInstanceID; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong value) { }

	// RVA: 0xC7C0D0 Offset: 0xC7AAD0 VA: 0x180C7C0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCB2D20 Offset: 0xCB1720 VA: 0x180CB2D20 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7BE00 Offset: 0xC7A800 VA: 0x180C7BE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(SteamItemInstanceID_t x, SteamItemInstanceID_t y) { }

	// RVA: 0xCB2E00 Offset: 0xCB1800 VA: 0x180CB2E00
	public static bool op_Inequality(SteamItemInstanceID_t x, SteamItemInstanceID_t y) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static SteamItemInstanceID_t op_Explicit(ulong value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(SteamItemInstanceID_t that) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 4
	public bool Equals(SteamItemInstanceID_t other) { }

	// RVA: 0xC7BD50 Offset: 0xC7A750 VA: 0x180C7BD50 Slot: 5
	public int CompareTo(SteamItemInstanceID_t other) { }

	// RVA: 0xCB2DC0 Offset: 0xCB17C0 VA: 0x180CB2DC0
	private static void .cctor() { }
}
