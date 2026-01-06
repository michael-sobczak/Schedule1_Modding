public class UseChemistryStationTask : Task // TypeDefIndex: 809
{
	// Fields
	public const float STIR_TIME = 1.5;
	public const float TEMPERATURE_TIME = 2;
	[CompilerGenerated]
	private ChemistryStation.EStep <CurrentStep>k__BackingField; // 0xA0
	[CompilerGenerated]
	private ChemistryStation <Station>k__BackingField; // 0xA8
	[CompilerGenerated]
	private StationRecipe <Recipe>k__BackingField; // 0xB0
	private Beaker beaker; // 0xB8
	private StirringRod stirringRod; // 0xC0
	private List<StationItem> items; // 0xC8
	private List<IngredientPiece> ingredientPieces; // 0xD0
	private float stirProgress; // 0xD8
	private float timeInTemperatureRange; // 0xDC
	private ItemInstance[] RemovedIngredients; // 0xE0

	// Properties
	public ChemistryStation.EStep CurrentStep { get; set; }
	public ChemistryStation Station { get; set; }
	public StationRecipe Recipe { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5B3AE0 Offset: 0x5B24E0 VA: 0x1805B3AE0
	public ChemistryStation.EStep get_CurrentStep() { }

	[CompilerGenerated]
	// RVA: 0x5B3AF0 Offset: 0x5B24F0 VA: 0x1805B3AF0
	private void set_CurrentStep(ChemistryStation.EStep value) { }

	[CompilerGenerated]
	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public ChemistryStation get_Station() { }

	[CompilerGenerated]
	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	private void set_Station(ChemistryStation value) { }

	[CompilerGenerated]
	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public StationRecipe get_Recipe() { }

	[CompilerGenerated]
	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	private void set_Recipe(StationRecipe value) { }

	// RVA: 0x5B1ED0 Offset: 0x5B08D0 VA: 0x1805B1ED0
	public static string GetStepDescription(ChemistryStation.EStep step) { }

	// RVA: 0x5B2F10 Offset: 0x5B1910 VA: 0x1805B2F10
	public void .ctor(ChemistryStation station, StationRecipe recipe) { }

	// RVA: 0x5B2EE0 Offset: 0x5B18E0 VA: 0x1805B2EE0 Slot: 9
	public override void Update() { }

	// RVA: 0x5B2CA0 Offset: 0x5B16A0 VA: 0x1805B2CA0
	private void UpdateInstruction() { }

	// RVA: 0x5B1430 Offset: 0x5AFE30 VA: 0x1805B1430
	private void CheckProgress() { }

	// RVA: 0x5B2010 Offset: 0x5B0A10 VA: 0x1805B2010
	private void ProgressStep() { }

	// RVA: 0x5B15D0 Offset: 0x5AFFD0 VA: 0x1805B15D0
	private void CheckStep_CombineIngredients() { }

	// RVA: 0x5B1CE0 Offset: 0x5B06E0 VA: 0x1805B1CE0
	private void CheckStep_StirMixture() { }

	// RVA: 0x5B1840 Offset: 0x5B0240 VA: 0x1805B1840
	private void CheckStep_LowerBoilingFlask() { }

	// RVA: 0x5B18D0 Offset: 0x5B02D0 VA: 0x1805B18D0
	private void CheckStep_PourIntoBoilingFlask() { }

	// RVA: 0x5B1960 Offset: 0x5B0360 VA: 0x1805B1960
	private void CheckStep_RaiseBoilingFlask() { }

	// RVA: 0x5B19F0 Offset: 0x5B03F0 VA: 0x1805B19F0
	private void CheckStep_StartHeat() { }

	// RVA: 0x5B2A10 Offset: 0x5B1410 VA: 0x1805B2A10 Slot: 7
	public override void Success() { }

	// RVA: 0x5B24E0 Offset: 0x5B0EE0 VA: 0x1805B24E0 Slot: 6
	public override void StopTask() { }
}
