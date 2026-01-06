public class DryingRackConfiguration : EntityConfiguration // TypeDefIndex: 1200
{
	// Fields
	[CompilerGenerated]
	private DryingRack <Rack>k__BackingField; // 0x40
	public NPCField AssignedBotanist; // 0x48
	public QualityField TargetQuality; // 0x50
	public ObjectField Destination; // 0x58
	[CompilerGenerated]
	private TransitRoute <DestinationRoute>k__BackingField; // 0x60

	// Properties
	public DryingRack Rack { get; set; }
	public TransitRoute DestinationRoute { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public DryingRack get_Rack() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_Rack(DryingRack value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public TransitRoute get_DestinationRoute() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	protected void set_DestinationRoute(TransitRoute value) { }

	// RVA: 0x5FF110 Offset: 0x5FDB10 VA: 0x1805FF110
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, DryingRack rack) { }

	// RVA: 0x5F88E0 Offset: 0x5F72E0 VA: 0x1805F88E0 Slot: 6
	public override void Reset() { }

	// RVA: 0x5FED40 Offset: 0x5FD740 VA: 0x1805FED40
	private void DestinationChanged(BuildableItem item) { }

	// RVA: 0x5FEE80 Offset: 0x5FD880 VA: 0x1805FEE80
	public bool DestinationFilter(BuildableItem obj, out string reason) { }

	// RVA: 0x5F8920 Offset: 0x5F7320 VA: 0x1805F8920 Slot: 7
	public override void Selected() { }

	// RVA: 0x5F8590 Offset: 0x5F6F90 VA: 0x1805F8590 Slot: 8
	public override void Deselected() { }

	// RVA: 0x5FF070 Offset: 0x5FDA70 VA: 0x1805FF070 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x5FEF90 Offset: 0x5FD990 VA: 0x1805FEF90 Slot: 10
	public override string GetSaveString() { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__11_0(NPC <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__11_1(EQuality <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__11_2(BuildableItem <p0>) { }
}
