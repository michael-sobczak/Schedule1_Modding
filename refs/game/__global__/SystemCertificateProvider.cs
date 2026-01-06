internal class SystemCertificateProvider : ISystemCertificateProvider // TypeDefIndex: 9317
{
	// Fields
	private static MonoTlsProvider provider; // 0x0
	private static int initialized; // 0x8
	private static X509PalImpl x509pal; // 0x10
	private static object syncRoot; // 0x18

	// Properties
	public X509PalImpl X509Pal { get; }

	// Methods

	// RVA: 0x201E290 Offset: 0x201CC90 VA: 0x18201E290
	private static X509PalImpl GetX509Pal() { }

	// RVA: 0x201E0F0 Offset: 0x201CAF0 VA: 0x18201E0F0
	private static void EnsureInitialized() { }

	// RVA: 0x201EA50 Offset: 0x201D450 VA: 0x18201EA50
	public X509PalImpl get_X509Pal() { }

	// RVA: 0x201E4C0 Offset: 0x201CEC0 VA: 0x18201E4C0 Slot: 4
	public X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x201E790 Offset: 0x201D190 VA: 0x18201E790 Slot: 5
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0x201E560 Offset: 0x201CF60 VA: 0x18201E560
	public X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x201E850 Offset: 0x201D250 VA: 0x18201E850 Slot: 6
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0x201E620 Offset: 0x201D020 VA: 0x18201E620
	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x201E9D0 Offset: 0x201D3D0 VA: 0x18201E9D0
	private static void .cctor() { }
}
