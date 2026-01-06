public static class ProtectedData // TypeDefIndex: 19298
{
	// Fields
	private static readonly byte[] s_nonEmpty; // 0x0

	// Methods

	// RVA: 0x21A9BD0 Offset: 0x21A85D0 VA: 0x1821A9BD0
	public static byte[] Protect(byte[] userData, byte[] optionalEntropy, DataProtectionScope scope) { }

	// RVA: 0x21A9CA0 Offset: 0x21A86A0 VA: 0x1821A9CA0
	public static byte[] Unprotect(byte[] encryptedData, byte[] optionalEntropy, DataProtectionScope scope) { }

	// RVA: 0x21A9720 Offset: 0x21A8120 VA: 0x1821A9720
	private static byte[] ProtectOrUnprotect(byte[] inputData, byte[] optionalEntropy, DataProtectionScope scope, bool protect) { }

	// RVA: 0x21A9700 Offset: 0x21A8100 VA: 0x1821A9700
	private static bool ErrorMayBeCausedByUnloadedProfile(int errorCode) { }

	// RVA: 0x21A9D70 Offset: 0x21A8770 VA: 0x1821A9D70
	private static void .cctor() { }
}
