public class MushroomBedConfiguration : EntityConfiguration // TypeDefIndex: 1205
{
	// Fields
	[CompilerGenerated]
	private MushroomBed <MushroomBed>k__BackingField; // 0x40
	public ItemField Spawn; // 0x48
	public ItemField Additive1; // 0x50
	public ItemField Additive2; // 0x58
	public ItemField Additive3; // 0x60
	public NPCField AssignedBotanist; // 0x68
	public ObjectField Destination; // 0x70
	[CompilerGenerated]
	private TransitRoute <DestinationRoute>k__BackingField; // 0x78

	// Properties
	public MushroomBed MushroomBed { get; set; }
	public TransitRoute DestinationRoute { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public MushroomBed get_MushroomBed() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_MushroomBed(MushroomBed value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public TransitRoute get_DestinationRoute() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	protected void set_DestinationRoute(TransitRoute value) { }

	// RVA: 0x6064B0 Offset: 0x604EB0 VA: 0x1806064B0
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, MushroomBed mushroomBed) { }

	// RVA: 0x605DF0 Offset: 0x6047F0 VA: 0x180605DF0
	public string[] GetSelectedSeedIDs() { }

	// RVA: 0x606030 Offset: 0x604A30 VA: 0x180606030
	public bool IsAdditiveSelected(ItemDefinition additive) { }

	// RVA: 0x606130 Offset: 0x604B30 VA: 0x180606130 Slot: 6
	public override void Reset() { }

	// RVA: 0x605A50 Offset: 0x604450 VA: 0x180605A50
	private void DestinationChanged(BuildableItem item) { }

	// RVA: 0x605B90 Offset: 0x604590 VA: 0x180605B90
	public bool DestinationFilter(BuildableItem obj, out string reason) { }

	// RVA: 0x6062D0 Offset: 0x604CD0 VA: 0x1806062D0 Slot: 7
	public override void Selected() { }

	// RVA: 0x605A30 Offset: 0x604430 VA: 0x180605A30 Slot: 8
	public override void Deselected() { }

	// RVA: 0x6062F0 Offset: 0x604CF0 VA: 0x1806062F0 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x605CA0 Offset: 0x6046A0 VA: 0x180605CA0 Slot: 10
	public override string GetSaveString() { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__14_0(ItemDefinition <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__14_1(ItemDefinition <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__14_2(ItemDefinition <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__14_3(ItemDefinition <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__14_4(NPC <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__14_5(BuildableItem <p0>) { }
}
