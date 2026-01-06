public class InteractionEffector // TypeDefIndex: 14141
{
	// Fields
	[CompilerGenerated]
	private FullBodyBipedEffector <effectorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <isPaused>k__BackingField; // 0x14
	[CompilerGenerated]
	private InteractionObject <interactionObject>k__BackingField; // 0x18
	private Poser poser; // 0x20
	private IKEffector effector; // 0x28
	private float timer; // 0x30
	private float length; // 0x34
	private float weight; // 0x38
	private float fadeInSpeed; // 0x3C
	private float defaultPositionWeight; // 0x40
	private float defaultRotationWeight; // 0x44
	private float defaultPull; // 0x48
	private float defaultReach; // 0x4C
	private float defaultPush; // 0x50
	private float defaultPushParent; // 0x54
	private float defaultBendGoalWeight; // 0x58
	private float defaultPoserWeight; // 0x5C
	private float resetTimer; // 0x60
	private bool positionWeightUsed; // 0x64
	private bool rotationWeightUsed; // 0x65
	private bool pullUsed; // 0x66
	private bool reachUsed; // 0x67
	private bool pushUsed; // 0x68
	private bool pushParentUsed; // 0x69
	private bool bendGoalWeightUsed; // 0x6A
	private bool poserUsed; // 0x6B
	private bool pickedUp; // 0x6C
	private bool defaults; // 0x6D
	private bool pickUpOnPostFBBIK; // 0x6E
	private Vector3 pickUpPosition; // 0x70
	private Vector3 pausePositionRelative; // 0x7C
	private Quaternion pickUpRotation; // 0x88
	private Quaternion pauseRotationRelative; // 0x98
	private InteractionTarget interactionTarget; // 0xA8
	private Transform target; // 0xB0
	private List<bool> triggered; // 0xB8
	private InteractionSystem interactionSystem; // 0xC0
	private bool started; // 0xC8

	// Properties
	public FullBodyBipedEffector effectorType { get; set; }
	public bool isPaused { get; set; }
	public InteractionObject interactionObject { get; set; }
	public bool inInteraction { get; }
	public float progress { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public FullBodyBipedEffector get_effectorType() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	private void set_effectorType(FullBodyBipedEffector value) { }

	[CompilerGenerated]
	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_isPaused() { }

	[CompilerGenerated]
	// RVA: 0x60D740 Offset: 0x60C140 VA: 0x18060D740
	private void set_isPaused(bool value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public InteractionObject get_interactionObject() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_interactionObject(InteractionObject value) { }

	// RVA: 0x1F03390 Offset: 0x1F01D90 VA: 0x181F03390
	public bool get_inInteraction() { }

	// RVA: 0x1F03300 Offset: 0x1F01D00 VA: 0x181F03300
	public void .ctor(FullBodyBipedEffector effectorType) { }

	// RVA: 0x1F00780 Offset: 0x1EFF180 VA: 0x181F00780
	public void Initiate(InteractionSystem interactionSystem) { }

	// RVA: 0x1F02390 Offset: 0x1F00D90 VA: 0x181F02390
	public void StoreDefaults() { }

	// RVA: 0x1F01500 Offset: 0x1EFFF00 VA: 0x181F01500
	public bool ResetToDefaults(float speed, float deltaTime) { }

	// RVA: 0x1F00DD0 Offset: 0x1EFF7D0 VA: 0x181F00DD0
	public bool Pause() { }

	// RVA: 0x1F01AB0 Offset: 0x1F004B0 VA: 0x181F01AB0
	public bool Resume() { }

	// RVA: 0x1F02100 Offset: 0x1F00B00 VA: 0x181F02100
	public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt) { }

	// RVA: 0x1F01B60 Offset: 0x1F00560 VA: 0x181F01B60
	public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt) { }

	// RVA: 0x1F028E0 Offset: 0x1F012E0 VA: 0x181F028E0
	public void Update(Transform root, float speed, float deltaTime) { }

	// RVA: 0x1F033E0 Offset: 0x1F01DE0 VA: 0x181F033E0
	public float get_progress() { }

	// RVA: 0x1F02620 Offset: 0x1F01020 VA: 0x181F02620
	private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause) { }

	// RVA: 0x1F01090 Offset: 0x1EFFA90 VA: 0x181F01090
	private void PickUp(Transform root) { }

	// RVA: 0x1F02210 Offset: 0x1F00C10 VA: 0x181F02210
	public bool Stop() { }

	// RVA: 0x1F00840 Offset: 0x1EFF240 VA: 0x181F00840
	public void OnPostFBBIK() { }
}
