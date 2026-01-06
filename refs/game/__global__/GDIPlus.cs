internal class GDIPlus // TypeDefIndex: 17180
{
	// Fields
	public static IntPtr Display; // 0x0
	public static bool UseX11Drawable; // 0x8
	public static bool UseCarbonDrawable; // 0x9
	public static bool UseCocoaDrawable; // 0xA
	internal static ulong GdiPlusToken; // 0x10

	// Methods

	// RVA: 0x2156B60 Offset: 0x2155560 VA: 0x182156B60
	internal static extern Status GdiplusStartup(ref ulong token, ref GdiplusStartupInput input, ref GdiplusStartupOutput output) { }

	// RVA: 0x2156D20 Offset: 0x2155720 VA: 0x182156D20
	private static void ProcessExit(object sender, EventArgs e) { }

	// RVA: 0x21570C0 Offset: 0x2155AC0 VA: 0x1821570C0
	private static void .cctor() { }

	// RVA: 0x2156E90 Offset: 0x2155890 VA: 0x182156E90
	public static bool RunningOnWindows() { }

	// RVA: 0x2156DF0 Offset: 0x21557F0 VA: 0x182156DF0
	public static bool RunningOnUnix() { }

	// RVA: 0x2150A20 Offset: 0x214F420 VA: 0x182150A20
	internal static void CheckStatus(Status status) { }

	// RVA: 0x2151B10 Offset: 0x2150510 VA: 0x182151B10
	internal static extern int GdipCloneBrush(HandleRef brush, out IntPtr clonedBrush) { }

	// RVA: 0x2152E90 Offset: 0x2151890 VA: 0x182152E90
	internal static extern int GdipDeleteBrush(HandleRef brush) { }

	// RVA: 0x2152C50 Offset: 0x2151650 VA: 0x182152C50
	internal static extern Status GdipCreateRegion(out IntPtr region) { }

	// RVA: 0x2153210 Offset: 0x2151C10 VA: 0x182153210
	internal static extern Status GdipDeleteRegion(IntPtr region) { }

	// RVA: 0x2152BC0 Offset: 0x21515C0 VA: 0x182152BC0
	internal static extern Status GdipCreateRegionRectI(ref Rectangle rect, out IntPtr region) { }

	// RVA: 0x2151E70 Offset: 0x2150870 VA: 0x182151E70
	internal static extern Status GdipCombineRegionRectI(IntPtr region, ref Rectangle rect, CombineMode combineMode) { }

	// RVA: 0x2154FD0 Offset: 0x21539D0 VA: 0x182154FD0
	internal static extern Status GdipGetRegionBounds(IntPtr region, IntPtr graphics, ref RectangleF rect) { }

	// RVA: 0x21562E0 Offset: 0x2154CE0 VA: 0x1821562E0
	internal static extern Status GdipSetEmpty(IntPtr region) { }

	// RVA: 0x21556C0 Offset: 0x21540C0 VA: 0x1821556C0
	internal static extern Status GdipIsInfiniteRegion(IntPtr region, IntPtr graphics, out bool result) { }

	// RVA: 0x2151F10 Offset: 0x2150910 VA: 0x182151F10
	internal static extern Status GdipCombineRegionRegion(IntPtr region, IntPtr region2, CombineMode combineMode) { }

	// RVA: 0x2155070 Offset: 0x2153A70 VA: 0x182155070
	internal static extern Status GdipGetRegionHRgn(IntPtr region, IntPtr graphics, ref IntPtr hRgn) { }

	// RVA: 0x2152B30 Offset: 0x2151530 VA: 0x182152B30
	internal static extern Status GdipCreateRegionHrgn(IntPtr hRgn, out IntPtr region) { }

	// RVA: 0x2152CD0 Offset: 0x21516D0 VA: 0x182152CD0
	internal static extern int GdipCreateSolidFill(int color, out IntPtr brush) { }

	// RVA: 0x21526B0 Offset: 0x21510B0 VA: 0x1821526B0
	internal static extern int GdipCreateHatchBrush(int hatchstyle, int foreColor, int backColor, out IntPtr brush) { }

	// RVA: 0x2152DF0 Offset: 0x21517F0 VA: 0x182152DF0
	internal static extern int GdipCreateTexture(HandleRef image, int wrapMode, out IntPtr texture) { }

	// RVA: 0x2152890 Offset: 0x2151290 VA: 0x182152890
	internal static extern Status GdipCreateLineBrushI(ref Point point1, ref Point point2, int color1, int color2, WrapMode wrapMode, out IntPtr brush) { }

	// RVA: 0x21527D0 Offset: 0x21511D0 VA: 0x1821527D0
	internal static extern Status GdipCreateLineBrushFromRectI(ref Rectangle rect, int color1, int color2, LinearGradientMode linearGradientMode, WrapMode wrapMode, out IntPtr brush) { }

	// RVA: 0x2154CA0 Offset: 0x21536A0 VA: 0x182154CA0
	internal static extern Status GdipGetLineRect(IntPtr brush, out RectangleF rect) { }

	// RVA: 0x2152450 Offset: 0x2150E50 VA: 0x182152450
	internal static extern Status GdipCreateFromHDC(IntPtr hDC, out IntPtr graphics) { }

	// RVA: 0x2153010 Offset: 0x2151A10 VA: 0x182153010
	internal static extern Status GdipDeleteGraphics(IntPtr graphics) { }

	// RVA: 0x2155DB0 Offset: 0x21547B0 VA: 0x182155DB0
	internal static extern Status GdipRestoreGraphics(IntPtr graphics, uint graphicsState) { }

	// RVA: 0x2155EE0 Offset: 0x21548E0 VA: 0x182155EE0
	internal static extern Status GdipSaveGraphics(IntPtr graphics, out uint state) { }

	// RVA: 0x2155E40 Offset: 0x2154840 VA: 0x182155E40
	internal static extern Status GdipRotateWorldTransform(IntPtr graphics, float angle, MatrixOrder order) { }

	// RVA: 0x2156AB0 Offset: 0x21554B0 VA: 0x182156AB0
	internal static extern Status GdipTranslateWorldTransform(IntPtr graphics, float dx, float dy, MatrixOrder order) { }

	// RVA: 0x2153710 Offset: 0x2152110 VA: 0x182153710
	internal static extern Status GdipDrawLine(IntPtr graphics, IntPtr pen, float x1, float y1, float x2, float y2) { }

	// RVA: 0x2153650 Offset: 0x2152050 VA: 0x182153650
	internal static extern Status GdipDrawLineI(IntPtr graphics, IntPtr pen, int x1, int y1, int x2, int y2) { }

	// RVA: 0x21537E0 Offset: 0x21521E0 VA: 0x1821537E0
	internal static extern Status GdipDrawLinesI(IntPtr graphics, IntPtr pen, Point[] points, int count) { }

	// RVA: 0x21538A0 Offset: 0x21522A0 VA: 0x1821538A0
	internal static extern Status GdipDrawPolygonI(IntPtr graphics, IntPtr pen, Point[] points, int count) { }

	// RVA: 0x2153960 Offset: 0x2152360 VA: 0x182153960
	internal static extern Status GdipDrawRectangleI(IntPtr graphics, IntPtr pen, int x, int y, int width, int height) { }

	// RVA: 0x2153B00 Offset: 0x2152500 VA: 0x182153B00
	internal static extern Status GdipFillEllipseI(IntPtr graphics, IntPtr pen, int x, int y, int width, int height) { }

	// RVA: 0x2153C80 Offset: 0x2152680 VA: 0x182153C80
	internal static extern Status GdipFillPolygonI(IntPtr graphics, IntPtr brush, Point[] points, int count, FillMode fillMode) { }

	// RVA: 0x2153BC0 Offset: 0x21525C0 VA: 0x182153BC0
	internal static extern Status GdipFillPolygon2(IntPtr graphics, IntPtr brush, PointF[] points, int count) { }

	// RVA: 0x2153E00 Offset: 0x2152800 VA: 0x182153E00
	internal static extern Status GdipFillRectangle(IntPtr graphics, IntPtr brush, float x1, float y1, float x2, float y2) { }

	// RVA: 0x2153D40 Offset: 0x2152740 VA: 0x182153D40
	internal static extern Status GdipFillRectangleI(IntPtr graphics, IntPtr brush, int x1, int y1, int x2, int y2) { }

	// RVA: 0x2153A20 Offset: 0x2152420 VA: 0x182153A20
	internal static extern Status GdipDrawString(IntPtr graphics, string text, int len, IntPtr font, ref RectangleF rc, IntPtr format, IntPtr brush) { }

	// RVA: 0x2154130 Offset: 0x2152B30 VA: 0x182154130
	internal static extern Status GdipGetDC(IntPtr graphics, out IntPtr hdc) { }

	// RVA: 0x2155C20 Offset: 0x2154620 VA: 0x182155C20
	internal static extern Status GdipReleaseDC(IntPtr graphics, IntPtr hdc) { }

	// RVA: 0x21534C0 Offset: 0x2151EC0 VA: 0x1821534C0
	internal static extern Status GdipDrawImageRectI(IntPtr graphics, IntPtr image, int x, int y, int width, int height) { }

	// RVA: 0x2155D30 Offset: 0x2154730 VA: 0x182155D30
	internal static extern Status GdipResetWorldTransform(IntPtr graphics) { }

	// RVA: 0x2155230 Offset: 0x2153C30 VA: 0x182155230
	internal static extern Status GdipGetWorldTransform(IntPtr graphics, IntPtr matrix) { }

	// RVA: 0x21552C0 Offset: 0x2153CC0 VA: 0x1821552C0
	internal static extern Status GdipGraphicsClear(IntPtr graphics, int argb) { }

	// RVA: 0x2156180 Offset: 0x2154B80 VA: 0x182156180
	internal static extern Status GdipSetClipRectI(IntPtr graphics, int x, int y, int width, int height, CombineMode combineMode) { }

	// RVA: 0x2156240 Offset: 0x2154C40 VA: 0x182156240
	internal static extern Status GdipSetClipRegion(IntPtr graphics, IntPtr region, CombineMode combineMode) { }

	// RVA: 0x2155CB0 Offset: 0x21546B0 VA: 0x182155CB0
	internal static extern Status GdipResetClip(IntPtr graphics) { }

	// RVA: 0x21540A0 Offset: 0x2152AA0 VA: 0x1821540A0
	internal static extern Status GdipGetClip(IntPtr graphics, IntPtr region) { }

	// RVA: 0x21541C0 Offset: 0x2152BC0 VA: 0x1821541C0
	internal static extern Status GdipGetDpiX(IntPtr graphics, out float dpi) { }

	// RVA: 0x2154250 Offset: 0x2152C50 VA: 0x182154250
	internal static extern Status GdipGetDpiY(IntPtr graphics, out float dpi) { }

	// RVA: 0x2153ED0 Offset: 0x21528D0 VA: 0x182153ED0
	internal static extern Status GdipFlush(IntPtr graphics, FlushIntention intention) { }

	// RVA: 0x21529D0 Offset: 0x21513D0 VA: 0x1821529D0
	internal static extern Status GdipCreatePen1(int argb, float width, GraphicsUnit unit, out IntPtr pen) { }

	// RVA: 0x2152A80 Offset: 0x2151480 VA: 0x182152A80
	internal static extern Status GdipCreatePen2(IntPtr brush, float width, GraphicsUnit unit, out IntPtr pen) { }

	// RVA: 0x2151D50 Offset: 0x2150750 VA: 0x182151D50
	internal static extern Status GdipClonePen(IntPtr pen, out IntPtr clonepen) { }

	// RVA: 0x2153110 Offset: 0x2151B10 VA: 0x182153110
	internal static extern Status GdipDeletePen(IntPtr pen) { }

	// RVA: 0x2156580 Offset: 0x2154F80 VA: 0x182156580
	internal static extern Status GdipSetPenDashStyle(IntPtr pen, DashStyle dashStyle) { }

	// RVA: 0x2154E00 Offset: 0x2153800 VA: 0x182154E00
	internal static extern Status GdipGetPenWidth(IntPtr pen, out float width) { }

	// RVA: 0x21524E0 Offset: 0x2150EE0 VA: 0x1821524E0
	internal static extern Status GdipCreateFromHWND(IntPtr hwnd, out IntPtr graphics) { }

	// RVA: 0x2155A20 Offset: 0x2154420 VA: 0x182155A20
	internal static extern Status GdipMeasureString(IntPtr graphics, string str, int length, IntPtr font, ref RectangleF layoutRect, IntPtr stringFormat, out RectangleF boundingBox, int* codepointsFitted, int* linesFilled) { }

	// RVA: 0x2152180 Offset: 0x2150B80 VA: 0x182152180
	internal static extern Status GdipCreateBitmapFromScan0(int width, int height, int stride, PixelFormat format, IntPtr scan0, out IntPtr bmp) { }

	// RVA: 0x2151FB0 Offset: 0x21509B0 VA: 0x182151FB0
	internal static extern Status GdipCreateBitmapFromGraphics(int width, int height, IntPtr target, out IntPtr bitmap) { }

	// RVA: 0x2151900 Offset: 0x2150300 VA: 0x182151900
	internal static extern Status GdipBitmapLockBits(IntPtr bmp, ref Rectangle rc, ImageLockMode flags, PixelFormat format, [In] [Out] BitmapData bmpData) { }

	// RVA: 0x2151A70 Offset: 0x2150470 VA: 0x182151A70
	internal static extern Status GdipBitmapUnlockBits(IntPtr bmp, [In] [Out] BitmapData bmpData) { }

	// RVA: 0x2151860 Offset: 0x2150260 VA: 0x182151860
	internal static extern Status GdipBitmapGetPixel(IntPtr bmp, int x, int y, out int argb) { }

	// RVA: 0x21519D0 Offset: 0x21503D0 VA: 0x1821519D0
	internal static extern Status GdipBitmapSetPixel(IntPtr bmp, int x, int y, int argb) { }

	// RVA: 0x2155930 Offset: 0x2154330 VA: 0x182155930
	internal static extern Status GdipLoadImageFromStream(IStream stream, out IntPtr image) { }

	// RVA: 0x2156070 Offset: 0x2154A70 VA: 0x182156070
	internal static extern Status GdipSaveImageToStream(HandleRef image, IStream stream, in Guid clsidEncoder, HandleRef encoderParams) { }

	// RVA: 0x2151CC0 Offset: 0x21506C0 VA: 0x182151CC0
	internal static extern Status GdipCloneImage(IntPtr image, out IntPtr imageclone) { }

	// RVA: 0x2152050 Offset: 0x2150A50 VA: 0x182152050
	internal static extern Status GdipCreateBitmapFromHBITMAP(IntPtr hBitMap, IntPtr gdiPalette, out IntPtr image) { }

	// RVA: 0x2153390 Offset: 0x2151D90 VA: 0x182153390
	internal static extern Status GdipDisposeImage(IntPtr image) { }

	// RVA: 0x2154B80 Offset: 0x2153580 VA: 0x182154B80
	internal static extern Status GdipGetImageType(IntPtr image, out ImageType type) { }

	// RVA: 0x21553F0 Offset: 0x2153DF0 VA: 0x1821553F0
	internal static extern Status GdipImageGetFrameDimensionsCount(IntPtr image, out uint count) { }

	// RVA: 0x2155480 Offset: 0x2153E80 VA: 0x182155480
	internal static extern Status GdipImageGetFrameDimensionsList(IntPtr image, [Out] Guid[] dimensionIDs, uint count) { }

	// RVA: 0x21548A0 Offset: 0x21532A0 VA: 0x1821548A0
	internal static extern Status GdipGetImageHeight(IntPtr image, out uint height) { }

	// RVA: 0x2154930 Offset: 0x2153330 VA: 0x182154930
	internal static extern Status GdipGetImagePaletteSize(IntPtr image, out int size) { }

	// RVA: 0x21549C0 Offset: 0x21533C0 VA: 0x1821549C0
	internal static extern Status GdipGetImagePalette(IntPtr image, IntPtr palette, int size) { }

	// RVA: 0x21564F0 Offset: 0x2154EF0 VA: 0x1821564F0
	internal static extern Status GdipSetImagePalette(IntPtr image, IntPtr palette) { }

	// RVA: 0x2154A60 Offset: 0x2153460 VA: 0x182154A60
	internal static extern Status GdipGetImagePixelFormat(IntPtr image, out PixelFormat format) { }

	// RVA: 0x2154AF0 Offset: 0x21534F0 VA: 0x182154AF0
	internal static extern Status GdipGetImageRawFormat(IntPtr image, out Guid format) { }

	// RVA: 0x2154C10 Offset: 0x2153610 VA: 0x182154C10
	internal static extern Status GdipGetImageWidth(IntPtr image, out uint width) { }

	// RVA: 0x2155350 Offset: 0x2153D50 VA: 0x182155350
	internal static extern Status GdipImageGetFrameCount(IntPtr image, ref Guid guidDimension, out uint count) { }

	// RVA: 0x2155620 Offset: 0x2154020 VA: 0x182155620
	internal static extern Status GdipImageSelectActiveFrame(IntPtr image, ref Guid guidDimension, int frameIndex) { }

	// RVA: 0x2154E90 Offset: 0x2153890 VA: 0x182154E90
	internal static extern Status GdipGetPropertyItemSize(IntPtr image, int propertyID, out int propertySize) { }

	// RVA: 0x2154F30 Offset: 0x2153930 VA: 0x182154F30
	internal static extern Status GdipGetPropertyItem(IntPtr image, int propertyID, int propertySize, IntPtr buffer) { }

	// RVA: 0x2155590 Offset: 0x2153F90 VA: 0x182155590
	internal static extern Status GdipImageRotateFlip(IntPtr image, RotateFlipType rotateFlipType) { }

	// RVA: 0x2153410 Offset: 0x2151E10 VA: 0x182153410
	internal static extern Status GdipDrawImageI(IntPtr graphics, IntPtr image, int x, int y) { }

	// RVA: 0x2154810 Offset: 0x2153210 VA: 0x182154810
	internal static extern Status GdipGetImageGraphicsContext(IntPtr image, out IntPtr graphics) { }

	// RVA: 0x2153580 Offset: 0x2151F80 VA: 0x182153580
	internal static extern Status GdipDrawImageRectRectI(IntPtr graphics, IntPtr image, int dstx, int dsty, int dstwidth, int dstheight, int srcx, int srcy, int srcwidth, int srcheight, GraphicsUnit srcUnit, IntPtr imageattr, Graphics.DrawImageAbort callback, IntPtr callbackData) { }

	// RVA: 0x2152D60 Offset: 0x2151760 VA: 0x182152D60
	internal static extern Status GdipCreateStringFormat(StringFormatFlags formatAttributes, int language, out IntPtr native) { }

	// RVA: 0x2152610 Offset: 0x2151010 VA: 0x182152610
	internal static extern Status GdipCreateHBITMAPFromBitmap(IntPtr bmp, out IntPtr HandleBmp, int clrbackground) { }

	// RVA: 0x21520F0 Offset: 0x2150AF0 VA: 0x1821520F0
	internal static extern Status GdipCreateBitmapFromHICON(IntPtr hicon, out IntPtr bitmap) { }

	// RVA: 0x2152950 Offset: 0x2151350 VA: 0x182152950
	internal static extern Status GdipCreateMatrix(out IntPtr matrix) { }

	// RVA: 0x2153090 Offset: 0x2151A90 VA: 0x182153090
	internal static extern Status GdipDeleteMatrix(IntPtr matrix) { }

	// RVA: 0x2154D70 Offset: 0x2153770 VA: 0x182154D70
	internal static extern Status GdipGetMatrixElements(IntPtr matrix, IntPtr matrixOut) { }

	// RVA: 0x2155770 Offset: 0x2154170 VA: 0x182155770
	internal static extern Status GdipIsMatrixEqual(IntPtr matrix, IntPtr matrix2, out bool result) { }

	// RVA: 0x2152750 Offset: 0x2151150 VA: 0x182152750
	internal static extern int GdipCreateImageAttributes(out IntPtr imageattr) { }

	// RVA: 0x2156360 Offset: 0x2154D60 VA: 0x182156360
	internal static extern int GdipSetImageAttributesColorKeys(HandleRef imageattr, ColorAdjustType type, bool enableFlag, int colorLow, int colorHigh) { }

	// RVA: 0x2153310 Offset: 0x2151D10 VA: 0x182153310
	internal static extern int GdipDisposeImageAttributes(HandleRef imageattr) { }

	// RVA: 0x2156410 Offset: 0x2154E10 VA: 0x182156410
	internal static extern int GdipSetImageAttributesColorMatrix(HandleRef imageattr, ColorAdjustType type, bool enableFlag, ColorMatrix colorMatrix, ColorMatrix grayMatrix, ColorMatrixFlag flags) { }

	// RVA: 0x2151C30 Offset: 0x2150630 VA: 0x182151C30
	internal static extern int GdipCloneImageAttributes(HandleRef imageattr, out IntPtr cloneImageattr) { }

	// RVA: 0x21522F0 Offset: 0x2150CF0 VA: 0x1821522F0
	internal static extern Status GdipCreateFont(IntPtr fontFamily, float emSize, FontStyle style, GraphicsUnit unit, out IntPtr font) { }

	// RVA: 0x2152F90 Offset: 0x2151990 VA: 0x182152F90
	internal static extern Status GdipDeleteFont(IntPtr font) { }

	// RVA: 0x2154D30 Offset: 0x2153730 VA: 0x182154D30
	internal static extern Status GdipGetLogFont(IntPtr font, IntPtr graphics, [Out] object logfontA) { }

	// RVA: 0x2151580 Offset: 0x214FF80 VA: 0x182151580
	internal static extern IntPtr CreateFontIndirect(ref LOGFONT logfont) { }

	// RVA: 0x2156C00 Offset: 0x2155600 VA: 0x182156C00
	internal static extern IntPtr GetDC(IntPtr hwnd) { }

	// RVA: 0x2156D70 Offset: 0x2155770 VA: 0x182156D70
	internal static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC) { }

	// RVA: 0x2156C80 Offset: 0x2155680 VA: 0x182156C80
	internal static extern bool GetIconInfo(IntPtr hIcon, out IconInfo iconinfo) { }

	// RVA: 0x2151740 Offset: 0x2150140 VA: 0x182151740
	internal static extern IntPtr CreateIconIndirect(in IconInfo piconinfo) { }

	// RVA: 0x21517D0 Offset: 0x21501D0 VA: 0x1821517D0
	internal static extern bool DestroyIcon(IntPtr hIcon) { }

	// RVA: 0x2156FB0 Offset: 0x21559B0 VA: 0x182156FB0
	internal static extern IntPtr XOpenDisplay(IntPtr display) { }

	// RVA: 0x2157030 Offset: 0x2155A30 VA: 0x182157030
	internal static extern IntPtr XRootWindow(IntPtr display, int screen) { }

	// RVA: 0x2156F30 Offset: 0x2155930 VA: 0x182156F30
	internal static extern int XDefaultScreen(IntPtr display) { }

	// RVA: 0x2154380 Offset: 0x2152D80 VA: 0x182154380
	internal static extern int GdipGetFontCollectionFamilyCount(HandleRef collection, out int found) { }

	// RVA: 0x2154410 Offset: 0x2152E10 VA: 0x182154410
	internal static extern int GdipGetFontCollectionFamilyList(HandleRef collection, int getCount, IntPtr[] dest, out int retCount) { }

	// RVA: 0x2155B20 Offset: 0x2154520 VA: 0x182155B20
	internal static extern int GdipNewInstalledFontCollection(out IntPtr collection) { }

	// RVA: 0x2155BA0 Offset: 0x21545A0 VA: 0x182155BA0
	internal static extern Status GdipNewPrivateFontCollection(out IntPtr collection) { }

	// RVA: 0x2153190 Offset: 0x2151B90 VA: 0x182153190
	internal static extern Status GdipDeletePrivateFontCollection(ref IntPtr collection) { }

	// RVA: 0x2152240 Offset: 0x2150C40 VA: 0x182152240
	internal static extern Status GdipCreateFontFamilyFromName(string fName, IntPtr collection, out IntPtr fontFamily) { }

	// RVA: 0x21542E0 Offset: 0x2152CE0 VA: 0x1821542E0
	internal static extern Status GdipGetFamilyName(IntPtr family, IntPtr name, int language) { }

	// RVA: 0x21545F0 Offset: 0x2152FF0 VA: 0x1821545F0
	internal static extern Status GdipGetGenericFontFamilySansSerif(out IntPtr fontFamily) { }

	// RVA: 0x2154670 Offset: 0x2153070 VA: 0x182154670
	internal static extern Status GdipGetGenericFontFamilySerif(out IntPtr fontFamily) { }

	// RVA: 0x2154570 Offset: 0x2152F70 VA: 0x182154570
	internal static extern Status GdipGetGenericFontFamilyMonospace(out IntPtr fontFamily) { }

	// RVA: 0x2153F60 Offset: 0x2152960 VA: 0x182153F60
	internal static extern Status GdipGetCellAscent(IntPtr fontFamily, int style, out short ascent) { }

	// RVA: 0x2154000 Offset: 0x2152A00 VA: 0x182154000
	internal static extern Status GdipGetCellDescent(IntPtr fontFamily, int style, out short descent) { }

	// RVA: 0x2152F10 Offset: 0x2151910 VA: 0x182152F10
	internal static extern Status GdipDeleteFontFamily(IntPtr fontFamily) { }

	// RVA: 0x21544D0 Offset: 0x2152ED0 VA: 0x1821544D0
	internal static extern Status GdipGetFontHeightGivenDPI(IntPtr font, float dpi, out float height) { }

	// RVA: 0x2151BA0 Offset: 0x21505A0 VA: 0x182151BA0
	internal static extern int GdipCloneFontFamily(HandleRef fontFamily, out IntPtr clone) { }

	// RVA: 0x2156A30 Offset: 0x2155430 VA: 0x182156A30
	internal static extern Status GdipStringFormatGetGenericTypographic(out IntPtr format) { }

	// RVA: 0x2153290 Offset: 0x2151C90 VA: 0x182153290
	internal static extern Status GdipDeleteStringFormat(IntPtr format) { }

	// RVA: 0x2151DE0 Offset: 0x21507E0 VA: 0x182151DE0
	internal static extern Status GdipCloneStringFormat(IntPtr srcformat, out IntPtr format) { }

	// RVA: 0x21566A0 Offset: 0x21550A0 VA: 0x1821566A0
	internal static extern Status GdipSetStringFormatFlags(IntPtr format, StringFormatFlags flags) { }

	// RVA: 0x21551A0 Offset: 0x2153BA0 VA: 0x1821551A0
	internal static extern Status GdipGetStringFormatFlags(IntPtr format, out StringFormatFlags flags) { }

	// RVA: 0x2156610 Offset: 0x2155010 VA: 0x182156610
	internal static extern Status GdipSetStringFormatAlign(IntPtr format, StringAlignment align) { }

	// RVA: 0x2155110 Offset: 0x2153B10 VA: 0x182155110
	internal static extern Status GdipGetStringFormatAlign(IntPtr format, out StringAlignment align) { }

	// RVA: 0x21567C0 Offset: 0x21551C0 VA: 0x1821567C0
	internal static extern Status GdipSetStringFormatLineAlign(IntPtr format, StringAlignment align) { }

	// RVA: 0x2156910 Offset: 0x2155310 VA: 0x182156910
	internal static extern Status GdipSetStringFormatTrimming(IntPtr format, StringTrimming trimming) { }

	// RVA: 0x2156730 Offset: 0x2155130 VA: 0x182156730
	internal static extern Status GdipSetStringFormatHotkeyPrefix(IntPtr format, HotkeyPrefix hotkeyPrefix) { }

	// RVA: 0x2156850 Offset: 0x2155250 VA: 0x182156850
	internal static extern Status GdipSetStringFormatTabStops(IntPtr format, float firstTabOffset, int count, float[] tabStops) { }

	// RVA: 0x21546F0 Offset: 0x21530F0 VA: 0x1821546F0
	internal static extern int GdipGetImageEncodersSize(out int encoderNums, out int arraySize) { }

	// RVA: 0x2154780 Offset: 0x2153180 VA: 0x182154780
	internal static extern int GdipGetImageEncoders(int encoderNums, int arraySize, IntPtr encoders) { }

	// RVA: 0x21523B0 Offset: 0x2150DB0 VA: 0x1821523B0
	internal static extern Status GdipCreateFromContext_macosx(IntPtr cgref, int width, int height, out IntPtr graphics) { }

	// RVA: 0x21569A0 Offset: 0x21553A0 VA: 0x1821569A0
	internal static extern Status GdipSetVisibleClip_linux(IntPtr graphics, ref Rectangle rect) { }

	// RVA: 0x2152570 Offset: 0x2150F70 VA: 0x182152570
	internal static extern Status GdipCreateFromXDrawable_linux(IntPtr drawable, IntPtr display, out IntPtr graphics) { }

	// RVA: 0x2155820 Offset: 0x2154220 VA: 0x182155820
	internal static extern Status GdipLoadImageFromDelegate_linux(GDIPlus.StreamGetHeaderDelegate getHeader, GDIPlus.StreamGetBytesDelegate getBytes, GDIPlus.StreamPutBytesDelegate putBytes, GDIPlus.StreamSeekDelegate doSeek, GDIPlus.StreamCloseDelegate close, GDIPlus.StreamSizeDelegate size, out IntPtr image) { }

	// RVA: 0x2155F70 Offset: 0x2154970 VA: 0x182155F70
	internal static extern Status GdipSaveImageToDelegate_linux(IntPtr image, GDIPlus.StreamGetBytesDelegate getBytes, GDIPlus.StreamPutBytesDelegate putBytes, GDIPlus.StreamSeekDelegate doSeek, GDIPlus.StreamCloseDelegate close, GDIPlus.StreamSizeDelegate size, ref Guid encoderClsID, IntPtr encoderParameters) { }

	// RVA: 0x2157480 Offset: 0x2155E80 VA: 0x182157480
	private static extern int uname(IntPtr buf) { }
}
