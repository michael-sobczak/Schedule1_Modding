public class AvatarLookController : MonoBehaviour // TypeDefIndex: 3145
{
	// Fields
	public const float LookAtPlayerRange = 4;
	public const float EyeContractRange = 10;
	public const float AimIKRange = 20;
	public static Transform TempContainer; // 0x0
	public bool DEBUG; // 0x20
	[CompilerGenerated]
	private float <BodyRotationSpeedMultiplier>k__BackingField; // 0x24
	[Header("References")]
	public AimIK Aim; // 0x28
	public Transform HeadBone; // 0x30
	public Transform LookForwardTarget; // 0x38
	public Transform LookOrigin; // 0x40
	public EyeController Eyes; // 0x48
	[Header("Optional NPC reference")]
	public NPC NPC; // 0x50
	[Header("Settings")]
	public bool AutoLookAtPlayer; // 0x58
	public float LookLerpSpeed; // 0x5C
	public float AimIKWeight; // 0x60
	public float BodyRotationSpeed; // 0x64
	private Avatar avatar; // 0x68
	private Vector3 lookAtPos; // 0x70
	private Transform lookAtTarget; // 0x80
	private Vector3 lastFrameOffset; // 0x88
	private bool overrideLookAt; // 0x94
	private Vector3 overriddenLookTarget; // 0x98
	private int overrideLookPriority; // 0xA4
	private bool overrideRotateBody; // 0xA8
	private bool blockLookOverrides; // 0xA9
	private Vector3 lastFrameLookOriginPos; // 0xAC
	private Vector3 lastFrameLookOriginForward; // 0xB8
	public Transform ForceLookTarget; // 0xC8
	public bool ForceLookRotateBody; // 0xD0
	private float defaultIKWeight; // 0xD4
	private Player nearestPlayer; // 0xD8
	private float nearestPlayerDist; // 0xE0
	private float localPlayerDist; // 0xE4
	private float cullRange; // 0xE8

	// Properties
	public float BodyRotationSpeedMultiplier { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_BodyRotationSpeedMultiplier() { }

	[CompilerGenerated]
	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	public void set_BodyRotationSpeedMultiplier(float value) { }

	// RVA: 0x9AFD20 Offset: 0x9AE720 VA: 0x1809AFD20
	private void Awake() { }

	// RVA: 0x9B13F0 Offset: 0x9AFDF0 VA: 0x1809B13F0
	private void UpdateLook() { }

	// RVA: 0x9B1F50 Offset: 0x9B0950 VA: 0x1809B1F50
	private void UpdateNearestPlayer() { }

	// RVA: 0x9B0410 Offset: 0x9AEE10 VA: 0x1809B0410
	private void LateUpdate() { }

	// RVA: 0x9B1050 Offset: 0x9AFA50 VA: 0x1809B1050
	public void OverrideLookTarget(Vector3 targetPosition, int priority, bool rotateBody = False) { }

	// RVA: 0x9B00A0 Offset: 0x9AEAA0 VA: 0x1809B00A0
	public void BlockLookTargetOverrides() { }

	// RVA: 0x9B0ED0 Offset: 0x9AF8D0 VA: 0x1809B0ED0
	private void LookForward() { }

	// RVA: 0x9B0B50 Offset: 0x9AF550 VA: 0x1809B0B50
	private void LerpTargetTransform() { }

	// RVA: 0x9B0300 Offset: 0x9AED00 VA: 0x1809B0300
	private Player GetNearestPlayer() { }

	// RVA: 0x9B00B0 Offset: 0x9AEAB0 VA: 0x1809B00B0
	private bool CanLookAt(Vector3 position) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim) { }

	// RVA: 0x9B1020 Offset: 0x9AFA20 VA: 0x1809B1020
	public void OverrideIKWeight(float weight) { }

	// RVA: 0x9B1270 Offset: 0x9AFC70 VA: 0x1809B1270
	public void ResetIKWeight() { }

	// RVA: 0x9B23B0 Offset: 0x9B0DB0 VA: 0x1809B23B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x9B12B0 Offset: 0x9AFCB0 VA: 0x1809B12B0
	private float <GetNearestPlayer>b__45_0(Player p) { }
}
