public class CheckpointBehaviour : Behaviour // TypeDefIndex: 1775
{
	// Fields
	public const float LOOK_TIME = 1.5;
	[CompilerGenerated]
	private CheckpointManager.ECheckpointLocation <AssignedCheckpoint>k__BackingField; // 0x168
	[CompilerGenerated]
	private RoadCheckpoint <Checkpoint>k__BackingField; // 0x170
	[CompilerGenerated]
	private bool <IsSearching>k__BackingField; // 0x178
	[CompilerGenerated]
	private LandVehicle <CurrentSearchedVehicle>k__BackingField; // 0x180
	[CompilerGenerated]
	private Player <Initiator>k__BackingField; // 0x188
	private float currentLookTime; // 0x190
	private bool trunkOpened; // 0x194
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted; // 0x195
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted; // 0x196

	// Properties
	public CheckpointManager.ECheckpointLocation AssignedCheckpoint { get; set; }
	public RoadCheckpoint Checkpoint { get; set; }
	public bool IsSearching { get; set; }
	public LandVehicle CurrentSearchedVehicle { get; set; }
	public Player Initiator { get; set; }
	private Transform standPoint { get; }
	private DialogueDatabase dialogueDatabase { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x73B350 Offset: 0x739D50 VA: 0x18073B350
	public CheckpointManager.ECheckpointLocation get_AssignedCheckpoint() { }

	[CompilerGenerated]
	// RVA: 0x739E10 Offset: 0x738810 VA: 0x180739E10
	protected void set_AssignedCheckpoint(CheckpointManager.ECheckpointLocation value) { }

	[CompilerGenerated]
	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360
	public RoadCheckpoint get_Checkpoint() { }

	[CompilerGenerated]
	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0
	protected void set_Checkpoint(RoadCheckpoint value) { }

	[CompilerGenerated]
	// RVA: 0x73B390 Offset: 0x739D90 VA: 0x18073B390
	public bool get_IsSearching() { }

	[CompilerGenerated]
	// RVA: 0x73B510 Offset: 0x739F10 VA: 0x18073B510
	protected void set_IsSearching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x73B370 Offset: 0x739D70 VA: 0x18073B370
	public LandVehicle get_CurrentSearchedVehicle() { }

	[CompilerGenerated]
	// RVA: 0x73B4D0 Offset: 0x739ED0 VA: 0x18073B4D0
	protected void set_CurrentSearchedVehicle(LandVehicle value) { }

	[CompilerGenerated]
	// RVA: 0x73B380 Offset: 0x739D80 VA: 0x18073B380
	public Player get_Initiator() { }

	[CompilerGenerated]
	// RVA: 0x73B4F0 Offset: 0x739EF0 VA: 0x18073B4F0
	protected void set_Initiator(Player value) { }

	// RVA: 0x73B3E0 Offset: 0x739DE0 VA: 0x18073B3E0
	private Transform get_standPoint() { }

	// RVA: 0x73B3A0 Offset: 0x739DA0 VA: 0x18073B3A0
	private DialogueDatabase get_dialogueDatabase() { }

	// RVA: 0x737B20 Offset: 0x736520 VA: 0x180737B20 Slot: 22
	public override void Activate() { }

	// RVA: 0x739760 Offset: 0x738160 VA: 0x180739760 Slot: 25
	public override void Resume() { }

	// RVA: 0x737E10 Offset: 0x736810 VA: 0x180737E10 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x738F40 Offset: 0x737940 VA: 0x180738F40 Slot: 24
	public override void Pause() { }

	// RVA: 0x738730 Offset: 0x737130 VA: 0x180738730 Slot: 28
	public override void OnActiveTick() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x73AD10 Offset: 0x739710 VA: 0x18073AD10
	public void SetCheckpoint(CheckpointManager.ECheckpointLocation loc) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x73AE40 Offset: 0x739840 VA: 0x18073AE40
	public void SetInitiator(NetworkObject init) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x73B0F0 Offset: 0x739AF0 VA: 0x18073B0F0
	public void StartSearch(NetworkObject targetVehicle, NetworkObject initiator) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x73B240 Offset: 0x739C40 VA: 0x18073B240
	public void StopSearch() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x73AFB0 Offset: 0x7399B0 VA: 0x18073AFB0
	public void SetIsSearching(bool s) { }

	// RVA: 0x7383D0 Offset: 0x736DD0 VA: 0x1807383D0
	private Vector3 GetSearchPoint() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x737CF0 Offset: 0x7366F0 VA: 0x180737CF0
	private void ConcludeSearch() { }

	// RVA: 0x737FE0 Offset: 0x7369E0 VA: 0x180737FE0
	private bool DoesVehicleContainIllicitItems() { }

	// RVA: 0x739110 Offset: 0x737B10 VA: 0x180739110
	private void PlayerWalkedThroughCheckPoint(Player player) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	// RVA: 0x738530 Offset: 0x736F30 VA: 0x180738530 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x738500 Offset: 0x736F00 VA: 0x180738500 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x73A6E0 Offset: 0x7390E0 VA: 0x18073A6E0
	private void RpcWriter___Observers_SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc) { }

	// RVA: 0x739E10 Offset: 0x738810 VA: 0x180739E10
	public void RpcLogic___SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc) { }

	// RVA: 0x73A340 Offset: 0x738D40 VA: 0x18073A340
	private void RpcReader___Observers_SetCheckpoint_4087078542(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x73A820 Offset: 0x739220 VA: 0x18073A820
	private void RpcWriter___Observers_SetInitiator_3323014238(NetworkObject init) { }

	// RVA: 0x739E20 Offset: 0x738820 VA: 0x180739E20
	public void RpcLogic___SetInitiator_3323014238(NetworkObject init) { }

	// RVA: 0x73A390 Offset: 0x738D90 VA: 0x18073A390
	private void RpcReader___Observers_SetInitiator_3323014238(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x73AAA0 Offset: 0x7394A0 VA: 0x18073AAA0
	private void RpcWriter___Server_StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator) { }

	// RVA: 0x739F40 Offset: 0x738940 VA: 0x180739F40
	public void RpcLogic___StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator) { }

	// RVA: 0x73A4C0 Offset: 0x738EC0 VA: 0x18073A4C0
	private void RpcReader___Server_StartSearch_3694055493(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x73AC00 Offset: 0x739600 VA: 0x18073AC00
	private void RpcWriter___Server_StopSearch_2166136261() { }

	// RVA: 0x73A1D0 Offset: 0x738BD0 VA: 0x18073A1D0
	public void RpcLogic___StopSearch_2166136261() { }

	// RVA: 0x73A570 Offset: 0x738F70 VA: 0x18073A570
	private void RpcReader___Server_StopSearch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x73A960 Offset: 0x739360 VA: 0x18073A960
	private void RpcWriter___Observers_SetIsSearching_1140765316(bool s) { }

	// RVA: 0x739E90 Offset: 0x738890 VA: 0x180739E90
	public void RpcLogic___SetIsSearching_1140765316(bool s) { }

	// RVA: 0x73A440 Offset: 0x738E40 VA: 0x18073A440
	private void RpcReader___Observers_SetIsSearching_1140765316(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x73A5C0 Offset: 0x738FC0 VA: 0x18073A5C0
	private void RpcWriter___Observers_ConcludeSearch_2166136261() { }

	// RVA: 0x739930 Offset: 0x738330 VA: 0x180739930
	private void RpcLogic___ConcludeSearch_2166136261() { }

	// RVA: 0x73A300 Offset: 0x738D00 VA: 0x18073A300
	private void RpcReader___Observers_ConcludeSearch_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
