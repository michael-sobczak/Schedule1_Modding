public class Equippable_Revolver : Equippable_RangedWeapon // TypeDefIndex: 2544
{
	// Fields
	public Transform[] Bullets; // 0x1A0

	// Methods

	// RVA: 0x8B3550 Offset: 0x8B1F50 VA: 0x1808B3550 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0x8B3590 Offset: 0x8B1F90 VA: 0x1808B3590 Slot: 9
	public override void Fire() { }

	// RVA: 0x8B3600 Offset: 0x8B2000 VA: 0x1808B3600 Slot: 11
	public override void Reload() { }

	// RVA: 0x8B35D0 Offset: 0x8B1FD0 VA: 0x1808B35D0 Slot: 12
	protected override void NotifyIncrementalReload() { }

	// RVA: 0x8B3720 Offset: 0x8B2120 VA: 0x1808B3720
	private void SetDisplayedBullets(int count) { }

	// RVA: 0x8B37D0 Offset: 0x8B21D0 VA: 0x1808B37D0
	public void .ctor() { }
}
