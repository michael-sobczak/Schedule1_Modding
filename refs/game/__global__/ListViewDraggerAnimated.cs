internal class ListViewDraggerAnimated : ListViewDragger // TypeDefIndex: 6480
{
	// Fields
	private int m_DragStartIndex; // 0x78
	private int m_CurrentIndex; // 0x7C
	private float m_SelectionHeight; // 0x80
	private float m_LocalOffsetOnStart; // 0x84
	private Vector3 m_CurrentPointerPosition; // 0x88
	private ReusableCollectionItem m_Item; // 0x98
	private ReusableCollectionItem m_OffsetItem; // 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isDragging>k__BackingField; // 0xA8

	// Properties
	public bool isDragging { get; set; }
	public ReusableCollectionItem draggedItem { get; }
	protected override bool supportsDragEvents { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4D63F0 Offset: 0x4D4DF0 VA: 0x1804D63F0
	public bool get_isDragging() { }

	[CompilerGenerated]
	// RVA: 0x4D6660 Offset: 0x4D5060 VA: 0x1804D6660
	private void set_isDragging(bool value) { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public ReusableCollectionItem get_draggedItem() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 4
	protected override bool get_supportsDragEvents() { }

	// RVA: 0x2E94D40 Offset: 0x2E93740 VA: 0x182E94D40
	public void .ctor(BaseVerticalCollectionView listView) { }

	// RVA: 0x2E93C10 Offset: 0x2E92610 VA: 0x182E93C10 Slot: 7
	protected internal override StartDragArgs StartDrag(Vector3 pointerPosition) { }

	// RVA: 0x2E94580 Offset: 0x2E92F80 VA: 0x182E94580 Slot: 8
	protected internal override void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x2E933D0 Offset: 0x2E91DD0 VA: 0x182E933D0
	private void Animate(ReusableCollectionItem element, float paddingTop) { }

	// RVA: 0x2E937A0 Offset: 0x2E921A0 VA: 0x182E937A0 Slot: 9
	protected internal override void OnDrop(Vector3 pointerPosition) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	protected override void ClearDragAndDropUI(bool dragCancelled) { }

	// RVA: 0x2E94540 Offset: 0x2E92F40 VA: 0x182E94540 Slot: 11
	protected override bool TryGetDragPosition(Vector2 pointerPosition, ref ListViewDragger.DragPosition dragPosition) { }
}
