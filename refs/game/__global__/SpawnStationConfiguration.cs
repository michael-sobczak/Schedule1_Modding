public class SpawnStationConfiguration : EntityConfiguration // TypeDefIndex: 1210
{
	// Fields
	[CompilerGenerated]
	private MushroomSpawnStation <Station>k__BackingField; // 0x40
	public NPCField AssignedBotanist; // 0x48
	public ObjectField Destination; // 0x50
	[CompilerGenerated]
	private TransitRoute <DestinationRoute>k__BackingField; // 0x58

	// Properties
	public MushroomSpawnStation Station { get; set; }
	public TransitRoute DestinationRoute { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public MushroomSpawnStation get_Station() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_Station(MushroomSpawnStation value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public TransitRoute get_DestinationRoute() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	protected void set_DestinationRoute(TransitRoute value) { }

	// RVA: 0x6223A0 Offset: 0x620DA0 VA: 0x1806223A0
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, MushroomSpawnStation station) { }

	// RVA: 0x61CAB0 Offset: 0x61B4B0 VA: 0x18061CAB0 Slot: 6
	public override void Reset() { }

	// RVA: 0x621FF0 Offset: 0x6209F0 VA: 0x180621FF0
	private void DestinationChanged(BuildableItem item) { }

	// RVA: 0x622130 Offset: 0x620B30 VA: 0x180622130
	public bool DestinationFilter(BuildableItem obj, out string reason) { }

	// RVA: 0x61CAF0 Offset: 0x61B4F0 VA: 0x18061CAF0 Slot: 7
	public override void Selected() { }

	// RVA: 0x61C750 Offset: 0x61B150 VA: 0x18061C750 Slot: 8
	public override void Deselected() { }

	// RVA: 0x622320 Offset: 0x620D20 VA: 0x180622320 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x622240 Offset: 0x620C40 VA: 0x180622240 Slot: 10
	public override string GetSaveString() { }

	[CompilerGenerated]
	// RVA: 0x61CBA0 Offset: 0x61B5A0 VA: 0x18061CBA0
	private void <.ctor>b__10_0(NPC <p0>) { }

	[CompilerGenerated]
	// RVA: 0x61CBA0 Offset: 0x61B5A0 VA: 0x18061CBA0
	private void <.ctor>b__10_1(BuildableItem <p0>) { }
}
