public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t> // TypeDefIndex: 14814
{
	// Fields
	public static readonly UGCQueryHandle_t Invalid; // 0x0
	public ulong m_UGCQueryHandle; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong value) { }

	// RVA: 0xC7C0D0 Offset: 0xC7AAD0 VA: 0x180C7C0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCBECC0 Offset: 0xCBD6C0 VA: 0x180CBECC0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7BE00 Offset: 0xC7A800 VA: 0x180C7BE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(UGCQueryHandle_t x, UGCQueryHandle_t y) { }

	// RVA: 0xCBEDA0 Offset: 0xCBD7A0 VA: 0x180CBEDA0
	public static bool op_Inequality(UGCQueryHandle_t x, UGCQueryHandle_t y) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static UGCQueryHandle_t op_Explicit(ulong value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(UGCQueryHandle_t that) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 4
	public bool Equals(UGCQueryHandle_t other) { }

	// RVA: 0xC7BD50 Offset: 0xC7A750 VA: 0x180C7BD50 Slot: 5
	public int CompareTo(UGCQueryHandle_t other) { }

	// RVA: 0xCBED60 Offset: 0xCBD760 VA: 0x180CBED60
	private static void .cctor() { }
}
