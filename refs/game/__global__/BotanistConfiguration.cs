public class BotanistConfiguration : EntityConfiguration // TypeDefIndex: 1194
{
	// Fields
	public static readonly Type[] AssignableTypes; // 0x0
	public ObjectField Home; // 0x40
	public ObjectField Supplies; // 0x48
	public ObjectListField Assigns; // 0x50
	[CompilerGenerated]
	private List<Pot> <AssignedPots>k__BackingField; // 0x58
	[CompilerGenerated]
	private List<DryingRack> <AssignedRacks>k__BackingField; // 0x60
	[CompilerGenerated]
	private List<MushroomBed> <AssignedBeds>k__BackingField; // 0x68
	[CompilerGenerated]
	private List<MushroomSpawnStation> <AssignedSpawnStations>k__BackingField; // 0x70
	[CompilerGenerated]
	private EmployeeHome <AssignedHome>k__BackingField; // 0x78
	private List<BuildableItem> _thisBotanistAssignedOn; // 0x80
	private Botanist _botanist; // 0x88

	// Properties
	public List<Pot> AssignedPots { get; set; }
	public List<DryingRack> AssignedRacks { get; set; }
	public List<MushroomBed> AssignedBeds { get; set; }
	public List<MushroomSpawnStation> AssignedSpawnStations { get; set; }
	public EmployeeHome AssignedHome { get; set; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 4
	public override bool AllowRename() { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public List<Pot> get_AssignedPots() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_AssignedPots(List<Pot> value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public List<DryingRack> get_AssignedRacks() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	private void set_AssignedRacks(List<DryingRack> value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public List<MushroomBed> get_AssignedBeds() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	private void set_AssignedBeds(List<MushroomBed> value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public List<MushroomSpawnStation> get_AssignedSpawnStations() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	private void set_AssignedSpawnStations(List<MushroomSpawnStation> value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public EmployeeHome get_AssignedHome() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	private void set_AssignedHome(EmployeeHome value) { }

	// RVA: 0x5F4820 Offset: 0x5F3220 VA: 0x1805F4820
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, Botanist _botanist) { }

	// RVA: 0x5F4420 Offset: 0x5F2E20 VA: 0x1805F4420 Slot: 6
	public override void Reset() { }

	// RVA: 0x5F3E80 Offset: 0x5F2880 VA: 0x1805F3E80
	private bool IsStationValid(BuildableItem obj, out string reason) { }

	// RVA: 0x5F3620 Offset: 0x5F2020 VA: 0x1805F3620
	public void AssignsChanged(List<BuildableItem> objects) { }

	// RVA: 0x5F3BD0 Offset: 0x5F25D0 VA: 0x1805F3BD0
	private NPCField GetNPCField(IConfigurable configurable) { }

	// RVA: 0x5F44D0 Offset: 0x5F2ED0 VA: 0x1805F44D0 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x5F3C60 Offset: 0x5F2660 VA: 0x1805F3C60 Slot: 10
	public override string GetSaveString() { }

	// RVA: 0x5F3D40 Offset: 0x5F2740 VA: 0x1805F3D40
	private void HomeChanged(BuildableItem newItem) { }

	// RVA: 0x5F45E0 Offset: 0x5F2FE0 VA: 0x1805F45E0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__27_0(BuildableItem <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__27_1(List<BuildableItem> <p0>) { }
}
