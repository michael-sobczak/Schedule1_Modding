internal sealed class GUIClip // TypeDefIndex: 17590
{
	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
	// RVA: 0x2D049A0 Offset: 0x2D033A0 VA: 0x182D049A0
	internal static Rect get_visibleRect() { }

	// RVA: 0x2D04820 Offset: 0x2D03220 VA: 0x182D04820
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x2D04630 Offset: 0x2D03030 VA: 0x182D04630
	internal static void Internal_Pop() { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
	// RVA: 0x2D045D0 Offset: 0x2D02FD0 VA: 0x182D045D0
	internal static int Internal_GetCount() { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
	// RVA: 0x2D04580 Offset: 0x2D02F80 VA: 0x182D04580
	internal static Matrix4x4 GetMatrix() { }

	// RVA: 0x2D04920 Offset: 0x2D03320 VA: 0x182D04920
	internal static void SetMatrix(Matrix4x4 m) { }

	// RVA: 0x2D046C0 Offset: 0x2D030C0 VA: 0x182D046C0
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x2D04750 Offset: 0x2D03150 VA: 0x182D04750
	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	// RVA: 0x2D04600 Offset: 0x2D03000 VA: 0x182D04600
	internal static void Internal_PopParentClip() { }

	// RVA: 0x2D04880 Offset: 0x2D03280 VA: 0x182D04880
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x2D04630 Offset: 0x2D03030 VA: 0x182D04630
	internal static void Pop() { }

	// RVA: 0x2D04960 Offset: 0x2D03360 VA: 0x182D04960
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x2D047B0 Offset: 0x2D031B0 VA: 0x182D047B0
	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x2D04540 Offset: 0x2D02F40 VA: 0x182D04540
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2D048E0 Offset: 0x2D032E0 VA: 0x182D048E0
	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x2D04660 Offset: 0x2D03060 VA: 0x182D04660
	private static void Internal_PushParentClip_Injected(ref Matrix4x4 renderTransform, ref Matrix4x4 inputTransform, ref Rect clipRect) { }
}
