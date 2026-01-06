public sealed class CorePackageRegistry // TypeDefIndex: 17842
{
	// Fields
	[CompilerGenerated]
	private static CorePackageRegistry <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private IPackageRegistry <Registry>k__BackingField; // 0x10

	// Properties
	public static CorePackageRegistry Instance { get; set; }
	internal IPackageRegistry Registry { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2B9BE60 Offset: 0x2B9A860 VA: 0x182B9BE60
	public static CorePackageRegistry get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x2B9BEA0 Offset: 0x2B9A8A0 VA: 0x182B9BEA0
	internal static void set_Instance(CorePackageRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal IPackageRegistry get_Registry() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_Registry(IPackageRegistry value) { }

	// RVA: 0x2B9BDB0 Offset: 0x2B9A7B0 VA: 0x182B9BDB0
	internal void .ctor() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(IPackageRegistry registry) { }

	// RVA: -1 Offset: -1
	public CoreRegistration Register<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B2C0 Offset: 0xE69CC0 VA: 0x180E6B2C0
	|-CorePackageRegistry.Register<object>
	|
	|-RVA: 0xE6B1D0 Offset: 0xE69BD0 VA: 0x180E6B1D0
	|-CorePackageRegistry.Register<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2B9BD00 Offset: 0x2B9A700 VA: 0x182B9BD00
	internal void Lock() { }
}
