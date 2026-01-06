public class ChemistConfiguration : EntityConfiguration // TypeDefIndex: 1197
{
	// Fields
	public ObjectField Home; // 0x40
	public ObjectListField Stations; // 0x48
	public List<ChemistryStation> ChemStations; // 0x50
	public List<LabOven> LabOvens; // 0x58
	public List<Cauldron> Cauldrons; // 0x60
	public List<MixingStation> MixStations; // 0x68
	[CompilerGenerated]
	private Chemist <chemist>k__BackingField; // 0x70
	[CompilerGenerated]
	private EmployeeHome <assignedHome>k__BackingField; // 0x78

	// Properties
	public int TotalStations { get; }
	public Chemist chemist { get; set; }
	public EmployeeHome assignedHome { get; set; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 4
	public override bool AllowRename() { }

	// RVA: 0x5F8500 Offset: 0x5F6F00 VA: 0x1805F8500
	public int get_TotalStations() { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public Chemist get_chemist() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	protected void set_chemist(Chemist value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public EmployeeHome get_assignedHome() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	private void set_assignedHome(EmployeeHome value) { }

	// RVA: 0x5F7DD0 Offset: 0x5F67D0 VA: 0x1805F7DD0
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, Chemist _chemist) { }

	// RVA: 0x5F7630 Offset: 0x5F6030 VA: 0x1805F7630 Slot: 6
	public override void Reset() { }

	// RVA: 0x5F71E0 Offset: 0x5F5BE0 VA: 0x1805F71E0
	private bool IsStationValid(BuildableItem obj, out string reason) { }

	// RVA: 0x5F5CD0 Offset: 0x5F46D0 VA: 0x1805F5CD0
	public void AssignedStationsChanged(List<BuildableItem> objects) { }

	// RVA: 0x5F7CE0 Offset: 0x5F66E0 VA: 0x1805F7CE0 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x5F6FF0 Offset: 0x5F59F0 VA: 0x1805F6FF0 Slot: 10
	public override string GetSaveString() { }

	// RVA: 0x5F70A0 Offset: 0x5F5AA0 VA: 0x1805F70A0
	private void HomeChanged(BuildableItem newItem) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__17_0(List<BuildableItem> <p0>) { }
}
