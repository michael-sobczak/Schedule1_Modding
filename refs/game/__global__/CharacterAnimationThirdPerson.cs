public class CharacterAnimationThirdPerson : CharacterAnimationBase // TypeDefIndex: 14298
{
	// Fields
	public CharacterThirdPerson characterController; // 0x68
	[SerializeField]
	private float turnSensitivity; // 0x70
	[SerializeField]
	private float turnSpeed; // 0x74
	[SerializeField]
	private float runCycleLegOffset; // 0x78
	[Range(0.1, 3)]
	[SerializeField]
	private float animSpeedMultiplier; // 0x7C
	protected Animator animator; // 0x80
	private Vector3 lastForward; // 0x88
	private const string groundedDirectional = "Grounded Directional";
	private const string groundedStrafe = "Grounded Strafe";
	private float deltaAngle; // 0x94
	private float jumpLeg; // 0x98
	private bool lastJump; // 0x9C

	// Properties
	public override bool animationGrounded { get; }

	// Methods

	// RVA: 0x1F51220 Offset: 0x1F4FC20 VA: 0x181F51220 Slot: 6
	protected override void Start() { }

	// RVA: 0x1F50E10 Offset: 0x1F4F810 VA: 0x181F50E10 Slot: 4
	public override Vector3 GetPivotPoint() { }

	// RVA: 0x1F51850 Offset: 0x1F50250 VA: 0x181F51850 Slot: 5
	public override bool get_animationGrounded() { }

	// RVA: 0x1F512C0 Offset: 0x1F4FCC0 VA: 0x181F512C0 Slot: 9
	protected virtual void Update() { }

	// RVA: 0x1F50E50 Offset: 0x1F4F850 VA: 0x181F50E50
	private void OnAnimatorMove() { }

	// RVA: 0x1F51820 Offset: 0x1F50220 VA: 0x181F51820
	public void .ctor() { }
}
