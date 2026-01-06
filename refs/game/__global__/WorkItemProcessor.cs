internal class WorkItemProcessor : IWorkItemContext // TypeDefIndex: 13193
{
	// Fields
	[CompilerGenerated]
	private bool <workItemsInProgressRightNow>k__BackingField; // 0x10
	private readonly AstarPath astar; // 0x18
	private readonly WorkItemProcessor.IndexedQueue<AstarWorkItem> workItems; // 0x20
	private bool queuedWorkItemFloodFill; // 0x28
	private bool anyGraphsDirty; // 0x29
	[CompilerGenerated]
	private bool <workItemsInProgress>k__BackingField; // 0x2A

	// Properties
	public bool workItemsInProgressRightNow { get; set; }
	public bool anyQueued { get; }
	public bool workItemsInProgress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_workItemsInProgressRightNow() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	private void set_workItemsInProgressRightNow(bool value) { }

	// RVA: 0xB2E330 Offset: 0xB2CD30 VA: 0x180B2E330
	public bool get_anyQueued() { }

	[CompilerGenerated]
	// RVA: 0x844440 Offset: 0x842E40 VA: 0x180844440
	public bool get_workItemsInProgress() { }

	[CompilerGenerated]
	// RVA: 0x844450 Offset: 0x842E50 VA: 0x180844450
	private void set_workItemsInProgress(bool value) { }

	// RVA: 0xB2DE70 Offset: 0xB2C870 VA: 0x180B2DE70 Slot: 4
	private void Pathfinding.IWorkItemContext.QueueFloodFill() { }

	// RVA: 0xB2DE80 Offset: 0xB2C880 VA: 0x180B2DE80 Slot: 6
	private void Pathfinding.IWorkItemContext.SetGraphDirty(NavGraph graph) { }

	// RVA: 0xB2DE30 Offset: 0xB2C830 VA: 0x180B2DE30 Slot: 5
	public void EnsureValidFloodFill() { }

	// RVA: 0xB2E290 Offset: 0xB2CC90 VA: 0x180B2E290
	public void .ctor(AstarPath astar) { }

	// RVA: 0x4930D0 Offset: 0x491AD0 VA: 0x1804930D0
	public void OnFloodFill() { }

	// RVA: 0xB2DDC0 Offset: 0xB2C7C0 VA: 0x180B2DDC0
	public void AddWorkItem(AstarWorkItem item) { }

	// RVA: 0xB2DE90 Offset: 0xB2C890 VA: 0x180B2DE90
	public bool ProcessWorkItems(bool force) { }
}
