public sealed class RectTransformUtility // TypeDefIndex: 18972
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x2F168D0 Offset: 0x2F152D0 VA: 0x182F168D0
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x2F169C0 Offset: 0x2F153C0 VA: 0x182F169C0
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x2F16AC0 Offset: 0x2F154C0 VA: 0x182F16AC0
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x2F16D70 Offset: 0x2F15770 VA: 0x182F16D70
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint) { }

	// RVA: 0x2F16C30 Offset: 0x2F15630 VA: 0x182F16C30
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x2F16B50 Offset: 0x2F15550 VA: 0x182F16B50
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x2F17170 Offset: 0x2F15B70 VA: 0x182F17170
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x2F16ED0 Offset: 0x2F158D0 VA: 0x182F16ED0
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x2F16FF0 Offset: 0x2F159F0 VA: 0x182F16FF0
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x2F17600 Offset: 0x2F16000 VA: 0x182F17600
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x2F16410 Offset: 0x2F14E10 VA: 0x182F16410
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x2F161B0 Offset: 0x2F14BB0 VA: 0x182F161B0
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x2F16840 Offset: 0x2F15240 VA: 0x182F16840
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x2F176C0 Offset: 0x2F160C0 VA: 0x182F176C0
	private static void .cctor() { }

	// RVA: 0x2F16860 Offset: 0x2F15260 VA: 0x182F16860
	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0x2F16960 Offset: 0x2F15360 VA: 0x182F16960
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0x2F16A50 Offset: 0x2F15450 VA: 0x182F16A50
	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset) { }
}
