public class VehicleAgent : MonoBehaviour // TypeDefIndex: 2234
{
	// Fields
	public const string VehicleGraphName = "General Vehicle Graph";
	public const string RoadGraphName = "Road Nodes";
	public const float MaxDistanceFromPath = 6;
	public const float MaxDistanceFromPathWhenReversing = 8;
	public static Vector3 MainGraphSamplePoint; // 0x0
	public static float MinRenavigationRate; // 0xC
	public const float Steer_P = 40;
	public const float Steer_I = 5;
	public const float Steer_D = 10;
	public const float Throttle_P = 0.08;
	public const float Throttle_I = 0;
	public const float Throttle_D = 0;
	public const float Steer_Rate = 135;
	public const float MaxAxlePositionShift = 3;
	public const float OBSTACLE_MIN_RANGE = 1.5;
	public const float OBSTACLE_MAX_RANGE = 15;
	public const float MAX_STEER_ANGLE_OVERRIDE = 35;
	public const float INFREQUENT_UPDATE_RATE = 0.033;
	public bool DEBUG_MODE; // 0x20
	[CompilerGenerated]
	private bool <AutoDriving>k__BackingField; // 0x21
	[CompilerGenerated]
	private Vector3 <TargetLocation>k__BackingField; // 0x24
	public DriveFlags Flags; // 0x30
	[Header("Seekers")]
	[SerializeField]
	protected Seeker roadSeeker; // 0x38
	[SerializeField]
	protected Seeker generalSeeker; // 0x40
	[SerializeField]
	[Header("References")]
	protected Transform CTE_Origin; // 0x48
	[SerializeField]
	protected Transform FrontAxlePosition; // 0x50
	[SerializeField]
	protected Transform RearAxlePosition; // 0x58
	[SerializeField]
	[Header("Sensors")]
	protected Sensor sensor_FL; // 0x60
	[SerializeField]
	protected Sensor sensor_FM; // 0x68
	[SerializeField]
	protected Sensor sensor_FR; // 0x70
	[SerializeField]
	protected Sensor sensor_RR; // 0x78
	[SerializeField]
	protected Sensor sensor_RL; // 0x80
	private Sensor[] sensors; // 0x88
	[Header("Sweeping")]
	[SerializeField]
	protected LayerMask sweepMask; // 0x90
	[SerializeField]
	protected Transform sweepOrigin_FL; // 0x98
	[SerializeField]
	protected Transform sweepOrigin_FR; // 0xA0
	[SerializeField]
	protected Transform sweepOrigin_RL; // 0xA8
	[SerializeField]
	protected Transform sweepOrigin_RR; // 0xB0
	[SerializeField]
	protected Wheel leftWheel; // 0xB8
	[SerializeField]
	protected Wheel rightWheel; // 0xC0
	protected const float sweepSegment = 15;
	[Header("Path following")]
	protected float sampleStepSizeMin; // 0xC8
	protected float sampleStepSizeMax; // 0xCC
	protected int aheadPointSamples; // 0xD0
	protected const float DestinationDistanceSlowThreshold = 8;
	protected const float DestinationArrivalThreshold = 3;
	[SerializeField]
	[Header("Steer settings")]
	protected float steerTargetFollowRate; // 0xD4
	private SteerPID steerPID; // 0xD8
	[Header("Turning speed reduction")]
	protected float turnSpeedReductionMinRange; // 0xE0
	protected float turnSpeedReductionMaxRange; // 0xE4
	protected float turnSpeedReductionDivisor; // 0xE8
	private float minTurnSpeedReductionAngleThreshold; // 0xEC
	private float minTurningSpeed; // 0xF0
	[Header("Throttle")]
	[SerializeField]
	protected float throttleMin; // 0xF4
	[SerializeField]
	protected float throttleMax; // 0xF8
	private PID throttlePID; // 0x100
	public static float UnmarkedSpeed; // 0x10
	public static float ReverseSpeed; // 0x14
	private ValueTracker speedReductionTracker; // 0x108
	[Header("Pursuit Mode")]
	public bool PursuitModeEnabled; // 0x110
	public Transform PursuitTarget; // 0x118
	public float PursuitDistanceUpdateThreshold; // 0x120
	private Vector3 PursuitTargetLastPosition; // 0x124
	[Header("Stuck Detection")]
	public VehicleTeleporter Teleporter; // 0x130
	public PositionHistoryTracker PositionHistoryTracker; // 0x138
	public float StuckTimeThreshold; // 0x140
	public int StuckSamples; // 0x144
	public float StuckDistanceThreshold; // 0x148
	protected VehicleAgent.NavigationCallback storedNavigationCallback; // 0x150
	protected SpeedZone currentSpeedZone; // 0x158
	protected LandVehicle vehicle; // 0x160
	protected float wheelbase; // 0x168
	protected float wheeltrack; // 0x16C
	protected float vehicleLength; // 0x170
	protected float vehicleWidth; // 0x174
	protected float turnRadius; // 0x178
	protected float sweepTrack; // 0x17C
	private float wheelBottomOffset; // 0x180
	[Header("Control info - READONLY")]
	[SerializeField]
	protected float targetSpeed; // 0x184
	[SerializeField]
	protected float targetSteerAngle_Normalized; // 0x188
	protected float lateralOffset; // 0x18C
	protected PathSmoothingUtility.SmoothedPath path; // 0x190
	private float timeOnLastNavigationCall; // 0x198
	private float sweepTestFailedTime; // 0x19C
	private NavigationSettings currentNavigationSettings; // 0x1A0
	private Coroutine navigationCalculationRoutine; // 0x1A8
	private Coroutine reverseCoroutine; // 0x1B0

	// Properties
	public bool AutoDriving { get; set; }
	public bool KinematicMode { get; }
	public bool IsReversing { get; }
	public Vector3 TargetLocation { get; set; }
	protected float sampleStepSize { get; }
	protected float turnSpeedReductionRange { get; }
	protected float maxSteerAngle { get; }
	private Vector3 frontOfVehiclePosition { get; }
	public bool NavigationCalculationInProgress { get; }
	private float timeSinceLastNavigationCall { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_AutoDriving() { }

	[CompilerGenerated]
	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	protected void set_AutoDriving(bool value) { }

	// RVA: 0x833FC0 Offset: 0x8329C0 VA: 0x180833FC0
	public bool get_KinematicMode() { }

	// RVA: 0x833FB0 Offset: 0x8329B0 VA: 0x180833FB0
	public bool get_IsReversing() { }

	[CompilerGenerated]
	// RVA: 0x4D6370 Offset: 0x4D4D70 VA: 0x1804D6370
	public Vector3 get_TargetLocation() { }

	[CompilerGenerated]
	// RVA: 0x4D6620 Offset: 0x4D5020 VA: 0x1804D6620
	protected void set_TargetLocation(Vector3 value) { }

	// RVA: 0x834110 Offset: 0x832B10 VA: 0x180834110
	protected float get_sampleStepSize() { }

	// RVA: 0x8341C0 Offset: 0x832BC0 VA: 0x1808341C0
	protected float get_turnSpeedReductionRange() { }

	// RVA: 0x8340E0 Offset: 0x832AE0 VA: 0x1808340E0
	protected float get_maxSteerAngle() { }

	// RVA: 0x834000 Offset: 0x832A00 VA: 0x180834000
	private Vector3 get_frontOfVehiclePosition() { }

	// RVA: 0x833FF0 Offset: 0x8329F0 VA: 0x180833FF0
	public bool get_NavigationCalculationInProgress() { }

	// RVA: 0x8341A0 Offset: 0x832BA0 VA: 0x1808341A0
	private float get_timeSinceLastNavigationCall() { }

	// RVA: 0x82C300 Offset: 0x82AD00 VA: 0x18082C300
	private void Awake() { }

	// RVA: 0x830700 Offset: 0x82F100 VA: 0x180830700 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x82F160 Offset: 0x82DB60 VA: 0x18082F160
	private void InitializeVehicleData() { }

	// RVA: 0x82DB20 Offset: 0x82C520 VA: 0x18082DB20 Slot: 5
	protected virtual void FixedUpdate() { }

	// RVA: 0x82EDF0 Offset: 0x82D7F0 VA: 0x18082EDF0
	protected void InfrequentUpdate() { }

	// RVA: 0x82FC00 Offset: 0x82E600 VA: 0x18082FC00
	protected void LateUpdate() { }

	// RVA: 0x8314E0 Offset: 0x82FEE0 VA: 0x1808314E0
	protected void UpdateKinematic(float deltaTime) { }

	// RVA: 0x82DB30 Offset: 0x82C530 VA: 0x18082DB30
	private Vector3 GetAxleGroundHit(bool front) { }

	// RVA: 0x833B00 Offset: 0x832500 VA: 0x180833B00
	private void UpdateSweep() { }

	// RVA: 0x832300 Offset: 0x830D00 VA: 0x180832300
	private void UpdateSpeedReduction() { }

	// RVA: 0x8320F0 Offset: 0x830AF0 VA: 0x1808320F0
	private void UpdatePursuitMode() { }

	// RVA: 0x833790 Offset: 0x832190 VA: 0x180833790
	private void UpdateStuckDetection() { }

	// RVA: 0x82D5E0 Offset: 0x82BFE0 VA: 0x18082D5E0
	private void CheckDistanceFromPath() { }

	// RVA: 0x832010 Offset: 0x830A10 VA: 0x180832010
	private void UpdateOvertaking() { }

	// RVA: 0x830520 Offset: 0x82EF20 VA: 0x180830520 Slot: 6
	protected virtual void RefreshSpeedZone() { }

	// RVA: 0x832C00 Offset: 0x831600 VA: 0x180832C00 Slot: 7
	protected virtual void UpdateSpeed() { }

	// RVA: 0x832D10 Offset: 0x831710 VA: 0x180832D10
	protected void UpdateSteering() { }

	// RVA: 0x82FE20 Offset: 0x82E820 VA: 0x18082FE20
	public void Navigate(Vector3 location, NavigationSettings settings, VehicleAgent.NavigationCallback callback) { }

	// RVA: 0x830420 Offset: 0x82EE20 VA: 0x180830420
	private void NavigationCalculationCallback(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath _path) { }

	// RVA: 0x82D9D0 Offset: 0x82C3D0 VA: 0x18082D9D0
	private void EndDriving() { }

	// RVA: 0x8307C0 Offset: 0x82F1C0 VA: 0x1808307C0
	public void StopNavigating() { }

	// RVA: 0x8304D0 Offset: 0x82EED0 VA: 0x1808304D0
	public void RecalculateNavigation() { }

	// RVA: 0x8308D0 Offset: 0x82F2D0 VA: 0x1808308D0
	public bool SweepTurn(VehicleAgent.ESweepType sweep, float sweepAngle, bool reverse, out float hitDistance, out Vector3 hitPoint, float steerAngle = 0) { }

	// RVA: 0x82C610 Offset: 0x82B010 VA: 0x18082C610
	public void BetterSweepTurn(VehicleAgent.ESweepType sweep, float steerAngle, bool reverse, LayerMask mask, out float hitDistance, out RaycastHit hit) { }

	// RVA: 0x830660 Offset: 0x82F060 VA: 0x180830660
	public void StartReverse() { }

	[IteratorStateMachine(typeof(VehicleAgent.<Reverse>d__139))]
	// RVA: 0x8305F0 Offset: 0x82EFF0 VA: 0x1808305F0
	public IEnumerator Reverse() { }

	// RVA: 0x830820 Offset: 0x82F220 VA: 0x180830820
	private void StopReversing() { }

	// RVA: 0x82E0F0 Offset: 0x82CAF0 VA: 0x18082E0F0
	private Collider GetClosestForwardObstruction(out float obstructionDist) { }

	// RVA: 0x82FBE0 Offset: 0x82E5E0 VA: 0x18082FBE0
	public bool IsOnVehicleGraph() { }

	// RVA: 0x82E580 Offset: 0x82CF80 VA: 0x18082E580
	private float GetDistanceFromVehicleGraph() { }

	// RVA: 0x82EB80 Offset: 0x82D580 VA: 0x18082EB80
	private Vector3 GetPathLateralDirection() { }

	// RVA: 0x82E870 Offset: 0x82D270 VA: 0x18082E870
	public bool GetIsStuck() { }

	// RVA: 0x833E80 Offset: 0x832880 VA: 0x180833E80
	public void .ctor() { }

	// RVA: 0x833DE0 Offset: 0x8327E0 VA: 0x180833DE0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x8314B0 Offset: 0x82FEB0 VA: 0x1808314B0
	private bool <Reverse>b__139_0() { }
}
