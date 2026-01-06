public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t> // TypeDefIndex: 14807
{
	// Fields
	public static readonly AccountID_t Invalid; // 0x0
	public uint m_AccountID; // 0x0

	// Methods

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(uint value) { }

	// RVA: 0xC7B8B0 Offset: 0xC7A2B0 VA: 0x180C7B8B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xC7B7F0 Offset: 0xC7A1F0 VA: 0x180C7B7F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7B8A0 Offset: 0xC7A2A0 VA: 0x180C7B8A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7B900 Offset: 0xC7A300 VA: 0x180C7B900
	public static bool op_Equality(AccountID_t x, AccountID_t y) { }

	// RVA: 0xC7B910 Offset: 0xC7A310 VA: 0x180C7B910
	public static bool op_Inequality(AccountID_t x, AccountID_t y) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static AccountID_t op_Explicit(uint value) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static uint op_Explicit(AccountID_t that) { }

	// RVA: 0xC7B890 Offset: 0xC7A290 VA: 0x180C7B890 Slot: 4
	public bool Equals(AccountID_t other) { }

	// RVA: 0xC7B7E0 Offset: 0xC7A1E0 VA: 0x180C7B7E0 Slot: 5
	public int CompareTo(AccountID_t other) { }

	// RVA: 0xC7B8C0 Offset: 0xC7A2C0 VA: 0x180C7B8C0
	private static void .cctor() { }
}
