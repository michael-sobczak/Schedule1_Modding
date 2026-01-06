public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t> // TypeDefIndex: 14817
{
	// Fields
	public ulong m_SteamLeaderboard; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong value) { }

	// RVA: 0xC7C0D0 Offset: 0xC7AAD0 VA: 0x180C7C0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCBEC30 Offset: 0xCBD630 VA: 0x180CBEC30 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7BE00 Offset: 0xC7A800 VA: 0x180C7BE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(SteamLeaderboard_t x, SteamLeaderboard_t y) { }

	// RVA: 0xC7C200 Offset: 0xC7AC00 VA: 0x180C7C200
	public static bool op_Inequality(SteamLeaderboard_t x, SteamLeaderboard_t y) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static SteamLeaderboard_t op_Explicit(ulong value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(SteamLeaderboard_t that) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 4
	public bool Equals(SteamLeaderboard_t other) { }

	// RVA: 0xC7BD50 Offset: 0xC7A750 VA: 0x180C7BD50 Slot: 5
	public int CompareTo(SteamLeaderboard_t other) { }
}
