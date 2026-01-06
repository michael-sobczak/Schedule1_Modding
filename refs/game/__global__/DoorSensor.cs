public class DoorSensor : MonoBehaviour // TypeDefIndex: 1539
{
	// Fields
	public const float ActivationDistance = 30;
	public EDoorSide DetectorSide; // 0x20
	public DoorController Door; // 0x28
	private Collider collider; // 0x30
	private List<Collider> exclude; // 0x38
	private List<NPC> npcsInContact; // 0x40
	private List<Player> playersInContact; // 0x48

	// Methods

	// RVA: 0x6F6560 Offset: 0x6F4F60 VA: 0x1806F6560
	private void Awake() { }

	// RVA: 0x6F6B70 Offset: 0x6F5570 VA: 0x1806F6B70
	private void UpdateCollider() { }

	// RVA: 0x6F6680 Offset: 0x6F5080 VA: 0x1806F6680
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x6F69A0 Offset: 0x6F53A0 VA: 0x1806F69A0
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x6F65E0 Offset: 0x6F4FE0 VA: 0x1806F65E0
	private void FixedUpdate() { }

	// RVA: 0x6F6E40 Offset: 0x6F5840 VA: 0x1806F6E40
	public void .ctor() { }
}
