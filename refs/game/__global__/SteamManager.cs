public class SteamManager : MonoBehaviour // TypeDefIndex: 18
{
	// Fields
	protected static bool s_EverInitialized; // 0x0
	protected static SteamManager s_instance; // 0x8
	protected bool m_bInitialized; // 0x20
	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook; // 0x28

	// Properties
	protected static SteamManager Instance { get; }
	public static bool Initialized { get; }

	// Methods

	// RVA: 0x567980 Offset: 0x566380 VA: 0x180567980
	protected static SteamManager get_Instance() { }

	// RVA: 0x567890 Offset: 0x566290 VA: 0x180567890
	public static bool get_Initialized() { }

	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	// RVA: 0x567830 Offset: 0x566230 VA: 0x180567830
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText) { }

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x5675F0 Offset: 0x565FF0 VA: 0x1805675F0
	private static void InitOnPlayMode() { }

	// RVA: 0x567250 Offset: 0x565C50 VA: 0x180567250 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x567720 Offset: 0x566120 VA: 0x180567720 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x567660 Offset: 0x566060 VA: 0x180567660 Slot: 6
	protected virtual void OnDestroy() { }

	// RVA: 0x567880 Offset: 0x566280 VA: 0x180567880 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
