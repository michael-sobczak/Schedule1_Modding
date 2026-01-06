public class SmoothCameraOrbit : MonoBehaviour // TypeDefIndex: 73
{
	// Fields
	public Transform target; // 0x20
	public Vector3 targetOffset; // 0x28
	public float distance; // 0x34
	public float maxDistance; // 0x38
	public float minDistance; // 0x3C
	public float xSpeed; // 0x40
	public float ySpeed; // 0x44
	public int yMinLimit; // 0x48
	public int yMaxLimit; // 0x4C
	public int zoomRate; // 0x50
	public float panSpeed; // 0x54
	public float zoomDampening; // 0x58
	public float autoRotate; // 0x5C
	public float autoRotateSpeed; // 0x60
	private float xDeg; // 0x64
	private float yDeg; // 0x68
	private float currentDistance; // 0x6C
	private float desiredDistance; // 0x70
	private Quaternion currentRotation; // 0x74
	private Quaternion desiredRotation; // 0x84
	private Quaternion rotation; // 0x94
	private Vector3 position; // 0xA4
	private float idleTimer; // 0xB0
	private float idleSmooth; // 0xB4

	// Methods

	// RVA: 0x566D80 Offset: 0x565780 VA: 0x180566D80
	private void Start() { }

	// RVA: 0x566D80 Offset: 0x565780 VA: 0x180566D80
	private void OnEnable() { }

	// RVA: 0x5662E0 Offset: 0x564CE0 VA: 0x1805662E0
	public void Init() { }

	// RVA: 0x566750 Offset: 0x565150 VA: 0x180566750
	private void LateUpdate() { }

	// RVA: 0x5662A0 Offset: 0x564CA0 VA: 0x1805662A0
	private static float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x566D90 Offset: 0x565790 VA: 0x180566D90
	public void .ctor() { }
}
