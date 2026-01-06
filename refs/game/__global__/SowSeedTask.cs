public class SowSeedTask : Task // TypeDefIndex: 801
{
	// Fields
	[CompilerGenerated]
	private string <TaskName>k__BackingField; // 0xA0
	protected Pot pot; // 0xA8
	protected SeedDefinition definition; // 0xB0
	protected FunctionalSeed seed; // 0xB8
	private bool seedExitedVial; // 0xC0
	private bool seedReachedDestination; // 0xC1
	private bool successfullyPlanted; // 0xC2
	private float weedSeedStationaryTime; // 0xC4
	private bool capRemoved; // 0xC8

	// Properties
	public override string TaskName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 4
	public override string get_TaskName() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00 Slot: 5
	protected override void set_TaskName(string value) { }

	// RVA: 0x5ADED0 Offset: 0x5AC8D0 VA: 0x1805ADED0
	public void .ctor(Pot _pot, SeedDefinition def) { }

	// RVA: 0x5ADA80 Offset: 0x5AC480 VA: 0x1805ADA80 Slot: 9
	public override void Update() { }

	// RVA: 0x5AD6A0 Offset: 0x5AC0A0 VA: 0x1805AD6A0 Slot: 7
	public override void Success() { }

	// RVA: 0x5AD300 Offset: 0x5ABD00 VA: 0x1805AD300 Slot: 6
	public override void StopTask() { }

	// RVA: 0x5AD130 Offset: 0x5ABB30 VA: 0x1805AD130
	private void OnSeedExitVial() { }

	// RVA: 0x5AD140 Offset: 0x5ABB40 VA: 0x1805AD140
	private void OnSeedReachedDestination() { }
}
