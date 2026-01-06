public class LocalPlayerFootstepGenerator : MonoBehaviour // TypeDefIndex: 1318
{
	// Fields
	public float DistancePerStep; // 0x20
	public Transform ReferencePoint; // 0x28
	public LayerMask GroundDetectionMask; // 0x30
	public UnityEvent<EMaterialType, float> onStep; // 0x38
	private float currentDistance; // 0x40
	private Vector3 lastFramePosition; // 0x44

	// Methods

	// RVA: 0x6438A0 Offset: 0x6422A0 VA: 0x1806438A0
	private void LateUpdate() { }

	// RVA: 0x643C20 Offset: 0x642620 VA: 0x180643C20
	public void TriggerStep() { }

	// RVA: 0x6435B0 Offset: 0x641FB0 VA: 0x1806435B0
	public bool IsGrounded(out EMaterialType surfaceType) { }

	// RVA: 0x643D00 Offset: 0x642700 VA: 0x180643D00
	public void .ctor() { }
}
