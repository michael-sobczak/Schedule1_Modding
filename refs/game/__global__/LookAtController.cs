public class LookAtController : MonoBehaviour // TypeDefIndex: 14203
{
	// Fields
	public LookAtIK ik; // 0x20
	[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
	[Header("Target Smoothing")]
	public Transform target; // 0x28
	[Range(0, 1)]
	public float weight; // 0x30
	public Vector3 offset; // 0x34
	[Tooltip("The time it takes to switch targets.")]
	public float targetSwitchSmoothTime; // 0x40
	[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
	public float weightSmoothTime; // 0x44
	[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
	[Header("Turning Towards The Target")]
	public bool smoothTurnTowardsTarget; // 0x48
	[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
	public float maxRadiansDelta; // 0x4C
	[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
	public float maxMagnitudeDelta; // 0x50
	[Tooltip("Speed of slerping towards the target.")]
	public float slerpSpeed; // 0x54
	[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
	public Vector3 pivotOffsetFromRoot; // 0x58
	[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
	public float minDistance; // 0x64
	[Header("RootRotation")]
	[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
	[Range(0, 180)]
	public float maxRootAngle; // 0x68
	private Transform lastTarget; // 0x70
	private float switchWeight; // 0x78
	private float switchWeightV; // 0x7C
	private float weightV; // 0x80
	private Vector3 lastPosition; // 0x84
	private Vector3 dir; // 0x90
	private bool lastSmoothTowardsTarget; // 0x9C

	// Properties
	private Vector3 pivot { get; }

	// Methods

	// RVA: 0x1F24330 Offset: 0x1F22D30 VA: 0x181F24330
	private void Start() { }

	// RVA: 0x1F236B0 Offset: 0x1F220B0 VA: 0x181F236B0
	private void LateUpdate() { }

	// RVA: 0x1F24480 Offset: 0x1F22E80 VA: 0x181F24480
	private Vector3 get_pivot() { }

	// RVA: 0x1F23570 Offset: 0x1F21F70 VA: 0x181F23570
	private void ApplyMinDistance() { }

	// RVA: 0x1F23F90 Offset: 0x1F22990 VA: 0x181F23F90
	private void RootRotation() { }

	// RVA: 0x1F243F0 Offset: 0x1F22DF0 VA: 0x181F243F0
	public void .ctor() { }
}
