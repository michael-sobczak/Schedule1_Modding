public class CallInterface : Singleton<CallInterface> // TypeDefIndex: 2799
{
	// Fields
	public const float TIME_PER_CHAR = 0.015;
	[CompilerGenerated]
	private PhoneCallData <ActiveCallData>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x30
	[Header("References")]
	public Canvas Canvas; // 0x38
	public RectTransform Container; // 0x40
	public Image ProfilePicture; // 0x48
	public TextMeshProUGUI NameLabel; // 0x50
	public TextMeshProUGUI MainText; // 0x58
	public RectTransform ContinuePrompt; // 0x60
	public Animation OpenAnim; // 0x68
	public AudioSourceController TypewriterEffectSound; // 0x70
	public CanvasGroup CanvasGroup; // 0x78
	[Header("Settings")]
	public Color Highlight1Color; // 0x80
	private int currentCallStage; // 0x90
	private Coroutine slideRoutine; // 0x98
	private bool skipRollout; // 0xA0
	private Coroutine rolloutRoutine; // 0xA8
	private string highlight1Hex; // 0xB0
	public Action<PhoneCallData> CallCompleted; // 0xB8
	public Action<PhoneCallData> CallStarted; // 0xC0

	// Properties
	public PhoneCallData ActiveCallData { get; set; }
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public PhoneCallData get_ActiveCallData() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_ActiveCallData(PhoneCallData value) { }

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	protected void set_IsOpen(bool value) { }

	// RVA: 0x9250E0 Offset: 0x923AE0 VA: 0x1809250E0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x926530 Offset: 0x924F30 VA: 0x180926530
	private void Update() { }

	// RVA: 0x9258C0 Offset: 0x9242C0 VA: 0x1809258C0
	private void Exit(ExitAction exit) { }

	// RVA: 0x925D00 Offset: 0x924700 VA: 0x180925D00
	public void StartCall(PhoneCallData data, CallerID caller, int startStage = 0) { }

	// RVA: 0x9257D0 Offset: 0x9241D0 VA: 0x1809257D0
	public void EndCall() { }

	// RVA: 0x925230 Offset: 0x923C30 VA: 0x180925230
	private void Close() { }

	// RVA: 0x925650 Offset: 0x924050 VA: 0x180925650
	public void Continue() { }

	// RVA: 0x925BB0 Offset: 0x9245B0 VA: 0x180925BB0
	private void ShowStage(int stageIndex, float initialDelay = 0) { }

	// RVA: 0x925970 Offset: 0x924370 VA: 0x180925970
	private string ProcessText(string text) { }

	// RVA: 0x925910 Offset: 0x924310 VA: 0x180925910
	private string GetVisibleText(int charactersShown, string fullText) { }

	// RVA: 0x925AD0 Offset: 0x9244D0 VA: 0x180925AD0
	private void SetIsVisible(bool visible) { }

	// RVA: 0x926760 Offset: 0x925160 VA: 0x180926760
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x926270 Offset: 0x924C70 VA: 0x180926270
	private string <ProcessText>b__34_0(Match match) { }
}
