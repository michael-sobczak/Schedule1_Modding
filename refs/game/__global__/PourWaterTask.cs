public class PourWaterTask : PourOntoTargetTask // TypeDefIndex: 814
{
	// Fields
	public const float NORMALIZED_FILL_PER_TARGET = 0.2;
	public static bool hintShown; // 0x0

	// Properties
	protected override bool UseCoverage { get; }
	protected override bool FailOnEmpty { get; }
	protected override GrowContainerCameraHandler.ECameraPosition CameraPosition { get; }

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 14
	protected override bool get_UseCoverage() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	protected override bool get_FailOnEmpty() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 16
	protected override GrowContainerCameraHandler.ECameraPosition get_CameraPosition() { }

	// RVA: 0x5ACE50 Offset: 0x5AB850 VA: 0x1805ACE50
	public void .ctor(GrowContainer _growContainer, ItemInstance _itemInstance, Pourable _pourablePrefab) { }

	// RVA: 0x5ACBB0 Offset: 0x5AB5B0 VA: 0x1805ACBB0 Slot: 6
	public override void StopTask() { }

	// RVA: 0x5ACC00 Offset: 0x5AB600 VA: 0x1805ACC00 Slot: 19
	public override void TargetReached() { }
}
