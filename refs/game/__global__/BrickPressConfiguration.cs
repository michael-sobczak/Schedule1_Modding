public class BrickPressConfiguration : EntityConfiguration // TypeDefIndex: 1195
{
	// Fields
	[CompilerGenerated]
	private BrickPress <BrickPress>k__BackingField; // 0x40
	public NPCField AssignedPackager; // 0x48
	public ObjectField Destination; // 0x50
	[CompilerGenerated]
	private TransitRoute <DestinationRoute>k__BackingField; // 0x58

	// Properties
	public BrickPress BrickPress { get; set; }
	public TransitRoute DestinationRoute { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public BrickPress get_BrickPress() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_BrickPress(BrickPress value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public TransitRoute get_DestinationRoute() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	protected void set_DestinationRoute(TransitRoute value) { }

	// RVA: 0x5F5310 Offset: 0x5F3D10 VA: 0x1805F5310
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, BrickPress station) { }

	// RVA: 0x5F5210 Offset: 0x5F3C10 VA: 0x1805F5210 Slot: 6
	public override void Reset() { }

	// RVA: 0x5F4F10 Offset: 0x5F3910 VA: 0x1805F4F10
	private void DestinationChanged(BuildableItem item) { }

	// RVA: 0x5F5050 Offset: 0x5F3A50 VA: 0x1805F5050
	public bool DestinationFilter(BuildableItem obj, out string reason) { }

	// RVA: 0x5F5250 Offset: 0x5F3C50 VA: 0x1805F5250 Slot: 7
	public override void Selected() { }

	// RVA: 0x5F4EF0 Offset: 0x5F38F0 VA: 0x1805F4EF0 Slot: 8
	public override void Deselected() { }

	// RVA: 0x5F5270 Offset: 0x5F3C70 VA: 0x1805F5270 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x5F5160 Offset: 0x5F3B60 VA: 0x1805F5160 Slot: 10
	public override string GetSaveString() { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__10_0(NPC <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__10_1(BuildableItem <p0>) { }
}
