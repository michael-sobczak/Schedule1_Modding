internal abstract class CollectionVirtualizationController // TypeDefIndex: 6195
{
	// Fields
	protected readonly ScrollView m_ScrollView; // 0x10

	// Properties
	public abstract int firstVisibleIndex { get; set; }
	public abstract int visibleItemCount { get; }
	public abstract IEnumerable<ReusableCollectionItem> activeItems { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_firstVisibleIndex();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void set_firstVisibleIndex(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_visibleItemCount();

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	protected void .ctor(ScrollView scrollView) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Refresh(bool rebuild);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ScrollToItem(int id);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Resize(Vector2 size);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnScroll(Vector2 offset);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetIndexFromPosition(Vector2 position);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float GetExpectedItemHeight(int index);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract float GetExpectedContentHeight();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void OnFocus(VisualElement leafTarget);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnBlur(VisualElement willFocus);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void UpdateBackground();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IEnumerable<ReusableCollectionItem> get_activeItems();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract void StartDragItem(ReusableCollectionItem item);

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract void EndDrag(int dropIndex);
}
