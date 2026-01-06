public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t> // TypeDefIndex: 14809
{
	// Fields
	public static readonly DepotId_t Invalid; // 0x0
	public uint m_DepotId; // 0x0

	// Methods

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(uint value) { }

	// RVA: 0xC7B8B0 Offset: 0xC7A2B0 VA: 0x180C7B8B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xC81780 Offset: 0xC80180 VA: 0x180C81780 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7B8A0 Offset: 0xC7A2A0 VA: 0x180C7B8A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7B900 Offset: 0xC7A300 VA: 0x180C7B900
	public static bool op_Equality(DepotId_t x, DepotId_t y) { }

	// RVA: 0xC81860 Offset: 0xC80260 VA: 0x180C81860
	public static bool op_Inequality(DepotId_t x, DepotId_t y) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static DepotId_t op_Explicit(uint value) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static uint op_Explicit(DepotId_t that) { }

	// RVA: 0xC7B890 Offset: 0xC7A290 VA: 0x180C7B890 Slot: 4
	public bool Equals(DepotId_t other) { }

	// RVA: 0xC7B7E0 Offset: 0xC7A1E0 VA: 0x180C7B7E0 Slot: 5
	public int CompareTo(DepotId_t other) { }

	// RVA: 0xC81820 Offset: 0xC80220 VA: 0x180C81820
	private static void .cctor() { }
}
