public struct HSteamListenSocket : IEquatable<HSteamListenSocket>, IComparable<HSteamListenSocket> // TypeDefIndex: 14790
{
	// Fields
	public static readonly HSteamListenSocket Invalid; // 0x0
	public uint m_HSteamListenSocket; // 0x0

	// Methods

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(uint value) { }

	// RVA: 0xC7B8B0 Offset: 0xC7A2B0 VA: 0x180C7B8B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xC82D30 Offset: 0xC81730 VA: 0x180C82D30 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7B8A0 Offset: 0xC7A2A0 VA: 0x180C7B8A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7B900 Offset: 0xC7A300 VA: 0x180C7B900
	public static bool op_Equality(HSteamListenSocket x, HSteamListenSocket y) { }

	// RVA: 0xC82E10 Offset: 0xC81810 VA: 0x180C82E10
	public static bool op_Inequality(HSteamListenSocket x, HSteamListenSocket y) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static HSteamListenSocket op_Explicit(uint value) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static uint op_Explicit(HSteamListenSocket that) { }

	// RVA: 0xC7B890 Offset: 0xC7A290 VA: 0x180C7B890 Slot: 4
	public bool Equals(HSteamListenSocket other) { }

	// RVA: 0xC7B7E0 Offset: 0xC7A1E0 VA: 0x180C7B7E0 Slot: 5
	public int CompareTo(HSteamListenSocket other) { }

	// RVA: 0xC82DD0 Offset: 0xC817D0 VA: 0x180C82DD0
	private static void .cctor() { }
}
