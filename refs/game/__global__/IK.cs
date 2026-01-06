public abstract class IK : SolverManager // TypeDefIndex: 14080
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IKSolver GetIKSolver();

	// RVA: 0x1EC49A0 Offset: 0x1EC33A0 VA: 0x181EC49A0 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x1EC4920 Offset: 0x1EC3320 VA: 0x181EC4920 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x1EC48B0 Offset: 0x1EC32B0 VA: 0x181EC48B0 Slot: 6
	protected override void FixTransforms() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OpenUserManual();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OpenScriptReference();

	// RVA: 0x1EC4A40 Offset: 0x1EC3440 VA: 0x181EC4A40
	protected void .ctor() { }
}
