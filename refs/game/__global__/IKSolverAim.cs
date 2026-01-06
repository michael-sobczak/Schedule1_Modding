public class IKSolverAim : IKSolverHeuristic // TypeDefIndex: 14109
{
	// Fields
	public Transform transform; // 0x88
	public Vector3 axis; // 0x90
	public Vector3 poleAxis; // 0x9C
	public Vector3 polePosition; // 0xA8
	[Range(0, 1)]
	public float poleWeight; // 0xB4
	public Transform poleTarget; // 0xB8
	[Range(0, 1)]
	public float clampWeight; // 0xC0
	[Range(0, 2)]
	public int clampSmoothing; // 0xC4
	public IKSolver.IterationDelegate OnPreIteration; // 0xC8
	private float step; // 0xD0
	private Vector3 clampedIKPosition; // 0xD4
	private RotationLimit transformLimit; // 0xE0
	private Transform lastTransform; // 0xE8

	// Properties
	public Vector3 transformAxis { get; }
	public Vector3 transformPoleAxis { get; }
	protected override int minBones { get; }
	protected override Vector3 localDirection { get; }

	// Methods

	// RVA: 0x1ED59E0 Offset: 0x1ED43E0 VA: 0x181ED59E0
	public float GetAngle() { }

	// RVA: 0x1ED7590 Offset: 0x1ED5F90 VA: 0x181ED7590
	public Vector3 get_transformAxis() { }

	// RVA: 0x1ED7620 Offset: 0x1ED6020 VA: 0x181ED7620
	public Vector3 get_transformPoleAxis() { }

	// RVA: 0x1ED5FD0 Offset: 0x1ED49D0 VA: 0x181ED5FD0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x1ED6370 Offset: 0x1ED4D70 VA: 0x181ED6370 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 12
	protected override int get_minBones() { }

	// RVA: 0x1ED72C0 Offset: 0x1ED5CC0 VA: 0x181ED72C0
	private void Solve() { }

	// RVA: 0x1ED5AF0 Offset: 0x1ED44F0 VA: 0x181ED5AF0
	private Vector3 GetClampedIKPosition() { }

	// RVA: 0x1ED6A70 Offset: 0x1ED5470 VA: 0x181ED6A70
	private void RotateToTarget(Vector3 targetPosition, IKSolver.Bone bone, float weight) { }

	// RVA: 0x1ED74D0 Offset: 0x1ED5ED0 VA: 0x181ED74D0 Slot: 15
	protected override Vector3 get_localDirection() { }

	// RVA: 0x1ED7420 Offset: 0x1ED5E20 VA: 0x181ED7420
	public void .ctor() { }
}
