internal class LockedPackageRegistry : IPackageRegistry // TypeDefIndex: 17864
{
	// Fields
	private const string k_ErrorMessage = "Package registration has been locked. Make sure to register service packages in[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)].";
	[CompilerGenerated]
	private readonly IPackageRegistry <Registry>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal IPackageRegistry Registry { get; }
	public DependencyTree Tree { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal IPackageRegistry get_Registry() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(IPackageRegistry registryToLock) { }

	// RVA: 0x2B9F210 Offset: 0x2B9DC10 VA: 0x182B9F210 Slot: 4
	public DependencyTree get_Tree() { }

	// RVA: 0x2B9F260 Offset: 0x2B9DC60 VA: 0x182B9F260 Slot: 5
	public void set_Tree(DependencyTree value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD080 Offset: 0xEFBA80 VA: 0x180EFD080
	|-LockedPackageRegistry.RegisterPackage<object>
	|-LockedPackageRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void RegisterDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD030 Offset: 0xEFBA30 VA: 0x180EFD030
	|-LockedPackageRegistry.RegisterDependency<object>
	|-LockedPackageRegistry.RegisterDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RegisterOptionalDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD030 Offset: 0xEFBA30 VA: 0x180EFD030
	|-LockedPackageRegistry.RegisterOptionalDependency<object>
	|-LockedPackageRegistry.RegisterOptionalDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void RegisterProvision<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD030 Offset: 0xEFBA30 VA: 0x180EFD030
	|-LockedPackageRegistry.RegisterProvision<object>
	|-LockedPackageRegistry.RegisterProvision<__Il2CppFullySharedGenericType>
	*/
}
