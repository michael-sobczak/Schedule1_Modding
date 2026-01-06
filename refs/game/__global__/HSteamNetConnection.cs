public struct HSteamNetConnection : IEquatable<HSteamNetConnection>, IComparable<HSteamNetConnection> // TypeDefIndex: 14791
{
	// Fields
	public static readonly HSteamNetConnection Invalid; // 0x0
	public uint m_HSteamNetConnection; // 0x0

	// Methods

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(uint value) { }

	// RVA: 0xC7B8B0 Offset: 0xC7A2B0 VA: 0x180C7B8B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xC82E60 Offset: 0xC81860 VA: 0x180C82E60 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7B8A0 Offset: 0xC7A2A0 VA: 0x180C7B8A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7B900 Offset: 0xC7A300 VA: 0x180C7B900
	public static bool op_Equality(HSteamNetConnection x, HSteamNetConnection y) { }

	// RVA: 0xC82F40 Offset: 0xC81940 VA: 0x180C82F40
	public static bool op_Inequality(HSteamNetConnection x, HSteamNetConnection y) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static HSteamNetConnection op_Explicit(uint value) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static uint op_Explicit(HSteamNetConnection that) { }

	// RVA: 0xC7B890 Offset: 0xC7A290 VA: 0x180C7B890 Slot: 4
	public bool Equals(HSteamNetConnection other) { }

	// RVA: 0xC7B7E0 Offset: 0xC7A1E0 VA: 0x180C7B7E0 Slot: 5
	public int CompareTo(HSteamNetConnection other) { }

	// RVA: 0xC82F00 Offset: 0xC81900 VA: 0x180C82F00
	private static void .cctor() { }
}
