public class PotConfiguration : EntityConfiguration // TypeDefIndex: 1209
{
	// Fields
	[CompilerGenerated]
	private Pot <Pot>k__BackingField; // 0x40
	public ItemField Seed; // 0x48
	public ItemField Additive1; // 0x50
	public ItemField Additive2; // 0x58
	public ItemField Additive3; // 0x60
	public NPCField AssignedBotanist; // 0x68
	public ObjectField Destination; // 0x70
	[CompilerGenerated]
	private TransitRoute <DestinationRoute>k__BackingField; // 0x78

	// Properties
	public Pot Pot { get; set; }
	public TransitRoute DestinationRoute { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Pot get_Pot() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_Pot(Pot value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public TransitRoute get_DestinationRoute() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	protected void set_DestinationRoute(TransitRoute value) { }

	// RVA: 0x61ED60 Offset: 0x61D760 VA: 0x18061ED60
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, Pot pot) { }

	// RVA: 0x61E8F0 Offset: 0x61D2F0 VA: 0x18061E8F0
	public bool IsAdditiveSelected(ItemDefinition additive) { }

	// RVA: 0x61E6B0 Offset: 0x61D0B0 VA: 0x18061E6B0
	public string[] GetSelectedSeedIDs() { }

	// RVA: 0x61E9F0 Offset: 0x61D3F0 VA: 0x18061E9F0 Slot: 6
	public override void Reset() { }

	// RVA: 0x61E2E0 Offset: 0x61CCE0 VA: 0x18061E2E0
	private void DestinationChanged(BuildableItem item) { }

	// RVA: 0x61E420 Offset: 0x61CE20 VA: 0x18061E420
	public bool DestinationFilter(BuildableItem obj, out string reason) { }

	// RVA: 0x61EB90 Offset: 0x61D590 VA: 0x18061EB90 Slot: 7
	public override void Selected() { }

	// RVA: 0x61E2B0 Offset: 0x61CCB0 VA: 0x18061E2B0 Slot: 8
	public override void Deselected() { }

	// RVA: 0x61EBC0 Offset: 0x61D5C0 VA: 0x18061EBC0 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x61E530 Offset: 0x61CF30 VA: 0x18061E530 Slot: 10
	public override string GetSaveString() { }

	[CompilerGenerated]
	// RVA: 0x61CBA0 Offset: 0x61B5A0 VA: 0x18061CBA0
	private void <.ctor>b__14_0(ItemDefinition <p0>) { }

	[CompilerGenerated]
	// RVA: 0x61CBA0 Offset: 0x61B5A0 VA: 0x18061CBA0
	private void <.ctor>b__14_1(ItemDefinition <p0>) { }

	[CompilerGenerated]
	// RVA: 0x61CBA0 Offset: 0x61B5A0 VA: 0x18061CBA0
	private void <.ctor>b__14_2(ItemDefinition <p0>) { }

	[CompilerGenerated]
	// RVA: 0x61CBA0 Offset: 0x61B5A0 VA: 0x18061CBA0
	private void <.ctor>b__14_3(ItemDefinition <p0>) { }

	[CompilerGenerated]
	// RVA: 0x61CBA0 Offset: 0x61B5A0 VA: 0x18061CBA0
	private void <.ctor>b__14_4(NPC <p0>) { }

	[CompilerGenerated]
	// RVA: 0x61CBA0 Offset: 0x61B5A0 VA: 0x18061CBA0
	private void <.ctor>b__14_5(BuildableItem <p0>) { }
}
