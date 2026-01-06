public class TVApp : MonoBehaviour // TypeDefIndex: 633
{
	// Fields
	public const float SCALE_MIN = 0.67;
	public const float SCALE_MAX = 1.5;
	public const float LERP_TIME = 0.12;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("Settings")]
	public bool CanClose; // 0x21
	public string AppName; // 0x28
	public Sprite Icon; // 0x30
	public bool Pauseable; // 0x38
	[Header("References")]
	public Canvas Canvas; // 0x40
	[HideInInspector]
	public TVApp PreviousScreen; // 0x48
	public CanvasGroup CanvasGroup; // 0x50
	public TVPauseScreen PauseScreen; // 0x58
	private Coroutine lerpCoroutine; // 0x60

	// Properties
	public bool IsOpen { get; set; }
	public bool IsPaused { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	// RVA: 0xAA7C30 Offset: 0xAA6630 VA: 0x180AA7C30
	public bool get_IsPaused() { }

	// RVA: 0xAA72D0 Offset: 0xAA5CD0 VA: 0x180AA72D0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0xAA77E0 Offset: 0xAA61E0 VA: 0x180AA77E0
	private void OnDestroy() { }

	// RVA: 0xAA7990 Offset: 0xAA6390 VA: 0x180AA7990 Slot: 5
	public virtual void Open() { }

	// RVA: 0xAA7380 Offset: 0xAA5D80 VA: 0x180AA7380 Slot: 6
	public virtual void Close() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public virtual void Resume() { }

	// RVA: 0xAA7660 Offset: 0xAA6060 VA: 0x180AA7660
	private void Lerp(float endScale, float endAlpha) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	protected virtual void ActiveMinPass() { }

	// RVA: 0xAA7550 Offset: 0xAA5F50 VA: 0x180AA7550
	private void Exit(ExitAction action) { }

	// RVA: 0xAA7B70 Offset: 0xAA6570 VA: 0x180AA7B70 Slot: 9
	protected virtual void TryPause() { }

	// RVA: 0xAA7C20 Offset: 0xAA6620 VA: 0x180AA7C20
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(TVApp.<<Lerp>g__Lerp|23_0>d))]
	// RVA: 0xAA7B90 Offset: 0xAA6590 VA: 0x180AA7B90
	private IEnumerator <Lerp>g__Lerp|23_0(float endScale, float endAlpha) { }
}
