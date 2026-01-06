public class IKSolverTrigonometric : IKSolver // TypeDefIndex: 14126
{
	// Fields
	public Transform target; // 0x58
	[Range(0, 1)]
	public float IKRotationWeight; // 0x60
	public Quaternion IKRotation; // 0x64
	public Vector3 bendNormal; // 0x74
	public IKSolverTrigonometric.TrigonometricBone bone1; // 0x80
	public IKSolverTrigonometric.TrigonometricBone bone2; // 0x88
	public IKSolverTrigonometric.TrigonometricBone bone3; // 0x90
	protected Vector3 weightIKPosition; // 0x98
	protected bool directHierarchy; // 0xA4

	// Methods

	// RVA: 0x1EF51B0 Offset: 0x1EF3BB0 VA: 0x181EF51B0
	public void SetBendGoalPosition(Vector3 goalPosition, float weight) { }

	// RVA: 0x1EF5450 Offset: 0x1EF3E50 VA: 0x181EF5450
	public void SetBendPlaneToCurrent() { }

	// RVA: 0xC09400 Offset: 0xC07E00 VA: 0x180C09400
	public void SetIKRotation(Quaternion rotation) { }

	// RVA: 0x1EF5720 Offset: 0x1EF4120 VA: 0x181EF5720
	public void SetIKRotationWeight(float weight) { }

	// RVA: 0x1EF3A40 Offset: 0x1EF2440 VA: 0x181EF3A40
	public Quaternion GetIKRotation() { }

	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float GetIKRotationWeight() { }

	// RVA: 0x1EF3BA0 Offset: 0x1EF25A0 VA: 0x181EF3BA0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x1EF3A50 Offset: 0x1EF2450 VA: 0x181EF3A50 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x1EF5FD0 Offset: 0x1EF49D0 VA: 0x181EF5FD0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x1EF33D0 Offset: 0x1EF1DD0 VA: 0x181EF33D0 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x1EF3F10 Offset: 0x1EF2910 VA: 0x181EF3F10 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x1EF5680 Offset: 0x1EF4080 VA: 0x181EF5680
	public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root) { }

	// RVA: 0x1EF5750 Offset: 0x1EF4150 VA: 0x181EF5750
	public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight) { }

	// RVA: 0x1EF3810 Offset: 0x1EF2210 VA: 0x181EF3810
	private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) { }

	// RVA: 0x1EF43E0 Offset: 0x1EF2DE0 VA: 0x181EF43E0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x1EF3DF0 Offset: 0x1EF27F0 VA: 0x181EF3DF0
	private bool IsDirectHierarchy() { }

	// RVA: 0x1EF3CF0 Offset: 0x1EF26F0 VA: 0x181EF3CF0
	public void InitiateBones() { }

	// RVA: 0x1EF4720 Offset: 0x1EF3120 VA: 0x181EF4720 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	protected virtual void OnInitiateVirtual() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	protected virtual void OnUpdateVirtual() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	protected virtual void OnPostSolveVirtual() { }

	// RVA: 0x1EF3430 Offset: 0x1EF1E30 VA: 0x181EF3430
	protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal) { }

	// RVA: 0x1EF6020 Offset: 0x1EF4A20 VA: 0x181EF6020
	public void .ctor() { }
}
