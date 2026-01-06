public class NetworkHudCanvases : MonoBehaviour // TypeDefIndex: 18083
{
	// Fields
	[SerializeField]
	[Tooltip("What connections to automatically start on play.")]
	private NetworkHudCanvases.AutoStartType _autoStartType; // 0x20
	[Tooltip("Color when socket is stopped.")]
	[SerializeField]
	private Color _stoppedColor; // 0x24
	[Tooltip("Color when socket is changing.")]
	[SerializeField]
	private Color _changingColor; // 0x34
	[Tooltip("Color when socket is started.")]
	[SerializeField]
	private Color _startedColor; // 0x44
	[Header("Indicators")]
	[SerializeField]
	[Tooltip("Indicator for server state.")]
	private Image _serverIndicator; // 0x58
	[Tooltip("Indicator for client state.")]
	[SerializeField]
	private Image _clientIndicator; // 0x60
	[SerializeField]
	private bool DrawGUI; // 0x68
	private NetworkManager _networkManager; // 0x70
	private LocalConnectionState _clientState; // 0x78
	private LocalConnectionState _serverState; // 0x79

	// Methods

	// RVA: 0xCE8B80 Offset: 0xCE7580 VA: 0x180CE8B80
	private void OnGUI() { }

	// RVA: 0xCE9040 Offset: 0xCE7A40 VA: 0x180CE9040
	private void Start() { }

	// RVA: 0xCE8A50 Offset: 0xCE7450 VA: 0x180CE8A50
	private void OnDestroy() { }

	// RVA: 0xCE93F0 Offset: 0xCE7DF0 VA: 0x180CE93F0
	private void UpdateColor(LocalConnectionState state, ref Image img) { }

	// RVA: 0xCE88B0 Offset: 0xCE72B0 VA: 0x180CE88B0
	private void ClientManager_OnClientConnectionState(ClientConnectionStateArgs obj) { }

	// RVA: 0xCE8FE0 Offset: 0xCE79E0 VA: 0x180CE8FE0
	private void ServerManager_OnServerConnectionState(ServerConnectionStateArgs obj) { }

	// RVA: 0xCE89B0 Offset: 0xCE73B0 VA: 0x180CE89B0
	public void OnClick_Server() { }

	// RVA: 0xCE8910 Offset: 0xCE7310 VA: 0x180CE8910
	public void OnClick_Client() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void SetEventSystem() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void DeselectButtons() { }

	// RVA: 0xCE9440 Offset: 0xCE7E40 VA: 0x180CE9440
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xCE9340 Offset: 0xCE7D40 VA: 0x180CE9340
	internal static string <OnGUI>g__GetNextStateText|11_0(LocalConnectionState state) { }
}
