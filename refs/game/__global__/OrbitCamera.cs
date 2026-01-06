public class OrbitCamera : MonoBehaviour // TypeDefIndex: 1920
{
	// Fields
	[Header("References")]
	[SerializeField]
	protected Transform cameraStartPoint; // 0x20
	[SerializeField]
	protected Transform centrePoint; // 0x28
	[Header("Settings")]
	public float targetFollowSpeed; // 0x30
	public float yMinLimit; // 0x34
	public float yMaxLimit; // 0x38
	public static float xSpeed; // 0x0
	public static float ySpeed; // 0x4
	[CompilerGenerated]
	private bool <isEnabled>k__BackingField; // 0x3C
	private Vector3 rotationOriginPoint; // 0x40
	private float distance; // 0x4C
	private float prevDistance; // 0x50
	private float x; // 0x54
	private float y; // 0x58
	private Transform targetTransform; // 0x60

	// Properties
	public bool isEnabled { get; set; }
	protected Transform cam { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90
	public bool get_isEnabled() { }

	[CompilerGenerated]
	// RVA: 0x66B060 Offset: 0x669A60 VA: 0x18066B060
	protected void set_isEnabled(bool value) { }

	// RVA: 0x78EC30 Offset: 0x78D630 VA: 0x18078EC30
	protected Transform get_cam() { }

	// RVA: 0x78E0C0 Offset: 0x78CAC0 VA: 0x18078E0C0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x78EB60 Offset: 0x78D560 VA: 0x18078EB60 Slot: 6
	protected virtual void Update() { }

	// RVA: 0x78E720 Offset: 0x78D120 VA: 0x18078E720 Slot: 7
	protected virtual void LateUpdate() { }

	[Button]
	// RVA: 0x78E280 Offset: 0x78CC80 VA: 0x18078E280
	public void Enable() { }

	// RVA: 0x78E190 Offset: 0x78CB90 VA: 0x18078E190
	public void Disable() { }

	// RVA: 0x78E730 Offset: 0x78D130 VA: 0x18078E730
	protected void UpdateRotation() { }

	// RVA: 0x5662A0 Offset: 0x564CA0 VA: 0x1805662A0
	private static float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x78E530 Offset: 0x78CF30 VA: 0x18078E530
	private void FinalizeCameraMovement() { }

	// RVA: 0x78EBC0 Offset: 0x78D5C0 VA: 0x18078EBC0
	public void .ctor() { }

	// RVA: 0x78EB70 Offset: 0x78D570 VA: 0x18078EB70
	private static void .cctor() { }
}
