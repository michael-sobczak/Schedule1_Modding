public class ToolStripMenuItem : ToolStripDropDownItem // TypeDefIndex: 5644
{
	// Fields
	private CheckState checked_state; // 0x188
	private bool check_on_click; // 0x18C
	private bool close_on_mouse_release; // 0x18D
	private string shortcut_display_string; // 0x190
	private Keys shortcut_keys; // 0x198
	private bool show_shortcut_keys; // 0x19C
	private Form mdi_client_form; // 0x1A0
	private static object CheckedChangedEvent; // 0x0
	private static object CheckStateChangedEvent; // 0x8
	private static object UIACheckOnClickChangedEvent; // 0x10

	// Properties
	[Bindable(True)]
	[RefreshProperties(1)]
	[DefaultValue(False)]
	public bool Checked { get; set; }
	[DefaultValue(0)]
	[Bindable(True)]
	[RefreshProperties(1)]
	public CheckState CheckState { set; }
	public override bool Enabled { get; set; }
	[Browsable(False)]
	public bool IsMdiWindowListEntry { get; }
	[Localizable(True)]
	[DefaultValue(0)]
	public Keys ShortcutKeys { get; set; }
	protected internal override Padding DefaultMargin { get; }
	protected override Padding DefaultPadding { get; }
	protected override Size DefaultSize { get; }
	internal Form MdiClientForm { get; set; }

	// Methods

	// RVA: 0x22492E0 Offset: 0x2247CE0 VA: 0x1822492E0
	public void .ctor() { }

	// RVA: 0x22491B0 Offset: 0x2247BB0 VA: 0x1822491B0
	public void .ctor(string text, Image image, EventHandler onClick) { }

	// RVA: 0x2249240 Offset: 0x2247C40 VA: 0x182249240
	public void .ctor(string text, Image image, EventHandler onClick, string name) { }

	// RVA: 0x22490B0 Offset: 0x2247AB0 VA: 0x1822490B0
	private static void .cctor() { }

	// RVA: 0x2249340 Offset: 0x2247D40 VA: 0x182249340
	public bool get_Checked() { }

	// RVA: 0x2249610 Offset: 0x2248010 VA: 0x182249610
	public void set_Checked(bool value) { }

	// RVA: 0x2249430 Offset: 0x2247E30 VA: 0x182249430
	public void set_CheckState(CheckState value) { }

	// RVA: 0x2249400 Offset: 0x2247E00 VA: 0x182249400 Slot: 20
	public override bool get_Enabled() { }

	// RVA: 0x2249800 Offset: 0x2248200 VA: 0x182249800 Slot: 21
	public override void set_Enabled(bool value) { }

	// RVA: 0x2249410 Offset: 0x2247E10 VA: 0x182249410
	public bool get_IsMdiWindowListEntry() { }

	// RVA: 0x2249420 Offset: 0x2247E20 VA: 0x182249420
	public Keys get_ShortcutKeys() { }

	// RVA: 0x2249810 Offset: 0x2248210 VA: 0x182249810
	public void set_ShortcutKeys(Keys value) { }

	// RVA: 0x2249360 Offset: 0x2247D60 VA: 0x182249360 Slot: 37
	protected internal override Padding get_DefaultMargin() { }

	// RVA: 0x2249390 Offset: 0x2247D90 VA: 0x182249390 Slot: 38
	protected override Padding get_DefaultPadding() { }

	// RVA: 0x22493D0 Offset: 0x2247DD0 VA: 0x1822493D0 Slot: 39
	protected override Size get_DefaultSize() { }

	// RVA: 0x2247670 Offset: 0x2246070 VA: 0x182247670 Slot: 78
	protected override ToolStripDropDown CreateDefaultDropDown() { }

	// RVA: 0x22476E0 Offset: 0x22460E0 VA: 0x1822476E0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2247AF0 Offset: 0x22464F0 VA: 0x182247AF0 Slot: 84
	protected virtual void OnCheckedChanged(EventArgs e) { }

	// RVA: 0x2247A10 Offset: 0x2246410 VA: 0x182247A10 Slot: 85
	protected virtual void OnCheckStateChanged(EventArgs e) { }

	// RVA: 0x2247BC0 Offset: 0x22465C0 VA: 0x182247BC0 Slot: 43
	protected override void OnClick(EventArgs e) { }

	// RVA: 0x1AF9390 Offset: 0x1AF7D90 VA: 0x181AF9390 Slot: 80
	protected override void OnDropDownHide(EventArgs e) { }

	// RVA: 0x2247E70 Offset: 0x2246870 VA: 0x182247E70 Slot: 83
	protected override void OnDropDownShow(EventArgs e) { }

	// RVA: 0x2247E80 Offset: 0x2246880 VA: 0x182247E80 Slot: 46
	protected override void OnFontChanged(EventArgs e) { }

	// RVA: 0x2247E90 Offset: 0x2246890 VA: 0x182247E90 Slot: 49
	protected override void OnMouseDown(MouseEventArgs e) { }

	// RVA: 0x2247F50 Offset: 0x2246950 VA: 0x182247F50 Slot: 50
	protected override void OnMouseEnter(EventArgs e) { }

	// RVA: 0x2247FD0 Offset: 0x22469D0 VA: 0x182247FD0 Slot: 52
	protected override void OnMouseLeave(EventArgs e) { }

	// RVA: 0x2247FE0 Offset: 0x22469E0 VA: 0x182247FE0 Slot: 54
	protected override void OnMouseUp(MouseEventArgs e) { }

	// RVA: 0x2248140 Offset: 0x2246B40 VA: 0x182248140 Slot: 55
	protected override void OnOwnerChanged(EventArgs e) { }

	// RVA: 0x2248150 Offset: 0x2246B50 VA: 0x182248150 Slot: 57
	protected override void OnPaint(PaintEventArgs e) { }

	// RVA: 0x2248D10 Offset: 0x2247710 VA: 0x182248D10 Slot: 64
	protected internal override bool ProcessCmdKey(ref Message m, Keys keyData) { }

	// RVA: 0x2247850 Offset: 0x2246250 VA: 0x182247850
	private Control GetTopLevelControl() { }

	// RVA: 0x2248F90 Offset: 0x2247990 VA: 0x182248F90 Slot: 66
	protected internal override bool ProcessMnemonic(char charCode) { }

	// RVA: 0x2249090 Offset: 0x2247A90 VA: 0x182249090 Slot: 67
	protected internal override void SetBounds(Rectangle rect) { }

	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	internal Form get_MdiClientForm() { }

	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	internal void set_MdiClientForm(Form value) { }

	// RVA: 0x22475C0 Offset: 0x2245FC0 VA: 0x1822475C0 Slot: 69
	internal override Size CalculatePreferredSize(Size constrainingSize) { }

	// RVA: 0x22476F0 Offset: 0x22460F0 VA: 0x1822476F0
	internal string GetShortcutDisplayString() { }

	// RVA: 0x2247960 Offset: 0x2246360 VA: 0x182247960
	internal void HandleAutoExpansion() { }

	// RVA: 0x22479D0 Offset: 0x22463D0 VA: 0x1822479D0 Slot: 73
	internal override void HandleClick(EventArgs e) { }
}
