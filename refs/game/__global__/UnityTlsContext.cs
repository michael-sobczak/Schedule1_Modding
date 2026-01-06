internal class UnityTlsContext : MobileTlsContext // TypeDefIndex: 9377
{
	// Fields
	private UnityTls.unitytls_tlsctx* tlsContext; // 0x58
	private UnityTls.unitytls_x509list* requestedClientCertChain; // 0x60
	private UnityTls.unitytls_key* requestedClientKey; // 0x68
	private UnityTls.unitytls_tlsctx_read_callback readCallback; // 0x70
	private UnityTls.unitytls_tlsctx_write_callback writeCallback; // 0x78
	private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
	private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
	private X509Certificate localClientCertificate; // 0x90
	private X509Certificate2 remoteCertificate; // 0x98
	private MonoTlsConnectionInfo connectioninfo; // 0xA0
	private bool isAuthenticated; // 0xA8
	private bool hasContext; // 0xA9
	private bool closedGraceful; // 0xAA
	private byte[] writeBuffer; // 0xB0
	private byte[] readBuffer; // 0xB8
	private GCHandle handle; // 0xC0
	private Exception lastException; // 0xC8

	// Properties
	public override bool IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }
	public override X509Certificate2 RemoteCertificate { get; }

	// Methods

	// RVA: 0x2024170 Offset: 0x2022B70 VA: 0x182024170
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0x2022780 Offset: 0x2021180 VA: 0x182022780
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

	// RVA: 0x4D63F0 Offset: 0x4D4DF0 VA: 0x1804D63F0 Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250 Slot: 10
	public override X509Certificate2 get_RemoteCertificate() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	public override void Flush() { }

	// RVA: 0x20232D0 Offset: 0x2021CD0 VA: 0x1820232D0 Slot: 12
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2023F60 Offset: 0x2022960 VA: 0x182023F60 Slot: 13
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x20234E0 Offset: 0x2021EE0 VA: 0x1820234E0 Slot: 16
	public override void Renegotiate() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	public override bool PendingRenegotiation() { }

	// RVA: 0x2023520 Offset: 0x2021F20 VA: 0x182023520 Slot: 14
	public override void Shutdown() { }

	// RVA: 0x2022620 Offset: 0x2021020 VA: 0x182022620 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2023660 Offset: 0x2022060 VA: 0x182023660 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x2022C20 Offset: 0x2021620 VA: 0x182022C20 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x2022AA0 Offset: 0x20214A0 VA: 0x182022AA0 Slot: 8
	public override void FinishHandshake() { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_write_callback))]
	// RVA: 0x2023E90 Offset: 0x2022890 VA: 0x182023E90
	private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x2023C80 Offset: 0x2022680 VA: 0x182023C80
	private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_read_callback))]
	// RVA: 0x2022F50 Offset: 0x2021950 VA: 0x182022F50
	private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x2023020 Offset: 0x2021A20 VA: 0x182023020
	private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_x509verify_callback))]
	// RVA: 0x2023BC0 Offset: 0x20225C0 VA: 0x182023BC0
	private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x20238B0 Offset: 0x20222B0 VA: 0x1820238B0
	private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_certificate_callback))]
	// RVA: 0x2022500 Offset: 0x2020F00 VA: 0x182022500
	private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x20221B0 Offset: 0x2020BB0 VA: 0x1820221B0
	private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }
}
