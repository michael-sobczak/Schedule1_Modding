public class CartelActivities : NetworkBehaviour // TypeDefIndex: 2076
{
	// Fields
	public const int MAX_COOLDOWN_HOURS = 24;
	public const int MIN_COOLDOWN_HOURS = 6;
	[CompilerGenerated]
	private CartelActivity <CurrentGlobalActivity>k__BackingField; // 0x118
	[CompilerGenerated]
	private int <HoursUntilNextGlobalActivity>k__BackingField; // 0x120
	[Header("References")]
	public List<CartelActivity> GlobalActivities; // 0x128
	public CartelRegionActivities[] RegionalActivities; // 0x130
	private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelActivitiesAssembly-CSharp.dll_Excuted; // 0x138
	private bool NetworkInitialize__LateScheduleOne.Cartel.CartelActivitiesAssembly-CSharp.dll_Excuted; // 0x139

	// Properties
	public CartelActivity CurrentGlobalActivity { get; set; }
	public int HoursUntilNextGlobalActivity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public CartelActivity get_CurrentGlobalActivity() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	private void set_CurrentGlobalActivity(CartelActivity value) { }

	[CompilerGenerated]
	// RVA: 0x5232D0 Offset: 0x521CD0 VA: 0x1805232D0
	public int get_HoursUntilNextGlobalActivity() { }

	[CompilerGenerated]
	// RVA: 0x618160 Offset: 0x616B60 VA: 0x180618160
	public void set_HoursUntilNextGlobalActivity(int value) { }

	// RVA: 0x7DF8B0 Offset: 0x7DE2B0 VA: 0x1807DF8B0
	private void Start() { }

	// RVA: 0x7DEF50 Offset: 0x7DD950 VA: 0x1807DEF50 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x7DE920 Offset: 0x7DD320 VA: 0x1807DE920
	public CartelRegionActivities GetRegionalActivities(EMapRegion region) { }

	// RVA: 0x7DED80 Offset: 0x7DD780 VA: 0x1807DED80
	private void HourPass() { }

	// RVA: 0x7DFA00 Offset: 0x7DE400 VA: 0x1807DFA00
	private void TryStartActivity() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7DF600 Offset: 0x7DE000 VA: 0x1807DF600
	private void StartGlobalActivity(NetworkConnection conn, EMapRegion region, int activityIndex) { }

	// RVA: 0x7DDE10 Offset: 0x7DC810 VA: 0x1807DDE10
	private void ActivityEnded() { }

	// RVA: 0x7DDF30 Offset: 0x7DC930 VA: 0x1807DDF30
	private bool CanNewActivityBegin() { }

	// RVA: 0x7DE0D0 Offset: 0x7DCAD0 VA: 0x1807DE0D0
	private List<CartelActivity> GetActivitiesReadyToStart() { }

	// RVA: 0x7DEA20 Offset: 0x7DD420 VA: 0x1807DEA20
	private List<EMapRegion> GetValidRegionsForActivity() { }

	// RVA: 0x7DE4D0 Offset: 0x7DCED0 VA: 0x1807DE4D0
	public static int GetNewCooldown() { }

	// RVA: 0x7DE230 Offset: 0x7DCC30 VA: 0x1807DE230
	private static float GetInfluenceFraction() { }

	// RVA: 0x7E0030 Offset: 0x7DEA30 VA: 0x1807E0030
	public void .ctor() { }

	// RVA: 0x7DEE80 Offset: 0x7DD880 VA: 0x1807DEE80 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x64BFE0 Offset: 0x64A9E0 VA: 0x18064BFE0 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7DF320 Offset: 0x7DDD20 VA: 0x1807DF320
	private void RpcWriter___Observers_StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex) { }

	// RVA: 0x7DF040 Offset: 0x7DDA40 VA: 0x1807DF040
	private void RpcLogic___StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex) { }

	// RVA: 0x7DF200 Offset: 0x7DDC00 VA: 0x1807DF200
	private void RpcReader___Observers_StartGlobalActivity_1796582335(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7DF490 Offset: 0x7DDE90 VA: 0x1807DF490
	private void RpcWriter___Target_StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex) { }

	// RVA: 0x7DF290 Offset: 0x7DDC90 VA: 0x1807DF290
	private void RpcReader___Target_StartGlobalActivity_1796582335(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
