public class AvatarAnimation : MonoBehaviour // TypeDefIndex: 3142
{
	// Fields
	public const bool ImpostorsEnabled = True;
	public const float AnimationRangeSqr = 2025;
	public const float FrustrumCullMinDist = 225;
	public const float RunningAnimationSpeed = 8;
	public const float MaxBoneOffset = 0.01;
	public const float MaxBoneOffsetSqr = 0.0001;
	public static Vector3 SITTING_OFFSET; // 0x0
	public const float SEAT_TIME = 0.5;
	private const string StandUpFromBackClipName = "Stand up from back";
	private const string StandUpFromFrontClipName = "Stand up from front";
	[CompilerGenerated]
	private bool <IsCrouched>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <TimeSinceSitEnd>k__BackingField; // 0x24
	[CompilerGenerated]
	private AvatarSeat <CurrentSeat>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <StandUpAnimationPlaying>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsAvatarCulled>k__BackingField; // 0x31
	public bool DEBUG_MODE; // 0x32
	[Header("References")]
	public Animator animator; // 0x38
	public Transform HipBone; // 0x40
	public Transform[] Bones; // 0x48
	protected Avatar avatar; // 0x50
	public Transform LeftHandContainer; // 0x58
	public Transform RightHandContainer; // 0x60
	public Transform RightHandAlignmentPoint; // 0x68
	public Transform LeftHandAlignmentPoint; // 0x70
	public AvatarIKController IKController; // 0x78
	[Header("Settings")]
	public LayerMask GroundingMask; // 0x80
	public bool AllowCulling; // 0x84
	public UnityEvent onStandupStart; // 0x88
	public UnityEvent onStandupDone; // 0x90
	public UnityEvent onHeavyFlinch; // 0x98
	private BoneTransform[] standUpFromBackBoneTransforms; // 0xA0
	private BoneTransform[] standUpFromFrontBoneTransforms; // 0xA8
	private BoneTransform[] ragdollBoneTransforms; // 0xB0
	private Coroutine standUpRoutine; // 0xB8
	private Coroutine seatRoutine; // 0xC0
	private Skateboard activeSkateboard; // 0xC8
	private bool animationEnabled; // 0xD0

	// Properties
	public bool IsCrouched { get; set; }
	public bool IsSeated { get; }
	public float TimeSinceSitEnd { get; set; }
	public AvatarSeat CurrentSeat { get; set; }
	public bool StandUpAnimationPlaying { get; set; }
	public bool IsAvatarCulled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsCrouched() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsCrouched(bool value) { }

	// RVA: 0x9ABEA0 Offset: 0x9AA8A0 VA: 0x1809ABEA0
	public bool get_IsSeated() { }

	[CompilerGenerated]
	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_TimeSinceSitEnd() { }

	[CompilerGenerated]
	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	protected void set_TimeSinceSitEnd(float value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public AvatarSeat get_CurrentSeat() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	protected void set_CurrentSeat(AvatarSeat value) { }

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_StandUpAnimationPlaying() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	protected void set_StandUpAnimationPlaying(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	public bool get_IsAvatarCulled() { }

	[CompilerGenerated]
	// RVA: 0x50AAE0 Offset: 0x5094E0 VA: 0x18050AAE0
	private void set_IsAvatarCulled(bool value) { }

	// RVA: 0x9A91E0 Offset: 0x9A7BE0 VA: 0x1809A91E0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x9AB3F0 Offset: 0x9A9DF0 VA: 0x1809AB3F0
	private void Start() { }

	// RVA: 0x9ABBF0 Offset: 0x9AA5F0 VA: 0x1809ABBF0
	private void Update() { }

	// RVA: 0x9AB680 Offset: 0x9AA080 VA: 0x1809AB680
	private void UpdateAnimationActive() { }

	// RVA: 0x9AA390 Offset: 0x9A8D90 VA: 0x1809AA390
	public void SetDirection(float dir) { }

	// RVA: 0x9AAA10 Offset: 0x9A9410 VA: 0x1809AAA10
	public void SetStrafe(float strafe) { }

	// RVA: 0x9AAA90 Offset: 0x9A9490 VA: 0x1809AAA90
	public void SetTimeAirborne(float airbone) { }

	// RVA: 0x9AA300 Offset: 0x9A8D00 VA: 0x1809AA300
	public void SetCrouched(bool crouched) { }

	// RVA: 0x9AA410 Offset: 0x9A8E10 VA: 0x1809AA410
	public void SetGrounded(bool grounded) { }

	// RVA: 0x9A98F0 Offset: 0x9A82F0 VA: 0x1809A98F0
	public void Jump() { }

	// RVA: 0x9AA160 Offset: 0x9A8B60 VA: 0x1809AA160
	public void SetAnimationEnabled(bool enabled) { }

	// RVA: 0x9A95F0 Offset: 0x9A7FF0 VA: 0x1809A95F0
	public void Flinch(Vector3 forceDirection, AvatarAnimation.EFlinchType flinchType) { }

	// RVA: 0x9A9960 Offset: 0x9A8360 VA: 0x1809A9960
	public void PlayStandUpAnimation() { }

	// RVA: 0x9A9EF0 Offset: 0x9A88F0 VA: 0x1809A9EF0
	protected void RagdollChange(bool wasRagdolled, bool ragdoll, bool playStandUpAnim) { }

	// RVA: 0x9A8CE0 Offset: 0x9A76E0 VA: 0x1809A8CE0
	private void AlignPositionToHips() { }

	// RVA: 0x9AABE0 Offset: 0x9A95E0 VA: 0x1809AABE0
	private bool ShouldGetUpFromBack() { }

	// RVA: 0x9A9DD0 Offset: 0x9A87D0 VA: 0x1809A9DD0
	private void PopulateBoneTransforms(BoneTransform[] boneTransforms) { }

	// RVA: 0x9A9B70 Offset: 0x9A8570 VA: 0x1809A9B70
	private void PopulateAnimationStartBoneTransforms(string clipName, BoneTransform[] boneTransforms) { }

	// RVA: 0x9AAB10 Offset: 0x9A9510 VA: 0x1809AAB10
	public void SetTrigger(string trigger) { }

	// RVA: 0x9AA0F0 Offset: 0x9A8AF0 VA: 0x1809AA0F0
	public void ResetTrigger(string trigger) { }

	// RVA: 0x9AA230 Offset: 0x9A8C30 VA: 0x1809AA230
	public void SetBool(string id, bool value) { }

	// RVA: 0x9AA490 Offset: 0x9A8E90 VA: 0x1809AA490
	public void SetSeat(AvatarSeat seat) { }

	// RVA: 0x9AAE70 Offset: 0x9A9870 VA: 0x1809AAE70
	public void SkateboardMounted(Skateboard board) { }

	// RVA: 0x9AAC90 Offset: 0x9A9690 VA: 0x1809AAC90
	public void SkateboardDismounted() { }

	// RVA: 0x9AB3B0 Offset: 0x9A9DB0 VA: 0x1809AB3B0
	private void SkateboardPush() { }

	// RVA: 0x9ABE80 Offset: 0x9AA880 VA: 0x1809ABE80
	public void .ctor() { }

	// RVA: 0x9ABE30 Offset: 0x9AA830 VA: 0x1809ABE30
	private static void .cctor() { }
}
