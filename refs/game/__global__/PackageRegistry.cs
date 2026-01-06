internal class PackageRegistry : IPackageRegistry // TypeDefIndex: 17865
{
	// Fields
	[CompilerGenerated]
	private DependencyTree <Tree>k__BackingField; // 0x10

	// Properties
	public DependencyTree Tree { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 4
	public DependencyTree get_Tree() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0 Slot: 5
	public void set_Tree(DependencyTree value) { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(DependencyTree tree) { }

	// RVA: -1 Offset: -1 Slot: 6
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1B840 Offset: 0xF1A240 VA: 0x180F1B840
	|-PackageRegistry.RegisterPackage<object>
	|
	|-RVA: 0xF1B660 Offset: 0xF1A060 VA: 0x180F1B660
	|-PackageRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void RegisterDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1B430 Offset: 0xF19E30 VA: 0x180F1B430
	|-PackageRegistry.RegisterDependency<object>
	|-PackageRegistry.RegisterDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RegisterOptionalDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1B550 Offset: 0xF19F50 VA: 0x180F1B550
	|-PackageRegistry.RegisterOptionalDependency<object>
	|-PackageRegistry.RegisterOptionalDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void RegisterProvision<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1B9B0 Offset: 0xF1A3B0 VA: 0x180F1B9B0
	|-PackageRegistry.RegisterProvision<object>
	|-PackageRegistry.RegisterProvision<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2B9F380 Offset: 0x2B9DD80 VA: 0x182B9F380
	private void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash) { }
}
