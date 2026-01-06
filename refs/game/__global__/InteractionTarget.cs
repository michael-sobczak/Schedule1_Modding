public class InteractionTarget : MonoBehaviour // TypeDefIndex: 14155
{
	// Fields
	[Tooltip("The type of the FBBIK effector.")]
	public FullBodyBipedEffector effectorType; // 0x20
	[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
	public InteractionTarget.Multiplier[] multipliers; // 0x28
	[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
	public float interactionSpeedMlp; // 0x30
	[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
	public Transform pivot; // 0x38
	[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
	public InteractionTarget.RotationMode rotationMode; // 0x40
	[Tooltip("The axis of twisting the interaction target (blue line).")]
	public Vector3 twistAxis; // 0x44
	[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
	public float twistWeight; // 0x50
	[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
	public float swingWeight; // 0x54
	[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
	[Range(0, 1)]
	public float threeDOFWeight; // 0x58
	[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
	public bool rotateOnce; // 0x5C
	[Tooltip("Will not set HandPoser's pose target and allows you to use a pose target from a previous interaction if disabled.")]
	public bool usePoser; // 0x5D
	private Quaternion defaultLocalRotation; // 0x60
	private Transform lastPivot; // 0x70

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1F225D0 Offset: 0x1F20FD0 VA: 0x181F225D0
	private void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1F223F0 Offset: 0x1F20DF0 VA: 0x181F223F0
	private void OpenScriptReference() { }

	[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
	// RVA: 0x1F22450 Offset: 0x1F20E50 VA: 0x181F22450
	private void OpenTutorial1() { }

	[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
	// RVA: 0x1F224B0 Offset: 0x1F20EB0 VA: 0x181F224B0
	private void OpenTutorial2() { }

	[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
	// RVA: 0x1F22510 Offset: 0x1F20F10 VA: 0x181F22510
	private void OpenTutorial3() { }

	[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
	// RVA: 0x1F22570 Offset: 0x1F20F70 VA: 0x181F22570
	private void OpenTutorial4() { }

	[ContextMenu("Support Group")]
	// RVA: 0x1F22FB0 Offset: 0x1F219B0 VA: 0x181F22FB0
	private void SupportGroup() { }

	[ContextMenu("Asset Store Thread")]
	// RVA: 0x1F22310 Offset: 0x1F20D10 VA: 0x181F22310
	private void ASThread() { }

	// RVA: 0x1F22370 Offset: 0x1F20D70 VA: 0x181F22370
	public float GetValue(InteractionObject.WeightCurve.Type curveType) { }

	// RVA: 0x1F22630 Offset: 0x1F21030 VA: 0x181F22630
	public void ResetRotation() { }

	// RVA: 0x1F226C0 Offset: 0x1F210C0 VA: 0x181F226C0
	public void RotateTo(Transform bone) { }

	// RVA: 0x1F23010 Offset: 0x1F21A10 VA: 0x181F23010
	public void .ctor() { }
}
