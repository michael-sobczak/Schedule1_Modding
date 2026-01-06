public class ThreadExceptionDialog : Form // TypeDefIndex: 5599
{
	// Fields
	private Exception e; // 0x398
	private bool details; // 0x3A0
	private Button buttonIgnore; // 0x3A8
	private Button buttonAbort; // 0x3B0
	private Button buttonDetails; // 0x3B8
	private Label labelException; // 0x3C0
	private Label label1; // 0x3C8
	private TextBox textBoxDetails; // 0x3D0
	private Label helpText; // 0x3D8

	// Properties
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[EditorBrowsable(1)]
	public override bool AutoSize { get; set; }

	// Methods

	// RVA: 0x2223D20 Offset: 0x2222720 VA: 0x182223D20
	public void .ctor(Exception t) { }

	// RVA: 0x2222F70 Offset: 0x2221970 VA: 0x182222F70
	private void InitializeComponent() { }

	// RVA: 0x2223F20 Offset: 0x2222920 VA: 0x182223F20
	private void buttonDetails_Click(object sender, EventArgs e) { }

	// RVA: 0x2222CE0 Offset: 0x22216E0 VA: 0x182222CE0
	private void FillExceptionDetails() { }

	// RVA: 0x2223C10 Offset: 0x2222610 VA: 0x182223C10
	private void RefreshDetails() { }

	// RVA: 0x2223EE0 Offset: 0x22228E0 VA: 0x182223EE0
	private void buttonAbort_Click(object sender, EventArgs e) { }

	// RVA: 0x2223B90 Offset: 0x2222590 VA: 0x182223B90
	private void PaintHandler(object o, PaintEventArgs args) { }

	// RVA: 0x2223F40 Offset: 0x2222940 VA: 0x182223F40 Slot: 37
	public override bool get_AutoSize() { }

	// RVA: 0x2223F50 Offset: 0x2222950 VA: 0x182223F50 Slot: 38
	public override void set_AutoSize(bool value) { }
}
