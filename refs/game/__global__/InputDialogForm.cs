internal class InputDialogForm : ExtendedForm // TypeDefIndex: 17253
{
	// Fields
	private SizeF _textMargin; // 0x3C0
	private string _mainInstruction; // 0x3C8
	private string _content; // 0x3D0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler<OkButtonClickedEventArgs> OkButtonClicked; // 0x3D8
	private IContainer components; // 0x3E0
	private Panel _primaryPanel; // 0x3E8
	private Panel _secondaryPanel; // 0x3F0
	private Button _cancelButton; // 0x3F8
	private Button _okButton; // 0x400
	private TextBox _inputTextBox; // 0x408

	// Properties
	public string MainInstruction { get; set; }
	public string Content { get; set; }
	public string Input { get; set; }
	public int MaxLength { get; set; }
	public bool UsePasswordMasking { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E05E20 Offset: 0x1E04820 VA: 0x181E05E20
	public void add_OkButtonClicked(EventHandler<OkButtonClickedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1E05F90 Offset: 0x1E04990 VA: 0x181E05F90
	public void remove_OkButtonClicked(EventHandler<OkButtonClickedEventArgs> value) { }

	// RVA: 0x1E05960 Offset: 0x1E04360 VA: 0x181E05960
	public void .ctor() { }

	// RVA: 0x1E05F20 Offset: 0x1E04920 VA: 0x181E05F20
	public string get_MainInstruction() { }

	// RVA: 0x681E50 Offset: 0x680850 VA: 0x180681E50
	public void set_MainInstruction(string value) { }

	// RVA: 0x1E05EE0 Offset: 0x1E048E0 VA: 0x181E05EE0
	public string get_Content() { }

	// RVA: 0x67A2C0 Offset: 0x678CC0 VA: 0x18067A2C0
	public void set_Content(string value) { }

	// RVA: 0x1E05EF0 Offset: 0x1E048F0 VA: 0x181E05EF0
	public string get_Input() { }

	// RVA: 0x1E06050 Offset: 0x1E04A50 VA: 0x181E06050
	public void set_Input(string value) { }

	// RVA: 0x1E05F30 Offset: 0x1E04930 VA: 0x181E05F30
	public int get_MaxLength() { }

	// RVA: 0x1E06080 Offset: 0x1E04A80 VA: 0x181E06080
	public void set_MaxLength(int value) { }

	// RVA: 0x1E05F60 Offset: 0x1E04960 VA: 0x181E05F60
	public bool get_UsePasswordMasking() { }

	// RVA: 0x1E060B0 Offset: 0x1E04AB0 VA: 0x181E060B0
	public void set_UsePasswordMasking(bool value) { }

	// RVA: 0x1E05690 Offset: 0x1E04090 VA: 0x181E05690 Slot: 220
	protected virtual void OnOkButtonClicked(OkButtonClickedEventArgs e) { }

	// RVA: 0x1E056C0 Offset: 0x1E040C0 VA: 0x181E056C0 Slot: 105
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified) { }

	// RVA: 0x1E05740 Offset: 0x1E04140 VA: 0x181E05740
	private void SizeDialog() { }

	// RVA: 0x1E04E50 Offset: 0x1E03850 VA: 0x181E04E50
	private static void DrawThemeBackground(IDeviceContext dc, VisualStyleElement element, Rectangle bounds, Rectangle clipRectangle) { }

	// RVA: 0x1E04D50 Offset: 0x1E03750 VA: 0x181E04D50
	private void DrawText(IDeviceContext dc, ref Point location, bool measureOnly, int width) { }

	// RVA: 0x1E05AF0 Offset: 0x1E044F0 VA: 0x181E05AF0
	private void _primaryPanel_Paint(object sender, PaintEventArgs e) { }

	// RVA: 0x1E05D10 Offset: 0x1E04710 VA: 0x181E05D10
	private void _secondaryPanel_Paint(object sender, PaintEventArgs e) { }

	// RVA: 0x1E05670 Offset: 0x1E04070 VA: 0x181E05670
	private void NewInputBoxForm_Load(object sender, EventArgs e) { }

	// RVA: 0x1E05A10 Offset: 0x1E04410 VA: 0x181E05A10
	private void _okButton_Click(object sender, EventArgs e) { }

	// RVA: 0x1E04CD0 Offset: 0x1E036D0 VA: 0x181E04CD0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E04F60 Offset: 0x1E03960 VA: 0x181E04F60
	private void InitializeComponent() { }
}
