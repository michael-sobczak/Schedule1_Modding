public class GrowContainerPourTask : Task // TypeDefIndex: 810
{
	// Fields
	[CompilerGenerated]
	private string <TaskName>k__BackingField; // 0xA0
	protected GrowContainer growContainer; // 0xA8
	protected ItemInstance item; // 0xB0
	protected Pourable pourable; // 0xB8
	[CompilerGenerated]
	private readonly bool <UseCoverage>k__BackingField; // 0xC0
	[CompilerGenerated]
	private readonly bool <FailOnEmpty>k__BackingField; // 0xC1
	[CompilerGenerated]
	private readonly GrowContainerCameraHandler.ECameraPosition <CameraPosition>k__BackingField; // 0xC4
	protected bool removeItemAfterInitialPour; // 0xC8

	// Properties
	public override string TaskName { get; set; }
	protected virtual bool UseCoverage { get; }
	protected virtual bool FailOnEmpty { get; }
	protected virtual GrowContainerCameraHandler.ECameraPosition CameraPosition { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 4
	public override string get_TaskName() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00 Slot: 5
	protected override void set_TaskName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4E8B60 Offset: 0x4E7560 VA: 0x1804E8B60 Slot: 14
	protected virtual bool get_UseCoverage() { }

	[CompilerGenerated]
	// RVA: 0x4E8CC0 Offset: 0x4E76C0 VA: 0x1804E8CC0 Slot: 15
	protected virtual bool get_FailOnEmpty() { }

	[CompilerGenerated]
	// RVA: 0x526FE0 Offset: 0x5259E0 VA: 0x180526FE0 Slot: 16
	protected virtual GrowContainerCameraHandler.ECameraPosition get_CameraPosition() { }

	// RVA: 0x5A25B0 Offset: 0x5A0FB0 VA: 0x1805A25B0
	public void .ctor(GrowContainer _growContainer, ItemInstance _itemInstance, Pourable _pourablePrefab) { }

	// RVA: 0x5A2540 Offset: 0x5A0F40 VA: 0x1805A2540 Slot: 9
	public override void Update() { }

	// RVA: 0x5A2180 Offset: 0x5A0B80 VA: 0x1805A2180 Slot: 6
	public override void StopTask() { }

	// RVA: 0x5A1E40 Offset: 0x5A0840 VA: 0x1805A1E40 Slot: 17
	protected virtual void OnInitialPour() { }

	// RVA: 0x5A1E60 Offset: 0x5A0860 VA: 0x1805A1E60
	protected void RemoveItem() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 18
	protected virtual void FullyCovered() { }
}
