internal class SystemDependencyProvider : ISystemDependencyProvider // TypeDefIndex: 9318
{
	// Fields
	private static SystemDependencyProvider instance; // 0x0
	private static object syncRoot; // 0x8
	[CompilerGenerated]
	private readonly SystemCertificateProvider <CertificateProvider>k__BackingField; // 0x10

	// Properties
	public static SystemDependencyProvider Instance { get; }
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.CertificateProvider { get; }
	public SystemCertificateProvider CertificateProvider { get; }
	public X509PalImpl X509Pal { get; }

	// Methods

	// RVA: 0x201EDF0 Offset: 0x201D7F0 VA: 0x18201EDF0
	public static SystemDependencyProvider get_Instance() { }

	// RVA: 0x201EB00 Offset: 0x201D500 VA: 0x18201EB00
	internal static void Initialize() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 4
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public SystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0x201EE50 Offset: 0x201D850 VA: 0x18201EE50
	public X509PalImpl get_X509Pal() { }

	// RVA: 0x201ED50 Offset: 0x201D750 VA: 0x18201ED50
	private void .ctor() { }

	// RVA: 0x201ECD0 Offset: 0x201D6D0 VA: 0x18201ECD0
	private static void .cctor() { }
}
