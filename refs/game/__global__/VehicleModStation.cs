public class VehicleModStation : MonoBehaviour // TypeDefIndex: 2203
{
	// Fields
	[Header("References")]
	[SerializeField]
	protected Transform vehiclePosition; // 0x20
	[SerializeField]
	protected OrbitCamera orbitCam; // 0x28
	[CompilerGenerated]
	private LandVehicle <currentVehicle>k__BackingField; // 0x30

	// Properties
	public LandVehicle currentVehicle { get; set; }
	public bool isOpen { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public LandVehicle get_currentVehicle() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_currentVehicle(LandVehicle value) { }

	// RVA: 0x83B490 Offset: 0x839E90 VA: 0x18083B490
	public bool get_isOpen() { }

	// RVA: 0x83AD60 Offset: 0x839760 VA: 0x18083AD60
	public void Open(LandVehicle vehicle) { }

	// RVA: 0x83B2E0 Offset: 0x839CE0 VA: 0x18083B2E0 Slot: 4
	protected virtual void Update() { }

	// RVA: 0x83AC40 Offset: 0x839640 VA: 0x18083AC40
	public void Close() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
