public class FingerRig : SolverManager // TypeDefIndex: 14058
{
	// Fields
	[Tooltip("The master weight for all fingers.")]
	[Range(0, 1)]
	public float weight; // 0x40
	public Finger[] fingers; // 0x48
	[CompilerGenerated]
	private bool <initiated>k__BackingField; // 0x50

	// Properties
	public bool initiated { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_initiated() { }

	[CompilerGenerated]
	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0
	private void set_initiated(bool value) { }

	// RVA: 0x1EB7F40 Offset: 0x1EB6940 VA: 0x181EB7F40
	public bool IsValid(ref string errorMessage) { }

	[ContextMenu("Auto-detect")]
	// RVA: 0x1EB79B0 Offset: 0x1EB63B0 VA: 0x181EB79B0
	public void AutoDetect() { }

	// RVA: 0x1EB77E0 Offset: 0x1EB61E0 VA: 0x181EB77E0
	public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target) { }

	// RVA: 0x1EB7FC0 Offset: 0x1EB69C0 VA: 0x181EB7FC0
	public void RemoveFinger(int index) { }

	// RVA: 0x1EB76E0 Offset: 0x1EB60E0 VA: 0x181EB76E0
	private void AddChildrenRecursive(Transform parent, ref Transform[] array) { }

	// RVA: 0x1EB7E80 Offset: 0x1EB6880 VA: 0x181EB7E80 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x1EB82E0 Offset: 0x1EB6CE0 VA: 0x181EB82E0
	public void UpdateFingerSolvers() { }

	// RVA: 0x1EB7D20 Offset: 0x1EB6720 VA: 0x181EB7D20
	public void FixFingerTransforms() { }

	// RVA: 0x1EB81A0 Offset: 0x1EB6BA0 VA: 0x181EB81A0
	public void StoreDefaultLocalState() { }

	// RVA: 0x1EB82E0 Offset: 0x1EB6CE0 VA: 0x181EB82E0 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x1EB7D20 Offset: 0x1EB6720 VA: 0x181EB7D20 Slot: 6
	protected override void FixTransforms() { }

	// RVA: 0x1EB8360 Offset: 0x1EB6D60 VA: 0x181EB8360
	public void .ctor() { }
}
