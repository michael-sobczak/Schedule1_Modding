public class IKSolverFullBody : IKSolver // TypeDefIndex: 14114
{
	// Fields
	[Range(0, 10)]
	public int iterations; // 0x58
	public FBIKChain[] chain; // 0x60
	public IKEffector[] effectors; // 0x68
	public IKMappingSpine spineMapping; // 0x70
	public IKMappingBone[] boneMappings; // 0x78
	public IKMappingLimb[] limbMappings; // 0x80
	public bool FABRIKPass; // 0x88
	public IKSolver.UpdateDelegate OnPreRead; // 0x90
	public IKSolver.UpdateDelegate OnPreSolve; // 0x98
	public IKSolver.IterationDelegate OnPreIteration; // 0xA0
	public IKSolver.IterationDelegate OnPostIteration; // 0xA8
	public IKSolver.UpdateDelegate OnPreBend; // 0xB0
	public IKSolver.UpdateDelegate OnPostSolve; // 0xB8
	public IKSolver.UpdateDelegate OnStoreDefaultLocalState; // 0xC0
	public IKSolver.UpdateDelegate OnFixTransforms; // 0xC8

	// Methods

	// RVA: 0x1EE3270 Offset: 0x1EE1C70 VA: 0x181EE3270
	public IKEffector GetEffector(Transform t) { }

	// RVA: 0x1EE3220 Offset: 0x1EE1C20 VA: 0x181EE3220
	public FBIKChain GetChain(Transform transform) { }

	// RVA: 0x1EE30E0 Offset: 0x1EE1AE0 VA: 0x181EE30E0
	public int GetChainIndex(Transform transform) { }

	// RVA: 0x1EE3370 Offset: 0x1EE1D70 VA: 0x181EE3370
	public IKSolver.Node GetNode(int chainIndex, int nodeIndex) { }

	// RVA: 0x1EE3060 Offset: 0x1EE1A60 VA: 0x181EE3060
	public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex) { }

	// RVA: 0x1EE3530 Offset: 0x1EE1F30 VA: 0x181EE3530 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x1EE33C0 Offset: 0x1EE1DC0 VA: 0x181EE33C0 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x1EE3740 Offset: 0x1EE2140 VA: 0x181EE3740 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x1EE4520 Offset: 0x1EE2F20 VA: 0x181EE4520 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x1EE2D30 Offset: 0x1EE1730 VA: 0x181EE2D30 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x1EE39B0 Offset: 0x1EE23B0 VA: 0x181EE39B0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x1EE3B60 Offset: 0x1EE2560 VA: 0x181EE3B60 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x1EE3D90 Offset: 0x1EE2790 VA: 0x181EE3D90 Slot: 12
	protected virtual void ReadPose() { }

	// RVA: 0x1EE41C0 Offset: 0x1EE2BC0 VA: 0x181EE41C0 Slot: 13
	protected virtual void Solve() { }

	// RVA: 0x1EE2CF0 Offset: 0x1EE16F0 VA: 0x181EE2CF0 Slot: 14
	protected virtual void ApplyBendConstraints() { }

	// RVA: 0x1EE4760 Offset: 0x1EE3160 VA: 0x181EE4760 Slot: 15
	protected virtual void WritePose() { }

	// RVA: 0x1EE48B0 Offset: 0x1EE32B0 VA: 0x181EE48B0
	public void .ctor() { }
}
