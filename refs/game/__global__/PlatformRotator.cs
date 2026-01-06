public class PlatformRotator : MonoBehaviour // TypeDefIndex: 14284
{
	// Fields
	public float maxAngle; // 0x20
	public float switchRotationTime; // 0x24
	public float random; // 0x28
	public float rotationSpeed; // 0x2C
	public Vector3 movePosition; // 0x30
	public float moveSpeed; // 0x3C
	public int characterLayer; // 0x40
	private Quaternion defaultRotation; // 0x44
	private Quaternion targetRotation; // 0x54
	private Vector3 targetPosition; // 0x64
	private Vector3 velocity; // 0x70
	private Rigidbody r; // 0x80

	// Methods

	// RVA: 0x1F4A910 Offset: 0x1F49310 VA: 0x181F4A910
	private void Start() { }

	// RVA: 0x1F4A3C0 Offset: 0x1F48DC0 VA: 0x181F4A3C0
	private void FixedUpdate() { }

	[IteratorStateMachine(typeof(PlatformRotator.<SwitchRotation>d__14))]
	// RVA: 0x1F4AA50 Offset: 0x1F49450 VA: 0x181F4AA50
	private IEnumerator SwitchRotation() { }

	// RVA: 0x1F4A780 Offset: 0x1F49180 VA: 0x181F4A780
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x1F4A850 Offset: 0x1F49250 VA: 0x181F4A850
	private void OnCollisionExit(Collision collision) { }

	// RVA: 0x1F4AAC0 Offset: 0x1F494C0 VA: 0x181F4AAC0
	public void .ctor() { }
}
