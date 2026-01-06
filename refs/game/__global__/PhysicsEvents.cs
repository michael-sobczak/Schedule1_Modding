public class PhysicsEvents : MonoBehaviour // TypeDefIndex: 2317
{
	// Fields
	public bool DEBUG; // 0x20
	public UnityEvent<Collider> OnTriggerEnterEvent; // 0x28
	public UnityEvent<Collider> OnTriggerExitEvent; // 0x30
	public UnityEvent<Collision> OnCollisionEnterEvent; // 0x38
	public UnityEvent<Collision> OnCollisionExitEvent; // 0x40

	// Methods

	// RVA: 0x8645B0 Offset: 0x862FB0 VA: 0x1808645B0
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x8646A0 Offset: 0x8630A0 VA: 0x1808646A0
	public void OnTriggerExit(Collider other) { }

	// RVA: 0x864390 Offset: 0x862D90 VA: 0x180864390
	public void OnCollisionEnter(Collision collision) { }

	// RVA: 0x8644A0 Offset: 0x862EA0 VA: 0x1808644A0
	public void OnCollisionExit(Collision collision) { }

	// RVA: 0x864220 Offset: 0x862C20 VA: 0x180864220
	private static string GetHierarchyString(Transform transform) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
