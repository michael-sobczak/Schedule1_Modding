public class CameraController : MonoBehaviour // TypeDefIndex: 14016
{
	// Fields
	public Transform target; // 0x20
	public Transform rotationSpace; // 0x28
	public CameraController.UpdateMode updateMode; // 0x30
	public bool lockCursor; // 0x34
	[Header("Position")]
	public bool smoothFollow; // 0x35
	public Vector3 offset; // 0x38
	public float followSpeed; // 0x44
	[Header("Rotation")]
	public float rotationSensitivity; // 0x48
	public float yMinLimit; // 0x4C
	public float yMaxLimit; // 0x50
	public bool rotateAlways; // 0x54
	public bool rotateOnLeftButton; // 0x55
	public bool rotateOnRightButton; // 0x56
	public bool rotateOnMiddleButton; // 0x57
	[Header("Distance")]
	public float distance; // 0x58
	public float minDistance; // 0x5C
	public float maxDistance; // 0x60
	public float zoomSpeed; // 0x64
	public float zoomSensitivity; // 0x68
	[Header("Blocking")]
	public LayerMask blockingLayers; // 0x6C
	public float blockingRadius; // 0x70
	public float blockingSmoothTime; // 0x74
	public float blockingOriginOffset; // 0x78
	[Range(0, 1)]
	public float blockedOffset; // 0x7C
	[CompilerGenerated]
	private float <x>k__BackingField; // 0x80
	[CompilerGenerated]
	private float <y>k__BackingField; // 0x84
	[CompilerGenerated]
	private float <distanceTarget>k__BackingField; // 0x88
	private Vector3 targetDistance; // 0x8C
	private Vector3 position; // 0x98
	private Quaternion rotation; // 0xA4
	private Vector3 smoothPosition; // 0xB4
	private Camera cam; // 0xC0
	private bool fixedFrame; // 0xC8
	private float fixedDeltaTime; // 0xCC
	private Quaternion r; // 0xD0
	private Vector3 lastUp; // 0xE0
	private float blockedDistance; // 0xEC
	private float blockedDistanceV; // 0xF0

	// Properties
	public float x { get; set; }
	public float y { get; set; }
	public float distanceTarget { get; set; }
	private float zoomAdd { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6A5300 Offset: 0x6A3D00 VA: 0x1806A5300
	public float get_x() { }

	[CompilerGenerated]
	// RVA: 0xA546B0 Offset: 0xA530B0 VA: 0x180A546B0
	private void set_x(float value) { }

	[CompilerGenerated]
	// RVA: 0x9B5520 Offset: 0x9B3F20 VA: 0x1809B5520
	public float get_y() { }

	[CompilerGenerated]
	// RVA: 0x1EA3850 Offset: 0x1EA2250 VA: 0x181EA3850
	private void set_y(float value) { }

	[CompilerGenerated]
	// RVA: 0x6A5250 Offset: 0x6A3C50 VA: 0x1806A5250
	public float get_distanceTarget() { }

	[CompilerGenerated]
	// RVA: 0x143F250 Offset: 0x143DC50 VA: 0x18143F250
	private void set_distanceTarget(float value) { }

	// RVA: 0x1EA2970 Offset: 0x1EA1370 VA: 0x181EA2970
	public void SetAngles(Quaternion rotation) { }

	// RVA: 0x1EA2950 Offset: 0x1EA1350 VA: 0x181EA2950
	public void SetAngles(float yaw, float pitch) { }

	// RVA: 0x1EA26F0 Offset: 0x1EA10F0 VA: 0x181EA26F0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1EA36B0 Offset: 0x1EA20B0 VA: 0x181EA36B0 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x1EA2880 Offset: 0x1EA1280 VA: 0x181EA2880 Slot: 6
	protected virtual void FixedUpdate() { }

	// RVA: 0x1EA28E0 Offset: 0x1EA12E0 VA: 0x181EA28E0 Slot: 7
	protected virtual void LateUpdate() { }

	// RVA: 0x1EA2A10 Offset: 0x1EA1410 VA: 0x181EA2A10
	public void UpdateInput() { }

	// RVA: 0x1EA3680 Offset: 0x1EA2080 VA: 0x181EA3680
	public void UpdateTransform() { }

	// RVA: 0x1EA2BF0 Offset: 0x1EA15F0 VA: 0x181EA2BF0
	public void UpdateTransform(float deltaTime) { }

	// RVA: 0x1EA37F0 Offset: 0x1EA21F0 VA: 0x181EA37F0
	private float get_zoomAdd() { }

	// RVA: 0x1EA23A0 Offset: 0x1EA0DA0 VA: 0x181EA23A0
	private float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x1EA36E0 Offset: 0x1EA20E0 VA: 0x181EA36E0
	public void .ctor() { }
}
