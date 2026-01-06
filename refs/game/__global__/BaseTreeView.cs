public abstract class BaseTreeView : BaseVerticalCollectionView // TypeDefIndex: 6226
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string itemUssClassName; // 0x8
	public static readonly string itemToggleUssClassName; // 0x10
	public static readonly string itemIndentsContainerUssClassName; // 0x18
	public static readonly string itemIndentUssClassName; // 0x20
	public static readonly string itemContentContainerUssClassName; // 0x28
	private bool m_AutoExpand; // 0x4C0
	[SerializeField]
	private List<int> m_ExpandedItemIds; // 0x4C8

	// Properties
	public IList itemsSource { get; }
	public BaseTreeViewController viewController { get; }
	public bool autoExpand { get; set; }
	internal List<int> expandedItemIds { get; set; }

	// Methods

	// RVA: 0x2DC24F0 Offset: 0x2DC0EF0 VA: 0x182DC24F0
	public IList get_itemsSource() { }

	// RVA: 0x2DC2530 Offset: 0x2DC0F30 VA: 0x182DC2530
	public BaseTreeViewController get_viewController() { }

	// RVA: 0x2DC0F20 Offset: 0x2DBF920 VA: 0x182DC0F20 Slot: 104
	internal override void CreateVirtualizationController() { }

	// RVA: 0x2DC1B40 Offset: 0x2DC0540 VA: 0x182DC1B40 Slot: 106
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x2DC17B0 Offset: 0x2DC01B0 VA: 0x182DC17B0
	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x2DC0EC0 Offset: 0x2DBF8C0 VA: 0x182DC0EC0 Slot: 108
	internal override ICollectionDragAndDropController CreateDragAndDropController() { }

	// RVA: 0x2DAEAD0 Offset: 0x2DAD4D0 VA: 0x182DAEAD0
	public bool get_autoExpand() { }

	// RVA: 0x2DC25B0 Offset: 0x2DC0FB0 VA: 0x182DC25B0
	public void set_autoExpand(bool value) { }

	// RVA: 0x2DC24E0 Offset: 0x2DC0EE0 VA: 0x182DC24E0
	internal List<int> get_expandedItemIds() { }

	// RVA: 0x2DC25F0 Offset: 0x2DC0FF0 VA: 0x182DC25F0
	internal void set_expandedItemIds(List<int> value) { }

	// RVA: 0x2DC2340 Offset: 0x2DC0D40 VA: 0x182DC2340
	public void .ctor() { }

	// RVA: 0x2DC2190 Offset: 0x2DC0B90 VA: 0x182DC2190
	public void .ctor(int itemHeight) { }

	// RVA: 0x2DC1810 Offset: 0x2DC0210 VA: 0x182DC1810 Slot: 96
	internal override void OnViewDataReady() { }

	// RVA: 0x2DC11C0 Offset: 0x2DBFBC0 VA: 0x182DC11C0 Slot: 111
	internal override bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	// RVA: 0x2DC1960 Offset: 0x2DC0360 VA: 0x182DC1960
	public void SetSelectionById(int id) { }

	// RVA: 0x2DC18A0 Offset: 0x2DC02A0 VA: 0x182DC18A0
	public void SetSelectionById(IEnumerable<int> ids) { }

	// RVA: 0x2DC1A70 Offset: 0x2DC0470 VA: 0x182DC1A70
	internal void SetSelectionInternalById(IEnumerable<int> ids, bool sendNotification) { }

	// RVA: 0x2DC1040 Offset: 0x2DBFA40 VA: 0x182DC1040
	private int GetItemIndex(int id, bool expand = False) { }

	// RVA: 0x2DC1780 Offset: 0x2DC0180 VA: 0x182DC1780
	public bool IsExpanded(int id) { }

	// RVA: 0x2DC0E60 Offset: 0x2DBF860 VA: 0x182DC0E60
	public void CollapseItem(int id, bool collapseAllChildren = False) { }

	// RVA: 0x2DC0FF0 Offset: 0x2DBF9F0 VA: 0x182DC0FF0
	public void ExpandItem(int id, bool expandAllChildren = False) { }

	// RVA: 0x2DC17C0 Offset: 0x2DC01C0 VA: 0x182DC17C0
	private void OnTreeViewPointerUp(PointerUpEvent evt) { }

	// RVA: 0x2DC1750 Offset: 0x2DC0150 VA: 0x182DC1750
	private bool IsExpandedByIndex(int index) { }

	// RVA: 0x2DC0DE0 Offset: 0x2DBF7E0 VA: 0x182DC0DE0
	private void CollapseItemByIndex(int index, bool collapseAll) { }

	// RVA: 0x2DC0F60 Offset: 0x2DBF960 VA: 0x182DC0F60
	private void ExpandItemByIndex(int index, bool expandAll) { }

	// RVA: 0x2DC1F70 Offset: 0x2DC0970 VA: 0x182DC1F70
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2DC1E00 Offset: 0x2DC0800 VA: 0x182DC1E00
	private int <SetSelectionInternalById>b__47_0(int id) { }
}
