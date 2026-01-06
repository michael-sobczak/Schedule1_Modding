internal class ColumnResizer : PointerManipulator // TypeDefIndex: 7217
{
	// Fields
	private Vector2 m_Start; // 0x38
	protected bool m_Active; // 0x40
	private bool m_Resizing; // 0x41
	private MultiColumnCollectionHeader m_Header; // 0x48
	private Column m_Column; // 0x50
	private VisualElement m_PreviewElement; // 0x58
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ColumnLayout <columnLayout>k__BackingField; // 0x60
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <preview>k__BackingField; // 0x68

	// Properties
	public ColumnLayout columnLayout { get; set; }
	public bool preview { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_columnLayout(ColumnLayout value) { }

	[CompilerGenerated]
	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_preview() { }

	[CompilerGenerated]
	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	public void set_preview(bool value) { }

	// RVA: 0x2E43480 Offset: 0x2E41E80 VA: 0x182E43480
	public void .ctor(Column column) { }

	// RVA: 0x2E42F40 Offset: 0x2E41940 VA: 0x182E42F40 Slot: 5
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x2E43140 Offset: 0x2E41B40 VA: 0x182E43140 Slot: 6
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x2E42810 Offset: 0x2E41210 VA: 0x182E42810
	private void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x2E428B0 Offset: 0x2E412B0 VA: 0x182E428B0
	private void OnPointerDown(PointerDownEvent e) { }

	// RVA: 0x2E42C50 Offset: 0x2E41650 VA: 0x182E42C50
	private void OnPointerMove(PointerMoveEvent e) { }

	// RVA: 0x2E42DA0 Offset: 0x2E417A0 VA: 0x182E42DA0
	private void OnPointerUp(PointerUpEvent e) { }

	// RVA: 0x2E42700 Offset: 0x2E41100 VA: 0x182E42700
	private void BeginDragResize(float pos) { }

	// RVA: 0x2E42750 Offset: 0x2E41150 VA: 0x182E42750
	private void DragResize(float pos) { }

	// RVA: 0x2E43340 Offset: 0x2E41D40 VA: 0x182E43340
	private void UpdatePreviewPosition() { }

	// RVA: 0x2E427A0 Offset: 0x2E411A0 VA: 0x182E427A0
	private void EndDragResize(float pos, bool cancelled) { }
}
