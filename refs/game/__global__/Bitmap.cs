public sealed class Bitmap : Image // TypeDefIndex: 17115
{
	// Methods

	// RVA: 0x21346E0 Offset: 0x21330E0 VA: 0x1821346E0
	private void .ctor() { }

	// RVA: 0x2134600 Offset: 0x2133000 VA: 0x182134600
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x21349F0 Offset: 0x21333F0 VA: 0x1821349F0
	internal void .ctor(IntPtr ptr, Stream stream) { }

	// RVA: 0x21346C0 Offset: 0x21330C0 VA: 0x1821346C0
	public void .ctor(int width, int height) { }

	// RVA: 0x21346F0 Offset: 0x21330F0 VA: 0x1821346F0
	public void .ctor(int width, int height, Graphics g) { }

	// RVA: 0x2134540 Offset: 0x2132F40 VA: 0x182134540
	public void .ctor(int width, int height, PixelFormat format) { }

	// RVA: 0x2134660 Offset: 0x2133060 VA: 0x182134660
	public void .ctor(Image original) { }

	// RVA: 0x2134630 Offset: 0x2133030 VA: 0x182134630
	public void .ctor(Stream stream) { }

	// RVA: 0x2134520 Offset: 0x2132F20 VA: 0x182134520
	public void .ctor(Image original, Size newSize) { }

	// RVA: 0x2134630 Offset: 0x2133030 VA: 0x182134630
	public void .ctor(Stream stream, bool useIcm) { }

	// RVA: 0x21348B0 Offset: 0x21332B0 VA: 0x1821348B0
	public void .ctor(Image original, int width, int height) { }

	// RVA: 0x21347F0 Offset: 0x21331F0 VA: 0x1821347F0
	public void .ctor(int width, int height, int stride, PixelFormat format, IntPtr scan0) { }

	// RVA: 0x2134500 Offset: 0x2132F00 VA: 0x182134500
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2133E40 Offset: 0x2132840 VA: 0x182133E40
	public Color GetPixel(int x, int y) { }

	// RVA: 0x2134360 Offset: 0x2132D60 VA: 0x182134360
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x2133C40 Offset: 0x2132640 VA: 0x182133C40
	public static Bitmap FromHicon(IntPtr hicon) { }

	[EditorBrowsable(2)]
	// RVA: 0x2133D70 Offset: 0x2132770 VA: 0x182133D70
	public IntPtr GetHbitmap() { }

	[EditorBrowsable(2)]
	// RVA: 0x2133CE0 Offset: 0x21326E0 VA: 0x182133CE0
	public IntPtr GetHbitmap(Color background) { }

	// RVA: 0x2133F20 Offset: 0x2132920 VA: 0x182133F20
	public BitmapData LockBits(Rectangle rect, ImageLockMode flags, PixelFormat format) { }

	// RVA: 0x2134000 Offset: 0x2132A00 VA: 0x182134000
	public BitmapData LockBits(Rectangle rect, ImageLockMode flags, PixelFormat format, BitmapData bitmapData) { }

	// RVA: 0x21340B0 Offset: 0x2132AB0 VA: 0x1821340B0
	public void MakeTransparent(Color transparentColor) { }

	// RVA: 0x2134490 Offset: 0x2132E90 VA: 0x182134490
	public void UnlockBits(BitmapData bitmapdata) { }
}
