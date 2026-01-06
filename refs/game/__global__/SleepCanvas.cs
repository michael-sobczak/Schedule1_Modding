public class SleepCanvas : Singleton<SleepCanvas> // TypeDefIndex: 2683
{
	// Fields
	public const int MaxSleepTime = 12;
	public const int MinSleepTime = 4;
	[CompilerGenerated]
	private bool <IsMenuOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <QueuedSleepMessage>k__BackingField; // 0x30
	private float QueuedMessageDisplayTime; // 0x38
	[Header("References")]
	public Canvas Canvas; // 0x40
	public RectTransform Container; // 0x48
	public RectTransform MenuContainer; // 0x50
	public TextMeshProUGUI CurrentTimeLabel; // 0x58
	public Button IncreaseButton; // 0x60
	public Button DecreaseButton; // 0x68
	public TextMeshProUGUI EndTimeLabel; // 0x70
	public Button SleepButton; // 0x78
	public TextMeshProUGUI SleepButtonLabel; // 0x80
	public Image BlackOverlay; // 0x88
	public TextMeshProUGUI SleepMessageLabel; // 0x90
	public CanvasGroup SleepMessageGroup; // 0x98
	public TextMeshProUGUI TimeLabel; // 0xA0
	public TextMeshProUGUI WakeLabel; // 0xA8
	public TextMeshProUGUI WaitingForHostLabel; // 0xB0
	public UnityEvent onSleepFullyFaded; // 0xB8
	public UnityEvent onSleepEndFade; // 0xC0
	private List<IPostSleepEvent> queuedPostSleepEvents; // 0xC8

	// Properties
	public bool IsMenuOpen { get; set; }
	public string QueuedSleepMessage { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsMenuOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsMenuOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_QueuedSleepMessage() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_QueuedSleepMessage(string value) { }

	// RVA: 0x901E50 Offset: 0x900850 VA: 0x180901E50 Slot: 5
	protected override void Awake() { }

	// RVA: 0x902470 Offset: 0x900E70 VA: 0x180902470
	private void Exit(ExitAction action) { }

	// RVA: 0x902760 Offset: 0x901160 VA: 0x180902760
	public void SetIsOpen(bool open) { }

	// RVA: 0x903250 Offset: 0x901C50 VA: 0x180903250
	public void Update() { }

	// RVA: 0x901D10 Offset: 0x900710 VA: 0x180901D10
	public void AddPostSleepEvent(IPostSleepEvent postSleepEvent) { }

	// RVA: 0x9030F0 Offset: 0x901AF0 VA: 0x1809030F0
	private void UpdateHourSetting() { }

	// RVA: 0x903200 Offset: 0x901C00 VA: 0x180903200
	private void UpdateTimeLabels() { }

	// RVA: 0x903130 Offset: 0x901B30 VA: 0x180903130
	private void UpdateSleepButton() { }

	// RVA: 0x902180 Offset: 0x900B80 VA: 0x180902180
	private void ChangeSleepAmount(int change) { }

	// RVA: 0x902330 Offset: 0x900D30 VA: 0x180902330
	private int ClampWakeTime(int time) { }

	// RVA: 0x902290 Offset: 0x900C90 VA: 0x180902290
	private int ClampTime(int time, int startTime, int endTime) { }

	// RVA: 0x902DD0 Offset: 0x9017D0 VA: 0x180902DD0
	private void SleepButtonPressed() { }

	// RVA: 0x902E50 Offset: 0x901850 VA: 0x180902E50
	private void SleepStart() { }

	// RVA: 0x9024C0 Offset: 0x900EC0 VA: 0x1809024C0
	private void LerpBlackOverlay(float transparency, float lerpTime) { }

	// RVA: 0x9025E0 Offset: 0x900FE0 VA: 0x1809025E0
	public void QueueSleepMessage(string message, float displayTime = 3) { }

	// RVA: 0x903450 Offset: 0x901E50 VA: 0x180903450
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x903060 Offset: 0x901A60 VA: 0x180903060
	private void <Awake>b__29_0() { }

	[CompilerGenerated]
	// RVA: 0x903070 Offset: 0x901A70 VA: 0x180903070
	private void <Awake>b__29_1() { }

	[IteratorStateMachine(typeof(SleepCanvas.<<SleepStart>g__Sleep|41_0>d))]
	[CompilerGenerated]
	// RVA: 0x903080 Offset: 0x901A80 VA: 0x180903080
	private IEnumerator <SleepStart>g__Sleep|41_0() { }
}
