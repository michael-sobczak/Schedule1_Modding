public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle> // TypeDefIndex: 14769
{
	// Fields
	public static readonly HTTPRequestHandle Invalid; // 0x0
	public uint m_HTTPRequestHandle; // 0x0

	// Methods

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(uint value) { }

	// RVA: 0xC7B8B0 Offset: 0xC7A2B0 VA: 0x180C7B8B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xC831F0 Offset: 0xC81BF0 VA: 0x180C831F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xC7B8A0 Offset: 0xC7A2A0 VA: 0x180C7B8A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7B900 Offset: 0xC7A300 VA: 0x180C7B900
	public static bool op_Equality(HTTPRequestHandle x, HTTPRequestHandle y) { }

	// RVA: 0xC832D0 Offset: 0xC81CD0 VA: 0x180C832D0
	public static bool op_Inequality(HTTPRequestHandle x, HTTPRequestHandle y) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static HTTPRequestHandle op_Explicit(uint value) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static uint op_Explicit(HTTPRequestHandle that) { }

	// RVA: 0xC7B890 Offset: 0xC7A290 VA: 0x180C7B890 Slot: 4
	public bool Equals(HTTPRequestHandle other) { }

	// RVA: 0xC7B7E0 Offset: 0xC7A1E0 VA: 0x180C7B7E0 Slot: 5
	public int CompareTo(HTTPRequestHandle other) { }

	// RVA: 0xC83290 Offset: 0xC81C90 VA: 0x180C83290
	private static void .cctor() { }
}
