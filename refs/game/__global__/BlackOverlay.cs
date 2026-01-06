public class BlackOverlay : Singleton<BlackOverlay> // TypeDefIndex: 2557
{
	// Fields
	[CompilerGenerated]
	private bool <isShown>k__BackingField; // 0x28
	[Header("References")]
	public Canvas canvas; // 0x30
	public CanvasGroup group; // 0x38
	private Coroutine fadeRoutine; // 0x40

	// Properties
	public bool isShown { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isShown() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isShown(bool value) { }

	// RVA: 0x8AA310 Offset: 0x8A8D10 VA: 0x1808AA310 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8AA480 Offset: 0x8A8E80 VA: 0x1808AA480
	public void Open(float fadeTime = 0.5) { }

	// RVA: 0x8AA380 Offset: 0x8A8D80 VA: 0x1808AA380
	public void Close(float fadeTime = 0.5) { }

	[IteratorStateMachine(typeof(BlackOverlay.<Fade>d__10))]
	// RVA: 0x8AA3F0 Offset: 0x8A8DF0 VA: 0x1808AA3F0
	private IEnumerator Fade(float endOpacity, float fadeTime) { }

	// RVA: 0x8AA510 Offset: 0x8A8F10 VA: 0x1808AA510
	public void .ctor() { }
}
