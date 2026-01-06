public class PlayerPusher : MonoBehaviour // TypeDefIndex: 2174
{
	// Fields
	private LandVehicle veh; // 0x20
	[Header("Settings")]
	public float MinSpeedToPush; // 0x28
	public float MaxPushSpeed; // 0x2C
	public float MinPushForce; // 0x30
	public float MaxPushForce; // 0x34
	private Collider collider; // 0x38

	// Methods

	// RVA: 0x828860 Offset: 0x827260 VA: 0x180828860
	private void Awake() { }

	// RVA: 0x828930 Offset: 0x827330 VA: 0x180828930
	private void OnDestroy() { }

	// RVA: 0x828CB0 Offset: 0x8276B0 VA: 0x180828CB0
	public void SetEnabled(bool isEnabled) { }

	// RVA: 0x828960 Offset: 0x827360 VA: 0x180828960
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x828CD0 Offset: 0x8276D0 VA: 0x180828CD0
	public void .ctor() { }
}
