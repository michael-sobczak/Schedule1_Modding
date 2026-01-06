public class SkateboardAnimation : MonoBehaviour // TypeDefIndex: 678
{
	// Fields
	[Header("Settings")]
	public float JumpCrouchAmount; // 0x20
	public float CrouchSpeed; // 0x24
	public float ArmLiftRate; // 0x28
	public float PelvisMaxRotation; // 0x2C
	public float HandsMaxRotation; // 0x30
	public float PelvisOffsetBlend; // 0x34
	public float VerticalMomentumMultiplier; // 0x38
	public float VerticalMomentumOffsetClamp; // 0x3C
	public float MomentumMoveSpeed; // 0x40
	public float IKBlendChangeRate; // 0x44
	public float PushAnimationDuration; // 0x48
	public float PushAnimationSpeed; // 0x4C
	public AnimationClip PushAnim; // 0x50
	[Header("References")]
	public SkateboardAnimation.AlignmentSet PelvisContainerAlignment; // 0x58
	public SkateboardAnimation.AlignmentSet PelvisAlignment; // 0x60
	public SkateboardAnimation.AlignmentSet SpineContainerAlignment; // 0x68
	public SkateboardAnimation.AlignmentSet SpineAlignment; // 0x70
	public Transform SpineAlignment_Hunched; // 0x78
	public SkateboardAnimation.AlignmentSet LeftFootAlignment; // 0x80
	public SkateboardAnimation.AlignmentSet RightFootAlignment; // 0x88
	public SkateboardAnimation.AlignmentSet LeftLegBendTarget; // 0x90
	public SkateboardAnimation.AlignmentSet RightLegBendTarget; // 0x98
	public SkateboardAnimation.AlignmentSet LeftHandAlignment; // 0xA0
	public SkateboardAnimation.AlignmentSet RightHandAlignment; // 0xA8
	public Transform AvatarFaceTarget; // 0xB0
	public Transform HandContainer; // 0xB8
	public Animation IKAnimation; // 0xC0
	[Header("Arm Lift")]
	public SkateboardAnimation.AlignmentSet LeftHandLoweredAlignment; // 0xC8
	public SkateboardAnimation.AlignmentSet LeftHandRaisedAlignment; // 0xD0
	public SkateboardAnimation.AlignmentSet RightHandLoweredAlignment; // 0xD8
	public SkateboardAnimation.AlignmentSet RightHandRaisedAlignment; // 0xE0
	private Skateboard board; // 0xE8
	private float currentCrouchShift; // 0xF0
	private float targetArmLift; // 0xF4
	private float currentArmLift; // 0xF8
	private Quaternion pelvisDefaultRotation; // 0xFC
	private Vector3 pelvisDefaultPosition; // 0x10C
	private Vector3 spineDefaultPosition; // 0x118
	private float currentMomentumOffset; // 0x124
	private float ikBlend; // 0x128
	private List<SkateboardAnimation.AlignmentSet> alignmentSets; // 0x130

	// Properties
	public float CurrentCrouchShift { get; }

	// Methods

	// RVA: 0xABF1D0 Offset: 0xABDBD0 VA: 0x180ABF1D0
	public float get_CurrentCrouchShift() { }

	// RVA: 0xABD830 Offset: 0xABC230 VA: 0x180ABD830
	private void Awake() { }

	// RVA: 0xABF0F0 Offset: 0xABDAF0 VA: 0x180ABF0F0
	private void Update() { }

	// RVA: 0xABDFE0 Offset: 0xABC9E0 VA: 0x180ABDFE0
	private void LateUpdate() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void FixedUpdate() { }

	// RVA: 0xABEA20 Offset: 0xABD420 VA: 0x180ABEA20
	private void UpdateIKBlend() { }

	// RVA: 0xABE620 Offset: 0xABD020 VA: 0x180ABE620
	private void UpdateBodyAlignment() { }

	// RVA: 0xABE0C0 Offset: 0xABCAC0 VA: 0x180ABE0C0
	private void UpdateArmLift() { }

	// RVA: 0xABEDE0 Offset: 0xABD7E0 VA: 0x180ABEDE0
	private void UpdatePelvisRotation() { }

	// RVA: 0xABE0B0 Offset: 0xABCAB0 VA: 0x180ABE0B0
	public void SetArmLift(float lift) { }

	// RVA: 0xABE010 Offset: 0xABCA10 VA: 0x180ABE010
	private void OnPushStart() { }

	// RVA: 0xABF100 Offset: 0xABDB00 VA: 0x180ABF100
	public void .ctor() { }
}
