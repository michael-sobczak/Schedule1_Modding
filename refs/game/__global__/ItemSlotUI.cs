public class ItemSlotUI : MonoBehaviour // TypeDefIndex: 2630
{
	// Fields
	public Color32 normalColor; // 0x20
	public Color32 highlightColor; // 0x24
	[CompilerGenerated]
	private ItemSlot <assignedSlot>k__BackingField; // 0x28
	[HideInInspector]
	public bool IsBeingDragged; // 0x30
	[Header("References")]
	public RectTransform Rect; // 0x38
	public Image Background; // 0x40
	public GameObject LockContainer; // 0x48
	public RectTransform ItemContainer; // 0x50
	public ItemSlotFilterButton FilterButton; // 0x58
	[CompilerGenerated]
	private ItemUI <ItemUI>k__BackingField; // 0x60

	// Properties
	public ItemSlot assignedSlot { get; set; }
	public ItemUI ItemUI { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ItemSlot get_assignedSlot() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	protected void set_assignedSlot(ItemSlot value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public ItemUI get_ItemUI() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	protected void set_ItemUI(ItemUI value) { }

	// RVA: 0x8E9FB0 Offset: 0x8E89B0 VA: 0x1808E9FB0 Slot: 4
	public virtual void AssignSlot(ItemSlot s) { }

	// RVA: 0x8EA510 Offset: 0x8E8F10 VA: 0x1808EA510 Slot: 5
	public virtual void ClearSlot() { }

	// RVA: 0x8EAAB0 Offset: 0x8E94B0 VA: 0x1808EAAB0
	public void OnDestroy() { }

	// RVA: 0x8EB010 Offset: 0x8E9A10 VA: 0x1808EB010 Slot: 6
	public virtual void UpdateUI() { }

	// RVA: 0x8EAD00 Offset: 0x8E9700 VA: 0x1808EAD00
	public void SetHighlighted(bool h) { }

	// RVA: 0x8EADF0 Offset: 0x8E97F0 VA: 0x1808EADF0
	public void SetNormalColor(Color color) { }

	// RVA: 0x8EAC30 Offset: 0x8E9630 VA: 0x1808EAC30
	public void SetHighlightColor(Color color) { }

	// RVA: 0x8EAA00 Offset: 0x8E9400 VA: 0x1808EAA00
	private void Lock() { }

	// RVA: 0x8EAF60 Offset: 0x8E9960 VA: 0x1808EAF60
	private void Unlock() { }

	// RVA: 0x8EADB0 Offset: 0x8E97B0 VA: 0x1808EADB0
	public void SetLockVisible(bool vis) { }

	// RVA: 0x8EA950 Offset: 0x8E9350 VA: 0x1808EA950
	public RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1) { }

	// RVA: 0x8EAEC0 Offset: 0x8E98C0 VA: 0x1808EAEC0
	public void SetVisible(bool shown) { }

	// RVA: 0x8EABA0 Offset: 0x8E95A0 VA: 0x1808EABA0
	public void OverrideDisplayedQuantity(int quantity) { }

	// RVA: 0x8D9AD0 Offset: 0x8D84D0 VA: 0x1808D9AD0
	public void .ctor() { }
}
