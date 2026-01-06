public class Equippable_Cash : Equippable_Viewmodel // TypeDefIndex: 3309
{
	// Fields
	private int amountIndex; // 0x60
	[Header("References")]
	public Transform Container_Under100; // 0x68
	public List<Transform> SingleNotes; // 0x70
	public Transform Container_100_300; // 0x78
	public List<Transform> Under300Stacks; // 0x80
	public Transform Container_300Plus; // 0x88
	public List<Transform> PlusStacks; // 0x90

	// Methods

	// RVA: 0xA4AD90 Offset: 0xA49790 VA: 0x180A4AD90 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0xA4AEA0 Offset: 0xA498A0 VA: 0x180A4AEA0 Slot: 5
	public override void Unequip() { }

	// RVA: 0xA4AFB0 Offset: 0xA499B0 VA: 0x180A4AFB0
	private void UpdateCashVisuals() { }

	// RVA: 0x840740 Offset: 0x83F140 VA: 0x180840740
	public void .ctor() { }
}
