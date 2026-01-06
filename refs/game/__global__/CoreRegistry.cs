public sealed class CoreRegistry // TypeDefIndex: 17844
{
	// Fields
	[CompilerGenerated]
	private static CoreRegistry <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly string <InstanceId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ServicesType <Type>k__BackingField; // 0x18
	[CompilerGenerated]
	private InitializationOptions <Options>k__BackingField; // 0x20
	[CompilerGenerated]
	private IPackageRegistry <PackageRegistry>k__BackingField; // 0x28
	[CompilerGenerated]
	private IComponentRegistry <ComponentRegistry>k__BackingField; // 0x30
	[CompilerGenerated]
	private IServiceRegistry <ServiceRegistry>k__BackingField; // 0x38

	// Properties
	public static CoreRegistry Instance { get; set; }
	public string InstanceId { get; }
	internal ServicesType Type { get; set; }
	internal InitializationOptions Options { get; set; }
	[NotNull]
	internal IPackageRegistry PackageRegistry { get; set; }
	[NotNull]
	internal IComponentRegistry ComponentRegistry { get; set; }
	[NotNull]
	internal IServiceRegistry ServiceRegistry { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2B9C370 Offset: 0x2B9AD70 VA: 0x182B9C370
	public static CoreRegistry get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x2B9C3B0 Offset: 0x2B9ADB0 VA: 0x182B9C3B0
	internal static void set_Instance(CoreRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_InstanceId() { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal ServicesType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	private void set_Type(ServicesType value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal InitializationOptions get_Options() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void set_Options(InitializationOptions value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal IPackageRegistry get_PackageRegistry() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_PackageRegistry(IPackageRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal IComponentRegistry get_ComponentRegistry() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_ComponentRegistry(IComponentRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal IServiceRegistry get_ServiceRegistry() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_ServiceRegistry(IServiceRegistry value) { }

	// RVA: 0x2B9C160 Offset: 0x2B9AB60 VA: 0x182B9C160
	internal void .ctor() { }

	// RVA: 0x2B9C290 Offset: 0x2B9AC90 VA: 0x182B9C290
	internal void .ctor(IPackageRegistry packageRegistry, ServicesType type = 0, string instanceId) { }

	// RVA: -1 Offset: -1
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B6C0 Offset: 0xE6A0C0 VA: 0x180E6B6C0
	|-CoreRegistry.RegisterPackage<object>
	|
	|-RVA: 0xE6B5D0 Offset: 0xE69FD0 VA: 0x180E6B5D0
	|-CoreRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B810 Offset: 0xE6A210 VA: 0x180E6B810
	|-CoreRegistry.RegisterServiceComponent<object>
	|
	|-RVA: 0xE6B740 Offset: 0xE6A140 VA: 0x180E6B740
	|-CoreRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B450 Offset: 0xE69E50 VA: 0x180E6B450
	|-CoreRegistry.GetServiceComponent<object>
	|
	|-RVA: 0xE6B3A0 Offset: 0xE69DA0 VA: 0x180E6B3A0
	|-CoreRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetServiceComponent<TComponent>(out TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B810 Offset: 0xE6A210 VA: 0x180E6B810
	|-CoreRegistry.TryGetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterService<T>(T service) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B8F0 Offset: 0xE6A2F0 VA: 0x180E6B8F0
	|-CoreRegistry.RegisterService<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B520 Offset: 0xE69F20 VA: 0x180E6B520
	|-CoreRegistry.GetService<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2B9C000 Offset: 0x2B9AA00 VA: 0x182B9C000
	internal void LockComponentRegistration() { }

	// RVA: 0x2B9C0B0 Offset: 0x2B9AAB0 VA: 0x182B9C0B0
	internal void LockServiceRegistration() { }
}
