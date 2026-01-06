public class CameraOrbit : MonoBehaviour // TypeDefIndex: 1899
{
	// Fields
	[Header("Required")]
	public Transform target; // 0x20
	public Transform cam; // 0x28
	public GraphicRaycaster raycaster; // 0x30
	public AvatarLookController LookAt; // 0x38
	[Header("Config")]
	public float targetdistance; // 0x40
	public float xSpeed; // 0x44
	public float ySpeed; // 0x48
	public float sideOffset; // 0x4C
	public float yMinLimit; // 0x50
	public float yMaxLimit; // 0x54
	public float distanceMin; // 0x58
	public float distanceMax; // 0x5C
	public float ScrollSensativity; // 0x60
	private Rigidbody rb; // 0x68
	private float x; // 0x70
	private float y; // 0x74
	private float targetx; // 0x78
	private float targety; // 0x7C
	private float distance; // 0x80
	private bool hoveringUI; // 0x84

	// Methods

	// RVA: 0x77A110 Offset: 0x778B10 VA: 0x18077A110
	private void Start() { }

	// RVA: 0x77A1F0 Offset: 0x778BF0 VA: 0x18077A1F0
	private void Update() { }

	// RVA: 0x779980 Offset: 0x778380 VA: 0x180779980
	private void LateUpdate() { }

	// RVA: 0x5662A0 Offset: 0x564CA0 VA: 0x1805662A0
	public static float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x77A3A0 Offset: 0x778DA0 VA: 0x18077A3A0
	public void .ctor() { }
}
