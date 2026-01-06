public class ToolStripButton : ToolStripItem // TypeDefIndex: 5611
{
	// Fields
	private CheckState checked_state; // 0x180
	private bool check_on_click; // 0x184
	private static object CheckedChangedEvent; // 0x0
	private static object CheckStateChangedEvent; // 0x8
	private static object UIACheckOnClickChangedEvent; // 0x10

	// Properties
	public override bool CanSelect { get; }
	[DefaultValue(False)]
	public bool Checked { get; set; }
	protected override bool DefaultAutoToolTip { get; }

	// Methods

	// RVA: 0x222D750 Offset: 0x222C150 VA: 0x18222D750
	public void .ctor(string text, Image image, EventHandler onClick) { }

	// RVA: 0x222D680 Offset: 0x222C080 VA: 0x18222D680
	public void .ctor(string text, Image image, EventHandler onClick, string name) { }

	// RVA: 0x222D580 Offset: 0x222BF80 VA: 0x18222D580
	private static void .cctor() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 18
	public override bool get_CanSelect() { }

	// RVA: 0x222D850 Offset: 0x222C250 VA: 0x18222D850
	public bool get_Checked() { }

	// RVA: 0x222D870 Offset: 0x222C270 VA: 0x18222D870
	public void set_Checked(bool value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 35
	protected override bool get_DefaultAutoToolTip() { }

	// RVA: 0x222CD80 Offset: 0x222B780 VA: 0x18222CD80 Slot: 40
	public override Size GetPreferredSize(Size constrainingSize) { }

	// RVA: 0x222CEA0 Offset: 0x222B8A0 VA: 0x18222CEA0 Slot: 76
	protected virtual void OnCheckedChanged(EventArgs e) { }

	// RVA: 0x222CDC0 Offset: 0x222B7C0 VA: 0x18222CDC0 Slot: 77
	protected virtual void OnCheckStateChanged(EventArgs e) { }

	// RVA: 0x222CF70 Offset: 0x222B970 VA: 0x18222CF70 Slot: 43
	protected override void OnClick(EventArgs e) { }

	// RVA: 0x222D180 Offset: 0x222BB80 VA: 0x18222D180 Slot: 57
	protected override void OnPaint(PaintEventArgs e) { }
}
