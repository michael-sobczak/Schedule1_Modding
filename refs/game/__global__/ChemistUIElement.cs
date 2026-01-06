public class ChemistUIElement : WorldspaceUIElement // TypeDefIndex: 2915
{
	// Fields
	[Header("References")]
	public Image[] StationsIcons; // 0x50
	[CompilerGenerated]
	private Chemist <AssignedChemist>k__BackingField; // 0x58

	// Properties
	public Chemist AssignedChemist { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Chemist get_AssignedChemist() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	protected void set_AssignedChemist(Chemist value) { }

	// RVA: 0x958690 Offset: 0x957090 VA: 0x180958690
	public void Initialize(Chemist chemist) { }

	// RVA: 0x9587C0 Offset: 0x9571C0 VA: 0x1809587C0 Slot: 10
	protected virtual void RefreshUI() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
