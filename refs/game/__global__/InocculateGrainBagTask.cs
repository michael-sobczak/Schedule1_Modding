public class InocculateGrainBagTask : Task // TypeDefIndex: 796
{
	// Fields
	[CompilerGenerated]
	private string <TaskName>k__BackingField; // 0xA0
	private MushroomSpawnStation _station; // 0xA8
	private MushroomSpawnStationItem _spawn; // 0xB0
	private SporeSyringeStationItem _syringe; // 0xB8
	private InocculateGrainBagTask.EStage _currentStage; // 0xC0
	private ItemInstance _grainBagInstance; // 0xC8
	private ItemInstance _syringeInstance; // 0xD0
	private ShroomSpawnDefinition _spawnDefinition; // 0xD8

	// Properties
	public override string TaskName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 4
	public override string get_TaskName() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00 Slot: 5
	protected override void set_TaskName(string value) { }

	// RVA: 0x58DA70 Offset: 0x58C470 VA: 0x18058DA70
	public void .ctor(MushroomSpawnStation station) { }

	// RVA: 0x58D760 Offset: 0x58C160 VA: 0x18058D760 Slot: 7
	public override void Success() { }

	// RVA: 0x58D650 Offset: 0x58C050 VA: 0x18058D650 Slot: 6
	public override void StopTask() { }

	// RVA: 0x58D920 Offset: 0x58C320 VA: 0x18058D920 Slot: 9
	public override void Update() { }

	// RVA: 0x58D400 Offset: 0x58BE00 VA: 0x18058D400
	private string GetInstructionForStage(InocculateGrainBagTask.EStage stage) { }

	// RVA: 0x58D5B0 Offset: 0x58BFB0 VA: 0x18058D5B0
	private void OnSyringeCapRemoved() { }

	// RVA: 0x58D600 Offset: 0x58C000 VA: 0x18058D600
	private void OnSyringeInserted() { }

	// RVA: 0x58D550 Offset: 0x58BF50 VA: 0x18058D550
	private void OnPlungerPushed(float amount) { }
}
