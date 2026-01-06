internal class LockedServiceRegistry : IServiceRegistry // TypeDefIndex: 17867
{
	// Fields
	private const string k_ErrorMessage = "Service registration has been locked. Make sure to register service services before all packages have finished initializing.";
	[CompilerGenerated]
	private readonly IServiceRegistry <Registry>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal IServiceRegistry Registry { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal IServiceRegistry get_Registry() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(IServiceRegistry registryToLock) { }

	// RVA: -1 Offset: -1 Slot: 4
	public void RegisterService<T>(T service) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD0D0 Offset: 0xEFBAD0 VA: 0x180EFD0D0
	|-LockedServiceRegistry.RegisterService<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T GetService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFCD80 Offset: 0xEFB780 VA: 0x180EFCD80
	|-LockedServiceRegistry.GetService<__Il2CppFullySharedGenericType>
	*/
}
