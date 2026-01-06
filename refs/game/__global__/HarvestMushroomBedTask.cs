public class HarvestMushroomBedTask : Task // TypeDefIndex: 793
{
	// Fields
	private AudioSourceController _soundLoop; // 0xA0
	private MushroomBed _mushroomBed; // 0xA8
	protected bool _canDrag; // 0xB0
	private int _harvestCount; // 0xB4
	private int _harvestTotal; // 0xB8

	// Methods

	// RVA: 0x58B5C0 Offset: 0x589FC0 VA: 0x18058B5C0
	public void .ctor(MushroomBed mushroomBed, bool canDrag, AudioSourceController soundLoopPrefab) { }

	// RVA: 0x58A9E0 Offset: 0x5893E0 VA: 0x18058A9E0 Slot: 6
	public override void StopTask() { }

	// RVA: 0x58B040 Offset: 0x589A40 VA: 0x18058B040 Slot: 9
	public override void Update() { }

	// RVA: 0x58AE50 Offset: 0x589850 VA: 0x18058AE50
	private void UpdateInstructionText() { }

	// RVA: 0x58AD40 Offset: 0x589740 VA: 0x18058AD40 Slot: 10
	protected override void UpdateCursor() { }

	// RVA: 0x58A820 Offset: 0x589220 VA: 0x18058A820
	private GrowingMushroom GetHoveredHarvestable() { }
}
