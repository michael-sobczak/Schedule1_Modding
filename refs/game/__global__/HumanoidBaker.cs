public class HumanoidBaker : Baker // TypeDefIndex: 14014
{
	// Fields
	[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
	public bool bakeHandIK; // 0x98
	[Range(0, 0.1)]
	[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
	public float IKKeyReductionError; // 0x9C
	[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
	[Range(1, 9)]
	public int muscleFrameRateDiv; // 0xA0
	private BakerMuscle[] bakerMuscles; // 0xA8
	private BakerHumanoidQT rootQT; // 0xB0
	private BakerHumanoidQT leftFootQT; // 0xB8
	private BakerHumanoidQT rightFootQT; // 0xC0
	private BakerHumanoidQT leftHandQT; // 0xC8
	private BakerHumanoidQT rightHandQT; // 0xD0
	private float[] muscles; // 0xD8
	private HumanPose pose; // 0xE0
	private HumanPoseHandler handler; // 0x108
	private Vector3 bodyPosition; // 0x110
	private Quaternion bodyRotation; // 0x11C
	private int mN; // 0x12C
	private Quaternion lastBodyRotation; // 0x130

	// Methods

	// RVA: 0x1EA65E0 Offset: 0x1EA4FE0 VA: 0x181EA65E0
	private void Awake() { }

	// RVA: 0x1EA6D50 Offset: 0x1EA5750 VA: 0x181EA6D50 Slot: 4
	protected override Transform GetCharacterRoot() { }

	// RVA: 0x1EA7A00 Offset: 0x1EA6400 VA: 0x181EA7A00 Slot: 5
	protected override void OnStartBaking() { }

	// RVA: 0x1EA7740 Offset: 0x1EA6140 VA: 0x181EA7740 Slot: 6
	protected override void OnSetLoopFrame(float time) { }

	// RVA: 0x1EA6D70 Offset: 0x1EA5770 VA: 0x181EA6D70 Slot: 7
	protected override void OnSetCurves(ref AnimationClip clip) { }

	// RVA: 0x1EA7140 Offset: 0x1EA5B40 VA: 0x181EA7140 Slot: 8
	protected override void OnSetKeyframes(float time, bool lastFrame) { }

	// RVA: 0x1EA7BB0 Offset: 0x1EA65B0 VA: 0x181EA7BB0
	private void UpdateHumanPose() { }

	// RVA: 0x1EA7CA0 Offset: 0x1EA66A0 VA: 0x181EA7CA0
	public void .ctor() { }
}
