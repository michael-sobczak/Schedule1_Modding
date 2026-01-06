internal class Hwnd : IDisposable // TypeDefIndex: 5391
{
	// Fields
	private static Hashtable windows; // 0x0
	private IntPtr handle; // 0x10
	internal IntPtr client_window; // 0x18
	internal IntPtr whole_window; // 0x20
	internal IntPtr cursor; // 0x28
	internal Menu menu; // 0x30
	internal TitleStyle title_style; // 0x38
	internal FormBorderStyle border_style; // 0x3C
	internal bool border_static; // 0x40
	internal int x; // 0x44
	internal int y; // 0x48
	internal int width; // 0x4C
	internal int height; // 0x50
	internal bool allow_drop; // 0x54
	internal Hwnd parent; // 0x58
	internal bool visible; // 0x60
	internal bool mapped; // 0x61
	internal uint opacity; // 0x64
	internal bool enabled; // 0x68
	internal bool zero_sized; // 0x69
	internal ArrayList invalid_list; // 0x70
	internal Rectangle nc_invalid; // 0x78
	internal bool expose_pending; // 0x88
	internal bool nc_expose_pending; // 0x89
	internal bool configure_pending; // 0x8A
	internal bool resizing_or_moving; // 0x8B
	internal bool reparented; // 0x8C
	internal Stack drawing_stack; // 0x90
	internal Rectangle client_rectangle; // 0x98
	internal ArrayList marshal_free_list; // 0xA8
	internal int caption_height; // 0xB0
	internal int tool_caption_height; // 0xB4
	internal bool whacky_wm; // 0xB8
	internal bool fixed_size; // 0xB9
	internal bool zombie; // 0xBA
	internal Region user_clip; // 0xC0
	internal XEventQueue queue; // 0xC8
	internal WindowExStyles initial_ex_style; // 0xD0
	internal WindowStyles initial_style; // 0xD4
	internal FormWindowState cached_window_state; // 0xD8
	internal Point previous_child_startup_location; // 0xDC
	internal static Point previous_main_startup_location; // 0x8
	internal ArrayList children; // 0xE8
	[ThreadStatic]
	private static Bitmap bmp; // 0x80000000
	[ThreadStatic]
	private static Graphics bmp_g; // 0x80000008
	internal object configure_lock; // 0xF0
	internal object expose_lock; // 0xF8

	// Properties
	public static Graphics GraphicsContext { get; }
	public Rectangle ClientRect { get; set; }
	public IntPtr Cursor { get; set; }
	public IntPtr ClientWindow { get; set; }
	public Region UserClip { get; set; }
	public Rectangle DefaultClientRect { get; }
	public IntPtr Handle { get; }
	public int Height { get; set; }
	public bool Reparented { set; }
	public XEventQueue Queue { get; set; }
	public bool Enabled { get; set; }
	public IntPtr EnabledHwnd { get; }
	public Point MenuOrigin { get; }
	public Rectangle Invalid { get; }
	public Rectangle[] ClipRectangles { get; }
	public Hwnd Parent { get; set; }
	public bool Mapped { get; set; }
	public IntPtr WholeWindow { get; set; }
	public int Width { get; set; }
	public int X { get; set; }
	public int Y { get; set; }

	// Methods

	// RVA: 0x2344BA0 Offset: 0x23435A0 VA: 0x182344BA0
	public void .ctor() { }

	// RVA: 0x2344AE0 Offset: 0x23434E0 VA: 0x182344AE0
	private static void .cctor() { }

	// RVA: 0x23429D0 Offset: 0x23413D0 VA: 0x1823429D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2344680 Offset: 0x2343080 VA: 0x182344680
	public static Hwnd ObjectFromWindow(IntPtr window) { }

	// RVA: 0x2344500 Offset: 0x2342F00 VA: 0x182344500
	public static Hwnd ObjectFromHandle(IntPtr handle) { }

	// RVA: 0xC85EC0 Offset: 0xC848C0 VA: 0x180C85EC0
	public static IntPtr HandleFromObject(Hwnd obj) { }

	// RVA: 0x2344270 Offset: 0x2342C70 VA: 0x182344270
	public static Hwnd GetObjectFromWindow(IntPtr window) { }

	// RVA: 0x2343E00 Offset: 0x2342800 VA: 0x182343E00
	public static IntPtr GetHandleFromWindow(IntPtr window) { }

	// RVA: 0x2342CB0 Offset: 0x23416B0 VA: 0x182342CB0
	public static Hwnd.Borders GetBorderWidth(CreateParams cp) { }

	// RVA: 0x23443F0 Offset: 0x2342DF0 VA: 0x1823443F0
	public static Rectangle GetWindowRectangle(CreateParams cp, Menu menu, Rectangle client_rect) { }

	// RVA: 0x2343600 Offset: 0x2342000 VA: 0x182343600
	public ArrayList GetClippingRectangles() { }

	// RVA: 0x2343280 Offset: 0x2341C80 VA: 0x182343280
	public static Hwnd.Borders GetBorders(CreateParams cp, Menu menu) { }

	// RVA: 0x2343510 Offset: 0x2341F10 VA: 0x182343510
	public static Rectangle GetClientRectangle(CreateParams cp, Menu menu, int width, int height) { }

	// RVA: 0x23452E0 Offset: 0x2343CE0 VA: 0x1823452E0
	public static Graphics get_GraphicsContext() { }

	// RVA: 0x2344DE0 Offset: 0x23437E0 VA: 0x182344DE0
	public Rectangle get_ClientRect() { }

	// RVA: 0x143F000 Offset: 0x143DA00 VA: 0x18143F000
	public void set_ClientRect(Rectangle value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public IntPtr get_Cursor() { }

	// RVA: 0x5E0880 Offset: 0x5DF280 VA: 0x1805E0880
	public void set_Cursor(IntPtr value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public IntPtr get_ClientWindow() { }

	// RVA: 0x2345840 Offset: 0x2344240 VA: 0x182345840
	public void set_ClientWindow(IntPtr value) { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public Region get_UserClip() { }

	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	public void set_UserClip(Region value) { }

	// RVA: 0x2345090 Offset: 0x2343A90 VA: 0x182345090
	public Rectangle get_DefaultClientRect() { }

	// RVA: 0x2345420 Offset: 0x2343E20 VA: 0x182345420
	public IntPtr get_Handle() { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public int get_Height() { }

	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	public void set_Height(int value) { }

	// RVA: 0x1A36D50 Offset: 0x1A35750 VA: 0x181A36D50
	public void set_Reparented(bool value) { }

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public XEventQueue get_Queue() { }

	// RVA: 0x4B6CC0 Offset: 0x4B56C0 VA: 0x1804B6CC0
	public void set_Queue(XEventQueue value) { }

	// RVA: 0x23452C0 Offset: 0x2343CC0 VA: 0x1823452C0
	public bool get_Enabled() { }

	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	public void set_Enabled(bool value) { }

	// RVA: 0x2345200 Offset: 0x2343C00 VA: 0x182345200
	public IntPtr get_EnabledHwnd() { }

	// RVA: 0x23456A0 Offset: 0x23440A0 VA: 0x1823456A0
	public Point get_MenuOrigin() { }

	// RVA: 0x23454B0 Offset: 0x2343EB0 VA: 0x1823454B0
	public Rectangle get_Invalid() { }

	// RVA: 0x2344FC0 Offset: 0x23439C0 VA: 0x182344FC0
	public Rectangle[] get_ClipRectangles() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Hwnd get_Parent() { }

	// RVA: 0x2345A00 Offset: 0x2344400 VA: 0x182345A00
	public void set_Parent(Hwnd value) { }

	// RVA: 0x2345680 Offset: 0x2344080 VA: 0x182345680
	public bool get_Mapped() { }

	// RVA: 0x848350 Offset: 0x846D50 VA: 0x180848350
	public void set_Mapped(bool value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public IntPtr get_WholeWindow() { }

	// RVA: 0x2345A90 Offset: 0x2344490 VA: 0x182345A90
	public void set_WholeWindow(IntPtr value) { }

	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	public int get_Width() { }

	// RVA: 0x4E27E0 Offset: 0x4E11E0 VA: 0x1804E27E0
	public void set_Width(int value) { }

	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public int get_X() { }

	// RVA: 0x1EEA950 Offset: 0x1EE9350 VA: 0x181EEA950
	public void set_X(int value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_Y() { }

	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	public void set_Y(int value) { }

	// RVA: 0x2342470 Offset: 0x2340E70 VA: 0x182342470
	public void AddInvalidArea(int x, int y, int width, int height) { }

	// RVA: 0x23424C0 Offset: 0x2340EC0 VA: 0x1823424C0
	public void AddInvalidArea(Rectangle rect) { }

	// RVA: 0x2342940 Offset: 0x2341340 VA: 0x182342940
	public void ClearInvalidArea() { }

	// RVA: 0x23427D0 Offset: 0x23411D0 VA: 0x1823427D0
	public void AddNcInvalidArea(int x, int y, int width, int height) { }

	// RVA: 0x2342980 Offset: 0x2341380 VA: 0x182342980
	public void ClearNcInvalidArea() { }

	// RVA: 0x2344800 Offset: 0x2343200 VA: 0x182344800 Slot: 3
	public override string ToString() { }

	// RVA: 0x2343F90 Offset: 0x2342990 VA: 0x182343F90
	public static Point GetNextStackedFormLocation(CreateParams cp, Hwnd parent_hwnd) { }
}
