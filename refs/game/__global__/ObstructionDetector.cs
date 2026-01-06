public class ObstructionDetector : MonoBehaviour // TypeDefIndex: 2172
{
	// Fields
	private LandVehicle vehicle; // 0x20
	public List<LandVehicle> vehicles; // 0x28
	public List<NPC> npcs; // 0x30
	public List<PlayerMovement> players; // 0x38
	public List<VehicleObstacle> vehicleObstacles; // 0x40
	public float closestObstructionDistance; // 0x48
	public float range; // 0x4C

	// Methods

	// RVA: 0x820F30 Offset: 0x81F930 VA: 0x180820F30 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x820FF0 Offset: 0x81F9F0 VA: 0x180820FF0 Slot: 5
	protected virtual void FixedUpdate() { }

	// RVA: 0x821970 Offset: 0x820370 VA: 0x180821970
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x821E60 Offset: 0x820860 VA: 0x180821E60
	public void .ctor() { }
}
