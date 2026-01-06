public class VehicleCamera : MonoBehaviour // TypeDefIndex: 2178
{
	// Fields
	private const float followDelta = 10;
	private const float yMinLimit = -20;
	private const float manualOverrideTime = 0.01;
	private const float manualOverrideReturnTime = 0.6;
	private const float xSpeed = 60;
	private const float ySpeed = 40;
	private const float yMaxLimit = 89;
	[Header("References")]
	public LandVehicle vehicle; // 0x20
	[SerializeField]
	[Header("Camera Settings")]
	protected Transform cameraOrigin; // 0x28
	[SerializeField]
	protected float lateralOffset; // 0x30
	[SerializeField]
	protected float verticalOffset; // 0x34
	protected bool cameraReversed; // 0x38
	protected float timeSinceCameraManuallyAdjusted; // 0x3C
	protected float orbitDistance; // 0x40
	protected Vector3 lastFrameCameraOffset; // 0x44
	protected Vector3 lastManualOffset; // 0x50
	private Transform targetTransform; // 0x60
	private Transform cameraDolly; // 0x68
	private float x; // 0x70
	private float y; // 0x74
	private float mouseIdleCooldown; // 0x78
	private float mouseIdleTimer; // 0x7C

	// Properties
	private Transform cam { get; }
	private bool NeedSecondaryClick { get; }

	// Methods

	// RVA: 0x837370 Offset: 0x835D70 VA: 0x180837370
	private Transform get_cam() { }

	// RVA: 0x8372F0 Offset: 0x835CF0 VA: 0x1808372F0
	private bool get_NeedSecondaryClick() { }

	// RVA: 0x8369D0 Offset: 0x8353D0 VA: 0x1808369D0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x836E20 Offset: 0x835820 VA: 0x180836E20
	private void Subscribe() { }

	// RVA: 0x836F60 Offset: 0x835960 VA: 0x180836F60 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x836620 Offset: 0x835020 VA: 0x180836620
	private void PlayerEnteredVehicle(LandVehicle veh) { }

	// RVA: 0x834570 Offset: 0x832F70 VA: 0x180834570
	private void CheckForClick() { }

	// RVA: 0x834720 Offset: 0x833120 VA: 0x180834720
	private void CheckForMouseMovement() { }

	// RVA: 0x835EB0 Offset: 0x8348B0 VA: 0x180835EB0 Slot: 6
	protected virtual void LateUpdate() { }

	// RVA: 0x834B80 Offset: 0x833580 VA: 0x180834B80
	private void HandleNonSecondaryClickCameraMovement() { }

	// RVA: 0x835490 Offset: 0x833E90 VA: 0x180835490
	private void HandleSecondaryClickCameraMovement() { }

	// RVA: 0x834920 Offset: 0x833320 VA: 0x180834920
	private void ForceCameraReturn() { }

	// RVA: 0x5662A0 Offset: 0x564CA0 VA: 0x1805662A0
	private static float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x8349C0 Offset: 0x8333C0 VA: 0x1808349C0
	private Vector3 GetTargetCameraPosition() { }

	// RVA: 0x8362A0 Offset: 0x834CA0 VA: 0x1808362A0
	private Vector3 LimitCameraPosition(Vector3 targetPosition) { }

	// RVA: 0x837240 Offset: 0x835C40 VA: 0x180837240
	public void .ctor() { }
}
