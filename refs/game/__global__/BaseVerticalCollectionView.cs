public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver // TypeDefIndex: 6236
{
	// Fields
	private static readonly ProfilerMarker k_RefreshMarker; // 0x0
	private static readonly ProfilerMarker k_RebuildMarker; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<IEnumerable<object>> itemsChosen; // 0x3D8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<IEnumerable<object>> selectionChanged; // 0x3E0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<IEnumerable<int>> selectedIndicesChanged; // 0x3E8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<int, int> itemIndexChanged; // 0x3F0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action itemsSourceChanged; // 0x3F8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action selectionNotChanged; // 0x400
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Func<CanStartDragArgs, bool> canStartDrag; // 0x408
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Func<SetupDragAndDropArgs, StartDragArgs> setupDragAndDrop; // 0x410
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Func<HandleDragAndDropArgs, DragVisualMode> dragAndDropUpdate; // 0x418
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Func<HandleDragAndDropArgs, DragVisualMode> handleDrop; // 0x420
	private SelectionType m_SelectionType; // 0x428
	private static readonly List<ReusableCollectionItem> k_EmptyItems; // 0x10
	private bool m_HorizontalScrollingEnabled; // 0x42C
	[SerializeField]
	private AlternatingRowBackground m_ShowAlternatingRowBackgrounds; // 0x430
	internal static readonly int s_DefaultItemHeight; // 0x18
	internal float m_FixedItemHeight; // 0x434
	internal bool m_ItemHeightIsInline; // 0x438
	private CollectionVirtualizationMethod m_VirtualizationMethod; // 0x43C
	private readonly ScrollView m_ScrollView; // 0x440
	private CollectionViewController m_ViewController; // 0x448
	private CollectionVirtualizationController m_VirtualizationController; // 0x450
	private KeyboardNavigationManipulator m_NavigationManipulator; // 0x458
	[SerializeField]
	internal SerializedVirtualizationData serializedVirtualizationData; // 0x460
	[SerializeField]
	private readonly List<int> m_SelectedIds; // 0x468
	private readonly BaseVerticalCollectionView.Selection m_Selection; // 0x470
	private float m_LastHeight; // 0x478
	private bool m_IsRangeSelectionDirectionUp; // 0x47C
	private ListViewDragger m_Dragger; // 0x480
	internal static CustomStyleProperty<int> s_ItemHeightProperty; // 0x20
	private Action<int, int> m_ItemIndexChangedCallback; // 0x488
	private Action m_ItemsSourceChangedCallback; // 0x490
	internal IVisualElementScheduledItem m_RebuildScheduled; // 0x498
	public static readonly string ussClassName; // 0x28
	public static readonly string borderUssClassName; // 0x30
	public static readonly string itemUssClassName; // 0x38
	public static readonly string dragHoverBarUssClassName; // 0x40
	public static readonly string dragHoverMarkerUssClassName; // 0x48
	public static readonly string itemDragHoverUssClassName; // 0x50
	public static readonly string itemSelectedVariantUssClassName; // 0x58
	public static readonly string itemAlternativeBackgroundUssClassName; // 0x60
	public static readonly string listScrollViewUssClassName; // 0x68
	internal static readonly string backgroundFillUssClassName; // 0x70
	private Vector3 m_TouchDownPosition; // 0x4A0
	private long m_LastPointerDownTimeStamp; // 0x4B0
	private int m_PointerDownCount; // 0x4B8

	// Properties
	public IList itemsSource { get; set; }
	public override VisualElement contentContainer { get; }
	public SelectionType selectionType { get; set; }
	public IEnumerable<object> selectedItems { get; }
	public IEnumerable<int> selectedIds { get; }
	public int selectedIndex { get; set; }
	public IEnumerable<int> selectedIndices { get; }
	internal IEnumerable<ReusableCollectionItem> activeItems { get; }
	internal ScrollView scrollView { get; }
	internal ListViewDragger dragger { get; }
	internal CollectionVirtualizationController virtualizationController { get; }
	public CollectionViewController viewController { get; }
	public bool showBorder { set; }
	public bool reorderable { get; set; }
	public bool horizontalScrollingEnabled { set; }
	public AlternatingRowBackground showAlternatingRowBackgrounds { get; set; }
	public CollectionVirtualizationMethod virtualizationMethod { get; set; }
	public float fixedItemHeight { get; set; }
	internal float lastHeight { get; }

	// Methods

	// RVA: 0x2DC4250 Offset: 0x2DC2C50 VA: 0x182DC4250
	internal bool HasCanStartDrag() { }

	// RVA: 0x2DC5A20 Offset: 0x2DC4420 VA: 0x182DC5A20
	internal bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<int> ids) { }

	// RVA: 0x2DC5C20 Offset: 0x2DC4620 VA: 0x182DC5C20
	internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<int> ids, StartDragArgs args) { }

	// RVA: 0x2DC5B80 Offset: 0x2DC4580 VA: 0x182DC5B80
	internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	// RVA: 0x2DC5AE0 Offset: 0x2DC44E0 VA: 0x182DC5AE0
	internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	// RVA: 0x2DC8750 Offset: 0x2DC7150 VA: 0x182DC8750
	public IList get_itemsSource() { }

	// RVA: 0x2DC8B30 Offset: 0x2DC7530 VA: 0x182DC8B30
	public void set_itemsSource(IList value) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 99
	public override VisualElement get_contentContainer() { }

	// RVA: 0x2DC89A0 Offset: 0x2DC73A0 VA: 0x182DC89A0
	public SelectionType get_selectionType() { }

	// RVA: 0x2DC8C50 Offset: 0x2DC7650 VA: 0x182DC8C50
	public void set_selectionType(SelectionType value) { }

	[IteratorStateMachine(typeof(BaseVerticalCollectionView.<get_selectedItems>d__72))]
	// RVA: 0x2DC8920 Offset: 0x2DC7320 VA: 0x182DC8920
	public IEnumerable<object> get_selectedItems() { }

	// RVA: 0x2DC8820 Offset: 0x2DC7220 VA: 0x182DC8820
	public IEnumerable<int> get_selectedIds() { }

	// RVA: 0x2DC8840 Offset: 0x2DC7240 VA: 0x182DC8840
	public int get_selectedIndex() { }

	// RVA: 0x2DC5A10 Offset: 0x2DC4410 VA: 0x182DC5A10
	public void set_selectedIndex(int value) { }

	// RVA: 0x2DC8900 Offset: 0x2DC7300 VA: 0x182DC8900
	public IEnumerable<int> get_selectedIndices() { }

	// RVA: 0x2DC86B0 Offset: 0x2DC70B0 VA: 0x182DC86B0
	internal IEnumerable<ReusableCollectionItem> get_activeItems() { }

	// RVA: 0x13D8010 Offset: 0x13D6A10 VA: 0x1813D8010
	internal ScrollView get_scrollView() { }

	// RVA: 0x2DC8730 Offset: 0x2DC7130 VA: 0x182DC8730
	internal ListViewDragger get_dragger() { }

	// RVA: 0x2DC4110 Offset: 0x2DC2B10 VA: 0x182DC4110
	internal CollectionVirtualizationController get_virtualizationController() { }

	// RVA: 0x13D8020 Offset: 0x13D6A20 VA: 0x1813D8020
	public CollectionViewController get_viewController() { }

	// RVA: 0x2DC6B30 Offset: 0x2DC5530 VA: 0x182DC6B30
	internal float ResolveItemHeight(float height = -1) { }

	// RVA: 0x2DC8D10 Offset: 0x2DC7710 VA: 0x182DC8D10
	public void set_showBorder(bool value) { }

	// RVA: 0x2DC8790 Offset: 0x2DC7190 VA: 0x182DC8790
	public bool get_reorderable() { }

	// RVA: 0x2DC8BB0 Offset: 0x2DC75B0 VA: 0x182DC8BB0
	public void set_reorderable(bool value) { }

	// RVA: 0x2DC8AC0 Offset: 0x2DC74C0 VA: 0x182DC8AC0
	public void set_horizontalScrollingEnabled(bool value) { }

	// RVA: 0x2DC89B0 Offset: 0x2DC73B0 VA: 0x182DC89B0
	public AlternatingRowBackground get_showAlternatingRowBackgrounds() { }

	// RVA: 0x2DC8CF0 Offset: 0x2DC76F0 VA: 0x182DC8CF0
	public void set_showAlternatingRowBackgrounds(AlternatingRowBackground value) { }

	// RVA: 0xE45CE0 Offset: 0xE446E0 VA: 0x180E45CE0
	public CollectionVirtualizationMethod get_virtualizationMethod() { }

	// RVA: 0x2DC8DA0 Offset: 0x2DC77A0 VA: 0x182DC8DA0
	public void set_virtualizationMethod(CollectionVirtualizationMethod value) { }

	// RVA: 0x2DC8740 Offset: 0x2DC7140 VA: 0x182DC8740
	public float get_fixedItemHeight() { }

	// RVA: 0x2DC89C0 Offset: 0x2DC73C0 VA: 0x182DC89C0
	public void set_fixedItemHeight(float value) { }

	// RVA: 0x2DC8780 Offset: 0x2DC7180 VA: 0x182DC8780
	internal float get_lastHeight() { }

	// RVA: 0x2DC35C0 Offset: 0x2DC1FC0 VA: 0x182DC35C0 Slot: 104
	internal virtual void CreateVirtualizationController() { }

	// RVA: 0x2DC4110 Offset: 0x2DC2B10 VA: 0x182DC4110
	internal CollectionVirtualizationController GetOrCreateVirtualizationController() { }

	// RVA: -1 Offset: -1
	internal void CreateVirtualizationController<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE585F0 Offset: 0xE56FF0 VA: 0x180E585F0
	|-BaseVerticalCollectionView.CreateVirtualizationController<object>
	*/

	// RVA: 0x2DC40B0 Offset: 0x2DC2AB0 VA: 0x182DC40B0
	internal CollectionViewController GetOrCreateViewController() { }

	// RVA: -1 Offset: -1 Slot: 105
	protected abstract CollectionViewController CreateViewController();

	// RVA: 0x2DC74B0 Offset: 0x2DC5EB0 VA: 0x182DC74B0 Slot: 106
	public virtual void SetViewController(CollectionViewController controller) { }

	// RVA: 0x2DC3560 Offset: 0x2DC1F60 VA: 0x182DC3560 Slot: 107
	internal virtual ListViewDragger CreateDragger() { }

	// RVA: 0x2DC42A0 Offset: 0x2DC2CA0 VA: 0x182DC42A0
	internal void InitializeDragAndDropController(bool enableReordering) { }

	// RVA: -1 Offset: -1 Slot: 108
	internal abstract ICollectionDragAndDropController CreateDragAndDropController();

	// RVA: 0x2DC7D10 Offset: 0x2DC6710 VA: 0x182DC7D10
	public void .ctor() { }

	// RVA: 0x2DC85B0 Offset: 0x2DC6FB0 VA: 0x182DC85B0
	public void .ctor(IList itemsSource, float itemHeight = -1) { }

	// RVA: 0x2DC4150 Offset: 0x2DC2B50 VA: 0x182DC4150
	public VisualElement GetRootElementForId(int id) { }

	// RVA: 0x2DC4260 Offset: 0x2DC2C60 VA: 0x182DC4260 Slot: 109
	internal virtual bool HasValidDataAndBindings() { }

	// RVA: 0x2DC4EF0 Offset: 0x2DC38F0 VA: 0x182DC4EF0
	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x2DC4F30 Offset: 0x2DC3930 VA: 0x182DC4F30
	private void OnItemsSourceChanged() { }

	// RVA: 0x2DC5EE0 Offset: 0x2DC48E0 VA: 0x182DC5EE0
	public void RefreshItems() { }

	// RVA: 0x2DC5D30 Offset: 0x2DC4730 VA: 0x182DC5D30
	public void Rebuild() { }

	// RVA: 0x2DC6B50 Offset: 0x2DC5550 VA: 0x182DC6B50
	internal void ScheduleRebuild() { }

	// RVA: 0x2DC60C0 Offset: 0x2DC4AC0 VA: 0x182DC60C0
	private void RefreshSelection() { }

	// RVA: 0x2DC5370 Offset: 0x2DC3D70 VA: 0x182DC5370 Slot: 110
	internal virtual void PostRefresh() { }

	// RVA: 0x2DC6D10 Offset: 0x2DC5710 VA: 0x182DC6D10
	public void ScrollToItem(int index) { }

	// RVA: 0x2DC6C70 Offset: 0x2DC5670 VA: 0x182DC6C70
	public void ScrollToItemById(int id) { }

	// RVA: 0x2DC5200 Offset: 0x2DC3C00 VA: 0x182DC5200
	private void OnScroll(Vector2 offset) { }

	// RVA: 0x2DC6A70 Offset: 0x2DC5470 VA: 0x182DC6A70
	private void Resize(Vector2 size) { }

	// RVA: 0x2DC4730 Offset: 0x2DC3130 VA: 0x182DC4730
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x2DC4C30 Offset: 0x2DC3630 VA: 0x182DC4C30
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x2DC2B90 Offset: 0x2DC1590 VA: 0x182DC2B90
	private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey) { }

	// RVA: 0x2DC3070 Offset: 0x2DC1A70 VA: 0x182DC3070
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0xF32510 Offset: 0xF30F10 VA: 0x180F32510 Slot: 111
	internal virtual bool HandleItemNavigation(bool moveIn, bool altKey) { }

	// RVA: 0x2DC50A0 Offset: 0x2DC3AA0 VA: 0x182DC50A0
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x2DC4FC0 Offset: 0x2DC39C0 VA: 0x182DC4FC0
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x2DC4F50 Offset: 0x2DC3950 VA: 0x182DC4F50
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x2DC5120 Offset: 0x2DC3B20 VA: 0x182DC5120
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x2DC5430 Offset: 0x2DC3E30 VA: 0x182DC5430
	private void ProcessPointerDown(IPointerEvent evt) { }

	// RVA: 0x2DC5690 Offset: 0x2DC4090 VA: 0x182DC5690
	private void ProcessPointerUp(IPointerEvent evt) { }

	// RVA: 0x2DC37C0 Offset: 0x2DC21C0 VA: 0x182DC37C0
	private void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey) { }

	// RVA: 0x2DC3600 Offset: 0x2DC2000 VA: 0x182DC3600
	internal void DoRangeSelection(int rangeSelectionFinalIndex) { }

	// RVA: 0x2DC5A10 Offset: 0x2DC4410 VA: 0x182DC5A10
	private void ProcessSingleClick(int clickedIndex) { }

	// RVA: 0x2DC6D90 Offset: 0x2DC5790 VA: 0x182DC6D90
	internal void SelectAll() { }

	// RVA: 0x2DC2900 Offset: 0x2DC1300 VA: 0x182DC2900
	public void AddToSelection(int index) { }

	// RVA: 0x2DC2970 Offset: 0x2DC1370 VA: 0x182DC2970
	internal void AddToSelection(IList<int> indexes) { }

	// RVA: 0x2DC2610 Offset: 0x2DC1010 VA: 0x182DC2610
	private void AddToSelectionWithoutValidation(int index) { }

	// RVA: 0x2DC6A10 Offset: 0x2DC5410 VA: 0x182DC6A10
	public void RemoveFromSelection(int index) { }

	// RVA: 0x2DC66A0 Offset: 0x2DC50A0 VA: 0x182DC66A0
	private void RemoveFromSelectionWithoutValidation(int index) { }

	// RVA: 0x2DC7420 Offset: 0x2DC5E20 VA: 0x182DC7420
	public void SetSelection(int index) { }

	// RVA: 0x2DC7410 Offset: 0x2DC5E10 VA: 0x182DC7410
	public void SetSelection(IEnumerable<int> indices) { }

	// RVA: 0x2DC7400 Offset: 0x2DC5E00 VA: 0x182DC7400
	public void SetSelectionWithoutNotify(IEnumerable<int> indices) { }

	// RVA: 0x2DC7080 Offset: 0x2DC5A80 VA: 0x182DC7080
	internal void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification) { }

	// RVA: 0x2DC43D0 Offset: 0x2DC2DD0 VA: 0x182DC43D0
	private bool MatchesExistingSelection(IEnumerable<int> indices) { }

	// RVA: 0x2DC46A0 Offset: 0x2DC30A0 VA: 0x182DC46A0
	private void NotifyOfSelectionChange() { }

	// RVA: 0x2DC34D0 Offset: 0x2DC1ED0 VA: 0x182DC34D0
	public void ClearSelection() { }

	// RVA: 0x2DC3210 Offset: 0x2DC1C10 VA: 0x182DC3210
	private void ClearSelectionWithoutValidation() { }

	// RVA: 0x2DC5320 Offset: 0x2DC3D20 VA: 0x182DC5320 Slot: 96
	internal override void OnViewDataReady() { }

	[EventInterest(new[] { typeof(PointerUpEvent), typeof(FocusEvent), typeof(NavigationSubmitEvent), typeof(BlurEvent) })]
	// RVA: 0x2DC3CF0 Offset: 0x2DC26F0 VA: 0x182DC3CF0 Slot: 12
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x2DC5280 Offset: 0x2DC3C80 VA: 0x182DC5280
	private void OnSizeChanged(GeometryChangedEvent evt) { }

	// RVA: 0x2DC4A80 Offset: 0x2DC3480 VA: 0x182DC4A80
	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 102
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2DC77E0 Offset: 0x2DC61E0 VA: 0x182DC77E0 Slot: 103
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2DC7820 Offset: 0x2DC6220 VA: 0x182DC7820
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2DC7750 Offset: 0x2DC6150 VA: 0x182DC7750
	private void <.ctor>b__159_0(float v) { }

	[CompilerGenerated]
	// RVA: 0x2DC76D0 Offset: 0x2DC60D0 VA: 0x182DC76D0
	private void <RefreshSelection>g__NotifyIfChanged|172_0(ref BaseVerticalCollectionView.<>c__DisplayClass172_0 ) { }

	[CompilerGenerated]
	// RVA: 0x2DC75C0 Offset: 0x2DC5FC0 VA: 0x182DC75C0
	private void <Apply>g__HandleSelectionAndScroll|183_0(int index, ref BaseVerticalCollectionView.<>c__DisplayClass183_0 ) { }
}
