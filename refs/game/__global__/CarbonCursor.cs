internal struct CarbonCursor // TypeDefIndex: 5871
{
	// Fields
	private Bitmap bmp; // 0x0
	private Bitmap mask; // 0x8
	private Color cursor_color; // 0x10
	private Color mask_color; // 0x28
	private int hot_x; // 0x40
	private int hot_y; // 0x44
	private StdCursor id; // 0x48
	private bool standard; // 0x4C

	// Methods

	// RVA: 0x22B1300 Offset: 0x22AFD00 VA: 0x1822B1300
	public void .ctor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot) { }

	// RVA: 0x22B13A0 Offset: 0x22AFDA0 VA: 0x1822B13A0
	public void .ctor(StdCursor id) { }

	// RVA: 0x22B1110 Offset: 0x22AFB10 VA: 0x1822B1110
	public void SetCursor() { }

	// RVA: 0x22B1130 Offset: 0x22AFB30 VA: 0x1822B1130
	public void SetCustomCursor() { }

	// RVA: 0x22B1180 Offset: 0x22AFB80 VA: 0x1822B1180
	public void SetStandardCursor() { }

	// RVA: 0x22B1280 Offset: 0x22AFC80 VA: 0x1822B1280
	private static extern int SetThemeCursor(ThemeCursor cursor) { }
}
