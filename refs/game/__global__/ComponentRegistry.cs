internal class ComponentRegistry : IComponentRegistry // TypeDefIndex: 17839
{
	// Fields
	[CompilerGenerated]
	private readonly Dictionary<int, IServiceComponent> <ComponentTypeHashToInstance>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal Dictionary<int, IServiceComponent> ComponentTypeHashToInstance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal Dictionary<int, IServiceComponent> get_ComponentTypeHashToInstance() { }

	// RVA: 0x2B9B2F0 Offset: 0x2B99CF0 VA: 0x182B9B2F0
	public void .ctor() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(Dictionary<int, IServiceComponent> componentTypeHashToInstance) { }

	// RVA: -1 Offset: -1 Slot: 4
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE68000 Offset: 0xE66A00 VA: 0x180E68000
	|-ComponentRegistry.RegisterServiceComponent<object>
	|
	|-RVA: 0xE67D40 Offset: 0xE66740 VA: 0x180E67D40
	|-ComponentRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE67B60 Offset: 0xE66560 VA: 0x180E67B60
	|-ComponentRegistry.GetServiceComponent<object>
	|
	|-RVA: 0xE67950 Offset: 0xE66350 VA: 0x180E67950
	|-ComponentRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool TryGetServiceComponent<TComponent>(out TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE681D0 Offset: 0xE66BD0 VA: 0x180E681D0
	|-ComponentRegistry.TryGetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2B9B1A0 Offset: 0x2B99BA0 VA: 0x182B9B1A0
	private bool IsComponentTypeRegistered(int componentTypeHash) { }

	// RVA: 0x2B9B280 Offset: 0x2B99C80 VA: 0x182B9B280 Slot: 7
	public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance) { }
}
