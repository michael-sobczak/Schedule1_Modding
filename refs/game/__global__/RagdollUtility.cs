public class RagdollUtility : MonoBehaviour // TypeDefIndex: 14168
{
	// Fields
	[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
	public IK ik; // 0x20
	[Tooltip("How long does it take to blend from ragdoll to animation?")]
	public float ragdollToAnimationTime; // 0x28
	[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
	public bool applyIkOnRagdoll; // 0x2C
	[Tooltip("How much velocity transfer from animation to ragdoll?")]
	public float applyVelocity; // 0x30
	[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
	public float applyAngularVelocity; // 0x34
	private Animator animator; // 0x38
	private RagdollUtility.Rigidbone[] rigidbones; // 0x40
	private RagdollUtility.Child[] children; // 0x48
	private bool enableRagdollFlag; // 0x50
	private AnimatorUpdateMode animatorUpdateMode; // 0x54
	private IK[] allIKComponents; // 0x58
	private bool[] fixTransforms; // 0x60
	private float ragdollWeight; // 0x68
	private float ragdollWeightV; // 0x6C
	private bool fixedFrame; // 0x70
	private bool[] disabledIKComponents; // 0x78

	// Properties
	private bool isRagdoll { get; }
	private bool ikUsed { get; }

	// Methods

	// RVA: 0x1F265A0 Offset: 0x1F24FA0 VA: 0x181F265A0
	public void EnableRagdoll() { }

	// RVA: 0x1F264B0 Offset: 0x1F24EB0 VA: 0x181F264B0
	public void DisableRagdoll() { }

	// RVA: 0x1F27100 Offset: 0x1F25B00 VA: 0x181F27100
	public void Start() { }

	[IteratorStateMachine(typeof(RagdollUtility.<DisableRagdollSmooth>d__21))]
	// RVA: 0x1F26440 Offset: 0x1F24E40 VA: 0x181F26440
	private IEnumerator DisableRagdollSmooth() { }

	// RVA: 0x1F27740 Offset: 0x1F26140 VA: 0x181F27740
	private void Update() { }

	// RVA: 0x1F26830 Offset: 0x1F25230 VA: 0x181F26830
	private void FixedUpdate() { }

	// RVA: 0x1F268B0 Offset: 0x1F252B0 VA: 0x181F268B0
	private void LateUpdate() { }

	// RVA: 0x1F26410 Offset: 0x1F24E10 VA: 0x181F26410
	private void AfterLastIK() { }

	// RVA: 0x1F26390 Offset: 0x1F24D90 VA: 0x181F26390
	private void AfterAnimation() { }

	// RVA: 0x1F26AE0 Offset: 0x1F254E0 VA: 0x181F26AE0
	private void OnFinalPose() { }

	// RVA: 0x1F26CE0 Offset: 0x1F256E0 VA: 0x181F26CE0
	private void RagdollEnabler() { }

	// RVA: 0x1F27C90 Offset: 0x1F26690 VA: 0x181F27C90
	private bool get_isRagdoll() { }

	// RVA: 0x1F26F70 Offset: 0x1F25970 VA: 0x181F26F70
	private void RecordVelocities() { }

	// RVA: 0x1F27B50 Offset: 0x1F26550 VA: 0x181F27B50
	private bool get_ikUsed() { }

	// RVA: 0x1F27690 Offset: 0x1F26090 VA: 0x181F27690
	private void StoreLocalState() { }

	// RVA: 0x1F26610 Offset: 0x1F25010 VA: 0x181F26610
	private void FixTransforms(float weight) { }

	// RVA: 0x1F26980 Offset: 0x1F25380 VA: 0x181F26980
	private void OnDestroy() { }

	// RVA: 0x1F27A40 Offset: 0x1F26440 VA: 0x181F27A40
	public void .ctor() { }
}
