public class CartelRegionActivities : NetworkBehaviour // TypeDefIndex: 2091
{
	// Fields
	public const int MIN_COOLDOWN = 12;
	public const int MAX_COOLDOWN = 48;
	public bool TEST_MODE; // 0x118
	[CompilerGenerated]
	private CartelActivity <CurrentActivity>k__BackingField; // 0x120
	[CompilerGenerated]
	private int <HoursUntilNextActivity>k__BackingField; // 0x128
	[Header("Settings")]
	public bool Active; // 0x12C
	public EMapRegion Region; // 0x130
	public List<CartelActivity> Activities; // 0x138
	[Header("References")]
	public CartelAmbushLocation[] AmbushLocations; // 0x140
	public CartelDealer CartelDealer; // 0x148
	private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelRegionActivitiesAssembly-CSharp.dll_Excuted; // 0x150
	private bool NetworkInitialize__LateScheduleOne.Cartel.CartelRegionActivitiesAssembly-CSharp.dll_Excuted; // 0x151

	// Properties
	public CartelActivity CurrentActivity { get; set; }
	public int HoursUntilNextActivity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public CartelActivity get_CurrentActivity() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	private void set_CurrentActivity(CartelActivity value) { }

	[CompilerGenerated]
	// RVA: 0x51D950 Offset: 0x51C350 VA: 0x18051D950
	public int get_HoursUntilNextActivity() { }

	[CompilerGenerated]
	// RVA: 0x618170 Offset: 0x616B70 VA: 0x180618170
	public void set_HoursUntilNextActivity(int value) { }

	// RVA: 0x8083A0 Offset: 0x806DA0 VA: 0x1808083A0 Slot: 16
	protected override void OnValidate() { }

	// RVA: 0x808DE0 Offset: 0x8077E0 VA: 0x180808DE0
	private void Start() { }

	// RVA: 0x8082C0 Offset: 0x806CC0 VA: 0x1808082C0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x808020 Offset: 0x806A20 VA: 0x180808020
	public void HourPass() { }

	// RVA: 0x809100 Offset: 0x807B00 VA: 0x180809100
	private void TryStartActivity() { }

	[Button]
	// RVA: 0x807880 Offset: 0x806280 VA: 0x180807880
	public void ActivateDeal() { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x808B60 Offset: 0x807560 VA: 0x180808B60
	private void StartActivity(NetworkConnection conn, int activityIndex) { }

	// RVA: 0x807890 Offset: 0x806290 VA: 0x180807890
	private void ActivityEnded() { }

	// RVA: 0x807A10 Offset: 0x806410 VA: 0x180807A10
	public CartelRegionalActivityData GetData() { }

	// RVA: 0x808130 Offset: 0x806B30 VA: 0x180808130
	public void Load(CartelRegionalActivityData data) { }

	// RVA: 0x807B00 Offset: 0x806500 VA: 0x180807B00
	public static int GetNewCooldown(EMapRegion region) { }

	// RVA: 0x8079E0 Offset: 0x8063E0 VA: 0x1808079E0
	private void CartelStatusChange(ECartelStatus oldStatus, ECartelStatus newStatus) { }

	// RVA: 0x809310 Offset: 0x807D10 VA: 0x180809310
	public void .ctor() { }

	// RVA: 0x8081F0 Offset: 0x806BF0 VA: 0x1808081F0 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x8081D0 Offset: 0x806BD0 VA: 0x1808081D0 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x8088A0 Offset: 0x8072A0 VA: 0x1808088A0
	private void RpcWriter___Observers_StartActivity_2681120339(NetworkConnection conn, int activityIndex) { }

	// RVA: 0x808440 Offset: 0x806E40 VA: 0x180808440
	private void RpcLogic___StartActivity_2681120339(NetworkConnection conn, int activityIndex) { }

	// RVA: 0x8087C0 Offset: 0x8071C0 VA: 0x1808087C0
	private void RpcReader___Observers_StartActivity_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8089F0 Offset: 0x8073F0 VA: 0x1808089F0
	private void RpcWriter___Target_StartActivity_2681120339(NetworkConnection conn, int activityIndex) { }

	// RVA: 0x808830 Offset: 0x807230 VA: 0x180808830
	private void RpcReader___Target_StartActivity_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
