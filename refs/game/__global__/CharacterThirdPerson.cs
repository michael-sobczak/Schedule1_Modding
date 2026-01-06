public class CharacterThirdPerson : CharacterBase // TypeDefIndex: 14303
{
	// Fields
	[Header("References")]
	public CharacterAnimationBase characterAnimation; // 0x70
	public UserControlThirdPerson userControl; // 0x78
	public CameraController cam; // 0x80
	[Header("Movement")]
	public CharacterThirdPerson.MoveMode moveMode; // 0x88
	public bool smoothPhysics; // 0x8C
	public float smoothAccelerationTime; // 0x90
	public float linearAccelerationSpeed; // 0x94
	public float platformFriction; // 0x98
	public float groundStickyEffect; // 0x9C
	public float maxVerticalVelocityOnGround; // 0xA0
	public float velocityToGroundTangentWeight; // 0xA4
	[Header("Rotation")]
	public bool lookInCameraDirection; // 0xA8
	public float turnSpeed; // 0xAC
	public float stationaryTurnSpeedMlp; // 0xB0
	[Header("Jumping and Falling")]
	public bool smoothJump; // 0xB4
	public float airSpeed; // 0xB8
	public float airControl; // 0xBC
	public float jumpPower; // 0xC0
	public float jumpRepeatDelayTime; // 0xC4
	public bool doubleJumpEnabled; // 0xC8
	public float doubleJumpPowerMlp; // 0xCC
	[Header("Wall Running")]
	public LayerMask wallRunLayers; // 0xD0
	public float wallRunMaxLength; // 0xD4
	public float wallRunMinMoveMag; // 0xD8
	public float wallRunMinVelocityY; // 0xDC
	public float wallRunRotationSpeed; // 0xE0
	public float wallRunMaxRotationAngle; // 0xE4
	public float wallRunWeightSpeed; // 0xE8
	[Header("Crouching")]
	public float crouchCapsuleScaleMlp; // 0xEC
	[CompilerGenerated]
	private bool <fullRootMotion>k__BackingField; // 0xF0
	[CompilerGenerated]
	private bool <onGround>k__BackingField; // 0xF1
	public CharacterThirdPerson.AnimState animState; // 0xF4
	protected Vector3 moveDirection; // 0x10C
	private Animator animator; // 0x118
	private Vector3 normal; // 0x120
	private Vector3 platformVelocity; // 0x12C
	private Vector3 platformAngularVelocity; // 0x138
	private RaycastHit hit; // 0x144
	private float jumpLeg; // 0x170
	private float jumpEndTime; // 0x174
	private float forwardMlp; // 0x178
	private float groundDistance; // 0x17C
	private float lastAirTime; // 0x180
	private float stickyForce; // 0x184
	private Vector3 wallNormal; // 0x188
	private Vector3 moveDirectionVelocity; // 0x194
	private float wallRunWeight; // 0x1A0
	private float lastWallRunWeight; // 0x1A4
	private float fixedDeltaTime; // 0x1A8
	private Vector3 fixedDeltaPosition; // 0x1AC
	private Quaternion fixedDeltaRotation; // 0x1B8
	private bool fixedFrame; // 0x1C8
	private float wallRunEndTime; // 0x1CC
	private Vector3 gravity; // 0x1D0
	private Vector3 verticalVelocity; // 0x1DC
	private float velocityY; // 0x1E8
	private bool doubleJumped; // 0x1EC
	private bool jumpReleased; // 0x1ED

	// Properties
	public bool fullRootMotion { get; set; }
	public bool onGround { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8D1FE0 Offset: 0x8D09E0 VA: 0x1808D1FE0
	public bool get_fullRootMotion() { }

	[CompilerGenerated]
	// RVA: 0xA63CC0 Offset: 0xA626C0 VA: 0x180A63CC0
	public void set_fullRootMotion(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D817D0 Offset: 0x1D801D0 VA: 0x181D817D0
	public bool get_onGround() { }

	[CompilerGenerated]
	// RVA: 0x1F56050 Offset: 0x1F54A50 VA: 0x181F56050
	private void set_onGround(bool value) { }

	// RVA: 0x1F55400 Offset: 0x1F53E00 VA: 0x181F55400 Slot: 5
	protected override void Start() { }

	// RVA: 0x1F54B80 Offset: 0x1F53580 VA: 0x181F54B80
	private void OnAnimatorMove() { }

	// RVA: 0x1F54990 Offset: 0x1F53390 VA: 0x181F54990 Slot: 4
	public override void Move(Vector3 deltaPosition, Quaternion deltaRotation) { }

	// RVA: 0x1F52800 Offset: 0x1F51200 VA: 0x181F52800
	private void FixedUpdate() { }

	// RVA: 0x1F55570 Offset: 0x1F53F70 VA: 0x181F55570 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x1F541C0 Offset: 0x1F52BC0 VA: 0x181F541C0 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x1F542A0 Offset: 0x1F52CA0 VA: 0x181F542A0
	private void MoveFixed(Vector3 deltaPosition) { }

	// RVA: 0x1F55640 Offset: 0x1F54040 VA: 0x181F55640
	private void WallRun() { }

	// RVA: 0x1F52760 Offset: 0x1F51160 VA: 0x181F52760
	private bool CanWallRun() { }

	// RVA: 0x1F53520 Offset: 0x1F51F20 VA: 0x181F53520
	private Vector3 GetMoveDirection() { }

	// RVA: 0x1F54C20 Offset: 0x1F53620 VA: 0x181F54C20 Slot: 9
	protected virtual void Rotate() { }

	// RVA: 0x1F532B0 Offset: 0x1F51CB0 VA: 0x181F532B0
	private Vector3 GetForwardDirection() { }

	// RVA: 0x1F53F50 Offset: 0x1F52950 VA: 0x181F53F50 Slot: 10
	protected virtual bool Jump() { }

	[IteratorStateMachine(typeof(CharacterThirdPerson.<JumpSmooth>d__79))]
	// RVA: 0x1F53EC0 Offset: 0x1F528C0 VA: 0x181F53EC0
	private IEnumerator JumpSmooth(Vector3 jumpVelocity) { }

	// RVA: 0x1F53970 Offset: 0x1F52370 VA: 0x181F53970
	private void GroundCheck() { }

	// RVA: 0x1F55ED0 Offset: 0x1F548D0 VA: 0x181F55ED0
	public void .ctor() { }
}
