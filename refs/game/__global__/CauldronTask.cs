public class CauldronTask : Task // TypeDefIndex: 787
{
	// Fields
	[CompilerGenerated]
	private Cauldron <Cauldron>k__BackingField; // 0xA0
	[CompilerGenerated]
	private CauldronTask.EStep <CurrentStep>k__BackingField; // 0xA8
	private StationItem[] CocaLeaves; // 0xB0
	private StationItem Gasoline; // 0xB8
	private Draggable Tub; // 0xC0

	// Properties
	public Cauldron Cauldron { get; set; }
	public CauldronTask.EStep CurrentStep { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public Cauldron get_Cauldron() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	private void set_Cauldron(Cauldron value) { }

	[CompilerGenerated]
	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	public CauldronTask.EStep get_CurrentStep() { }

	[CompilerGenerated]
	// RVA: 0x587060 Offset: 0x585A60 VA: 0x180587060
	private void set_CurrentStep(CauldronTask.EStep value) { }

	// RVA: 0x585B90 Offset: 0x584590 VA: 0x180585B90
	public static string GetStepDescription(CauldronTask.EStep step) { }

	// RVA: 0x586650 Offset: 0x585050 VA: 0x180586650
	public void .ctor(Cauldron caudron) { }

	// RVA: 0x5862A0 Offset: 0x584CA0 VA: 0x1805862A0 Slot: 7
	public override void Success() { }

	// RVA: 0x585F80 Offset: 0x584980 VA: 0x180585F80 Slot: 6
	public override void StopTask() { }

	// RVA: 0x586470 Offset: 0x584E70 VA: 0x180586470 Slot: 9
	public override void Update() { }

	// RVA: 0x5858E0 Offset: 0x5842E0 VA: 0x1805858E0
	private void CheckProgress() { }

	// RVA: 0x585A40 Offset: 0x584440 VA: 0x180585A40
	private void CheckStep_CombineIngredients() { }

	// RVA: 0x585C20 Offset: 0x584620 VA: 0x180585C20
	private void StartMixing() { }

	// RVA: 0x5863F0 Offset: 0x584DF0 VA: 0x1805863F0
	private void UpdateInstruction() { }

	// RVA: 0x585C00 Offset: 0x584600 VA: 0x180585C00
	private void StartButtonPressed() { }
}
