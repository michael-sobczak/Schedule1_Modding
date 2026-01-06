public class RoadCheckpoint : NetworkBehaviour // TypeDefIndex: 2063
{
	// Fields
	public const float MAX_TIME_OPEN = 15;
	[CompilerGenerated]
	private RoadCheckpoint.ECheckpointState <ActivationState>k__BackingField; // 0x118
	protected RoadCheckpoint.ECheckpointState appliedState; // 0x11C
	[CompilerGenerated]
	[SyncVar(SendRate = 0.25)]
	public bool <Gate1Open>k__BackingField; // 0x120
	[CompilerGenerated]
	[SyncVar(SendRate = 0.25)]
	public bool <Gate2Open>k__BackingField; // 0x121
	public List<NPC> AssignedNPCs; // 0x128
	[Header("Settings")]
	public EStealthLevel MaxStealthLevel; // 0x130
	public bool OpenForNPCs; // 0x134
	public bool EnabledOnStart; // 0x135
	[Header("References")]
	[SerializeField]
	protected GameObject container; // 0x138
	public CarStopper Stopper1; // 0x140
	public CarStopper Stopper2; // 0x148
	public VehicleDetector SearchArea1; // 0x150
	public VehicleDetector SearchArea2; // 0x158
	public VehicleObstacle VehicleObstacle1; // 0x160
	public VehicleObstacle VehicleObstacle2; // 0x168
	public VehicleDetector NPCVehicleDetectionArea1; // 0x170
	public VehicleDetector NPCVehicleDetectionArea2; // 0x178
	public VehicleDetector ImmediateVehicleDetector; // 0x180
	public Rigidbody[] TrafficCones; // 0x188
	public Transform[] StandPoints; // 0x190
	protected Dictionary<Rigidbody, Tuple<Vector3, Quaternion>> trafficConeOriginalTransforms; // 0x198
	private float timeSinceGate1Open; // 0x1A0
	private bool vehicleDetectedSinceGate1Open; // 0x1A4
	private float timeSinceGate2Open; // 0x1A8
	private bool vehicleDetectedSinceGate2Open; // 0x1AC
	public UnityEvent<Player> onPlayerWalkThrough; // 0x1B0
	public SyncVar<bool> syncVar___<Gate1Open>k__BackingField; // 0x1B8
	public SyncVar<bool> syncVar___<Gate2Open>k__BackingField; // 0x1C0
	private bool NetworkInitialize___EarlyScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted; // 0x1C8
	private bool NetworkInitialize__LateScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted; // 0x1C9

	// Properties
	public RoadCheckpoint.ECheckpointState ActivationState { get; set; }
	public bool Gate1Open { get; set; }
	public bool Gate2Open { get; set; }
	public bool SyncAccessor_<Gate1Open>k__BackingField { get; set; }
	public bool SyncAccessor_<Gate2Open>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5232B0 Offset: 0x521CB0 VA: 0x1805232B0
	public RoadCheckpoint.ECheckpointState get_ActivationState() { }

	[CompilerGenerated]
	// RVA: 0x7EDA60 Offset: 0x7EC460 VA: 0x1807EDA60
	protected void set_ActivationState(RoadCheckpoint.ECheckpointState value) { }

	[CompilerGenerated]
	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool get_Gate1Open() { }

	[CompilerGenerated]
	// RVA: 0x7ED1A0 Offset: 0x7EBBA0 VA: 0x1807ED1A0
	protected void set_Gate1Open(bool value) { }

	[CompilerGenerated]
	// RVA: 0x60EB50 Offset: 0x60D550 VA: 0x18060EB50
	public bool get_Gate2Open() { }

	[CompilerGenerated]
	// RVA: 0x7ED230 Offset: 0x7EBC30 VA: 0x1807ED230
	protected void set_Gate2Open(bool value) { }

	// RVA: 0x7EC0B0 Offset: 0x7EAAB0 VA: 0x1807EC0B0 Slot: 19
	public override void Awake() { }

	// RVA: 0x7ED500 Offset: 0x7EBF00 VA: 0x1807ED500 Slot: 20
	protected virtual void Update() { }

	// RVA: 0x7EBE10 Offset: 0x7EA810 VA: 0x1807EBE10 Slot: 21
	protected virtual void ApplyState() { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x7EC220 Offset: 0x7EAC20 VA: 0x1807EC220
	public void Enable(NetworkConnection conn) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7EC100 Offset: 0x7EAB00 VA: 0x1807EC100
	public void Disable() { }

	// RVA: 0x7ED1A0 Offset: 0x7EBBA0 VA: 0x1807ED1A0
	public void SetGate1Open(bool o) { }

	// RVA: 0x7ED230 Offset: 0x7EBC30 VA: 0x1807ED230
	public void SetGate2Open(bool o) { }

	// RVA: 0x7EC9D0 Offset: 0x7EB3D0 VA: 0x1807EC9D0
	private void ResetTrafficCones() { }

	// RVA: 0x7EC7C0 Offset: 0x7EB1C0 VA: 0x1807EC7C0
	public void PlayerDetected(Player player) { }

	// RVA: 0x7ED2C0 Offset: 0x7EBCC0 VA: 0x1807ED2C0
	private bool TryGetNearestAssignedNPC(out NPC npc, out float distance) { }

	// RVA: 0x7ED990 Offset: 0x7EC390 VA: 0x1807ED990
	public void .ctor() { }

	// RVA: 0x7EC4F0 Offset: 0x7EAEF0 VA: 0x1807EC4F0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7EC480 Offset: 0x7EAE80 VA: 0x1807EC480 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7ECF60 Offset: 0x7EB960 VA: 0x1807ECF60
	private void RpcWriter___Observers_Enable_328543758(NetworkConnection conn) { }

	// RVA: 0x7ECD60 Offset: 0x7EB760 VA: 0x1807ECD60
	public void RpcLogic___Enable_328543758(NetworkConnection conn) { }

	// RVA: 0x7ECDC0 Offset: 0x7EB7C0 VA: 0x1807ECDC0
	private void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7ED070 Offset: 0x7EBA70 VA: 0x1807ED070
	private void RpcWriter___Target_Enable_328543758(NetworkConnection conn) { }

	// RVA: 0x7ECE00 Offset: 0x7EB800 VA: 0x1807ECE00
	private void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7ECE40 Offset: 0x7EB840 VA: 0x1807ECE40
	private void RpcWriter___Observers_Disable_2166136261() { }

	// RVA: 0x7ECBD0 Offset: 0x7EB5D0 VA: 0x1807ECBD0
	public void RpcLogic___Disable_2166136261() { }

	// RVA: 0x7ECD80 Offset: 0x7EB780 VA: 0x1807ECD80
	private void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool sync___get_value_<Gate1Open>k__BackingField() { }

	// RVA: 0x7EDA70 Offset: 0x7EC470 VA: 0x1807EDA70
	public void sync___set_value_<Gate1Open>k__BackingField(bool value, bool asServer) { }

	// RVA: 0x7EC820 Offset: 0x7EB220 VA: 0x1807EC820 Slot: 24
	public override bool ReadSyncVar___ScheduleOne.Police.RoadCheckpoint(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x60EB50 Offset: 0x60D550 VA: 0x18060EB50
	public bool sync___get_value_<Gate2Open>k__BackingField() { }

	// RVA: 0x7EDB30 Offset: 0x7EC530 VA: 0x1807EDB30
	public void sync___set_value_<Gate2Open>k__BackingField(bool value, bool asServer) { }

	// RVA: 0x7EBE50 Offset: 0x7EA850 VA: 0x1807EBE50 Slot: 25
	protected virtual void Awake_UserLogic_ScheduleOne.Police.RoadCheckpoint_Assembly-CSharp.dll() { }
}
