public class PackagerConfiguration : EntityConfiguration // TypeDefIndex: 1206
{
	// Fields
	public ObjectField Home; // 0x40
	public ObjectListField Stations; // 0x48
	public RouteListField Routes; // 0x50
	public List<PackagingStation> AssignedStations; // 0x58
	public List<BrickPress> AssignedBrickPresses; // 0x60
	[CompilerGenerated]
	private Packager <packager>k__BackingField; // 0x68
	[CompilerGenerated]
	private EmployeeHome <assignedHome>k__BackingField; // 0x70

	// Properties
	public int AssignedStationCount { get; }
	public Packager packager { get; set; }
	public EmployeeHome assignedHome { get; set; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 4
	public override bool AllowRename() { }

	// RVA: 0x6083E0 Offset: 0x606DE0 VA: 0x1806083E0
	public int get_AssignedStationCount() { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Packager get_packager() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	protected void set_packager(Packager value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public EmployeeHome get_assignedHome() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	private void set_assignedHome(EmployeeHome value) { }

	// RVA: 0x607D70 Offset: 0x606770 VA: 0x180607D70
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, Packager _packager) { }

	// RVA: 0x607940 Offset: 0x606340 VA: 0x180607940 Slot: 6
	public override void Reset() { }

	// RVA: 0x607670 Offset: 0x606070 VA: 0x180607670
	private bool IsStationValid(BuildableItem obj, out string reason) { }

	// RVA: 0x606B80 Offset: 0x605580 VA: 0x180606B80
	public void AssignedStationsChanged(List<BuildableItem> objects) { }

	// RVA: 0x607CB0 Offset: 0x6066B0 VA: 0x180607CB0 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x607450 Offset: 0x605E50 VA: 0x180607450 Slot: 10
	public override string GetSaveString() { }

	// RVA: 0x607530 Offset: 0x605F30 VA: 0x180607530
	private void HomeChanged(BuildableItem newItem) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__16_0(List<BuildableItem> <p0>) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__16_1(List<AdvancedTransitRoute> <p0>) { }
}
