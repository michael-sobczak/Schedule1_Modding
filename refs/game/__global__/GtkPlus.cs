internal class GtkPlus // TypeDefIndex: 5958
{
	// Fields
	private static GtkPlus instance; // 0x0
	private readonly int WidgetTypeCount; // 0x10
	private readonly IntPtr[] widgets; // 0x18
	private readonly IntPtr window; // 0x20
	private readonly IntPtr fixed; // 0x28
	private readonly IntPtr[] styles; // 0x30
	private readonly IntPtr combo_box_drop_down_toggle_button; // 0x38
	private readonly IntPtr combo_box_drop_down_arrow; // 0x40
	private IntPtr combo_box_drop_down_toggle_button_style; // 0x48
	private IntPtr combo_box_drop_down_arrow_style; // 0x50
	private readonly IntPtr tool_bar_button; // 0x58
	private readonly IntPtr tool_bar_toggle_button; // 0x60
	private IntPtr tool_bar_button_style; // 0x68
	private IntPtr tool_bar_toggle_button_style; // 0x70
	private readonly IntPtr tree_view_column; // 0x78
	private readonly IntPtr tree_view_column_button; // 0x80
	private IntPtr tree_view_column_button_style; // 0x88
	private readonly GtkPlus.ButtonPainter button_painter; // 0x90
	private readonly GtkPlus.CheckBoxPainter check_box_painter; // 0x98
	private readonly GtkPlus.RadioButtonPainter radio_button_painter; // 0xA0
	private readonly GtkPlus.ComboBoxDropDownButtonPainter combo_box_drop_down_button_painter; // 0xA8
	private readonly GtkPlus.ComboBoxBorderPainter combo_box_border_painter; // 0xB0
	private readonly GtkPlus.GroupBoxPainter group_box_painter; // 0xB8
	private readonly GtkPlus.HeaderPainter header_painter; // 0xC0
	private readonly GtkPlus.ProgressBarBarPainter progress_bar_bar_painter; // 0xC8
	private readonly GtkPlus.ProgressBarChunkPainter progress_bar_chunk_painter; // 0xD0
	private readonly GtkPlus.ScrollBarArrowButtonPainter scroll_bar_arrow_button_painter; // 0xD8
	private readonly GtkPlus.ScrollBarThumbButtonPainter scroll_bar_thumb_button_painter; // 0xE0
	private readonly GtkPlus.ScrollBarTrackPainter scroll_bar_track_painter; // 0xE8
	private readonly GtkPlus.StatusBarGripperPainter status_bar_gripper_painter; // 0xF0
	private readonly GtkPlus.TabControlPanePainter tab_control_pane_painter; // 0xF8
	private readonly GtkPlus.TabControlTabItemPainter tab_control_tab_item_painter; // 0x100
	private readonly GtkPlus.TextBoxPainter text_box_painter; // 0x108
	private readonly GtkPlus.ToolBarPainter tool_bar_painter; // 0x110
	private readonly GtkPlus.ToolBarButtonPainter tool_bar_button_painter; // 0x118
	private readonly GtkPlus.ToolBarCheckedButtonPainter tool_bar_checked_button_painter; // 0x120
	private readonly GtkPlus.TrackBarTrackPainter track_bar_track_painter; // 0x128
	private readonly GtkPlus.TrackBarThumbPainter track_bar_thumb_painter; // 0x130
	private readonly GtkPlus.TreeViewGlyphPainter tree_view_glyph_painter; // 0x138
	private readonly GtkPlus.UpDownPainter up_down_painter; // 0x140

	// Properties
	public static GtkPlus Instance { get; }

	// Methods

	// RVA: 0x22D65C0 Offset: 0x22D4FC0 VA: 0x1822D65C0
	protected void .ctor() { }

	// RVA: 0x22D83B0 Offset: 0x22D6DB0 VA: 0x1822D83B0
	public static GtkPlus get_Instance() { }

	// RVA: 0x22D46C0 Offset: 0x22D30C0 VA: 0x1822D46C0
	public static bool Initialize() { }

	// RVA: 0x22D3B20 Offset: 0x22D2520 VA: 0x1822D3B20 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x22D3620 Offset: 0x22D2020 VA: 0x1822D3620
	public void ButtonPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, bool default, GtkPlusState state) { }

	// RVA: 0x22D3770 Offset: 0x22D2170 VA: 0x1822D3770
	public void CheckBoxPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, GtkPlusToggleButtonValue value) { }

	// RVA: 0x22D3FD0 Offset: 0x22D29D0 VA: 0x1822D3FD0
	private Size GetGtkCheckButtonIndicatorSize(GtkPlus.WidgetType widgetType) { }

	// RVA: 0x22D3760 Offset: 0x22D2160 VA: 0x1822D3760
	public Size CheckBoxGetSize() { }

	// RVA: 0x22D39E0 Offset: 0x22D23E0 VA: 0x1822D39E0
	public void ComboBoxPaintDropDownButton(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state) { }

	// RVA: 0x22D38C0 Offset: 0x22D22C0 VA: 0x1822D38C0
	public void ComboBoxPaintBorder(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea) { }

	// RVA: 0x22D4470 Offset: 0x22D2E70 VA: 0x1822D4470
	public void GroupBoxPaint(IDeviceContext dc, Rectangle bounds, Rectangle excludedArea, GtkPlusState state) { }

	// RVA: 0x22D4580 Offset: 0x22D2F80 VA: 0x1822D4580
	public void HeaderPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state) { }

	// RVA: 0x22D5500 Offset: 0x22D3F00 VA: 0x1822D5500
	public void ProgressBarPaintBar(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea) { }

	// RVA: 0x22D5620 Offset: 0x22D4020 VA: 0x1822D5620
	public void ProgressBarPaintChunk(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea) { }

	// RVA: 0x22D5750 Offset: 0x22D4150 VA: 0x1822D5750
	public void RadioButtonPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, GtkPlusToggleButtonValue value) { }

	// RVA: 0x22D5740 Offset: 0x22D4140 VA: 0x1822D5740
	public Size RadioButtonGetSize() { }

	// RVA: 0x22D58A0 Offset: 0x22D42A0 VA: 0x1822D58A0
	public void ScrollBarPaintArrowButton(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, bool horizontal, bool upOrLeft) { }

	// RVA: 0x22D5930 Offset: 0x22D4330 VA: 0x1822D5930
	public void ScrollBarPaintThumbButton(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, bool horizontal) { }

	// RVA: 0x22D59B0 Offset: 0x22D43B0 VA: 0x1822D59B0
	public void ScrollBarPaintTrack(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, bool horizontal, bool upOrLeft) { }

	// RVA: 0x22D5A40 Offset: 0x22D4440 VA: 0x1822D5A40
	public void StatusBarPaintGripper(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea) { }

	// RVA: 0x22D5B60 Offset: 0x22D4560 VA: 0x1822D5B60
	public void TabControlPaintPane(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea) { }

	// RVA: 0x22D5C80 Offset: 0x22D4680 VA: 0x1822D5C80
	public void TabControlPaintTabItem(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state) { }

	// RVA: 0x22D5DC0 Offset: 0x22D47C0 VA: 0x1822D5DC0
	public void TextBoxPaint(IDeviceContext dc, Rectangle bounds, Rectangle excludedArea, GtkPlusState state) { }

	// RVA: 0x22D6120 Offset: 0x22D4B20 VA: 0x1822D6120
	public void ToolBarPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea) { }

	// RVA: 0x22D5ED0 Offset: 0x22D48D0 VA: 0x1822D5ED0
	public void ToolBarPaintButton(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state) { }

	// RVA: 0x22D6010 Offset: 0x22D4A10 VA: 0x1822D6010
	public void ToolBarPaintCheckedButton(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea) { }

	// RVA: 0x22D62C0 Offset: 0x22D4CC0 VA: 0x1822D62C0
	public void TrackBarPaintTrack(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, bool horizontal) { }

	// RVA: 0x22D6240 Offset: 0x22D4C40 VA: 0x1822D6240
	public void TrackBarPaintThumb(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, GtkPlusState state, bool horizontal) { }

	// RVA: 0x22D6330 Offset: 0x22D4D30 VA: 0x1822D6330
	public void TreeViewPaintGlyph(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, bool closed) { }

	// RVA: 0x22D6470 Offset: 0x22D4E70 VA: 0x1822D6470
	public void UpDownPaint(IDeviceContext dc, Rectangle bounds, Rectangle clippingArea, bool up, GtkPlusState state) { }

	// RVA: 0x22D53F0 Offset: 0x22D3DF0 VA: 0x1822D53F0
	private void Paint(GtkPlus.WidgetType widgetType, Rectangle bounds, IDeviceContext dc, Rectangle clippingArea, GtkPlus.Painter painter) { }

	// RVA: 0x22D4810 Offset: 0x22D3210 VA: 0x1822D4810
	private void PaintExcludingArea(GtkPlus.WidgetType widgetType, Rectangle bounds, IDeviceContext dc, Rectangle excludedArea, GtkPlus.Painter painter) { }

	// RVA: 0x22D4CC0 Offset: 0x22D36C0 VA: 0x1822D4CC0
	private void Paint(GtkPlus.WidgetType widgetType, Rectangle bounds, IDeviceContext dc, GtkPlus.TransparencyType transparencyType, Color background, GtkPlus.DeviceContextType deviceContextType, Rectangle clippingArea, GtkPlus.Painter painter, Rectangle excludedArea) { }

	// RVA: 0x22D48F0 Offset: 0x22D32F0 VA: 0x1822D48F0
	private void Paint(IntPtr drawable, IntPtr gc, Rectangle rectangle, GtkPlus.WidgetType widgetType, out IntPtr pixbuf, out IntPtr pixelData, out int rowstride, Rectangle clippingArea, GtkPlus.Painter painter, Rectangle excludedArea) { }

	// RVA: 0x22D4260 Offset: 0x22D2C60 VA: 0x1822D4260
	private static GtkPlus.GtkShadowType GetWidgetStyleShadowType(IntPtr widget) { }

	// RVA: 0x22D41B0 Offset: 0x22D2BB0 VA: 0x1822D41B0
	private static int GetWidgetStyleInteger(IntPtr widget, string propertyName) { }

	// RVA: 0x22D4330 Offset: 0x22D2D30 VA: 0x1822D4330
	private static float GetWidgetStyleSingle(IntPtr widget, string propertyName) { }

	// RVA: 0x22D40F0 Offset: 0x22D2AF0 VA: 0x1822D40F0
	private static bool GetWidgetStyleBoolean(IntPtr widget, string propertyName) { }

	// RVA: 0x22D43F0 Offset: 0x22D2DF0 VA: 0x1822D43F0
	private static IntPtr GetWidgetStyle(IntPtr widget) { }

	// RVA: 0x22D7EA0 Offset: 0x22D68A0 VA: 0x1822D7EA0
	private static extern void gdk_draw_rectangle(IntPtr drawable, IntPtr gc, bool filled, int x, int y, int width, int height) { }

	// RVA: 0x22D7F70 Offset: 0x22D6970 VA: 0x1822D7F70
	private static extern IntPtr gdk_gc_new(IntPtr drawable) { }

	// RVA: 0x22D7FF0 Offset: 0x22D69F0 VA: 0x1822D7FF0
	private static extern void gdk_gc_set_rgb_fg_color(IntPtr gc, ref GtkPlus.GdkColor color) { }

	// RVA: 0x22D8080 Offset: 0x22D6A80 VA: 0x1822D8080
	private static extern IntPtr gdk_pixbuf_get_from_drawable(IntPtr dest, IntPtr src, IntPtr cmap, int src_x, int src_y, int dest_x, int dest_y, int width, int height) { }

	// RVA: 0x22D8310 Offset: 0x22D6D10 VA: 0x1822D8310
	private static extern IntPtr gdk_pixmap_new(IntPtr drawable, int width, int height, int depth) { }

	// RVA: 0x22D8160 Offset: 0x22D6B60 VA: 0x1822D8160
	private static extern IntPtr gdk_pixbuf_get_pixels(IntPtr pixbuf) { }

	// RVA: 0x22D81E0 Offset: 0x22D6BE0 VA: 0x1822D81E0
	private static extern int gdk_pixbuf_get_rowstride(IntPtr pixbuf) { }

	// RVA: 0x22D8260 Offset: 0x22D6C60 VA: 0x1822D8260
	private static extern IntPtr gdk_pixbuf_new(GtkPlus.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height) { }

	// RVA: 0x22D8BF0 Offset: 0x22D75F0 VA: 0x1822D8BF0
	private static extern bool gtk_init_check(ref int argc, ref string[] argv) { }

	// RVA: 0x22D86A0 Offset: 0x22D70A0 VA: 0x1822D86A0
	private static extern IntPtr gtk_check_version(uint required_major, uint required_minor, uint required_micro) { }

	// RVA: 0x22D87A0 Offset: 0x22D71A0 VA: 0x1822D87A0
	private static extern void gtk_container_add(IntPtr container, IntPtr widget) { }

	// RVA: 0x22D8830 Offset: 0x22D7230 VA: 0x1822D8830
	private static extern void gtk_container_forall(IntPtr container, GtkPlus.GtkCallback callback, IntPtr callback_data) { }

	// RVA: 0x22D8E80 Offset: 0x22D7880 VA: 0x1822D8E80
	private static extern void gtk_object_destroy(IntPtr object) { }

	// RVA: 0x22D43F0 Offset: 0x22D2DF0 VA: 0x1822D43F0
	private static extern IntPtr gtk_rc_get_style(IntPtr widget) { }

	// RVA: 0x22D9D90 Offset: 0x22D8790 VA: 0x1822D9D90
	private static extern IntPtr gtk_style_attach(IntPtr style, IntPtr window) { }

	// RVA: 0x22DA370 Offset: 0x22D8D70 VA: 0x1822DA370
	private static extern void gtk_widget_realize(IntPtr widget) { }

	// RVA: 0x22DA660 Offset: 0x22D9060 VA: 0x1822DA660
	private static extern void gtk_widget_style_get(IntPtr widget, string property, out int value, IntPtr nullTerminator) { }

	// RVA: 0x22DA3F0 Offset: 0x22D8DF0 VA: 0x1822DA3F0
	private static extern void gtk_widget_style_get(IntPtr widget, string property, out float value, IntPtr nullTerminator) { }

	// RVA: 0x22DA570 Offset: 0x22D8F70 VA: 0x1822DA570
	private static extern void gtk_widget_style_get(IntPtr widget, string property1, out int value1, string property2, out int value2, IntPtr nullTerminator) { }

	// RVA: 0x22DA4B0 Offset: 0x22D8EB0 VA: 0x1822DA4B0
	private static extern void gtk_widget_style_get(IntPtr widget, string property, out GtkPlus.GtkShadowType value, IntPtr nullTerminator) { }

	// RVA: 0x22DA720 Offset: 0x22D9120 VA: 0x1822DA720
	private static extern void gtk_widget_style_get(IntPtr widget, string property, out bool value, IntPtr nullTerminator) { }

	// RVA: 0x22DA7F0 Offset: 0x22D91F0 VA: 0x1822DA7F0
	private static extern IntPtr gtk_window_new(GtkPlus.GtkWindowType type) { }

	// RVA: 0x22DA870 Offset: 0x22D9270 VA: 0x1822DA870
	private static extern void gtk_window_set_default(IntPtr window, IntPtr default_widget) { }

	// RVA: 0x22D83F0 Offset: 0x22D6DF0 VA: 0x1822D83F0
	private static extern IntPtr gtk_adjustment_new(double value, double lower, double upper, double step_increment, double page_increment, double page_size) { }

	// RVA: 0x22DA0C0 Offset: 0x22D8AC0 VA: 0x1822DA0C0
	private static extern IntPtr gtk_tree_view_column_new() { }

	// RVA: 0x22DA130 Offset: 0x22D8B30 VA: 0x1822DA130
	private static extern int gtk_tree_view_insert_column(IntPtr tree_view, IntPtr column, int position) { }

	// RVA: 0x22D9FB0 Offset: 0x22D89B0 VA: 0x1822D9FB0
	private static extern void gtk_toolbar_insert(IntPtr toolbar, IntPtr item, int pos) { }

	// RVA: 0x22D8540 Offset: 0x22D6F40 VA: 0x1822D8540
	private static extern IntPtr gtk_bin_get_child(IntPtr bin) { }

	// RVA: 0x22D84D0 Offset: 0x22D6ED0 VA: 0x1822D84D0
	private static extern IntPtr gtk_arrow_get_type() { }

	// RVA: 0x22D88D0 Offset: 0x22D72D0 VA: 0x1822D88D0
	private static extern IntPtr gtk_container_get_type() { }

	// RVA: 0x22D9E20 Offset: 0x22D8820 VA: 0x1822D9E20
	private static extern IntPtr gtk_toggle_button_get_type() { }

	// RVA: 0x22D85C0 Offset: 0x22D6FC0 VA: 0x1822D85C0
	private static extern IntPtr gtk_button_new() { }

	// RVA: 0x22D8630 Offset: 0x22D7030 VA: 0x1822D8630
	private static extern IntPtr gtk_check_button_new() { }

	// RVA: 0x22D8730 Offset: 0x22D7130 VA: 0x1822D8730
	private static extern IntPtr gtk_combo_box_entry_new() { }

	// RVA: 0x22D8940 Offset: 0x22D7340 VA: 0x1822D8940
	private static extern IntPtr gtk_entry_new() { }

	// RVA: 0x22D89B0 Offset: 0x22D73B0 VA: 0x1822D89B0
	private static extern IntPtr gtk_fixed_new() { }

	// RVA: 0x22D8A20 Offset: 0x22D7420 VA: 0x1822D8A20
	private static extern IntPtr gtk_frame_new(string label) { }

	// RVA: 0x22D8AC0 Offset: 0x22D74C0 VA: 0x1822D8AC0
	private static extern IntPtr gtk_hscale_new_with_range(double min, double max, double step) { }

	// RVA: 0x22D8B70 Offset: 0x22D7570 VA: 0x1822D8B70
	private static extern IntPtr gtk_hscrollbar_new(IntPtr adjustment) { }

	// RVA: 0x22D8E10 Offset: 0x22D7810 VA: 0x1822D8E10
	private static extern IntPtr gtk_notebook_new() { }

	// RVA: 0x22D9B90 Offset: 0x22D8590 VA: 0x1822D9B90
	private static extern IntPtr gtk_progress_bar_new() { }

	// RVA: 0x22D9C00 Offset: 0x22D8600 VA: 0x1822D9C00
	private static extern IntPtr gtk_radio_button_new(IntPtr group) { }

	// RVA: 0x22D9C80 Offset: 0x22D8680 VA: 0x1822D9C80
	private static extern IntPtr gtk_spin_button_new(IntPtr adjustment, double climb_rate, uint digits) { }

	// RVA: 0x22D9D20 Offset: 0x22D8720 VA: 0x1822D9D20
	private static extern IntPtr gtk_statusbar_new() { }

	// RVA: 0x22D9E90 Offset: 0x22D8890 VA: 0x1822D9E90
	private static extern IntPtr gtk_toggle_tool_button_new() { }

	// RVA: 0x22DA050 Offset: 0x22D8A50 VA: 0x1822DA050
	private static extern IntPtr gtk_toolbar_new() { }

	// RVA: 0x22D9F00 Offset: 0x22D8900 VA: 0x1822D9F00
	private static extern IntPtr gtk_tool_button_new(IntPtr icon_widget, string label) { }

	// RVA: 0x22DA1D0 Offset: 0x22D8BD0 VA: 0x1822DA1D0
	private static extern IntPtr gtk_tree_view_new() { }

	// RVA: 0x22DA240 Offset: 0x22D8C40 VA: 0x1822DA240
	private static extern IntPtr gtk_vscale_new_with_range(double min, double max, double step) { }

	// RVA: 0x22DA2F0 Offset: 0x22D8CF0 VA: 0x1822DA2F0
	private static extern IntPtr gtk_vscrollbar_new(IntPtr adjustment) { }

	// RVA: 0x22D8F00 Offset: 0x22D7900 VA: 0x1822D8F00
	private static extern void gtk_paint_arrow(IntPtr style, IntPtr window, GtkPlus.GtkStateType state_type, GtkPlus.GtkShadowType shadow_type, ref GtkPlus.GdkRectangle area, IntPtr widget, string detail, GtkPlus.GtkArrowType arrow_type, bool fill, int x, int y, int width, int height) { }

	// RVA: 0x22D9170 Offset: 0x22D7B70 VA: 0x1822D9170
	private static extern void gtk_paint_box(IntPtr style, IntPtr window, GtkPlus.GtkStateType state_type, GtkPlus.GtkShadowType shadow_type, ref GtkPlus.GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height) { }

	// RVA: 0x22D9030 Offset: 0x22D7A30 VA: 0x1822D9030
	private static extern void gtk_paint_box_gap(IntPtr style, IntPtr window, GtkPlus.GtkStateType state_type, GtkPlus.GtkShadowType shadow_type, ref GtkPlus.GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height, GtkPlus.GtkPositionType gap_side, int gap_x, int gap_width) { }

	// RVA: 0x22D9290 Offset: 0x22D7C90 VA: 0x1822D9290
	private static extern void gtk_paint_check(IntPtr style, IntPtr window, GtkPlus.GtkStateType state_type, GtkPlus.GtkShadowType shadow_type, ref GtkPlus.GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height) { }

	// RVA: 0x22D93B0 Offset: 0x22D7DB0 VA: 0x1822D93B0
	private static extern void gtk_paint_expander(IntPtr style, IntPtr window, GtkPlus.GtkStateType state_type, ref GtkPlus.GdkRectangle area, IntPtr widget, string detail, int x, int y, GtkPlus.GtkExpanderStyle expander_style) { }

	// RVA: 0x22D94B0 Offset: 0x22D7EB0 VA: 0x1822D94B0
	private static extern void gtk_paint_extension(IntPtr style, IntPtr window, GtkPlus.GtkStateType state_type, GtkPlus.GtkShadowType shadow_type, ref GtkPlus.GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height, GtkPlus.GtkPositionType gap_side) { }

	// RVA: 0x22D95E0 Offset: 0x22D7FE0 VA: 0x1822D95E0
	private static extern void gtk_paint_flat_box(IntPtr style, IntPtr window, GtkPlus.GtkStateType state_type, GtkPlus.GtkShadowType shadow_type, ref GtkPlus.GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height) { }

	// RVA: 0x22D9700 Offset: 0x22D8100 VA: 0x1822D9700
	private static extern void gtk_paint_option(IntPtr style, IntPtr window, GtkPlus.GtkStateType state_type, GtkPlus.GtkShadowType shadow_type, ref GtkPlus.GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height) { }

	// RVA: 0x22D9820 Offset: 0x22D8220 VA: 0x1822D9820
	private static extern void gtk_paint_resize_grip(IntPtr style, IntPtr window, GtkPlus.GtkStateType state_type, ref GtkPlus.GdkRectangle area, IntPtr widget, string detail, GtkPlus.GdkWindowEdge edge, int x, int y, int width, int height) { }

	// RVA: 0x22D9940 Offset: 0x22D8340 VA: 0x1822D9940
	private static extern void gtk_paint_shadow(IntPtr style, IntPtr window, GtkPlus.GtkStateType state_type, GtkPlus.GtkShadowType shadow_type, ref GtkPlus.GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height) { }

	// RVA: 0x22D9A60 Offset: 0x22D8460 VA: 0x1822D9A60
	private static extern void gtk_paint_slider(IntPtr style, IntPtr window, GtkPlus.GtkStateType state_type, GtkPlus.GtkShadowType shadow_type, ref GtkPlus.GdkRectangle area, IntPtr widget, string detail, int x, int y, int width, int height, GtkPlus.GtkOrientation orientation) { }

	// RVA: 0x22D3EA0 Offset: 0x22D28A0 VA: 0x1822D3EA0
	private static void GTK_WIDGET_SET_FLAGS(IntPtr wid, GtkPlus.GtkWidgetFlags flag) { }

	// RVA: 0x22D7D10 Offset: 0x22D6710 VA: 0x1822D7D10
	private static extern IntPtr g_object_ref(IntPtr object) { }

	// RVA: 0x22D7D90 Offset: 0x22D6790 VA: 0x1822D7D90
	private static extern void g_object_unref(IntPtr object) { }

	// RVA: 0x22D7E10 Offset: 0x22D6810 VA: 0x1822D7E10
	private static extern bool g_type_check_instance_is_a(IntPtr type_instance, IntPtr iface_type) { }

	// RVA: 0x22D7C40 Offset: 0x22D6640 VA: 0x1822D7C40
	private static extern void g_object_get(IntPtr object, string property_name, out bool value, IntPtr nullTerminator) { }
}
