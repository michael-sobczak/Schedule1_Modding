public class NPCBehaviour : NetworkBehaviour // TypeDefIndex: 1850
{
	// Fields
	public bool DEBUG_MODE; // 0x118
	[Header("References")]
	public NPCScheduleManager ScheduleManager; // 0x120
	[Header("Default Behaviours")]
	public CoweringBehaviour CoweringBehaviour; // 0x128
	public RagdollBehaviour RagdollBehaviour; // 0x130
	public CallPoliceBehaviour CallPoliceBehaviour; // 0x138
	public GenericDialogueBehaviour GenericDialogueBehaviour; // 0x140
	public HeavyFlinchBehaviour HeavyFlinchBehaviour; // 0x148
	public FaceTargetBehaviour FaceTargetBehaviour; // 0x150
	public DeadBehaviour DeadBehaviour; // 0x158
	public UnconsciousBehaviour UnconsciousBehaviour; // 0x160
	public Behaviour SummonBehaviour; // 0x168
	public ConsumeProductBehaviour ConsumeProductBehaviour; // 0x170
	public CombatBehaviour CombatBehaviour; // 0x178
	public FleeBehaviour FleeBehaviour; // 0x180
	public StationaryBehaviour StationaryBehaviour; // 0x188
	public RequestProductBehaviour RequestProductBehaviour; // 0x190
	[SerializeField]
	protected List<Behaviour> behaviourStack; // 0x198
	[CompilerGenerated]
	private Behaviour <activeBehaviour>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private NPC <Npc>k__BackingField; // 0x1A8
	private Coroutine summonRoutine; // 0x1B0
	[SerializeField]
	private List<Behaviour> enabledBehaviours; // 0x1B8
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted; // 0x1C0
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted; // 0x1C1

	// Properties
	public Behaviour activeBehaviour { get; set; }
	public NPC Npc { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public Behaviour get_activeBehaviour() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	public void set_activeBehaviour(Behaviour value) { }

	[CompilerGenerated]
	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public NPC get_Npc() { }

	[CompilerGenerated]
	// RVA: 0x76A7E0 Offset: 0x7691E0 VA: 0x18076A7E0
	private void set_Npc(NPC value) { }

	// RVA: 0x764C20 Offset: 0x763620 VA: 0x180764C20 Slot: 19
	public override void Awake() { }

	// RVA: 0x769E40 Offset: 0x768840 VA: 0x180769E40 Slot: 20
	protected virtual void Start() { }

	// RVA: 0x766100 Offset: 0x764B00 VA: 0x180766100
	private void OnDestroy() { }

	// RVA: 0x7666D0 Offset: 0x7650D0 VA: 0x1807666D0 Slot: 16
	protected override void OnValidate() { }

	// RVA: 0x766540 Offset: 0x764F40 VA: 0x180766540 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x76A220 Offset: 0x768C20 VA: 0x18076A220
	public void Summon(string buildingGUID, int doorIndex, float duration) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x764C70 Offset: 0x763670 VA: 0x180764C70
	public void ConsumeProduct(ProductItemInstance product) { }

	// RVA: 0x766260 Offset: 0x764C60 VA: 0x180766260
	private void OnKnockOut() { }

	// RVA: 0x766420 Offset: 0x764E20 VA: 0x180766420
	private void OnRevive() { }

	// RVA: 0x766220 Offset: 0x764C20 VA: 0x180766220 Slot: 21
	protected virtual void OnDie() { }

	// RVA: 0x7658E0 Offset: 0x7642E0 VA: 0x1807658E0
	public Behaviour GetBehaviour(string BehaviourName) { }

	// RVA: -1 Offset: -1
	public T GetBehaviour<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07EB0 Offset: 0xF068B0 VA: 0x180F07EB0
	|-NPCBehaviour.GetBehaviour<object>
	*/

	// RVA: 0x76A350 Offset: 0x768D50 VA: 0x18076A350 Slot: 22
	public virtual void Update() { }

	// RVA: 0x765AA0 Offset: 0x7644A0 VA: 0x180765AA0 Slot: 23
	public virtual void LateUpdate() { }

	// RVA: 0x766630 Offset: 0x765030 VA: 0x180766630 Slot: 24
	protected virtual void OnTick() { }

	// RVA: 0x769C80 Offset: 0x768680 VA: 0x180769C80
	public void SortBehaviourStack() { }

	// RVA: 0x765A60 Offset: 0x764460 VA: 0x180765A60
	private Behaviour GetEnabledBehaviour() { }

	// RVA: 0x764840 Offset: 0x763240 VA: 0x180764840
	private void AddEnabledBehaviour(Behaviour b) { }

	// RVA: 0x766CC0 Offset: 0x7656C0 VA: 0x180766CC0
	private void RemoveEnabledBehaviour(Behaviour b) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7657A0 Offset: 0x7641A0 VA: 0x1807657A0
	public void EnableBehaviour_Server(int behaviourIndex) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x765520 Offset: 0x763F20 VA: 0x180765520
	public void EnableBehaviour_Client(NetworkConnection conn, int behaviourIndex) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7653E0 Offset: 0x763DE0 VA: 0x1807653E0
	public void DisableBehaviour_Server(int behaviourIndex) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x765160 Offset: 0x763B60 VA: 0x180765160
	public void DisableBehaviour_Client(NetworkConnection conn, int behaviourIndex) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x764700 Offset: 0x763100 VA: 0x180764700
	public void ActivateBehaviour_Server(int behaviourIndex) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x764480 Offset: 0x762E80 VA: 0x180764480
	public void ActivateBehaviour_Client(NetworkConnection conn, int behaviourIndex) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x765020 Offset: 0x763A20 VA: 0x180765020
	public void DeactivateBehaviour_Server(int behaviourIndex) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x764DA0 Offset: 0x7637A0 VA: 0x180764DA0
	public void DeactivateBehaviour_Client(NetworkConnection conn, int behaviourIndex) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x766B80 Offset: 0x765580 VA: 0x180766B80
	public void PauseBehaviour_Server(int behaviourIndex) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x766900 Offset: 0x765300 VA: 0x180766900
	public void PauseBehaviour_Client(NetworkConnection conn, int behaviourIndex) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x767100 Offset: 0x765B00 VA: 0x180767100
	public void ResumeBehaviour_Server(int behaviourIndex) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x766E80 Offset: 0x765880 VA: 0x180766E80
	public void ResumeBehaviour_Client(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x76A710 Offset: 0x769110 VA: 0x18076A710
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x76A230 Offset: 0x768C30 VA: 0x18076A230
	private void <OnSpawnServer>g__Replicate|31_0(NetworkConnection conn) { }

	// RVA: 0x765B60 Offset: 0x764560 VA: 0x180765B60 Slot: 25
	public override void NetworkInitialize___Early() { }

	// RVA: 0x765B40 Offset: 0x764540 VA: 0x180765B40 Slot: 26
	public override void NetworkInitialize__Late() { }

	// RVA: 0x703DD0 Offset: 0x7027D0 VA: 0x180703DD0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7691C0 Offset: 0x767BC0 VA: 0x1807691C0
	private void RpcWriter___Server_Summon_900355577(string buildingGUID, int doorIndex, float duration) { }

	// RVA: 0x7675E0 Offset: 0x765FE0 VA: 0x1807675E0
	public void RpcLogic___Summon_900355577(string buildingGUID, int doorIndex, float duration) { }

	// RVA: 0x767F20 Offset: 0x766920 VA: 0x180767F20
	private void RpcReader___Server_Summon_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x764C70 Offset: 0x763670 VA: 0x180764C70
	private void RpcWriter___Server_ConsumeProduct_2622925554(ProductItemInstance product) { }

	// RVA: 0x7672D0 Offset: 0x765CD0 VA: 0x1807672D0
	public void RpcLogic___ConsumeProduct_2622925554(ProductItemInstance product) { }

	// RVA: 0x767C30 Offset: 0x766630 VA: 0x180767C30
	private void RpcReader___Server_ConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x768E00 Offset: 0x767800 VA: 0x180768E00
	private void RpcWriter___Server_EnableBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x7674B0 Offset: 0x765EB0 VA: 0x1807674B0
	public void RpcLogic___EnableBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x767DA0 Offset: 0x7667A0 VA: 0x180767DA0
	private void RpcReader___Server_EnableBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x768650 Offset: 0x767050 VA: 0x180768650
	private void RpcWriter___Observers_EnableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x767430 Offset: 0x765E30 VA: 0x180767430
	public void RpcLogic___EnableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x767A60 Offset: 0x766460 VA: 0x180767A60
	private void RpcReader___Observers_EnableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x769830 Offset: 0x768230 VA: 0x180769830
	private void RpcWriter___Target_EnableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x768110 Offset: 0x766B10 VA: 0x180768110
	private void RpcReader___Target_EnableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x768CC0 Offset: 0x7676C0 VA: 0x180768CC0
	private void RpcWriter___Server_DisableBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x767420 Offset: 0x765E20 VA: 0x180767420
	public void RpcLogic___DisableBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x767D20 Offset: 0x766720 VA: 0x180767D20
	private void RpcReader___Server_DisableBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x768500 Offset: 0x766F00 VA: 0x180768500
	private void RpcWriter___Observers_DisableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x7673A0 Offset: 0x765DA0 VA: 0x1807673A0
	public void RpcLogic___DisableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x7679F0 Offset: 0x7663F0 VA: 0x1807679F0
	private void RpcReader___Observers_DisableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7696C0 Offset: 0x7680C0 VA: 0x1807696C0
	private void RpcWriter___Target_DisableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x7680A0 Offset: 0x766AA0 VA: 0x1807680A0
	private void RpcReader___Target_DisableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x768A40 Offset: 0x767440 VA: 0x180768A40
	private void RpcWriter___Server_ActivateBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x7672C0 Offset: 0x765CC0 VA: 0x1807672C0
	public void RpcLogic___ActivateBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x767BB0 Offset: 0x7665B0 VA: 0x180767BB0
	private void RpcReader___Server_ActivateBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x768260 Offset: 0x766C60 VA: 0x180768260
	private void RpcWriter___Observers_ActivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x767240 Offset: 0x765C40 VA: 0x180767240
	public void RpcLogic___ActivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x767910 Offset: 0x766310 VA: 0x180767910
	private void RpcReader___Observers_ActivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7693E0 Offset: 0x767DE0 VA: 0x1807693E0
	private void RpcWriter___Target_ActivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x767FC0 Offset: 0x7669C0 VA: 0x180767FC0
	private void RpcReader___Target_ActivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x768B80 Offset: 0x767580 VA: 0x180768B80
	private void RpcWriter___Server_DeactivateBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x767390 Offset: 0x765D90 VA: 0x180767390
	public void RpcLogic___DeactivateBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x767CA0 Offset: 0x7666A0 VA: 0x180767CA0
	private void RpcReader___Server_DeactivateBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7683B0 Offset: 0x766DB0 VA: 0x1807683B0
	private void RpcWriter___Observers_DeactivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x767310 Offset: 0x765D10 VA: 0x180767310
	public void RpcLogic___DeactivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x767980 Offset: 0x766380 VA: 0x180767980
	private void RpcReader___Observers_DeactivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x769550 Offset: 0x767F50 VA: 0x180769550
	private void RpcWriter___Target_DeactivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x768030 Offset: 0x766A30 VA: 0x180768030
	private void RpcReader___Target_DeactivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x768F40 Offset: 0x767940 VA: 0x180768F40
	private void RpcWriter___Server_PauseBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x767540 Offset: 0x765F40 VA: 0x180767540
	public void RpcLogic___PauseBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x767E20 Offset: 0x766820 VA: 0x180767E20
	private void RpcReader___Server_PauseBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7687A0 Offset: 0x7671A0 VA: 0x1807687A0
	private void RpcWriter___Observers_PauseBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x7674C0 Offset: 0x765EC0 VA: 0x1807674C0
	public void RpcLogic___PauseBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x767AD0 Offset: 0x7664D0 VA: 0x180767AD0
	private void RpcReader___Observers_PauseBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7699A0 Offset: 0x7683A0 VA: 0x1807699A0
	private void RpcWriter___Target_PauseBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x768180 Offset: 0x766B80 VA: 0x180768180
	private void RpcReader___Target_PauseBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x769080 Offset: 0x767A80 VA: 0x180769080
	private void RpcWriter___Server_ResumeBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x7675D0 Offset: 0x765FD0 VA: 0x1807675D0
	public void RpcLogic___ResumeBehaviour_Server_3316948804(int behaviourIndex) { }

	// RVA: 0x767EA0 Offset: 0x7668A0 VA: 0x180767EA0
	private void RpcReader___Server_ResumeBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7688F0 Offset: 0x7672F0 VA: 0x1807688F0
	private void RpcWriter___Observers_ResumeBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x767550 Offset: 0x765F50 VA: 0x180767550
	public void RpcLogic___ResumeBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x767B40 Offset: 0x766540 VA: 0x180767B40
	private void RpcReader___Observers_ResumeBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x769B10 Offset: 0x768510 VA: 0x180769B10
	private void RpcWriter___Target_ResumeBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex) { }

	// RVA: 0x7681F0 Offset: 0x766BF0 VA: 0x1807681F0
	private void RpcReader___Target_ResumeBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x764A00 Offset: 0x763400 VA: 0x180764A00 Slot: 27
	protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.NPCBehaviour_Assembly-CSharp.dll() { }
}
