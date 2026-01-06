public static class InstanceFinder // TypeDefIndex: 12482
{
	// Fields
	private static NetworkManager _networkManager; // 0x0

	// Properties
	public static NetworkManager NetworkManager { get; }
	public static ServerManager ServerManager { get; }
	public static ClientManager ClientManager { get; }
	public static TransportManager TransportManager { get; }
	public static TimeManager TimeManager { get; }
	public static SceneManager SceneManager { get; }
	public static RollbackManager RollbackManager { get; }
	public static PredictionManager PredictionManager { get; }
	public static StatisticsManager StatisticsManager { get; }
	public static bool IsServer { get; }
	public static bool IsServerOnly { get; }
	public static bool IsClient { get; }
	public static bool IsClientOnly { get; }
	public static bool IsHost { get; }
	public static bool IsOffline { get; }

	// Methods

	// RVA: 0xD0E010 Offset: 0xD0CA10 VA: 0x180D0E010
	public static NetworkManager get_NetworkManager() { }

	// RVA: 0xD0E400 Offset: 0xD0CE00 VA: 0x180D0E400
	public static ServerManager get_ServerManager() { }

	// RVA: 0xD0DC60 Offset: 0xD0C660 VA: 0x180D0DC60
	public static ClientManager get_ClientManager() { }

	// RVA: 0xD0E550 Offset: 0xD0CF50 VA: 0x180D0E550
	public static TransportManager get_TransportManager() { }

	// RVA: 0xD0E4E0 Offset: 0xD0CEE0 VA: 0x180D0E4E0
	public static TimeManager get_TimeManager() { }

	// RVA: 0xD0E390 Offset: 0xD0CD90 VA: 0x180D0E390
	public static SceneManager get_SceneManager() { }

	// RVA: 0xD0E310 Offset: 0xD0CD10 VA: 0x180D0E310
	public static RollbackManager get_RollbackManager() { }

	// RVA: 0xD0E2A0 Offset: 0xD0CCA0 VA: 0x180D0E2A0
	public static PredictionManager get_PredictionManager() { }

	// RVA: 0xD0E470 Offset: 0xD0CE70 VA: 0x180D0E470
	public static StatisticsManager get_StatisticsManager() { }

	// RVA: 0xD0DF90 Offset: 0xD0C990 VA: 0x180D0DF90
	public static bool get_IsServer() { }

	// RVA: 0xD0DF10 Offset: 0xD0C910 VA: 0x180D0DF10
	public static bool get_IsServerOnly() { }

	// RVA: 0xD0DD50 Offset: 0xD0C750 VA: 0x180D0DD50
	public static bool get_IsClient() { }

	// RVA: 0xD0DCD0 Offset: 0xD0C6D0 VA: 0x180D0DCD0
	public static bool get_IsClientOnly() { }

	// RVA: 0xD0DDD0 Offset: 0xD0C7D0 VA: 0x180D0DDD0
	public static bool get_IsHost() { }

	// RVA: 0xD0DE50 Offset: 0xD0C850 VA: 0x180D0DE50
	public static bool get_IsOffline() { }

	// RVA: -1 Offset: -1
	public static void RegisterInvokeOnInstance<T>(Action<Component> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3CA0 Offset: 0xEE26A0 VA: 0x180EE3CA0
	|-InstanceFinder.RegisterInvokeOnInstance<object>
	*/

	// RVA: -1 Offset: -1
	public static void UnregisterInvokeOnInstance<T>(Action<Component> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3EA0 Offset: 0xEE28A0 VA: 0x180EE3EA0
	|-InstanceFinder.UnregisterInvokeOnInstance<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3B60 Offset: 0xEE2560 VA: 0x180EE3B60
	|-InstanceFinder.GetInstance<object>
	*/

	// RVA: -1 Offset: -1
	public static bool HasInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3BA0 Offset: 0xEE25A0 VA: 0x180EE3BA0
	|-InstanceFinder.HasInstance<object>
	*/

	// RVA: -1 Offset: -1
	public static void RegisterInstance<T>(T component, bool replace = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3C40 Offset: 0xEE2640 VA: 0x180EE3C40
	|-InstanceFinder.RegisterInstance<object>
	*/

	// RVA: -1 Offset: -1
	public static bool TryRegisterInstance<T>(T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3D40 Offset: 0xEE2740 VA: 0x180EE3D40
	|-InstanceFinder.TryRegisterInstance<object>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetInstance<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3CF0 Offset: 0xEE26F0 VA: 0x180EE3CF0
	|-InstanceFinder.TryGetInstance<object>
	*/

	// RVA: -1 Offset: -1
	public static void UnregisterInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3E60 Offset: 0xEE2860 VA: 0x180EE3E60
	|-InstanceFinder.UnregisterInstance<object>
	*/
}
