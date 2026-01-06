internal class BasicClient : IAuthenticationModule // TypeDefIndex: 10044
{
	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x25A8700 Offset: 0x25A7100 VA: 0x1825A8700 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x25A87B0 Offset: 0x25A71B0 VA: 0x1825A87B0
	private static byte[] GetBytes(string str) { }

	// RVA: 0x25A8860 Offset: 0x25A7260 VA: 0x1825A8860
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x25A8B60 Offset: 0x25A7560 VA: 0x1825A8B60 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x25A8B80 Offset: 0x25A7580 VA: 0x1825A8B80 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
