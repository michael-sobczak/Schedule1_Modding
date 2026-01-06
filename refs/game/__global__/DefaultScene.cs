public class DefaultScene : MonoBehaviour // TypeDefIndex: 12666
{
	// Fields
	[SerializeField]
	[Tooltip("True to enable use of this component.")]
	private bool _enabled; // 0x20
	[Tooltip("True to load the online scene as global, false to load it as connection.")]
	[FormerlySerializedAs("_useGlobalScenes")]
	[SerializeField]
	private bool _enableGlobalScenes; // 0x21
	[Tooltip("True to replace all scenes with the offline scene immediately.")]
	[SerializeField]
	private bool _startInOffline; // 0x22
	[Tooltip("Scene to load when disconnected. Server and client will load this scene.")]
	[SerializeField]
	[Scene]
	private string _offlineScene; // 0x28
	[Scene]
	[SerializeField]
	[Tooltip("Scene to load when connected. Server and client will load this scene.")]
	private string _onlineScene; // 0x30
	[SerializeField]
	[Tooltip("Which scenes to replace when loading into OnlineScene.")]
	private ReplaceOption _replaceScenes; // 0x38
	private NetworkManager _networkManager; // 0x40

	// Methods

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void SetOfflineScene(string sceneName) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string GetOfflineScene() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void SetOnlineScene(string sceneName) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string GetOnlineScene() { }

	// RVA: 0xD26CB0 Offset: 0xD256B0 VA: 0x180D26CB0
	private void Awake() { }

	// RVA: 0xD271F0 Offset: 0xD25BF0 VA: 0x180D271F0
	private void OnDestroy() { }

	// RVA: 0xD26D50 Offset: 0xD25750 VA: 0x180D26D50
	private void InitializeOnce() { }

	// RVA: 0xD27470 Offset: 0xD25E70 VA: 0x180D27470
	private void SceneManager_OnLoadEnd(SceneLoadEndEventArgs obj) { }

	// RVA: 0xD27710 Offset: 0xD26110 VA: 0x180D27710
	private void ServerManager_OnServerConnectionState(ServerConnectionStateArgs obj) { }

	// RVA: 0xD26CC0 Offset: 0xD256C0 VA: 0x180D26CC0
	private void ClientManager_OnClientConnectionState(ClientConnectionStateArgs obj) { }

	// RVA: 0xD27620 Offset: 0xD26020 VA: 0x180D27620
	private void ServerManager_OnAuthenticationResult(NetworkConnection arg1, bool authenticated) { }

	// RVA: 0xD27100 Offset: 0xD25B00 VA: 0x180D27100
	private void LoadOfflineScene() { }

	// RVA: 0xD27850 Offset: 0xD26250 VA: 0x180D27850
	private void UnloadOfflineScene() { }

	// RVA: 0xD26D00 Offset: 0xD25700 VA: 0x180D26D00
	private string GetSceneName(string fullPath) { }

	// RVA: 0xD27920 Offset: 0xD26320 VA: 0x180D27920
	public void .ctor() { }
}
