internal class ServiceRegistry : IServiceRegistry // TypeDefIndex: 17868
{
	// Fields
	[CompilerGenerated]
	private readonly Dictionary<int, object> <ServiceTypeHashToInstance>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal Dictionary<int, object> ServiceTypeHashToInstance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal Dictionary<int, object> get_ServiceTypeHashToInstance() { }

	// RVA: 0x2B9F4C0 Offset: 0x2B9DEC0 VA: 0x182B9F4C0
	public void .ctor() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(Dictionary<int, object> serviceTypeHashToInstance) { }

	// RVA: -1 Offset: -1 Slot: 4
	public void RegisterService<T>(T service) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4D520 Offset: 0xF4BF20 VA: 0x180F4D520
	|-ServiceRegistry.RegisterService<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T GetService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4D370 Offset: 0xF4BD70 VA: 0x180F4D370
	|-ServiceRegistry.GetService<__Il2CppFullySharedGenericType>
	*/
}
