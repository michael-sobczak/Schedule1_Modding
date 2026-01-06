public sealed class PKCS1 // TypeDefIndex: 17551
{
	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x1A7B130 Offset: 0x1A79B30 VA: 0x181A7B130
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x1A7BEB0 Offset: 0x1A7A8B0 VA: 0x181A7BEB0
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x1A7BF30 Offset: 0x1A7A930 VA: 0x181A7BF30
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x1A7C000 Offset: 0x1A7AA00 VA: 0x181A7C000
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x1A7C030 Offset: 0x1A7AA30 VA: 0x181A7C030
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x1A7B790 Offset: 0x1A7A190 VA: 0x181A7B790
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x1A7BAE0 Offset: 0x1A7A4E0 VA: 0x181A7BAE0
	internal static string HashNameFromOid(string oid, bool throwOnError = True) { }

	// RVA: 0x1A7B730 Offset: 0x1A7A130 VA: 0x181A7B730
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0x1A7B1C0 Offset: 0x1A79BC0 VA: 0x181A7B1C0
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x1A7C3A0 Offset: 0x1A7ADA0 VA: 0x181A7C3A0
	private static void .cctor() { }
}
