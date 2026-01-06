public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t> // TypeDefIndex: 14802
{
	// Fields
	public static readonly PublishedFileId_t Invalid; // 0x0
	public ulong m_PublishedFileId; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong value) { }

	// RVA: 0xC7C0D0 Offset: 0xC7AAD0 VA: 0x180C7C0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCB0CE0 Offset: 0xCAF6E0 VA: 0x180CB0CE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7BE00 Offset: 0xC7A800 VA: 0x180C7BE00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(PublishedFileId_t x, PublishedFileId_t y) { }

	// RVA: 0xCB0DC0 Offset: 0xCAF7C0 VA: 0x180CB0DC0
	public static bool op_Inequality(PublishedFileId_t x, PublishedFileId_t y) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static PublishedFileId_t op_Explicit(ulong value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static ulong op_Explicit(PublishedFileId_t that) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0 Slot: 4
	public bool Equals(PublishedFileId_t other) { }

	// RVA: 0xC7BD50 Offset: 0xC7A750 VA: 0x180C7BD50 Slot: 5
	public int CompareTo(PublishedFileId_t other) { }

	// RVA: 0xCB0D80 Offset: 0xCAF780 VA: 0x180CB0D80
	private static void .cctor() { }
}
