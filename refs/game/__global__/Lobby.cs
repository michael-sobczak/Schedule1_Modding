public class Lobby : PersistentSingleton<Lobby> // TypeDefIndex: 1146
{
	// Fields
	public const bool ENABLED = True;
	public const int PLAYER_LIMIT = 4;
	public const string JOIN_READY = "ready";
	public const string LOAD_TUTORIAL = "load_tutorial";
	public const string HOST_LOADING = "host_loading";
	[CompilerGenerated]
	private ulong <LobbyID>k__BackingField; // 0x28
	[CompilerGenerated]
	private CSteamID <LocalPlayerID>k__BackingField; // 0x30
	public CSteamID[] Players; // 0x38
	public Action onLobbyChange; // 0x40
	private Callback<LobbyCreated_t> LobbyCreatedCallback; // 0x48
	private Callback<LobbyEnter_t> LobbyEnteredCallback; // 0x50
	private Callback<LobbyChatUpdate_t> ChatUpdateCallback; // 0x58
	private Callback<GameLobbyJoinRequested_t> GameLobbyJoinRequestedCallback; // 0x60
	private Callback<LobbyChatMsg_t> LobbyChatMessageCallback; // 0x68

	// Properties
	public bool IsHost { get; }
	public ulong LobbyID { get; set; }
	public CSteamID LobbySteamID { get; }
	public bool IsInLobby { get; }
	public int PlayerCount { get; }
	public CSteamID LocalPlayerID { get; set; }

	// Methods

	// RVA: 0x5E06A0 Offset: 0x5DF0A0 VA: 0x1805E06A0
	public bool get_IsHost() { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ulong get_LobbyID() { }

	[CompilerGenerated]
	// RVA: 0x5E0880 Offset: 0x5DF280 VA: 0x1805E0880
	private void set_LobbyID(ulong value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public CSteamID get_LobbySteamID() { }

	// RVA: 0x5E0740 Offset: 0x5DF140 VA: 0x1805E0740
	public bool get_IsInLobby() { }

	// RVA: 0x5E0750 Offset: 0x5DF150 VA: 0x1805E0750
	public int get_PlayerCount() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public CSteamID get_LocalPlayerID() { }

	[CompilerGenerated]
	// RVA: 0x5E0890 Offset: 0x5DF290 VA: 0x1805E0890
	private void set_LocalPlayerID(CSteamID value) { }

	// RVA: 0x5DEE10 Offset: 0x5DD810 VA: 0x1805DEE10 Slot: 5
	protected override void Awake() { }

	// RVA: 0x5E00F0 Offset: 0x5DEAF0 VA: 0x1805E00F0 Slot: 4
	protected override void Start() { }

	// RVA: 0x5DF050 Offset: 0x5DDA50 VA: 0x1805DF050
	private void InitializeCallbacks() { }

	// RVA: 0x5E0400 Offset: 0x5DEE00 VA: 0x1805E0400
	public void TryOpenInviteInterface() { }

	// RVA: 0x5DF310 Offset: 0x5DDD10 VA: 0x1805DF310
	public void LeaveLobby() { }

	// RVA: 0x5DEF40 Offset: 0x5DD940 VA: 0x1805DEF40
	private void CreateLobby() { }

	// RVA: 0x5DEF60 Offset: 0x5DD960 VA: 0x1805DEF60
	private string GetLaunchLobby() { }

	// RVA: 0x5E04D0 Offset: 0x5DEED0 VA: 0x1805E04D0
	private void UpdateLobbyMembers() { }

	// RVA: 0x5DF280 Offset: 0x5DDC80 VA: 0x1805DF280
	public void JoinAsClient(string steamId64) { }

	// RVA: 0x5DFF90 Offset: 0x5DE990 VA: 0x1805DFF90
	public void SendLobbyMessage(string message) { }

	// RVA: 0x5E0050 Offset: 0x5DEA50 VA: 0x1805E0050
	public void SetLobbyData(string key, string value) { }

	// RVA: 0x5DF7B0 Offset: 0x5DE1B0 VA: 0x1805DF7B0
	private void OnLobbyCreated(LobbyCreated_t result) { }

	// RVA: 0x5DFA20 Offset: 0x5DE420 VA: 0x1805DFA20
	private void OnLobbyEntered(LobbyEnter_t result) { }

	// RVA: 0x5DFE80 Offset: 0x5DE880 VA: 0x1805DFE80
	private void PlayerEnterOrLeave(LobbyChatUpdate_t result) { }

	// RVA: 0x5DF3F0 Offset: 0x5DDDF0 VA: 0x1805DF3F0
	private void LobbyJoinRequested(GameLobbyJoinRequested_t result) { }

	// RVA: 0x5DF4D0 Offset: 0x5DDED0 VA: 0x1805DF4D0
	private void OnLobbyChatMessage(LobbyChatMsg_t result) { }

	// RVA: 0x5E0600 Offset: 0x5DF000 VA: 0x1805E0600
	public void .ctor() { }
}
