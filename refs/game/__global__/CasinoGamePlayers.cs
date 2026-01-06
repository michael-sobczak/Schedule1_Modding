public class CasinoGamePlayers : NetworkBehaviour // TypeDefIndex: 2028
{
	// Fields
	public int PlayerLimit; // 0x118
	private Player[] Players; // 0x120
	public UnityEvent onPlayerListChanged; // 0x128
	public UnityEvent onPlayerScoresChanged; // 0x130
	private Dictionary<Player, int> playerScores; // 0x138
	private Dictionary<Player, CasinoGamePlayerData> playerDatas; // 0x140
	private bool NetworkInitialize___EarlyScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted; // 0x148
	private bool NetworkInitialize__LateScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted; // 0x149

	// Properties
	public int CurrentPlayerCount { get; }

	// Methods

	// RVA: 0x7CF200 Offset: 0x7CDC00 VA: 0x1807CF200
	public int get_CurrentPlayerCount() { }

	// RVA: 0x7CAB90 Offset: 0x7C9590 VA: 0x1807CAB90 Slot: 19
	public override void Awake() { }

	// RVA: 0x7CB4D0 Offset: 0x7C9ED0 VA: 0x1807CB4D0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x7CA9F0 Offset: 0x7C93F0 VA: 0x1807CA9F0
	public void AddPlayer(Player player) { }

	// RVA: 0x7CBD10 Offset: 0x7CA710 VA: 0x1807CBD10
	public void RemovePlayer(Player player) { }

	// RVA: 0x7CEFC0 Offset: 0x7CD9C0 VA: 0x1807CEFC0
	public void SetPlayerScore(Player player, int score) { }

	// RVA: 0x7CAFE0 Offset: 0x7C99E0 VA: 0x1807CAFE0
	public int GetPlayerScore(Player player) { }

	// RVA: 0x7CB0B0 Offset: 0x7C9AB0 VA: 0x1807CB0B0
	public Player GetPlayer(int index) { }

	// RVA: 0x7CAE30 Offset: 0x7C9830 VA: 0x1807CAE30
	public int GetPlayerIndex(Player player) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7CBE60 Offset: 0x7CA860 VA: 0x1807CBE60
	private void RequestAddPlayer(NetworkObject playerObject) { }

	// RVA: 0x7CA8D0 Offset: 0x7C92D0 VA: 0x1807CA8D0
	private void AddPlayerToArray(Player player) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x7CBF90 Offset: 0x7CA990 VA: 0x1807CBF90
	private void RequestRemovePlayer(NetworkObject playerObject) { }

	// RVA: 0x7CBC10 Offset: 0x7CA610 VA: 0x1807CBC10
	private void RemovePlayerFromArray(Player player) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x7CC0C0 Offset: 0x7CAAC0 VA: 0x1807CC0C0
	private void RequestSetScore(NetworkObject playerObject, int score) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7CED00 Offset: 0x7CD700 VA: 0x1807CED00
	private void SetPlayerScore(NetworkConnection conn, NetworkObject playerObject, int score) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7CEAA0 Offset: 0x7CD4A0 VA: 0x1807CEAA0
	private void SetPlayerList(NetworkConnection conn, NetworkObject[] playerObjects) { }

	// RVA: 0x7CADD0 Offset: 0x7C97D0 VA: 0x1807CADD0
	public CasinoGamePlayerData GetPlayerData() { }

	// RVA: 0x7CAC10 Offset: 0x7C9610 VA: 0x1807CAC10
	public CasinoGamePlayerData GetPlayerData(Player player) { }

	// RVA: 0x7CAD10 Offset: 0x7C9710 VA: 0x1807CAD10
	public CasinoGamePlayerData GetPlayerData(int index) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7CE790 Offset: 0x7CD190 VA: 0x1807CE790
	public void SendPlayerBool(NetworkObject playerObject, string key, bool value) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x7CB660 Offset: 0x7CA060 VA: 0x1807CB660
	private void ReceivePlayerBool(NetworkConnection conn, NetworkObject playerObject, string key, bool value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7CE910 Offset: 0x7CD310 VA: 0x1807CE910
	public void SendPlayerFloat(NetworkObject playerObject, string key, float value) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7CB930 Offset: 0x7CA330 VA: 0x1807CB930
	private void ReceivePlayerFloat(NetworkConnection conn, NetworkObject playerObject, string key, float value) { }

	// RVA: 0x7CAE80 Offset: 0x7C9880 VA: 0x1807CAE80
	private NetworkObject[] GetPlayerObjects() { }

	// RVA: 0x7CF120 Offset: 0x7CDB20 VA: 0x1807CF120
	public void .ctor() { }

	// RVA: 0x7CB110 Offset: 0x7C9B10 VA: 0x1807CB110 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7CB0F0 Offset: 0x7C9AF0 VA: 0x1807CB0F0 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7CDDF0 Offset: 0x7CC7F0 VA: 0x1807CDDF0
	private void RpcWriter___Server_RequestAddPlayer_3323014238(NetworkObject playerObject) { }

	// RVA: 0x7CC570 Offset: 0x7CAF70 VA: 0x1807CC570
	private void RpcLogic___RequestAddPlayer_3323014238(NetworkObject playerObject) { }

	// RVA: 0x7CD130 Offset: 0x7CBB30 VA: 0x1807CD130
	private void RpcReader___Server_RequestAddPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7CBF90 Offset: 0x7CA990 VA: 0x1807CBF90
	private void RpcWriter___Server_RequestRemovePlayer_3323014238(NetworkObject playerObject) { }

	// RVA: 0x7CC830 Offset: 0x7CB230 VA: 0x1807CC830
	private void RpcLogic___RequestRemovePlayer_3323014238(NetworkObject playerObject) { }

	// RVA: 0x7CD1B0 Offset: 0x7CBBB0 VA: 0x1807CD1B0
	private void RpcReader___Server_RequestRemovePlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7CC0C0 Offset: 0x7CAAC0 VA: 0x1807CC0C0
	private void RpcWriter___Server_RequestSetScore_4172557123(NetworkObject playerObject, int score) { }

	// RVA: 0x7CC9E0 Offset: 0x7CB3E0 VA: 0x1807CC9E0
	private void RpcLogic___RequestSetScore_4172557123(NetworkObject playerObject, int score) { }

	// RVA: 0x7CD380 Offset: 0x7CBD80 VA: 0x1807CD380
	private void RpcReader___Server_RequestSetScore_4172557123(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7CDC70 Offset: 0x7CC670 VA: 0x1807CDC70
	private void RpcWriter___Observers_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score) { }

	// RVA: 0x7CCD70 Offset: 0x7CB770 VA: 0x1807CCD70
	private void RpcLogic___SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score) { }

	// RVA: 0x7CD080 Offset: 0x7CBA80 VA: 0x1807CD080
	private void RpcReader___Observers_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7CE620 Offset: 0x7CD020 VA: 0x1807CE620
	private void RpcWriter___Target_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score) { }

	// RVA: 0x7CD790 Offset: 0x7CC190 VA: 0x1807CD790
	private void RpcReader___Target_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7CDB30 Offset: 0x7CC530 VA: 0x1807CDB30
	private void RpcWriter___Observers_SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects) { }

	// RVA: 0x7CCA60 Offset: 0x7CB460 VA: 0x1807CCA60
	private void RpcLogic___SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects) { }

	// RVA: 0x7CD020 Offset: 0x7CBA20 VA: 0x1807CD020
	private void RpcReader___Observers_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7CE4C0 Offset: 0x7CCEC0 VA: 0x1807CE4C0
	private void RpcWriter___Target_SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects) { }

	// RVA: 0x7CD730 Offset: 0x7CC130 VA: 0x1807CD730
	private void RpcReader___Target_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7CDF20 Offset: 0x7CC920 VA: 0x1807CDF20
	private void RpcWriter___Server_SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value) { }

	// RVA: 0x7CCA00 Offset: 0x7CB400 VA: 0x1807CCA00
	public void RpcLogic___SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value) { }

	// RVA: 0x7CD410 Offset: 0x7CBE10 VA: 0x1807CD410
	private void RpcReader___Server_SendPlayerBool_77262511(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7CD830 Offset: 0x7CC230 VA: 0x1807CD830
	private void RpcWriter___Observers_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value) { }

	// RVA: 0x7CC230 Offset: 0x7CAC30 VA: 0x1807CC230
	private void RpcLogic___ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value) { }

	// RVA: 0x7CCE90 Offset: 0x7CB890 VA: 0x1807CCE90
	private void RpcReader___Observers_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7CE1E0 Offset: 0x7CCBE0 VA: 0x1807CE1E0
	private void RpcWriter___Target_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value) { }

	// RVA: 0x7CD5B0 Offset: 0x7CBFB0 VA: 0x1807CD5B0
	private void RpcReader___Target_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7CE080 Offset: 0x7CCA80 VA: 0x1807CE080
	private void RpcWriter___Server_SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value) { }

	// RVA: 0x7CCA30 Offset: 0x7CB430 VA: 0x1807CCA30
	public void RpcLogic___SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value) { }

	// RVA: 0x7CD4F0 Offset: 0x7CBEF0 VA: 0x1807CD4F0
	private void RpcReader___Server_SendPlayerFloat_2931762093(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7CD9B0 Offset: 0x7CC3B0 VA: 0x1807CD9B0
	private void RpcWriter___Observers_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value) { }

	// RVA: 0x7CC3D0 Offset: 0x7CADD0 VA: 0x1807CC3D0
	private void RpcLogic___ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value) { }

	// RVA: 0x7CCF60 Offset: 0x7CB960 VA: 0x1807CCF60
	private void RpcReader___Observers_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7CE350 Offset: 0x7CCD50 VA: 0x1807CE350
	private void RpcWriter___Target_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value) { }

	// RVA: 0x7CD680 Offset: 0x7CC080 VA: 0x1807CD680
	private void RpcReader___Target_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7CAB30 Offset: 0x7C9530 VA: 0x1807CAB30
	private void Awake_UserLogic_ScheduleOne.Casino.CasinoGamePlayers_Assembly-CSharp.dll() { }
}
