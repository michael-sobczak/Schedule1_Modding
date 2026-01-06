internal class MonoBtlsProvider : MobileTlsProvider // TypeDefIndex: 9437
{
	// Properties
	public override Guid ID { get; }
	public override string Name { get; }
	public override bool SupportsSslStream { get; }
	public override bool SupportsMonoExtensions { get; }
	public override bool SupportsConnectionInfo { get; }
	internal override bool SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }

	// Methods

	// RVA: 0x201BB60 Offset: 0x201A560 VA: 0x18201BB60 Slot: 4
	public override Guid get_ID() { }

	// RVA: 0x201BBC0 Offset: 0x201A5C0 VA: 0x18201BBC0 Slot: 5
	public override string get_Name() { }

	// RVA: 0x201BAC0 Offset: 0x201A4C0 VA: 0x18201BAC0
	internal void .ctor() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 6
	public override bool get_SupportsSslStream() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 8
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 10
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0x201BBF0 Offset: 0x201A5F0 VA: 0x18201BBF0 Slot: 9
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0x2019B30 Offset: 0x2018530 VA: 0x182019B30 Slot: 11
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x2019D00 Offset: 0x2018700 VA: 0x182019D00
	internal X509Certificate2Impl GetNativeCertificate(byte[] data, string password, X509KeyStorageFlags flags) { }

	// RVA: 0x2019EB0 Offset: 0x20188B0 VA: 0x182019EB0
	internal X509Certificate2Impl GetNativeCertificate(X509Certificate certificate) { }

	// RVA: 0x2019E30 Offset: 0x2018830 VA: 0x182019E30
	internal X509Certificate2Impl GetNativeCertificate(byte[] data, SafePasswordHandle password, X509KeyStorageFlags flags) { }

	// RVA: 0x201A2A0 Offset: 0x2018CA0 VA: 0x18201A2A0
	internal static MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode) { }

	// RVA: 0x201AAB0 Offset: 0x20194B0 VA: 0x18201AAB0 Slot: 12
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0x201B4A0 Offset: 0x2019EA0 VA: 0x18201B4A0
	internal static bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param) { }

	// RVA: 0x2019700 Offset: 0x2018100 VA: 0x182019700
	private void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0x201A420 Offset: 0x2018E20 VA: 0x18201A420
	internal static X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code) { }

	// RVA: 0x201A670 Offset: 0x2019070 VA: 0x18201A670
	internal static void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0x201AA20 Offset: 0x2019420 VA: 0x18201AA20
	private static void SetupDefaultCertificateStore(MonoBtlsX509Store store) { }

	// RVA: 0x20196A0 Offset: 0x20180A0 VA: 0x1820196A0
	private static void AddUserStore(MonoBtlsX509Store store) { }

	// RVA: 0x2019600 Offset: 0x2018000 VA: 0x182019600
	private static void AddMachineStore(MonoBtlsX509Store store) { }

	// RVA: 0x2019660 Offset: 0x2018060 VA: 0x182019660
	private static void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0x2019A30 Offset: 0x2018430 VA: 0x182019A30
	public static X509Certificate2 CreateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x2019C80 Offset: 0x2018680 VA: 0x182019C80
	public static X509Chain GetManagedChain(MonoBtlsX509Chain chain) { }

	// RVA: 0x2019BD0 Offset: 0x20185D0 VA: 0x182019BD0
	public static MonoBtlsX509 GetBtlsCertificate(X509Certificate certificate) { }

	// RVA: 0x2019FD0 Offset: 0x20189D0 VA: 0x182019FD0
	public static MonoBtlsX509Chain GetNativeChain(X509CertificateCollection certificates) { }
}
