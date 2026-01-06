internal class TitleButtons : IEnumerable // TypeDefIndex: 5419
{
	// Fields
	public TitleButton MinimizeButton; // 0x10
	public TitleButton MaximizeButton; // 0x18
	public TitleButton RestoreButton; // 0x20
	public TitleButton CloseButton; // 0x28
	public TitleButton HelpButton; // 0x30
	public TitleButton[] AllButtons; // 0x38
	public bool Visible; // 0x40
	private ToolTip.ToolTipWindow tooltip; // 0x48
	private Timer tooltip_timer; // 0x50
	private TitleButton tooltip_hovered_button; // 0x58
	private TitleButton tooltip_hidden_button; // 0x60
	private Form form; // 0x68

	// Properties
	public bool AnyPushedTitleButtons { get; }

	// Methods

	// RVA: 0x2355750 Offset: 0x2354150 VA: 0x182355750
	public void .ctor(Form frm) { }

	// RVA: 0x2354360 Offset: 0x2352D60 VA: 0x182354360
	private void ClickHandler(object sender, EventArgs e) { }

	// RVA: 0x23544C0 Offset: 0x2352EC0 VA: 0x1823544C0
	public TitleButton FindButton(int x, int y) { }

	// RVA: 0x2355B80 Offset: 0x2354580 VA: 0x182355B80
	public bool get_AnyPushedTitleButtons() { }

	// RVA: 0x2354560 Offset: 0x2352F60 VA: 0x182354560 Slot: 4
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2355550 Offset: 0x2353F50 VA: 0x182355550
	public void ToolTipStart(TitleButton button) { }

	// RVA: 0x23556B0 Offset: 0x23540B0 VA: 0x1823556B0
	public void ToolTipTimerTick(object sender, EventArgs e) { }

	// RVA: 0x2355330 Offset: 0x2353D30 VA: 0x182355330
	public void ToolTipShow(bool only_refresh) { }

	// RVA: 0x23552A0 Offset: 0x2353CA0 VA: 0x1823552A0
	public void ToolTipHide(bool reset_hidden_button) { }

	// RVA: 0x2354AB0 Offset: 0x23534B0 VA: 0x182354AB0
	public bool MouseMove(int x, int y) { }

	// RVA: 0x2354580 Offset: 0x2352F80 VA: 0x182354580
	public void MouseDown(int x, int y) { }

	// RVA: 0x2354F20 Offset: 0x2353920 VA: 0x182354F20
	public void MouseUp(int x, int y) { }

	// RVA: 0x2354830 Offset: 0x2353230 VA: 0x182354830
	internal void MouseLeave(int x, int y) { }
}
