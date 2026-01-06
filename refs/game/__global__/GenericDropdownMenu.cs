public class GenericDropdownMenu : IGenericMenu // TypeDefIndex: 6303
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string itemUssClassName; // 0x8
	public static readonly string labelUssClassName; // 0x10
	public static readonly string containerInnerUssClassName; // 0x18
	public static readonly string containerOuterUssClassName; // 0x20
	public static readonly string checkmarkUssClassName; // 0x28
	public static readonly string separatorUssClassName; // 0x30
	private List<GenericDropdownMenu.MenuItem> m_Items; // 0x10
	private VisualElement m_MenuContainer; // 0x18
	private VisualElement m_OuterContainer; // 0x20
	private ScrollView m_ScrollView; // 0x28
	private VisualElement m_PanelRootVisualContainer; // 0x30
	private VisualElement m_TargetElement; // 0x38
	private Rect m_DesiredRect; // 0x40
	private KeyboardNavigationManipulator m_NavigationManipulator; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isSingleSelectionDropdown>k__BackingField; // 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <closeOnParentResize>k__BackingField; // 0x59
	private Vector2 m_MousePosition; // 0x5C

	// Properties
	internal bool isSingleSelectionDropdown { get; set; }
	internal bool closeOnParentResize { get; set; }
	public VisualElement contentContainer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	internal bool get_isSingleSelectionDropdown() { }

	[CompilerGenerated]
	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	internal void set_isSingleSelectionDropdown(bool value) { }

	[CompilerGenerated]
	// RVA: 0x79D110 Offset: 0x79BB10 VA: 0x18079D110
	internal bool get_closeOnParentResize() { }

	[CompilerGenerated]
	// RVA: 0x79D240 Offset: 0x79BC40 VA: 0x18079D240
	internal void set_closeOnParentResize(bool value) { }

	// RVA: 0x2DD1C00 Offset: 0x2DD0600 VA: 0x182DD1C00
	public VisualElement get_contentContainer() { }

	// RVA: 0x2DD18D0 Offset: 0x2DD02D0 VA: 0x182DD18D0
	public void .ctor() { }

	// RVA: 0x2DD0680 Offset: 0x2DCF080 VA: 0x182DD0680
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x2DD0A40 Offset: 0x2DCF440 VA: 0x182DD0A40
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x2DD05C0 Offset: 0x2DCEFC0 VA: 0x182DD05C0
	private void Hide(bool giveFocusBack = False) { }

	// RVA: 0x2DCF210 Offset: 0x2DCDC10 VA: 0x182DCF210
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0x2DCEED0 Offset: 0x2DCD8D0 VA: 0x182DCEED0
	private bool Apply(KeyboardNavigationOperation op) { }

	// RVA: 0x2DD0EE0 Offset: 0x2DCF8E0 VA: 0x182DD0EE0
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x2DD1050 Offset: 0x2DCFA50 VA: 0x182DD1050
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x2DD11C0 Offset: 0x2DCFBC0 VA: 0x182DD11C0
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x2DD0D60 Offset: 0x2DCF760 VA: 0x182DD0D60
	private void OnFocusOut(FocusOutEvent evt) { }

	// RVA: 0x2DD0EC0 Offset: 0x2DCF8C0 VA: 0x182DD0EC0
	private void OnParentResized(GeometryChangedEvent evt) { }

	// RVA: 0x2DD14F0 Offset: 0x2DCFEF0 VA: 0x182DD14F0
	private void UpdateSelection(VisualElement target) { }

	// RVA: 0x2DCF250 Offset: 0x2DCDC50 VA: 0x182DCF250
	private void ChangeSelectedIndex(int newIndex, int previousIndex) { }

	// RVA: 0x2DD0520 Offset: 0x2DCEF20 VA: 0x182DD0520
	private int GetSelectedIndex() { }

	// RVA: 0x2DCE940 Offset: 0x2DCD340 VA: 0x182DCE940 Slot: 4
	public void AddItem(string itemName, bool isChecked, Action action) { }

	// RVA: 0x2DCEDC0 Offset: 0x2DCD7C0 VA: 0x182DCEDC0 Slot: 5
	public void AddItem(string itemName, bool isChecked, Action<object> action, object data) { }

	// RVA: 0x2DCEE10 Offset: 0x2DCD810 VA: 0x182DCEE10 Slot: 7
	public void AddSeparator(string path) { }

	// RVA: 0x2DCE980 Offset: 0x2DCD380 VA: 0x182DCE980
	private GenericDropdownMenu.MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data) { }

	// RVA: 0x2DCF380 Offset: 0x2DCDD80 VA: 0x182DCF380 Slot: 6
	public void DropDown(Rect position, VisualElement targetElement, bool anchored = False) { }

	// RVA: 0x2DD1320 Offset: 0x2DCFD20 VA: 0x182DD1320
	private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x2DD0A30 Offset: 0x2DCF430 VA: 0x182DD0A30
	private void OnContainerGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x2DCFE50 Offset: 0x2DCE850 VA: 0x182DCFE50
	private void EnsureVisibilityInParent() { }

	// RVA: 0x2DD1650 Offset: 0x2DD0050 VA: 0x182DD1650
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2DD1390 Offset: 0x2DCFD90 VA: 0x182DD1390
	private void <Apply>g__UpdateSelectionDown|39_0(int newIndex, ref GenericDropdownMenu.<>c__DisplayClass39_0 ) { }

	[CompilerGenerated]
	// RVA: 0x2DD1440 Offset: 0x2DCFE40 VA: 0x182DD1440
	private void <Apply>g__UpdateSelectionUp|39_1(int newIndex, ref GenericDropdownMenu.<>c__DisplayClass39_0 ) { }
}
