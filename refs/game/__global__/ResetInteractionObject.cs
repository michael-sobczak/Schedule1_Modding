public class ResetInteractionObject : MonoBehaviour // TypeDefIndex: 14274
{
	// Fields
	public float resetDelay; // 0x20
	private Vector3 defaultPosition; // 0x24
	private Quaternion defaultRotation; // 0x30
	private Transform defaultParent; // 0x40
	private Rigidbody r; // 0x48

	// Methods

	// RVA: 0x1F4AF40 Offset: 0x1F49940 VA: 0x181F4AF40
	private void Start() { }

	// RVA: 0x1F4AE10 Offset: 0x1F49810 VA: 0x181F4AE10
	private void OnPickUp(Transform t) { }

	[IteratorStateMachine(typeof(ResetInteractionObject.<ResetObject>d__7))]
	// RVA: 0x1F4AEC0 Offset: 0x1F498C0 VA: 0x181F4AEC0
	private IEnumerator ResetObject(float resetTime) { }

	// RVA: 0x55D3D0 Offset: 0x55BDD0 VA: 0x18055D3D0
	public void .ctor() { }
}
