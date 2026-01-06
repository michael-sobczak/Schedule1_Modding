internal abstract class X509PalImpl // TypeDefIndex: 9321
{
	// Fields
	private static byte[] signedData; // 0x0

	// Properties
	public bool SupportsLegacyBasicConstraintsExtension { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract X509CertificateImpl Import(byte[] data);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509Certificate2Impl Import(X509Certificate cert);

	// RVA: 0x2026D10 Offset: 0x2025710 VA: 0x182026D10
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x2026670 Offset: 0x2025070 VA: 0x182026670
	protected static byte[] ConvertData(byte[] data) { }

	// RVA: 0x2026B50 Offset: 0x2025550 VA: 0x182026B50
	internal X509Certificate2Impl ImportFallback(byte[] data) { }

	// RVA: 0x2026C90 Offset: 0x2025690 VA: 0x182026C90
	internal X509Certificate2Impl ImportFallback(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public bool get_SupportsLegacyBasicConstraintsExtension() { }

	// RVA: 0x2026830 Offset: 0x2025230 VA: 0x182026830
	public X509ContentType GetCertContentType(byte[] rawData) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x2026E30 Offset: 0x2025830 VA: 0x182026E30
	private static void .cctor() { }
}
