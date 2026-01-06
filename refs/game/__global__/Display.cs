public class Display // TypeDefIndex: 11641
{
	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	private static int m_ActiveEditorGameViewTarget; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x18

	// Properties
	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public RenderBuffer colorBuffer { get; }
	public bool active { get; }
	public bool requiresSrgbBlitToBackbuffer { get; }
	public static Display main { get; }

	// Methods

	// RVA: 0x2C87910 Offset: 0x2C86310 VA: 0x182C87910
	internal void .ctor() { }

	// RVA: 0x7C2A20 Offset: 0x7C1420 VA: 0x1807C2A20
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x2C87B30 Offset: 0x2C86530 VA: 0x182C87B30
	public int get_renderingWidth() { }

	// RVA: 0x2C87AB0 Offset: 0x2C864B0 VA: 0x182C87AB0
	public int get_renderingHeight() { }

	// RVA: 0x2C87CA0 Offset: 0x2C866A0 VA: 0x182C87CA0
	public int get_systemWidth() { }

	// RVA: 0x2C87C20 Offset: 0x2C86620 VA: 0x182C87C20
	public int get_systemHeight() { }

	// RVA: 0x2C879C0 Offset: 0x2C863C0 VA: 0x182C879C0
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x2C87950 Offset: 0x2C86350 VA: 0x182C87950
	public bool get_active() { }

	// RVA: 0x2C87BB0 Offset: 0x2C865B0 VA: 0x182C87BB0
	public bool get_requiresSrgbBlitToBackbuffer() { }

	// RVA: 0x2C87670 Offset: 0x2C86070 VA: 0x182C87670
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x2C87A60 Offset: 0x2C86460 VA: 0x182C87A60
	public static Display get_main() { }

	[RequiredByNativeCode]
	// RVA: 0x2C87420 Offset: 0x2C85E20 VA: 0x182C87420
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCode]
	// RVA: 0x2C87230 Offset: 0x2C85C30 VA: 0x182C87230
	internal static void FireDisplaysUpdated() { }

	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	// RVA: 0x2C873C0 Offset: 0x2C85DC0 VA: 0x182C873C0
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
	// RVA: 0x2C87360 Offset: 0x2C85D60 VA: 0x182C87360
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunction("UnityDisplayManager_GetRenderingBuffersWrapper")]
	// RVA: 0x2C87300 Offset: 0x2C85D00 VA: 0x182C87300
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	// RVA: 0x2C87610 Offset: 0x2C86010 VA: 0x182C87610
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	[FreeFunction("UnityDisplayManager_DisplayActive")]
	// RVA: 0x2C872C0 Offset: 0x2C85CC0 VA: 0x182C872C0
	private static bool GetActiveImpl(IntPtr nativeDisplay) { }

	[FreeFunction("UnityDisplayManager_RequiresSRGBBlitToBackbuffer")]
	// RVA: 0x2C87740 Offset: 0x2C86140 VA: 0x182C87740
	private static bool RequiresSrgbBlitToBackbufferImpl(IntPtr nativeDisplay) { }

	// RVA: 0x2C87780 Offset: 0x2C86180 VA: 0x182C87780
	private static void .cctor() { }
}
