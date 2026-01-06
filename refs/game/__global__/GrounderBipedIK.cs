public class GrounderBipedIK : Grounder // TypeDefIndex: 14061
{
	// Fields
	[Tooltip("The BipedIK componet.")]
	public BipedIK ik; // 0x50
	[Tooltip("The amount of spine bending towards upward slopes.")]
	public float spineBend; // 0x58
	[Tooltip("The interpolation speed of spine bending.")]
	public float spineSpeed; // 0x5C
	private Transform[] feet; // 0x60
	private Quaternion[] footRotations; // 0x68
	private Vector3 animatedPelvisLocalPosition; // 0x70
	private Vector3 solvedPelvisLocalPosition; // 0x7C
	private Vector3 spineOffset; // 0x88
	private float lastWeight; // 0x94

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1EBB960 Offset: 0x1EBA360 VA: 0x181EBB960 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1EBB900 Offset: 0x1EBA300 VA: 0x181EBB900 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x1EBB9C0 Offset: 0x1EBA3C0 VA: 0x181EBB9C0 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x1EBAA50 Offset: 0x1EB9450 VA: 0x181EBAA50
	private bool IsReadyToInitiate() { }

	// RVA: 0x1EBBB00 Offset: 0x1EBA500 VA: 0x181EBBB00
	private void Update() { }

	// RVA: 0x1EBA620 Offset: 0x1EB9020 VA: 0x181EBA620
	private void Initiate() { }

	// RVA: 0x1EBAD30 Offset: 0x1EB9730 VA: 0x181EBAD30
	private void OnDisable() { }

	// RVA: 0x1EBB100 Offset: 0x1EB9B00 VA: 0x181EBB100
	private void OnSolverUpdate() { }

	// RVA: 0x1EBBA30 Offset: 0x1EBA430 VA: 0x181EBBA30
	private void SetLegIK(IKSolverLimb limb, int index) { }

	// RVA: 0x1EBAD90 Offset: 0x1EB9790 VA: 0x181EBAD90
	private void OnPostSolverUpdate() { }

	// RVA: 0x1EBAB00 Offset: 0x1EB9500 VA: 0x181EBAB00
	private void OnDestroy() { }

	// RVA: 0x1EBBBF0 Offset: 0x1EBA5F0 VA: 0x181EBBBF0
	public void .ctor() { }
}
