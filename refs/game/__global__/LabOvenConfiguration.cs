public class LabOvenConfiguration : EntityConfiguration // TypeDefIndex: 1202
{
	// Fields
	[CompilerGenerated]
	private LabOven <Oven>k__BackingField; // 0x40
	public NPCField AssignedChemist; // 0x48
	public ObjectField Destination; // 0x50
	[CompilerGenerated]
	private TransitRoute <DestinationRoute>k__BackingField; // 0x58

	// Properties
	public LabOven Oven { get; set; }
	public TransitRoute DestinationRoute { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public LabOven get_Oven() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_Oven(LabOven value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public TransitRoute get_DestinationRoute() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	protected void set_DestinationRoute(TransitRoute value) { }

	// RVA: 0x5FFD10 Offset: 0x5FE710 VA: 0x1805FFD10
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, LabOven oven) { }

	// RVA: 0x5F5210 Offset: 0x5F3C10 VA: 0x1805F5210 Slot: 6
	public override void Reset() { }

	// RVA: 0x5FF970 Offset: 0x5FE370 VA: 0x1805FF970
	private void DestinationChanged(BuildableItem item) { }

	// RVA: 0x5FFAB0 Offset: 0x5FE4B0 VA: 0x1805FFAB0
	public bool DestinationFilter(BuildableItem obj, out string reason) { }

	// RVA: 0x5F5250 Offset: 0x5F3C50 VA: 0x1805F5250 Slot: 7
	public override void Selected() { }

	// RVA: 0x5F4EF0 Offset: 0x5F38F0 VA: 0x1805F4EF0 Slot: 8
	public override void Deselected() { }

	// RVA: 0x5FFC70 Offset: 0x5FE670 VA: 0x1805FFC70 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x5FFBC0 Offset: 0x5FE5C0 VA: 0x1805FFBC0 Slot: 10
	public override string GetSaveString() { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__10_0(NPC <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__10_1(BuildableItem <p0>) { }
}
