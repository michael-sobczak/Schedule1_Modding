public class PackagingStationConfiguration : EntityConfiguration // TypeDefIndex: 1207
{
	// Fields
	[CompilerGenerated]
	private PackagingStation <Station>k__BackingField; // 0x40
	public NPCField AssignedPackager; // 0x48
	public ObjectField Destination; // 0x50
	[CompilerGenerated]
	private TransitRoute <DestinationRoute>k__BackingField; // 0x58

	// Properties
	public PackagingStation Station { get; set; }
	public TransitRoute DestinationRoute { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public PackagingStation get_Station() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_Station(PackagingStation value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public TransitRoute get_DestinationRoute() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	protected void set_DestinationRoute(TransitRoute value) { }

	// RVA: 0x61CBB0 Offset: 0x61B5B0 VA: 0x18061CBB0
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, PackagingStation station) { }

	// RVA: 0x61CAB0 Offset: 0x61B4B0 VA: 0x18061CAB0 Slot: 6
	public override void Reset() { }

	// RVA: 0x61C780 Offset: 0x61B180 VA: 0x18061C780
	private void DestinationChanged(BuildableItem item) { }

	// RVA: 0x61C8C0 Offset: 0x61B2C0 VA: 0x18061C8C0
	public bool DestinationFilter(BuildableItem obj, out string reason) { }

	// RVA: 0x61CAF0 Offset: 0x61B4F0 VA: 0x18061CAF0 Slot: 7
	public override void Selected() { }

	// RVA: 0x61C750 Offset: 0x61B150 VA: 0x18061C750 Slot: 8
	public override void Deselected() { }

	// RVA: 0x61CB20 Offset: 0x61B520 VA: 0x18061CB20 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x61C9D0 Offset: 0x61B3D0 VA: 0x18061C9D0 Slot: 10
	public override string GetSaveString() { }

	[CompilerGenerated]
	// RVA: 0x61CBA0 Offset: 0x61B5A0 VA: 0x18061CBA0
	private void <.ctor>b__10_0(NPC <p0>) { }

	[CompilerGenerated]
	// RVA: 0x61CBA0 Offset: 0x61B5A0 VA: 0x18061CBA0
	private void <.ctor>b__10_1(BuildableItem <p0>) { }
}
