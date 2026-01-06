internal class MonoBtlsPkcs12 : MonoBtlsObject // TypeDefIndex: 9436
{
	// Fields
	private MonoBtlsKey privateKey; // 0x20

	// Properties
	internal MonoBtlsPkcs12.BoringPkcs12Handle Handle { get; }
	public int Count { get; }
	public bool HasPrivateKey { get; }

	// Methods

	// RVA: 0x20190F0 Offset: 0x2017AF0 VA: 0x1820190F0
	internal MonoBtlsPkcs12.BoringPkcs12Handle get_Handle() { }

	// RVA: 0x2019210 Offset: 0x2017C10 VA: 0x182019210
	private static extern void mono_btls_pkcs12_free(IntPtr handle) { }

	// RVA: 0x2019590 Offset: 0x2017F90 VA: 0x182019590
	private static extern IntPtr mono_btls_pkcs12_new() { }

	// RVA: 0x2019320 Offset: 0x2017D20 VA: 0x182019320
	private static extern int mono_btls_pkcs12_get_count(IntPtr handle) { }

	// RVA: 0x2019290 Offset: 0x2017C90 VA: 0x182019290
	private static extern IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index) { }

	// RVA: 0x20194A0 Offset: 0x2017EA0 VA: 0x1820194A0
	private static extern int mono_btls_pkcs12_import(IntPtr chain, void* data, int len, SafePasswordHandle password) { }

	// RVA: 0x2019420 Offset: 0x2017E20 VA: 0x182019420
	private static extern int mono_btls_pkcs12_has_private_key(IntPtr pkcs12) { }

	// RVA: 0x20193A0 Offset: 0x2017DA0 VA: 0x1820193A0
	private static extern IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12) { }

	// RVA: 0x2018F70 Offset: 0x2017970 VA: 0x182018F70
	internal void .ctor() { }

	// RVA: 0x2019050 Offset: 0x2017A50 VA: 0x182019050
	public int get_Count() { }

	// RVA: 0x20189C0 Offset: 0x20173C0 VA: 0x1820189C0
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0x2018E00 Offset: 0x2017800 VA: 0x182018E00
	public void Import(byte[] buffer, SafePasswordHandle password) { }

	// RVA: 0x2019170 Offset: 0x2017B70 VA: 0x182019170
	public bool get_HasPrivateKey() { }

	// RVA: 0x2018BD0 Offset: 0x20175D0 VA: 0x182018BD0
	public MonoBtlsKey GetPrivateKey() { }
}
