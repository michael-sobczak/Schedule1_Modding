public class ToolStripDropDownMenu : ToolStripDropDown // TypeDefIndex: 5622
{
	// Fields
	private ToolStripLayoutStyle layout_style; // 0x368
	private bool show_check_margin; // 0x36C
	private bool show_image_margin; // 0x36D

	// Properties
	public override Rectangle DisplayRectangle { get; }
	public override LayoutEngine LayoutEngine { get; }
	[DefaultValue(False)]
	public bool ShowCheckMargin { get; }
	[DefaultValue(True)]
	public bool ShowImageMargin { get; }
	protected override Padding DefaultPadding { get; }

	// Methods

	// RVA: 0x2230EF0 Offset: 0x222F8F0 VA: 0x182230EF0
	public void .ctor() { }

	// RVA: 0x2230FB0 Offset: 0x222F9B0 VA: 0x182230FB0 Slot: 58
	public override Rectangle get_DisplayRectangle() { }

	// RVA: 0x2230FE0 Offset: 0x222F9E0 VA: 0x182230FE0 Slot: 67
	public override LayoutEngine get_LayoutEngine() { }

	// RVA: 0x2231060 Offset: 0x222FA60 VA: 0x182231060
	public bool get_ShowCheckMargin() { }

	// RVA: 0x2231070 Offset: 0x222FA70 VA: 0x182231070
	public bool get_ShowImageMargin() { }

	// RVA: 0x2230F50 Offset: 0x222F950 VA: 0x182230F50 Slot: 75
	protected override Padding get_DefaultPadding() { }

	// RVA: 0x22301A0 Offset: 0x222EBA0 VA: 0x1822301A0 Slot: 206
	protected internal override ToolStripItem CreateDefaultItem(string text, Image image, EventHandler onClick) { }

	// RVA: 0x21C88C0 Offset: 0x21C72C0 VA: 0x1821C88C0 Slot: 136
	protected override void OnFontChanged(EventArgs e) { }

	// RVA: 0x2230390 Offset: 0x222ED90 VA: 0x182230390 Slot: 148
	protected override void OnLayout(LayoutEventArgs e) { }

	// RVA: 0x2230C60 Offset: 0x222F660 VA: 0x182230C60 Slot: 168
	protected override void OnPaintBackground(PaintEventArgs e) { }

	// RVA: 0x2230EE0 Offset: 0x222F8E0 VA: 0x182230EE0 Slot: 215
	protected override void SetDisplayedItems() { }

	// RVA: 0x2230010 Offset: 0x222EA10 VA: 0x182230010 Slot: 218
	internal override Rectangle CalculateConnectedArea() { }
}
