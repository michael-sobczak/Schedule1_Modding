public abstract class BaseListView : BaseVerticalCollectionView // TypeDefIndex: 6217
{
	// Fields
	private static readonly string k_SizeFieldLabel; // 0x0
	private bool m_ShowBoundCollectionSize; // 0x4C0
	private bool m_ShowFoldoutHeader; // 0x4C1
	private string m_HeaderTitle; // 0x4C8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<IEnumerable<int>> itemsAdded; // 0x4D0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<IEnumerable<int>> itemsRemoved; // 0x4D8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action itemsSourceSizeChanged; // 0x4E0
	private Label m_ListViewLabel; // 0x4E8
	private Foldout m_Foldout; // 0x4F0
	private TextField m_ArraySizeField; // 0x4F8
	private bool m_IsOverMultiEditLimit; // 0x500
	private VisualElement m_Footer; // 0x508
	private Button m_AddButton; // 0x510
	private Button m_RemoveButton; // 0x518
	private Action<IEnumerable<int>> m_ItemAddedCallback; // 0x520
	private Action<IEnumerable<int>> m_ItemRemovedCallback; // 0x528
	private Action m_ItemsSourceSizeChangedCallback; // 0x530
	private ListViewReorderMode m_ReorderMode; // 0x538
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action reorderModeChanged; // 0x540
	public static readonly string ussClassName; // 0x8
	public static readonly string itemUssClassName; // 0x10
	public static readonly string emptyLabelUssClassName; // 0x18
	public static readonly string overMaxMultiEditLimitClassName; // 0x20
	public static readonly string reorderableUssClassName; // 0x28
	public static readonly string reorderableItemUssClassName; // 0x30
	public static readonly string reorderableItemContainerUssClassName; // 0x38
	public static readonly string reorderableItemHandleUssClassName; // 0x40
	public static readonly string reorderableItemHandleBarUssClassName; // 0x48
	public static readonly string footerUssClassName; // 0x50
	public static readonly string foldoutHeaderUssClassName; // 0x58
	public static readonly string arraySizeFieldUssClassName; // 0x60
	public static readonly string arraySizeFieldWithHeaderUssClassName; // 0x68
	public static readonly string arraySizeFieldWithFooterUssClassName; // 0x70
	public static readonly string listViewWithHeaderUssClassName; // 0x78
	public static readonly string listViewWithFooterUssClassName; // 0x80
	public static readonly string scrollViewWithFooterUssClassName; // 0x88
	public static readonly string footerAddButtonName; // 0x90
	public static readonly string footerRemoveButtonName; // 0x98
	private string m_MaxMultiEditStr; // 0x548
	private static readonly string k_EmptyListStr; // 0xA0

	// Properties
	public bool showBoundCollectionSize { get; set; }
	public bool showFoldoutHeader { get; set; }
	public string headerTitle { set; }
	public bool showAddRemoveFooter { get; set; }
	internal VisualElement footer { get; }
	public BaseListViewController viewController { get; }
	public ListViewReorderMode reorderMode { get; set; }

	// Methods

	// RVA: 0x2DAEAD0 Offset: 0x2DAD4D0 VA: 0x182DAEAD0
	public bool get_showBoundCollectionSize() { }

	// RVA: 0x2DAECE0 Offset: 0x2DAD6E0 VA: 0x182DAECE0
	public void set_showBoundCollectionSize(bool value) { }

	// RVA: 0x2DAEAE0 Offset: 0x2DAD4E0 VA: 0x182DAEAE0
	public bool get_showFoldoutHeader() { }

	// RVA: 0x2DAED00 Offset: 0x2DAD700 VA: 0x182DAED00
	public void set_showFoldoutHeader(bool value) { }

	// RVA: 0x2DADAA0 Offset: 0x2DAC4A0 VA: 0x182DADAA0
	internal void SetupArraySizeField() { }

	// RVA: 0x2DAEC20 Offset: 0x2DAD620 VA: 0x182DAEC20
	public void set_headerTitle(string value) { }

	// RVA: 0x2DAEAC0 Offset: 0x2DAD4C0 VA: 0x182DAEAC0
	public bool get_showAddRemoveFooter() { }

	// RVA: 0x2DAECD0 Offset: 0x2DAD6D0 VA: 0x182DAECD0
	public void set_showAddRemoveFooter(bool value) { }

	// RVA: 0x2DAC730 Offset: 0x2DAB130 VA: 0x182DAC730
	private void EnableFooter(bool enabled) { }

	// RVA: 0x2DAC5B0 Offset: 0x2DAAFB0 VA: 0x182DAC5B0
	private void AddItems(int itemCount) { }

	// RVA: 0x2DAD090 Offset: 0x2DABA90 VA: 0x182DAD090
	private void OnArraySizeFieldChanged(ChangeEvent<string> evt) { }

	// RVA: 0x2DADE90 Offset: 0x2DAC890 VA: 0x182DADE90
	internal void UpdateArraySizeField() { }

	// RVA: 0x2DADF80 Offset: 0x2DAC980 VA: 0x182DADF80
	internal void UpdateListViewLabel() { }

	// RVA: 0x2DACEE0 Offset: 0x2DAB8E0 VA: 0x182DACEE0
	private void OnAddClicked() { }

	// RVA: 0x2DAD3A0 Offset: 0x2DABDA0 VA: 0x182DAD3A0
	private void OnRemoveClicked() { }

	// RVA: 0x2DAEAA0 Offset: 0x2DAD4A0 VA: 0x182DAEAA0
	internal VisualElement get_footer() { }

	// RVA: 0x2DAEAF0 Offset: 0x2DAD4F0 VA: 0x182DAEAF0
	public BaseListViewController get_viewController() { }

	// RVA: 0x2DAC6F0 Offset: 0x2DAB0F0 VA: 0x182DAC6F0 Slot: 104
	internal override void CreateVirtualizationController() { }

	// RVA: 0x2DAD560 Offset: 0x2DABF60 VA: 0x182DAD560 Slot: 106
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x2DAD2E0 Offset: 0x2DABCE0 VA: 0x182DAD2E0
	private void OnItemAdded(IEnumerable<int> indices) { }

	// RVA: 0x2DAD300 Offset: 0x2DABD00 VA: 0x182DAD300
	private void OnItemsRemoved(IEnumerable<int> indices) { }

	// RVA: 0x2DAD320 Offset: 0x2DABD20 VA: 0x182DAD320
	private void OnItemsSourceSizeChanged() { }

	[CompilerGenerated]
	// RVA: 0x2DAE9F0 Offset: 0x2DAD3F0 VA: 0x182DAE9F0
	internal void add_reorderModeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2DAEB70 Offset: 0x2DAD570 VA: 0x182DAEB70
	internal void remove_reorderModeChanged(Action value) { }

	// RVA: 0x2DAEAB0 Offset: 0x2DAD4B0 VA: 0x182DAEAB0
	public ListViewReorderMode get_reorderMode() { }

	// RVA: 0x2DAEC70 Offset: 0x2DAD670 VA: 0x182DAEC70
	public void set_reorderMode(ListViewReorderMode value) { }

	// RVA: 0x2DAC650 Offset: 0x2DAB050 VA: 0x182DAC650 Slot: 107
	internal override ListViewDragger CreateDragger() { }

	// RVA: 0x2DAC5F0 Offset: 0x2DAAFF0 VA: 0x182DAC5F0 Slot: 108
	internal override ICollectionDragAndDropController CreateDragAndDropController() { }

	// RVA: 0x2DAE940 Offset: 0x2DAD340 VA: 0x182DAE940
	public void .ctor() { }

	// RVA: 0x2DAD530 Offset: 0x2DABF30 VA: 0x182DAD530 Slot: 110
	internal override void PostRefresh() { }

	// RVA: 0x2DACBB0 Offset: 0x2DAB5B0 VA: 0x182DACBB0 Slot: 111
	internal override bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	// RVA: 0x2DAE200 Offset: 0x2DACC00 VA: 0x182DAE200
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2DADE10 Offset: 0x2DAC810 VA: 0x182DADE10
	private void <OnAddClicked>b__38_0() { }
}
