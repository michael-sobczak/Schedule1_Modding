public sealed class Graphics : MarshalByRefObject, IDisposable, IDeviceContext // TypeDefIndex: 17146
{
	// Fields
	internal IntPtr nativeObject; // 0x18
	internal IMacContext maccontext; // 0x20
	private bool disposed; // 0x28
	private static float defDpiX; // 0x0
	private static float defDpiY; // 0x4
	private IntPtr deviceContextHdc; // 0x30
	private Metafile.MetafileHolder _metafileHolder; // 0x38

	// Properties
	internal static float systemDpiX { get; }
	internal static float systemDpiY { get; }
	internal IntPtr NativeObject { get; }
	public Region Clip { get; set; }
	public float DpiX { get; }
	public float DpiY { get; }
	public Matrix Transform { get; }

	// Methods

	// RVA: 0x2141210 Offset: 0x213FC10 VA: 0x182141210
	internal void .ctor(IntPtr nativeGraphics) { }

	// RVA: 0x2141240 Offset: 0x213FC40 VA: 0x182141240
	internal void .ctor(IntPtr nativeGraphics, Image image) { }

	// RVA: 0x213F680 Offset: 0x213E080 VA: 0x18213F680 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2141520 Offset: 0x213FF20 VA: 0x182141520
	internal static float get_systemDpiX() { }

	// RVA: 0x2141610 Offset: 0x2140010 VA: 0x182141610
	internal static float get_systemDpiY() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal IntPtr get_NativeObject() { }

	// RVA: 0x213D110 Offset: 0x213BB10 VA: 0x18213D110
	public void Clear(Color color) { }

	// RVA: 0x213D190 Offset: 0x213BB90 VA: 0x18213D190 Slot: 6
	public void Dispose() { }

	// RVA: 0x213D380 Offset: 0x213BD80 VA: 0x18213D380
	public void DrawIcon(Icon icon, Rectangle targetRect) { }

	// RVA: 0x213D500 Offset: 0x213BF00 VA: 0x18213D500
	public void DrawIcon(Icon icon, int x, int y) { }

	// RVA: 0x213DDF0 Offset: 0x213C7F0 VA: 0x18213DDF0
	public void DrawImage(Image image, Point point) { }

	// RVA: 0x213DBF0 Offset: 0x213C5F0 VA: 0x18213DBF0
	public void DrawImage(Image image, Rectangle rect) { }

	// RVA: 0x213E040 Offset: 0x213CA40 VA: 0x18213E040
	public void DrawImage(Image image, int x, int y) { }

	// RVA: 0x213DEE0 Offset: 0x213C8E0 VA: 0x18213DEE0
	public void DrawImage(Image image, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit) { }

	// RVA: 0x213DD00 Offset: 0x213C700 VA: 0x18213DD00
	public void DrawImage(Image image, int x, int y, int width, int height) { }

	// RVA: 0x213DA70 Offset: 0x213C470 VA: 0x18213DA70
	public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttr) { }

	// RVA: 0x213D740 Offset: 0x213C140 VA: 0x18213D740
	public void DrawImageUnscaled(Image image, int x, int y, int width, int height) { }

	// RVA: 0x213D650 Offset: 0x213C050 VA: 0x18213D650
	public void DrawImageUnscaledAndClipped(Image image, Rectangle rect) { }

	// RVA: 0x213E120 Offset: 0x213CB20 VA: 0x18213E120
	public void DrawLine(Pen pen, Point pt1, Point pt2) { }

	// RVA: 0x213E380 Offset: 0x213CD80 VA: 0x18213E380
	public void DrawLine(Pen pen, int x1, int y1, int x2, int y2) { }

	// RVA: 0x213E210 Offset: 0x213CC10 VA: 0x18213E210
	public void DrawLine(Pen pen, float x1, float y1, float x2, float y2) { }

	// RVA: 0x213E470 Offset: 0x213CE70 VA: 0x18213E470
	public void DrawLines(Pen pen, Point[] points) { }

	// RVA: 0x213E5A0 Offset: 0x213CFA0 VA: 0x18213E5A0
	public void DrawPolygon(Pen pen, Point[] points) { }

	// RVA: 0x213E7C0 Offset: 0x213D1C0 VA: 0x18213E7C0
	public void DrawRectangle(Pen pen, Rectangle rect) { }

	// RVA: 0x213E6D0 Offset: 0x213D0D0 VA: 0x18213E6D0
	public void DrawRectangle(Pen pen, int x, int y, int width, int height) { }

	// RVA: 0x213EBE0 Offset: 0x213D5E0 VA: 0x18213EBE0
	public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle) { }

	// RVA: 0x213E8D0 Offset: 0x213D2D0 VA: 0x18213E8D0
	public void DrawString(string s, Font font, Brush brush, PointF point) { }

	// RVA: 0x213ED60 Offset: 0x213D760 VA: 0x18213ED60
	public void DrawString(string s, Font font, Brush brush, float x, float y, StringFormat format) { }

	// RVA: 0x213EA60 Offset: 0x213D460 VA: 0x18213EA60
	public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format) { }

	// RVA: 0x213EF10 Offset: 0x213D910 VA: 0x18213EF10
	public void FillEllipse(Brush brush, Rectangle rect) { }

	// RVA: 0x213F020 Offset: 0x213DA20 VA: 0x18213F020
	public void FillEllipse(Brush brush, int x, int y, int width, int height) { }

	// RVA: 0x213F110 Offset: 0x213DB10 VA: 0x18213F110
	public void FillPolygon(Brush brush, PointF[] points) { }

	// RVA: 0x213F240 Offset: 0x213DC40 VA: 0x18213F240
	public void FillPolygon(Brush brush, Point[] points, FillMode fillMode) { }

	// RVA: 0x213F480 Offset: 0x213DE80 VA: 0x18213F480
	public void FillRectangle(Brush brush, Rectangle rect) { }

	// RVA: 0x213F590 Offset: 0x213DF90 VA: 0x18213F590
	public void FillRectangle(Brush brush, int x, int y, int width, int height) { }

	// RVA: 0x213F380 Offset: 0x213DD80 VA: 0x18213F380
	public void FillRectangle(Brush brush, float x, float y, float width, float height) { }

	// RVA: 0x213F6E0 Offset: 0x213E0E0 VA: 0x18213F6E0
	public void Flush() { }

	// RVA: 0x213F780 Offset: 0x213E180 VA: 0x18213F780
	public void Flush(FlushIntention intention) { }

	[EditorBrowsable(2)]
	// RVA: 0x213F890 Offset: 0x213E290 VA: 0x18213F890
	public static Graphics FromHdc(IntPtr hdc) { }

	[EditorBrowsable(2)]
	// RVA: 0x213F830 Offset: 0x213E230 VA: 0x18213F830
	public static Graphics FromHdcInternal(IntPtr hdc) { }

	[EditorBrowsable(2)]
	// RVA: 0x213F940 Offset: 0x213E340 VA: 0x18213F940
	public static Graphics FromHwnd(IntPtr hwnd) { }

	// RVA: 0x213FE90 Offset: 0x213E890 VA: 0x18213FE90
	public static Graphics FromImage(Image image) { }

	// RVA: 0x21400A0 Offset: 0x213EAA0 VA: 0x1821400A0
	internal static Graphics FromXDrawable(IntPtr drawable, IntPtr display) { }

	// RVA: 0x21402C0 Offset: 0x213ECC0 VA: 0x1821402C0 Slot: 7
	public IntPtr GetHdc() { }

	// RVA: 0x2140150 Offset: 0x213EB50 VA: 0x182140150
	private SizeF GdipMeasureString(IntPtr graphics, string text, Font font, ref RectangleF layoutRect, IntPtr stringFormat) { }

	// RVA: 0x2140670 Offset: 0x213F070 VA: 0x182140670
	public SizeF MeasureString(string text, Font font) { }

	// RVA: 0x2140330 Offset: 0x213ED30 VA: 0x182140330
	public SizeF MeasureString(string text, Font font, SizeF layoutArea) { }

	// RVA: 0x21409D0 Offset: 0x213F3D0 VA: 0x1821409D0
	public SizeF MeasureString(string text, Font font, int width) { }

	// RVA: 0x2140820 Offset: 0x213F220 VA: 0x182140820
	public SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat) { }

	// RVA: 0x21404C0 Offset: 0x213EEC0 VA: 0x1821404C0
	public SizeF MeasureString(string text, Font font, int width, StringFormat format) { }

	[EditorBrowsable(2)]
	// RVA: 0x2140C00 Offset: 0x213F600 VA: 0x182140C00
	public void ReleaseHdc(IntPtr hdc) { }

	// RVA: 0x2140C10 Offset: 0x213F610 VA: 0x182140C10 Slot: 8
	public void ReleaseHdc() { }

	[EditorBrowsable(1)]
	[MonoLimitation("Can only be used when hdc was provided by Graphics.GetHdc() method")]
	// RVA: 0x2140B50 Offset: 0x213F550 VA: 0x182140B50
	public void ReleaseHdcInternal(IntPtr hdc) { }

	// RVA: 0x2140C20 Offset: 0x213F620 VA: 0x182140C20
	public void ResetClip() { }

	// RVA: 0x2140C80 Offset: 0x213F680 VA: 0x182140C80
	public void ResetTransform() { }

	// RVA: 0x2140CE0 Offset: 0x213F6E0 VA: 0x182140CE0
	public void Restore(GraphicsState gstate) { }

	// RVA: 0x2140DE0 Offset: 0x213F7E0 VA: 0x182140DE0
	public void RotateTransform(float angle) { }

	// RVA: 0x2140D60 Offset: 0x213F760 VA: 0x182140D60
	public void RotateTransform(float angle, MatrixOrder order) { }

	// RVA: 0x2140E50 Offset: 0x213F850 VA: 0x182140E50
	public GraphicsState Save() { }

	// RVA: 0x2141060 Offset: 0x213FA60 VA: 0x182141060
	public void SetClip(Rectangle rect) { }

	// RVA: 0x2140EF0 Offset: 0x213F8F0 VA: 0x182140EF0
	public void SetClip(Rectangle rect, CombineMode combineMode) { }

	// RVA: 0x2140F90 Offset: 0x213F990 VA: 0x182140F90
	public void SetClip(Region region, CombineMode combineMode) { }

	// RVA: 0x2141190 Offset: 0x213FB90 VA: 0x182141190
	public void TranslateTransform(float dx, float dy) { }

	// RVA: 0x2141100 Offset: 0x213FB00 VA: 0x182141100
	public void TranslateTransform(float dx, float dy, MatrixOrder order) { }

	// RVA: 0x21412E0 Offset: 0x213FCE0 VA: 0x1821412E0
	public Region get_Clip() { }

	// RVA: 0x2141710 Offset: 0x2140110 VA: 0x182141710
	public void set_Clip(Region value) { }

	// RVA: 0x2141390 Offset: 0x213FD90 VA: 0x182141390
	public float get_DpiX() { }

	// RVA: 0x2141400 Offset: 0x213FE00 VA: 0x182141400
	public float get_DpiY() { }

	// RVA: 0x2141470 Offset: 0x213FE70 VA: 0x182141470
	public Matrix get_Transform() { }
}
