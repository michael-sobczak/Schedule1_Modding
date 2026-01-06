public class InteractionObject : MonoBehaviour // TypeDefIndex: 14149
{
	// Fields
	[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
	public Transform otherLookAtTarget; // 0x20
	[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
	public Transform otherTargetsRoot; // 0x28
	[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
	public Transform positionOffsetSpace; // 0x30
	public InteractionObject.WeightCurve[] weightCurves; // 0x38
	public InteractionObject.Multiplier[] multipliers; // 0x40
	public InteractionObject.InteractionEvent[] events; // 0x48
	[CompilerGenerated]
	private float <length>k__BackingField; // 0x50
	[CompilerGenerated]
	private InteractionSystem <lastUsedInteractionSystem>k__BackingField; // 0x58
	private InteractionTarget[] targets; // 0x60

	// Properties
	public float length { get; set; }
	public InteractionSystem lastUsedInteractionSystem { get; set; }
	public Transform lookAtTarget { get; }
	public Transform targetsRoot { get; }

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1F05510 Offset: 0x1F03F10 VA: 0x181F05510
	private void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1F05330 Offset: 0x1F03D30 VA: 0x181F05330
	private void OpenScriptReference() { }

	[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
	// RVA: 0x1F05390 Offset: 0x1F03D90 VA: 0x181F05390
	private void OpenTutorial1() { }

	[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
	// RVA: 0x1F053F0 Offset: 0x1F03DF0 VA: 0x181F053F0
	private void OpenTutorial2() { }

	[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
	// RVA: 0x1F05450 Offset: 0x1F03E50 VA: 0x181F05450
	private void OpenTutorial3() { }

	[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
	// RVA: 0x1F054B0 Offset: 0x1F03EB0 VA: 0x181F054B0
	private void OpenTutorial4() { }

	[ContextMenu("Support Group")]
	// RVA: 0x1F05580 Offset: 0x1F03F80 VA: 0x181F05580
	private void SupportGroup() { }

	[ContextMenu("Asset Store Thread")]
	// RVA: 0x1F03CC0 Offset: 0x1F026C0 VA: 0x181F03CC0
	private void ASThread() { }

	[CompilerGenerated]
	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_length() { }

	[CompilerGenerated]
	// RVA: 0x6FF440 Offset: 0x6FDE40 VA: 0x1806FF440
	private void set_length(float value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public InteractionSystem get_lastUsedInteractionSystem() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_lastUsedInteractionSystem(InteractionSystem value) { }

	// RVA: 0x1F050A0 Offset: 0x1F03AA0 VA: 0x181F050A0
	public void Initiate() { }

	// RVA: 0x1F05640 Offset: 0x1F04040 VA: 0x181F05640
	public Transform get_lookAtTarget() { }

	// RVA: 0x1F04BD0 Offset: 0x1F035D0 VA: 0x181F04BD0
	public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem) { }

	// RVA: 0x1F04920 Offset: 0x1F03320 VA: 0x181F04920
	public bool CurveUsed(InteractionObject.WeightCurve.Type type) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public InteractionTarget[] GetTargets() { }

	// RVA: 0x1F04A30 Offset: 0x1F03430 VA: 0x181F04A30
	public Transform GetTarget(FullBodyBipedEffector effectorType, string tag) { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void OnStartInteraction(InteractionSystem interactionSystem) { }

	// RVA: 0x1F03D20 Offset: 0x1F02720 VA: 0x181F03D20
	public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight, bool isPaused) { }

	// RVA: 0x1F04DB0 Offset: 0x1F037B0 VA: 0x181F04DB0
	public float GetValue(InteractionObject.WeightCurve.Type weightCurveType, InteractionTarget target, float timer) { }

	// RVA: 0x1F056C0 Offset: 0x1F040C0 VA: 0x181F056C0
	public Transform get_targetsRoot() { }

	// RVA: 0x1F05570 Offset: 0x1F03F70 VA: 0x181F05570
	private void Start() { }

	// RVA: 0x1F04300 Offset: 0x1F02D00 VA: 0x181F04300
	private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionObject.WeightCurve.Type type, float value, float weight) { }

	// RVA: 0x1F04D30 Offset: 0x1F03730 VA: 0x181F04D30
	private Transform GetTarget(FullBodyBipedEffector effectorType) { }

	// RVA: 0x1F05040 Offset: 0x1F03A40 VA: 0x181F05040
	private int GetWeightCurveIndex(InteractionObject.WeightCurve.Type weightCurveType) { }

	// RVA: 0x1F049D0 Offset: 0x1F033D0 VA: 0x181F049D0
	private int GetMultiplierIndex(InteractionObject.WeightCurve.Type weightCurveType) { }

	// RVA: 0x1F055E0 Offset: 0x1F03FE0 VA: 0x181F055E0
	public void .ctor() { }
}
