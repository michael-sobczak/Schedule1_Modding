public class HintDisplay : Singleton<HintDisplay> // TypeDefIndex: 2620
{
	// Fields
	public const float FadeTime = 0.3;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	[Header("References")]
	public RectTransform Container; // 0x30
	public TextMeshProUGUI Label; // 0x38
	public CanvasGroup Group; // 0x40
	public InputPrompt DismissPrompt; // 0x48
	public Animation FlashAnim; // 0x50
	[Header("Settings")]
	public Vector2 Padding; // 0x58
	public Vector2 Offset; // 0x60
	private Coroutine autoCloseRoutine; // 0x68
	private Coroutine fadeRoutine; // 0x70
	private List<HintDisplay.Hint> hintQueue; // 0x78
	private float timeSinceOpened; // 0x80

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsOpen(bool value) { }

	// RVA: 0x8E8F50 Offset: 0x8E7950 VA: 0x1808E8F50 Slot: 4
	protected override void Start() { }

	// RVA: 0x8E9050 Offset: 0x8E7A50 VA: 0x1808E9050
	public void Update() { }

	// RVA: 0x8E8C60 Offset: 0x8E7660 VA: 0x1808E8C60
	public void ShowHint_10s(string text) { }

	// RVA: 0x8E8C70 Offset: 0x8E7670 VA: 0x1808E8C70
	public void ShowHint_20s(string text) { }

	// RVA: 0x8E8F40 Offset: 0x8E7940 VA: 0x1808E8F40
	public void ShowHint(string text) { }

	// RVA: 0x8E8C80 Offset: 0x8E7680 VA: 0x1808E8C80
	public void ShowHint(string text, float autoCloseTime = 0) { }

	// RVA: 0x8E85D0 Offset: 0x8E6FD0 VA: 0x1808E85D0
	public void Hide() { }

	// RVA: 0x8E8B20 Offset: 0x8E7520 VA: 0x1808E8B20
	private void SetAlpha(float alpha) { }

	// RVA: 0x8E8820 Offset: 0x8E7220 VA: 0x1808E8820
	public void QueueHint_10s(string message) { }

	// RVA: 0x8E8920 Offset: 0x8E7320 VA: 0x1808E8920
	public void QueueHint_20s(string message) { }

	// RVA: 0x8E8A20 Offset: 0x8E7420 VA: 0x1808E8A20
	public void QueueHint(string message, float time) { }

	// RVA: 0x8E85F0 Offset: 0x8E6FF0 VA: 0x1808E85F0
	private string ProcessText(string text) { }

	// RVA: 0x8E92B0 Offset: 0x8E7CB0 VA: 0x1808E92B0
	public void .ctor() { }

	[IteratorStateMachine(typeof(HintDisplay.<<ShowHint>g__AutoClose|22_0>d))]
	[CompilerGenerated]
	// RVA: 0x8E8FD0 Offset: 0x8E79D0 VA: 0x1808E8FD0
	private IEnumerator <ShowHint>g__AutoClose|22_0(float time) { }
}
