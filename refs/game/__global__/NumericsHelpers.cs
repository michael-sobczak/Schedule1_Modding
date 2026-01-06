internal static class NumericsHelpers // TypeDefIndex: 18602
{
	// Methods

	// RVA: 0x21A8100 Offset: 0x21A6B00 VA: 0x1821A8100
	public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite) { }

	// RVA: 0x21A7FB0 Offset: 0x21A69B0 VA: 0x1821A7FB0
	public static double GetDoubleFromParts(int sign, int exp, ulong man) { }

	// RVA: 0x21A7F10 Offset: 0x21A6910 VA: 0x1821A7F10
	public static void DangerousMakeTwosComplement(uint[] d) { }

	// RVA: 0x21A8190 Offset: 0x21A6B90 VA: 0x1821A8190
	public static ulong MakeUlong(uint uHi, uint uLo) { }

	// RVA: 0x21A7E50 Offset: 0x21A6850 VA: 0x1821A7E50
	public static uint Abs(int a) { }

	// RVA: 0x21A7F00 Offset: 0x21A6900 VA: 0x1821A7F00
	public static uint CombineHash(uint u1, uint u2) { }

	// RVA: 0x21A7F00 Offset: 0x21A6900 VA: 0x1821A7F00
	public static int CombineHash(int n1, int n2) { }

	// RVA: 0x219B000 Offset: 0x2199A00 VA: 0x18219B000
	public static int CbitHighZero(uint u) { }

	// RVA: 0x21A7E60 Offset: 0x21A6860 VA: 0x1821A7E60
	public static int CbitHighZero(ulong uu) { }
}
