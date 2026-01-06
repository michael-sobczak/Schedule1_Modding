internal class X509PalImplBtls : X509PalImpl // TypeDefIndex: 9481
{
	// Fields
	[CompilerGenerated]
	private readonly MonoBtlsProvider <Provider>k__BackingField; // 0x10

	// Properties
	private MonoBtlsProvider Provider { get; }

	// Methods

	// RVA: 0x2611DF0 Offset: 0x26107F0 VA: 0x182611DF0
	public void .ctor(MonoTlsProvider provider) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	private MonoBtlsProvider get_Provider() { }

	// RVA: 0x2611DC0 Offset: 0x26107C0 VA: 0x182611DC0 Slot: 4
	public override X509CertificateImpl Import(byte[] data) { }

	// RVA: 0x2611D70 Offset: 0x2610770 VA: 0x182611D70 Slot: 5
	public override X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x2611DA0 Offset: 0x26107A0 VA: 0x182611DA0 Slot: 6
	public override X509Certificate2Impl Import(X509Certificate cert) { }
}
