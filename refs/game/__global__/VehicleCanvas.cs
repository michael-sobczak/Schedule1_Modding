public class VehicleCanvas : Singleton<VehicleCanvas> // TypeDefIndex: 2720
{
	// Fields
	[Header("References")]
	public Canvas Canvas; // 0x28
	public TextMeshProUGUI SpeedText; // 0x30
	public GameObject DriverPromptsContainer; // 0x38
	private LandVehicle currentVehicle; // 0x40

	// Methods

	// RVA: 0x91F6C0 Offset: 0x91E0C0 VA: 0x18091F6C0 Slot: 4
	protected override void Start() { }

	// RVA: 0x91F810 Offset: 0x91E210 VA: 0x18091F810
	private void Subscribe() { }

	// RVA: 0x91FB90 Offset: 0x91E590 VA: 0x18091FB90
	private void Update() { }

	// RVA: 0x91F650 Offset: 0x91E050 VA: 0x18091F650
	private void LateUpdate() { }

	// RVA: 0x91FCD0 Offset: 0x91E6D0 VA: 0x18091FCD0
	private void VehicleEntered(LandVehicle veh) { }

	// RVA: 0x91FD30 Offset: 0x91E730 VA: 0x18091FD30
	private void VehicleExited(LandVehicle veh, Transform exitPoint) { }

	// RVA: 0x91FA30 Offset: 0x91E430 VA: 0x18091FA30
	private void UpdateSpeedText() { }

	// RVA: 0x91FD70 Offset: 0x91E770 VA: 0x18091FD70
	public void .ctor() { }
}
