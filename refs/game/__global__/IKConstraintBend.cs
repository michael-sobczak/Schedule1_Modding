public class IKConstraintBend // TypeDefIndex: 14095
{
	// Fields
	public Transform bone1; // 0x10
	public Transform bone2; // 0x18
	public Transform bone3; // 0x20
	public Transform bendGoal; // 0x28
	public Vector3 direction; // 0x30
	public Quaternion rotationOffset; // 0x3C
	[Range(0, 1)]
	public float weight; // 0x4C
	public Vector3 defaultLocalDirection; // 0x50
	public Vector3 defaultChildDirection; // 0x5C
	public float clampF; // 0x68
	private int chainIndex1; // 0x6C
	private int nodeIndex1; // 0x70
	private int chainIndex2; // 0x74
	private int nodeIndex2; // 0x78
	private int chainIndex3; // 0x7C
	private int nodeIndex3; // 0x80
	[CompilerGenerated]
	private bool <initiated>k__BackingField; // 0x84
	private bool limbOrientationsSet; // 0x85

	// Properties
	public bool initiated { get; set; }

	// Methods

	// RVA: 0x1ECE5F0 Offset: 0x1ECCFF0 VA: 0x181ECE5F0
	public bool IsValid(IKSolverFullBody solver, Warning.Logger logger) { }

	[CompilerGenerated]
	// RVA: 0x4CD060 Offset: 0x4CBA60 VA: 0x1804CD060
	public bool get_initiated() { }

	[CompilerGenerated]
	// RVA: 0x4CED80 Offset: 0x4CD780 VA: 0x1804CED80
	private void set_initiated(bool value) { }

	// RVA: 0x1ECF580 Offset: 0x1ECDF80 VA: 0x181ECF580
	public void .ctor() { }

	// RVA: 0x1ECF4C0 Offset: 0x1ECDEC0 VA: 0x181ECF4C0
	public void .ctor(Transform bone1, Transform bone2, Transform bone3) { }

	// RVA: 0x1ECF1C0 Offset: 0x1ECDBC0 VA: 0x181ECF1C0
	public void SetBones(Transform bone1, Transform bone2, Transform bone3) { }

	// RVA: 0x1ECE0E0 Offset: 0x1ECCAE0 VA: 0x181ECE0E0
	public void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x1ECF220 Offset: 0x1ECDC20 VA: 0x181ECF220
	public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last) { }

	// RVA: 0x1ECE860 Offset: 0x1ECD260 VA: 0x181ECE860
	public void LimitBend(float solverWeight, float positionWeight) { }

	// RVA: 0x1ECD6D0 Offset: 0x1ECC0D0 VA: 0x181ECD6D0
	public Vector3 GetDir(IKSolverFullBody solver) { }

	// RVA: 0x1ECF080 Offset: 0x1ECDA80 VA: 0x181ECF080
	private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent) { }

	// RVA: 0x1ECEF40 Offset: 0x1ECD940 VA: 0x181ECEF40
	private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent) { }
}
