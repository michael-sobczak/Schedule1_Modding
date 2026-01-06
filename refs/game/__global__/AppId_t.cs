public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t> // TypeDefIndex: 14808
{
	// Fields
	public static readonly AppId_t Invalid; // 0x0
	public uint m_AppId; // 0x0

	// Methods

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(uint value) { }

	// RVA: 0xC7B8B0 Offset: 0xC7A2B0 VA: 0x180C7B8B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xC7BAE0 Offset: 0xC7A4E0 VA: 0x180C7BAE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7B8A0 Offset: 0xC7A2A0 VA: 0x180C7B8A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7B900 Offset: 0xC7A300 VA: 0x180C7B900
	public static bool op_Equality(AppId_t x, AppId_t y) { }

	// RVA: 0xC7BBC0 Offset: 0xC7A5C0 VA: 0x180C7BBC0
	public static bool op_Inequality(AppId_t x, AppId_t y) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static AppId_t op_Explicit(uint value) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static uint op_Explicit(AppId_t that) { }

	// RVA: 0xC7B890 Offset: 0xC7A290 VA: 0x180C7B890 Slot: 4
	public bool Equals(AppId_t other) { }

	// RVA: 0xC7B7E0 Offset: 0xC7A1E0 VA: 0x180C7B7E0 Slot: 5
	public int CompareTo(AppId_t other) { }

	// RVA: 0xC7BB80 Offset: 0xC7A580 VA: 0x180C7BB80
	private static void .cctor() { }
}
