public abstract class ItemModule : MonoBehaviour // TypeDefIndex: 2424
{
	// Fields
	[CompilerGenerated]
	private StationItem <Item>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsModuleActive>k__BackingField; // 0x28

	// Properties
	public StationItem Item { get; set; }
	public bool IsModuleActive { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public StationItem get_Item() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_Item(StationItem value) { }

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsModuleActive() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsModuleActive(bool value) { }

	// RVA: 0x872C50 Offset: 0x871650 VA: 0x180872C50 Slot: 4
	public virtual void ActivateModule(StationItem item) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
