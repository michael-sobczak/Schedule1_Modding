internal class ToolBarItem : Component // TypeDefIndex: 5603
{
	// Fields
	private ToolBar toolbar; // 0x28
	private ToolBarButton button; // 0x30
	private Rectangle bounds; // 0x38
	private Rectangle image_rect; // 0x48
	private Rectangle text_rect; // 0x58
	private bool dd_pressed; // 0x68
	private bool inside; // 0x69
	private bool hilight; // 0x6A
	private bool pressed; // 0x6B

	// Properties
	public ToolBarButton Button { get; }
	public Rectangle Rectangle { get; }
	public Point Location { get; set; }
	public Rectangle ImageRectangle { get; }
	public Rectangle TextRectangle { get; }
	private Size TextSize { get; }
	public bool Pressed { get; set; }
	public bool DDPressed { get; set; }
	public bool Inside { get; set; }
	public bool Hilight { get; set; }

	// Methods

	// RVA: 0x2226FE0 Offset: 0x22259E0 VA: 0x182226FE0
	public void .ctor(ToolBarButton button) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public ToolBarButton get_Button() { }

	// RVA: 0x22270C0 Offset: 0x2225AC0 VA: 0x1822270C0
	public Rectangle get_Rectangle() { }

	// RVA: 0x2227090 Offset: 0x2225A90 VA: 0x182227090
	public Point get_Location() { }

	// RVA: 0x2227450 Offset: 0x2225E50 VA: 0x182227450
	public void set_Location(Point value) { }

	// RVA: 0x2227070 Offset: 0x2225A70 VA: 0x182227070
	public Rectangle get_ImageRectangle() { }

	// RVA: 0x22271D0 Offset: 0x2225BD0 VA: 0x1822271D0
	public Rectangle get_TextRectangle() { }

	// RVA: 0x22271F0 Offset: 0x2225BF0 VA: 0x1822271F0
	private Size get_TextSize() { }

	// RVA: 0x22270A0 Offset: 0x2225AA0 VA: 0x1822270A0
	public bool get_Pressed() { }

	// RVA: 0xCE3DE0 Offset: 0xCE27E0 VA: 0x180CE3DE0
	public void set_Pressed(bool value) { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_DDPressed() { }

	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	public void set_DDPressed(bool value) { }

	// RVA: 0xCE3D90 Offset: 0xCE2790 VA: 0x180CE3D90
	public bool get_Inside() { }

	// RVA: 0xCE3DF0 Offset: 0xCE27F0 VA: 0x180CE3DF0
	public void set_Inside(bool value) { }

	// RVA: 0xCE3DD0 Offset: 0xCE27D0 VA: 0x180CE3DD0
	public bool get_Hilight() { }

	// RVA: 0x2227400 Offset: 0x2225E00 VA: 0x182227400
	public void set_Hilight(bool value) { }

	// RVA: 0x22267B0 Offset: 0x22251B0 VA: 0x1822267B0
	public Size CalculateSize() { }

	// RVA: 0x2226F10 Offset: 0x2225910 VA: 0x182226F10
	public bool Layout(bool vertical, int calculated_size) { }

	// RVA: 0x2226BB0 Offset: 0x22255B0 VA: 0x182226BB0
	public bool Layout(Size size) { }

	// RVA: 0x2226B60 Offset: 0x2225560 VA: 0x182226B60
	public void Invalidate() { }
}
