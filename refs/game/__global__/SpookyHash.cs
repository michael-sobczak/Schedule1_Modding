internal static class SpookyHash // TypeDefIndex: 11737
{
	// Methods

	// RVA: 0x2CB0400 Offset: 0x2CAEE00 VA: 0x182CB0400
	public static void Hash(void* message, ulong length, ulong* hash1, ulong* hash2) { }

	// RVA: 0x2CB0210 Offset: 0x2CAEC10 VA: 0x182CB0210
	private static void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) { }

	// RVA: 0x2CB0040 Offset: 0x2CAEA40 VA: 0x182CB0040
	private static void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) { }

	// RVA: 0x2CB0D70 Offset: 0x2CAF770 VA: 0x182CB0D70
	private static void Rot64(ref ulong x, int k) { }

	// RVA: 0x2CB1050 Offset: 0x2CAFA50 VA: 0x182CB1050
	private static void Short(void* message, ulong length, ulong* hash1, ulong* hash2) { }

	// RVA: 0x2CB0EE0 Offset: 0x2CAF8E0 VA: 0x182CB0EE0
	private static void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

	// RVA: 0x2CB0D90 Offset: 0x2CAF790 VA: 0x182CB0D90
	private static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

	// RVA: 0x2CB0AF0 Offset: 0x2CAF4F0 VA: 0x182CB0AF0
	private static void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11) { }
}
