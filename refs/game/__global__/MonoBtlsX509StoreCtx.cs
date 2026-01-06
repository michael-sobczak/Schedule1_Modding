internal class MonoBtlsX509StoreCtx : MonoBtlsObject // TypeDefIndex: 9473
{
	// Fields
	private Nullable<int> verifyResult; // 0x20

	// Properties
	internal MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Handle { get; }
	public int VerifyResult { get; }

	// Methods

	// RVA: 0x26049F0 Offset: 0x26033F0 VA: 0x1826049F0
	internal MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle get_Handle() { }

	// RVA: 0x2604E30 Offset: 0x2603830 VA: 0x182604E30
	private static extern IntPtr mono_btls_x509_store_ctx_new() { }

	// RVA: 0x2604B80 Offset: 0x2603580 VA: 0x182604B80
	private static extern IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx) { }

	// RVA: 0x2604C80 Offset: 0x2603680 VA: 0x182604C80
	private static extern MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, out IntPtr error_string) { }

	// RVA: 0x2604C00 Offset: 0x2603600 VA: 0x182604C00
	private static extern IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle) { }

	// RVA: 0x2604D90 Offset: 0x2603790 VA: 0x182604D90
	private static extern int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain) { }

	// RVA: 0x2604EA0 Offset: 0x26038A0 VA: 0x182604EA0
	private static extern int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x2604FB0 Offset: 0x26039B0 VA: 0x182604FB0
	private static extern int mono_btls_x509_store_ctx_verify_cert(IntPtr handle) { }

	// RVA: 0x2604D10 Offset: 0x2603710 VA: 0x182604D10
	private static extern IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle) { }

	// RVA: 0x2604F30 Offset: 0x2603930 VA: 0x182604F30
	private static extern IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle) { }

	// RVA: 0x2604B00 Offset: 0x2603500 VA: 0x182604B00
	private static extern void mono_btls_x509_store_ctx_free(IntPtr handle) { }

	// RVA: 0x26048F0 Offset: 0x26032F0 VA: 0x1826048F0
	internal void .ctor() { }

	// RVA: 0x2603FE0 Offset: 0x26029E0 VA: 0x182603FE0
	private static MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx) { }

	// RVA: 0x2604770 Offset: 0x2603170 VA: 0x182604770
	internal void .ctor(int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x26049C0 Offset: 0x26033C0 VA: 0x1826049C0
	internal void .ctor(MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle ptr, Nullable<int> verifyResult) { }

	// RVA: 0x2604240 Offset: 0x2602C40 VA: 0x182604240
	public MonoBtlsX509Error GetError() { }

	// RVA: 0x2604100 Offset: 0x2602B00 VA: 0x182604100
	public MonoBtlsX509Chain GetChain() { }

	// RVA: 0x26042F0 Offset: 0x2602CF0 VA: 0x1826042F0
	public MonoBtlsX509Chain GetUntrusted() { }

	// RVA: 0x2604430 Offset: 0x2602E30 VA: 0x182604430
	public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain) { }

	// RVA: 0x2604570 Offset: 0x2602F70 VA: 0x182604570
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x2604A70 Offset: 0x2603470 VA: 0x182604A70
	public int get_VerifyResult() { }

	// RVA: 0x2604670 Offset: 0x2603070 VA: 0x182604670
	public int Verify() { }

	// RVA: 0x2603E90 Offset: 0x2602890 VA: 0x182603E90
	public MonoBtlsX509StoreCtx Copy() { }
}
