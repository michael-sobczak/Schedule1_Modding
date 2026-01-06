public class PlayerMovement : PlayerSingleton<PlayerMovement> // TypeDefIndex: 1355
{
	// Fields
	public const float DevSprintMultiplier = 1;
	public const float WalkSpeed = 3.25;
	public static float StaticMoveSpeedMultiplier; // 0x0
	public const float InputSensitivity = 7;
	public const float InputDeadZone = 0.001;
	public const float SlipperyMovementMultiplier = 0.98;
	public const float GroundedThreshold = 0.05;
	public const float SlopeThreshold = 5;
	public const float SlopeForce = 1;
	public const float SlopeForceRayLength = 1.5;
	public const float ControllerRadius = 0.35;
	public const float DefaultCharacterControllerHeight = 1.85;
	public const float CrouchHeightMultiplier = 0.65;
	public const float CrouchTime = 0.2;
	public const float CrouchSpeedMultipler = 0.6;
	public const float CrouchedVigIntensity = 0.35;
	public const float CrouchedVigSmoothness = 0.7;
	public const bool SprintingRequiresStamina = False;
	public const float SprintChangeRate = 4;
	public const float SprintMultiplier = 1.9;
	public const float StaminaDrainRate = 12.5;
	public const float StaminaRestoreRate = 25;
	public const float StaminaRestoreDelay = 1;
	public static float StaminaReserveMax; // 0x4
	public const float JumpForce = 5.25;
	public static float JumpMultiplier; // 0x8
	public static float GravityMultiplier; // 0xC
	public const float BaseGravityMultiplier = 1.4;
	public const float VerticalLadderSpeedMultiplier = 1.2;
	public const float LateralLadderSpeedMultiplier = 0.5;
	public const float LadderTopBuffer = 0.15;
	public const float LadderPitchAdjustment = 60;
	public const float DismountForce = 7;
	public const float DismountForceDuration = 0.5;
	[Header("References")]
	public Player Player; // 0x20
	public CharacterController Controller; // 0x28
	[Header("Jump/fall settings")]
	[FormerlySerializedAs("groundDetectionMask")]
	public LayerMask GroundDetectionMask; // 0x30
	[CompilerGenerated]
	private bool <CanMove>k__BackingField; // 0x34
	[CompilerGenerated]
	private bool <CanJump>k__BackingField; // 0x35
	[CompilerGenerated]
	private float <MoveSpeedMultiplier>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsJumping>k__BackingField; // 0x3C
	[CompilerGenerated]
	private float <TimeAirborne>k__BackingField; // 0x40
	[CompilerGenerated]
	private float <TimeGrounded>k__BackingField; // 0x44
	[CompilerGenerated]
	private bool <IsGrounded>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsCrouched>k__BackingField; // 0x49
	[CompilerGenerated]
	private float <StandingScale>k__BackingField; // 0x4C
	[CompilerGenerated]
	private bool <IsRagdolled>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <IsSprinting>k__BackingField; // 0x51
	[CompilerGenerated]
	private bool <ForceSprint>k__BackingField; // 0x52
	[CompilerGenerated]
	private float <CurrentStaminaReserve>k__BackingField; // 0x54
	[CompilerGenerated]
	private float <CurrentSprintMultiplier>k__BackingField; // 0x58
	[CompilerGenerated]
	private LandVehicle <CurrentVehicle>k__BackingField; // 0x60
	[CompilerGenerated]
	private Ladder <CurrentLadder>k__BackingField; // 0x68
	public Action<float> onStaminaReserveChanged; // 0x70
	public Action onJump; // 0x78
	public Action onLand; // 0x80
	public Action onCrouch; // 0x88
	public Action onUncrouch; // 0x90
	private Vector3 movement; // 0x98
	private Vector3 lastFrameMovement; // 0xA4
	private float movementY; // 0xB0
	private float timeOnLadderDismount; // 0xB4
	private Vector3 ladderDismountDir; // 0xB8
	private float horizontalAxis; // 0xC4
	private float verticalAxis; // 0xC8
	private Dictionary<int, MotionEvent> movementEvents; // 0xD0
	private float timeSinceStaminaDrain; // 0xD8
	private bool sprintActive; // 0xDC
	private bool sprintReleased; // 0xDD
	private List<string> sprintBlockers; // 0xE0
	private Vector3 residualVelocityDirection; // 0xE8
	private float residualVelocityForce; // 0xF4
	private float residualVelocityDuration; // 0xF8
	private float residualVelocityTimeRemaining; // 0xFC
	private bool teleport; // 0x100
	private Vector3 teleportPosition; // 0x104
	private float playerLadderYPosOnLastClimbSound; // 0x110
	private Coroutine playerRotCoroutine; // 0x118

	// Properties
	public bool CanMove { get; set; }
	public bool CanJump { get; set; }
	public float MoveSpeedMultiplier { get; set; }
	public Vector3 Movement { get; }
	public bool IsJumping { get; set; }
	public float TimeAirborne { get; set; }
	public float TimeGrounded { get; set; }
	public bool IsGrounded { get; set; }
	public bool IsCrouched { get; set; }
	public float StandingScale { get; set; }
	public bool IsRagdolled { get; set; }
	public bool IsSprinting { get; set; }
	public bool ForceSprint { get; set; }
	public float CurrentStaminaReserve { get; set; }
	public float CurrentSprintMultiplier { get; set; }
	public LandVehicle CurrentVehicle { get; set; }
	public Ladder CurrentLadder { get; set; }
	public bool IsOnLadder { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x66AFB0 Offset: 0x6699B0 VA: 0x18066AFB0
	public bool get_CanMove() { }

	[CompilerGenerated]
	// RVA: 0x66B030 Offset: 0x669A30 VA: 0x18066B030
	public void set_CanMove(bool value) { }

	[CompilerGenerated]
	// RVA: 0x660940 Offset: 0x65F340 VA: 0x180660940
	public bool get_CanJump() { }

	[CompilerGenerated]
	// RVA: 0x6604D0 Offset: 0x65EED0 VA: 0x1806604D0
	public void set_CanJump(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_MoveSpeedMultiplier() { }

	[CompilerGenerated]
	// RVA: 0x4E2CD0 Offset: 0x4E16D0 VA: 0x1804E2CD0
	public void set_MoveSpeedMultiplier(float value) { }

	// RVA: 0x66B010 Offset: 0x669A10 VA: 0x18066B010
	public Vector3 get_Movement() { }

	[CompilerGenerated]
	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90
	public bool get_IsJumping() { }

	[CompilerGenerated]
	// RVA: 0x66B060 Offset: 0x669A60 VA: 0x18066B060
	private void set_IsJumping(bool value) { }

	[CompilerGenerated]
	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_TimeAirborne() { }

	[CompilerGenerated]
	// RVA: 0x49D330 Offset: 0x49BD30 VA: 0x18049D330
	private void set_TimeAirborne(float value) { }

	[CompilerGenerated]
	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_TimeGrounded() { }

	[CompilerGenerated]
	// RVA: 0x49D340 Offset: 0x49BD40 VA: 0x18049D340
	private void set_TimeGrounded(float value) { }

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_IsGrounded() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	private void set_IsGrounded(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4D6190 Offset: 0x4D4B90 VA: 0x1804D6190
	public bool get_IsCrouched() { }

	[CompilerGenerated]
	// RVA: 0x4D6510 Offset: 0x4D4F10 VA: 0x1804D6510
	private void set_IsCrouched(bool value) { }

	[CompilerGenerated]
	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float get_StandingScale() { }

	[CompilerGenerated]
	// RVA: 0x66B070 Offset: 0x669A70 VA: 0x18066B070
	private void set_StandingScale(float value) { }

	[CompilerGenerated]
	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_IsRagdolled() { }

	[CompilerGenerated]
	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0
	private void set_IsRagdolled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x50A750 Offset: 0x509150 VA: 0x18050A750
	public bool get_IsSprinting() { }

	[CompilerGenerated]
	// RVA: 0x605240 Offset: 0x603C40 VA: 0x180605240
	private void set_IsSprinting(bool value) { }

	[CompilerGenerated]
	// RVA: 0x605160 Offset: 0x603B60 VA: 0x180605160
	public bool get_ForceSprint() { }

	[CompilerGenerated]
	// RVA: 0x6051E0 Offset: 0x603BE0 VA: 0x1806051E0
	public void set_ForceSprint(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420
	public float get_CurrentStaminaReserve() { }

	[CompilerGenerated]
	// RVA: 0x66B050 Offset: 0x669A50 VA: 0x18066B050
	private void set_CurrentStaminaReserve(float value) { }

	[CompilerGenerated]
	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_CurrentSprintMultiplier() { }

	[CompilerGenerated]
	// RVA: 0x66B040 Offset: 0x669A40 VA: 0x18066B040
	private void set_CurrentSprintMultiplier(float value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public LandVehicle get_CurrentVehicle() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	protected void set_CurrentVehicle(LandVehicle value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Ladder get_CurrentLadder() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_CurrentLadder(Ladder value) { }

	// RVA: 0x66AFC0 Offset: 0x6699C0 VA: 0x18066AFC0
	public bool get_IsOnLadder() { }

	// RVA: 0x666650 Offset: 0x665050 VA: 0x180666650 Slot: 4
	protected override void Awake() { }

	// RVA: 0x669730 Offset: 0x668130 VA: 0x180669730 Slot: 5
	protected override void Start() { }

	// RVA: 0x66A720 Offset: 0x669120 VA: 0x18066A720
	private void Update() { }

	// RVA: 0x666E20 Offset: 0x665820 VA: 0x180666E20
	private void FixedUpdate() { }

	// RVA: 0x667AE0 Offset: 0x6664E0 VA: 0x180667AE0
	private void LateUpdate() { }

	// RVA: 0x667D70 Offset: 0x666770 VA: 0x180667D70
	private void Move() { }

	// RVA: 0x666A20 Offset: 0x665420 VA: 0x180666A20
	private void ClampMovement() { }

	// RVA: 0x666EF0 Offset: 0x6658F0 VA: 0x180666EF0
	private float GetSurfaceAngle() { }

	// RVA: 0x666E90 Offset: 0x665890 VA: 0x180666E90
	private bool GetIsGrounded() { }

	// RVA: 0x6699F0 Offset: 0x6683F0 VA: 0x1806699F0
	public void Teleport(Vector3 position, bool alignFeetToPosition = False) { }

	// RVA: 0x6695E0 Offset: 0x667FE0 VA: 0x1806695E0
	public void SetResidualVelocity(Vector3 dir, float force, float time) { }

	// RVA: 0x66A970 Offset: 0x669370 VA: 0x18066A970
	public void WarpToNavMesh() { }

	// RVA: 0x669F70 Offset: 0x668970 VA: 0x180669F70
	private void UpdateHorizontalAxis() { }

	// RVA: 0x66A530 Offset: 0x668F30 VA: 0x18066A530
	private void UpdateVerticalAxis() { }

	[IteratorStateMachine(typeof(PlayerMovement.<Jump>d__143))]
	// RVA: 0x6670D0 Offset: 0x665AD0 VA: 0x1806670D0
	private IEnumerator Jump() { }

	// RVA: 0x669370 Offset: 0x667D70 VA: 0x180669370
	public void SetCrouched(bool c) { }

	// RVA: 0x669C60 Offset: 0x668660 VA: 0x180669C60
	private void TryToggleCrouch() { }

	// RVA: 0x6666B0 Offset: 0x6650B0 VA: 0x1806666B0
	private bool CanStand() { }

	// RVA: 0x669D90 Offset: 0x668790 VA: 0x180669D90
	private void UpdateCrouchVignetteEffect() { }

	// RVA: 0x66A480 Offset: 0x668E80 VA: 0x18066A480
	private void UpdatePlayerHeight() { }

	// RVA: 0x667C00 Offset: 0x666600 VA: 0x180667C00
	public void LerpPlayerRotation(Quaternion rotation, float lerpTime) { }

	[IteratorStateMachine(typeof(PlayerMovement.<LerpPlayerRotation_Process>d__151))]
	// RVA: 0x667B70 Offset: 0x666570 VA: 0x180667B70
	private IEnumerator LerpPlayerRotation_Process(Quaternion endRotation, float lerpTime) { }

	// RVA: 0x6694B0 Offset: 0x667EB0 VA: 0x1806694B0
	public void SetPlayerRotation(Quaternion rotation) { }

	// RVA: 0x666DA0 Offset: 0x6657A0 VA: 0x180666DA0
	private void EnterVehicle(LandVehicle vehicle) { }

	// RVA: 0x666DE0 Offset: 0x6657E0 VA: 0x180666DE0
	private void ExitVehicle(LandVehicle veh, Transform exitPoint) { }

	// RVA: 0x669100 Offset: 0x667B00 VA: 0x180669100
	public void RegisterMovementEvent(int threshold, Action action) { }

	// RVA: 0x666B30 Offset: 0x665530 VA: 0x180666B30
	public void DeregisterMovementEvent(Action action) { }

	// RVA: 0x66A160 Offset: 0x668B60 VA: 0x18066A160
	private void UpdateMovementEvents() { }

	// RVA: 0x666A00 Offset: 0x665400 VA: 0x180666A00
	public void ChangeStamina(float change, bool notify = True) { }

	// RVA: 0x669660 Offset: 0x668060 VA: 0x180669660
	public void SetStamina(float value, bool notify = True) { }

	// RVA: 0x6665C0 Offset: 0x664FC0 VA: 0x1806665C0
	public void AddSprintBlocker(string tag) { }

	// RVA: 0x6692E0 Offset: 0x667CE0 VA: 0x1806692E0
	public void RemoveSprintBlocker(string tag) { }

	// RVA: 0x667CD0 Offset: 0x6666D0 VA: 0x180667CD0
	public void MountLadder(Ladder ladder) { }

	// RVA: 0x666D20 Offset: 0x665720 VA: 0x180666D20
	public void DismountLadder() { }

	// RVA: 0x667140 Offset: 0x665B40 VA: 0x180667140
	private void LadderMove() { }

	// RVA: 0x669030 Offset: 0x667A30 VA: 0x180669030
	private void PlayLadderClimbSound() { }

	// RVA: 0x66AD30 Offset: 0x669730 VA: 0x18066AD30
	public void .ctor() { }

	// RVA: 0x66ACB0 Offset: 0x6696B0 VA: 0x18066ACB0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x669CB0 Offset: 0x6686B0 VA: 0x180669CB0
	private void <Start>b__130_0() { }
}
