internal class DigestClient : IAuthenticationModule // TypeDefIndex: 10054
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Properties
	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x25AD5B0 Offset: 0x25ABFB0 VA: 0x1825AD5B0
	private static Hashtable get_Cache() { }

	// RVA: 0x25ACC50 Offset: 0x25AB650 VA: 0x1825ACC50
	private static void CheckExpired(int count) { }

	// RVA: 0x25AC8F0 Offset: 0x25AB2F0 VA: 0x1825AC8F0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x25AD350 Offset: 0x25ABD50 VA: 0x1825AD350 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x25AD580 Offset: 0x25ABF80 VA: 0x1825AD580 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x25AD500 Offset: 0x25ABF00 VA: 0x1825AD500
	private static void .cctor() { }
}
