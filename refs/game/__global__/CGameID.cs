public struct CGameID : IEquatable<CGameID>, IComparable<CGameID> // TypeDefIndex: 14758
{
	// Fields
	public ulong m_GameID; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong GameID) { }

	// RVA: 0xC7C170 Offset: 0xC7AB70 VA: 0x180C7C170
	public void .ctor(AppId_t nAppID) { }

	// RVA: 0xC7C0F0 Offset: 0xC7AAF0 VA: 0x180C7C0F0
	public void .ctor(AppId_t nAppID, uint nModID) { }

	// RVA: 0xC7BE40 Offset: 0xC7A840 VA: 0x180C7BE40
	public bool IsSteamApp() { }

	// RVA: 0xC7BE10 Offset: 0xC7A810 VA: 0x180C7BE10
	public bool IsMod() { }

	// RVA: 0xC7BE30 Offset: 0xC7A830 VA: 0x180C7BE30
	public bool IsShortcut() { }

	// RVA: 0xC7BE20 Offset: 0xC7A820 VA: 0x180C7BE20
	public bool IsP2PFile() { }

	// RVA: 0xC7BD40 Offset: 0xC7A740 VA: 0x180C7BD40
	public AppId_t AppID() { }

	// RVA: 0xC7C0E0 Offset: 0xC7AAE0 VA: 0x180C7C0E0
	public CGameID.EGameIDType Type() { }

	// RVA: 0xC7BFE0 Offset: 0xC7A9E0 VA: 0x180C7BFE0
	public uint ModID() { }

	// RVA: 0xC7BE50 Offset: 0xC7A850 VA: 0x180C7BE50
	public bool IsValid() { }

	// RVA: 0xC7BFF0 Offset: 0xC7A9F0 VA: 0x180C7BFF0
	public void Reset() { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void Set(ulong GameID) { }

	// RVA: 0xC7C000 Offset: 0xC7AA00 VA: 0x180C7C000
	private void SetAppID(AppId_t other) { }

	// RVA: 0xC7C090 Offset: 0xC7AA90 VA: 0x180C7C090
	private void SetType(CGameID.EGameIDType other) { }

	// RVA: 0xC7C070 Offset: 0xC7AA70 VA: 0x180C7C070
	private void SetModID(uint other) { }

	// RVA: 0xC7C0D0 Offset: 0xC7AAD0 VA: 0x180C7C0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xC7BD60 Offset: 0xC7A760 VA: 0x180C7BD60 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7BE00 Offset: 0xC7A800 VA: 0x180C7BE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(CGameID x, CGameID y) { }

	// RVA: 0xC7C200 Offset: 0xC7AC00 VA: 0x180C7C200
	public static bool op_Inequality(CGameID x, CGameID y) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static CGameID op_Explicit(ulong value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(CGameID that) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 4
	public bool Equals(CGameID other) { }

	// RVA: 0xC7BD50 Offset: 0xC7A750 VA: 0x180C7BD50 Slot: 5
	public int CompareTo(CGameID other) { }
}
