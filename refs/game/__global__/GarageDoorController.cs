public class GarageDoorController : MonoBehaviour // TypeDefIndex: 62
{
	// Fields
	public GarageDoorStatus doorStatus; // 0x20
	public Transform garageDoor; // 0x28
	public Quaternion targetRotation; // 0x30

	// Methods

	// RVA: 0x55E5C0 Offset: 0x55CFC0 VA: 0x18055E5C0
	private void OnTriggerStay(Collider other) { }

	[IteratorStateMachine(typeof(GarageDoorController.<Rotate>d__4))]
	// RVA: 0x55E770 Offset: 0x55D170 VA: 0x18055E770
	private IEnumerator Rotate(Vector3 axis, float angle, float duration = 1) { }

	// RVA: 0x55E820 Offset: 0x55D220 VA: 0x18055E820
	public void .ctor() { }
}
