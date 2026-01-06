public abstract class BaseTreeViewController : CollectionViewController // TypeDefIndex: 6184
{
	// Fields
	private Dictionary<int, TreeItem> m_TreeItems; // 0x30
	private List<int> m_RootIndices; // 0x38
	private List<TreeViewItemWrapper> m_ItemWrappers; // 0x40
	private HashSet<int> m_TreeItemIdsWithItemWrappers; // 0x48
	private List<TreeViewItemWrapper> m_WrapperInsertionList; // 0x50
	private static readonly ProfilerMarker K_ExpandItemByIndex; // 0x0
	private static readonly ProfilerMarker k_CreateWrappers; // 0x8

	// Properties
	protected BaseTreeView baseTreeView { get; }
	public override IList itemsSource { get; set; }

	// Methods

	// RVA: 0x2DB22C0 Offset: 0x2DB0CC0 VA: 0x182DB22C0
	protected BaseTreeView get_baseTreeView() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 5
	public override IList get_itemsSource() { }

	// RVA: 0x2DB2340 Offset: 0x2DB0D40 VA: 0x182DB2340 Slot: 6
	public override void set_itemsSource(IList value) { }

	// RVA: 0x2DB1CE0 Offset: 0x2DB06E0 VA: 0x182DB1CE0
	public void RebuildTree() { }

	// RVA: 0x2D0E1B0 Offset: 0x2D0CBB0 VA: 0x182D0E1B0
	public IEnumerable<int> GetRootItemIds() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int GetParentId(int id);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract IEnumerable<int> GetChildrenIds(int id);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = True);

	// RVA: 0x2DB0F50 Offset: 0x2DAF950 VA: 0x182DB0F50 Slot: 14
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x2DB0C00 Offset: 0x2DAF600 VA: 0x182DB0C00 Slot: 15
	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x2DB0D00 Offset: 0x2DAF700 VA: 0x182DB0D00 Slot: 17
	internal override void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x2DB1990 Offset: 0x2DB0390 VA: 0x182DB1990
	internal void PostInitRegistration(ReusableTreeViewItem treeItem) { }

	// RVA: 0x2DB11E0 Offset: 0x2DAFBE0 VA: 0x182DB11E0
	private void OnItemPointerUp(PointerUpEvent evt) { }

	// RVA: 0x2DB17E0 Offset: 0x2DB01E0 VA: 0x182DB17E0
	private void OnToggleValueChanged(ChangeEvent<bool> evt) { }

	// RVA: 0x2DB09D0 Offset: 0x2DAF3D0 VA: 0x182DB09D0 Slot: 11
	public override int GetIndexForId(int id) { }

	// RVA: 0x2DB0840 Offset: 0x2DAF240 VA: 0x182DB0840 Slot: 12
	public override int GetIdForIndex(int index) { }

	// RVA: 0x2DB0B80 Offset: 0x2DAF580 VA: 0x182DB0B80 Slot: 26
	public virtual bool HasChildren(int id) { }

	// RVA: 0x2DAFA50 Offset: 0x2DAE450 VA: 0x182DAFA50
	internal bool Exists(int id) { }

	// RVA: 0x2DB0AD0 Offset: 0x2DAF4D0 VA: 0x182DB0AD0
	public bool HasChildrenByIndex(int index) { }

	// RVA: 0x2DB0790 Offset: 0x2DAF190 VA: 0x182DB0790
	public IEnumerable<int> GetChildrenIdsByIndex(int index) { }

	// RVA: 0x2DB05C0 Offset: 0x2DAEFC0 VA: 0x182DB05C0
	public int GetChildIndexForId(int id) { }

	// RVA: 0x2DB0970 Offset: 0x2DAF370 VA: 0x182DB0970
	internal int GetIndentationDepth(int id) { }

	// RVA: 0x2DB0900 Offset: 0x2DAF300 VA: 0x182DB0900
	internal int GetIndentationDepthByIndex(int index) { }

	// RVA: 0x1366110 Offset: 0x1364B10 VA: 0x181366110 Slot: 27
	internal virtual bool CanChangeExpandedState(int id) { }

	// RVA: 0x2DB1110 Offset: 0x2DAFB10 VA: 0x182DB1110
	public bool IsExpanded(int id) { }

	// RVA: 0x2DB1000 Offset: 0x2DAFA00 VA: 0x182DB1000
	public bool IsExpandedByIndex(int index) { }

	// RVA: 0x2DAFAB0 Offset: 0x2DAE4B0 VA: 0x182DAFAB0
	public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = True) { }

	// RVA: 0x2DB03E0 Offset: 0x2DAEDE0 VA: 0x182DB03E0
	public void ExpandItem(int id, bool expandAllChildren, bool refresh = True) { }

	// RVA: 0x2DAEFC0 Offset: 0x2DAD9C0 VA: 0x182DAEFC0
	public void CollapseItemByIndex(int index, bool collapseAllChildren) { }

	// RVA: 0x2DAF420 Offset: 0x2DADE20 VA: 0x182DAF420
	public void CollapseItem(int id, bool collapseAllChildren) { }

	// RVA: 0x2DB1FD0 Offset: 0x2DB09D0 VA: 0x182DB1FD0
	internal void RegenerateWrappers() { }

	// RVA: 0x2DAF5C0 Offset: 0x2DADFC0 VA: 0x182DAF5C0
	private void CreateWrappers(IEnumerable<int> treeViewItemIds, int depth, ref List<TreeViewItemWrapper> wrappers) { }

	// RVA: 0x2DB1180 Offset: 0x2DAFB80 VA: 0x182DB1180
	private bool IsIndexValid(int index) { }

	// RVA: 0x2DB1CC0 Offset: 0x2DB06C0 VA: 0x182DB1CC0
	internal void RaiseItemParentChanged(int id, int newParentId) { }

	// RVA: 0x2DB2140 Offset: 0x2DB0B40 VA: 0x182DB2140
	protected void .ctor() { }

	// RVA: 0x2DB2090 Offset: 0x2DB0A90 VA: 0x182DB2090
	private static void .cctor() { }
}
