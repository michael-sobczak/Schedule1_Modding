public class HUD : Singleton<HUD> // TypeDefIndex: 2622
{
	// Fields
	[Header("References")]
	public Canvas canvas; // 0x28
	public RectTransform canvasRect; // 0x30
	public Image crosshair; // 0x38
	[SerializeField]
	protected Image blackOverlay; // 0x40
	[SerializeField]
	protected Image radialIndicator; // 0x48
	[SerializeField]
	protected GraphicRaycaster raycaster; // 0x50
	[SerializeField]
	protected TextMeshProUGUI topScreenText; // 0x58
	[SerializeField]
	protected RectTransform topScreenText_Background; // 0x60
	public Text fpsLabel; // 0x68
	public RectTransform cashSlotContainer; // 0x70
	public RectTransform cashSlotUI; // 0x78
	public RectTransform onlineBalanceContainer; // 0x80
	public RectTransform onlineBalanceSlotUI; // 0x88
	public RectTransform managementSlotContainer; // 0x90
	public ItemSlotUI managementSlotUI; // 0x98
	public RectTransform HotbarContainer; // 0xA0
	public RectTransform SlotContainer; // 0xA8
	public ItemSlotUI discardSlot; // 0xB0
	public Image discardSlotFill; // 0xB8
	public TextMeshProUGUI selectedItemLabel; // 0xC0
	public RectTransform QuestEntryContainer; // 0xC8
	public TextMeshProUGUI QuestEntryTitle; // 0xD0
	public CrimeStatusUI CrimeStatusUI; // 0xD8
	public BalanceDisplay OnlineBalanceDisplay; // 0xE0
	public BalanceDisplay SafeBalanceDisplay; // 0xE8
	public CrosshairText CrosshairText; // 0xF0
	public RectTransform UnreadMessagesPrompt; // 0xF8
	public TextMeshProUGUI SleepPrompt; // 0x100
	public TextMeshProUGUI CurfewPrompt; // 0x108
	[Header("Settings")]
	public Gradient RedGreenGradient; // 0x110
	private int SampleSize; // 0x118
	private List<float> _previousFPS; // 0x120
	private EventSystem eventSystem; // 0x128
	private Coroutine blackOverlayFade; // 0x130
	private bool radialIndicatorSetThisFrame; // 0x138

	// Methods

	// RVA: 0x8E79B0 Offset: 0x8E63B0 VA: 0x1808E79B0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8E8000 Offset: 0x8E6A00 VA: 0x1808E8000 Slot: 4
	protected override void Start() { }

	// RVA: 0x8660F0 Offset: 0x864AF0 VA: 0x1808660F0
	public void SetCrosshairVisible(bool vis) { }

	// RVA: 0x8E7E20 Offset: 0x8E6820 VA: 0x1808E7E20
	public void SetBlackOverlayVisible(bool vis, float fadeTime) { }

	// RVA: 0x8E8190 Offset: 0x8E6B90 VA: 0x1808E8190
	private void Update() { }

	// RVA: 0x8E80D0 Offset: 0x8E6AD0 VA: 0x1808E80D0
	private void UpdateQuestEntryTitle() { }

	// RVA: 0x8E7C30 Offset: 0x8E6630 VA: 0x1808E7C30
	private void RefreshFPS() { }

	// RVA: 0x8E7B10 Offset: 0x8E6510 VA: 0x1808E7B10
	private float GetAverageFPS() { }

	// RVA: 0x8E7BF0 Offset: 0x8E65F0 VA: 0x1808E7BF0 Slot: 7
	protected virtual void LateUpdate() { }

	[IteratorStateMachine(typeof(HUD.<FadeBlackOverlay>d__43))]
	// RVA: 0x8E7A80 Offset: 0x8E6480 VA: 0x1808E7A80
	protected IEnumerator FadeBlackOverlay(bool visible, float fadeTime) { }

	// RVA: 0x8E7EF0 Offset: 0x8E68F0 VA: 0x1808E7EF0
	public void ShowRadialIndicator(float fill) { }

	// RVA: 0x8E7F30 Offset: 0x8E6930 VA: 0x1808E7F30
	public void ShowTopScreenText(string t) { }

	// RVA: 0x8E7BC0 Offset: 0x8E65C0 VA: 0x1808E7BC0
	public void HideTopScreenText() { }

	// RVA: 0x8E8530 Offset: 0x8E6F30 VA: 0x1808E8530
	public void .ctor() { }
}
