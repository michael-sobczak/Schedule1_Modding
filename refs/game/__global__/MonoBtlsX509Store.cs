internal class MonoBtlsX509Store : MonoBtlsObject // TypeDefIndex: 9471
{
	// Fields
	private Dictionary<IntPtr, MonoBtlsX509Lookup> lookupHash; // 0x20

	// Properties
	internal MonoBtlsX509Store.BoringX509StoreHandle Handle { get; }

	// Methods

	// RVA: 0x2606090 Offset: 0x2604A90 VA: 0x182606090
	internal MonoBtlsX509Store.BoringX509StoreHandle get_Handle() { }

	// RVA: 0x26062A0 Offset: 0x2604CA0 VA: 0x1826062A0
	private static extern IntPtr mono_btls_x509_store_new() { }

	// RVA: 0x2606220 Offset: 0x2604C20 VA: 0x182606220
	private static extern IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle) { }

	// RVA: 0x2606110 Offset: 0x2604B10 VA: 0x182606110
	private static extern int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509) { }

	// RVA: 0x26061A0 Offset: 0x2604BA0 VA: 0x1826061A0
	private static extern void mono_btls_x509_store_free(IntPtr handle) { }

	// RVA: 0x2605D30 Offset: 0x2604730 VA: 0x182605D30
	private static MonoBtlsX509Store.BoringX509StoreHandle Create_internal() { }

	// RVA: 0x2605C00 Offset: 0x2604600 VA: 0x182605C00
	private static MonoBtlsX509Store.BoringX509StoreHandle Create_internal(MonoBtlsSslCtx.BoringSslCtxHandle ctx) { }

	// RVA: 0x2605E30 Offset: 0x2604830 VA: 0x182605E30
	internal void .ctor() { }

	// RVA: 0x2605F50 Offset: 0x2604950 VA: 0x182605F50
	internal void .ctor(MonoBtlsSslCtx.BoringSslCtxHandle ctx) { }

	// RVA: 0x2605650 Offset: 0x2604050 VA: 0x182605650
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x2605870 Offset: 0x2604270 VA: 0x182605870
	public MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type) { }

	// RVA: 0x2605820 Offset: 0x2604220 VA: 0x182605820
	public void AddDirectoryLookup(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x2605750 Offset: 0x2604150 VA: 0x182605750
	public void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x2605A40 Offset: 0x2604440 VA: 0x182605A40 Slot: 5
	protected override void Close() { }
}
