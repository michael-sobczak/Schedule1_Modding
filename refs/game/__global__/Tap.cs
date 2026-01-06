public class Tap : NetworkBehaviour, IUsable // TypeDefIndex: 760
{
	// Fields
	private const float FlowRateMultiplier = 6;
	private const float HandleMoveSpeed = 2;
	[SerializeField]
	[CompilerGenerated]
	private Transform <CameraPos>k__BackingField; // 0x118
	[SerializeField]
	[CompilerGenerated]
	private Transform <FillableModelContainer>k__BackingField; // 0x120
	[SerializeField]
	private InteractableObject _interactable; // 0x128
	[SerializeField]
	private Transform _handleTransform; // 0x130
	[SerializeField]
	private Clickable _handleClickable; // 0x138
	[SerializeField]
	private ParticleSystem _waterParticles; // 0x140
	[SerializeField]
	private AudioSourceController _squeakSound; // 0x148
	[SerializeField]
	private AudioSourceController _waterRunningSound; // 0x150
	[SyncVar(WritePermissions = 1)]
	[CompilerGenerated]
	[HideInInspector]
	public bool <IsHeldOpen>k__BackingField; // 0x158
	[HideInInspector]
	[SyncVar(WritePermissions = 1)]
	[CompilerGenerated]
	public NetworkObject <NPCUserObject>k__BackingField; // 0x160
	[SyncVar(WritePermissions = 1)]
	[CompilerGenerated]
	[HideInInspector]
	public NetworkObject <PlayerUserObject>k__BackingField; // 0x168
	private float _normalizedTapFlow; // 0x170
	private Vector2 _defaultParticleStartSize; // 0x174
	private float _maxTapOpenValue; // 0x17C
	public SyncVar<bool> syncVar___<IsHeldOpen>k__BackingField; // 0x180
	public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField; // 0x188
	public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField; // 0x190
	private bool NetworkInitialize___EarlyScheduleOne.Property.TapAssembly-CSharp.dll_Excuted; // 0x198
	private bool NetworkInitialize__LateScheduleOne.Property.TapAssembly-CSharp.dll_Excuted; // 0x199

	// Properties
	public Transform CameraPos { get; set; }
	public Transform FillableModelContainer { get; set; }
	public bool IsHeldOpen { get; set; }
	public float ActualFlowRate { get; }
	public NetworkObject NPCUserObject { get; set; }
	public NetworkObject PlayerUserObject { get; set; }
	public bool SyncAccessor_<IsHeldOpen>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField { get; set; }
	public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public Transform get_CameraPos() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	private void set_CameraPos(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public Transform get_FillableModelContainer() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	private void set_FillableModelContainer(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x5995F0 Offset: 0x597FF0 VA: 0x1805995F0
	public bool get_IsHeldOpen() { }

	[CompilerGenerated]
	// RVA: 0x599660 Offset: 0x598060 VA: 0x180599660
	public void set_IsHeldOpen(bool value) { }

	// RVA: 0x5995B0 Offset: 0x597FB0 VA: 0x1805995B0
	public float get_ActualFlowRate() { }

	[CompilerGenerated]
	// RVA: 0x599600 Offset: 0x598000 VA: 0x180599600 Slot: 21
	public NetworkObject get_NPCUserObject() { }

	[CompilerGenerated]
	// RVA: 0x5996F0 Offset: 0x5980F0 VA: 0x1805996F0 Slot: 22
	public void set_NPCUserObject(NetworkObject value) { }

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610 Slot: 23
	public NetworkObject get_PlayerUserObject() { }

	[CompilerGenerated]
	// RVA: 0x599790 Offset: 0x598190 VA: 0x180599790 Slot: 24
	public void set_PlayerUserObject(NetworkObject value) { }

	// RVA: 0x597990 Offset: 0x596390 VA: 0x180597990 Slot: 29
	public override void Awake() { }

	// RVA: 0x597E60 Offset: 0x596860 VA: 0x180597E60 Slot: 30
	protected virtual void LateUpdate() { }

	// RVA: 0x599370 Offset: 0x597D70 VA: 0x180599370
	private void UpdateTapVisuals() { }

	// RVA: 0x5994F0 Offset: 0x597EF0 VA: 0x1805994F0
	private void UpdateWaterSound() { }

	// RVA: 0x597C50 Offset: 0x596650 VA: 0x180597C50
	private void Hovered() { }

	// RVA: 0x597D30 Offset: 0x596730 VA: 0x180597D30
	private void Interacted() { }

	// RVA: 0x598F60 Offset: 0x597960 VA: 0x180598F60
	public void SetHandleEnabled(bool enabled) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x598F80 Offset: 0x597980 VA: 0x180598F80
	private void SetHeldOpen(bool open) { }

	// RVA: 0x598530 Offset: 0x596F30 VA: 0x180598530
	private void OnHandleClickStart(RaycastHit hit) { }

	// RVA: 0x598520 Offset: 0x596F20 VA: 0x180598520
	private void OnHandleClickEnd() { }

	// RVA: 0x5979E0 Offset: 0x5963E0 VA: 0x1805979E0
	private bool CanInteract(out string invalidReason) { }

	// RVA: 0x5990E0 Offset: 0x597AE0 VA: 0x1805990E0
	public void SetMaxTapOpen(float max) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x599240 Offset: 0x597C40 VA: 0x180599240 Slot: 27
	public void SetPlayerUser(NetworkObject playerObject) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x599110 Offset: 0x597B10 VA: 0x180599110 Slot: 28
	public void SetNPCUser(NetworkObject npcObject) { }

	// RVA: 0x599590 Offset: 0x597F90 VA: 0x180599590
	public void .ctor() { }

	// RVA: 0x5981B0 Offset: 0x596BB0 VA: 0x1805981B0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x598120 Offset: 0x596B20 VA: 0x180598120 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x598BD0 Offset: 0x5975D0 VA: 0x180598BD0
	private void RpcWriter___Server_SetHeldOpen_1140765316(bool open) { }

	// RVA: 0x5986E0 Offset: 0x5970E0 VA: 0x1805986E0
	private void RpcLogic___SetHeldOpen_1140765316(bool open) { }

	// RVA: 0x598A40 Offset: 0x597440 VA: 0x180598A40
	private void RpcReader___Server_SetHeldOpen_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x598E30 Offset: 0x597830 VA: 0x180598E30
	private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0x598830 Offset: 0x597230 VA: 0x180598830 Slot: 33
	public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject) { }

	// RVA: 0x598B50 Offset: 0x597550 VA: 0x180598B50
	private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x598D00 Offset: 0x597700 VA: 0x180598D00
	private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0x598740 Offset: 0x597140 VA: 0x180598740 Slot: 34
	public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject) { }

	// RVA: 0x598AD0 Offset: 0x5974D0 VA: 0x180598AD0
	private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5995F0 Offset: 0x597FF0 VA: 0x1805995F0
	public bool sync___get_value_<IsHeldOpen>k__BackingField() { }

	// RVA: 0x599830 Offset: 0x598230 VA: 0x180599830
	public void sync___set_value_<IsHeldOpen>k__BackingField(bool value, bool asServer) { }

	// RVA: 0x598540 Offset: 0x596F40 VA: 0x180598540 Slot: 35
	public override bool ReadSyncVar___ScheduleOne.Property.Tap(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x599600 Offset: 0x598000 VA: 0x180599600
	public NetworkObject sync___get_value_<NPCUserObject>k__BackingField() { }

	// RVA: 0x5998F0 Offset: 0x5982F0 VA: 0x1805998F0
	public void sync___set_value_<NPCUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public NetworkObject sync___get_value_<PlayerUserObject>k__BackingField() { }

	// RVA: 0x5999B0 Offset: 0x5983B0 VA: 0x1805999B0
	public void sync___set_value_<PlayerUserObject>k__BackingField(NetworkObject value, bool asServer) { }

	// RVA: 0x5976E0 Offset: 0x5960E0 VA: 0x1805976E0
	private void Awake_UserLogic_ScheduleOne.Property.Tap_Assembly-CSharp.dll() { }
}
