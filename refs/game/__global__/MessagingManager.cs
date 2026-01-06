public class MessagingManager : NetworkSingleton<MessagingManager> // TypeDefIndex: 1163
{
	// Fields
	protected Dictionary<NPC, MSGConversation> ConversationMap; // 0x120
	private bool NetworkInitialize___EarlyScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted; // 0x128
	private bool NetworkInitialize__LateScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted; // 0x129

	// Methods

	// RVA: 0x5E0D00 Offset: 0x5DF700 VA: 0x1805E0D00 Slot: 20
	public override void Awake() { }

	// RVA: 0x5E13D0 Offset: 0x5DFDD0 VA: 0x1805E13D0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x5E0EA0 Offset: 0x5DF8A0 VA: 0x1805E0EA0
	public MSGConversation GetConversation(NPC npc) { }

	// RVA: 0x5E2150 Offset: 0x5E0B50 VA: 0x1805E2150
	public void Register(NPC npc, MSGConversation convs) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x5E4820 Offset: 0x5E3220 VA: 0x1805E4820
	public void SendMessage(Message m, bool notify, string npcID) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x5E1B10 Offset: 0x5E0510 VA: 0x1805E1B10
	private void ReceiveMessage(Message m, bool notify, string npcID) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x5E4680 Offset: 0x5E3080 VA: 0x1805E4680
	public void SendMessageChain(MessageChain m, string npcID, float initialDelay, bool notify) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x5E1950 Offset: 0x5E0350 VA: 0x1805E1950
	private void ReceiveMessageChain(MessageChain m, string npcID, float initialDelay, bool notify) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x5E4B40 Offset: 0x5E3540 VA: 0x1805E4B40
	public void SendResponse(int responseIndex, string npcID) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x5E1E50 Offset: 0x5E0850 VA: 0x1805E1E50
	private void ReceiveResponse(int responseIndex, string npcID) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x5E49A0 Offset: 0x5E33A0 VA: 0x1805E49A0
	public void SendPlayerMessage(int sendableIndex, int sentIndex, string npcID) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x5E1CA0 Offset: 0x5E06A0 VA: 0x1805E1CA0
	private void ReceivePlayerMessage(int sendableIndex, int sentIndex, string npcID) { }

	[TargetRpc]
	// RVA: 0x5E17F0 Offset: 0x5E01F0 VA: 0x1805E17F0
	private void ReceiveMSGConversationData(NetworkConnection conn, string npcID, MSGConversationData data) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x5E0D70 Offset: 0x5DF770 VA: 0x1805E0D70
	public void ClearResponses(string npcID) { }

	[ObserversRpc]
	// RVA: 0x5E16B0 Offset: 0x5E00B0 VA: 0x1805E16B0
	private void ReceiveClearResponses(string npcID) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x5E4CA0 Offset: 0x5E36A0 VA: 0x1805E4CA0
	public void ShowResponses(string npcID, List<Response> responses, float delay) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x5E1FC0 Offset: 0x5E09C0 VA: 0x1805E1FC0
	private void ReceiveShowResponses(string npcID, List<Response> responses, float delay) { }

	// RVA: 0x5E4EE0 Offset: 0x5E38E0 VA: 0x1805E4EE0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5E4E20 Offset: 0x5E3820 VA: 0x1805E4E20
	private void <OnSpawnServer>g__Replicate|2_0(NPC npc, NetworkConnection conn) { }

	// RVA: 0x5E0FF0 Offset: 0x5DF9F0 VA: 0x1805E0FF0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x5E0FA0 Offset: 0x5DF9A0 VA: 0x1805E0FA0 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5E40D0 Offset: 0x5E2AD0 VA: 0x1805E40D0
	private void RpcWriter___Server_SendMessage_2134336246(Message m, bool notify, string npcID) { }

	// RVA: 0x5E1B10 Offset: 0x5E0510 VA: 0x1805E1B10
	public void RpcLogic___SendMessage_2134336246(Message m, bool notify, string npcID) { }

	// RVA: 0x5E3370 Offset: 0x5E1D70 VA: 0x1805E3370
	private void RpcReader___Server_SendMessage_2134336246(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5E3970 Offset: 0x5E2370 VA: 0x1805E3970
	private void RpcWriter___Observers_ReceiveMessage_2134336246(Message m, bool notify, string npcID) { }

	// RVA: 0x5E2640 Offset: 0x5E1040 VA: 0x1805E2640
	private void RpcLogic___ReceiveMessage_2134336246(Message m, bool notify, string npcID) { }

	// RVA: 0x5E2E70 Offset: 0x5E1870 VA: 0x1805E2E70
	private void RpcReader___Observers_ReceiveMessage_2134336246(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5E3F60 Offset: 0x5E2960 VA: 0x1805E3F60
	private void RpcWriter___Server_SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify) { }

	// RVA: 0x5E1950 Offset: 0x5E0350 VA: 0x1805E1950
	public void RpcLogic___SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify) { }

	// RVA: 0x5E3280 Offset: 0x5E1C80 VA: 0x1805E3280
	private void RpcReader___Server_SendMessageChain_3949292778(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5E37F0 Offset: 0x5E21F0 VA: 0x1805E37F0
	private void RpcWriter___Observers_ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify) { }

	// RVA: 0x5E24E0 Offset: 0x5E0EE0 VA: 0x1805E24E0
	private void RpcLogic___ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify) { }

	// RVA: 0x5E2D90 Offset: 0x5E1790 VA: 0x1805E2D90
	private void RpcReader___Observers_ReceiveMessageChain_3949292778(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5E43B0 Offset: 0x5E2DB0 VA: 0x1805E43B0
	private void RpcWriter___Server_SendResponse_2801973956(int responseIndex, string npcID) { }

	// RVA: 0x5E1E50 Offset: 0x5E0850 VA: 0x1805E1E50
	public void RpcLogic___SendResponse_2801973956(int responseIndex, string npcID) { }

	// RVA: 0x5E3510 Offset: 0x5E1F10 VA: 0x1805E3510
	private void RpcReader___Server_SendResponse_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5E3C70 Offset: 0x5E2670 VA: 0x1805E3C70
	private void RpcWriter___Observers_ReceiveResponse_2801973956(int responseIndex, string npcID) { }

	// RVA: 0x5E2900 Offset: 0x5E1300 VA: 0x1805E2900
	private void RpcLogic___ReceiveResponse_2801973956(int responseIndex, string npcID) { }

	// RVA: 0x5E2FE0 Offset: 0x5E19E0 VA: 0x1805E2FE0
	private void RpcReader___Observers_ReceiveResponse_2801973956(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5E4230 Offset: 0x5E2C30 VA: 0x1805E4230
	private void RpcWriter___Server_SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID) { }

	// RVA: 0x5E1CA0 Offset: 0x5E06A0 VA: 0x1805E1CA0
	public void RpcLogic___SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID) { }

	// RVA: 0x5E3440 Offset: 0x5E1E40 VA: 0x1805E3440
	private void RpcReader___Server_SendPlayerMessage_1952281135(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5E3AE0 Offset: 0x5E24E0 VA: 0x1805E3AE0
	private void RpcWriter___Observers_ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID) { }

	// RVA: 0x5E27A0 Offset: 0x5E11A0 VA: 0x1805E27A0
	private void RpcLogic___ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID) { }

	// RVA: 0x5E2F20 Offset: 0x5E1920 VA: 0x1805E2F20
	private void RpcReader___Observers_ReceivePlayerMessage_1952281135(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5E17F0 Offset: 0x5E01F0 VA: 0x1805E17F0
	private void RpcWriter___Target_ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data) { }

	// RVA: 0x5E23A0 Offset: 0x5E0DA0 VA: 0x1805E23A0
	private void RpcLogic___ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data) { }

	// RVA: 0x5E3670 Offset: 0x5E2070 VA: 0x1805E3670
	private void RpcReader___Target_ReceiveMSGConversationData_2662241369(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5E0D70 Offset: 0x5DF770 VA: 0x1805E0D70
	private void RpcWriter___Server_ClearResponses_3615296227(string npcID) { }

	// RVA: 0x5E16B0 Offset: 0x5E00B0 VA: 0x1805E16B0
	public void RpcLogic___ClearResponses_3615296227(string npcID) { }

	// RVA: 0x5E3110 Offset: 0x5E1B10 VA: 0x1805E3110
	private void RpcReader___Server_ClearResponses_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5E16B0 Offset: 0x5E00B0 VA: 0x1805E16B0
	private void RpcWriter___Observers_ReceiveClearResponses_3615296227(string npcID) { }

	// RVA: 0x5E2260 Offset: 0x5E0C60 VA: 0x1805E2260
	private void RpcLogic___ReceiveClearResponses_3615296227(string npcID) { }

	// RVA: 0x5E2C30 Offset: 0x5E1630 VA: 0x1805E2C30
	private void RpcReader___Observers_ReceiveClearResponses_3615296227(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5E4520 Offset: 0x5E2F20 VA: 0x1805E4520
	private void RpcWriter___Server_ShowResponses_995803534(string npcID, List<Response> responses, float delay) { }

	// RVA: 0x5E1FC0 Offset: 0x5E09C0 VA: 0x1805E1FC0
	public void RpcLogic___ShowResponses_995803534(string npcID, List<Response> responses, float delay) { }

	// RVA: 0x5E35B0 Offset: 0x5E1FB0 VA: 0x1805E35B0
	private void RpcReader___Server_ShowResponses_995803534(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5E3DF0 Offset: 0x5E27F0 VA: 0x1805E3DF0
	private void RpcWriter___Observers_ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay) { }

	// RVA: 0x5E2AE0 Offset: 0x5E14E0 VA: 0x1805E2AE0
	private void RpcLogic___ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay) { }

	// RVA: 0x5E3070 Offset: 0x5E1A70 VA: 0x1805E3070
	private void RpcReader___Observers_ReceiveShowResponses_995803534(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5E0CC0 Offset: 0x5DF6C0 VA: 0x1805E0CC0 Slot: 25
	protected override void Awake_UserLogic_ScheduleOne.Messaging.MessagingManager_Assembly-CSharp.dll() { }
}
