internal class DigestSession // TypeDefIndex: 10053
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	// Properties
	public string Algorithm { get; }
	public string Realm { get; }
	public string Nonce { get; }
	public string Opaque { get; }
	public string QOP { get; }
	public string CNonce { get; }
	public DateTime LastUse { get; }

	// Methods

	// RVA: 0x25AED60 Offset: 0x25AD760 VA: 0x1825AED60
	private static void .cctor() { }

	// RVA: 0x25AEDC0 Offset: 0x25AD7C0 VA: 0x1825AEDC0
	public void .ctor() { }

	// RVA: 0x25AEE20 Offset: 0x25AD820 VA: 0x1825AEE20
	public string get_Algorithm() { }

	// RVA: 0x25AF020 Offset: 0x25ADA20 VA: 0x1825AF020
	public string get_Realm() { }

	// RVA: 0x25AEF60 Offset: 0x25AD960 VA: 0x1825AEF60
	public string get_Nonce() { }

	// RVA: 0x25AEFA0 Offset: 0x25AD9A0 VA: 0x1825AEFA0
	public string get_Opaque() { }

	// RVA: 0x25AEFE0 Offset: 0x25AD9E0 VA: 0x1825AEFE0
	public string get_QOP() { }

	// RVA: 0x25AEE60 Offset: 0x25AD860 VA: 0x1825AEE60
	public string get_CNonce() { }

	// RVA: 0x25AE830 Offset: 0x25AD230 VA: 0x1825AE830
	public bool Parse(string challenge) { }

	// RVA: 0x25AE6C0 Offset: 0x25AD0C0 VA: 0x1825AE6C0
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x25AE460 Offset: 0x25ACE60 VA: 0x1825AE460
	private string HA1(string username, string password) { }

	// RVA: 0x25AE5C0 Offset: 0x25ACFC0 VA: 0x1825AE5C0
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x25AE9F0 Offset: 0x25AD3F0 VA: 0x1825AE9F0
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x25ADEB0 Offset: 0x25AC8B0 VA: 0x1825ADEB0
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public DateTime get_LastUse() { }
}
