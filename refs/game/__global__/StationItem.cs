public class StationItem : MonoBehaviour // TypeDefIndex: 2439
{
	// Fields
	[CompilerGenerated]
	private List<ItemModule> <ActiveModules>k__BackingField; // 0x20
	public List<ItemModule> Modules; // 0x28
	public TrashItem TrashPrefab; // 0x30

	// Properties
	public List<ItemModule> ActiveModules { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<ItemModule> get_ActiveModules() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_ActiveModules(List<ItemModule> value) { }

	// RVA: 0x8A8F60 Offset: 0x8A7960 VA: 0x1808A8F60 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void Initialize(StorableItemDefinition itemDefinition) { }

	// RVA: -1 Offset: -1
	public void ActivateModule<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF52970 Offset: 0xF51370 VA: 0x180F52970
	|-StationItem.ActivateModule<object>
	*/

	// RVA: 0x8A8FC0 Offset: 0x8A79C0 VA: 0x1808A8FC0
	public void Destroy() { }

	// RVA: -1 Offset: -1
	public bool HasModule<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF52D10 Offset: 0xF51710 VA: 0x180F52D10
	|-StationItem.HasModule<object>
	*/

	// RVA: -1 Offset: -1
	public T GetModule<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF52B30 Offset: 0xF51530 VA: 0x180F52B30
	|-StationItem.GetModule<object>
	*/

	// RVA: 0x8A9020 Offset: 0x8A7A20 VA: 0x1808A9020
	public void .ctor() { }
}
