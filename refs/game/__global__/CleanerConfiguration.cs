public class CleanerConfiguration : EntityConfiguration // TypeDefIndex: 1199
{
	// Fields
	public ObjectField Home; // 0x40
	public ObjectListField Bins; // 0x48
	[CompilerGenerated]
	private Cleaner <cleaner>k__BackingField; // 0x50
	[CompilerGenerated]
	private List<TrashContainerItem> <binItems>k__BackingField; // 0x58
	[CompilerGenerated]
	private EmployeeHome <assignedHome>k__BackingField; // 0x60

	// Properties
	public Cleaner cleaner { get; set; }
	public List<TrashContainerItem> binItems { get; set; }
	public EmployeeHome assignedHome { get; set; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 4
	public override bool AllowRename() { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Cleaner get_cleaner() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	protected void set_cleaner(Cleaner value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public List<TrashContainerItem> get_binItems() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_binItems(List<TrashContainerItem> value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public EmployeeHome get_assignedHome() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	private void set_assignedHome(EmployeeHome value) { }

	// RVA: 0x5F9410 Offset: 0x5F7E10 VA: 0x1805F9410
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, Cleaner _cleaner) { }

	// RVA: 0x5F9320 Offset: 0x5F7D20 VA: 0x1805F9320 Slot: 6
	public override void Reset() { }

	// RVA: 0x5F91E0 Offset: 0x5F7BE0 VA: 0x1805F91E0
	private bool IsObjValid(BuildableItem obj, out string reason) { }

	// RVA: 0x5F8DB0 Offset: 0x5F77B0 VA: 0x1805F8DB0
	public void AssignedBinsChanged(List<BuildableItem> objects) { }

	// RVA: 0x5F9350 Offset: 0x5F7D50 VA: 0x1805F9350 Slot: 9
	public override bool ShouldSave() { }

	// RVA: 0x5F8FF0 Offset: 0x5F79F0 VA: 0x1805F8FF0 Slot: 10
	public override string GetSaveString() { }

	// RVA: 0x5F90A0 Offset: 0x5F7AA0 VA: 0x1805F90A0
	private void HomeChanged(BuildableItem newItem) { }

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__15_0(List<BuildableItem> <p0>) { }
}
