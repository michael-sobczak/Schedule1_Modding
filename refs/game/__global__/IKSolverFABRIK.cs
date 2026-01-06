public class IKSolverFABRIK : IKSolverHeuristic // TypeDefIndex: 14112
{
	// Fields
	public IKSolver.IterationDelegate OnPreIteration; // 0x88
	private bool[] limitedBones; // 0x90
	private Vector3[] solverLocalPositions; // 0x98

	// Properties
	protected override bool boneLengthCanBeZero { get; }

	// Methods

	// RVA: 0x1EDDDD0 Offset: 0x1EDC7D0 VA: 0x181EDDDD0
	public void SolveForward(Vector3 position) { }

	// RVA: 0x1EDDD00 Offset: 0x1EDC700 VA: 0x181EDDD00
	public void SolveBackward(Vector3 position) { }

	// RVA: 0x1EDBFA0 Offset: 0x1EDA9A0 VA: 0x181EDBFA0 Slot: 5
	public override Vector3 GetIKPosition() { }

	// RVA: 0x1EDCF60 Offset: 0x1EDB960 VA: 0x181EDCF60 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x1EDD930 Offset: 0x1EDC330 VA: 0x181EDD930 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 13
	protected override bool get_boneLengthCanBeZero() { }

	// RVA: 0x1EDDE80 Offset: 0x1EDC880 VA: 0x181EDDE80
	private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x1EDD470 Offset: 0x1EDBE70 VA: 0x181EDD470
	private void OnPreSolve() { }

	// RVA: 0x1EDD330 Offset: 0x1EDBD30 VA: 0x181EDD330
	private void OnPostSolve() { }

	// RVA: 0x1EDDF50 Offset: 0x1EDC950 VA: 0x181EDDF50
	private void Solve(Vector3 targetPosition) { }

	// RVA: 0x1EDBCC0 Offset: 0x1EDA6C0 VA: 0x181EDBCC0
	private void ForwardReach(Vector3 position) { }

	// RVA: 0x1EDE1B0 Offset: 0x1EDCBB0 VA: 0x181EDE1B0
	private void SolverMove(int index, Vector3 offset) { }

	// RVA: 0x1EDE440 Offset: 0x1EDCE40 VA: 0x181EDE440
	private void SolverRotate(int index, Quaternion rotation, bool recursive) { }

	// RVA: 0x1EDE260 Offset: 0x1EDCC60 VA: 0x181EDE260
	private void SolverRotateChildren(int index, Quaternion rotation) { }

	// RVA: 0x1EDDFF0 Offset: 0x1EDC9F0 VA: 0x181EDDFF0
	private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation) { }

	// RVA: 0x1EDC520 Offset: 0x1EDAF20 VA: 0x181EDC520
	private Quaternion GetParentSolverRotation(int index) { }

	// RVA: 0x1EDC3B0 Offset: 0x1EDADB0 VA: 0x181EDC3B0
	private Vector3 GetParentSolverPosition(int index) { }

	// RVA: 0x1EDC050 Offset: 0x1EDAA50 VA: 0x181EDC050
	private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed) { }

	// RVA: 0x1EDC680 Offset: 0x1EDB080 VA: 0x181EDC680
	private void LimitForward(int rotateBone, int limitBone) { }

	// RVA: 0x1EDBC80 Offset: 0x1EDA680 VA: 0x181EDBC80
	private void BackwardReach(Vector3 position) { }

	// RVA: 0x1EDBAB0 Offset: 0x1EDA4B0 VA: 0x181EDBAB0
	private void BackwardReachUnlimited(Vector3 position) { }

	// RVA: 0x1EDB280 Offset: 0x1ED9C80 VA: 0x181EDB280
	private void BackwardReachLimited(Vector3 position) { }

	// RVA: 0x1EDCDD0 Offset: 0x1EDB7D0 VA: 0x181EDCDD0
	private void MapToSolverPositions() { }

	// RVA: 0x1EDCCD0 Offset: 0x1EDB6D0 VA: 0x181EDCCD0
	private void MapToSolverPositionsLimited() { }

	// RVA: 0x1EDE640 Offset: 0x1EDD040 VA: 0x181EDE640
	public void .ctor() { }
}
