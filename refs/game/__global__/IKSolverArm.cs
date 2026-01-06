public class IKSolverArm : IKSolver // TypeDefIndex: 14110
{
	// Fields
	[Range(0, 1)]
	public float IKRotationWeight; // 0x58
	public Quaternion IKRotation; // 0x5C
	public IKSolver.Point chest; // 0x70
	public IKSolver.Point shoulder; // 0x78
	public IKSolver.Point upperArm; // 0x80
	public IKSolver.Point forearm; // 0x88
	public IKSolver.Point hand; // 0x90
	public bool isLeft; // 0x98
	public IKSolverVR.Arm arm; // 0xA0
	private Vector3[] positions; // 0xA8
	private Quaternion[] rotations; // 0xB0

	// Methods

	// RVA: 0x1ED7B00 Offset: 0x1ED6500 VA: 0x181ED7B00 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x66B040 Offset: 0x669A40 VA: 0x18066B040
	public void SetRotationWeight(float weight) { }

	// RVA: 0x1ED8500 Offset: 0x1ED6F00 VA: 0x181ED8500
	public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root) { }

	// RVA: 0x1ED7910 Offset: 0x1ED6310 VA: 0x181ED7910 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x1ED7720 Offset: 0x1ED6120 VA: 0x181ED7720 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x1ED8690 Offset: 0x1ED7090 VA: 0x181ED8690 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x1ED76B0 Offset: 0x1ED60B0 VA: 0x181ED76B0 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x1ED7F60 Offset: 0x1ED6960 VA: 0x181ED7F60 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x1ED7FE0 Offset: 0x1ED69E0 VA: 0x181ED7FE0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x1ED85E0 Offset: 0x1ED6FE0 VA: 0x181ED85E0
	private void Solve() { }

	// RVA: 0x1ED80A0 Offset: 0x1ED6AA0 VA: 0x181ED80A0
	private void Read() { }

	// RVA: 0x1ED8810 Offset: 0x1ED7210 VA: 0x181ED8810
	private void Write() { }

	// RVA: 0x1ED8A20 Offset: 0x1ED7420 VA: 0x181ED8A20
	public void .ctor() { }
}
