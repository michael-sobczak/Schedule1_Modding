internal class ListViewDragger : DragEventsProcessor // TypeDefIndex: 6478
{
	// Fields
	private ListViewDragger.DragPosition m_LastDragPosition; // 0x30
	private VisualElement m_DragHoverBar; // 0x50
	private VisualElement m_DragHoverItemMarker; // 0x58
	private VisualElement m_DragHoverSiblingMarker; // 0x60
	private float m_LeftIndentation; // 0x68
	private float m_SiblingBottom; // 0x6C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ICollectionDragAndDropController <dragAndDropController>k__BackingField; // 0x70

	// Properties
	protected BaseVerticalCollectionView targetView { get; }
	protected ScrollView targetScrollView { get; }
	public ICollectionDragAndDropController dragAndDropController { get; set; }

	// Methods

	// RVA: 0x2E98B80 Offset: 0x2E97580 VA: 0x182E98B80
	protected BaseVerticalCollectionView get_targetView() { }

	// RVA: 0x2E98B50 Offset: 0x2E97550 VA: 0x182E98B50
	protected ScrollView get_targetScrollView() { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public ICollectionDragAndDropController get_dragAndDropController() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_dragAndDropController(ICollectionDragAndDropController value) { }

	// RVA: 0x2E94D40 Offset: 0x2E93740 VA: 0x182E94D40
	public void .ctor(BaseVerticalCollectionView listView) { }

	// RVA: 0x2E95960 Offset: 0x2E94360 VA: 0x182E95960 Slot: 6
	protected override bool CanStartDrag(Vector3 pointerPosition) { }

	// RVA: 0x2E97E80 Offset: 0x2E96880 VA: 0x182E97E80 Slot: 7
	protected internal override StartDragArgs StartDrag(Vector3 pointerPosition) { }

	// RVA: 0x2E986A0 Offset: 0x2E970A0 VA: 0x182E986A0 Slot: 8
	protected internal override void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x2E964F0 Offset: 0x2E94EF0 VA: 0x182E964F0
	private DragVisualMode GetVisualMode(Vector3 pointerPosition, ref ListViewDragger.DragPosition dragPosition) { }

	// RVA: 0x2E973D0 Offset: 0x2E95DD0 VA: 0x182E973D0 Slot: 9
	protected internal override void OnDrop(Vector3 pointerPosition) { }

	// RVA: 0x2E96780 Offset: 0x2E95180 VA: 0x182E96780
	internal void HandleDragAndScroll(Vector2 pointerPosition) { }

	// RVA: 0x2E96670 Offset: 0x2E95070 VA: 0x182E96670
	private void HandleAutoExpansion(Vector2 pointerPosition) { }

	// RVA: 0x2E951A0 Offset: 0x2E93BA0 VA: 0x182E951A0
	private void ApplyDragAndDropUI(ListViewDragger.DragPosition dragPosition) { }

	// RVA: 0x2E981B0 Offset: 0x2E96BB0 VA: 0x182E981B0 Slot: 11
	protected virtual bool TryGetDragPosition(Vector2 pointerPosition, ref ListViewDragger.DragPosition dragPosition) { }

	// RVA: 0x2E97160 Offset: 0x2E95B60 VA: 0x182E97160
	private void HandleTreePosition(Vector2 pointerPosition, ref ListViewDragger.DragPosition dragPosition) { }

	// RVA: 0x2E96A20 Offset: 0x2E95420 VA: 0x182E96A20
	private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref ListViewDragger.DragPosition dragPosition, Vector2 pointerPosition) { }

	// RVA: 0x2E96110 Offset: 0x2E94B10 VA: 0x182E96110
	private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId) { }

	// RVA: 0x2E97280 Offset: 0x2E95C80 VA: 0x182E97280
	protected DragAndDropArgs MakeDragAndDropArgs(ListViewDragger.DragPosition dragPosition) { }

	// RVA: 0x2E96020 Offset: 0x2E94A20 VA: 0x182E96020
	private float GetHoverBarTopPosition(ReusableCollectionItem item) { }

	// RVA: 0x2E97630 Offset: 0x2E96030 VA: 0x182E97630
	private void PlaceHoverBarAtElement(ReusableCollectionItem item) { }

	// RVA: 0x2E97750 Offset: 0x2E96150 VA: 0x182E97750
	private void PlaceHoverBarAt(float top, float indentationPadding = -1, float siblingBottom = -1) { }

	// RVA: 0x2E95C60 Offset: 0x2E94660 VA: 0x182E95C60 Slot: 10
	protected override void ClearDragAndDropUI(bool dragCancelled) { }

	// RVA: 0x2E962E0 Offset: 0x2E94CE0 VA: 0x182E962E0
	protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition) { }

	[CompilerGenerated]
	// RVA: 0x2E98570 Offset: 0x2E96F70 VA: 0x182E98570
	private void <ApplyDragAndDropUI>g__GeometryChangedCallback|27_0(GeometryChangedEvent e) { }
}
