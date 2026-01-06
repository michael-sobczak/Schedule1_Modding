public class PickpocketScreen : Singleton<PickpocketScreen> // TypeDefIndex: 2658
{
	// Fields
	public const int PICKPOCKET_XP = 2;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <TutorialOpen>k__BackingField; // 0x29
	[Header("Settings")]
	public float GreenAreaMaxWidth; // 0x2C
	public float GreenAreaMinWidth; // 0x30
	public float SlideTime; // 0x34
	public float SlideTimeMaxMultiplier; // 0x38
	public float ValueDivisor; // 0x3C
	public float Tolerance; // 0x40
	[Header("References")]
	public Canvas Canvas; // 0x48
	public RectTransform Container; // 0x50
	public ItemSlotUI[] Slots; // 0x58
	public RectTransform[] GreenAreas; // 0x60
	public Animation TutorialAnimation; // 0x68
	public RectTransform TutorialContainer; // 0x70
	public RectTransform SliderContainer; // 0x78
	public Slider Slider; // 0x80
	public InputPrompt InputPrompt; // 0x88
	public RectTransform ActionsContainer; // 0x90
	public UnityEvent onFail; // 0x98
	public UnityEvent onStop; // 0xA0
	public UnityEvent onHitGreen; // 0xA8
	private NPC npc; // 0xB0
	private bool isSliding; // 0xB8
	private int slideDirection; // 0xBC
	private float sliderPosition; // 0xC0
	private float slideTimeMultiplier; // 0xC4
	private bool isFail; // 0xC8

	// Properties
	public bool IsOpen { get; set; }
	public bool TutorialOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_TutorialOpen() { }

	[CompilerGenerated]
	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	private void set_TutorialOpen(bool value) { }

	// RVA: 0x8FE660 Offset: 0x8FD060 VA: 0x1808FE660 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8FFD80 Offset: 0x8FE780 VA: 0x1808FFD80 Slot: 4
	protected override void Start() { }

	// RVA: 0x8FF030 Offset: 0x8FDA30 VA: 0x1808FF030
	public void Open(NPC _npc) { }

	// RVA: 0x8FEC80 Offset: 0x8FD680 VA: 0x1808FEC80
	private void Exit(ExitAction action) { }

	// RVA: 0x9001F0 Offset: 0x8FEBF0 VA: 0x1809001F0
	private void Update() { }

	// RVA: 0x8FFE50 Offset: 0x8FE850 VA: 0x1808FFE50
	private void StopArrow() { }

	// RVA: 0x8FFB60 Offset: 0x8FE560 VA: 0x1808FFB60
	public void SetSlotLocked(int index, bool locked) { }

	// RVA: 0x8FEE40 Offset: 0x8FD840 VA: 0x1808FEE40
	private ItemSlotUI GetHoveredSlot() { }

	// RVA: 0x8FECD0 Offset: 0x8FD6D0 VA: 0x1808FECD0
	private void Fail() { }

	// RVA: 0x8FE790 Offset: 0x8FD190 VA: 0x1808FE790
	public void Close() { }

	// RVA: 0x8FEFE0 Offset: 0x8FD9E0 VA: 0x1808FEFE0
	private void OpenTutorial() { }

	// RVA: 0x8FE750 Offset: 0x8FD150 VA: 0x1808FE750
	public void CloseTutorial() { }

	// RVA: 0x8FED60 Offset: 0x8FD760 VA: 0x1808FED60
	private float GetGreenAreaNormalizedPosition(int index) { }

	// RVA: 0x8FEDD0 Offset: 0x8FD7D0 VA: 0x1808FEDD0
	private float GetGreenAreaNormalizedWidth(int index) { }

	// RVA: 0x900480 Offset: 0x8FEE80 VA: 0x180900480
	public void .ctor() { }

	[IteratorStateMachine(typeof(PickpocketScreen.<<Fail>g__FailCoroutine|42_0>d))]
	[CompilerGenerated]
	// RVA: 0x900180 Offset: 0x8FEB80 VA: 0x180900180
	private IEnumerator <Fail>g__FailCoroutine|42_0() { }
}
