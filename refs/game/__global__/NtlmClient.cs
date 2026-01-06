internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 10076
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x25C17B0 Offset: 0x25C01B0 VA: 0x1825C17B0
	public void .ctor() { }

	// RVA: 0x25C16D0 Offset: 0x25C00D0 VA: 0x1825C16D0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x25C1820 Offset: 0x25C0220 VA: 0x1825C1820 Slot: 6
	public string get_AuthenticationType() { }
}
