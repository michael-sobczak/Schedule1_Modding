internal class MonoBtlsX509Chain : MonoBtlsObject // TypeDefIndex: 9456
{
	// Properties
	internal MonoBtlsX509Chain.BoringX509ChainHandle Handle { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x2601080 Offset: 0x25FFA80 VA: 0x182601080
	internal MonoBtlsX509Chain.BoringX509ChainHandle get_Handle() { }

	// RVA: 0x2601320 Offset: 0x25FFD20 VA: 0x182601320
	private static extern IntPtr mono_btls_x509_chain_new() { }

	// RVA: 0x26012A0 Offset: 0x25FFCA0 VA: 0x1826012A0
	private static extern int mono_btls_x509_chain_get_count(IntPtr handle) { }

	// RVA: 0x2601210 Offset: 0x25FFC10 VA: 0x182601210
	private static extern IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index) { }

	// RVA: 0x2601100 Offset: 0x25FFB00 VA: 0x182601100
	private static extern int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509) { }

	// RVA: 0x2601390 Offset: 0x25FFD90 VA: 0x182601390
	private static extern IntPtr mono_btls_x509_chain_up_ref(IntPtr handle) { }

	// RVA: 0x2601190 Offset: 0x25FFB90 VA: 0x182601190
	private static extern void mono_btls_x509_chain_free(IntPtr handle) { }

	// RVA: 0x2600F10 Offset: 0x25FF910 VA: 0x182600F10
	public void .ctor() { }

	// RVA: 0x22B0EA0 Offset: 0x22AF8A0 VA: 0x1822B0EA0
	internal void .ctor(MonoBtlsX509Chain.BoringX509ChainHandle handle) { }

	// RVA: 0x2600FE0 Offset: 0x25FF9E0 VA: 0x182600FE0
	public int get_Count() { }

	// RVA: 0x2600D80 Offset: 0x25FF780 VA: 0x182600D80
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0x2600B80 Offset: 0x25FF580 VA: 0x182600B80
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x2600C40 Offset: 0x25FF640 VA: 0x182600C40
	internal MonoBtlsX509Chain Copy() { }
}
