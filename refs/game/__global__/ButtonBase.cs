public abstract class ButtonBase : Control // TypeDefIndex: 5252
{
	// Fields
	private FlatStyle flat_style; // 0x1D8
	private int image_index; // 0x1DC
	internal Image image; // 0x1E0
	internal ImageList image_list; // 0x1E8
	private ContentAlignment image_alignment; // 0x1F0
	internal ContentAlignment text_alignment; // 0x1F4
	private bool is_default; // 0x1F8
	internal bool is_pressed; // 0x1F9
	internal StringFormat text_format; // 0x200
	internal bool paint_as_acceptbutton; // 0x208
	private FlatButtonAppearance flat_button_appearance; // 0x210
	private string image_key; // 0x218
	private TextImageRelation text_image_relation; // 0x220
	private TextFormatFlags text_format_flags; // 0x224
	private bool use_mnemonic; // 0x228
	private bool use_visual_style_back_color; // 0x229

	// Properties
	[DesignerSerializationVisibility(1)]
	[EditorBrowsable(0)]
	[MWFCategory("Layout")]
	[Browsable(True)]
	public override bool AutoSize { get; set; }
	public override Color BackColor { get; set; }
	[DesignerSerializationVisibility(2)]
	[Browsable(True)]
	[MWFCategory("Appearance")]
	public FlatButtonAppearance FlatAppearance { get; }
	[Localizable(True)]
	[MWFDescription("Determines look of button")]
	[DefaultValue(2)]
	[MWFCategory("Appearance")]
	public FlatStyle FlatStyle { get; set; }
	[Localizable(True)]
	[MWFDescription("Sets image to be displayed on button face")]
	[MWFCategory("Appearance")]
	public Image Image { get; }
	[MWFDescription("Sets the alignment of the image to be displayed on button face")]
	[Localizable(True)]
	[MWFCategory("Appearance")]
	[DefaultValue(32)]
	public ContentAlignment ImageAlign { get; }
	[TypeConverter(typeof(ImageIndexConverter))]
	[DefaultValue(-1)]
	[Localizable(True)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[MWFDescription("Index of image to display, if ImageList is used for button face images")]
	[MWFCategory("Appearance")]
	[RefreshProperties(2)]
	public int ImageIndex { get; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public ImeMode ImeMode { set; }
	[SettingsBindable(True)]
	[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public override string Text { get; set; }
	[DefaultValue(32)]
	[MWFCategory("Appearance")]
	[MWFDescription("Alignment for button text")]
	[Localizable(True)]
	public virtual ContentAlignment TextAlign { get; set; }
	[MWFCategory("Appearance")]
	[Localizable(True)]
	[DefaultValue(0)]
	public TextImageRelation TextImageRelation { get; }
	[MWFCategory("Behavior")]
	[DefaultValue(False)]
	public bool UseCompatibleTextRendering { get; }
	[MWFCategory("Appearance")]
	[DefaultValue(True)]
	public bool UseMnemonic { get; }
	[MWFCategory("Appearance")]
	public bool UseVisualStyleBackColor { get; set; }
	protected override CreateParams CreateParams { get; }
	protected override Size DefaultSize { get; }
	protected internal bool IsDefault { get; set; }
	internal bool Pressed { get; }
	internal TextFormatFlags TextFormatFlags { get; }

	// Methods

	// RVA: 0x21C77E0 Offset: 0x21C61E0 VA: 0x1821C77E0
	protected void .ctor() { }

	// RVA: 0xAADD90 Offset: 0xAAC790 VA: 0x180AADD90 Slot: 37
	public override bool get_AutoSize() { }

	// RVA: 0x21C7C30 Offset: 0x21C6630 VA: 0x1821C7C30 Slot: 38
	public override void set_AutoSize(bool value) { }

	// RVA: 0x21C7A10 Offset: 0x21C6410 VA: 0x1821C7A10 Slot: 42
	public override Color get_BackColor() { }

	// RVA: 0x21C7C40 Offset: 0x21C6640 VA: 0x1821C7C40 Slot: 43
	public override void set_BackColor(Color value) { }

	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public FlatButtonAppearance get_FlatAppearance() { }

	// RVA: 0x21C7AF0 Offset: 0x21C64F0 VA: 0x1821C7AF0
	public FlatStyle get_FlatStyle() { }

	// RVA: 0x21C7C70 Offset: 0x21C6670 VA: 0x1821C7C70
	public void set_FlatStyle(FlatStyle value) { }

	// RVA: 0x21C7B30 Offset: 0x21C6530 VA: 0x1821C7B30
	public Image get_Image() { }

	// RVA: 0x21C7B00 Offset: 0x21C6500 VA: 0x1821C7B00
	public ContentAlignment get_ImageAlign() { }

	// RVA: 0x21C7B10 Offset: 0x21C6510 VA: 0x1821C7B10
	public int get_ImageIndex() { }

	// RVA: 0x21C7CF0 Offset: 0x21C66F0 VA: 0x1821C7CF0
	public void set_ImeMode(ImeMode value) { }

	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170 Slot: 69
	public override string get_Text() { }

	// RVA: 0x21C8040 Offset: 0x21C6A40 VA: 0x1821C8040 Slot: 70
	public override void set_Text(string value) { }

	// RVA: 0x21C7BF0 Offset: 0x21C65F0 VA: 0x1821C7BF0 Slot: 193
	public virtual ContentAlignment get_TextAlign() { }

	// RVA: 0x21C7D20 Offset: 0x21C6720 VA: 0x1821C7D20 Slot: 194
	public virtual void set_TextAlign(ContentAlignment value) { }

	// RVA: 0xA2A290 Offset: 0xA28C90 VA: 0x180A2A290
	public TextImageRelation get_TextImageRelation() { }

	// RVA: 0x5995F0 Offset: 0x597FF0 VA: 0x1805995F0
	public bool get_UseCompatibleTextRendering() { }

	// RVA: 0x21C7C10 Offset: 0x21C6610 VA: 0x1821C7C10
	public bool get_UseMnemonic() { }

	// RVA: 0x21C7C20 Offset: 0x21C6620 VA: 0x1821C7C20
	public bool get_UseVisualStyleBackColor() { }

	// RVA: 0x21C8050 Offset: 0x21C6A50 VA: 0x1821C8050
	public void set_UseVisualStyleBackColor(bool value) { }

	// RVA: 0x21C7A40 Offset: 0x21C6440 VA: 0x1821C7A40 Slot: 72
	protected override CreateParams get_CreateParams() { }

	// RVA: 0x21C7A50 Offset: 0x21C6450 VA: 0x1821C7A50 Slot: 76
	protected override Size get_DefaultSize() { }

	// RVA: 0x6BFCD0 Offset: 0x6BE6D0 VA: 0x1806BFCD0
	protected internal bool get_IsDefault() { }

	// RVA: 0x21C7D00 Offset: 0x21C6700 VA: 0x1821C7D00
	protected internal void set_IsDefault(bool value) { }

	// RVA: 0x21C7240 Offset: 0x21C5C40 VA: 0x1821C7240 Slot: 82
	public override Size GetPreferredSize(Size proposedSize) { }

	// RVA: 0x21C7160 Offset: 0x21C5B60 VA: 0x1821C7160 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21C7250 Offset: 0x21C5C50 VA: 0x1821C7250 Slot: 134
	protected override void OnEnabledChanged(EventArgs e) { }

	// RVA: 0x21C7260 Offset: 0x21C5C60 VA: 0x1821C7260 Slot: 139
	protected override void OnGotFocus(EventArgs e) { }

	// RVA: 0x21C7290 Offset: 0x21C5C90 VA: 0x1821C7290 Slot: 145
	protected override void OnKeyDown(KeyEventArgs kevent) { }

	// RVA: 0x21C72E0 Offset: 0x21C5CE0 VA: 0x1821C72E0 Slot: 147
	protected override void OnKeyUp(KeyEventArgs kevent) { }

	// RVA: 0x21C7390 Offset: 0x21C5D90 VA: 0x1821C7390 Slot: 151
	protected override void OnLostFocus(EventArgs e) { }

	// RVA: 0x21C73C0 Offset: 0x21C5DC0 VA: 0x1821C73C0 Slot: 155
	protected override void OnMouseDown(MouseEventArgs mevent) { }

	// RVA: 0x21C7410 Offset: 0x21C5E10 VA: 0x1821C7410 Slot: 156
	protected override void OnMouseEnter(EventArgs eventargs) { }

	// RVA: 0x21C7450 Offset: 0x21C5E50 VA: 0x1821C7450 Slot: 158
	protected override void OnMouseLeave(EventArgs eventargs) { }

	// RVA: 0x21C7490 Offset: 0x21C5E90 VA: 0x1821C7490 Slot: 159
	protected override void OnMouseMove(MouseEventArgs mevent) { }

	// RVA: 0x21C7550 Offset: 0x21C5F50 VA: 0x1821C7550 Slot: 160
	protected override void OnMouseUp(MouseEventArgs mevent) { }

	// RVA: 0x21C76B0 Offset: 0x21C60B0 VA: 0x1821C76B0 Slot: 165
	protected override void OnPaint(PaintEventArgs pevent) { }

	// RVA: 0x21C76F0 Offset: 0x21C60F0 VA: 0x1821C76F0 Slot: 171
	protected override void OnParentChanged(EventArgs e) { }

	// RVA: 0x21C7700 Offset: 0x21C6100 VA: 0x1821C7700 Slot: 189
	protected override void OnTextChanged(EventArgs e) { }

	// RVA: 0x21C7730 Offset: 0x21C6130 VA: 0x1821C7730 Slot: 192
	protected override void OnVisibleChanged(EventArgs e) { }

	// RVA: 0x21C7770 Offset: 0x21C6170 VA: 0x1821C7770 Slot: 114
	protected override void WndProc(ref Message m) { }

	// RVA: 0x21C7BE0 Offset: 0x21C65E0 VA: 0x1821C7BE0
	internal bool get_Pressed() { }

	// RVA: 0x21C7C00 Offset: 0x21C6600 VA: 0x1821C7C00
	internal TextFormatFlags get_TextFormatFlags() { }

	// RVA: 0x21C7170 Offset: 0x21C5B70 VA: 0x1821C7170 Slot: 195
	internal virtual void Draw(PaintEventArgs pevent) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 196
	internal virtual void HaveDoubleClick() { }

	// RVA: 0x21C76A0 Offset: 0x21C60A0 VA: 0x1821C76A0 Slot: 166
	internal override void OnPaintBackgroundInternal(PaintEventArgs e) { }
}
