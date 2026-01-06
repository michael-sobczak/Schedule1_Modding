public class GrounderQuadruped : Grounder // TypeDefIndex: 14066
{
	// Fields
	[Tooltip("The Grounding solver for the forelegs.")]
	public Grounding forelegSolver; // 0x50
	[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
	[Range(0, 1)]
	public float rootRotationWeight; // 0x58
	[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
	[Range(-90, 0)]
	public float minRootRotation; // 0x5C
	[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
	[Range(0, 90)]
	public float maxRootRotation; // 0x60
	[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
	public float rootRotationSpeed; // 0x64
	[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
	public float maxLegOffset; // 0x68
	[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
	public float maxForeLegOffset; // 0x6C
	[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
	[Range(0, 1)]
	public float maintainHeadRotationWeight; // 0x70
	[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
	public Transform characterRoot; // 0x78
	[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
	public Transform pelvis; // 0x80
	[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
	public Transform lastSpineBone; // 0x88
	[Tooltip("The head (optional, if you intend to maintain its rotation).")]
	public Transform head; // 0x90
	public IK[] legs; // 0x98
	public IK[] forelegs; // 0xA0
	[HideInInspector]
	public Vector3 gravity; // 0xA8
	private GrounderQuadruped.Foot[] feet; // 0xB8
	private Vector3 animatedPelvisLocalPosition; // 0xC0
	private Quaternion animatedPelvisLocalRotation; // 0xCC
	private Quaternion animatedHeadLocalRotation; // 0xDC
	private Vector3 solvedPelvisLocalPosition; // 0xEC
	private Quaternion solvedPelvisLocalRotation; // 0xF8
	private Quaternion solvedHeadLocalRotation; // 0x108
	private int solvedFeet; // 0x118
	private bool solved; // 0x11C
	private float angle; // 0x120
	private Transform forefeetRoot; // 0x128
	private Quaternion headRotation; // 0x130
	private float lastWeight; // 0x140
	private Rigidbody characterRootRigidbody; // 0x148

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1EC11B0 Offset: 0x1EBFBB0 VA: 0x181EC11B0 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1EC1150 Offset: 0x1EBFB50 VA: 0x181EC1150 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x1EC1210 Offset: 0x1EBFC10 VA: 0x181EC1210 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x1EBFF50 Offset: 0x1EBE950 VA: 0x181EBFF50
	private bool IsReadyToInitiate() { }

	// RVA: 0x1EBFD80 Offset: 0x1EBE780 VA: 0x181EBFD80
	private bool IsReadyToInitiateLegs(IK[] ikComponents) { }

	// RVA: 0x1EC01D0 Offset: 0x1EBEBD0 VA: 0x181EC01D0
	private void OnDisable() { }

	// RVA: 0x1EC2090 Offset: 0x1EC0A90 VA: 0x181EC2090
	private void Update() { }

	// RVA: 0x1EBF940 Offset: 0x1EBE340 VA: 0x181EBF940
	private void Initiate() { }

	// RVA: 0x1EBF4C0 Offset: 0x1EBDEC0 VA: 0x181EBF4C0
	private Transform[] InitiateFeet(IK[] ikComponents, ref GrounderQuadruped.Foot[] f, int indexOffset) { }

	// RVA: 0x1EC0080 Offset: 0x1EBEA80 VA: 0x181EC0080
	private void LateUpdate() { }

	// RVA: 0x1EC1450 Offset: 0x1EBFE50 VA: 0x181EC1450
	private void RootRotation() { }

	// RVA: 0x1EC06F0 Offset: 0x1EBF0F0 VA: 0x181EC06F0
	private void OnSolverUpdate() { }

	// RVA: 0x1EC1D80 Offset: 0x1EC0780 VA: 0x181EC1D80
	private void UpdateForefeetRoot() { }

	// RVA: 0x1EC1BF0 Offset: 0x1EC05F0 VA: 0x181EC1BF0
	private void SetFootIK(GrounderQuadruped.Foot foot, float maxOffset) { }

	// RVA: 0x1EC0250 Offset: 0x1EBEC50 VA: 0x181EC0250
	private void OnPostSolverUpdate() { }

	// RVA: 0x1EC0190 Offset: 0x1EBEB90 VA: 0x181EC0190
	private void OnDestroy() { }

	// RVA: 0x1EBF240 Offset: 0x1EBDC40 VA: 0x181EBF240
	private void DestroyLegs(IK[] ikComponents) { }

	// RVA: 0x1EC2200 Offset: 0x1EC0C00 VA: 0x181EC2200
	public void .ctor() { }
}
