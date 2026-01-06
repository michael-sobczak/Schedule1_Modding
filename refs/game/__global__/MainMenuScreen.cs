public class MainMenuScreen : MonoBehaviour // TypeDefIndex: 2942
{
	// Fields
	public const float LERP_TIME = 0.075;
	public const float LERP_SCALE = 1.25;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("Settings")]
	public int ExitInputPriority; // 0x24
	public bool OpenOnStart; // 0x28
	[Header("References")]
	public MainMenuScreen PreviousScreen; // 0x30
	public CanvasGroup Group; // 0x38
	private RectTransform Rect; // 0x40
	private Coroutine lerpRoutine; // 0x48

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	// RVA: 0x962BE0 Offset: 0x9615E0 VA: 0x180962BE0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x963130 Offset: 0x961B30 VA: 0x180963130
	private void OnDestroy() { }

	// RVA: 0x962EA0 Offset: 0x9618A0 VA: 0x180962EA0 Slot: 5
	protected virtual void Exit(ExitAction action) { }

	// RVA: 0x963240 Offset: 0x961C40 VA: 0x180963240 Slot: 6
	public virtual void Open(bool closePrevious) { }

	// RVA: 0x962E00 Offset: 0x961800 VA: 0x180962E00 Slot: 7
	public virtual void Close(bool openPrevious) { }

	// RVA: 0x962F50 Offset: 0x961950 VA: 0x180962F50
	private void Lerp(bool open) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
