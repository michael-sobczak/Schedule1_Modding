public class FaceTargetBehaviour : Behaviour // TypeDefIndex: 1835
{
	// Fields
	[CompilerGenerated]
	private FaceTargetBehaviour.ETargetType <TargetType>k__BackingField; // 0x168
	[CompilerGenerated]
	private Player <TargetPlayer>k__BackingField; // 0x170
	[CompilerGenerated]
	private Vector3 <TargetPosition>k__BackingField; // 0x178
	[CompilerGenerated]
	private float <Countdown>k__BackingField; // 0x184
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FaceTargetBehaviourAssembly-CSharp.dll_Excuted; // 0x188
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FaceTargetBehaviourAssembly-CSharp.dll_Excuted; // 0x189

	// Properties
	public FaceTargetBehaviour.ETargetType TargetType { get; set; }
	public Player TargetPlayer { get; set; }
	public Vector3 TargetPosition { get; set; }
	public float Countdown { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x73B350 Offset: 0x739D50 VA: 0x18073B350
	public FaceTargetBehaviour.ETargetType get_TargetType() { }

	[CompilerGenerated]
	// RVA: 0x739E10 Offset: 0x738810 VA: 0x180739E10
	private void set_TargetType(FaceTargetBehaviour.ETargetType value) { }

	[CompilerGenerated]
	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360
	public Player get_TargetPlayer() { }

	[CompilerGenerated]
	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0
	private void set_TargetPlayer(Player value) { }

	[CompilerGenerated]
	// RVA: 0x74A070 Offset: 0x748A70 VA: 0x18074A070
	public Vector3 get_TargetPosition() { }

	[CompilerGenerated]
	// RVA: 0x74A0A0 Offset: 0x748AA0 VA: 0x18074A0A0
	private void set_TargetPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x74A060 Offset: 0x748A60 VA: 0x18074A060
	public float get_Countdown() { }

	[CompilerGenerated]
	// RVA: 0x74A090 Offset: 0x748A90 VA: 0x18074A090
	private void set_Countdown(float value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x749D00 Offset: 0x748700 VA: 0x180749D00
	public void SetTarget(NetworkObject player, float countDown = 5) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x749BC0 Offset: 0x7485C0 VA: 0x180749BC0
	private void SetTargetLocal(NetworkObject player) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x749E50 Offset: 0x748850 VA: 0x180749E50
	public void SetTarget(Vector3 position, float countDown = 5) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x749A20 Offset: 0x748420 VA: 0x180749A20
	private void SetTargetLocal(Vector3 position) { }

	// RVA: 0x7488E0 Offset: 0x7472E0 VA: 0x1807488E0 Slot: 22
	public override void Activate() { }

	// RVA: 0x748920 Offset: 0x747320 VA: 0x180748920 Slot: 26
	public override void BehaviourUpdate() { }

	// RVA: 0x748AD0 Offset: 0x7474D0 VA: 0x180748AD0
	private Vector3 GetTargetPosition() { }

	// RVA: 0x73D060 Offset: 0x73BA60 VA: 0x18073D060 Slot: 21
	public override void Disable() { }

	// RVA: 0x74A000 Offset: 0x748A00 VA: 0x18074A000
	public void .ctor() { }

	// RVA: 0x748BB0 Offset: 0x7475B0 VA: 0x180748BB0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x748B90 Offset: 0x747590 VA: 0x180748B90 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x749720 Offset: 0x748120 VA: 0x180749720
	private void RpcWriter___Server_SetTarget_244313061(NetworkObject player, float countDown = 5) { }

	// RVA: 0x748DF0 Offset: 0x7477F0 VA: 0x180748DF0
	public void RpcLogic___SetTarget_244313061(NetworkObject player, float countDown = 5) { }

	// RVA: 0x7492A0 Offset: 0x747CA0 VA: 0x1807492A0
	private void RpcReader___Server_SetTarget_244313061(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x749440 Offset: 0x747E40 VA: 0x180749440
	private void RpcWriter___Observers_SetTargetLocal_3323014238(NetworkObject player) { }

	// RVA: 0x748D20 Offset: 0x747720 VA: 0x180748D20
	private void RpcLogic___SetTargetLocal_3323014238(NetworkObject player) { }

	// RVA: 0x749170 Offset: 0x747B70 VA: 0x180749170
	private void RpcReader___Observers_SetTargetLocal_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x749880 Offset: 0x748280 VA: 0x180749880
	private void RpcWriter___Server_SetTarget_3661469815(Vector3 position, float countDown = 5) { }

	// RVA: 0x748FD0 Offset: 0x7479D0 VA: 0x180748FD0
	public void RpcLogic___SetTarget_3661469815(Vector3 position, float countDown = 5) { }

	// RVA: 0x749350 Offset: 0x747D50 VA: 0x180749350
	private void RpcReader___Server_SetTarget_3661469815(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x749590 Offset: 0x747F90 VA: 0x180749590
	private void RpcWriter___Observers_SetTargetLocal_4276783012(Vector3 position) { }

	// RVA: 0x748DD0 Offset: 0x7477D0 VA: 0x180748DD0
	private void RpcLogic___SetTargetLocal_4276783012(Vector3 position) { }

	// RVA: 0x7491E0 Offset: 0x747BE0 VA: 0x1807491E0
	private void RpcReader___Observers_SetTargetLocal_4276783012(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
