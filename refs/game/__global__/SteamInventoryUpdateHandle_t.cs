public struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t> // TypeDefIndex: 14780
{
	// Fields
	public static readonly SteamInventoryUpdateHandle_t Invalid; // 0x0
	public ulong m_SteamInventoryUpdateHandle; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong value) { }

	// RVA: 0xC7C0D0 Offset: 0xC7AAD0 VA: 0x180C7C0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCB2B60 Offset: 0xCB1560 VA: 0x180CB2B60 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7BE00 Offset: 0xC7A800 VA: 0x180C7BE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y) { }

	// RVA: 0xCB2C40 Offset: 0xCB1640 VA: 0x180CB2C40
	public static bool op_Inequality(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static SteamInventoryUpdateHandle_t op_Explicit(ulong value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(SteamInventoryUpdateHandle_t that) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 4
	public bool Equals(SteamInventoryUpdateHandle_t other) { }

	// RVA: 0xC7BD50 Offset: 0xC7A750 VA: 0x180C7BD50 Slot: 5
	public int CompareTo(SteamInventoryUpdateHandle_t other) { }

	// RVA: 0xCB2C00 Offset: 0xCB1600 VA: 0x180CB2C00
	private static void .cctor() { }
}
