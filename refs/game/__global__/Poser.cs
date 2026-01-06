public abstract class Poser : SolverManager // TypeDefIndex: 14164
{
	// Fields
	public Transform poseRoot; // 0x40
	[Range(0, 1)]
	public float weight; // 0x48
	[Range(0, 1)]
	public float localRotationWeight; // 0x4C
	[Range(0, 1)]
	public float localPositionWeight; // 0x50
	private bool initiated; // 0x54

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void AutoMapping();

	// RVA: 0x4BC030 Offset: 0x4BAA30 VA: 0x1804BC030
	public void UpdateManual() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void InitiatePoser();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void UpdatePoser();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void FixPoserTransforms();

	// RVA: 0x1F25DA0 Offset: 0x1F247A0 VA: 0x181F25DA0 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x1F25D70 Offset: 0x1F24770 VA: 0x181F25D70 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x1F25D50 Offset: 0x1F24750 VA: 0x181F25D50 Slot: 6
	protected override void FixTransforms() { }

	// RVA: 0x1F202F0 Offset: 0x1F1ECF0 VA: 0x181F202F0
	protected void .ctor() { }
}
