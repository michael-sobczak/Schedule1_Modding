public class BipedIKSolvers // TypeDefIndex: 14049
{
	// Fields
	public IKSolverLimb leftFoot; // 0x10
	public IKSolverLimb rightFoot; // 0x18
	public IKSolverLimb leftHand; // 0x20
	public IKSolverLimb rightHand; // 0x28
	public IKSolverFABRIK spine; // 0x30
	public IKSolverLookAt lookAt; // 0x38
	public IKSolverAim aim; // 0x40
	public Constraints pelvis; // 0x48
	private IKSolverLimb[] _limbs; // 0x50
	private IKSolver[] _ikSolvers; // 0x58

	// Properties
	public IKSolverLimb[] limbs { get; }
	public IKSolver[] ikSolvers { get; }

	// Methods

	// RVA: 0x1E99390 Offset: 0x1E97D90 VA: 0x181E99390
	public IKSolverLimb[] get_limbs() { }

	// RVA: 0x1E990F0 Offset: 0x1E97AF0 VA: 0x181E990F0
	public IKSolver[] get_ikSolvers() { }

	// RVA: 0x1E98D80 Offset: 0x1E97780 VA: 0x181E98D80
	public void AssignReferences(BipedReferences references) { }

	// RVA: 0x1E98F20 Offset: 0x1E97920 VA: 0x181E98F20
	public void .ctor() { }
}
