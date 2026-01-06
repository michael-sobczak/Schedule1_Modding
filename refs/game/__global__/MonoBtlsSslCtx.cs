internal class MonoBtlsSslCtx : MonoBtlsObject // TypeDefIndex: 9448
{
	// Fields
	private MonoBtlsSslCtx.NativeVerifyFunc verifyFunc; // 0x20
	private MonoBtlsSslCtx.NativeSelectFunc selectFunc; // 0x28
	private MonoBtlsSslCtx.NativeServerNameFunc serverNameFunc; // 0x30
	private IntPtr verifyFuncPtr; // 0x38
	private IntPtr selectFuncPtr; // 0x40
	private IntPtr serverNameFuncPtr; // 0x48
	private MonoBtlsVerifyCallback verifyCallback; // 0x50
	private MonoBtlsSelectCallback selectCallback; // 0x58
	private MonoBtlsServerNameCallback serverNameCallback; // 0x60
	private MonoBtlsX509Store store; // 0x68
	private GCHandle instance; // 0x70
	private IntPtr instancePtr; // 0x78

	// Properties
	internal MonoBtlsSslCtx.BoringSslCtxHandle Handle { get; }
	public MonoBtlsX509Store CertificateStore { get; }

	// Methods

	// RVA: 0x25FD400 Offset: 0x25FBE00 VA: 0x1825FD400
	internal MonoBtlsSslCtx.BoringSslCtxHandle get_Handle() { }

	// RVA: 0x25FD590 Offset: 0x25FBF90 VA: 0x1825FD590
	private static extern IntPtr mono_btls_ssl_ctx_new() { }

	// RVA: 0x25FD480 Offset: 0x25FBE80 VA: 0x1825FD480
	private static extern int mono_btls_ssl_ctx_free(IntPtr handle) { }

	// RVA: 0x25FD500 Offset: 0x25FBF00 VA: 0x1825FD500
	private static extern void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance) { }

	// RVA: 0x25FD690 Offset: 0x25FC090 VA: 0x1825FD690
	private static extern void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required) { }

	// RVA: 0x25FD600 Offset: 0x25FC000 VA: 0x1825FD600
	private static extern void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x25FD900 Offset: 0x25FC300 VA: 0x1825FD900
	private static extern void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version) { }

	// RVA: 0x25FD870 Offset: 0x25FC270 VA: 0x1825FD870
	private static extern void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version) { }

	// RVA: 0x25FD730 Offset: 0x25FC130 VA: 0x1825FD730
	private static extern int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported) { }

	// RVA: 0x25FDA20 Offset: 0x25FC420 VA: 0x1825FDA20
	private static extern int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x25FD7D0 Offset: 0x25FC1D0 VA: 0x1825FD7D0
	private static extern int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x25FD990 Offset: 0x25FC390 VA: 0x1825FD990
	private static extern void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x25FCE50 Offset: 0x25FB850 VA: 0x1825FCE50
	public void .ctor() { }

	// RVA: 0x25FCF20 Offset: 0x25FB920 VA: 0x1825FCF20
	internal void .ctor(MonoBtlsSslCtx.BoringSslCtxHandle handle) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public MonoBtlsX509Store get_CertificateStore() { }

	// RVA: 0x25FCE20 Offset: 0x25FB820 VA: 0x1825FCE20
	private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx) { }

	[MonoPInvokeCallback(typeof(MonoBtlsSslCtx.NativeVerifyFunc))]
	// RVA: 0x25FBFE0 Offset: 0x25FA9E0 VA: 0x1825FBFE0
	private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx) { }

	[MonoPInvokeCallback(typeof(MonoBtlsSslCtx.NativeSelectFunc))]
	// RVA: 0x25FBDE0 Offset: 0x25FA7E0 VA: 0x1825FBDE0
	private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x25FB980 Offset: 0x25FA380 VA: 0x1825FB980
	private static string[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr) { }

	// RVA: 0x25FCC30 Offset: 0x25FB630 VA: 0x1825FCC30
	public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required) { }

	// RVA: 0x25FCAB0 Offset: 0x25FB4B0 VA: 0x1825FCAB0
	public void SetSelectCallback(MonoBtlsSelectCallback callback) { }

	// RVA: 0x25FCA00 Offset: 0x25FB400 VA: 0x1825FCA00
	public void SetMinVersion(int version) { }

	// RVA: 0x25FC950 Offset: 0x25FB350 VA: 0x1825FC950
	public void SetMaxVersion(int version) { }

	// RVA: 0x25FC2F0 Offset: 0x25FACF0 VA: 0x1825FC2F0
	public void SetCiphers(short[] ciphers, bool allow_unsupported) { }

	// RVA: 0x25FCD10 Offset: 0x25FB710 VA: 0x1825FCD10
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x25FC500 Offset: 0x25FAF00 VA: 0x1825FC500
	public void SetClientCertificateIssuers(string[] acceptableIssuers) { }

	// RVA: 0x25FCB70 Offset: 0x25FB570 VA: 0x1825FCB70
	public void SetServerNameCallback(MonoBtlsServerNameCallback callback) { }

	[MonoPInvokeCallback(typeof(MonoBtlsSslCtx.NativeServerNameFunc))]
	// RVA: 0x25FBF00 Offset: 0x25FA900 VA: 0x1825FBF00
	private static int NativeServerNameCallback(IntPtr instance) { }

	// RVA: 0x25FB920 Offset: 0x25FA320 VA: 0x1825FB920 Slot: 5
	protected override void Close() { }
}
