public class InteractionSystem : MonoBehaviour // TypeDefIndex: 14152
{
	// Fields
	[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
	public string targetTag; // 0x20
	[Tooltip("The fade in time of the interaction.")]
	public float fadeInTime; // 0x28
	[Tooltip("The master speed for all interactions.")]
	public float speed; // 0x2C
	[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
	public float resetToDefaultsSpeed; // 0x30
	[FormerlySerializedAs("collider")]
	[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
	[Header("Triggering")]
	public Collider characterCollider; // 0x38
	[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
	[FormerlySerializedAs("camera")]
	public Transform FPSCamera; // 0x40
	[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
	public LayerMask camRaycastLayers; // 0x48
	[Tooltip("Max distance of raycasting from the camera.")]
	public float camRaycastDistance; // 0x4C
	[CompilerGenerated]
	private List<InteractionTrigger> <triggersInRange>k__BackingField; // 0x50
	private List<InteractionTrigger> inContact; // 0x58
	private List<int> bestRangeIndexes; // 0x60
	public InteractionSystem.InteractionDelegate OnInteractionStart; // 0x68
	public InteractionSystem.InteractionDelegate OnInteractionPause; // 0x70
	public InteractionSystem.InteractionDelegate OnInteractionPickUp; // 0x78
	public InteractionSystem.InteractionDelegate OnInteractionResume; // 0x80
	public InteractionSystem.InteractionDelegate OnInteractionStop; // 0x88
	public InteractionSystem.InteractionEventDelegate OnInteractionEvent; // 0x90
	public RaycastHit raycastHit; // 0x98
	[Space(10)]
	[SerializeField]
	[Tooltip("Reference to the FBBIK component.")]
	private FullBodyBipedIK fullBody; // 0xC8
	[Tooltip("Handles looking at the interactions.")]
	public InteractionLookAt lookAt; // 0xD0
	private InteractionEffector[] interactionEffectors; // 0xD8
	[CompilerGenerated]
	private bool <initiated>k__BackingField; // 0xE0
	private Collider lastCollider; // 0xE8
	private Collider c; // 0xF0
	private float lastTime; // 0xF8

	// Properties
	public bool inInteraction { get; }
	public FullBodyBipedIK ik { get; set; }
	public List<InteractionTrigger> triggersInRange { get; set; }
	public bool initiated { get; set; }

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1F07E70 Offset: 0x1F06870 VA: 0x181F07E70
	private void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1F07C90 Offset: 0x1F06690 VA: 0x181F07C90
	private void OpenScriptReference() { }

	[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
	// RVA: 0x1F07CF0 Offset: 0x1F066F0 VA: 0x181F07CF0
	private void OpenTutorial1() { }

	[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
	// RVA: 0x1F07D50 Offset: 0x1F06750 VA: 0x181F07D50
	private void OpenTutorial2() { }

	[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
	// RVA: 0x1F07DB0 Offset: 0x1F067B0 VA: 0x181F07DB0
	private void OpenTutorial3() { }

	[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
	// RVA: 0x1F07E10 Offset: 0x1F06810 VA: 0x181F07E10
	private void OpenTutorial4() { }

	[ContextMenu("Support")]
	// RVA: 0x1F094D0 Offset: 0x1F07ED0 VA: 0x181F094D0
	private void SupportGroup() { }

	[ContextMenu("Asset Store Thread")]
	// RVA: 0x1F05740 Offset: 0x1F04140 VA: 0x181F05740
	private void ASThread() { }

	// RVA: 0x1F0ADC0 Offset: 0x1F097C0 VA: 0x181F0ADC0
	public bool get_inInteraction() { }

	// RVA: 0x1F06650 Offset: 0x1F05050 VA: 0x181F06650
	public bool IsInInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x1F06990 Offset: 0x1F05390 VA: 0x181F06990
	public bool IsPaused(FullBodyBipedEffector effectorType) { }

	// RVA: 0x1F06870 Offset: 0x1F05270 VA: 0x181F06870
	public bool IsPaused() { }

	// RVA: 0x1F06720 Offset: 0x1F05120 VA: 0x181F06720
	public bool IsInSync() { }

	// RVA: 0x1F08540 Offset: 0x1F06F40 VA: 0x181F08540
	public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt) { }

	// RVA: 0x1F082B0 Offset: 0x1F06CB0 VA: 0x181F082B0
	public bool StartInteractionWithClosestTarget(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt) { }

	// RVA: 0x1F05E20 Offset: 0x1F04820 VA: 0x181F05E20
	private int GetClosestTargetIndex(FullBodyBipedEffector effectorType, InteractionObject obj) { }

	// RVA: 0x1F08430 Offset: 0x1F06E30 VA: 0x181F08430
	public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt) { }

	// RVA: 0x1F07F70 Offset: 0x1F06970 VA: 0x181F07F70
	public bool PauseInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x1F08220 Offset: 0x1F06C20 VA: 0x181F08220
	public bool ResumeInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x1F09120 Offset: 0x1F07B20 VA: 0x181F09120
	public bool StopInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x1F07ED0 Offset: 0x1F068D0 VA: 0x181F07ED0
	public void PauseAll() { }

	// RVA: 0x1F08180 Offset: 0x1F06B80 VA: 0x181F08180
	public void ResumeAll() { }

	// RVA: 0x1F08F40 Offset: 0x1F07940 VA: 0x181F08F40
	public void StopAll() { }

	// RVA: 0x1F06260 Offset: 0x1F04C60 VA: 0x181F06260
	public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType) { }

	// RVA: 0x1F06450 Offset: 0x1F04E50 VA: 0x181F06450
	public float GetProgress(FullBodyBipedEffector effectorType) { }

	// RVA: 0x1F062F0 Offset: 0x1F04CF0 VA: 0x181F062F0
	public float GetMinActiveProgress() { }

	// RVA: 0x1F09EC0 Offset: 0x1F088C0 VA: 0x181F09EC0
	public bool TriggerInteraction(int index, bool interrupt) { }

	// RVA: 0x1F099A0 Offset: 0x1F083A0 VA: 0x181F099A0
	public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject) { }

	// RVA: 0x1F09BD0 Offset: 0x1F085D0 VA: 0x181F09BD0
	public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget) { }

	// RVA: 0x1F05B10 Offset: 0x1F04510 VA: 0x181F05B10
	public InteractionTrigger.Range GetClosestInteractionRange() { }

	// RVA: 0x1F05970 Offset: 0x1F04370 VA: 0x181F05970
	public InteractionObject GetClosestInteractionObjectInRange() { }

	// RVA: 0x1F05C00 Offset: 0x1F04600 VA: 0x181F05C00
	public InteractionTarget GetClosestInteractionTargetInRange() { }

	// RVA: 0x1F059C0 Offset: 0x1F043C0 VA: 0x181F059C0
	public InteractionObject[] GetClosestInteractionObjectsInRange() { }

	// RVA: 0x1F05C70 Offset: 0x1F04670 VA: 0x181F05C70
	public InteractionTarget[] GetClosestInteractionTargetsInRange() { }

	// RVA: 0x1F09530 Offset: 0x1F07F30 VA: 0x181F09530
	public bool TriggerEffectorsReady(int index) { }

	// RVA: 0x1F064E0 Offset: 0x1F04EE0 VA: 0x181F064E0
	public InteractionTrigger.Range GetTriggerRange(int index) { }

	// RVA: 0x1F06060 Offset: 0x1F04A60 VA: 0x181F06060
	public int GetClosestTriggerIndex() { }

	// RVA: 0x1F091B0 Offset: 0x1F07BB0 VA: 0x181F091B0
	public void StoreDefaults() { }

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public FullBodyBipedIK get_ik() { }

	// RVA: 0x4B6CC0 Offset: 0x4B56C0 VA: 0x1804B6CC0
	public void set_ik(FullBodyBipedIK value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public List<InteractionTrigger> get_triggersInRange() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_triggersInRange(List<InteractionTrigger> value) { }

	[CompilerGenerated]
	// RVA: 0x510890 Offset: 0x50F290 VA: 0x180510890
	public bool get_initiated() { }

	[CompilerGenerated]
	// RVA: 0x973C20 Offset: 0x972620 VA: 0x180973C20
	private void set_initiated(bool value) { }

	// RVA: 0x1F08650 Offset: 0x1F07050 VA: 0x181F08650
	public void Start() { }

	// RVA: 0x1F06610 Offset: 0x1F05010 VA: 0x181F06610
	private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x1F06630 Offset: 0x1F05030 VA: 0x181F06630
	private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x1F06630 Offset: 0x1F05030 VA: 0x181F06630
	private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x1F06B40 Offset: 0x1F05540 VA: 0x181F06B40
	private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x1F07A90 Offset: 0x1F06490 VA: 0x181F07A90
	public void OnTriggerEnter(Collider c) { }

	// RVA: 0x1F07BA0 Offset: 0x1F065A0 VA: 0x181F07BA0
	public void OnTriggerExit(Collider c) { }

	// RVA: 0x1F057A0 Offset: 0x1F041A0 VA: 0x181F057A0
	private bool ContactIsInRange(int index, out int bestRangeIndex) { }

	// RVA: 0x1F07400 Offset: 0x1F05E00 VA: 0x181F07400
	private void OnDrawGizmosSelected() { }

	// RVA: 0x1F0A4F0 Offset: 0x1F08EF0 VA: 0x181F0A4F0
	public void Update() { }

	// RVA: 0x1F08000 Offset: 0x1F06A00 VA: 0x181F08000
	private void Raycasting() { }

	// RVA: 0x1F0A240 Offset: 0x1F08C40 VA: 0x181F0A240
	private void UpdateTriggerEventBroadcasting() { }

	// RVA: 0x1F07520 Offset: 0x1F05F20 VA: 0x181F07520
	private void OnEnable() { }

	// RVA: 0x1F0A0A0 Offset: 0x1F08AA0 VA: 0x181F0A0A0
	private void UpdateEffectors() { }

	// RVA: 0x1F07790 Offset: 0x1F06190 VA: 0x181F07790
	private void OnPreFBBIK() { }

	// RVA: 0x1F075F0 Offset: 0x1F05FF0 VA: 0x181F075F0
	private void OnPostFBBIK() { }

	// RVA: 0x1F07540 Offset: 0x1F05F40 VA: 0x181F07540
	private void OnFixTransforms() { }

	// RVA: 0x1F06D30 Offset: 0x1F05730 VA: 0x181F06D30
	private void OnDestroy() { }

	// RVA: 0x1F06A60 Offset: 0x1F05460 VA: 0x181F06A60
	private bool IsValid(bool log) { }

	// RVA: 0x1F098A0 Offset: 0x1F082A0 VA: 0x181F098A0
	private bool TriggerIndexIsValid(int index) { }

	// RVA: 0x1F0A880 Offset: 0x1F09280 VA: 0x181F0A880
	public void .ctor() { }
}
