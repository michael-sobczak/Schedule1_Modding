public class Equippable : MonoBehaviour // TypeDefIndex: 2530
{
	// Fields
	protected ItemInstance itemInstance; // 0x20
	public bool CanInteractWhenEquipped; // 0x28
	public bool CanPickUpWhenEquipped; // 0x29

	// Methods

	// RVA: 0x8AE700 Offset: 0x8AD100 VA: 0x1808AE700 Slot: 4
	public virtual void Equip(ItemInstance item) { }

	// RVA: 0x8B5BC0 Offset: 0x8B45C0 VA: 0x1808B5BC0 Slot: 5
	public virtual void Unequip() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	protected virtual void Update() { }

	// RVA: 0x8AE020 Offset: 0x8ACA20 VA: 0x1808AE020
	public void .ctor() { }
}
