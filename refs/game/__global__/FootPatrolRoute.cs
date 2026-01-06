public class FootPatrolRoute : MonoBehaviour // TypeDefIndex: 1839
{
	// Fields
	[Header("Settings")]
	public string RouteName; // 0x20
	public Color PathColor; // 0x28
	public Transform[] Waypoints; // 0x38
	public int StartWaypointIndex; // 0x40

	// Methods

	// RVA: 0x762C00 Offset: 0x761600 VA: 0x180762C00
	private void OnDrawGizmos() { }

	// RVA: 0x763100 Offset: 0x761B00 VA: 0x180763100
	private void OnValidate() { }

	// RVA: 0x763100 Offset: 0x761B00 VA: 0x180763100
	private void UpdateWaypoints() { }

	// RVA: 0x7631B0 Offset: 0x761BB0 VA: 0x1807631B0
	public void .ctor() { }
}
