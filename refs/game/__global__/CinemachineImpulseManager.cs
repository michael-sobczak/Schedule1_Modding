public class CinemachineImpulseManager // TypeDefIndex: 16218
{
	// Fields
	private static CinemachineImpulseManager sInstance; // 0x0
	private const float Epsilon = 0.0001;
	private List<CinemachineImpulseManager.ImpulseEvent> m_ExpiredEvents; // 0x10
	private List<CinemachineImpulseManager.ImpulseEvent> m_ActiveEvents; // 0x18
	public bool IgnoreTimeScale; // 0x20

	// Properties
	public static CinemachineImpulseManager Instance { get; }
	public float CurrentTime { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0xC2B940 Offset: 0xC2A340 VA: 0x180C2B940
	public static CinemachineImpulseManager get_Instance() { }

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0xC2B6F0 Offset: 0xC2A0F0 VA: 0x180C2B6F0
	private static void InitializeModule() { }

	// RVA: 0xC2B160 Offset: 0xC29B60 VA: 0x180C2B160
	internal static float EvaluateDissipationScale(float spread, float normalizedDistance) { }

	// RVA: 0xC2B220 Offset: 0xC29C20 VA: 0x180C2B220
	public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0xC2B8E0 Offset: 0xC2A2E0 VA: 0x180C2B8E0
	public float get_CurrentTime() { }

	// RVA: 0xC2B800 Offset: 0xC2A200 VA: 0x180C2B800
	public CinemachineImpulseManager.ImpulseEvent NewImpulseEvent() { }

	// RVA: 0xC2AF90 Offset: 0xC29990 VA: 0x180C2AF90
	public void AddImpulseEvent(CinemachineImpulseManager.ImpulseEvent e) { }

	// RVA: 0xC2B090 Offset: 0xC29A90 VA: 0x180C2B090
	public void Clear() { }
}
