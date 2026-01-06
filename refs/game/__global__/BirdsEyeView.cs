public class BirdsEyeView : Singleton<BirdsEyeView> // TypeDefIndex: 1898
{
	// Fields
	[Header("Settings")]
	public Vector3 bounds_Min; // 0x28
	public Vector3 bounds_Max; // 0x34
	[Header("Camera settings")]
	public float lateralMovementSpeed; // 0x40
	public float scrollMovementSpeed; // 0x44
	public float targetFollowSpeed; // 0x48
	[Header("Camera orbit settings")]
	public float xSpeed; // 0x4C
	public float ySpeed; // 0x50
	public float yMinLimit; // 0x54
	public float yMaxLimit; // 0x58
	private Vector3 rotationOriginPoint; // 0x5C
	private float distance; // 0x68
	private float prevDistance; // 0x6C
	private float x; // 0x70
	private float y; // 0x74
	private Transform targetTransform; // 0x78
	[CompilerGenerated]
	private bool <isEnabled>k__BackingField; // 0x80
	private Coroutine originSlideRoutine; // 0x88

	// Properties
	private Transform playerCam { get; }
	public bool isEnabled { get; set; }

	// Methods

	// RVA: 0x7798F0 Offset: 0x7782F0 VA: 0x1807798F0
	private Transform get_playerCam() { }

	[CompilerGenerated]
	// RVA: 0x7798E0 Offset: 0x7782E0 VA: 0x1807798E0
	public bool get_isEnabled() { }

	[CompilerGenerated]
	// RVA: 0x779970 Offset: 0x778370 VA: 0x180779970
	protected void set_isEnabled(bool value) { }

	// RVA: 0x778190 Offset: 0x776B90 VA: 0x180778190 Slot: 5
	protected override void Awake() { }

	// RVA: 0x7797F0 Offset: 0x7781F0 VA: 0x1807797F0 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x7787C0 Offset: 0x7771C0 VA: 0x1807787C0 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x7783C0 Offset: 0x776DC0 VA: 0x1807783C0
	public void Enable(Vector3 startPosition, Quaternion startRotation) { }

	// RVA: 0x7782C0 Offset: 0x776CC0 VA: 0x1807782C0
	public void Disable(bool reenableCameraLook = True) { }

	// RVA: 0x778C10 Offset: 0x777610 VA: 0x180778C10
	protected void UpdateLateralMovement() { }

	// RVA: 0x779600 Offset: 0x778000 VA: 0x180779600
	protected void UpdateScrollMovement() { }

	// RVA: 0x7790C0 Offset: 0x777AC0 VA: 0x1807790C0
	protected void UpdateRotation() { }

	// RVA: 0x7785D0 Offset: 0x776FD0 VA: 0x1807785D0
	private void FinalizeCameraMovement() { }

	// RVA: 0x5662A0 Offset: 0x564CA0 VA: 0x1805662A0
	private static float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x778270 Offset: 0x776C70 VA: 0x180778270
	private void CancelOriginSlide() { }

	// RVA: 0x7787E0 Offset: 0x7771E0 VA: 0x1807787E0
	public void SlideCameraOrigin(Vector3 position, float offsetDistance, float time = 0) { }

	// RVA: 0x779830 Offset: 0x778230 VA: 0x180779830
	public void .ctor() { }
}
