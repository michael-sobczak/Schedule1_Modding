public class DealWindowSelector : MonoBehaviour // TypeDefIndex: 2835
{
	// Fields
	public const float TIME_ARM_ROTATION_0000 = 0;
	public const float TIME_ARM_ROTATION_2400 = -360;
	public const int WINDOW_CUTOFF_MINS = 120;
	public UnityEvent<EDealWindow> OnSelected; // 0x20
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	[Header("References")]
	public GameObject Container; // 0x30
	public WindowSelectorButton MorningButton; // 0x38
	public WindowSelectorButton AfternoonButton; // 0x40
	public WindowSelectorButton NightButton; // 0x48
	public WindowSelectorButton LateNightButton; // 0x50
	public RectTransform CurrentTimeArm; // 0x58
	public Text CurrentTimeLabel; // 0x60
	private Action<EDealWindow> callback; // 0x68
	private WindowSelectorButton[] buttons; // 0x70
	private bool hintShown; // 0x78

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_IsOpen(bool value) { }

	// RVA: 0x9448B0 Offset: 0x9432B0 VA: 0x1809448B0
	private void Start() { }

	// RVA: 0x9444E0 Offset: 0x942EE0 VA: 0x1809444E0
	public void Exit(ExitAction action) { }

	// RVA: 0x944530 Offset: 0x942F30 VA: 0x180944530
	public void SetIsOpen(bool open) { }

	// RVA: 0x944550 Offset: 0x942F50 VA: 0x180944550
	public void SetIsOpen(bool open, MSGConversation conversation, Action<EDealWindow> callback) { }

	// RVA: 0x945040 Offset: 0x943A40 VA: 0x180945040
	public void Update() { }

	// RVA: 0x944BE0 Offset: 0x9435E0 VA: 0x180944BE0
	private void UpdateTime() { }

	// RVA: 0x944D80 Offset: 0x943780 VA: 0x180944D80
	private void UpdateWindowValidity() { }

	// RVA: 0x9444C0 Offset: 0x942EC0 VA: 0x1809444C0
	private void Close() { }

	// RVA: 0x944430 Offset: 0x942E30 VA: 0x180944430
	private void ButtonClicked(EDealWindow window) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
