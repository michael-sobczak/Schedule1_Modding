public class FBIKChain // TypeDefIndex: 14094
{
	// Fields
	[Range(0, 1)]
	public float pin; // 0x10
	[Range(0, 1)]
	public float pull; // 0x14
	[Range(0, 1)]
	public float push; // 0x18
	[Range(-1, 1)]
	public float pushParent; // 0x1C
	[Range(0, 1)]
	public float reach; // 0x20
	public FBIKChain.Smoothing reachSmoothing; // 0x24
	public FBIKChain.Smoothing pushSmoothing; // 0x28
	public IKSolver.Node[] nodes; // 0x30
	public int[] children; // 0x38
	public FBIKChain.ChildConstraint[] childConstraints; // 0x40
	public IKConstraintBend bendConstraint; // 0x48
	private float rootLength; // 0x50
	private bool initiated; // 0x54
	private float length; // 0x58
	private float distance; // 0x5C
	private IKSolver.Point p; // 0x60
	private float reachForce; // 0x68
	private float pullParentSum; // 0x6C
	private float[] crossFades; // 0x70
	private float sqrMag1; // 0x78
	private float sqrMag2; // 0x7C
	private float sqrMagDif; // 0x80
	private const float maxLimbLength = 0.99999;

	// Methods

	// RVA: 0x1EB75E0 Offset: 0x1EB5FE0 VA: 0x181EB75E0
	public void .ctor() { }

	// RVA: 0x1EB7380 Offset: 0x1EB5D80 VA: 0x181EB7380
	public void .ctor(float pin, float pull, Transform[] nodeTransforms) { }

	// RVA: 0x1EB6220 Offset: 0x1EB4C20 VA: 0x181EB6220
	public void SetNodes(Transform[] boneTransforms) { }

	// RVA: 0x1EB5100 Offset: 0x1EB3B00 VA: 0x181EB5100
	public int GetNodeIndex(Transform boneTransform) { }

	// RVA: 0x1EB53A0 Offset: 0x1EB3DA0 VA: 0x181EB53A0
	public bool IsValid(ref string message) { }

	// RVA: 0x1EB51E0 Offset: 0x1EB3BE0 VA: 0x181EB51E0
	public void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x1EB5C20 Offset: 0x1EB4620 VA: 0x181EB5C20
	public void ReadPose(IKSolverFullBody solver, bool fullBody) { }

	// RVA: 0x1EB46E0 Offset: 0x1EB30E0 VA: 0x181EB46E0
	private void CalculateBoneLengths(IKSolverFullBody solver) { }

	// RVA: 0x1EB58B0 Offset: 0x1EB42B0 VA: 0x181EB58B0
	public void Reach(IKSolverFullBody solver) { }

	// RVA: 0x1EB54C0 Offset: 0x1EB3EC0 VA: 0x181EB54C0
	public Vector3 Push(IKSolverFullBody solver) { }

	// RVA: 0x1EB6910 Offset: 0x1EB5310 VA: 0x181EB6910
	public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = False) { }

	// RVA: 0x1EB6C70 Offset: 0x1EB5670 VA: 0x181EB6C70
	public void Stage1(IKSolverFullBody solver) { }

	// RVA: 0x1EB7200 Offset: 0x1EB5C00 VA: 0x181EB7200
	public void Stage2(IKSolverFullBody solver, Vector3 position) { }

	// RVA: 0x1EB63F0 Offset: 0x1EB4DF0 VA: 0x181EB63F0
	public void SolveConstraintSystems(IKSolverFullBody solver) { }

	// RVA: 0x1EB66A0 Offset: 0x1EB50A0 VA: 0x181EB66A0
	private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x1EB4ED0 Offset: 0x1EB38D0 VA: 0x181EB4ED0
	protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude) { }

	// RVA: 0x1EB6360 Offset: 0x1EB4D60 VA: 0x181EB6360
	private void SolveChildConstraints(IKSolverFullBody solver) { }

	// RVA: 0x1EB6760 Offset: 0x1EB5160 VA: 0x181EB6760
	private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance) { }

	// RVA: 0x1EB4D20 Offset: 0x1EB3720 VA: 0x181EB4D20
	public void ForwardReach(Vector3 position) { }

	// RVA: 0x1EB4460 Offset: 0x1EB2E60 VA: 0x181EB4460
	private void BackwardReach(Vector3 position) { }
}
