public class GraphicRegistry // TypeDefIndex: 16399
{
	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics; // 0x18
	private static readonly List<Graphic> s_EmptyList; // 0x8

	// Properties
	public static GraphicRegistry instance { get; }

	// Methods

	// RVA: 0x2D9C110 Offset: 0x2D9AB10 VA: 0x182D9C110
	protected void .ctor() { }

	// RVA: 0x2D9C2A0 Offset: 0x2D9ACA0 VA: 0x182D9C2A0
	public static GraphicRegistry get_instance() { }

	// RVA: 0x2D9B910 Offset: 0x2D9A310 VA: 0x182D9B910
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x2D9BB10 Offset: 0x2D9A510 VA: 0x182D9BB10
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x2D9BD30 Offset: 0x2D9A730 VA: 0x182D9BD30
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x2D9BEF0 Offset: 0x2D9A8F0 VA: 0x182D9BEF0
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x2D9B300 Offset: 0x2D99D00 VA: 0x182D9B300
	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x2D9B600 Offset: 0x2D9A000 VA: 0x182D9B600
	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x2D9B790 Offset: 0x2D9A190 VA: 0x182D9B790
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x2D9B850 Offset: 0x2D9A250 VA: 0x182D9B850
	public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x2D9C080 Offset: 0x2D9AA80 VA: 0x182D9C080
	private static void .cctor() { }
}
