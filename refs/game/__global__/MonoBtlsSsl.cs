internal class MonoBtlsSsl : MonoBtlsObject // TypeDefIndex: 9443
{
	// Fields
	private MonoBtlsBio bio; // 0x20
	private MonoBtlsSsl.PrintErrorsCallbackFunc printErrorsFunc; // 0x28
	private IntPtr printErrorsFuncPtr; // 0x30

	// Properties
	internal MonoBtlsSsl.BoringSslHandle Handle { get; }

	// Methods

	// RVA: 0x25FF780 Offset: 0x25FE180 VA: 0x1825FF780
	private static extern void mono_btls_ssl_destroy(IntPtr handle) { }

	// RVA: 0x25FFB10 Offset: 0x25FE510 VA: 0x1825FFB10
	private static extern IntPtr mono_btls_ssl_new(IntPtr handle) { }

	// RVA: 0x2600000 Offset: 0x25FEA00 VA: 0x182600000
	private static extern int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x2600090 Offset: 0x25FEA90 VA: 0x182600090
	private static extern int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key) { }

	// RVA: 0x25FF5F0 Offset: 0x25FDFF0 VA: 0x1825FF5F0
	private static extern int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x25FF570 Offset: 0x25FDF70 VA: 0x1825FF570
	private static extern int mono_btls_ssl_accept(IntPtr handle) { }

	// RVA: 0x25FF700 Offset: 0x25FE100 VA: 0x1825FF700
	private static extern int mono_btls_ssl_connect(IntPtr handle) { }

	// RVA: 0x25FFA90 Offset: 0x25FE490 VA: 0x1825FFA90
	private static extern int mono_btls_ssl_handshake(IntPtr handle) { }

	// RVA: 0x25FF680 Offset: 0x25FE080 VA: 0x1825FF680
	private static extern void mono_btls_ssl_close(IntPtr handle) { }

	// RVA: 0x25FFF80 Offset: 0x25FE980 VA: 0x1825FFF80
	private static extern int mono_btls_ssl_shutdown(IntPtr handle) { }

	// RVA: 0x25FFDD0 Offset: 0x25FE7D0 VA: 0x1825FFDD0
	private static extern void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode) { }

	// RVA: 0x25FFD40 Offset: 0x25FE740 VA: 0x1825FFD40
	private static extern void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio) { }

	// RVA: 0x25FFC20 Offset: 0x25FE620 VA: 0x1825FFC20
	private static extern int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x2600120 Offset: 0x25FEB20 VA: 0x182600120
	private static extern int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x25FF880 Offset: 0x25FE280 VA: 0x1825FF880
	private static extern int mono_btls_ssl_get_error(IntPtr handle, int ret_code) { }

	// RVA: 0x25FFA10 Offset: 0x25FE410 VA: 0x1825FFA10
	private static extern int mono_btls_ssl_get_version(IntPtr handle) { }

	// RVA: 0x25FF800 Offset: 0x25FE200 VA: 0x1825FF800
	private static extern int mono_btls_ssl_get_cipher(IntPtr handle) { }

	// RVA: 0x25FF910 Offset: 0x25FE310 VA: 0x1825FF910
	private static extern IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle) { }

	// RVA: 0x25FFB90 Offset: 0x25FE590 VA: 0x1825FFB90
	private static extern void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx) { }

	// RVA: 0x25FFEF0 Offset: 0x25FE8F0 VA: 0x1825FFEF0
	private static extern int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name) { }

	// RVA: 0x25FF990 Offset: 0x25FE390 VA: 0x1825FF990
	private static extern IntPtr mono_btls_ssl_get_server_name(IntPtr handle) { }

	// RVA: 0x25FFE60 Offset: 0x25FE860 VA: 0x1825FFE60
	private static extern void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode) { }

	// RVA: 0x25FFCC0 Offset: 0x25FE6C0 VA: 0x1825FFCC0
	private static extern int mono_btls_ssl_renegotiate_pending(IntPtr handle) { }

	// RVA: 0x25FDDF0 Offset: 0x25FC7F0 VA: 0x1825FDDF0
	private static MonoBtlsSsl.BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) { }

	// RVA: 0x25FF290 Offset: 0x25FDC90 VA: 0x1825FF290
	public void .ctor(MonoBtlsSslCtx ctx) { }

	// RVA: 0x25FF4F0 Offset: 0x25FDEF0 VA: 0x1825FF4F0
	internal MonoBtlsSsl.BoringSslHandle get_Handle() { }

	// RVA: 0x25FE920 Offset: 0x25FD320 VA: 0x1825FE920
	public void SetBio(MonoBtlsBio bio) { }

	// RVA: 0x25FEFE0 Offset: 0x25FD9E0 VA: 0x1825FEFE0
	private Exception ThrowError(string callerName) { }

	// RVA: 0x25FE010 Offset: 0x25FCA10 VA: 0x1825FE010
	private MonoBtlsSslError GetError(int ret_code) { }

	// RVA: 0x25FEA10 Offset: 0x25FD410 VA: 0x1825FEA10
	public void SetCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x25FEB10 Offset: 0x25FD510 VA: 0x1825FEB10
	public void SetPrivateKey(MonoBtlsKey key) { }

	// RVA: 0x25FDB70 Offset: 0x25FC570 VA: 0x1825FDB70
	public void AddIntermediateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x25FDAB0 Offset: 0x25FC4B0 VA: 0x1825FDAB0
	public MonoBtlsSslError Accept() { }

	// RVA: 0x25FDD30 Offset: 0x25FC730 VA: 0x1825FDD30
	public MonoBtlsSslError Connect() { }

	// RVA: 0x25FE500 Offset: 0x25FCF00 VA: 0x1825FE500
	public MonoBtlsSslError Handshake() { }

	[MonoPInvokeCallback(typeof(MonoBtlsSsl.PrintErrorsCallbackFunc))]
	// RVA: 0x25FE5C0 Offset: 0x25FCFC0 VA: 0x1825FE5C0
	private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) { }

	// RVA: 0x25FE090 Offset: 0x25FCA90 VA: 0x1825FE090
	public string GetErrors() { }

	// RVA: 0x25FE6B0 Offset: 0x25FD0B0 VA: 0x1825FE6B0
	public void PrintErrors() { }

	// RVA: 0x25FE780 Offset: 0x25FD180 VA: 0x1825FE780
	public MonoBtlsSslError Read(IntPtr data, ref int dataSize) { }

	// RVA: 0x25FF180 Offset: 0x25FDB80 VA: 0x1825FF180
	public MonoBtlsSslError Write(IntPtr data, ref int dataSize) { }

	// RVA: 0x25FE460 Offset: 0x25FCE60 VA: 0x1825FE460
	public int GetVersion() { }

	// RVA: 0x25FDF30 Offset: 0x25FC930 VA: 0x1825FDF30
	public int GetCipher() { }

	// RVA: 0x25FE230 Offset: 0x25FCC30 VA: 0x1825FE230
	public MonoBtlsX509 GetPeerCertificate() { }

	// RVA: 0x25FED60 Offset: 0x25FD760 VA: 0x1825FED60
	public void SetServerName(string name) { }

	// RVA: 0x25FE360 Offset: 0x25FCD60 VA: 0x1825FE360
	public string GetServerName() { }

	// RVA: 0x25FEF10 Offset: 0x25FD910 VA: 0x1825FEF10
	public void Shutdown() { }

	// RVA: 0x25FEC10 Offset: 0x25FD610 VA: 0x1825FEC10
	public void SetQuietShutdown() { }

	// RVA: 0x25FDC70 Offset: 0x25FC670 VA: 0x1825FDC70 Slot: 5
	protected override void Close() { }

	// RVA: 0x25FECB0 Offset: 0x25FD6B0 VA: 0x1825FECB0
	public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) { }

	// RVA: 0x25FE880 Offset: 0x25FD280 VA: 0x1825FE880
	public bool RenegotiatePending() { }
}
