public class Column // TypeDefIndex: 6357
{
	// Fields
	private static readonly string k_InvalidTemplateError; // 0x0
	private string m_Name; // 0x10
	private string m_Title; // 0x18
	private Background m_Icon; // 0x20
	private bool m_Visible; // 0x40
	private Length m_Width; // 0x44
	private Length m_MinWidth; // 0x4C
	private Length m_MaxWidth; // 0x54
	private float m_DesiredWidth; // 0x5C
	private bool m_Stretchable; // 0x60
	private bool m_Sortable; // 0x61
	private bool m_Optional; // 0x62
	private bool m_Resizable; // 0x63
	private Func<VisualElement> m_MakeHeader; // 0x68
	private Action<VisualElement> m_BindHeader; // 0x70
	private Action<VisualElement> m_UnbindHeader; // 0x78
	private Action<VisualElement> m_DestroyHeader; // 0x80
	private Func<VisualElement> m_MakeCell; // 0x88
	private Action<VisualElement, int> m_BindCell; // 0x90
	private Action<VisualElement, int> m_UnbindCellItem; // 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<VisualElement> <destroyCell>k__BackingField; // 0xA0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Columns <collection>k__BackingField; // 0xA8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<Column, ColumnDataType> changed; // 0xB0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<Column> resized; // 0xB8

	// Properties
	public string name { get; set; }
	public string title { get; set; }
	public Background icon { get; }
	internal int index { get; }
	internal int displayIndex { get; }
	internal int visibleIndex { get; }
	public bool visible { get; set; }
	public Length width { get; set; }
	public Length minWidth { get; set; }
	public Length maxWidth { get; set; }
	internal float desiredWidth { get; set; }
	public bool sortable { get; set; }
	public bool stretchable { get; set; }
	public bool optional { get; set; }
	public bool resizable { get; set; }
	public Func<VisualElement> makeHeader { get; set; }
	public Action<VisualElement> bindHeader { get; }
	public Action<VisualElement> unbindHeader { get; }
	public Action<VisualElement> destroyHeader { get; }
	public Func<VisualElement> makeCell { get; set; }
	public Action<VisualElement, int> bindCell { get; }
	public Action<VisualElement, int> unbindCell { get; }
	public Action<VisualElement> destroyCell { get; }
	public Columns collection { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_name() { }

	// RVA: 0x2E5D070 Offset: 0x2E5BA70 VA: 0x182E5D070
	public void set_name(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_title() { }

	// RVA: 0x2E5D1D0 Offset: 0x2E5BBD0 VA: 0x182E5D1D0
	public void set_title(string value) { }

	// RVA: 0x2E5CB50 Offset: 0x2E5B550 VA: 0x182E5CB50
	public Background get_icon() { }

	// RVA: 0x2E5CB70 Offset: 0x2E5B570 VA: 0x182E5CB70
	internal int get_index() { }

	// RVA: 0x2E5CAA0 Offset: 0x2E5B4A0 VA: 0x182E5CAA0
	internal int get_displayIndex() { }

	// RVA: 0x2E5CC70 Offset: 0x2E5B670 VA: 0x182E5CC70
	internal int get_visibleIndex() { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_visible() { }

	// RVA: 0x2E5D230 Offset: 0x2E5BC30 VA: 0x182E5D230
	public void set_visible(bool value) { }

	// RVA: 0x2E5CD20 Offset: 0x2E5B720 VA: 0x182E5CD20
	public Length get_width() { }

	// RVA: 0x2E5D270 Offset: 0x2E5BC70 VA: 0x182E5D270
	public void set_width(Length value) { }

	// RVA: 0x1D14A20 Offset: 0x1D13420 VA: 0x181D14A20
	public Length get_minWidth() { }

	// RVA: 0x2E5D010 Offset: 0x2E5BA10 VA: 0x182E5D010
	public void set_minWidth(Length value) { }

	// RVA: 0x2E5CC60 Offset: 0x2E5B660 VA: 0x182E5CC60
	public Length get_maxWidth() { }

	// RVA: 0x2E5CFB0 Offset: 0x2E5B9B0 VA: 0x182E5CFB0
	public void set_maxWidth(Length value) { }

	// RVA: 0x4B5C00 Offset: 0x4B4600 VA: 0x1804B5C00
	internal float get_desiredWidth() { }

	// RVA: 0x2E5CEB0 Offset: 0x2E5B8B0 VA: 0x182E5CEB0
	internal void set_desiredWidth(float value) { }

	// RVA: 0x848340 Offset: 0x846D40 VA: 0x180848340
	public bool get_sortable() { }

	// RVA: 0x2E5D150 Offset: 0x2E5BB50 VA: 0x182E5D150
	public void set_sortable(bool value) { }

	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_stretchable() { }

	// RVA: 0x2E5D190 Offset: 0x2E5BB90 VA: 0x182E5D190
	public void set_stretchable(bool value) { }

	// RVA: 0xD7FDD0 Offset: 0xD7E7D0 VA: 0x180D7FDD0
	public bool get_optional() { }

	// RVA: 0x2E5D0D0 Offset: 0x2E5BAD0 VA: 0x182E5D0D0
	public void set_optional(bool value) { }

	// RVA: 0xD7FDF0 Offset: 0xD7E7F0 VA: 0x180D7FDF0
	public bool get_resizable() { }

	// RVA: 0x2E5D110 Offset: 0x2E5BB10 VA: 0x182E5D110
	public void set_resizable(bool value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Func<VisualElement> get_makeHeader() { }

	// RVA: 0x2E5CF50 Offset: 0x2E5B950 VA: 0x182E5CF50
	public void set_makeHeader(Func<VisualElement> value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public Action<VisualElement> get_bindHeader() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public Action<VisualElement> get_unbindHeader() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public Action<VisualElement> get_destroyHeader() { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public Func<VisualElement> get_makeCell() { }

	// RVA: 0x2E5CEE0 Offset: 0x2E5B8E0 VA: 0x182E5CEE0
	public void set_makeCell(Func<VisualElement> value) { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public Action<VisualElement, int> get_bindCell() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public Action<VisualElement, int> get_unbindCell() { }

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public Action<VisualElement> get_destroyCell() { }

	[CompilerGenerated]
	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public Columns get_collection() { }

	[CompilerGenerated]
	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	internal void set_collection(Columns value) { }

	[CompilerGenerated]
	// RVA: 0x2E5C920 Offset: 0x2E5B320 VA: 0x182E5C920
	internal void add_changed(Action<Column, ColumnDataType> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5CD30 Offset: 0x2E5B730 VA: 0x182E5CD30
	internal void remove_changed(Action<Column, ColumnDataType> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5C9E0 Offset: 0x2E5B3E0 VA: 0x182E5C9E0
	internal void add_resized(Action<Column> value) { }

	[CompilerGenerated]
	// RVA: 0x2E5CDF0 Offset: 0x2E5B7F0 VA: 0x182E5CDF0
	internal void remove_resized(Action<Column> value) { }

	// RVA: 0x2E5C810 Offset: 0x2E5B210 VA: 0x182E5C810
	private void NotifyChange(ColumnDataType type) { }

	// RVA: 0x2E5C7E0 Offset: 0x2E5B1E0 VA: 0x182E5C7E0
	internal float GetWidth(float layoutWidth) { }

	// RVA: 0x2E5C780 Offset: 0x2E5B180 VA: 0x182E5C780
	internal float GetMaxWidth(float layoutWidth) { }

	// RVA: 0x2E5C7B0 Offset: 0x2E5B1B0 VA: 0x182E5C7B0
	internal float GetMinWidth(float layoutWidth) { }

	// RVA: 0x2E5C8B0 Offset: 0x2E5B2B0 VA: 0x182E5C8B0
	public void .ctor() { }

	// RVA: 0x2E5C840 Offset: 0x2E5B240 VA: 0x182E5C840
	private static void .cctor() { }
}
