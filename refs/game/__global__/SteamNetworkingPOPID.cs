public struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID> // TypeDefIndex: 14800
{
	// Fields
	public uint m_SteamNetworkingPOPID; // 0x0

	// Methods

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(uint value) { }

	// RVA: 0xC7B8B0 Offset: 0xC7A2B0 VA: 0x180C7B8B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCB3F90 Offset: 0xCB2990 VA: 0x180CB3F90 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7B8A0 Offset: 0xC7A2A0 VA: 0x180C7B8A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7B900 Offset: 0xC7A300 VA: 0x180C7B900
	public static bool op_Equality(SteamNetworkingPOPID x, SteamNetworkingPOPID y) { }

	// RVA: 0xCB1130 Offset: 0xCAFB30 VA: 0x180CB1130
	public static bool op_Inequality(SteamNetworkingPOPID x, SteamNetworkingPOPID y) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static SteamNetworkingPOPID op_Explicit(uint value) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static uint op_Explicit(SteamNetworkingPOPID that) { }

	// RVA: 0xC7B890 Offset: 0xC7A290 VA: 0x180C7B890 Slot: 4
	public bool Equals(SteamNetworkingPOPID other) { }

	// RVA: 0xC7B7E0 Offset: 0xC7A1E0 VA: 0x180C7B7E0 Slot: 5
	public int CompareTo(SteamNetworkingPOPID other) { }
}
