public class UseMixingStationTask : Task // TypeDefIndex: 817
{
	// Fields
	[CompilerGenerated]
	private MixingStation <Station>k__BackingField; // 0xA0
	[CompilerGenerated]
	private UseMixingStationTask.EStep <CurrentStep>k__BackingField; // 0xA8
	private List<StationItem> items; // 0xB0
	private List<StationItem> mixerItems; // 0xB8
	private List<IngredientPiece> ingredientPieces; // 0xC0
	private ItemInstance[] removedIngredients; // 0xC8
	private Beaker Jug; // 0xD0

	// Properties
	public MixingStation Station { get; set; }
	public UseMixingStationTask.EStep CurrentStep { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public MixingStation get_Station() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	private void set_Station(MixingStation value) { }

	[CompilerGenerated]
	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	public UseMixingStationTask.EStep get_CurrentStep() { }

	[CompilerGenerated]
	// RVA: 0x587060 Offset: 0x585A60 VA: 0x180587060
	private void set_CurrentStep(UseMixingStationTask.EStep value) { }

	// RVA: 0x5B4670 Offset: 0x5B3070 VA: 0x1805B4670
	public static string GetStepDescription(UseMixingStationTask.EStep step) { }

	// RVA: 0x5B5760 Offset: 0x5B4160 VA: 0x1805B5760
	public void .ctor(MixingStation station) { }

	// RVA: 0x5B3CC0 Offset: 0x5B26C0 VA: 0x1805B3CC0
	private Beaker CreateJug() { }

	// RVA: 0x5B5660 Offset: 0x5B4060 VA: 0x1805B5660 Slot: 9
	public override void Update() { }

	// RVA: 0x5B5420 Offset: 0x5B3E20 VA: 0x1805B5420
	private void UpdateInstruction() { }

	// RVA: 0x5B3B00 Offset: 0x5B2500 VA: 0x1805B3B00
	private void CheckProgress() { }

	// RVA: 0x5B3BE0 Offset: 0x5B25E0 VA: 0x1805B3BE0
	private void CheckStep_CombineIngredients() { }

	// RVA: 0x5B4390 Offset: 0x5B2D90 VA: 0x1805B4390
	private int GetCombinedIngredients() { }

	// RVA: 0x5B46E0 Offset: 0x5B30E0 VA: 0x1805B46E0
	private void ProgressStep() { }

	// RVA: 0x585C00 Offset: 0x584600 VA: 0x180585C00
	private void StartButtonPressed() { }

	// RVA: 0x5B4B50 Offset: 0x5B3550 VA: 0x1805B4B50 Slot: 7
	public override void Success() { }

	// RVA: 0x5B3EA0 Offset: 0x5B28A0 VA: 0x1805B3EA0
	private void CreateTrash() { }

	// RVA: 0x5B4720 Offset: 0x5B3120 VA: 0x1805B4720 Slot: 6
	public override void StopTask() { }

	[CompilerGenerated]
	// RVA: 0x5B4D20 Offset: 0x5B3720 VA: 0x1805B4D20
	private void <.ctor>g__SetupIngredient|15_0(StorableItemDefinition def, int index, bool mixer, ref UseMixingStationTask.<>c__DisplayClass15_0 ) { }
}
