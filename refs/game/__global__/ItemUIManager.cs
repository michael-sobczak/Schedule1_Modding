public class ItemUIManager : Singleton<ItemUIManager> // TypeDefIndex: 3037
{
	// Fields
	[CompilerGenerated]
	private bool <DraggingEnabled>k__BackingField; // 0x28
	[CompilerGenerated]
	private ItemSlotUI <HoveredSlot>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <QuickMoveEnabled>k__BackingField; // 0x38
	[Header("References")]
	public Canvas Canvas; // 0x40
	public RectTransform CashDragAmountContainer; // 0x48
	public RectTransform InputsContainer; // 0x50
	public ItemInfoPanel InfoPanel; // 0x58
	public RectTransform ItemQuantityPrompt; // 0x60
	public Animation CashSlotHintAnim; // 0x68
	public CanvasGroup CashSlotHintAnimCanvasGroup; // 0x70
	public FilterConfigPanel FilterConfigPanel; // 0x78
	[Header("Prefabs")]
	public ItemSlotUI ItemSlotUIPrefab; // 0x80
	public ItemUI DefaultItemUIPrefab; // 0x88
	public ItemSlotUI HotbarSlotUIPrefab; // 0x90
	private ItemSlotUI draggedSlot; // 0x98
	private Vector2 mouseOffset; // 0xA0
	private int draggedAmount; // 0xA8
	private RectTransform tempIcon; // 0xB0
	private List<GraphicRaycaster> _raycasters; // 0xB8
	private bool isDraggingCash; // 0xC0
	private float draggedCashAmount; // 0xC4
	private List<ItemSlot> PrimarySlots; // 0xC8
	private List<ItemSlot> SecondarySlots; // 0xD0
	private bool customDragAmount; // 0xD8
	private Coroutine quantityChangePopRoutine; // 0xE0
	public UnityEvent onDragStart; // 0xE8
	public UnityEvent onItemMoved; // 0xF0

	// Properties
	public bool DraggingEnabled { get; set; }
	public ItemSlotUI HoveredSlot { get; set; }
	public bool QuickMoveEnabled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_DraggingEnabled() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_DraggingEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public ItemSlotUI get_HoveredSlot() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_HoveredSlot(ItemSlotUI value) { }

	[CompilerGenerated]
	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_QuickMoveEnabled() { }

	[CompilerGenerated]
	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	protected void set_QuickMoveEnabled(bool value) { }

	// RVA: 0x99F6F0 Offset: 0x99E0F0 VA: 0x18099F6F0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x9A2E20 Offset: 0x9A1820 VA: 0x1809A2E20 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x99F5E0 Offset: 0x99DFE0 VA: 0x18099F5E0
	public void AddRaycaster(GraphicRaycaster raycaster) { }

	// RVA: 0x9A1250 Offset: 0x99FC50 VA: 0x1809A1250 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x9A2BB0 Offset: 0x9A15B0 VA: 0x1809A2BB0
	private void UpdateCashDragSelectorUI() { }

	// RVA: 0x9A2910 Offset: 0x9A1310 VA: 0x1809A2910
	private void UpdateCashDragAmount(CashInstance instance) { }

	// RVA: 0x9A1700 Offset: 0x9A0100 VA: 0x1809A1700
	public void SetDraggingEnabled(bool enabled, bool modifierPromptsVisible = True) { }

	// RVA: 0x99F8E0 Offset: 0x99E2E0 VA: 0x18099F8E0
	public void EnableQuickMove(List<ItemSlot> primarySlots, List<ItemSlot> secondarySlots) { }

	// RVA: 0x9A0FB0 Offset: 0x99F9B0 VA: 0x1809A0FB0
	private List<ItemSlot> GetQuickMoveSlots(ItemSlot sourceSlot) { }

	// RVA: 0x99F8D0 Offset: 0x99E2D0 VA: 0x18099F8D0
	public void DisableQuickMove() { }

	// RVA: 0x9A0BF0 Offset: 0x99F5F0 VA: 0x1809A0BF0
	private ItemSlotUI GetHoveredItemSlot() { }

	// RVA: 0x9A08C0 Offset: 0x99F2C0 VA: 0x1809A08C0
	private ItemDefinitionInfoHoverable GetHoveredItemInfo() { }

	// RVA: 0x9A1880 Offset: 0x9A0280 VA: 0x1809A1880
	private void SlotClicked(ItemSlotUI ui) { }

	// RVA: 0x9A20B0 Offset: 0x9A0AB0 VA: 0x1809A20B0
	private void StartDragCash() { }

	// RVA: 0x9A01B0 Offset: 0x99EBB0 VA: 0x1809A01B0
	private void EndDrag() { }

	// RVA: 0x9A1400 Offset: 0x99FE00 VA: 0x1809A1400
	private void SetDraggedAmount(int amount) { }

	// RVA: 0x99FA20 Offset: 0x99E420 VA: 0x18099FA20
	private void EndCashDrag() { }

	// RVA: 0x99F840 Offset: 0x99E240 VA: 0x18099F840
	public bool CanDragFromSlot(ItemSlotUI slotUI) { }

	// RVA: 0x99F780 Offset: 0x99E180 VA: 0x18099F780
	public bool CanCashBeDraggedIntoSlot(ItemSlotUI ui) { }

	// RVA: 0x9A3420 Offset: 0x9A1E20 VA: 0x1809A3420
	public void .ctor() { }
}
