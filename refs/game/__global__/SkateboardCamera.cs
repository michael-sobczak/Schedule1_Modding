public class SkateboardCamera : NetworkBehaviour // TypeDefIndex: 680
{
	// Fields
	private const float followDelta = 7.5;
	private const float yMinLimit = -20;
	private const float manualOverrideTime = 0.01;
	private const float manualOverrideReturnTime = 0.6;
	private const float xSpeed = 60;
	private const float ySpeed = 40;
	private const float yMaxLimit = 89;
	[Header("References")]
	public Transform cameraOrigin; // 0x118
	[Header("Settings")]
	public float CameraFollowSpeed; // 0x120
	public float HorizontalOffset; // 0x124
	public float VerticalOffset; // 0x128
	public float CameraDownAngle; // 0x12C
	[Header("Settings")]
	public float FOVMultiplier_MinSpeed; // 0x130
	public float FOVMultiplier_MaxSpeed; // 0x134
	public float FOVMultiplierChangeRate; // 0x138
	private Skateboard board; // 0x140
	private float currentFovMultiplier; // 0x148
	private bool cameraReversed; // 0x14C
	private bool cameraAdjusted; // 0x14D
	private float timeSinceCameraManuallyAdjusted; // 0x150
	private float orbitDistance; // 0x154
	private Vector3 lastFrameCameraOffset; // 0x158
	private Vector3 lastManualOffset; // 0x164
	private Transform targetTransform; // 0x170
	private Transform cameraDolly; // 0x178
	private float x; // 0x180
	private float y; // 0x184
	private float mouseIdleCooldown; // 0x188
	private float mouseIdleTimer; // 0x18C
	private bool NetworkInitialize___EarlyScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted; // 0x190
	private bool NetworkInitialize__LateScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted; // 0x191

	// Properties
	private Transform cam { get; }
	private bool NeedSecondaryClick { get; }

	// Methods

	// RVA: 0xAC2B90 Offset: 0xAC1590 VA: 0x180AC2B90
	private Transform get_cam() { }

	// RVA: 0xAC2B10 Offset: 0xAC1510 VA: 0x180AC2B10
	private bool get_NeedSecondaryClick() { }

	// RVA: 0xABFAA0 Offset: 0xABE4A0 VA: 0x180ABFAA0 Slot: 19
	public override void Awake() { }

	// RVA: 0xAC1CA0 Offset: 0xAC06A0 VA: 0x180AC1CA0
	private void OnPlayerMountedSkateboard(Skateboard skateboard) { }

	// RVA: 0xAC2050 Offset: 0xAC0A50 VA: 0x180AC2050 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0xAC1AA0 Offset: 0xAC04A0 VA: 0x180AC1AA0
	private void OnDestroy() { }

	// RVA: 0xAC26E0 Offset: 0xAC10E0 VA: 0x180AC26E0
	private void Update() { }

	// RVA: 0xABFAF0 Offset: 0xABE4F0 VA: 0x180ABFAF0
	private void CheckForClick() { }

	// RVA: 0xABFCE0 Offset: 0xABE6E0 VA: 0x180ABFCE0
	private void CheckForMouseMovement() { }

	// RVA: 0xAC1640 Offset: 0xAC0040 VA: 0x180AC1640
	private void LateUpdate() { }

	// RVA: 0xAC20A0 Offset: 0xAC0AA0 VA: 0x180AC20A0
	private void UpdateCamera() { }

	// RVA: 0xAC0240 Offset: 0xABEC40 VA: 0x180AC0240
	private void HandleNonSecondaryClickCameraMovement() { }

	// RVA: 0xAC0BB0 Offset: 0xABF5B0 VA: 0x180AC0BB0
	private void HandleSecondaryClickCameraMovement() { }

	// RVA: 0xAC2480 Offset: 0xAC0E80 VA: 0x180AC2480
	private void UpdateFOV() { }

	// RVA: 0xABFF00 Offset: 0xABE900 VA: 0x180ABFF00
	private void ForceCameraReturn() { }

	// RVA: 0x5662A0 Offset: 0x564CA0 VA: 0x1805662A0
	private static float ClampAngle(float angle, float min, float max) { }

	// RVA: 0xABFFC0 Offset: 0xABE9C0 VA: 0x180ABFFC0
	private Vector3 GetTargetCameraPosition() { }

	// RVA: 0xAC16D0 Offset: 0xAC00D0 VA: 0x180AC16D0
	private Vector3 LimitCameraPosition(Vector3 targetPosition) { }

	// RVA: 0xAC2A10 Offset: 0xAC1410 VA: 0x180AC2A10
	public void .ctor() { }

	// RVA: 0xAC1A80 Offset: 0xAC0480 VA: 0x180AC1A80 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0xAC1A60 Offset: 0xAC0460 VA: 0x180AC1A60 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xABF730 Offset: 0xABE130 VA: 0x180ABF730
	private void Awake_UserLogic_ScheduleOne.Skating.SkateboardCamera_Assembly-CSharp.dll() { }
}
