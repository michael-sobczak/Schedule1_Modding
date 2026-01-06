internal class LockedComponentRegistry : IComponentRegistry // TypeDefIndex: 17841
{
	// Fields
	private const string k_ErrorMessage = "Component registration has been locked. Make sure to register service components before all packages have finished initializing.";
	[CompilerGenerated]
	private readonly IComponentRegistry <Registry>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal IComponentRegistry Registry { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal IComponentRegistry get_Registry() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(IComponentRegistry registryToLock) { }

	// RVA: -1 Offset: -1 Slot: 4
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFCF00 Offset: 0xEFB900 VA: 0x180EFCF00
	|-LockedComponentRegistry.RegisterServiceComponent<object>
	|-LockedComponentRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFCE30 Offset: 0xEFB830 VA: 0x180EFCE30
	|-LockedComponentRegistry.GetServiceComponent<object>
	|
	|-RVA: 0xEFCD80 Offset: 0xEFB780 VA: 0x180EFCD80
	|-LockedComponentRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool TryGetServiceComponent<TComponent>(out TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFCF50 Offset: 0xEFB950 VA: 0x180EFCF50
	|-LockedComponentRegistry.TryGetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2B9F1C0 Offset: 0x2B9DBC0 VA: 0x182B9F1C0 Slot: 7
	public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance) { }
}
