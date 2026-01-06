public class BodySearchScreen : Singleton<BodySearchScreen> // TypeDefIndex: 2561
{
	// Fields
	public const float MAX_SPEED_BOOST = 2.5;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <TutorialOpen>k__BackingField; // 0x29
	public Color SlotRedColor; // 0x2C
	public Color SlotHighlightRedColor; // 0x3C
	public float GapTime; // 0x4C
	[Header("References")]
	public Canvas Canvas; // 0x50
	public RectTransform Container; // 0x58
	public RectTransform MinigameController; // 0x60
	public RectTransform SlotContainer; // 0x68
	public ItemSlotUI ItemSlotPrefab; // 0x70
	public RectTransform SearchIndicator; // 0x78
	public RectTransform SearchIndicatorStart; // 0x80
	public RectTransform SearchIndicatorEnd; // 0x88
	public Animation IndicatorAnimation; // 0x90
	public Animation TutorialAnimation; // 0x98
	public RectTransform TutorialContainer; // 0xA0
	public Animation ResetAnimation; // 0xA8
	public AudioSourceController FailSound; // 0xB0
	private List<ItemSlotUI> slots; // 0xB8
	public UnityEvent onSearchClear; // 0xC0
	public UnityEvent onSearchFail; // 0xC8
	private Color defaultSlotColor; // 0xD0
	private Color defaultSlotHighlightColor; // 0xE0
	private ItemSlotUI concealedSlot; // 0xF0
	private ItemSlotUI hoveredSlot; // 0xF8
	private Color[] defaultItemIconColors; // 0x100
	private float speedBoost; // 0x108
	private NPC searcher; // 0x110
	private bool _caught; // 0x118

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

	// RVA: 0x8AA550 Offset: 0x8A8F50 VA: 0x1808AA550 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8ABA00 Offset: 0x8AA400 VA: 0x1808ABA00 Slot: 4
	protected override void Start() { }

	// RVA: 0x8AB050 Offset: 0x8A9A50 VA: 0x1808AB050
	private void SetupSlots() { }

	// RVA: 0x8ABC00 Offset: 0x8AA600 VA: 0x1808ABC00
	private void Update() { }

	// RVA: 0x8AA9D0 Offset: 0x8A93D0 VA: 0x1808AA9D0
	public void Open(NPC _searcher, float searchTime = 0) { }

	// RVA: 0x8AA900 Offset: 0x8A9300 VA: 0x1808AA900
	private bool IsSlotConcealed(ItemSlotUI slot) { }

	// RVA: 0x8AA960 Offset: 0x8A9360 VA: 0x1808AA960
	private void ItemDetected(ItemSlotUI slot) { }

	// RVA: 0x8AB770 Offset: 0x8AA170 VA: 0x1808AB770
	public void SlotHeld(ItemSlotUI ui) { }

	// RVA: 0x8AB900 Offset: 0x8AA300 VA: 0x1808AB900
	public void SlotReleased(ItemSlotUI ui) { }

	// RVA: 0x8AA5D0 Offset: 0x8A8FD0 VA: 0x1808AA5D0
	public void Close(bool clear) { }

	// RVA: 0x8AA980 Offset: 0x8A9380 VA: 0x1808AA980
	private void OpenTutorial() { }

	// RVA: 0x8AA590 Offset: 0x8A8F90 VA: 0x1808AA590
	public void CloseTutorial() { }

	// RVA: 0x8ABE70 Offset: 0x8AA870 VA: 0x1808ABE70
	public void .ctor() { }
}
