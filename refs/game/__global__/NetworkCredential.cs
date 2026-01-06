public class NetworkCredential : ICredentials // TypeDefIndex: 9979
{
	// Fields
	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Properties
	public string UserName { get; set; }
	public string Password { get; set; }
	public string Domain { get; set; }

	// Methods

	// RVA: 0x26C8100 Offset: 0x26C6B00 VA: 0x1826C8100
	public void .ctor() { }

	// RVA: 0x26C82F0 Offset: 0x26C6CF0 VA: 0x1826C82F0
	public void .ctor(string userName, string password) { }

	// RVA: 0x26C8210 Offset: 0x26C6C10 VA: 0x1826C8210
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_UserName() { }

	// RVA: 0x26C8490 Offset: 0x26C6E90 VA: 0x1826C8490
	public void set_UserName(string value) { }

	// RVA: 0x26C80F0 Offset: 0x26C6AF0 VA: 0x1826C80F0
	public string get_Password() { }

	// RVA: 0x26C8460 Offset: 0x26C6E60 VA: 0x1826C8460
	public void set_Password(string value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Domain() { }

	// RVA: 0x26C8400 Offset: 0x26C6E00 VA: 0x1826C8400
	public void set_Domain(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal string InternalGetUserName() { }

	// RVA: 0x26C80F0 Offset: 0x26C6AF0 VA: 0x1826C80F0
	internal string InternalGetPassword() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal string InternalGetDomain() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 4
	public NetworkCredential GetCredential(Uri uri, string authType) { }
}
