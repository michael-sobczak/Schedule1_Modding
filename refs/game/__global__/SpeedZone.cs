public class SpeedZone : MonoBehaviour // TypeDefIndex: 2175
{
	// Fields
	public static List<SpeedZone> speedZones; // 0x0
	public BoxCollider col; // 0x20
	public float speed; // 0x28
	private static List<SpeedZone> query; // 0x8

	// Methods

	// RVA: 0x829A50 Offset: 0x828450 VA: 0x180829A50 Slot: 4
	public virtual void Awake() { }

	// RVA: 0x829B20 Offset: 0x828520 VA: 0x180829B20
	public static IEnumerable<SpeedZone> GetSpeedZones(Vector3 point) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnDrawGizmos() { }

	// RVA: 0x829E20 Offset: 0x828820 VA: 0x180829E20
	public void .ctor() { }

	// RVA: 0x829D50 Offset: 0x828750 VA: 0x180829D50
	private static void .cctor() { }
}
