public class AimController : MonoBehaviour // TypeDefIndex: 14177
{
	// Fields
	[Tooltip("Reference to the AimIK component.")]
	public AimIK ik; // 0x20
	[Range(0, 1)]
	[Tooltip("Master weight of the IK solver.")]
	public float weight; // 0x28
	[Header("Target Smoothing")]
	[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
	public Transform target; // 0x30
	[Tooltip("The time it takes to switch targets.")]
	public float targetSwitchSmoothTime; // 0x38
	[Tooltip("The time it takes to blend in/out of AimIK weight.")]
	public float weightSmoothTime; // 0x3C
	[Header("Turning Towards The Target")]
	[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
	public bool smoothTurnTowardsTarget; // 0x40
	[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
	public float maxRadiansDelta; // 0x44
	[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
	public float maxMagnitudeDelta; // 0x48
	[Tooltip("Speed of slerping towards the target.")]
	public float slerpSpeed; // 0x4C
	[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
	public float smoothDampTime; // 0x50
	[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
	public Vector3 pivotOffsetFromRoot; // 0x54
	[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
	public float minDistance; // 0x60
	[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
	public Vector3 offset; // 0x64
	[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
	[Range(0, 180)]
	[Header("RootRotation")]
	public float maxRootAngle; // 0x70
	[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
	public bool turnToTarget; // 0x74
	[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
	public float turnToTargetTime; // 0x78
	[Header("Mode")]
	[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
	public bool useAnimatedAimDirection; // 0x7C
	[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
	public Vector3 animatedAimDirection; // 0x80
	private Transform lastTarget; // 0x90
	private float switchWeight; // 0x98
	private float switchWeightV; // 0x9C
	private float weightV; // 0xA0
	private Vector3 lastPosition; // 0xA4
	private Vector3 dir; // 0xB0
	private bool lastSmoothTowardsTarget; // 0xBC
	private bool turningToTarget; // 0xBD
	private float turnToTargetMlp; // 0xC0
	private float turnToTargetMlpV; // 0xC4
	private float yawV; // 0xC8
	private float pitchV; // 0xCC
	private float dirMagV; // 0xD0

	// Properties
	private Vector3 pivot { get; }

	// Methods

	// RVA: 0x1F1AA90 Offset: 0x1F19490 VA: 0x181F1AA90
	private void Start() { }

	// RVA: 0x1F19AE0 Offset: 0x1F184E0 VA: 0x181F19AE0
	private void LateUpdate() { }

	// RVA: 0x1F1ACD0 Offset: 0x1F196D0 VA: 0x181F1ACD0
	private Vector3 get_pivot() { }

	// RVA: 0x1F199A0 Offset: 0x1F183A0 VA: 0x181F199A0
	private void ApplyMinDistance() { }

	// RVA: 0x1F1A6A0 Offset: 0x1F190A0 VA: 0x181F1A6A0
	private void RootRotation() { }

	[IteratorStateMachine(typeof(AimController.<TurnToTarget>d__37))]
	// RVA: 0x1F1AB80 Offset: 0x1F19580 VA: 0x181F1AB80
	private IEnumerator TurnToTarget() { }

	// RVA: 0x1F1ABF0 Offset: 0x1F195F0 VA: 0x181F1ABF0
	public void .ctor() { }
}
