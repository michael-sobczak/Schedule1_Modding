public class TwoPaneSplitView : VisualElement // TypeDefIndex: 6434
{
	// Fields
	private static readonly string s_UssClassName; // 0x0
	private static readonly string s_ContentContainerClassName; // 0x8
	private static readonly string s_HandleDragLineClassName; // 0x10
	private static readonly string s_HandleDragLineVerticalClassName; // 0x18
	private static readonly string s_HandleDragLineHorizontalClassName; // 0x20
	private static readonly string s_HandleDragLineAnchorClassName; // 0x28
	private static readonly string s_HandleDragLineAnchorVerticalClassName; // 0x30
	private static readonly string s_HandleDragLineAnchorHorizontalClassName; // 0x38
	private static readonly string s_VerticalClassName; // 0x40
	private static readonly string s_HorizontalClassName; // 0x48
	private VisualElement m_LeftPane; // 0x3C8
	private VisualElement m_RightPane; // 0x3D0
	private VisualElement m_FixedPane; // 0x3D8
	private VisualElement m_FlexedPane; // 0x3E0
	[SerializeField]
	private float m_FixedPaneDimension; // 0x3E8
	private VisualElement m_DragLine; // 0x3F0
	private VisualElement m_DragLineAnchor; // 0x3F8
	private bool m_CollapseMode; // 0x400
	private bool m_CollapseChildCalledBeforeSetupComplete; // 0x401
	private int m_CollapsedChildIndex; // 0x404
	private VisualElement m_Content; // 0x408
	private TwoPaneSplitViewOrientation m_Orientation; // 0x410
	private int m_FixedPaneIndex; // 0x414
	private float m_FixedPaneInitialDimension; // 0x418
	internal TwoPaneSplitViewResizer m_Resizer; // 0x420

	// Properties
	public VisualElement fixedPane { get; }
	public VisualElement flexedPane { get; }
	internal VisualElement dragLine { get; }
	public int fixedPaneIndex { get; }
	public TwoPaneSplitViewOrientation orientation { get; }
	internal float fixedPaneDimension { get; set; }
	public override VisualElement contentContainer { get; }

	// Methods

	// RVA: 0x67A290 Offset: 0x678C90 VA: 0x18067A290
	public VisualElement get_fixedPane() { }

	// RVA: 0x67A250 Offset: 0x678C50 VA: 0x18067A250
	public VisualElement get_flexedPane() { }

	// RVA: 0x2E4C9D0 Offset: 0x2E4B3D0 VA: 0x182E4C9D0
	internal VisualElement get_dragLine() { }

	// RVA: 0x2E83080 Offset: 0x2E81A80 VA: 0x182E83080
	public int get_fixedPaneIndex() { }

	// RVA: 0x2E83090 Offset: 0x2E81A90 VA: 0x182E83090
	public TwoPaneSplitViewOrientation get_orientation() { }

	// RVA: 0x2E83040 Offset: 0x2E81A40 VA: 0x182E83040
	internal float get_fixedPaneDimension() { }

	// RVA: 0x2E830A0 Offset: 0x2E81AA0 VA: 0x182E830A0
	internal void set_fixedPaneDimension(float value) { }

	// RVA: 0x2E82DA0 Offset: 0x2E817A0 VA: 0x182E82DA0
	public void .ctor() { }

	// RVA: 0x2E800F0 Offset: 0x2E7EAF0 VA: 0x182E800F0
	public void CollapseChild(int index) { }

	// RVA: 0x2E80570 Offset: 0x2E7EF70 VA: 0x182E80570
	internal void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation) { }

	// RVA: 0x2E80A30 Offset: 0x2E7F430 VA: 0x182E80A30
	private void OnPostDisplaySetup(GeometryChangedEvent evt) { }

	// RVA: 0x2E81E10 Offset: 0x2E80810 VA: 0x182E81E10
	private void ReplacePanesBasedOnAnchor() { }

	// RVA: 0x2E809B0 Offset: 0x2E7F3B0 VA: 0x182E809B0
	private void OnAnchorPostDisplaySetup(GeometryChangedEvent evt) { }

	// RVA: 0x2E80480 Offset: 0x2E7EE80 VA: 0x182E80480
	private void IdentifyLeftAndRightPane() { }

	// RVA: 0x2E80BA0 Offset: 0x2E7F5A0 VA: 0x182E80BA0
	private void PostDisplaySetup() { }

	// RVA: 0x2E80B50 Offset: 0x2E7F550 VA: 0x182E80B50
	private void OnSizeChange(GeometryChangedEvent evt) { }

	// RVA: 0x2E82310 Offset: 0x2E80D10 VA: 0x182E82310
	private void UpdateLayout(bool updateFixedPane, bool updateDragLine) { }

	// RVA: 0x2E83030 Offset: 0x2E81A30 VA: 0x182E83030 Slot: 99
	public override VisualElement get_contentContainer() { }

	// RVA: 0x2E80B60 Offset: 0x2E7F560 VA: 0x182E80B60 Slot: 96
	internal override void OnViewDataReady() { }

	// RVA: 0x2E81FF0 Offset: 0x2E809F0 VA: 0x182E81FF0
	private void SetDragLineOffset(float offset) { }

	// RVA: 0x2E82180 Offset: 0x2E80B80 VA: 0x182E82180
	private void SetFixedPaneDimension(float dimension) { }

	// RVA: 0x2E82AA0 Offset: 0x2E814A0 VA: 0x182E82AA0
	private static void .cctor() { }
}
