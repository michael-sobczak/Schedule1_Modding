public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID> // TypeDefIndex: 14759
{
	// Fields
	public static readonly CSteamID Nil; // 0x0
	public static readonly CSteamID OutofDateGS; // 0x8
	public static readonly CSteamID LanModeGS; // 0x10
	public static readonly CSteamID NotInitYetGS; // 0x18
	public static readonly CSteamID NonSteamGS; // 0x20
	public ulong m_SteamID; // 0x0

	// Methods

	// RVA: 0xC7F1E0 Offset: 0xC7DBE0 VA: 0x180C7F1E0
	public void .ctor(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType) { }

	// RVA: 0xC7F150 Offset: 0xC7DB50 VA: 0x180C7F150
	public void .ctor(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType) { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong ulSteamID) { }

	// RVA: 0xC7EE20 Offset: 0xC7D820 VA: 0x180C7EE20
	public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType) { }

	// RVA: 0xC7E9A0 Offset: 0xC7D3A0 VA: 0x180C7E9A0
	public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType) { }

	// RVA: 0xC7BFF0 Offset: 0xC7A9F0 VA: 0x180C7BFF0
	public void Clear() { }

	// RVA: 0xC7E790 Offset: 0xC7D190 VA: 0x180C7E790
	public void CreateBlankAnonLogon(EUniverse eUniverse) { }

	// RVA: 0xC7E830 Offset: 0xC7D230 VA: 0x180C7E830
	public void CreateBlankAnonUserLogon(EUniverse eUniverse) { }

	// RVA: 0xC7E430 Offset: 0xC7CE30 VA: 0x180C7E430
	public bool BBlankAnonAccount() { }

	// RVA: 0xC7E640 Offset: 0xC7D040 VA: 0x180C7E640
	public bool BGameServerAccount() { }

	// RVA: 0xC7E740 Offset: 0xC7D140 VA: 0x180C7E740
	public bool BPersistentGameServerAccount() { }

	// RVA: 0xC7E390 Offset: 0xC7CD90 VA: 0x180C7E390
	public bool BAnonGameServerAccount() { }

	// RVA: 0xC7E5F0 Offset: 0xC7CFF0 VA: 0x180C7E5F0
	public bool BContentServerAccount() { }

	// RVA: 0xC7E550 Offset: 0xC7CF50 VA: 0x180C7E550
	public bool BClanAccount() { }

	// RVA: 0xC7E500 Offset: 0xC7CF00 VA: 0x180C7E500
	public bool BChatAccount() { }

	// RVA: 0xC7EA80 Offset: 0xC7D480 VA: 0x180C7EA80
	public bool IsLobby() { }

	// RVA: 0xC7E6C0 Offset: 0xC7D0C0 VA: 0x180C7E6C0
	public bool BIndividualAccount() { }

	// RVA: 0xC7E310 Offset: 0xC7CD10 VA: 0x180C7E310
	public bool BAnonAccount() { }

	// RVA: 0xC7E3E0 Offset: 0xC7CDE0 VA: 0x180C7E3E0
	public bool BAnonUserAccount() { }

	// RVA: 0xC7E5A0 Offset: 0xC7CFA0 VA: 0x180C7E5A0
	public bool BConsoleUserAccount() { }

	// RVA: 0xC7ED30 Offset: 0xC7D730 VA: 0x180C7ED30
	public void SetAccountID(AccountID_t other) { }

	// RVA: 0xC7EDA0 Offset: 0xC7D7A0 VA: 0x180C7EDA0
	public void SetAccountInstance(uint other) { }

	// RVA: 0xC7EDD0 Offset: 0xC7D7D0 VA: 0x180C7EDD0
	public void SetEAccountType(EAccountType other) { }

	// RVA: 0xC7EE00 Offset: 0xC7D800 VA: 0x180C7EE00
	public void SetEUniverse(EUniverse other) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public AccountID_t GetAccountID() { }

	// RVA: 0xC7E990 Offset: 0xC7D390 VA: 0x180C7E990
	public uint GetUnAccountInstance() { }

	// RVA: 0xC7E970 Offset: 0xC7D370 VA: 0x180C7E970
	public EAccountType GetEAccountType() { }

	// RVA: 0xC7E980 Offset: 0xC7D380 VA: 0x180C7E980
	public EUniverse GetEUniverse() { }

	// RVA: 0xC7EB00 Offset: 0xC7D500 VA: 0x180C7EB00
	public bool IsValid() { }

	// RVA: 0xC7C0D0 Offset: 0xC7AAD0 VA: 0x180C7C0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xC7E8D0 Offset: 0xC7D2D0 VA: 0x180C7E8D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7BE00 Offset: 0xC7A800 VA: 0x180C7BE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(CSteamID x, CSteamID y) { }

	// RVA: 0xC7F270 Offset: 0xC7DC70 VA: 0x180C7F270
	public static bool op_Inequality(CSteamID x, CSteamID y) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static CSteamID op_Explicit(ulong value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(CSteamID that) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 4
	public bool Equals(CSteamID other) { }

	// RVA: 0xC7BD50 Offset: 0xC7A750 VA: 0x180C7BD50 Slot: 5
	public int CompareTo(CSteamID other) { }

	// RVA: 0xC7EF70 Offset: 0xC7D970 VA: 0x180C7EF70
	private static void .cctor() { }
}
