public class SolverManager : MonoBehaviour // TypeDefIndex: 14042
{
	// Fields
	[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
	public bool fixTransforms; // 0x20
	private Animator animator; // 0x28
	private Animation legacy; // 0x30
	private bool updateFrame; // 0x38
	private bool componentInitiated; // 0x39
	private bool skipSolverUpdate; // 0x3A

	// Properties
	private bool animatePhysics { get; }
	private bool isAnimated { get; }

	// Methods

	// RVA: 0x1EAB8A0 Offset: 0x1EAA2A0 VA: 0x181EAB8A0
	public void Disable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	protected virtual void InitiateSolver() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void UpdateSolver() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	protected virtual void FixTransforms() { }

	// RVA: 0x1EABBF0 Offset: 0x1EAA5F0 VA: 0x181EABBF0
	private void OnDisable() { }

	// RVA: 0x1EABB50 Offset: 0x1EAA550 VA: 0x181EABB50
	private void Start() { }

	// RVA: 0x1EABD10 Offset: 0x1EAA710 VA: 0x181EABD10
	private bool get_animatePhysics() { }

	// RVA: 0x1EABB50 Offset: 0x1EAA550 VA: 0x181EABB50
	private void Initiate() { }

	// RVA: 0x1EABCC0 Offset: 0x1EAA6C0 VA: 0x181EABCC0
	private void Update() { }

	// RVA: 0x1EAB920 Offset: 0x1EAA320 VA: 0x181EAB920
	private void FindAnimatorRecursive(Transform t, bool findInChildren) { }

	// RVA: 0x1EABDE0 Offset: 0x1EAA7E0 VA: 0x181EABDE0
	private bool get_isAnimated() { }

	// RVA: 0x1EABB00 Offset: 0x1EAA500 VA: 0x181EABB00
	private void FixedUpdate() { }

	// RVA: 0x1EABBA0 Offset: 0x1EAA5A0 VA: 0x181EABBA0
	private void LateUpdate() { }

	// RVA: 0x1EABC80 Offset: 0x1EAA680 VA: 0x181EABC80
	public void UpdateSolverExternal() { }

	// RVA: 0x567D00 Offset: 0x566700 VA: 0x180567D00
	public void .ctor() { }
}
