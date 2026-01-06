public class IKSolverLeg : IKSolver // TypeDefIndex: 14119
{
	// Fields
	[Range(0, 1)]
	public float IKRotationWeight; // 0x58
	public Quaternion IKRotation; // 0x5C
	public IKSolver.Point pelvis; // 0x70
	public IKSolver.Point thigh; // 0x78
	public IKSolver.Point calf; // 0x80
	public IKSolver.Point foot; // 0x88
	public IKSolver.Point toe; // 0x90
	public IKSolverVR.Leg leg; // 0x98
	public Vector3 heelOffset; // 0xA0
	private Vector3[] positions; // 0xB0
	private Quaternion[] rotations; // 0xB8

	// Methods

	// RVA: 0x1EEDBB0 Offset: 0x1EEC5B0 VA: 0x181EEDBB0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x66B040 Offset: 0x669A40 VA: 0x18066B040
	public void SetRotationWeight(float weight) { }

	// RVA: 0x1ED8500 Offset: 0x1ED6F00 VA: 0x181ED8500
	public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root) { }

	// RVA: 0x1EED9C0 Offset: 0x1EEC3C0 VA: 0x181EED9C0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x1EED7D0 Offset: 0x1EEC1D0 VA: 0x181EED7D0 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x1EEE780 Offset: 0x1EED180 VA: 0x181EEE780 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x1ED76B0 Offset: 0x1ED60B0 VA: 0x181ED76B0 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x1EEE010 Offset: 0x1EECA10 VA: 0x181EEE010 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x1EEE090 Offset: 0x1EECA90 VA: 0x181EEE090 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x1EEE680 Offset: 0x1EED080 VA: 0x181EEE680
	private void Solve() { }

	// RVA: 0x1EEE1A0 Offset: 0x1EECBA0 VA: 0x181EEE1A0
	private void Read() { }

	// RVA: 0x1EEE7E0 Offset: 0x1EED1E0 VA: 0x181EEE7E0
	private void Write() { }

	// RVA: 0x1EEE9F0 Offset: 0x1EED3F0 VA: 0x181EEE9F0
	public void .ctor() { }
}
