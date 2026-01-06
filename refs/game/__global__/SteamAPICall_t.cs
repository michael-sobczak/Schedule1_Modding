public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t> // TypeDefIndex: 14812
{
	// Fields
	public static readonly SteamAPICall_t Invalid; // 0x0
	public ulong m_SteamAPICall; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong value) { }

	// RVA: 0xC7C0D0 Offset: 0xC7AAD0 VA: 0x180C7C0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCBE510 Offset: 0xCBCF10 VA: 0x180CBE510 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7BE00 Offset: 0xC7A800 VA: 0x180C7BE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(SteamAPICall_t x, SteamAPICall_t y) { }

	// RVA: 0xCBE5F0 Offset: 0xCBCFF0 VA: 0x180CBE5F0
	public static bool op_Inequality(SteamAPICall_t x, SteamAPICall_t y) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static SteamAPICall_t op_Explicit(ulong value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(SteamAPICall_t that) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 4
	public bool Equals(SteamAPICall_t other) { }

	// RVA: 0xC7BD50 Offset: 0xC7A750 VA: 0x180C7BD50 Slot: 5
	public int CompareTo(SteamAPICall_t other) { }

	// RVA: 0xCBE5B0 Offset: 0xCBCFB0 VA: 0x180CBE5B0
	private static void .cctor() { }
}
