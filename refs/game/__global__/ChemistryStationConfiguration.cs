public class ChemistryStationConfiguration : EntityConfiguration // TypeDefIndex: 1198
{
	// Fields
	[CompilerGenerated]
	private ChemistryStation <Station>k__BackingField; // 0x40
	public NPCField AssignedChemist; // 0x48
	public StationRecipeField Recipe; // 0x50
	public ObjectField Destination; // 0x58
	[CompilerGenerated]
	private TransitRoute <DestinationRoute>k__BackingField; // 0x60

	// Properties
	public ChemistryStation Station { get; set; }
	public TransitRoute DestinationRoute { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public ChemistryStation get_Station() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_Station(ChemistryStation value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public TransitRoute get_DestinationRoute() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	protected void set_DestinationRoute(TransitRoute value) { }

	// RVA: 0x5F89E0 Offset: 0x5F73E0 VA: 0x1805F89E0
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, ChemistryStation station) { }

	// RVA: 0x5F88E0 Offset: 0x5F72E0 VA: 0x1805F88E0 Slot: 6
	public override void Reset() { }

	// RVA: 0x5F85B0 Offset: 0x5F6FB0 VA: 0x1805F85B0
	private void DestinationChanged(BuildableItem item) { }

	// RVA: 0x5F86F0 Offset: 0x5F70F0 VA: 0x1805F86F0
	public bool DestinationFilter(BuildableItem obj, out string reason) { }

	// RVA: 0x5F8920 Offset: 0x5F7320 VA: 0x1805F8920 Slot: 7
	public override void Selected() { }

	// RVA: 0x5F8590 Offset: 0x5F6F90 VA: 0x1805F8590 Slot: 8
	public override void Deselected() { }

	// RVA: 0x5F8940 Offset: 0x5F7340 VA: 0x1805F8940 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x5F8800 Offset: 0x5F7200 VA: 0x1805F8800 Slot: 10
	public override string GetSaveString() { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__11_0(NPC <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__11_1(StationRecipe <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__11_2(BuildableItem <p0>) { }
}
