public class AirConditioner : GridItem // TypeDefIndex: 668
{
	// Fields
	private const float CoolingTemperature = 0;
	private const float HeatingTemperature = 40;
	[CompilerGenerated]
	[SerializeField]
	private TemperatureEmitter <TemperatureEmitter>k__BackingField; // 0x210
	[SerializeField]
	[CompilerGenerated]
	private TemperatureDisplay <TemperatureDisplay>k__BackingField; // 0x218
	[SerializeField]
	private Light _coolingLight; // 0x220
	[SerializeField]
	private Light _heatingLight; // 0x228
	[SerializeField]
	private AudioSourceController _beepSound; // 0x230
	[SerializeField]
	private AudioSourceController _loopSound; // 0x238
	[SerializeField]
	private ParticleSystem _heatParticles; // 0x240
	[SerializeField]
	private ParticleSystem _coolParticles; // 0x248
	[SyncVar(WritePermissions = 1, OnChange = "OnModeChanged")]
	[CompilerGenerated]
	[HideInInspector]
	public AirConditioner.EMode <CurrentMode>k__BackingField; // 0x250
	public SyncVar<AirConditioner.EMode> syncVar___<CurrentMode>k__BackingField; // 0x258
	private bool NetworkInitialize___EarlyScheduleOne.Temperature.AirConditionerAssembly-CSharp.dll_Excuted; // 0x260
	private bool NetworkInitialize__LateScheduleOne.Temperature.AirConditionerAssembly-CSharp.dll_Excuted; // 0x261

	// Properties
	public TemperatureEmitter TemperatureEmitter { get; set; }
	public TemperatureDisplay TemperatureDisplay { get; set; }
	public AirConditioner.EMode CurrentMode { get; set; }
	public AirConditioner.EMode SyncAccessor_<CurrentMode>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public TemperatureEmitter get_TemperatureEmitter() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0
	private void set_TemperatureEmitter(TemperatureEmitter value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public TemperatureDisplay get_TemperatureDisplay() { }

	[CompilerGenerated]
	// RVA: 0x6413A0 Offset: 0x63FDA0 VA: 0x1806413A0
	private void set_TemperatureDisplay(TemperatureDisplay value) { }

	[CompilerGenerated]
	// RVA: 0xAB3760 Offset: 0xAB2160 VA: 0x180AB3760
	public AirConditioner.EMode get_CurrentMode() { }

	[CompilerGenerated]
	// RVA: 0xAB3770 Offset: 0xAB2170 VA: 0x180AB3770
	private void set_CurrentMode(AirConditioner.EMode value) { }

	// RVA: 0xAB2570 Offset: 0xAB0F70 VA: 0x180AB2570 Slot: 47
	public override void Awake() { }

	// RVA: 0xAB29F0 Offset: 0xAB13F0 VA: 0x180AB29F0 Slot: 66
	public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID) { }

	// RVA: 0xAB2940 Offset: 0xAB1340 VA: 0x180AB2940
	private void HeatmapVisibilityChanged(Property property, bool visible) { }

	// RVA: 0xAB25D0 Offset: 0xAB0FD0 VA: 0x180AB25D0 Slot: 56
	protected override void Destroy() { }

	// RVA: 0xAB3750 Offset: 0xAB2150 VA: 0x180AB3750
	private void Update() { }

	// RVA: 0xAB3460 Offset: 0xAB1E60 VA: 0x180AB3460
	private void UpdateLoopSound() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0xAB32E0 Offset: 0xAB1CE0 VA: 0x180AB32E0
	public void SetMode_Server(AirConditioner.EMode mode) { }

	// RVA: 0xAB30F0 Offset: 0xAB1AF0 VA: 0x180AB30F0
	public void SetMode(AirConditioner.EMode mode) { }

	// RVA: 0xAB2110 Offset: 0xAB0B10 VA: 0x180AB2110
	private void ApplyMode() { }

	// RVA: 0xAB2F60 Offset: 0xAB1960 VA: 0x180AB2F60
	private void OnModeChanged(AirConditioner.EMode previous, AirConditioner.EMode current, bool asServer) { }

	[Button]
	// RVA: 0xAB3420 Offset: 0xAB1E20 VA: 0x180AB3420
	public void SetOff() { }

	[Button]
	// RVA: 0xAB32C0 Offset: 0xAB1CC0 VA: 0x180AB32C0
	public void SetCooling() { }

	[Button]
	// RVA: 0xAB32D0 Offset: 0xAB1CD0 VA: 0x180AB32D0
	public void SetHeating() { }

	// RVA: 0xAB2840 Offset: 0xAB1240 VA: 0x180AB2840 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x9CC3C0 Offset: 0x9CADC0 VA: 0x1809CC3C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xAB3430 Offset: 0xAB1E30 VA: 0x180AB3430
	private float <InitializeGridItem>b__22_0() { }

	[CompilerGenerated]
	// RVA: 0xAB3450 Offset: 0xAB1E50 VA: 0x180AB3450
	private bool <InitializeGridItem>b__22_1() { }

	// RVA: 0xAB2D40 Offset: 0xAB1740 VA: 0x180AB2D40 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xAB2CE0 Offset: 0xAB16E0 VA: 0x180AB2CE0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xAB3190 Offset: 0xAB1B90 VA: 0x180AB3190
	private void RpcWriter___Server_SetMode_Server_3835190203(AirConditioner.EMode mode) { }

	// RVA: 0xAB30F0 Offset: 0xAB1AF0 VA: 0x180AB30F0
	public void RpcLogic___SetMode_Server_3835190203(AirConditioner.EMode mode) { }

	// RVA: 0xAB3110 Offset: 0xAB1B10 VA: 0x180AB3110
	private void RpcReader___Server_SetMode_Server_3835190203(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xAB3760 Offset: 0xAB2160 VA: 0x180AB3760
	public AirConditioner.EMode sync___get_value_<CurrentMode>k__BackingField() { }

	// RVA: 0xAB3800 Offset: 0xAB2200 VA: 0x180AB3800
	public void sync___set_value_<CurrentMode>k__BackingField(AirConditioner.EMode value, bool asServer) { }

	// RVA: 0xAB2FD0 Offset: 0xAB19D0 VA: 0x180AB2FD0 Slot: 71
	public override bool ReadSyncVar___ScheduleOne.Temperature.AirConditioner(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0xAB2530 Offset: 0xAB0F30 VA: 0x180AB2530 Slot: 72
	protected override void Awake_UserLogic_ScheduleOne.Temperature.AirConditioner_Assembly-CSharp.dll() { }
}
