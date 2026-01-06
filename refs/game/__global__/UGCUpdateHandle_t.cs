public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t> // TypeDefIndex: 14815
{
	// Fields
	public static readonly UGCUpdateHandle_t Invalid; // 0x0
	public ulong m_UGCUpdateHandle; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong value) { }

	// RVA: 0xC7C0D0 Offset: 0xC7AAD0 VA: 0x180C7C0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCBEE00 Offset: 0xCBD800 VA: 0x180CBEE00 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7BE00 Offset: 0xC7A800 VA: 0x180C7BE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(UGCUpdateHandle_t x, UGCUpdateHandle_t y) { }

	// RVA: 0xCBEEE0 Offset: 0xCBD8E0 VA: 0x180CBEEE0
	public static bool op_Inequality(UGCUpdateHandle_t x, UGCUpdateHandle_t y) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static UGCUpdateHandle_t op_Explicit(ulong value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(UGCUpdateHandle_t that) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 4
	public bool Equals(UGCUpdateHandle_t other) { }

	// RVA: 0xC7BD50 Offset: 0xC7A750 VA: 0x180C7BD50 Slot: 5
	public int CompareTo(UGCUpdateHandle_t other) { }

	// RVA: 0xCBEEA0 Offset: 0xCBD8A0 VA: 0x180CBEEA0
	private static void .cctor() { }
}
