public class VehiclePursuitBehaviour : Behaviour // TypeDefIndex: 1866
{
	// Fields
	public const float RECENT_VISIBILITY_THRESHOLD = 5;
	public const float EXIT_VEHICLE_MAX_SPEED = 4;
	public const float CLOSE_ENOUGH_THRESHOLD = 10;
	public const float UPDATE_FREQUENCY = 0.2;
	public const float STATIONARY_THRESHOLD = 1;
	public const float TIME_STATIONARY_TO_EXIT = 3;
	[CompilerGenerated]
	private Player <Target>k__BackingField; // 0x168
	[Header("Settings")]
	public AnimationCurve RepathDistanceThresholdMap; // 0x170
	public LandVehicle vehicle; // 0x178
	private bool initialContactMade; // 0x180
	private bool aggressiveDrivingEnabled; // 0x181
	[CompilerGenerated]
	private bool <IsTargetRecentlyVisible>k__BackingField; // 0x182
	[CompilerGenerated]
	private bool <IsTargetImmediatelyVisible>k__BackingField; // 0x183
	private float timeSinceLastSighting; // 0x184
	private bool visionEventReceived; // 0x188
	private int consecutiveVehiclePathingFailures; // 0x18C
	private float timeStationary; // 0x190
	private Vector3 currentDriveTarget; // 0x194
	private int targetChanges; // 0x1A0
	private float timeSincePursuitStart; // 0x1A4
	private bool beginAsSighted; // 0x1A8
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted; // 0x1A9
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted; // 0x1AA

	// Properties
	public Player Target { get; set; }
	public bool IsTargetRecentlyVisible { get; set; }
	public bool IsTargetImmediatelyVisible { get; set; }
	private bool isDriving { get; }
	private VehicleAgent Agent { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public Player get_Target() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	protected void set_Target(Player value) { }

	[CompilerGenerated]
	// RVA: 0x777970 Offset: 0x776370 VA: 0x180777970
	public bool get_IsTargetRecentlyVisible() { }

	[CompilerGenerated]
	// RVA: 0x777A30 Offset: 0x776430 VA: 0x180777A30
	private void set_IsTargetRecentlyVisible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x777960 Offset: 0x776360 VA: 0x180777960
	public bool get_IsTargetImmediatelyVisible() { }

	[CompilerGenerated]
	// RVA: 0x777A20 Offset: 0x776420 VA: 0x180777A20
	private void set_IsTargetImmediatelyVisible(bool value) { }

	// RVA: 0x777980 Offset: 0x776380 VA: 0x180777980
	private bool get_isDriving() { }

	// RVA: 0x774E10 Offset: 0x773810 VA: 0x180774E10
	private VehicleAgent get_Agent() { }

	// RVA: 0x7757C0 Offset: 0x7741C0 VA: 0x1807757C0 Slot: 19
	public override void Awake() { }

	// RVA: 0x7765D0 Offset: 0x774FD0 VA: 0x1807765D0
	private void OnDestroy() { }

	// RVA: 0x775810 Offset: 0x774210 VA: 0x180775810
	public void BeginAsSighted() { }

	// RVA: 0x775430 Offset: 0x773E30 VA: 0x180775430 Slot: 22
	public override void Activate() { }

	// RVA: 0x7769B0 Offset: 0x7753B0 VA: 0x1807769B0 Slot: 25
	public override void Resume() { }

	// RVA: 0x776710 Offset: 0x775110 VA: 0x180776710 Slot: 24
	public override void Pause() { }

	// RVA: 0x775B20 Offset: 0x774520 VA: 0x180775B20 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x7754F0 Offset: 0x773EF0 VA: 0x1807754F0 Slot: 34
	public virtual void AssignTarget(Player target) { }

	// RVA: 0x776D50 Offset: 0x775750 VA: 0x180776D50
	private void StartPursuit() { }

	// RVA: 0x775820 Offset: 0x774220 VA: 0x180775820 Slot: 26
	public override void BehaviourUpdate() { }

	// RVA: 0x776430 Offset: 0x774E30 VA: 0x180776430 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x775F50 Offset: 0x774950 VA: 0x180775F50 Slot: 35
	protected virtual void FixedUpdate() { }

	// RVA: 0x777150 Offset: 0x775B50 VA: 0x180777150
	private void UpdateDestination() { }

	// RVA: 0x7760A0 Offset: 0x774AA0 VA: 0x1807760A0
	private bool IsTargetValid() { }

	// RVA: 0x775870 Offset: 0x774270 VA: 0x180775870
	private void CheckExitVehicle() { }

	// RVA: 0x775F70 Offset: 0x774970 VA: 0x180775F70
	private Vector3 GetPlayerChasePoint() { }

	// RVA: 0x776A80 Offset: 0x775480 VA: 0x180776A80
	private void SetAggressiveDriving(bool aggressive) { }

	// RVA: 0x775E10 Offset: 0x774810 VA: 0x180775E10
	private void DriveTo(Vector3 location) { }

	// RVA: 0x776220 Offset: 0x774C20 VA: 0x180776220
	private void NavigationCallback(VehicleAgent.ENavigationResult status) { }

	// RVA: 0x7745D0 Offset: 0x772FD0 VA: 0x1807745D0
	private bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition) { }

	// RVA: 0x775930 Offset: 0x774330 VA: 0x180775930
	protected void CheckTargetVisibility() { }

	// RVA: 0x7761A0 Offset: 0x774BA0 VA: 0x1807761A0
	public void MarkPlayerVisible() { }

	// RVA: 0x776150 Offset: 0x774B50 VA: 0x180776150
	protected bool IsTargetVisible() { }

	// RVA: 0x776890 Offset: 0x775290 VA: 0x180776890
	private void ProcessVisionEvent(VisionEventReceipt visionEventReceipt) { }

	// RVA: 0x7767E0 Offset: 0x7751E0 VA: 0x1807767E0
	private void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt) { }

	// RVA: 0x777020 Offset: 0x775A20 VA: 0x180777020 Slot: 36
	protected virtual void TargetSpotted() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x776320 Offset: 0x774D20 VA: 0x180776320
	public void NotifyServerTargetSeen() { }

	// RVA: 0x7778F0 Offset: 0x7762F0 VA: 0x1807778F0
	public void .ctor() { }

	// RVA: 0x776290 Offset: 0x774C90 VA: 0x180776290 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x776270 Offset: 0x774C70 VA: 0x180776270 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x776320 Offset: 0x774D20 VA: 0x180776320
	private void RpcWriter___Server_NotifyServerTargetSeen_2166136261() { }

	// RVA: 0x7769D0 Offset: 0x7753D0 VA: 0x1807769D0
	public void RpcLogic___NotifyServerTargetSeen_2166136261() { }

	// RVA: 0x776A20 Offset: 0x775420 VA: 0x180776A20
	private void RpcReader___Server_NotifyServerTargetSeen_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x775520 Offset: 0x773F20 VA: 0x180775520 Slot: 37
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviour_Assembly-CSharp.dll() { }
}
