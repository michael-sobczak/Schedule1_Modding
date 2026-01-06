public static class PointerCaptureHelper // TypeDefIndex: 6734
{
	// Methods

	// RVA: 0x2EDDAF0 Offset: 0x2EDC4F0 VA: 0x182EDDAF0
	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	[Extension]
	// RVA: 0x2EDDB90 Offset: 0x2EDC590 VA: 0x182EDDB90
	public static bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	[Extension]
	// RVA: 0x2EDD890 Offset: 0x2EDC290 VA: 0x182EDD890
	public static void CapturePointer(IEventHandler handler, int pointerId) { }

	[Extension]
	// RVA: 0x2EDDD60 Offset: 0x2EDC760 VA: 0x182EDDD60
	public static void ReleasePointer(IEventHandler handler, int pointerId) { }

	[Extension]
	// RVA: 0x2EDDA60 Offset: 0x2EDC460 VA: 0x182EDDA60
	public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	[Extension]
	// RVA: 0x2EDDE50 Offset: 0x2EDC850 VA: 0x182EDDE50
	public static void ReleasePointer(IPanel panel, int pointerId) { }

	[Extension]
	// RVA: 0x2EDD810 Offset: 0x2EDC210 VA: 0x182EDD810
	internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[Extension]
	// RVA: 0x2EDDC70 Offset: 0x2EDC670 VA: 0x182EDDC70
	internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[Extension]
	// RVA: 0x2EDDEE0 Offset: 0x2EDC8E0 VA: 0x182EDDEE0
	internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

	[Extension]
	// RVA: 0x2EDDCF0 Offset: 0x2EDC6F0 VA: 0x182EDDCF0
	internal static void ProcessPointerCapture(IPanel panel, int pointerId) { }
}
