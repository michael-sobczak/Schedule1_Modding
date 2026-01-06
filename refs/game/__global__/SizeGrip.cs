internal class SizeGrip : Control // TypeDefIndex: 5566
{
	// Fields
	private Point capture_point; // 0x1D8
	private Control captured_control; // 0x1E0
	private int window_w; // 0x1E8
	private int window_h; // 0x1EC
	private bool hide_pending; // 0x1F0
	private bool captured; // 0x1F1
	private bool is_virtual; // 0x1F2
	private bool enabled; // 0x1F3
	private bool fill_background; // 0x1F4
	private Rectangle last_painted_area; // 0x1F8

	// Properties
	public bool FillBackground { set; }
	public bool Virtual { set; }
	public Control CapturedControl { get; set; }

	// Methods

	// RVA: 0x21E4CD0 Offset: 0x21E36D0 VA: 0x1821E4CD0
	public void .ctor(Control CapturedControl) { }

	// RVA: 0x21E4DB0 Offset: 0x21E37B0 VA: 0x1821E4DB0
	public void set_FillBackground(bool value) { }

	// RVA: 0x21E4DC0 Offset: 0x21E37C0 VA: 0x1821E4DC0
	public void set_Virtual(bool value) { }

	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public Control get_CapturedControl() { }

	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	public void set_CapturedControl(Control value) { }

	// RVA: 0x21E3C00 Offset: 0x21E2600 VA: 0x1821E3C00
	internal static Size GetDefaultSize() { }

	// RVA: 0x21E3B60 Offset: 0x21E2560 VA: 0x1821E3B60
	internal static Rectangle GetDefaultRectangle(Control Parent) { }

	// RVA: 0x21E4810 Offset: 0x21E3210 VA: 0x1821E4810
	private void HandleResize(object sender, EventArgs e) { }

	// RVA: 0x21E3C40 Offset: 0x21E2640 VA: 0x1821E3C40
	private void HandleEnabledChanged(object sender, EventArgs e) { }

	// RVA: 0x21E44D0 Offset: 0x21E2ED0 VA: 0x1821E44D0
	internal void HandlePaint(object sender, PaintEventArgs e) { }

	// RVA: 0x21E3DB0 Offset: 0x21E27B0 VA: 0x1821E3DB0
	private void HandleMouseCaptureChanged(object sender, EventArgs e) { }

	// RVA: 0x21E3E90 Offset: 0x21E2890 VA: 0x1821E3E90
	internal void HandleMouseDown(object sender, MouseEventArgs e) { }

	// RVA: 0x21E4050 Offset: 0x21E2A50 VA: 0x1821E4050
	internal void HandleMouseMove(object sender, MouseEventArgs e) { }

	// RVA: 0x21E4370 Offset: 0x21E2D70 VA: 0x1821E4370
	internal void HandleMouseUp(object sender, MouseEventArgs e) { }

	// RVA: 0x21E4CB0 Offset: 0x21E36B0 VA: 0x1821E4CB0 Slot: 111
	protected override void SetVisibleCore(bool value) { }

	// RVA: 0x21E4C70 Offset: 0x21E3670 VA: 0x1821E4C70 Slot: 165
	protected override void OnPaint(PaintEventArgs pe) { }

	// RVA: 0x21E4A20 Offset: 0x21E3420 VA: 0x1821E4A20 Slot: 152
	protected override void OnMouseCaptureChanged(EventArgs e) { }

	// RVA: 0x21E48B0 Offset: 0x21E32B0 VA: 0x1821E48B0 Slot: 134
	protected override void OnEnabledChanged(EventArgs e) { }

	// RVA: 0x21E4B10 Offset: 0x21E3510 VA: 0x1821E4B10 Slot: 155
	protected override void OnMouseDown(MouseEventArgs e) { }

	// RVA: 0x21E4B20 Offset: 0x21E3520 VA: 0x1821E4B20 Slot: 159
	protected override void OnMouseMove(MouseEventArgs e) { }

	// RVA: 0x21E4B30 Offset: 0x21E3530 VA: 0x1821E4B30 Slot: 160
	protected override void OnMouseUp(MouseEventArgs e) { }
}
