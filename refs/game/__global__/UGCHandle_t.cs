public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t> // TypeDefIndex: 14805
{
	// Fields
	public static readonly UGCHandle_t Invalid; // 0x0
	public ulong m_UGCHandle; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong value) { }

	// RVA: 0xC7C0D0 Offset: 0xC7AAD0 VA: 0x180C7C0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCBD4D0 Offset: 0xCBBED0 VA: 0x180CBD4D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7BE00 Offset: 0xC7A800 VA: 0x180C7BE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(UGCHandle_t x, UGCHandle_t y) { }

	// RVA: 0xCBD5B0 Offset: 0xCBBFB0 VA: 0x180CBD5B0
	public static bool op_Inequality(UGCHandle_t x, UGCHandle_t y) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static UGCHandle_t op_Explicit(ulong value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(UGCHandle_t that) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 4
	public bool Equals(UGCHandle_t other) { }

	// RVA: 0xC7BD50 Offset: 0xC7A750 VA: 0x180C7BD50 Slot: 5
	public int CompareTo(UGCHandle_t other) { }

	// RVA: 0xCBD570 Offset: 0xCBBF70 VA: 0x180CBD570
	private static void .cctor() { }
}
