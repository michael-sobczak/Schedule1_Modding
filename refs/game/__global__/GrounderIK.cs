public class GrounderIK : Grounder // TypeDefIndex: 14064
{
	// Fields
	public IK[] legs; // 0x50
	[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
	public Transform pelvis; // 0x58
	[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
	public Transform characterRoot; // 0x60
	[Range(0, 1)]
	[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
	public float rootRotationWeight; // 0x68
	[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
	public float rootRotationSpeed; // 0x6C
	[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
	public float maxRootRotationAngle; // 0x70
	private Transform[] feet; // 0x78
	private Quaternion[] footRotations; // 0x80
	private Vector3 animatedPelvisLocalPosition; // 0x88
	private Vector3 solvedPelvisLocalPosition; // 0x94
	private int solvedFeet; // 0xA0
	private bool solved; // 0xA4
	private float lastWeight; // 0xA8
	private Rigidbody characterRootRigidbody; // 0xB0

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1EBE270 Offset: 0x1EBCC70 VA: 0x181EBE270 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1EBE210 Offset: 0x1EBCC10 VA: 0x181EBE210 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x1EBE2D0 Offset: 0x1EBCCD0 VA: 0x181EBE2D0 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x1EBD550 Offset: 0x1EBBF50 VA: 0x181EBD550
	private bool IsReadyToInitiate() { }

	// RVA: 0x1EBD9E0 Offset: 0x1EBC3E0 VA: 0x181EBD9E0
	private void OnDisable() { }

	// RVA: 0x1EBEAB0 Offset: 0x1EBD4B0 VA: 0x181EBEAB0
	private void Update() { }

	// RVA: 0x1EBCF90 Offset: 0x1EBB990 VA: 0x181EBCF90
	private void Initiate() { }

	// RVA: 0x1EBDE90 Offset: 0x1EBC890 VA: 0x181EBDE90
	private void OnSolverUpdate() { }

	// RVA: 0x1EBE5B0 Offset: 0x1EBCFB0 VA: 0x181EBE5B0
	private void SetLegIK(int index) { }

	// RVA: 0x1EBDB00 Offset: 0x1EBC500 VA: 0x181EBDB00
	private void OnPostSolverUpdate() { }

	// RVA: 0x1EBD750 Offset: 0x1EBC150 VA: 0x181EBD750
	private void OnDestroy() { }

	// RVA: 0x1EBF150 Offset: 0x1EBDB50 VA: 0x181EBF150
	public void .ctor() { }
}
