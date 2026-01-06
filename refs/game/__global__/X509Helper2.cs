internal static class X509Helper2 // TypeDefIndex: 9648
{
	// Methods

	[MonoTODO("Investigate replacement; see comments in source.")]
	// RVA: 0x2658810 Offset: 0x2657210 VA: 0x182658810
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x2658740 Offset: 0x2657140 VA: 0x182658740
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x1B23270 Offset: 0x1B21C70 VA: 0x181B23270
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x2658930 Offset: 0x2657330 VA: 0x182658930
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x26587A0 Offset: 0x26571A0 VA: 0x1826587A0
	internal static Exception GetInvalidChainContextException() { }
}
