public class ToolStripDropDownButton : ToolStripDropDownItem // TypeDefIndex: 5616
{
	// Fields
	private bool show_drop_down_arrow; // 0x188

	// Properties
	[DefaultValue(True)]
	public bool ShowDropDownArrow { get; }
	protected override bool DefaultAutoToolTip { get; }

	// Methods

	// RVA: 0x222E710 Offset: 0x222D110 VA: 0x18222E710
	public void .ctor() { }

	// RVA: 0x222E650 Offset: 0x222D050 VA: 0x18222E650
	public void .ctor(string text, Image image, EventHandler onClick, string name) { }

	// RVA: 0xA59C90 Offset: 0xA58690 VA: 0x180A59C90
	public bool get_ShowDropDownArrow() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 35
	protected override bool get_DefaultAutoToolTip() { }

	// RVA: 0x222DD20 Offset: 0x222C720 VA: 0x18222DD20 Slot: 78
	protected override ToolStripDropDown CreateDefaultDropDown() { }

	// RVA: 0x222DDC0 Offset: 0x222C7C0 VA: 0x18222DDC0 Slot: 49
	protected override void OnMouseDown(MouseEventArgs e) { }

	// RVA: 0x222DF30 Offset: 0x222C930 VA: 0x18222DF30 Slot: 52
	protected override void OnMouseLeave(EventArgs e) { }

	// RVA: 0x222E060 Offset: 0x222CA60 VA: 0x18222E060 Slot: 54
	protected override void OnMouseUp(MouseEventArgs e) { }

	// RVA: 0x222E070 Offset: 0x222CA70 VA: 0x18222E070 Slot: 57
	protected override void OnPaint(PaintEventArgs e) { }

	// RVA: 0x222E5D0 Offset: 0x222CFD0 VA: 0x18222E5D0 Slot: 66
	protected internal override bool ProcessMnemonic(char charCode) { }

	// RVA: 0x222DCF0 Offset: 0x222C6F0 VA: 0x18222DCF0 Slot: 69
	internal override Size CalculatePreferredSize(Size constrainingSize) { }
}
