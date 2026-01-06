public class Skateboard : NetworkBehaviour // TypeDefIndex: 676
{
	// Fields
	public const float JumpCooldown = 0.3;
	public const float JumpForceMin = 0.5;
	public const float JumpForceBuildTime = 0.5;
	public const float PushCooldown = 1;
	public const float PushStaminaConsumption = 12.5;
	public const float PitchLimit = 60;
	public const float RollLimit = 20;
	[Header("Info - Readonly")]
	public float CurrentSpeed_Kmh; // 0x118
	[CompilerGenerated]
	private float <CurrentSteerInput>k__BackingField; // 0x11C
	[CompilerGenerated]
	[SyncVar(Channel = 1)]
	public float <JumpBuildAmount>k__BackingField; // 0x120
	[CompilerGenerated]
	private Player <Rider>k__BackingField; // 0x128
	[Header("References")]
	public Rigidbody Rb; // 0x130
	public Transform CoM; // 0x138
	public Transform[] HoverPoints; // 0x140
	public Transform FrontAxlePosition; // 0x148
	public Transform RearAxlePosition; // 0x150
	public Transform PlayerContainer; // 0x158
	public SkateboardAnimation Animation; // 0x160
	public SmoothedVelocityCalculator VelocityCalculator; // 0x168
	public AverageAcceleration Accelerometer; // 0x170
	[HideInInspector]
	public Skateboard_Equippable Equippable; // 0x178
	public Transform IKAlignmentsContainer; // 0x180
	[Header("Turn Settings")]
	public float TurnForce; // 0x188
	public float TurnChangeRate; // 0x18C
	public float TurnReturnToRestRate; // 0x190
	public float TurnSpeedBoost; // 0x194
	public AnimationCurve TurnForceMap; // 0x198
	[Header("Settings")]
	public float Gravity; // 0x1A0
	public float BrakeForce; // 0x1A4
	public float ReverseTopSpeed_Kmh; // 0x1A8
	public LayerMask GroundDetectionMask; // 0x1AC
	public Collider[] MainColliders; // 0x1B0
	public float RotationClampForce; // 0x1B8
	public bool SlowOnTerrain; // 0x1BC
	[Header("Friction Settings")]
	public bool FrictionEnabled; // 0x1BD
	public AnimationCurve LongitudinalFrictionCurve; // 0x1C0
	public float LongitudinalFrictionMultiplier; // 0x1C8
	public float LateralFrictionForceMultiplier; // 0x1CC
	[Header("Jump Settings")]
	public float JumpForce; // 0x1D0
	public float JumpDuration_Min; // 0x1D4
	public float JumpDuration_Max; // 0x1D8
	public AnimationCurve FrontAxleJumpCurve; // 0x1E0
	public AnimationCurve RearAxleJumpCurve; // 0x1E8
	public AnimationCurve JumpForwardForceCurve; // 0x1F0
	public float JumpForwardBoost; // 0x1F8
	[Header("Hover Settings")]
	public float HoverForce; // 0x1FC
	public float HoverRayLength; // 0x200
	public float HoverHeight; // 0x204
	public float Hover_P; // 0x208
	public float Hover_I; // 0x20C
	public float Hover_D; // 0x210
	[Header("Pushing Setings")]
	[Tooltip("Top speed in m/s")]
	public float TopSpeed_Kmh; // 0x214
	public float PushForceMultiplier; // 0x218
	public AnimationCurve PushForceMultiplierMap; // 0x220
	public float PushForceDuration; // 0x228
	public float PushDelay; // 0x22C
	public AnimationCurve PushForceCurve; // 0x230
	[Header("Air Movement")]
	public bool AirMovementEnabled; // 0x238
	public float AirMovementForce; // 0x23C
	public float AirMovementJumpReductionDuration; // 0x240
	public AnimationCurve AirMovementJumpReductionCurve; // 0x248
	[Header("Events")]
	public UnityEvent OnPushStart; // 0x250
	public UnityEvent<float> OnJump; // 0x258
	public UnityEvent OnLand; // 0x260
	private float horizontalInput; // 0x268
	private bool jumpReleased; // 0x26C
	private float timeSinceLastJump; // 0x270
	private float timeGrounded; // 0x274
	private float timeAirborne; // 0x278
	private float jumpHeldTime; // 0x27C
	private float frontAxleForce; // 0x280
	private float rearAxleForce; // 0x284
	private float jumpForwardForce; // 0x288
	private List<PID> hoverPIDs; // 0x290
	private bool pushQueued; // 0x298
	private bool isPushing; // 0x299
	private float thisFramePushForce; // 0x29C
	private float timeSincePushStart; // 0x2A0
	private bool braking; // 0x2A4
	public SyncVar<float> syncVar___<JumpBuildAmount>k__BackingField; // 0x2A8
	private bool NetworkInitialize___EarlyScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted; // 0x2B0
	private bool NetworkInitialize__LateScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted; // 0x2B1

	// Properties
	public float CurrentSteerInput { get; set; }
	public bool IsPushing { get; }
	public float TimeSincePushStart { get; }
	public bool isGrounded { get; }
	public float AirTime { get; }
	public float JumpBuildAmount { get; set; }
	public Player Rider { get; set; }
	public float TopSpeed_Ms { get; }
	public float SyncAccessor_<JumpBuildAmount>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5933C0 Offset: 0x591DC0 VA: 0x1805933C0
	public float get_CurrentSteerInput() { }

	[CompilerGenerated]
	// RVA: 0x5933E0 Offset: 0x591DE0 VA: 0x1805933E0
	protected void set_CurrentSteerInput(float value) { }

	// RVA: 0xA141B0 Offset: 0xA12BB0 VA: 0x180A141B0
	public bool get_IsPushing() { }

	// RVA: 0xAC9010 Offset: 0xAC7A10 VA: 0x180AC9010
	public float get_TimeSincePushStart() { }

	// RVA: 0xAC9040 Offset: 0xAC7A40 VA: 0x180AC9040
	public bool get_isGrounded() { }

	// RVA: 0x81F5E0 Offset: 0x81DFE0 VA: 0x18081F5E0
	public float get_AirTime() { }

	[CompilerGenerated]
	// RVA: 0x5AB790 Offset: 0x5AA190 VA: 0x1805AB790
	public float get_JumpBuildAmount() { }

	[ServerRpc]
	[CompilerGenerated]
	// RVA: 0xAC8340 Offset: 0xAC6D40 VA: 0x180AC8340
	public void set_JumpBuildAmount(float value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public Player get_Rider() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	private void set_Rider(Player value) { }

	// RVA: 0xAC9020 Offset: 0xAC7A20 VA: 0x180AC9020
	public float get_TopSpeed_Ms() { }

	// RVA: 0xAC4170 Offset: 0xAC2B70 VA: 0x180AC4170 Slot: 19
	public override void Awake() { }

	// RVA: 0xAC7940 Offset: 0xAC6340 VA: 0x180AC7940 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0xAC8E10 Offset: 0xAC7810 VA: 0x180AC8E10
	public void Update() { }

	// RVA: 0xAC6B90 Offset: 0xAC5590 VA: 0x180AC6B90
	private void GetInput() { }

	// RVA: 0xAC69A0 Offset: 0xAC53A0 VA: 0x180AC69A0
	private void FixedUpdate() { }

	// RVA: 0xAC7690 Offset: 0xAC6090 VA: 0x180AC7690
	private void LateUpdate() { }

	// RVA: 0xAC3090 Offset: 0xAC1A90 VA: 0x180AC3090
	private void ApplyInput() { }

	// RVA: 0xAC3880 Offset: 0xAC2280 VA: 0x180AC3880
	private void ApplyLateralFriction() { }

	// RVA: 0xAC8770 Offset: 0xAC7170 VA: 0x180AC8770
	private void UpdateHover() { }

	// RVA: 0xAC2F50 Offset: 0xAC1950 VA: 0x180AC2F50
	private void ApplyGravity() { }

	// RVA: 0xAC41C0 Offset: 0xAC2BC0 VA: 0x180AC41C0
	private void CheckGrounded() { }

	// RVA: 0xAC4290 Offset: 0xAC2C90 VA: 0x180AC4290
	private void CheckJump() { }

	[ServerRpc(RunLocally = True)]
	// RVA: 0xAC84F0 Offset: 0xAC6EF0 VA: 0x180AC84F0
	private void SendJump(float jumpHeldTime) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0xAC7BF0 Offset: 0xAC65F0 VA: 0x180AC7BF0
	private void ReceiveJump(float _jumpHeldTime) { }

	// RVA: 0xAC7550 Offset: 0xAC5F50 VA: 0x180AC7550
	private void Jump() { }

	// RVA: 0xAC7A10 Offset: 0xAC6410 VA: 0x180AC7A10
	private void Push() { }

	// RVA: 0xAC70C0 Offset: 0xAC5AC0 VA: 0x180AC70C0
	public bool IsGrounded() { }

	// RVA: 0xAC70F0 Offset: 0xAC5AF0 VA: 0x180AC70F0
	public bool IsGrounded(out RaycastHit hit) { }

	// RVA: 0xAC8690 Offset: 0xAC7090 VA: 0x180AC8690
	public void SetVelocity(Vector3 velocity) { }

	// RVA: 0xAC47B0 Offset: 0xAC31B0 VA: 0x180AC47B0
	private void ClampRotation() { }

	// RVA: 0xAC3DD0 Offset: 0xAC27D0 VA: 0x180AC3DD0
	public void ApplyPlayerScale() { }

	// RVA: 0xAC7000 Offset: 0xAC5A00 VA: 0x180AC7000
	public float GetSurfaceSmoothness() { }

	// RVA: 0xAC74A0 Offset: 0xAC5EA0 VA: 0x180AC74A0
	public bool IsOnTerrain() { }

	// RVA: 0xAC8E60 Offset: 0xAC7860 VA: 0x180AC8E60
	public void .ctor() { }

	[IteratorStateMachine(typeof(Skateboard.<<Push>g__Push|113_0>d))]
	[CompilerGenerated]
	// RVA: 0xAC8700 Offset: 0xAC7100 VA: 0x180AC8700
	private IEnumerator <Push>g__Push|113_0() { }

	// RVA: 0xAC7710 Offset: 0xAC6110 VA: 0x180AC7710 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0xAC76C0 Offset: 0xAC60C0 VA: 0x180AC76C0 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xAC8340 Offset: 0xAC6D40 VA: 0x180AC8340
	private void RpcWriter___Server_set_JumpBuildAmount_431000436(float value) { }

	// RVA: 0xAC7DD0 Offset: 0xAC67D0 VA: 0x180AC7DD0
	public void RpcLogic___set_JumpBuildAmount_431000436(float value) { }

	// RVA: 0xAC7F60 Offset: 0xAC6960 VA: 0x180AC7F60
	private void RpcReader___Server_set_JumpBuildAmount_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xAC8190 Offset: 0xAC6B90 VA: 0x180AC8190
	private void RpcWriter___Server_SendJump_431000436(float jumpHeldTime) { }

	// RVA: 0xAC7BF0 Offset: 0xAC65F0 VA: 0x180AC7BF0
	private void RpcLogic___SendJump_431000436(float jumpHeldTime) { }

	// RVA: 0xAC7ED0 Offset: 0xAC68D0 VA: 0x180AC7ED0
	private void RpcReader___Server_SendJump_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xAC8040 Offset: 0xAC6A40 VA: 0x180AC8040
	private void RpcWriter___Observers_ReceiveJump_431000436(float _jumpHeldTime) { }

	// RVA: 0xAC7D30 Offset: 0xAC6730 VA: 0x180AC7D30
	private void RpcLogic___ReceiveJump_431000436(float _jumpHeldTime) { }

	// RVA: 0xAC7E60 Offset: 0xAC6860 VA: 0x180AC7E60
	private void RpcReader___Observers_ReceiveJump_431000436(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5AB790 Offset: 0x5AA190 VA: 0x1805AB790
	public float sync___get_value_<JumpBuildAmount>k__BackingField() { }

	// RVA: 0xAC9060 Offset: 0xAC7A60 VA: 0x180AC9060
	public void sync___set_value_<JumpBuildAmount>k__BackingField(float value, bool asServer) { }

	// RVA: 0xAC7AB0 Offset: 0xAC64B0 VA: 0x180AC7AB0 Slot: 22
	public override bool ReadSyncVar___ScheduleOne.Skating.Skateboard(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0xAC3ED0 Offset: 0xAC28D0 VA: 0x180AC3ED0
	private void Awake_UserLogic_ScheduleOne.Skating.Skateboard_Assembly-CSharp.dll() { }
}
