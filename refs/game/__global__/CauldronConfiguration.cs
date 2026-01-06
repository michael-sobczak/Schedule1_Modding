public class CauldronConfiguration : EntityConfiguration // TypeDefIndex: 1196
{
	// Fields
	[CompilerGenerated]
	private Cauldron <Station>k__BackingField; // 0x40
	public NPCField AssignedChemist; // 0x48
	public ObjectField Destination; // 0x50
	[CompilerGenerated]
	private TransitRoute <DestinationRoute>k__BackingField; // 0x58

	// Properties
	public Cauldron Station { get; set; }
	public TransitRoute DestinationRoute { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Cauldron get_Station() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_Station(Cauldron value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public TransitRoute get_DestinationRoute() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	protected void set_DestinationRoute(TransitRoute value) { }

	// RVA: 0x5F59C0 Offset: 0x5F43C0 VA: 0x1805F59C0
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, Cauldron cauldron) { }

	// RVA: 0x5F5210 Offset: 0x5F3C10 VA: 0x1805F5210 Slot: 6
	public override void Reset() { }

	// RVA: 0x5F5620 Offset: 0x5F4020 VA: 0x1805F5620
	private void DestinationChanged(BuildableItem item) { }

	// RVA: 0x5F5760 Offset: 0x5F4160 VA: 0x1805F5760
	public bool DestinationFilter(BuildableItem obj, out string reason) { }

	// RVA: 0x5F5250 Offset: 0x5F3C50 VA: 0x1805F5250 Slot: 7
	public override void Selected() { }

	// RVA: 0x5F4EF0 Offset: 0x5F38F0 VA: 0x1805F4EF0 Slot: 8
	public override void Deselected() { }

	// RVA: 0x5F5920 Offset: 0x5F4320 VA: 0x1805F5920 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x5F5870 Offset: 0x5F4270 VA: 0x1805F5870 Slot: 10
	public override string GetSaveString() { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__10_0(NPC <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__10_1(BuildableItem <p0>) { }
}
