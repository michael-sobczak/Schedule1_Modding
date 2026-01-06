public class PackageProductTask : Task // TypeDefIndex: 799
{
	// Fields
	[CompilerGenerated]
	private string <TaskName>k__BackingField; // 0xA0
	protected PackagingStation station; // 0xA8
	protected FunctionalPackaging Packaging; // 0xB0
	protected List<FunctionalProduct> Products; // 0xB8

	// Properties
	public override string TaskName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 4
	public override string get_TaskName() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00 Slot: 5
	protected override void set_TaskName(string value) { }

	// RVA: 0x590A50 Offset: 0x58F450 VA: 0x180590A50
	public void .ctor(PackagingStation _station) { }

	// RVA: 0x590620 Offset: 0x58F020 VA: 0x180590620 Slot: 6
	public override void StopTask() { }

	// RVA: 0x590A10 Offset: 0x58F410 VA: 0x180590A10 Slot: 7
	public override void Success() { }

	// RVA: 0x590590 Offset: 0x58EF90 VA: 0x180590590
	private void FullyPacked() { }

	// RVA: 0x5905C0 Offset: 0x58EFC0 VA: 0x1805905C0
	private void Sealed() { }

	// RVA: 0x493100 Offset: 0x491B00 VA: 0x180493100
	private void ReachedOutput() { }
}
