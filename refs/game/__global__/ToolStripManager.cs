public sealed class ToolStripManager // TypeDefIndex: 5642
{
	// Fields
	private static ToolStripRenderer renderer; // 0x0
	private static ToolStripManagerRenderMode render_mode; // 0x8
	private static bool visual_styles_enabled; // 0xC
	private static List<WeakReference> toolstrips; // 0x10
	private static List<ToolStripMenuItem> menu_items; // 0x18
	private static bool activated_by_keyboard; // 0x20
	private static EventHandler AppClicked; // 0x28
	private static EventHandler AppFocusChange; // 0x30

	// Properties
	public static ToolStripRenderer Renderer { get; }
	internal static bool ActivatedByKeyboard { get; set; }

	// Methods

	// RVA: 0x223DC80 Offset: 0x223C680 VA: 0x18223DC80
	private static void .cctor() { }

	// RVA: 0x223DE10 Offset: 0x223C810 VA: 0x18223DE10
	internal static void add_AppClicked(EventHandler value) { }

	// RVA: 0x223E090 Offset: 0x223CA90 VA: 0x18223E090
	internal static void remove_AppClicked(EventHandler value) { }

	// RVA: 0x223DF00 Offset: 0x223C900 VA: 0x18223DF00
	internal static void add_AppFocusChange(EventHandler value) { }

	// RVA: 0x223E180 Offset: 0x223CB80 VA: 0x18223E180
	internal static void remove_AppFocusChange(EventHandler value) { }

	// RVA: 0x223E040 Offset: 0x223CA40 VA: 0x18223E040
	public static ToolStripRenderer get_Renderer() { }

	[MonoLimitation("Only supports one level of merging, cannot merge the same ToolStrip multiple times")]
	// RVA: 0x223B850 Offset: 0x223A250 VA: 0x18223B850
	public static bool Merge(ToolStrip sourceToolStrip, ToolStrip targetToolStrip) { }

	// RVA: 0x223DA80 Offset: 0x223C480 VA: 0x18223DA80
	public static bool RevertMerge(ToolStrip targetToolStrip) { }

	// RVA: 0x223D260 Offset: 0x223BC60 VA: 0x18223D260
	public static bool RevertMerge(ToolStrip targetToolStrip, ToolStrip sourceToolStrip) { }

	// RVA: 0x223DFF0 Offset: 0x223C9F0 VA: 0x18223DFF0
	internal static bool get_ActivatedByKeyboard() { }

	// RVA: 0x223E270 Offset: 0x223CC70 VA: 0x18223E270
	internal static void set_ActivatedByKeyboard(bool value) { }

	// RVA: 0x223A9B0 Offset: 0x22393B0 VA: 0x18223A9B0
	internal static void AddToolStrip(ToolStrip ts) { }

	// RVA: 0x223AB40 Offset: 0x2239540 VA: 0x18223AB40
	private static int AdjustItemMergeIndex(ToolStrip ts, ToolStripItem tsi) { }

	// RVA: 0x223AC10 Offset: 0x2239610 VA: 0x18223AC10
	private static int CountRealToolStripItems(ToolStrip ts) { }

	// RVA: 0x223B210 Offset: 0x2239C10 VA: 0x18223B210
	internal static ToolStrip GetNextToolStrip(ToolStrip ts, bool forward) { }

	// RVA: 0x223C780 Offset: 0x223B180 VA: 0x18223C780
	internal static bool ProcessCmdKey(ref Message m, Keys keyData) { }

	// RVA: 0x223C9A0 Offset: 0x223B3A0 VA: 0x18223C9A0
	internal static bool ProcessMenuKey(ref Message m) { }

	// RVA: 0x223DAF0 Offset: 0x223C4F0 VA: 0x18223DAF0
	internal static void SetActiveToolStrip(ToolStrip toolStrip, bool keyboard) { }

	// RVA: 0x223A860 Offset: 0x2239260 VA: 0x18223A860
	internal static void AddToolStripMenuItem(ToolStripMenuItem tsmi) { }

	// RVA: 0x223D000 Offset: 0x223BA00 VA: 0x18223D000
	internal static void RemoveToolStrip(ToolStrip ts) { }

	// RVA: 0x223CF10 Offset: 0x223B910 VA: 0x18223CF10
	internal static void RemoveToolStripMenuItem(ToolStripMenuItem tsmi) { }

	// RVA: 0x223AEB0 Offset: 0x22398B0 VA: 0x18223AEB0
	internal static void FireAppClicked() { }

	// RVA: 0x223B060 Offset: 0x2239A60 VA: 0x18223B060
	internal static void FireAppFocusChanged(Form form) { }

	// RVA: 0x223CDD0 Offset: 0x223B7D0 VA: 0x18223CDD0
	private static void RemoveItemFromParentToolStrip(ToolStripItem tsi) { }
}
