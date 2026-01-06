public class IKEffector // TypeDefIndex: 14096
{
	// Fields
	public Transform bone; // 0x10
	public Transform target; // 0x18
	[Range(0, 1)]
	public float positionWeight; // 0x20
	[Range(0, 1)]
	public float rotationWeight; // 0x24
	public Vector3 position; // 0x28
	public Quaternion rotation; // 0x34
	public Vector3 positionOffset; // 0x44
	[CompilerGenerated]
	private bool <isEndEffector>k__BackingField; // 0x50
	public bool effectChildNodes; // 0x51
	[Range(0, 1)]
	public float maintainRelativePositionWeight; // 0x54
	public Transform[] childBones; // 0x58
	public Transform planeBone1; // 0x60
	public Transform planeBone2; // 0x68
	public Transform planeBone3; // 0x70
	public Quaternion planeRotationOffset; // 0x78
	private float posW; // 0x88
	private float rotW; // 0x8C
	private Vector3[] localPositions; // 0x90
	private bool usePlaneNodes; // 0x98
	private Quaternion animatedPlaneRotation; // 0x9C
	private Vector3 animatedPosition; // 0xAC
	private bool firstUpdate; // 0xB8
	private int chainIndex; // 0xBC
	private int nodeIndex; // 0xC0
	private int plane1ChainIndex; // 0xC4
	private int plane1NodeIndex; // 0xC8
	private int plane2ChainIndex; // 0xCC
	private int plane2NodeIndex; // 0xD0
	private int plane3ChainIndex; // 0xD4
	private int plane3NodeIndex; // 0xD8
	private int[] childChainIndexes; // 0xE0
	private int[] childNodeIndexes; // 0xE8

	// Properties
	public bool isEndEffector { get; set; }

	// Methods

	// RVA: 0x1ECF5E0 Offset: 0x1ECDFE0 VA: 0x181ECF5E0
	public IKSolver.Node GetNode(IKSolverFullBody solver) { }

	[CompilerGenerated]
	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_isEndEffector() { }

	[CompilerGenerated]
	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0
	private void set_isEndEffector(bool value) { }

	// RVA: 0x1ED0EB0 Offset: 0x1ECF8B0 VA: 0x181ED0EB0
	public void PinToBone(float positionWeight, float rotationWeight) { }

	// RVA: 0x1ED1620 Offset: 0x1ED0020 VA: 0x181ED1620
	public void .ctor() { }

	// RVA: 0x1ED1800 Offset: 0x1ED0200 VA: 0x181ED1800
	public void .ctor(Transform bone, Transform[] childBones) { }

	// RVA: 0x1ED0360 Offset: 0x1ECED60 VA: 0x181ED0360
	public bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x1ECFF00 Offset: 0x1ECE900 VA: 0x181ECFF00
	public void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x1ED0F80 Offset: 0x1ECF980 VA: 0x181ED0F80
	public void ResetOffset(IKSolverFullBody solver) { }

	// RVA: 0x1ED1150 Offset: 0x1ECFB50 VA: 0x181ED1150
	public void SetToTarget() { }

	// RVA: 0x1ED06E0 Offset: 0x1ECF0E0 VA: 0x181ED06E0
	public void OnPreSolve(IKSolverFullBody solver) { }

	// RVA: 0x1ED0690 Offset: 0x1ECF090 VA: 0x181ED0690
	public void OnPostWrite() { }

	// RVA: 0x1ECF640 Offset: 0x1ECE040 VA: 0x181ECF640
	private Quaternion GetPlaneRotation(IKSolverFullBody solver) { }

	// RVA: 0x1ED1200 Offset: 0x1ECFC00 VA: 0x181ED1200
	public void Update(IKSolverFullBody solver) { }

	// RVA: 0x1ECF970 Offset: 0x1ECE370 VA: 0x181ECF970
	private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset) { }
}
