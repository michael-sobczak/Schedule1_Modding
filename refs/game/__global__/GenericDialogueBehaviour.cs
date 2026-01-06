public class GenericDialogueBehaviour : Behaviour // TypeDefIndex: 1841
{
	// Fields
	private Player targetPlayer; // 0x168
	[Header("Settings")]
	public bool FaceConversationTarget; // 0x170
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.GenericDialogueBehaviourAssembly-CSharp.dll_Excuted; // 0x171
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.GenericDialogueBehaviourAssembly-CSharp.dll_Excuted; // 0x172

	// Methods

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x763E90 Offset: 0x762890 VA: 0x180763E90
	public void SendTargetPlayer(NetworkObject player) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7637D0 Offset: 0x7621D0 VA: 0x1807637D0
	private void SetTargetPlayer(NetworkObject player) { }

	// RVA: 0x7632C0 Offset: 0x761CC0 VA: 0x1807632C0 Slot: 20
	public override void Enable() { }

	// RVA: 0x73D060 Offset: 0x73BA60 VA: 0x18073D060 Slot: 21
	public override void Disable() { }

	// RVA: 0x763210 Offset: 0x761C10 VA: 0x180763210 Slot: 22
	public override void Activate() { }

	// RVA: 0x763760 Offset: 0x762160 VA: 0x180763760 Slot: 25
	public override void Resume() { }

	// RVA: 0x763280 Offset: 0x761C80 VA: 0x180763280 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x763410 Offset: 0x761E10 VA: 0x180763410 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x763FC0 Offset: 0x7629C0 VA: 0x180763FC0
	public void .ctor() { }

	// RVA: 0x763320 Offset: 0x761D20 VA: 0x180763320 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x763300 Offset: 0x761D00 VA: 0x180763300 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x763D60 Offset: 0x762760 VA: 0x180763D60
	private void RpcWriter___Server_SendTargetPlayer_3323014238(NetworkObject player) { }

	// RVA: 0x7637D0 Offset: 0x7621D0 VA: 0x1807637D0
	public void RpcLogic___SendTargetPlayer_3323014238(NetworkObject player) { }

	// RVA: 0x763B90 Offset: 0x762590 VA: 0x180763B90
	private void RpcReader___Server_SendTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x763C10 Offset: 0x762610 VA: 0x180763C10
	private void RpcWriter___Observers_SetTargetPlayer_3323014238(NetworkObject player) { }

	// RVA: 0x763910 Offset: 0x762310 VA: 0x180763910
	private void RpcLogic___SetTargetPlayer_3323014238(NetworkObject player) { }

	// RVA: 0x763B20 Offset: 0x762520 VA: 0x180763B20
	private void RpcReader___Observers_SetTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
