public class ChemistryStationUIElement : WorldspaceUIElement // TypeDefIndex: 2914
{
	// Fields
	[CompilerGenerated]
	private ChemistryStation <AssignedStation>k__BackingField; // 0x50
	[Header("References")]
	public StationRecipeEntry RecipeEntry; // 0x58
	public GameObject NoRecipe; // 0x60

	// Properties
	public ChemistryStation AssignedStation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public ChemistryStation get_AssignedStation() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	protected void set_AssignedStation(ChemistryStation value) { }

	// RVA: 0x9589B0 Offset: 0x9573B0 VA: 0x1809589B0
	public void Initialize(ChemistryStation oven) { }

	// RVA: 0x958A90 Offset: 0x957490 VA: 0x180958A90 Slot: 10
	protected virtual void RefreshUI() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
