public class IKMapping // TypeDefIndex: 14098
{
	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 4
	public virtual bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x1ED58A0 Offset: 0x1ED42A0 VA: 0x181ED58A0
	protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger) { }

	// RVA: 0x1EB66A0 Offset: 0x1EB50A0 VA: 0x181EB66A0
	protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
