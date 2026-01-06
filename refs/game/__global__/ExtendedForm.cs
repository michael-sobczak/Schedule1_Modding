public class ExtendedForm : Form // TypeDefIndex: 17249
{
	// Fields
	private bool _useSystemFont; // 0x398
	private Padding _glassMargin; // 0x39C
	private bool _allowGlassDragging; // 0x3B0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler DwmCompositionChanged; // 0x3B8

	// Properties
	[DefaultValue(False)]
	[Category("Appearance")]
	[Description("Indicates whether or not the form automatically uses the system default font.")]
	public bool UseSystemFont { get; set; }
	[Category("Appearance")]
	[Description("The glass margins of the form.")]
	public Padding GlassMargin { get; set; }
	[Category("Behavior")]
	[Description("Indicates whether the form can be dragged by the glass areas inside the client area.")]
	[DefaultValue(True)]
	public bool AllowGlassDragging { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E03A00 Offset: 0x1E02400 VA: 0x181E03A00
	public void add_DwmCompositionChanged(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E03AF0 Offset: 0x1E024F0 VA: 0x181E03AF0
	public void remove_DwmCompositionChanged(EventHandler value) { }

	// RVA: 0x1E039B0 Offset: 0x1E023B0 VA: 0x181E039B0
	public void .ctor() { }

	// RVA: 0x1E03AE0 Offset: 0x1E024E0 VA: 0x181E03AE0
	public bool get_UseSystemFont() { }

	// RVA: 0x1E03C70 Offset: 0x1E02670 VA: 0x181E03C70
	public void set_UseSystemFont(bool value) { }

	// RVA: 0x1E03AC0 Offset: 0x1E024C0 VA: 0x181E03AC0
	public Padding get_GlassMargin() { }

	// RVA: 0x1E03BB0 Offset: 0x1E025B0 VA: 0x181E03BB0
	public void set_GlassMargin(Padding value) { }

	// RVA: 0x1E03AB0 Offset: 0x1E024B0 VA: 0x181E03AB0
	public bool get_AllowGlassDragging() { }

	// RVA: 0x1E03BA0 Offset: 0x1E025A0 VA: 0x181E03BA0
	public void set_AllowGlassDragging(bool value) { }

	// RVA: 0x1E02A20 Offset: 0x1E01420 VA: 0x181E02A20 Slot: 219
	protected virtual void OnDwmCompositionChanged(EventArgs e) { }

	// RVA: 0x1E02B00 Offset: 0x1E01500 VA: 0x181E02B00 Slot: 210
	protected override void OnLoad(EventArgs e) { }

	// RVA: 0x1E02A50 Offset: 0x1E01450 VA: 0x181E02A50 Slot: 214
	protected override void OnFormClosed(FormClosedEventArgs e) { }

	// RVA: 0x1E02BC0 Offset: 0x1E015C0 VA: 0x181E02BC0 Slot: 168
	protected override void OnPaintBackground(PaintEventArgs pevent) { }

	// RVA: 0x1E02DA0 Offset: 0x1E017A0 VA: 0x181E02DA0 Slot: 181
	protected override void OnResize(EventArgs e) { }

	// RVA: 0x1E02AD0 Offset: 0x1E014D0 VA: 0x181E02AD0 Slot: 140
	protected override void OnHandleCreated(EventArgs e) { }

	// RVA: 0x1E036B0 Offset: 0x1E020B0 VA: 0x181E036B0 Slot: 114
	protected override void WndProc(ref Message m) { }

	// RVA: 0x1E03310 Offset: 0x1E01D10 VA: 0x181E03310 Slot: 105
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified) { }

	// RVA: 0x1E02850 Offset: 0x1E01250 VA: 0x181E02850
	private void EnableGlass() { }

	// RVA: 0x1E02E20 Offset: 0x1E01820 VA: 0x181E02E20
	private void PaintGlassArea(PaintEventArgs pevent, Brush brush) { }

	// RVA: 0x1E03650 Offset: 0x1E02050 VA: 0x181E03650
	private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e) { }
}
