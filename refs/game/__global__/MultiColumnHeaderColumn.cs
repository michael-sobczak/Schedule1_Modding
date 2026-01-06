internal class MultiColumnHeaderColumn : VisualElement // TypeDefIndex: 7227
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string sortableUssClassName; // 0x8
	public static readonly string sortedAscendingUssClassName; // 0x10
	public static readonly string sortedDescendingUssClassName; // 0x18
	public static readonly string movingUssClassName; // 0x20
	public static readonly string contentContainerUssClassName; // 0x28
	public static readonly string contentUssClassName; // 0x30
	public static readonly string defaultContentUssClassName; // 0x38
	public static readonly string hasIconUssClassName; // 0x40
	public static readonly string hasTitleUssClassName; // 0x48
	public static readonly string titleUssClassName; // 0x50
	public static readonly string iconElementName; // 0x58
	public static readonly string titleElementName; // 0x60
	private static readonly string s_BoundVEPropertyName; // 0x68
	private static readonly string s_BindingCallbackVEPropertyName; // 0x70
	private static readonly string s_UnbindingCallbackVEPropertyName; // 0x78
	private static readonly string s_DestroyCallbackVEPropertyName; // 0x80
	private VisualElement m_ContentContainer; // 0x3C8
	private VisualElement m_Content; // 0x3D0
	private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer; // 0x3D8
	private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate; // 0x3E0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Clickable <clickable>k__BackingField; // 0x3E8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ColumnMover <mover>k__BackingField; // 0x3F0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Column <column>k__BackingField; // 0x3F8

	// Properties
	public Clickable clickable { get; set; }
	public ColumnMover mover { get; set; }
	public string sortOrderLabel { set; }
	public Column column { get; set; }
	public VisualElement content { get; set; }
	private bool isContentBound { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2E4C8D0 Offset: 0x2E4B2D0 VA: 0x182E4C8D0
	public Clickable get_clickable() { }

	[CompilerGenerated]
	// RVA: 0x2E4C9E0 Offset: 0x2E4B3E0 VA: 0x182E4C9E0
	private void set_clickable(Clickable value) { }

	[CompilerGenerated]
	// RVA: 0x2E4C9D0 Offset: 0x2E4B3D0 VA: 0x182E4C9D0
	public ColumnMover get_mover() { }

	[CompilerGenerated]
	// RVA: 0x2338890 Offset: 0x2337290 VA: 0x182338890
	private void set_mover(ColumnMover value) { }

	// RVA: 0x2E4CD60 Offset: 0x2E4B760 VA: 0x182E4CD60
	public void set_sortOrderLabel(string value) { }

	[CompilerGenerated]
	// RVA: 0x2E4C8E0 Offset: 0x2E4B2E0 VA: 0x182E4C8E0
	public Column get_column() { }

	[CompilerGenerated]
	// RVA: 0x13E3E80 Offset: 0x13E2880 VA: 0x1813E3E80
	private void set_column(Column value) { }

	// RVA: 0x67A240 Offset: 0x678C40 VA: 0x18067A240
	public VisualElement get_content() { }

	// RVA: 0x2E4CA00 Offset: 0x2E4B400 VA: 0x182E4CA00
	public void set_content(VisualElement value) { }

	// RVA: 0x2E4C8F0 Offset: 0x2E4B2F0 VA: 0x182E4C8F0
	private bool get_isContentBound() { }

	// RVA: 0x2E4CCB0 Offset: 0x2E4B6B0 VA: 0x182E4CCB0
	private void set_isContentBound(bool value) { }

	// RVA: 0x2E4BEC0 Offset: 0x2E4A8C0 VA: 0x182E4BEC0
	public void .ctor(Column column) { }

	// RVA: 0x2E4B1F0 Offset: 0x2E49BF0 VA: 0x182E4B1F0
	private void OnColumnChanged(Column c, ColumnDataType role) { }

	// RVA: 0x2E4B310 Offset: 0x2E49D10 VA: 0x182E4B310
	private void OnColumnResized(Column c) { }

	// RVA: 0x2E4ADE0 Offset: 0x2E497E0 VA: 0x182E4ADE0
	private void InitManipulators() { }

	// RVA: 0x2E4B320 Offset: 0x2E49D20 VA: 0x182E4B320
	private void OnMoverChanged(ColumnMover mv) { }

	// RVA: 0x2E4B4B0 Offset: 0x2E49EB0 VA: 0x182E4B4B0
	private void UpdateDataFromColumn() { }

	// RVA: 0x2E4A2D0 Offset: 0x2E48CD0 VA: 0x182E4A2D0
	private void BindHeaderContent() { }

	// RVA: 0x2E4B3D0 Offset: 0x2E49DD0 VA: 0x182E4B3D0
	private void UnbindHeaderContent() { }

	// RVA: 0x2E4A9E0 Offset: 0x2E493E0 VA: 0x182E4A9E0
	private void DestroyHeaderContent() { }

	// RVA: 0x2E4A3B0 Offset: 0x2E48DB0 VA: 0x182E4A3B0
	private VisualElement CreateDefaultHeaderContent() { }

	// RVA: 0x2E4A630 Offset: 0x2E49030 VA: 0x182E4A630
	private void DefaultBindHeaderContent(VisualElement ve) { }

	// RVA: 0x2E4B6F0 Offset: 0x2E4A0F0 VA: 0x182E4B6F0
	private void UpdateHeaderTemplate() { }

	// RVA: 0x2E4B5C0 Offset: 0x2E49FC0 VA: 0x182E4B5C0
	private void UpdateGeometryFromColumn() { }

	// RVA: 0x2E4ABA0 Offset: 0x2E495A0 VA: 0x182E4ABA0
	public void Dispose() { }

	// RVA: 0x2E4B910 Offset: 0x2E4A310 VA: 0x182E4B910
	private static void .cctor() { }
}
