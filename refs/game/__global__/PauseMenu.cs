public class PauseMenu : Singleton<PauseMenu> // TypeDefIndex: 2649
{
	// Fields
	[CompilerGenerated]
	private bool <IsPaused>k__BackingField; // 0x28
	public Canvas Canvas; // 0x30
	public RectTransform Container; // 0x38
	public MainMenuScreen Screen; // 0x40
	public FeedbackForm FeedbackForm; // 0x48
	private bool noActiveUIElements; // 0x50
	private bool justPaused; // 0x51
	private bool justResumed; // 0x52
	private bool couldLook; // 0x53
	private bool lockedMouse; // 0x54
	private bool crosshairVisible; // 0x55
	private bool hudVisible; // 0x56
	public Action onPause; // 0x58
	public Action onResume; // 0x60

	// Properties
	public bool IsPaused { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsPaused() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsPaused(bool value) { }

	// RVA: 0x8FA620 Offset: 0x8F9020 VA: 0x1808FA620 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8FB050 Offset: 0x8F9A50 VA: 0x1808FB050 Slot: 4
	protected override void Start() { }

	// RVA: 0x8FA6D0 Offset: 0x8F90D0 VA: 0x1808FA6D0
	private void Exit(ExitAction action) { }

	// RVA: 0x8FB160 Offset: 0x8F9B60 VA: 0x1808FB160
	private void Update() { }

	// RVA: 0x8FA770 Offset: 0x8F9170 VA: 0x1808FA770
	private void LateUpdate() { }

	// RVA: 0x8FA820 Offset: 0x8F9220 VA: 0x1808FA820
	public void Pause() { }

	// RVA: 0x8FACA0 Offset: 0x8F96A0 VA: 0x1808FACA0
	public void Resume() { }

	// RVA: 0x8FB0D0 Offset: 0x8F9AD0 VA: 0x1808FB0D0
	public void StuckButtonClicked() { }

	// RVA: 0x8FB190 Offset: 0x8F9B90 VA: 0x1808FB190
	public void .ctor() { }
}
