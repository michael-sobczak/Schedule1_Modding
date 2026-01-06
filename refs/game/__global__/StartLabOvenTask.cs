public class StartLabOvenTask : Task // TypeDefIndex: 804
{
	// Fields
	[CompilerGenerated]
	private LabOven <Oven>k__BackingField; // 0xA0
	[CompilerGenerated]
	private StartLabOvenTask.EStep <CurrentStep>k__BackingField; // 0xA8
	private ItemInstance ingredient; // 0xB0
	private Coroutine pourRoutine; // 0xB8
	private StationItem stationItem; // 0xC0
	private PourableModule pourableModule; // 0xC8
	private bool pourAnimDone; // 0xD0

	// Properties
	public LabOven Oven { get; set; }
	public StartLabOvenTask.EStep CurrentStep { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public LabOven get_Oven() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	private void set_Oven(LabOven value) { }

	[CompilerGenerated]
	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	public StartLabOvenTask.EStep get_CurrentStep() { }

	[CompilerGenerated]
	// RVA: 0x587060 Offset: 0x585A60 VA: 0x180587060
	protected void set_CurrentStep(StartLabOvenTask.EStep value) { }

	// RVA: 0x5AF730 Offset: 0x5AE130 VA: 0x1805AF730
	public void .ctor(LabOven oven) { }

	// RVA: 0x5AF4D0 Offset: 0x5ADED0 VA: 0x1805AF4D0 Slot: 9
	public override void Update() { }

	// RVA: 0x5AF2B0 Offset: 0x5ADCB0 VA: 0x1805AF2B0 Slot: 7
	public override void Success() { }

	// RVA: 0x5AEEF0 Offset: 0x5AD8F0 VA: 0x1805AEEF0 Slot: 6
	public override void StopTask() { }

	// RVA: 0x5AE910 Offset: 0x5AD310 VA: 0x1805AE910
	private void CheckProgress() { }

	// RVA: 0x5AED70 Offset: 0x5AD770 VA: 0x1805AED70
	private void ProgressStep() { }

	// RVA: 0x5AEB40 Offset: 0x5AD540 VA: 0x1805AEB40
	private void CheckStep_OpenDoor() { }

	// RVA: 0x5AEBE0 Offset: 0x5AD5E0 VA: 0x1805AEBE0
	private void CheckStep_Pour() { }

	// RVA: 0x5AEAB0 Offset: 0x5AD4B0 VA: 0x1805AEAB0
	private void CheckStep_CloseDoor() { }

	// RVA: 0x5AEC00 Offset: 0x5AD600 VA: 0x1805AEC00
	private void CheckStep_PressButton() { }

	[IteratorStateMachine(typeof(StartLabOvenTask.<PlayPourAnimation>d__24))]
	// RVA: 0x5AED00 Offset: 0x5AD700 VA: 0x1805AED00
	private IEnumerator PlayPourAnimation() { }

	// RVA: 0x5AEC40 Offset: 0x5AD640 VA: 0x1805AEC40
	public static string GetStepInstruction(StartLabOvenTask.EStep step) { }
}
