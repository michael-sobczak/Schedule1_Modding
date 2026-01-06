public class HarvestPlant : Task // TypeDefIndex: 794
{
	// Fields
	[CompilerGenerated]
	private string <TaskName>k__BackingField; // 0xA0
	protected Pot pot; // 0xA8
	private int HarvestCount; // 0xB0
	private int HarvestTotal; // 0xB4
	private float rotation; // 0xB8
	private static bool hintShown; // 0x0
	private static bool CanDrag; // 0x1
	private AudioSourceController SoundLoop; // 0xC0

	// Properties
	public override string TaskName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 4
	public override string get_TaskName() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00 Slot: 5
	protected override void set_TaskName(string value) { }

	// RVA: 0x58CB30 Offset: 0x58B530 VA: 0x18058CB30
	public void .ctor(Pot _pot, bool canDrag, AudioSourceController soundLoopPrefab) { }

	// RVA: 0x58C240 Offset: 0x58AC40 VA: 0x18058C240
	private void UpdateInstructionText() { }

	// RVA: 0x58BD60 Offset: 0x58A760 VA: 0x18058BD60 Slot: 6
	public override void StopTask() { }

	// RVA: 0x58C130 Offset: 0x58AB30 VA: 0x18058C130 Slot: 10
	protected override void UpdateCursor() { }

	// RVA: 0x58C4B0 Offset: 0x58AEB0 VA: 0x18058C4B0 Slot: 9
	public override void Update() { }

	// RVA: 0x58BC50 Offset: 0x58A650 VA: 0x18058BC50
	private PlantHarvestable GetHoveredHarvestable() { }
}
