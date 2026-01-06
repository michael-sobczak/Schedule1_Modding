public struct FourCC : IEquatable<FourCC> // TypeDefIndex: 7809
{
	// Fields
	private int m_Code; // 0x0

	// Methods

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(int code) { }

	// RVA: 0x277AEE0 Offset: 0x27798E0 VA: 0x18277AEE0
	public void .ctor(char a, char b = '\x20', char c = '\x20', char d = '\x20') { }

	// RVA: 0x277AD40 Offset: 0x2779740 VA: 0x18277AD40
	public void .ctor(string str) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static int op_Implicit(FourCC fourCC) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static FourCC op_Implicit(int i) { }

	// RVA: 0x277AB10 Offset: 0x2779510 VA: 0x18277AB10 Slot: 3
	public override string ToString() { }

	// RVA: 0xC7B890 Offset: 0xC7A290 VA: 0x180C7B890 Slot: 4
	public bool Equals(FourCC other) { }

	// RVA: 0x277AA90 Offset: 0x2779490 VA: 0x18277AA90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7B900 Offset: 0xC7A300 VA: 0x180C7B900
	public static bool op_Equality(FourCC left, FourCC right) { }

	// RVA: 0xCB1130 Offset: 0xCAFB30 VA: 0x180CB1130
	public static bool op_Inequality(FourCC left, FourCC right) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static FourCC FromInt32(int i) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static int ToInt32(FourCC fourCC) { }
}
