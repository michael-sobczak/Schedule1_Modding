internal class SendMouseEvents // TypeDefIndex: 19020
{
	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20
	public static Func<KeyValuePair<int, Vector2>> s_GetMouseState; // 0x28
	private static Vector2 s_MousePosition; // 0x30
	private static bool s_MouseButtonPressedThisFrame; // 0x38
	private static bool s_MouseButtonIsPressed; // 0x39

	// Methods

	// RVA: 0x2D2AE10 Offset: 0x2D29810 VA: 0x182D2AE10
	private static void UpdateMouse() { }

	[RequiredByNativeCode]
	// RVA: 0x2D2ADC0 Offset: 0x2D297C0 VA: 0x182D2ADC0
	private static void SetMouseMoved() { }

	[RequiredByNativeCode]
	// RVA: 0x2D298E0 Offset: 0x2D282E0 VA: 0x182D298E0
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x2D2A420 Offset: 0x2D28E20 VA: 0x182D2A420
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x2D2B080 Offset: 0x2D29A80 VA: 0x182D2B080
	private static void .cctor() { }
}
