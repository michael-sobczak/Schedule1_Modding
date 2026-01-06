public class IKSolverFABRIKRoot : IKSolver // TypeDefIndex: 14113
{
	// Fields
	public int iterations; // 0x58
	[Range(0, 1)]
	public float rootPin; // 0x5C
	public FABRIKChain[] chains; // 0x60
	private bool zeroWeightApplied; // 0x68
	private bool[] isRoot; // 0x70
	private Vector3 rootDefaultPosition; // 0x78

	// Methods

	// RVA: 0x1EDA5A0 Offset: 0x1ED8FA0 VA: 0x181EDA5A0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x1EDB150 Offset: 0x1ED9B50 VA: 0x181EDB150 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x1ED9E00 Offset: 0x1ED8800 VA: 0x181ED9E00 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x1EDAD10 Offset: 0x1ED9710 VA: 0x181EDAD10 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x1EDA510 Offset: 0x1ED8F10 VA: 0x181EDA510
	private bool IsRoot(int index) { }

	// RVA: 0x1EDAED0 Offset: 0x1ED98D0 VA: 0x181EDAED0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x1EDA2F0 Offset: 0x1ED8CF0 VA: 0x181EDA2F0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x1EDA230 Offset: 0x1ED8C30 VA: 0x181EDA230 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x1ED9C80 Offset: 0x1ED8680 VA: 0x181ED9C80
	private void AddPointsToArray(ref IKSolver.Point[] array, FABRIKChain chain) { }

	// RVA: 0x1ED9ED0 Offset: 0x1ED88D0 VA: 0x181ED9ED0
	private Vector3 GetCentroid() { }

	// RVA: 0x1EDB210 Offset: 0x1ED9C10 VA: 0x181EDB210
	public void .ctor() { }
}
