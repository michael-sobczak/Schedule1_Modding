internal abstract class BaseReorderableDragAndDropController : ICollectionDragAndDropController, IDragAndDropController<IListDragAndDropArgs>, IReorderable // TypeDefIndex: 6459
{
	// Fields
	protected readonly BaseVerticalCollectionView m_View; // 0x10
	protected List<int> m_SortedSelectedIds; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <enableReordering>k__BackingField; // 0x20

	// Properties
	public virtual bool enableReordering { get; set; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 10
	public IEnumerable<int> GetSortedSelectedIds() { }

	// RVA: 0x2E87F20 Offset: 0x2E86920 VA: 0x182E87F20
	protected void .ctor(BaseVerticalCollectionView view) { }

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0 Slot: 13
	public virtual bool get_enableReordering() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600 Slot: 14
	public virtual void set_enableReordering(bool value) { }

	// RVA: 0x1C02300 Offset: 0x1C00D00 VA: 0x181C02300 Slot: 15
	public virtual bool CanStartDrag(IEnumerable<int> itemIds) { }

	// RVA: 0x2E87A80 Offset: 0x2E86480 VA: 0x182E87A80 Slot: 16
	public virtual StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = False) { }

	// RVA: 0x2E87A60 Offset: 0x2E86460 VA: 0x182E87A60 Slot: 17
	protected virtual int CompareId(int id1, int id2) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void OnDrop(IListDragAndDropArgs args);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	public virtual void DragCleanup() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }
}
