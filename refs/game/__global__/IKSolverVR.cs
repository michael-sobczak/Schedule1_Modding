public class IKSolverVR : IKSolver // TypeDefIndex: 14138
{
	// Fields
	[CompilerGenerated]
	private Animator <animator>k__BackingField; // 0x58
	private Transform[] solverTransforms; // 0x60
	private bool hasChest; // 0x68
	private bool hasNeck; // 0x69
	private bool hasShoulders; // 0x6A
	private bool hasToes; // 0x6B
	private bool hasLegs; // 0x6C
	private bool hasArms; // 0x6D
	private Vector3[] readPositions; // 0x70
	private Quaternion[] readRotations; // 0x78
	private Vector3[] solvedPositions; // 0x80
	private Quaternion[] solvedRotations; // 0x88
	private Quaternion[] defaultLocalRotations; // 0x90
	private Vector3[] defaultLocalPositions; // 0x98
	private Vector3 rootV; // 0xA0
	private Vector3 rootVelocity; // 0xAC
	private Vector3 bodyOffset; // 0xB8
	private int supportLegIndex; // 0xC4
	private int lastLOD; // 0xC8
	private float lastLocomotionWeight; // 0xCC
	[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
	[Range(0, 2)]
	public int LOD; // 0xD0
	[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
	public float scale; // 0xD4
	[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
	public bool plantFeet; // 0xD8
	[CompilerGenerated]
	private IKSolverVR.VirtualBone <rootBone>k__BackingField; // 0xE0
	[Tooltip("The spine solver.")]
	public IKSolverVR.Spine spine; // 0xE8
	[Tooltip("The left arm solver.")]
	public IKSolverVR.Arm leftArm; // 0xF0
	[Tooltip("The right arm solver.")]
	public IKSolverVR.Arm rightArm; // 0xF8
	[Tooltip("The left leg solver.")]
	public IKSolverVR.Leg leftLeg; // 0x100
	[Tooltip("The right leg solver.")]
	public IKSolverVR.Leg rightLeg; // 0x108
	[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
	public IKSolverVR.Locomotion locomotion; // 0x110
	private IKSolverVR.Leg[] legs; // 0x118
	private IKSolverVR.Arm[] arms; // 0x120
	private Vector3 headPosition; // 0x128
	private Vector3 headDeltaPosition; // 0x134
	private Vector3 raycastOriginPelvis; // 0x140
	private Vector3 lastOffset; // 0x14C
	private Vector3 debugPos1; // 0x158
	private Vector3 debugPos2; // 0x164
	private Vector3 debugPos3; // 0x170
	private Vector3 debugPos4; // 0x17C

	// Properties
	public Animator animator { get; set; }
	[HideInInspector]
	public IKSolverVR.VirtualBone rootBone { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Animator get_animator() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_animator(Animator value) { }

	// RVA: 0x1EF95D0 Offset: 0x1EF7FD0 VA: 0x181EF95D0
	public void SetToReferences(VRIK.References references) { }

	// RVA: 0x1EF7CD0 Offset: 0x1EF66D0 VA: 0x181EF7CD0
	public void GuessHandOrientations(VRIK.References references, bool onlyIfZero) { }

	// RVA: 0x1EF69B0 Offset: 0x1EF53B0 VA: 0x181EF69B0
	public void DefaultAnimationCurves() { }

	// RVA: 0x1EF62C0 Offset: 0x1EF4CC0 VA: 0x181EF62C0
	public void AddPositionOffset(IKSolverVR.PositionOffset positionOffset, Vector3 value) { }

	// RVA: 0x1EF6540 Offset: 0x1EF4F40 VA: 0x181EF6540
	public void AddRotationOffset(IKSolverVR.RotationOffset rotationOffset, Vector3 value) { }

	// RVA: 0x1EF65D0 Offset: 0x1EF4FD0 VA: 0x181EF65D0
	public void AddRotationOffset(IKSolverVR.RotationOffset rotationOffset, Quaternion value) { }

	// RVA: 0x1EF6170 Offset: 0x1EF4B70 VA: 0x181EF6170
	public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot) { }

	// RVA: 0x1EF9450 Offset: 0x1EF7E50 VA: 0x181EF9450
	public void Reset() { }

	// RVA: 0x1EFB5C0 Offset: 0x1EF9FC0 VA: 0x181EFB5C0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x1EF6B60 Offset: 0x1EF5560 VA: 0x181EF6B60 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x1EF7AE0 Offset: 0x1EF64E0 VA: 0x181EF7AE0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x1EF7A80 Offset: 0x1EF6480 VA: 0x181EF7A80 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x1EF80F0 Offset: 0x1EF6AF0 VA: 0x181EF80F0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x1EF6D70 Offset: 0x1EF5770 VA: 0x181EF6D70
	private Vector3 GetNormal(Transform[] transforms) { }

	// RVA: 0x1EF7BD0 Offset: 0x1EF65D0 VA: 0x181EF7BD0
	private static Keyframe[] GetSineKeyframes(float mag) { }

	// RVA: 0x1EFB760 Offset: 0x1EFA160 VA: 0x181EFB760
	private void UpdateSolverTransforms() { }

	// RVA: 0x1EF8470 Offset: 0x1EF6E70 VA: 0x181EF8470 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x1EF84D0 Offset: 0x1EF6ED0 VA: 0x181EF84D0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x1EFB8E0 Offset: 0x1EFA2E0 VA: 0x181EFB8E0
	private void WriteTransforms() { }

	// RVA: 0x1EF8B80 Offset: 0x1EF7580 VA: 0x181EF8B80
	private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms) { }

	// RVA: 0x1EF9920 Offset: 0x1EF8320 VA: 0x181EF9920
	private void Solve() { }

	// RVA: 0x1EF7B40 Offset: 0x1EF6540 VA: 0x181EF7B40
	private Vector3 GetPosition(int index) { }

	// RVA: 0x1EF7B90 Offset: 0x1EF6590 VA: 0x181EF7B90
	private Quaternion GetRotation(int index) { }

	[CompilerGenerated]
	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	public IKSolverVR.VirtualBone get_rootBone() { }

	[CompilerGenerated]
	// RVA: 0x4E8E40 Offset: 0x4E7840 VA: 0x1804E8E40
	private void set_rootBone(IKSolverVR.VirtualBone value) { }

	// RVA: 0x1EFBE30 Offset: 0x1EFA830 VA: 0x181EFBE30
	private void Write() { }

	// RVA: 0x1EF7160 Offset: 0x1EF5B60 VA: 0x181EF7160
	private Vector3 GetPelvisOffset(float deltaTime) { }

	// RVA: 0x1EFBFE0 Offset: 0x1EFA9E0 VA: 0x181EFBFE0
	public void .ctor() { }
}
