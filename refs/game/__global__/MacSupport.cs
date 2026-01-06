internal static class MacSupport // TypeDefIndex: 17186
{
	// Fields
	internal static Hashtable contextReference; // 0x0
	internal static object lockobj; // 0x8
	internal static Delegate hwnd_delegate; // 0x10

	// Methods

	// RVA: 0x21630D0 Offset: 0x2161AD0 VA: 0x1821630D0
	private static void .cctor() { }

	// RVA: 0x2161B20 Offset: 0x2160520 VA: 0x182161B20
	internal static CocoaContext GetCGContextForNSView(IntPtr handle) { }

	// RVA: 0x2162110 Offset: 0x2160B10 VA: 0x182162110
	internal static CarbonContext GetCGContextForView(IntPtr handle) { }

	// RVA: 0x2162AA0 Offset: 0x21614A0 VA: 0x182162AA0
	internal static IntPtr GetContext(IntPtr port) { }

	// RVA: 0x2162F60 Offset: 0x2161960 VA: 0x182162F60
	internal static void ReleaseContext(IntPtr port, IntPtr context) { }

	// RVA: 0x2163490 Offset: 0x2161E90 VA: 0x182163490
	public static extern IntPtr objc_getClass(string className) { }

	// RVA: 0x2163530 Offset: 0x2161F30 VA: 0x182163530
	public static extern IntPtr objc_msgSend(IntPtr basePtr, IntPtr selector) { }

	// RVA: 0x21635C0 Offset: 0x2161FC0 VA: 0x1821635C0
	public static extern void objc_msgSend_stret(ref CGRect32 arect, IntPtr basePtr, IntPtr selector) { }

	// RVA: 0x2163660 Offset: 0x2162060 VA: 0x182163660
	public static extern void objc_msgSend_stret(ref CGRect64 arect, IntPtr basePtr, IntPtr selector) { }

	// RVA: 0x2163400 Offset: 0x2161E00 VA: 0x182163400
	public static extern bool bool_objc_msgSend(IntPtr handle, IntPtr selector) { }

	// RVA: 0x2163700 Offset: 0x2162100 VA: 0x182163700
	public static extern IntPtr sel_registerName(string selectorName) { }

	// RVA: 0x2161A20 Offset: 0x2160420 VA: 0x182161A20
	internal static extern IntPtr CGMainDisplayID() { }

	// RVA: 0x2161980 Offset: 0x2160380 VA: 0x182161980
	internal static extern CGRect32 CGDisplayBounds32(IntPtr display) { }

	// RVA: 0x2162ED0 Offset: 0x21618D0 VA: 0x182162ED0
	internal static extern int HIViewGetBounds(IntPtr vHnd, ref CGRect32 r) { }

	// RVA: 0x2162E30 Offset: 0x2161830 VA: 0x182162E30
	internal static extern int HIViewConvertRect(ref CGRect32 r, IntPtr a, IntPtr b) { }

	// RVA: 0x2162C20 Offset: 0x2161620 VA: 0x182162C20
	internal static extern IntPtr GetControlOwner(IntPtr aView) { }

	// RVA: 0x2162D10 Offset: 0x2161710 VA: 0x182162D10
	internal static extern int GetWindowBounds(IntPtr wHnd, uint reg, ref QDRect rect) { }

	// RVA: 0x2162DB0 Offset: 0x21617B0 VA: 0x182162DB0
	internal static extern IntPtr GetWindowPort(IntPtr hWnd) { }

	// RVA: 0x2162CA0 Offset: 0x21616A0 VA: 0x182162CA0
	internal static extern IntPtr GetQDGlobalsThePort() { }

	// RVA: 0x2161A90 Offset: 0x2160490 VA: 0x182161A90
	internal static extern void CreateCGContextForPort(IntPtr port, ref IntPtr context) { }

	// RVA: 0x21611E0 Offset: 0x215FBE0 VA: 0x1821611E0
	internal static extern void CFRelease(IntPtr context) { }

	// RVA: 0x2161840 Offset: 0x2160240 VA: 0x182161840
	internal static extern void CGContextTranslateCTM32(IntPtr context, float tx, float ty) { }

	// RVA: 0x2161680 Offset: 0x2160080 VA: 0x182161680
	internal static extern void CGContextScaleCTM32(IntPtr context, float x, float y) { }

	// RVA: 0x21618E0 Offset: 0x21602E0 VA: 0x1821618E0
	internal static extern void CGContextTranslateCTM64(IntPtr context, double tx, double ty) { }

	// RVA: 0x2161720 Offset: 0x2160120 VA: 0x182161720
	internal static extern void CGContextScaleCTM64(IntPtr context, double x, double y) { }

	// RVA: 0x2161500 Offset: 0x215FF00 VA: 0x182161500
	internal static extern void CGContextFlush(IntPtr context) { }

	// RVA: 0x21617C0 Offset: 0x21601C0 VA: 0x1821617C0
	internal static extern void CGContextSynchronize(IntPtr context) { }

	// RVA: 0x2161260 Offset: 0x215FC60 VA: 0x182161260
	internal static extern void CGContextAddRect32(IntPtr context, CGRect32 rect) { }

	// RVA: 0x2161300 Offset: 0x215FD00 VA: 0x182161300
	internal static extern void CGContextBeginPath(IntPtr context) { }

	// RVA: 0x2161400 Offset: 0x215FE00 VA: 0x182161400
	internal static extern void CGContextClosePath(IntPtr context) { }

	// RVA: 0x2161380 Offset: 0x215FD80 VA: 0x182161380
	internal static extern void CGContextClip(IntPtr context) { }

	// RVA: 0x2161480 Offset: 0x215FE80 VA: 0x182161480
	internal static extern void CGContextEOClip(IntPtr context) { }

	// RVA: 0x2161600 Offset: 0x2160000 VA: 0x182161600
	internal static extern void CGContextSaveGState(IntPtr context) { }

	// RVA: 0x2161580 Offset: 0x215FF80 VA: 0x182161580
	internal static extern void CGContextRestoreGState(IntPtr context) { }
}
