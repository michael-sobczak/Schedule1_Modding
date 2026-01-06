public abstract class Image : MarshalByRefObject, IDisposable, ICloneable, ISerializable // TypeDefIndex: 17156
{
	// Fields
	internal IntPtr nativeObject; // 0x18
	internal Stream stream; // 0x20

	// Properties
	[Browsable(False)]
	public Guid[] FrameDimensionsList { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[DefaultValue(False)]
	public int Height { get; }
	[Browsable(False)]
	public ColorPalette Palette { get; set; }
	public PixelFormat PixelFormat { get; }
	public ImageFormat RawFormat { get; }
	public Size Size { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[DefaultValue(False)]
	public int Width { get; }
	internal IntPtr NativeObject { get; }
	internal IntPtr nativeImage { get; }

	// Methods

	// RVA: 0x215FBD0 Offset: 0x215E5D0 VA: 0x18215FBD0
	internal void .ctor() { }

	// RVA: 0x215FA30 Offset: 0x215E430 VA: 0x18215FA30
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x215F860 Offset: 0x215E260 VA: 0x18215F860 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x215E1C0 Offset: 0x215CBC0 VA: 0x18215E1C0
	public static Bitmap FromHbitmap(IntPtr hbitmap) { }

	// RVA: 0x215E0C0 Offset: 0x215CAC0 VA: 0x18215E0C0
	public static Bitmap FromHbitmap(IntPtr hbitmap, IntPtr hpalette) { }

	// RVA: 0x215E2C0 Offset: 0x215CCC0 VA: 0x18215E2C0
	public static Image FromStream(Stream stream) { }

	// RVA: 0x215ED40 Offset: 0x215D740 VA: 0x18215ED40
	internal static Image LoadFromStream(Stream stream, bool keepAlive) { }

	// RVA: 0x215DDC0 Offset: 0x215C7C0 VA: 0x18215DDC0
	internal static Image CreateFromHandle(IntPtr handle) { }

	// RVA: 0x215E7D0 Offset: 0x215D1D0 VA: 0x18215E7D0
	internal static IntPtr InitFromStream(Stream stream) { }

	// RVA: 0x215E2D0 Offset: 0x215CCD0 VA: 0x18215E2D0
	public int GetFrameCount(FrameDimension dimension) { }

	// RVA: 0x215E3D0 Offset: 0x215CDD0 VA: 0x18215E3D0
	public PropertyItem GetPropertyItem(int propid) { }

	// RVA: 0x215EFB0 Offset: 0x215D9B0 VA: 0x18215EFB0
	public void RotateFlip(RotateFlipType rotateFlipType) { }

	// RVA: 0x215FBE0 Offset: 0x215E5E0 VA: 0x18215FBE0
	internal ImageCodecInfo findEncoderForFormat(ImageFormat format) { }

	// RVA: 0x215F530 Offset: 0x215DF30 VA: 0x18215F530
	public void Save(Stream stream, ImageFormat format) { }

	// RVA: 0x215F080 Offset: 0x215DA80 VA: 0x18215F080
	public void Save(Stream stream, ImageCodecInfo encoder, EncoderParameters encoderParams) { }

	// RVA: 0x215F760 Offset: 0x215E160 VA: 0x18215F760
	public int SelectActiveFrame(FrameDimension dimension, int frameIndex) { }

	// RVA: 0x215FD40 Offset: 0x215E740 VA: 0x18215FD40
	public Guid[] get_FrameDimensionsList() { }

	// RVA: 0x215FF30 Offset: 0x215E930 VA: 0x18215FF30
	public int get_Height() { }

	// RVA: 0x2160000 Offset: 0x215EA00 VA: 0x182160000
	public ColorPalette get_Palette() { }

	// RVA: 0x2160810 Offset: 0x215F210 VA: 0x182160810
	public void set_Palette(ColorPalette value) { }

	// RVA: 0x2160430 Offset: 0x215EE30 VA: 0x182160430
	internal ColorPalette retrieveGDIPalette() { }

	// RVA: 0x2160820 Offset: 0x215F220 VA: 0x182160820
	internal void storeGDIPalette(ColorPalette palette) { }

	// RVA: 0x2160010 Offset: 0x215EA10 VA: 0x182160010
	public PixelFormat get_PixelFormat() { }

	// RVA: 0x21600E0 Offset: 0x215EAE0 VA: 0x1821600E0
	public ImageFormat get_RawFormat() { }

	// RVA: 0x21601E0 Offset: 0x215EBE0 VA: 0x1821601E0
	public Size get_Size() { }

	// RVA: 0x2160360 Offset: 0x215ED60 VA: 0x182160360
	public int get_Width() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal IntPtr get_NativeObject() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal IntPtr get_nativeImage() { }

	// RVA: 0x215DF60 Offset: 0x215C960 VA: 0x18215DF60 Slot: 6
	public void Dispose() { }

	// RVA: 0x2134C60 Offset: 0x2133660 VA: 0x182134C60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x215DFD0 Offset: 0x215C9D0 VA: 0x18215DFD0 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x215DC30 Offset: 0x215C630 VA: 0x18215DC30 Slot: 7
	public object Clone() { }

	// RVA: 0x215D9B0 Offset: 0x215C3B0 VA: 0x18215D9B0
	private object CloneFromStream() { }
}
