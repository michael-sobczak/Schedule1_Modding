internal class ReusableListViewItem : ReusableCollectionItem // TypeDefIndex: 6202
{
	// Fields
	private VisualElement m_Container; // 0x48
	private VisualElement m_DragHandle; // 0x50
	private VisualElement m_ItemContainer; // 0x58

	// Properties
	public override VisualElement rootElement { get; }

	// Methods

	// RVA: 0x2DBB470 Offset: 0x2DB9E70 VA: 0x182DBB470 Slot: 4
	public override VisualElement get_rootElement() { }

	// RVA: 0x2DBAE10 Offset: 0x2DB9810 VA: 0x182DBAE10
	public void Init(VisualElement item, bool usesAnimatedDragger) { }

	// RVA: 0x2DBB160 Offset: 0x2DB9B60 VA: 0x182DBB160
	protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger) { }

	// RVA: 0x2DBAFF0 Offset: 0x2DB99F0 VA: 0x182DBAFF0
	public void UpdateDragHandle(bool needsDragHandle) { }

	// RVA: 0x2DBAEF0 Offset: 0x2DB98F0 VA: 0x182DBAEF0 Slot: 6
	public override void PreAttachElement() { }

	// RVA: 0x2DBAD80 Offset: 0x2DB9780 VA: 0x182DBAD80 Slot: 7
	public override void DetachElement() { }

	// RVA: 0x2DBAF80 Offset: 0x2DB9980 VA: 0x182DBAF80 Slot: 10
	public override void SetDragGhost(bool dragGhost) { }

	// RVA: 0x2DBB460 Offset: 0x2DB9E60 VA: 0x182DBB460
	public void .ctor() { }
}
