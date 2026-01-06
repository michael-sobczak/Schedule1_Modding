public class AuthenticationManager // TypeDefIndex: 10043
{
	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x25A7A70 Offset: 0x25A6470 VA: 0x1825A7A70
	private static void EnsureModules() { }

	// RVA: 0x25A75A0 Offset: 0x25A5FA0 VA: 0x1825A75A0
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x25A7700 Offset: 0x25A6100 VA: 0x1825A7700
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x25A7D00 Offset: 0x25A6700 VA: 0x1825A7D00
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x25A80D0 Offset: 0x25A6AD0 VA: 0x1825A80D0
	private static void .cctor() { }
}
