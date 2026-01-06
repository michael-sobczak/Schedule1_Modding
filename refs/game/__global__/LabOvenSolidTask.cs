public class LabOvenSolidTask : Task // TypeDefIndex: 798
{
	// Fields
	[CompilerGenerated]
	private LabOven <Oven>k__BackingField; // 0xA0
	[CompilerGenerated]
	private LabOvenSolidTask.EStep <CurrentStep>k__BackingField; // 0xA8
	private ItemInstance ingredient; // 0xB0
	private int ingredientQuantity; // 0xB8
	private StationItem[] stationItems; // 0xC0
	private Draggable[] stationDraggables; // 0xC8

	// Properties
	public LabOven Oven { get; set; }
	public LabOvenSolidTask.EStep CurrentStep { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public LabOven get_Oven() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	private void set_Oven(LabOven value) { }

	[CompilerGenerated]
	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	public LabOvenSolidTask.EStep get_CurrentStep() { }

	[CompilerGenerated]
	// RVA: 0x587060 Offset: 0x585A60 VA: 0x180587060
	protected void set_CurrentStep(LabOvenSolidTask.EStep value) { }

	// RVA: 0x58F080 Offset: 0x58DA80 VA: 0x18058F080
	public void .ctor(LabOven oven) { }

	// RVA: 0x58EFB0 Offset: 0x58D9B0 VA: 0x18058EFB0 Slot: 9
	public override void Update() { }

	// RVA: 0x58ED80 Offset: 0x58D780 VA: 0x18058ED80 Slot: 7
	public override void Success() { }

	// RVA: 0x58E9C0 Offset: 0x58D3C0 VA: 0x18058E9C0 Slot: 6
	public override void StopTask() { }

	// RVA: 0x58E040 Offset: 0x58CA40 VA: 0x18058E040
	private void CheckProgress() { }

	// RVA: 0x58E790 Offset: 0x58D190 VA: 0x18058E790
	private void ProgressStep() { }

	// RVA: 0x58E430 Offset: 0x58CE30 VA: 0x18058E430
	private void CheckStep_OpenDoor() { }

	// RVA: 0x58E4D0 Offset: 0x58CED0 VA: 0x18058E4D0
	private void CheckStep_PlaceItems() { }

	// RVA: 0x58E3A0 Offset: 0x58CDA0 VA: 0x18058E3A0
	private void CheckStep_CloseDoor() { }

	// RVA: 0x58E690 Offset: 0x58D090 VA: 0x18058E690
	private void CheckStep_PressButton() { }

	// RVA: 0x58E6D0 Offset: 0x58D0D0 VA: 0x18058E6D0
	public static string GetStepInstruction(LabOvenSolidTask.EStep step) { }
}
