public class BuildableItemLoader : Loader // TypeDefIndex: 948
{
	// Properties
	public virtual string ItemType { get; }

	// Methods

	// RVA: 0x5D5F40 Offset: 0x5D4940 VA: 0x1805D5F40 Slot: 5
	public virtual string get_ItemType() { }

	// RVA: 0x5D5E40 Offset: 0x5D4840 VA: 0x1805D5E40
	public void .ctor() { }

	// RVA: 0x5D5D40 Offset: 0x5D4740 VA: 0x1805D5D40 Slot: 4
	public override void Load(string mainPath) { }

	// RVA: 0x5D5B40 Offset: 0x5D4540 VA: 0x1805D5B40 Slot: 6
	public virtual void Load(DynamicSaveData data) { }

	// RVA: 0x5D5AF0 Offset: 0x5D44F0 VA: 0x1805D5AF0
	public BuildableItemData GetBuildableItemData(string mainPath) { }

	// RVA: -1 Offset: -1
	protected T GetData<T>(string mainPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5AC10 Offset: 0xE59610 VA: 0x180E5AC10
	|-BuildableItemLoader.GetData<object>
	*/
}
