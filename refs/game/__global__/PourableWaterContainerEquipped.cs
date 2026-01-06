public class PourableWaterContainerEquipped : Equippable_Pourable // TypeDefIndex: 2549
{
	// Fields
	[SerializeField]
	private WaterContainerVisualizer _visuals; // 0x70
	[SerializeField]
	private WaterContainerPourable _pourablePrefab; // 0x78
	private WaterContainerInstance _waterContainerInstance; // 0x80

	// Methods

	// RVA: 0x8B7040 Offset: 0x8B5A40 VA: 0x1808B7040 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0x8B71F0 Offset: 0x8B5BF0 VA: 0x1808B71F0 Slot: 5
	public override void Unequip() { }

	// RVA: 0x8B6E60 Offset: 0x8B5860 VA: 0x1808B6E60 Slot: 11
	protected override bool CanPour(GrowContainer growContainer, out string reason) { }

	// RVA: 0x8B7180 Offset: 0x8B5B80 VA: 0x1808B7180 Slot: 10
	protected override void StartPourTask(GrowContainer growContainer) { }

	// RVA: 0x8AD860 Offset: 0x8AC260 VA: 0x1808AD860
	public void .ctor() { }
}
