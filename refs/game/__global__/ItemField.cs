public class ItemField : ConfigField // TypeDefIndex: 1214
{
	// Fields
	[CompilerGenerated]
	private ItemDefinition <SelectedItem>k__BackingField; // 0x18
	public bool CanSelectNone; // 0x20
	public List<ItemDefinition> Options; // 0x28
	public UnityEvent<ItemDefinition> onItemChanged; // 0x30

	// Properties
	public ItemDefinition SelectedItem { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ItemDefinition get_SelectedItem() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_SelectedItem(ItemDefinition value) { }

	// RVA: 0x611940 Offset: 0x610340 VA: 0x180611940
	public void .ctor(EntityConfiguration parentConfig) { }

	// RVA: 0x6118A0 Offset: 0x6102A0 VA: 0x1806118A0
	public void SetItem(ItemDefinition item, bool network) { }

	// RVA: 0x611760 Offset: 0x610160 VA: 0x180611760 Slot: 4
	public override bool IsValueDefault() { }

	// RVA: 0x611690 Offset: 0x610090 VA: 0x180611690
	public ItemFieldData GetData() { }

	// RVA: 0x6117B0 Offset: 0x6101B0 VA: 0x1806117B0
	public void Load(ItemFieldData data) { }
}
