public class HotbarSlot : ItemSlot // TypeDefIndex: 1312
{
	// Fields
	[CompilerGenerated]
	private bool <IsEquipped>k__BackingField; // 0x78
	public Equippable Equippable; // 0x80
	public HotbarSlot.EquipEvent onEquipChanged; // 0x88

	// Properties
	public bool IsEquipped { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E23F0 Offset: 0x4E0DF0 VA: 0x1804E23F0
	public bool get_IsEquipped() { }

	[CompilerGenerated]
	// RVA: 0x4E28E0 Offset: 0x4E12E0 VA: 0x1804E28E0
	protected void set_IsEquipped(bool value) { }

	// RVA: 0x6431F0 Offset: 0x641BF0 VA: 0x1806431F0 Slot: 4
	public override void SetStoredItem(ItemInstance instance, bool _internal = False) { }

	// RVA: 0x642EC0 Offset: 0x6418C0 VA: 0x180642EC0 Slot: 7
	public override void ClearStoredInstance(bool _internal = False) { }

	// RVA: 0x642F90 Offset: 0x641990 VA: 0x180642F90 Slot: 14
	public virtual void Equip() { }

	// RVA: 0x643460 Offset: 0x641E60 VA: 0x180643460 Slot: 15
	public virtual void Unequip() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 13
	public override bool CanSlotAcceptCash() { }

	// RVA: 0x6435A0 Offset: 0x641FA0 VA: 0x1806435A0
	public void .ctor() { }
}
