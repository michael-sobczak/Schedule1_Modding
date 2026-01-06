public sealed class Canvas : Behaviour // TypeDefIndex: 18976
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases preWillRenderCanvases; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<int> <externBeginRenderOverlays>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int, int> <externRenderOverlaysBefore>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<int> <externEndRenderOverlays>k__BackingField; // 0x20

	// Properties
	public RenderMode renderMode { get; set; }
	public bool isRootCanvas { get; }
	public Rect pixelRect { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool pixelPerfect { get; }
	public float planeDistance { set; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; }
	public int sortingLayerID { get; set; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public Canvas rootCanvas { get; }
	public Vector2 renderingDisplaySize { get; }
	internal static Action<int> externBeginRenderOverlays { get; set; }
	internal static Action<int, int> externRenderOverlaysBefore { get; set; }
	internal static Action<int> externEndRenderOverlays { get; set; }
	[NativeProperty("Camera", False, 0)]
	public Camera worldCamera { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2F155C0 Offset: 0x2F13FC0 VA: 0x182F155C0
	public static void add_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x2F15C80 Offset: 0x2F14680 VA: 0x182F15C80
	public static void remove_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x2F15680 Offset: 0x2F14080 VA: 0x182F15680
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x2F15D40 Offset: 0x2F14740 VA: 0x182F15D40
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x2F159E0 Offset: 0x2F143E0 VA: 0x182F159E0
	public RenderMode get_renderMode() { }

	// RVA: 0x2F16050 Offset: 0x2F14A50 VA: 0x182F16050
	public void set_renderMode(RenderMode value) { }

	// RVA: 0x2F15840 Offset: 0x2F14240 VA: 0x182F15840
	public bool get_isRootCanvas() { }

	// RVA: 0x2F15950 Offset: 0x2F14350 VA: 0x182F15950
	public Rect get_pixelRect() { }

	// RVA: 0x2F15B40 Offset: 0x2F14540 VA: 0x182F15B40
	public float get_scaleFactor() { }

	// RVA: 0x2F16090 Offset: 0x2F14A90 VA: 0x182F16090
	public void set_scaleFactor(float value) { }

	// RVA: 0x2F159A0 Offset: 0x2F143A0 VA: 0x182F159A0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x2F16000 Offset: 0x2F14A00 VA: 0x182F16000
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x2F158C0 Offset: 0x2F142C0 VA: 0x182F158C0
	public bool get_pixelPerfect() { }

	// RVA: 0x2F15FB0 Offset: 0x2F149B0 VA: 0x182F15FB0
	public void set_planeDistance(float value) { }

	// RVA: 0x2F15A20 Offset: 0x2F14420 VA: 0x182F15A20
	public int get_renderOrder() { }

	// RVA: 0x2F15880 Offset: 0x2F14280 VA: 0x182F15880
	public bool get_overrideSorting() { }

	// RVA: 0x2F15F60 Offset: 0x2F14960 VA: 0x182F15F60
	public void set_overrideSorting(bool value) { }

	// RVA: 0x2F15BC0 Offset: 0x2F145C0 VA: 0x182F15BC0
	public int get_sortingOrder() { }

	// RVA: 0x2F16120 Offset: 0x2F14B20 VA: 0x182F16120
	public void set_sortingOrder(int value) { }

	// RVA: 0x2F15C00 Offset: 0x2F14600 VA: 0x182F15C00
	public int get_targetDisplay() { }

	// RVA: 0x2F15B80 Offset: 0x2F14580 VA: 0x182F15B80
	public int get_sortingLayerID() { }

	// RVA: 0x2F160E0 Offset: 0x2F14AE0 VA: 0x182F160E0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x2F15740 Offset: 0x2F14140 VA: 0x182F15740
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x2F15E00 Offset: 0x2F14800 VA: 0x182F15E00
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x2F15B00 Offset: 0x2F14500 VA: 0x182F15B00
	public Canvas get_rootCanvas() { }

	// RVA: 0x2F15AB0 Offset: 0x2F144B0 VA: 0x182F15AB0
	public Vector2 get_renderingDisplaySize() { }

	[CompilerGenerated]
	// RVA: 0x2F15780 Offset: 0x2F14180 VA: 0x182F15780
	internal static Action<int> get_externBeginRenderOverlays() { }

	[CompilerGenerated]
	// RVA: 0x2F15E40 Offset: 0x2F14840 VA: 0x182F15E40
	internal static void set_externBeginRenderOverlays(Action<int> value) { }

	[CompilerGenerated]
	// RVA: 0x2F15800 Offset: 0x2F14200 VA: 0x182F15800
	internal static Action<int, int> get_externRenderOverlaysBefore() { }

	[CompilerGenerated]
	// RVA: 0x2F15F00 Offset: 0x2F14900 VA: 0x182F15F00
	internal static void set_externRenderOverlaysBefore(Action<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x2F157C0 Offset: 0x2F141C0 VA: 0x182F157C0
	internal static Action<int> get_externEndRenderOverlays() { }

	[CompilerGenerated]
	// RVA: 0x2F15EA0 Offset: 0x2F148A0 VA: 0x182F15EA0
	internal static void set_externEndRenderOverlays(Action<int> value) { }

	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	// RVA: 0x2F15580 Offset: 0x2F13F80 VA: 0x182F15580
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	// RVA: 0x2F15C40 Offset: 0x2F14640 VA: 0x182F15C40
	public Camera get_worldCamera() { }

	// RVA: 0x2F16160 Offset: 0x2F14B60 VA: 0x182F16160
	public void set_worldCamera(Camera value) { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	// RVA: 0x2F15420 Offset: 0x2F13E20 VA: 0x182F15420
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	// RVA: 0x2F15450 Offset: 0x2F13E50 VA: 0x182F15450
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x2F15390 Offset: 0x2F13D90 VA: 0x182F15390
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x2F154E0 Offset: 0x2F13EE0 VA: 0x182F154E0
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x2F15530 Offset: 0x2F13F30 VA: 0x182F15530
	private static void SendWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x2F152D0 Offset: 0x2F13CD0 VA: 0x182F152D0
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[RequiredByNativeCode]
	// RVA: 0x2F15480 Offset: 0x2F13E80 VA: 0x182F15480
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[RequiredByNativeCode]
	// RVA: 0x2F15330 Offset: 0x2F13D30 VA: 0x182F15330
	private static void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2F15900 Offset: 0x2F14300 VA: 0x182F15900
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x2F15A60 Offset: 0x2F14460 VA: 0x182F15A60
	private void get_renderingDisplaySize_Injected(out Vector2 ret) { }
}
