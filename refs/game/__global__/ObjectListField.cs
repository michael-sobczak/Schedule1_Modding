public class ObjectListField : ConfigField // TypeDefIndex: 1218
{
	// Fields
	public List<BuildableItem> SelectedObjects; // 0x18
	public int MaxItems; // 0x20
	public ObjectSelector.ObjectFilter objectFilter; // 0x28
	public List<Type> TypeRequirements; // 0x30
	public UnityEvent<List<BuildableItem>> onListChanged; // 0x38

	// Methods

	// RVA: 0x61C590 Offset: 0x61AF90 VA: 0x18061C590
	public void .ctor(EntityConfiguration parentConfig) { }

	// RVA: 0x61C170 Offset: 0x61AB70 VA: 0x18061C170
	public void SetList(List<BuildableItem> list, bool network) { }

	// RVA: 0x61B9E0 Offset: 0x61A3E0 VA: 0x18061B9E0
	public void AddItem(BuildableItem item) { }

	// RVA: 0x61BF90 Offset: 0x61A990 VA: 0x18061BF90
	public void RemoveItem(BuildableItem item) { }

	// RVA: 0x61C070 Offset: 0x61AA70 VA: 0x18061C070
	private void SelectedObjectDestroyed(BuildableItem item) { }

	// RVA: 0x61BD60 Offset: 0x61A760 VA: 0x18061BD60 Slot: 4
	public override bool IsValueDefault() { }

	// RVA: 0x61BBC0 Offset: 0x61A5C0 VA: 0x18061BBC0
	public ObjectListFieldData GetData() { }

	// RVA: 0x61BDB0 Offset: 0x61A7B0 VA: 0x18061BDB0
	public void Load(ObjectListFieldData data) { }
}
