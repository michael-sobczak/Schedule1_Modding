public class Forklift : LandVehicle // TypeDefIndex: 2165
{
	// Fields
	[Header("Forklift References")]
	[SerializeField]
	protected Transform steeringWheel; // 0x328
	[SerializeField]
	protected Rigidbody forkRb; // 0x330
	[SerializeField]
	protected ConfigurableJoint joint; // 0x338
	[Header("Forklift settings")]
	[SerializeField]
	protected float steeringWheelAngleMultiplier; // 0x340
	[SerializeField]
	protected float lift_MinY; // 0x344
	[SerializeField]
	protected float lift_MaxY; // 0x348
	[SerializeField]
	protected float liftMoveRate; // 0x34C
	[SyncVar(Channel = 1)]
	[CompilerGenerated]
	public float <targetForkHeight>k__BackingField; // 0x350
	private float lastFrameTargetForkHeight; // 0x354
	[CompilerGenerated]
	[SyncVar(SendRate = 0.04, Channel = 1)]
	public float <actualForkHeight>k__BackingField; // 0x358
	public SyncVar<float> syncVar___<targetForkHeight>k__BackingField; // 0x360
	public SyncVar<float> syncVar___<actualForkHeight>k__BackingField; // 0x368
	private bool NetworkInitialize___EarlyScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted; // 0x370
	private bool NetworkInitialize__LateScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted; // 0x371

	// Properties
	public float targetForkHeight { get; set; }
	public float actualForkHeight { get; set; }
	public float SyncAccessor_<targetForkHeight>k__BackingField { get; set; }
	public float SyncAccessor_<actualForkHeight>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x813200 Offset: 0x811C00 VA: 0x180813200
	public float get_targetForkHeight() { }

	[ServerRpc(RunLocally = True)]
	[CompilerGenerated]
	// RVA: 0x8133B0 Offset: 0x811DB0 VA: 0x1808133B0
	protected void set_targetForkHeight(float value) { }

	[CompilerGenerated]
	// RVA: 0x6E61E0 Offset: 0x6E4BE0 VA: 0x1806E61E0
	public float get_actualForkHeight() { }

	[ServerRpc(RunLocally = True)]
	[CompilerGenerated]
	// RVA: 0x813210 Offset: 0x811C10 VA: 0x180813210
	protected void set_actualForkHeight(float value) { }

	// RVA: 0x811EA0 Offset: 0x8108A0 VA: 0x180811EA0 Slot: 45
	public override void Awake() { }

	// RVA: 0x812F80 Offset: 0x811980 VA: 0x180812F80 Slot: 49
	protected override void Update() { }

	// RVA: 0x812030 Offset: 0x810A30 VA: 0x180812030 Slot: 50
	protected override void FixedUpdate() { }

	// RVA: 0x8122A0 Offset: 0x810CA0 VA: 0x1808122A0 Slot: 69
	protected virtual void LateUpdate() { }

	// RVA: 0x8131E0 Offset: 0x811BE0 VA: 0x1808131E0
	public void .ctor() { }

	// RVA: 0x8125D0 Offset: 0x810FD0 VA: 0x1808125D0 Slot: 62
	public override void NetworkInitialize___Early() { }

	// RVA: 0x8124F0 Offset: 0x810EF0 VA: 0x1808124F0 Slot: 63
	public override void NetworkInitialize__Late() { }

	// RVA: 0x8124B0 Offset: 0x810EB0 VA: 0x1808124B0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x812DD0 Offset: 0x8117D0 VA: 0x180812DD0
	private void RpcWriter___Server_set_targetForkHeight_431000436(float value) { }

	// RVA: 0x812A70 Offset: 0x811470 VA: 0x180812A70
	protected void RpcLogic___set_targetForkHeight_431000436(float value) { }

	// RVA: 0x812B90 Offset: 0x811590 VA: 0x180812B90
	private void RpcReader___Server_set_targetForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x812C20 Offset: 0x811620 VA: 0x180812C20
	private void RpcWriter___Server_set_actualForkHeight_431000436(float value) { }

	// RVA: 0x8129E0 Offset: 0x8113E0 VA: 0x1808129E0
	protected void RpcLogic___set_actualForkHeight_431000436(float value) { }

	// RVA: 0x812B00 Offset: 0x811500 VA: 0x180812B00
	private void RpcReader___Server_set_actualForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x813200 Offset: 0x811C00 VA: 0x180813200
	public float sync___get_value_<targetForkHeight>k__BackingField() { }

	// RVA: 0x813610 Offset: 0x812010 VA: 0x180813610
	public void sync___set_value_<targetForkHeight>k__BackingField(float value, bool asServer) { }

	// RVA: 0x812860 Offset: 0x811260 VA: 0x180812860 Slot: 70
	public override bool ReadSyncVar___ScheduleOne.Vehicles.Forklift(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x6E61E0 Offset: 0x6E4BE0 VA: 0x1806E61E0
	public float sync___get_value_<actualForkHeight>k__BackingField() { }

	// RVA: 0x813550 Offset: 0x811F50 VA: 0x180813550
	public void sync___set_value_<actualForkHeight>k__BackingField(float value, bool asServer) { }

	// RVA: 0x811D40 Offset: 0x810740 VA: 0x180811D40 Slot: 71
	protected override void Awake_UserLogic_ScheduleOne.Vehicles.Forklift_Assembly-CSharp.dll() { }
}
