public class VehicleLights : NetworkBehaviour // TypeDefIndex: 2184
{
	// Fields
	private const int brakeHistoryMaxCount = 60;
	public LandVehicle vehicle; // 0x118
	[Header("Headlights")]
	public bool hasHeadLights; // 0x120
	public MeshRenderer[] headLightMeshes; // 0x128
	public OptimizedLight[] headLightSources; // 0x130
	public Material headlightMat_On; // 0x138
	public Material headLightMat_Off; // 0x140
	[CompilerGenerated]
	[SyncVar(Channel = 1, SendRate = 0.25, WritePermissions = 1)]
	public bool <headLightsOn>k__BackingField; // 0x148
	protected bool headLightsApplied; // 0x149
	[Header("Brake lights")]
	public bool hasBrakeLights; // 0x14A
	public MeshRenderer[] brakeLightMeshes; // 0x150
	public Light[] brakeLightSources; // 0x158
	public Material brakeLightMat_On; // 0x160
	public Material brakeLightMat_Off; // 0x168
	protected bool brakeLightsOn; // 0x170
	protected bool brakeLightsApplied; // 0x171
	[Header("Reverse lights")]
	public bool hasReverseLights; // 0x172
	public MeshRenderer[] reverseLightMeshes; // 0x178
	public Light[] reverseLightSources; // 0x180
	public Material reverseLightMat_On; // 0x188
	public Material reverseLightMat_Off; // 0x190
	protected bool reverseLightsOn; // 0x198
	protected bool reverseLightsApplied; // 0x199
	public UnityEvent onHeadlightsOn; // 0x1A0
	public UnityEvent onHeadlightsOff; // 0x1A8
	private CircularQueue<bool> brakesAppliedHistory; // 0x1B0
	private VehicleAgent agent; // 0x1B8
	public SyncVar<bool> syncVar___<headLightsOn>k__BackingField; // 0x1C0
	private bool NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted; // 0x1C8
	private bool NetworkInitialize__LateScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted; // 0x1C9

	// Properties
	public bool headLightsOn { get; set; }
	public bool SyncAccessor_<headLightsOn>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8391D0 Offset: 0x837BD0 VA: 0x1808391D0
	public bool get_headLightsOn() { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	[CompilerGenerated]
	// RVA: 0x8391E0 Offset: 0x837BE0 VA: 0x1808391E0
	public void set_headLightsOn(bool value) { }

	// RVA: 0x8381E0 Offset: 0x836BE0 VA: 0x1808381E0 Slot: 19
	public override void Awake() { }

	// RVA: 0x838F60 Offset: 0x837960 VA: 0x180838F60 Slot: 20
	protected virtual void Update() { }

	// RVA: 0x838260 Offset: 0x836C60 VA: 0x180838260 Slot: 21
	protected virtual void FixedUpdate() { }

	// RVA: 0x8383F0 Offset: 0x836DF0 VA: 0x1808383F0 Slot: 22
	protected virtual void LateUpdate() { }

	// RVA: 0x839140 Offset: 0x837B40 VA: 0x180839140
	public void .ctor() { }

	// RVA: 0x838A30 Offset: 0x837430 VA: 0x180838A30 Slot: 23
	public override void NetworkInitialize___Early() { }

	// RVA: 0x8389E0 Offset: 0x8373E0 VA: 0x1808389E0 Slot: 24
	public override void NetworkInitialize__Late() { }

	// RVA: 0x66D1D0 Offset: 0x66BBD0 VA: 0x18066D1D0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x838E30 Offset: 0x837830 VA: 0x180838E30
	private void RpcWriter___Server_set_headLightsOn_1140765316(bool value) { }

	// RVA: 0x838D10 Offset: 0x837710 VA: 0x180838D10
	public void RpcLogic___set_headLightsOn_1140765316(bool value) { }

	// RVA: 0x838DA0 Offset: 0x8377A0 VA: 0x180838DA0
	private void RpcReader___Server_set_headLightsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8391D0 Offset: 0x837BD0 VA: 0x1808391D0
	public bool sync___get_value_<headLightsOn>k__BackingField() { }

	// RVA: 0x839310 Offset: 0x837D10 VA: 0x180839310
	public void sync___set_value_<headLightsOn>k__BackingField(bool value, bool asServer) { }

	// RVA: 0x838BD0 Offset: 0x8375D0 VA: 0x180838BD0 Slot: 25
	public override bool ReadSyncVar___ScheduleOne.Vehicles.VehicleLights(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x838190 Offset: 0x836B90 VA: 0x180838190 Slot: 26
	protected virtual void Awake_UserLogic_ScheduleOne.Vehicles.VehicleLights_Assembly-CSharp.dll() { }
}
