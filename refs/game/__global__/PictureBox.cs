public class PictureBox : Control // TypeDefIndex: 5531
{
	// Fields
	private Image image; // 0x1D8
	private PictureBoxSizeMode size_mode; // 0x1E0
	private Image error_image; // 0x1E8
	private Image initial_image; // 0x1F0
	private bool image_from_url; // 0x1F8
	private int no_update; // 0x1FC
	private EventHandler frame_handler; // 0x200
	private static object LoadCompletedEvent; // 0x0
	private static object LoadProgressChangedEvent; // 0x8
	private static object SizeModeChangedEvent; // 0x10

	// Properties
	[DefaultValue(0)]
	[RefreshProperties(2)]
	[Localizable(True)]
	public PictureBoxSizeMode SizeMode { get; set; }
	[Localizable(True)]
	[Bindable(True)]
	public Image Image { get; set; }
	[DefaultValue(0)]
	[DispId(-504)]
	public BorderStyle BorderStyle { set; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override RightToLeft RightToLeft { get; }
	[Browsable(False)]
	[EditorBrowsable(1)]
	public int TabIndex { set; }
	[Browsable(False)]
	[EditorBrowsable(1)]
	public bool TabStop { set; }
	[EditorBrowsable(1)]
	[Bindable(False)]
	[Browsable(False)]
	public override string Text { get; set; }
	protected override CreateParams CreateParams { get; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override Font Font { get; set; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override Color ForeColor { get; set; }
	[Browsable(False)]
	[EditorBrowsable(1)]
	public override bool AllowDrop { get; }
	protected override Size DefaultSize { get; }

	// Methods

	// RVA: 0x239E080 Offset: 0x239CA80 VA: 0x18239E080
	public void .ctor() { }

	// RVA: 0x239DF80 Offset: 0x239C980 VA: 0x18239DF80
	private static void .cctor() { }

	// RVA: 0x21E0680 Offset: 0x21DF080 VA: 0x1821E0680
	public PictureBoxSizeMode get_SizeMode() { }

	// RVA: 0x239E450 Offset: 0x239CE50 VA: 0x18239E450
	public void set_SizeMode(PictureBoxSizeMode value) { }

	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public Image get_Image() { }

	// RVA: 0x239E2B0 Offset: 0x239CCB0 VA: 0x18239E2B0
	public void set_Image(Image value) { }

	// RVA: 0x2268ED0 Offset: 0x22678D0 VA: 0x182268ED0
	public void set_BorderStyle(BorderStyle value) { }

	// RVA: 0x222B020 Offset: 0x2229A20 VA: 0x18222B020 Slot: 68
	public override RightToLeft get_RightToLeft() { }

	// RVA: 0x239E570 Offset: 0x239CF70 VA: 0x18239E570
	public void set_TabIndex(int value) { }

	// RVA: 0x222B7D0 Offset: 0x222A1D0 VA: 0x18222B7D0
	public void set_TabStop(bool value) { }

	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170 Slot: 69
	public override string get_Text() { }

	// RVA: 0x21C8040 Offset: 0x21C6A40 VA: 0x1821C8040 Slot: 70
	public override void set_Text(string value) { }

	// RVA: 0x21C7A40 Offset: 0x21C6440 VA: 0x1821C7A40 Slot: 72
	protected override CreateParams get_CreateParams() { }

	// RVA: 0x21E0540 Offset: 0x21DEF40 VA: 0x1821E0540 Slot: 63
	public override Font get_Font() { }

	// RVA: 0x239E2A0 Offset: 0x239CCA0 VA: 0x18239E2A0 Slot: 64
	public override void set_Font(Font value) { }

	// RVA: 0x21D0940 Offset: 0x21CF340 VA: 0x1821D0940 Slot: 65
	public override Color get_ForeColor() { }

	// RVA: 0x21ECE40 Offset: 0x21EB840 VA: 0x1821ECE40 Slot: 66
	public override void set_ForeColor(Color value) { }

	// RVA: 0x4D63F0 Offset: 0x4D4DF0 VA: 0x1804D63F0 Slot: 34
	public override bool get_AllowDrop() { }

	// RVA: 0x239E200 Offset: 0x239CC00 VA: 0x18239E200 Slot: 76
	protected override Size get_DefaultSize() { }

	// RVA: 0x239D850 Offset: 0x239C250 VA: 0x18239D850 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x239DA40 Offset: 0x239C440 VA: 0x18239DA40 Slot: 165
	protected override void OnPaint(PaintEventArgs pe) { }

	// RVA: 0x234F720 Offset: 0x234E120 VA: 0x18234F720 Slot: 192
	protected override void OnVisibleChanged(EventArgs e) { }

	// RVA: 0x239DB40 Offset: 0x239C540 VA: 0x18239DB40 Slot: 193
	protected virtual void OnSizeModeChanged(EventArgs e) { }

	// RVA: 0x21C7250 Offset: 0x21C5C50 VA: 0x1821C7250 Slot: 134
	protected override void OnEnabledChanged(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x21C98D0 Offset: 0x21C82D0 VA: 0x1821C98D0 Slot: 140
	protected override void OnHandleCreated(EventArgs e) { }

	[EditorBrowsable(2)]
	// RVA: 0x21CDD00 Offset: 0x21CC700 VA: 0x1821CDD00 Slot: 141
	protected override void OnHandleDestroyed(EventArgs e) { }

	// RVA: 0x21C76F0 Offset: 0x21C60F0 VA: 0x1821C76F0 Slot: 171
	protected override void OnParentChanged(EventArgs e) { }

	// RVA: 0x239DB20 Offset: 0x239C520 VA: 0x18239DB20 Slot: 181
	protected override void OnResize(EventArgs e) { }

	// RVA: 0x239D8C0 Offset: 0x239C2C0 VA: 0x18239D8C0 Slot: 33
	internal override Size GetPreferredSizeCore(Size proposedSize) { }

	// RVA: 0x239D6B0 Offset: 0x239C0B0 VA: 0x18239D6B0
	private void ChangeImage(Image value, bool from_url) { }

	// RVA: 0x239DD80 Offset: 0x239C780 VA: 0x18239DD80
	private void StopAnimation() { }

	// RVA: 0x239DF20 Offset: 0x239C920 VA: 0x18239DF20
	private void UpdateSize() { }

	// RVA: 0x239D8E0 Offset: 0x239C2E0 VA: 0x18239D8E0
	private void OnAnimateImage(object sender, EventArgs e) { }

	// RVA: 0x239DEA0 Offset: 0x239C8A0 VA: 0x18239DEA0
	private void UpdateAnimatedImage(object sender, EventArgs e) { }

	// RVA: 0x239DC20 Offset: 0x239C620 VA: 0x18239DC20
	private void PictureBox_HandleCreated(object sender, EventArgs e) { }

	// RVA: 0x239DE20 Offset: 0x239C820 VA: 0x18239DE20 Slot: 3
	public override string ToString() { }
}
