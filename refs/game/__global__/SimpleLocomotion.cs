public class SimpleLocomotion : MonoBehaviour // TypeDefIndex: 14305
{
	// Fields
	[Tooltip("The component that updates the camera.")]
	public CameraController cameraController; // 0x20
	[Tooltip("Acceleration of movement.")]
	public float accelerationTime; // 0x28
	[Tooltip("Turning speed.")]
	public float turnTime; // 0x2C
	[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
	public bool walkByDefault; // 0x30
	[Tooltip("Smooth or linear rotation.")]
	public SimpleLocomotion.RotationMode rotationMode; // 0x34
	[Tooltip("Procedural motion speed (if not using root motion).")]
	public float moveSpeed; // 0x38
	[CompilerGenerated]
	private bool <isGrounded>k__BackingField; // 0x3C
	private Animator animator; // 0x40
	private float speed; // 0x48
	private float angleVel; // 0x4C
	private float speedVel; // 0x50
	private Vector3 linearTargetDirection; // 0x54
	private CharacterController characterController; // 0x60

	// Properties
	public bool isGrounded { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90
	public bool get_isGrounded() { }

	[CompilerGenerated]
	// RVA: 0x66B060 Offset: 0x669A60 VA: 0x18066B060
	private void set_isGrounded(bool value) { }

	// RVA: 0x1F57670 Offset: 0x1F56070 VA: 0x181F57670
	private void Start() { }

	// RVA: 0x1F57700 Offset: 0x1F56100 VA: 0x181F57700
	private void Update() { }

	// RVA: 0x1F56E20 Offset: 0x1F55820 VA: 0x181F56E20
	private void LateUpdate() { }

	// RVA: 0x1F57180 Offset: 0x1F55B80 VA: 0x181F57180
	private void Rotate() { }

	// RVA: 0x1F56E60 Offset: 0x1F55860 VA: 0x181F56E60
	private void Move() { }

	// RVA: 0x1F56D70 Offset: 0x1F55770 VA: 0x181F56D70
	private Vector3 GetInputVector() { }

	// RVA: 0x1F56CF0 Offset: 0x1F556F0 VA: 0x181F56CF0
	private Vector3 GetInputVectorRaw() { }

	// RVA: 0x1F57760 Offset: 0x1F56160 VA: 0x181F57760
	public void .ctor() { }
}
