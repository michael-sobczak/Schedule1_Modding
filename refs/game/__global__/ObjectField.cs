public class ObjectField : ConfigField // TypeDefIndex: 1217
{
	// Fields
	public BuildableItem SelectedObject; // 0x18
	public UnityEvent<BuildableItem> onObjectChanged; // 0x20
	public ObjectSelector.ObjectFilter objectFilter; // 0x28
	public List<Type> TypeRequirements; // 0x30
	public bool DrawTransitLine; // 0x38

	// Methods

	// RVA: 0x61B910 Offset: 0x61A310 VA: 0x18061B910
	public void .ctor(EntityConfiguration parentConfig) { }

	// RVA: 0x61B720 Offset: 0x61A120 VA: 0x18061B720
	public void SetObject(BuildableItem obj, bool network) { }

	// RVA: 0x61B5D0 Offset: 0x619FD0 VA: 0x18061B5D0 Slot: 4
	public override bool IsValueDefault() { }

	// RVA: 0x61B710 Offset: 0x61A110 VA: 0x18061B710
	private void SelectedObjectDestroyed() { }

	// RVA: 0x61B620 Offset: 0x61A020 VA: 0x18061B620
	public void Load(ObjectFieldData data) { }

	// RVA: 0x61B4F0 Offset: 0x619EF0 VA: 0x18061B4F0
	public ObjectFieldData GetData() { }
}
