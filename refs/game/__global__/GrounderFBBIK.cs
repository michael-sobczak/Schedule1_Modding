public class GrounderFBBIK : Grounder // TypeDefIndex: 14063
{
	// Fields
	[Tooltip("Reference to the FBBIK componet.")]
	public FullBodyBipedIK ik; // 0x50
	[Tooltip("The amount of spine bending towards upward slopes.")]
	public float spineBend; // 0x58
	[Tooltip("The interpolation speed of spine bending.")]
	public float spineSpeed; // 0x5C
	public GrounderFBBIK.SpineEffector[] spine; // 0x60
	private Transform[] feet; // 0x68
	private Vector3 spineOffset; // 0x70
	private bool firstSolve; // 0x7C

	// Methods

	[ContextMenu("TUTORIAL VIDEO")]
	// RVA: 0x1EBC9C0 Offset: 0x1EBB3C0 VA: 0x181EBC9C0
	private void OpenTutorial() { }

	[ContextMenu("User Manual")]
	// RVA: 0x1EBCA20 Offset: 0x1EBB420 VA: 0x181EBCA20 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1EBC960 Offset: 0x1EBB360 VA: 0x181EBC960 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x1EBCA80 Offset: 0x1EBB480 VA: 0x181EBCA80 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x1EBC090 Offset: 0x1EBAA90 VA: 0x181EBC090
	private bool IsReadyToInitiate() { }

	// RVA: 0x1EBCDD0 Offset: 0x1EBB7D0 VA: 0x181EBCDD0
	private void Update() { }

	// RVA: 0x1EBBCE0 Offset: 0x1EBA6E0 VA: 0x181EBBCE0
	private void FixedUpdate() { }

	// RVA: 0x1EBBCE0 Offset: 0x1EBA6E0 VA: 0x181EBBCE0
	private void LateUpdate() { }

	// RVA: 0x1EBBCF0 Offset: 0x1EBA6F0 VA: 0x181EBBCF0
	private void Initiate() { }

	// RVA: 0x1EBC470 Offset: 0x1EBAE70 VA: 0x181EBC470
	private void OnSolverUpdate() { }

	// RVA: 0x1EBCAE0 Offset: 0x1EBB4E0 VA: 0x181EBCAE0
	private void SetLegIK(IKEffector effector, Grounding.Leg leg) { }

	// RVA: 0x1EBC330 Offset: 0x1EBAD30 VA: 0x181EBC330
	private void OnDrawGizmosSelected() { }

	// RVA: 0x939D60 Offset: 0x938760 VA: 0x180939D60
	private void OnPostSolverUpdate() { }

	// RVA: 0x1EBC120 Offset: 0x1EBAB20 VA: 0x181EBC120
	private void OnDestroy() { }

	// RVA: 0x1EBCEA0 Offset: 0x1EBB8A0 VA: 0x181EBCEA0
	public void .ctor() { }
}
