public sealed class BitmapData // TypeDefIndex: 17217
{
	// Fields
	private int width; // 0x10
	private int height; // 0x14
	private int stride; // 0x18
	private PixelFormat pixel_format; // 0x1C
	private IntPtr scan0; // 0x20
	private int reserved; // 0x28
	private IntPtr palette; // 0x30
	private int property_count; // 0x38
	private IntPtr property; // 0x40
	private float dpi_horz; // 0x48
	private float dpi_vert; // 0x4C
	private int image_flags; // 0x50
	private int left; // 0x54
	private int top; // 0x58
	private int x; // 0x5C
	private int y; // 0x60
	private int transparent; // 0x64

	// Properties
	public int Height { get; }
	public int Width { get; }
	public IntPtr Scan0 { get; }
	public int Stride { get; }

	// Methods

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_Height() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_Width() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public IntPtr get_Scan0() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Stride() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
