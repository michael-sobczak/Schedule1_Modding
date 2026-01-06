internal class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController // TypeDefIndex: 6483
{
	// Fields
	protected TreeViewReorderableDragAndDropController.DropData m_DropData; // 0x28
	protected readonly BaseTreeView m_TreeView; // 0x30
	private IVisualElementScheduledItem m_ExpandDropItemScheduledItem; // 0x38
	private Action m_ExpandDropItemCallback; // 0x40

	// Methods

	// RVA: 0x2E9CB10 Offset: 0x2E9B510 VA: 0x182E9CB10
	public void .ctor(BaseTreeView view) { }

	// RVA: 0x2E9B4C0 Offset: 0x2E99EC0 VA: 0x182E9B4C0 Slot: 17
	protected override int CompareId(int id1, int id2) { }

	// RVA: 0x2E9CA40 Offset: 0x2E9B440 VA: 0x182E9CA40 Slot: 16
	public override StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = False) { }

	// RVA: 0x2E9C130 Offset: 0x2E9AB30 VA: 0x182E9C130 Slot: 18
	public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	// RVA: 0x2E9C1E0 Offset: 0x2E9ABE0 VA: 0x182E9C1E0 Slot: 19
	public override void OnDrop(IListDragAndDropArgs args) { }

	// RVA: 0x2E9BCC0 Offset: 0x2E9A6C0 VA: 0x182E9BCC0 Slot: 20
	public override void DragCleanup() { }

	// RVA: 0x2E9C800 Offset: 0x2E9B200 VA: 0x182E9C800
	private void RestoreExpanded(List<int> ids) { }

	// RVA: 0x2E9BFB0 Offset: 0x2E9A9B0 VA: 0x182E9BFB0 Slot: 21
	public override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	// RVA: 0x2E9BAE0 Offset: 0x2E9A4E0 VA: 0x182E9BAE0
	private void DelayExpandDropItem() { }

	// RVA: 0x2E9BDD0 Offset: 0x2E9A7D0 VA: 0x182E9BDD0
	private void ExpandDropItem() { }
}
