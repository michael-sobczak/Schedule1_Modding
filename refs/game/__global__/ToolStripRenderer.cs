public abstract class ToolStripRenderer // TypeDefIndex: 5649
{
	// Fields
	private static ColorMatrix grayscale_matrix; // 0x0
	private EventHandlerList events; // 0x10
	private static object RenderArrowEvent; // 0x8
	private static object RenderButtonBackgroundEvent; // 0x10
	private static object RenderDropDownButtonBackgroundEvent; // 0x18
	private static object RenderGripEvent; // 0x20
	private static object RenderImageMarginEvent; // 0x28
	private static object RenderItemBackgroundEvent; // 0x30
	private static object RenderItemCheckEvent; // 0x38
	private static object RenderItemImageEvent; // 0x40
	private static object RenderItemTextEvent; // 0x48
	private static object RenderLabelBackgroundEvent; // 0x50
	private static object RenderMenuItemBackgroundEvent; // 0x58
	private static object RenderOverflowButtonBackgroundEvent; // 0x60
	private static object RenderSeparatorEvent; // 0x68
	private static object RenderSplitButtonBackgroundEvent; // 0x70
	private static object RenderStatusStripSizingGripEvent; // 0x78
	private static object RenderToolStripBackgroundEvent; // 0x80
	private static object RenderToolStripBorderEvent; // 0x88
	private static object RenderToolStripContentPanelBackgroundEvent; // 0x90
	private static object RenderToolStripPanelBackgroundEvent; // 0x98
	private static object RenderToolStripStatusLabelBackgroundEvent; // 0xA0

	// Properties
	private EventHandlerList Events { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x22531E0 Offset: 0x2251BE0 VA: 0x1822531E0
	private static void .cctor() { }

	// RVA: 0x2250820 Offset: 0x224F220 VA: 0x182250820
	public static Image CreateDisabledImage(Image normalImage) { }

	// RVA: 0x2250A80 Offset: 0x224F480 VA: 0x182250A80
	public void DrawArrow(ToolStripArrowRenderEventArgs e) { }

	// RVA: 0x2250E40 Offset: 0x224F840 VA: 0x182250E40
	public void DrawButtonBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x1CBDE10 Offset: 0x1CBC810 VA: 0x181CBDE10
	public void DrawDropDownButtonBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x2250F20 Offset: 0x224F920 VA: 0x182250F20
	public void DrawGrip(ToolStripGripRenderEventArgs e) { }

	// RVA: 0x79ED10 Offset: 0x79D710 VA: 0x18079ED10
	public void DrawImageMargin(ToolStripRenderEventArgs e) { }

	// RVA: 0x2250F40 Offset: 0x224F940 VA: 0x182250F40
	public void DrawItemBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x2250F60 Offset: 0x224F960 VA: 0x182250F60
	public void DrawItemCheck(ToolStripItemImageRenderEventArgs e) { }

	// RVA: 0x2250F80 Offset: 0x224F980 VA: 0x182250F80
	public void DrawItemImage(ToolStripItemImageRenderEventArgs e) { }

	// RVA: 0x2250FA0 Offset: 0x224F9A0 VA: 0x182250FA0
	public void DrawItemText(ToolStripItemTextRenderEventArgs e) { }

	// RVA: 0x1DBFC40 Offset: 0x1DBE640 VA: 0x181DBFC40
	public void DrawMenuItemBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x2250FC0 Offset: 0x224F9C0 VA: 0x182250FC0
	public void DrawOverflowButtonBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x22510C0 Offset: 0x224FAC0 VA: 0x1822510C0
	public void DrawSeparator(ToolStripSeparatorRenderEventArgs e) { }

	// RVA: 0x1FB7A60 Offset: 0x1FB6460 VA: 0x181FB7A60
	public void DrawToolStripBackground(ToolStripRenderEventArgs e) { }

	// RVA: 0x1DC04D0 Offset: 0x1DBEED0 VA: 0x181DC04D0
	public void DrawToolStripBorder(ToolStripRenderEventArgs e) { }

	// RVA: 0x22510E0 Offset: 0x224FAE0 VA: 0x1822510E0 Slot: 4
	protected virtual void OnRenderArrow(ToolStripArrowRenderEventArgs e) { }

	// RVA: 0x2251600 Offset: 0x2250000 VA: 0x182251600 Slot: 5
	protected virtual void OnRenderButtonBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x2251720 Offset: 0x2250120 VA: 0x182251720 Slot: 6
	protected virtual void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x2251840 Offset: 0x2250240 VA: 0x182251840 Slot: 7
	protected virtual void OnRenderGrip(ToolStripGripRenderEventArgs e) { }

	// RVA: 0x2251960 Offset: 0x2250360 VA: 0x182251960 Slot: 8
	protected virtual void OnRenderImageMargin(ToolStripRenderEventArgs e) { }

	// RVA: 0x2251A80 Offset: 0x2250480 VA: 0x182251A80 Slot: 9
	protected virtual void OnRenderItemBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x2252110 Offset: 0x2250B10 VA: 0x182252110 Slot: 10
	protected virtual void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e) { }

	// RVA: 0x2252230 Offset: 0x2250C30 VA: 0x182252230 Slot: 11
	protected virtual void OnRenderItemImage(ToolStripItemImageRenderEventArgs e) { }

	// RVA: 0x2252600 Offset: 0x2251000 VA: 0x182252600 Slot: 12
	protected virtual void OnRenderItemText(ToolStripItemTextRenderEventArgs e) { }

	// RVA: 0x2252C40 Offset: 0x2251640 VA: 0x182252C40 Slot: 13
	protected virtual void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x2252D60 Offset: 0x2251760 VA: 0x182252D60 Slot: 14
	protected virtual void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x2252E80 Offset: 0x2251880 VA: 0x182252E80 Slot: 15
	protected virtual void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e) { }

	// RVA: 0x2252FA0 Offset: 0x22519A0 VA: 0x182252FA0 Slot: 16
	protected virtual void OnRenderToolStripBackground(ToolStripRenderEventArgs e) { }

	// RVA: 0x22530C0 Offset: 0x2251AC0 VA: 0x1822530C0 Slot: 17
	protected virtual void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }

	// RVA: 0x2253A00 Offset: 0x2252400 VA: 0x182253A00
	private EventHandlerList get_Events() { }

	// RVA: 0x2250A00 Offset: 0x224F400 VA: 0x182250A00
	internal static Image CreateMirrorImage(Image normalImage) { }

	// RVA: 0x2250AA0 Offset: 0x224F4A0 VA: 0x182250AA0
	private void DrawBackground(Graphics g, Rectangle bounds, Image image, ImageLayout layout) { }

	// RVA: 0x2250FE0 Offset: 0x224F9E0 VA: 0x182250FE0
	internal static void DrawRightArrow(Graphics g, Pen p, int x, int y) { }

	// RVA: 0x2250E60 Offset: 0x224F860 VA: 0x182250E60
	internal static void DrawDownArrow(Graphics g, Pen p, int x, int y) { }
}
