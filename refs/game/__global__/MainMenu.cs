public class MainMenu : Menu // TypeDefIndex: 5478
{
	// Fields
	private RightToLeft right_to_left; // 0x70
	private Form form; // 0x78
	private static object CollapseEvent; // 0x0
	private static object PaintEvent; // 0x8

	// Methods

	// RVA: 0x2378420 Offset: 0x2376E20 VA: 0x182378420
	public void .ctor() { }

	// RVA: 0x2378360 Offset: 0x2376D60 VA: 0x182378360
	private static void .cctor() { }

	// RVA: 0x2378480 Offset: 0x2376E80 VA: 0x182378480
	internal void add_Paint(PaintEventHandler value) { }

	// RVA: 0x2378510 Offset: 0x2376F10 VA: 0x182378510
	internal void remove_Paint(PaintEventHandler value) { }

	// RVA: 0x23778B0 Offset: 0x23762B0 VA: 0x1823778B0 Slot: 18
	public virtual MainMenu CloneMenu() { }

	// RVA: 0x2377950 Offset: 0x2376350 VA: 0x182377950 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public Form GetForm() { }

	// RVA: 0x2378310 Offset: 0x2376D10 VA: 0x182378310 Slot: 3
	public override string ToString() { }

	// RVA: 0x2377E90 Offset: 0x2376890 VA: 0x182377E90 Slot: 19
	protected internal virtual void OnCollapse(EventArgs e) { }

	// RVA: 0x2377D50 Offset: 0x2376750 VA: 0x182377D50
	internal void Draw() { }

	// RVA: 0x2377960 Offset: 0x2376360 VA: 0x182377960
	internal void Draw(Rectangle rect) { }

	// RVA: 0x2377B90 Offset: 0x2376590 VA: 0x182377B90
	internal void Draw(PaintEventArgs pe, Rectangle rect) { }

	// RVA: 0x2377E60 Offset: 0x2376860 VA: 0x182377E60 Slot: 15
	internal override void InvalidateItem(MenuItem item) { }

	// RVA: 0x2378250 Offset: 0x2376C50 VA: 0x182378250
	internal void SetForm(Form form) { }

	// RVA: 0x2377F60 Offset: 0x2376960 VA: 0x182377F60 Slot: 14
	internal override void OnMenuChanged(EventArgs e) { }

	// RVA: 0x2378120 Offset: 0x2376B20 VA: 0x182378120
	internal void OnMouseDown(object window, MouseEventArgs args) { }

	// RVA: 0x2378150 Offset: 0x2376B50 VA: 0x182378150
	internal void OnMouseMove(object window, MouseEventArgs e) { }
}
