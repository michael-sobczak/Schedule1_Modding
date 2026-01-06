internal class ChainValidationHelper : ICertificateValidator // TypeDefIndex: 9395
{
	// Fields
	private readonly WeakReference<SslStream> owner; // 0x10
	private readonly MonoTlsSettings settings; // 0x18
	private readonly MobileTlsProvider provider; // 0x20
	private readonly ServerCertValidationCallback certValidationCallback; // 0x28
	private readonly LocalCertSelectionCallback certSelectionCallback; // 0x30
	private readonly MonoTlsStream tlsStream; // 0x38
	private readonly HttpWebRequest request; // 0x40

	// Properties
	public MonoTlsSettings Settings { get; }

	// Methods

	// RVA: 0x200F770 Offset: 0x200E170 VA: 0x18200F770
	internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x200F680 Offset: 0x200E080 VA: 0x18200F680
	internal static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0x2010080 Offset: 0x200EA80 VA: 0x182010080
	private void .ctor(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	// RVA: 0x200F860 Offset: 0x200E260 VA: 0x18200F860
	private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	// RVA: 0x200F730 Offset: 0x200E130 VA: 0x18200F730
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 4
	public MonoTlsSettings get_Settings() { }

	// RVA: 0x200FA10 Offset: 0x200E410 VA: 0x18200FA10 Slot: 5
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: 0x200FA70 Offset: 0x200E470 VA: 0x18200FA70
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x200FB10 Offset: 0x200E510 VA: 0x18200FB10
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x200FBF0 Offset: 0x200E5F0 VA: 0x18200FBF0
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x200F950 Offset: 0x200E350 VA: 0x18200F950
	private bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors) { }
}
