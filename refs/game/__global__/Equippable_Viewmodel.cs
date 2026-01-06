public class Equippable_Viewmodel : Equippable // TypeDefIndex: 2547
{
	// Fields
	[Header("Viewmodel settings")]
	public Vector3 localPosition; // 0x30
	public Vector3 localEulerAngles; // 0x3C
	public Vector3 localScale; // 0x48
	[Header("Third person animation settings")]
	public AvatarEquippable AvatarEquippable; // 0x58

	// Methods

	// RVA: 0x8B5CD0 Offset: 0x8B46D0 VA: 0x1808B5CD0 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0x8B6100 Offset: 0x8B4B00 VA: 0x1808B6100 Slot: 5
	public override void Unequip() { }

	// RVA: 0x8B5F80 Offset: 0x8B4980 VA: 0x1808B5F80 Slot: 7
	protected virtual void PlayEquipAnimation() { }

	// RVA: 0x8B6040 Offset: 0x8B4A40 VA: 0x1808B6040 Slot: 8
	protected virtual void PlayUnequipAnimation() { }

	// RVA: 0x8ADE90 Offset: 0x8AC890 VA: 0x1808ADE90
	public void .ctor() { }
}
