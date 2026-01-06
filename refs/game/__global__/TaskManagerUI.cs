public class TaskManagerUI : Singleton<TaskManagerUI> // TypeDefIndex: 2706
{
	// Fields
	private bool textShown; // 0x28
	public GenericUIScreen inputPromptUI; // 0x30
	public Canvas canvas; // 0x38
	public RectTransform multiGrabIndicator; // 0x40
	public GenericUIScreen PackagingStationMK2TutorialDone; // 0x48

	// Methods

	// RVA: 0x91A150 Offset: 0x918B50 VA: 0x18091A150 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x919C60 Offset: 0x918660 VA: 0x180919C60 Slot: 4
	protected override void Start() { }

	// RVA: 0x919F90 Offset: 0x918990 VA: 0x180919F90 Slot: 8
	protected virtual void UpdateInstructionLabel() { }

	// RVA: 0x919DF0 Offset: 0x9187F0 VA: 0x180919DF0
	private void TaskStarted(Task task) { }

	// RVA: 0x91A200 Offset: 0x918C00 VA: 0x18091A200
	public void .ctor() { }
}
