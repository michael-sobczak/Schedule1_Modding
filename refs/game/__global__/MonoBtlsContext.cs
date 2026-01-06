internal class MonoBtlsContext : MobileTlsContext, IMonoBtlsBioMono // TypeDefIndex: 9428
{
	// Fields
	private X509Certificate2 remoteCertificate; // 0x58
	private X509Certificate clientCertificate; // 0x60
	private X509CertificateImplBtls nativeServerCertificate; // 0x68
	private X509CertificateImplBtls nativeClientCertificate; // 0x70
	private MonoBtlsSslCtx ctx; // 0x78
	private MonoBtlsSsl ssl; // 0x80
	private MonoBtlsBio bio; // 0x88
	private MonoBtlsBio errbio; // 0x90
	private MonoTlsConnectionInfo connectionInfo; // 0x98
	private bool certificateValidated; // 0xA0
	private bool isAuthenticated; // 0xA1
	private bool connected; // 0xA2

	// Properties
	public override bool IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }
	public override X509Certificate2 RemoteCertificate { get; }

	// Methods

	// RVA: 0x2017290 Offset: 0x2015C90 VA: 0x182017290
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0x2015650 Offset: 0x2014050 VA: 0x182015650
	private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate) { }

	// RVA: 0x2016E00 Offset: 0x2015800 VA: 0x182016E00
	private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0x20167F0 Offset: 0x20151F0 VA: 0x1820167F0
	private int SelectCallback(string[] acceptableIssuers) { }

	// RVA: 0x20168C0 Offset: 0x20152C0 VA: 0x1820168C0
	private int ServerNameCallback() { }

	// RVA: 0x2016CA0 Offset: 0x20156A0 VA: 0x182016CA0 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x2016930 Offset: 0x2015330 VA: 0x182016930
	private void SetPrivateCertificate(X509CertificateImplBtls privateCert) { }

	// RVA: 0x20150F0 Offset: 0x2013AF0 VA: 0x1820150F0
	private static Exception GetException(MonoBtlsSslError status) { }

	// RVA: 0x2016380 Offset: 0x2014D80 VA: 0x182016380 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x2015030 Offset: 0x2013A30 VA: 0x182015030
	private MonoBtlsSslError DoProcessHandshake() { }

	// RVA: 0x2015090 Offset: 0x2013A90 VA: 0x182015090 Slot: 8
	public override void FinishHandshake() { }

	// RVA: 0x20158F0 Offset: 0x20142F0 VA: 0x1820158F0
	private void InitializeConnection() { }

	// RVA: 0x2015570 Offset: 0x2013F70 VA: 0x182015570
	private void GetPeerCertificate() { }

	// RVA: 0x20160F0 Offset: 0x2014AF0 VA: 0x1820160F0
	private void InitializeSession() { }

	// RVA: 0x2015870 Offset: 0x2014270 VA: 0x182015870
	private static TlsProtocols GetProtocol(TlsProtocolCode protocol) { }

	// RVA: 0x20150B0 Offset: 0x2013AB0 VA: 0x1820150B0 Slot: 11
	public override void Flush() { }

	// RVA: 0x20164E0 Offset: 0x2014EE0 VA: 0x1820164E0 Slot: 12
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x2017010 Offset: 0x2015A10 VA: 0x182017010 Slot: 13
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x20167B0 Offset: 0x20151B0 VA: 0x1820167B0 Slot: 16
	public override void Renegotiate() { }

	// RVA: 0x2016C40 Offset: 0x2015640 VA: 0x182016C40 Slot: 14
	public override void Shutdown() { }

	// RVA: 0x2016350 Offset: 0x2014D50 VA: 0x182016350 Slot: 15
	public override bool PendingRenegotiation() { }

	// RVA: -1 Offset: -1
	private void Dispose<T>(ref T disposable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF06410 Offset: 0xF04E10 VA: 0x180F06410
	|-MonoBtlsContext.Dispose<object>
	*/

	// RVA: 0x2014ED0 Offset: 0x20138D0 VA: 0x182014ED0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x20162F0 Offset: 0x2014CF0 VA: 0x1820162F0 Slot: 18
	private int Mono.Btls.IMonoBtlsBioMono.Read(byte[] buffer, int offset, int size, out bool wantMore) { }

	// RVA: 0x2016320 Offset: 0x2014D20 VA: 0x182016320 Slot: 19
	private bool Mono.Btls.IMonoBtlsBioMono.Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	private void Mono.Btls.IMonoBtlsBioMono.Flush() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	private void Mono.Btls.IMonoBtlsBioMono.Close() { }

	// RVA: 0xC21B60 Offset: 0xC20560 VA: 0x180C21B60 Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 10
	public override X509Certificate2 get_RemoteCertificate() { }
}
