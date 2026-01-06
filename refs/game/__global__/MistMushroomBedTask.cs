public class MistMushroomBedTask : Task // TypeDefIndex: 811
{
	// Fields
	[CompilerGenerated]
	private string <TaskName>k__BackingField; // 0xA0
	private const float TARGET_SPRAY_RADIUS = 0.15;
	private const float TARGET_SPRAY_DISTANCE = 0.35;
	private MushroomBed _mushroomBed; // 0xA8
	private Sprayable _sprayable; // 0xB0
	private GameObject _sprayableObj; // 0xB8
	private WaterContainerInstance _waterContainerInstance; // 0xC0

	// Properties
	public override string TaskName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 4
	public override string get_TaskName() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00 Slot: 5
	protected override void set_TaskName(string value) { }

	// RVA: 0x5AA2E0 Offset: 0x5A8CE0 VA: 0x1805AA2E0
	public void .ctor(MushroomBed mushroomBed, ItemInstance item, GameObject sprayablePrefab) { }

	// RVA: 0x5A9D80 Offset: 0x5A8780 VA: 0x1805A9D80
	private void OnSuccessfulSpray() { }

	// RVA: 0x5A9D50 Offset: 0x5A8750 VA: 0x1805A9D50
	private void OnSpray() { }

	// RVA: 0x5A9F60 Offset: 0x5A8960 VA: 0x1805A9F60 Slot: 6
	public override void StopTask() { }
}
