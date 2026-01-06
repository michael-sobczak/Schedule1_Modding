internal class ColumnLayout // TypeDefIndex: 6360
{
	// Fields
	private List<Column> m_StretchableColumns; // 0x10
	private List<Column> m_FixedColumns; // 0x18
	private List<Column> m_RelativeWidthColumns; // 0x20
	private List<Column> m_MixedWidthColumns; // 0x28
	private Columns m_Columns; // 0x30
	private float m_ColumnsWidth; // 0x38
	private bool m_ColumnsWidthDirty; // 0x3C
	private float m_MaxColumnsWidth; // 0x40
	private float m_MinColumnsWidth; // 0x44
	private bool m_IsDirty; // 0x48
	private float m_PreviousWidth; // 0x4C
	private float m_LayoutWidth; // 0x50
	private bool m_DragResizeInPreviewMode; // 0x54
	private bool m_DragResizing; // 0x55
	private float m_DragStartPos; // 0x58
	private float m_DragLastPos; // 0x5C
	private float m_DragInitialColumnWidth; // 0x60
	private List<Column> m_DragStretchableColumns; // 0x68
	private List<Column> m_DragRelativeColumns; // 0x70
	private List<Column> m_DragFixedColumns; // 0x78
	private Dictionary<Column, float> m_PreviewDesiredWidths; // 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action layoutRequested; // 0x88

	// Properties
	public Columns columns { get; }
	public float columnsWidth { get; }
	public float layoutWidth { get; }
	public float minColumnsWidth { get; }
	public float maxColumnsWidth { get; }
	public bool hasStretchableColumns { get; }
	public bool hasRelativeWidthColumns { get; }

	// Methods

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Columns get_columns() { }

	// RVA: 0x2E5C420 Offset: 0x2E5AE20 VA: 0x182E5C420
	public float get_columnsWidth() { }

	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_layoutWidth() { }

	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_minColumnsWidth() { }

	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_maxColumnsWidth() { }

	// RVA: 0x2E5C680 Offset: 0x2E5B080 VA: 0x182E5C680
	public bool get_hasStretchableColumns() { }

	// RVA: 0x2E5C620 Offset: 0x2E5B020 VA: 0x182E5C620
	public bool get_hasRelativeWidthColumns() { }

	[CompilerGenerated]
	// RVA: 0x2E5C370 Offset: 0x2E5AD70 VA: 0x182E5C370
	public void add_layoutRequested(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2E5C6D0 Offset: 0x2E5B0D0 VA: 0x182E5C6D0
	public void remove_layoutRequested(Action value) { }

	// RVA: 0x2E5BF30 Offset: 0x2E5A930 VA: 0x182E5BF30
	public void .ctor(Columns columns) { }

	// RVA: 0x2E576A0 Offset: 0x2E560A0 VA: 0x182E576A0
	public void Dirty() { }

	// RVA: 0x2E59780 Offset: 0x2E58180 VA: 0x182E59780
	private void OnColumnAdded(Column column, int index) { }

	// RVA: 0x2E598F0 Offset: 0x2E582F0 VA: 0x182E598F0
	private void OnColumnRemoved(Column column) { }

	// RVA: 0x2E576A0 Offset: 0x2E560A0 VA: 0x182E576A0
	private void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x2E5ADA0 Offset: 0x2E597A0 VA: 0x182E5ADA0
	private bool RequiresLayoutUpdate(ColumnDataType type) { }

	// RVA: 0x2E59890 Offset: 0x2E58290 VA: 0x182E59890
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x2E59A00 Offset: 0x2E58400 VA: 0x182E59A00
	private void OnColumnResized(Column column) { }

	// RVA: 0x2E59770 Offset: 0x2E58170 VA: 0x182E59770
	private static bool IsClamped(float value, float min, float max) { }

	// RVA: 0x2E57D90 Offset: 0x2E56790 VA: 0x182E57D90
	public void DoLayout(float width) { }

	// RVA: 0x2E5B7C0 Offset: 0x2E5A1C0 VA: 0x182E5B7C0
	public void StretchResizeColumns(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x2E57A80 Offset: 0x2E56480 VA: 0x182E57A80
	private void DistributeOverflow(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x2E576E0 Offset: 0x2E560E0 VA: 0x182E576E0
	private void DistributeExcess(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x2E59E90 Offset: 0x2E58890 VA: 0x182E59E90
	private float RecomputeToMaxWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = False) { }

	// RVA: 0x2E5A650 Offset: 0x2E59050 VA: 0x182E5A650
	private float RecomputeToMinWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = False) { }

	// RVA: 0x2E59D30 Offset: 0x2E58730 VA: 0x182E59D30
	private float RecomputeToDesiredWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	// RVA: 0x2E59A10 Offset: 0x2E58410 VA: 0x182E59A10
	private float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	// RVA: 0x2E5AB20 Offset: 0x2E59520 VA: 0x182E5AB20
	private float RecomputeToMinWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = False) { }

	// RVA: 0x2E5A3B0 Offset: 0x2E58DB0 VA: 0x182E5A3B0
	private float RecomputeToMaxWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = False) { }

	// RVA: 0x2E5AF40 Offset: 0x2E59940 VA: 0x182E5AF40
	public void ResizeToFit(float width) { }

	// RVA: 0x2E5ADC0 Offset: 0x2E597C0 VA: 0x182E5ADC0
	private void ResizeColumn(Column column, float width, bool setDesiredWidthOnly = False) { }

	// RVA: 0x2E572F0 Offset: 0x2E55CF0 VA: 0x182E572F0
	internal void BeginDragResize(Column column, float pos, bool previewMode) { }

	// RVA: 0x2E59580 Offset: 0x2E57F80 VA: 0x182E59580
	public float GetDesiredPosition(Column column) { }

	// RVA: 0x2E596D0 Offset: 0x2E580D0 VA: 0x182E596D0
	public float GetDesiredWidth(Column c) { }

	// RVA: 0x2E58E30 Offset: 0x2E57830 VA: 0x182E58E30
	public void DragResize(Column column, float pos) { }

	// RVA: 0x2E59330 Offset: 0x2E57D30 VA: 0x182E59330
	internal void EndDragResize(Column column, bool cancelled) { }

	// RVA: 0x2E5B990 Offset: 0x2E5A390 VA: 0x182E5B990
	private void UpdateCache() { }

	// RVA: 0x2E5BCE0 Offset: 0x2E5A6E0 VA: 0x182E5BCE0
	private void UpdateMinAndMaxColumnsWidth() { }

	// RVA: 0x2E575E0 Offset: 0x2E55FE0 VA: 0x182E575E0
	private void ClearCache() { }

	[CompilerGenerated]
	// RVA: 0x2E5B890 Offset: 0x2E5A290 VA: 0x182E5B890
	private int <DoLayout>b__49_0(Column c1, Column c2) { }

	[CompilerGenerated]
	// RVA: 0x2E5B890 Offset: 0x2E5A290 VA: 0x182E5B890
	private int <DoLayout>b__49_1(Column c1, Column c2) { }

	[CompilerGenerated]
	// RVA: 0x2E5B890 Offset: 0x2E5A290 VA: 0x182E5B890
	private int <RecomputeToMaxWidthProportionally>b__53_0(Column c1, Column c2) { }

	[CompilerGenerated]
	// RVA: 0x2E5B910 Offset: 0x2E5A310 VA: 0x182E5B910
	private int <RecomputeToMinWidthProportionally>b__54_0(Column c1, Column c2) { }
}
