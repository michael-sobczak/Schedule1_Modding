public static class CallbackDispatcher // TypeDefIndex: 14702
{
	// Fields
	private static Dictionary<int, List<Callback>> m_registeredCallbacks; // 0x0
	private static Dictionary<int, List<Callback>> m_registeredGameServerCallbacks; // 0x8
	private static Dictionary<ulong, List<CallResult>> m_registeredCallResults; // 0x10
	private static object m_sync; // 0x18
	private static IntPtr m_pCallbackMsg; // 0x20
	private static int m_initCount; // 0x28

	// Properties
	public static bool IsInitialized { get; }

	// Methods

	// RVA: 0xC7F2D0 Offset: 0xC7DCD0 VA: 0x180C7F2D0
	public static void ExceptionHandler(Exception e) { }

	// RVA: 0xC815C0 Offset: 0xC7FFC0 VA: 0x180C815C0
	public static bool get_IsInitialized() { }

	// RVA: 0xC7F320 Offset: 0xC7DD20 VA: 0x180C7F320
	internal static void Initialize() { }

	// RVA: 0xC80660 Offset: 0xC7F060 VA: 0x180C80660
	internal static void Shutdown() { }

	// RVA: 0xC7F560 Offset: 0xC7DF60 VA: 0x180C7F560
	internal static void Register(Callback cb) { }

	// RVA: 0xC7F7F0 Offset: 0xC7E1F0 VA: 0x180C7F7F0
	internal static void Register(SteamAPICall_t asyncCall, CallResult cr) { }

	// RVA: 0xC81220 Offset: 0xC7FC20 VA: 0x180C81220
	internal static void Unregister(Callback cb) { }

	// RVA: 0xC81000 Offset: 0xC7FA00 VA: 0x180C81000
	internal static void Unregister(SteamAPICall_t asyncCall, CallResult cr) { }

	// RVA: 0xC807D0 Offset: 0xC7F1D0 VA: 0x180C807D0
	private static void UnregisterAll() { }

	// RVA: 0xC7FA90 Offset: 0xC7E490 VA: 0x180C7FA90
	internal static void RunFrame(bool isGameServer) { }

	// RVA: 0xC81430 Offset: 0xC7FE30 VA: 0x180C81430
	private static void .cctor() { }
}
