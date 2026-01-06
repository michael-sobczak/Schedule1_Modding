public class ParkingLot : MonoBehaviour, IGUIDRegisterable // TypeDefIndex: 3351
{
	// Fields
	[SerializeField]
	protected string BakedGUID; // 0x20
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x28
	[Header("READONLY")]
	public List<ParkingSpot> ParkingSpots; // 0x38
	[Header("Entry")]
	public Transform EntryPoint; // 0x40
	public Transform HiddenVehicleAccessPoint; // 0x48
	[Header("Exit")]
	public bool UseExitPoint; // 0x50
	public EParkingAlignment ExitAlignment; // 0x54
	public Transform ExitPoint; // 0x58
	public VehicleDetector ExitPointVehicleDetector; // 0x60

	// Properties
	public Guid GUID { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510 Slot: 4
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x4F58C0 Offset: 0x4F42C0 VA: 0x1804F58C0
	protected void set_GUID(Guid value) { }

	// RVA: 0xA527E0 Offset: 0xA511E0 VA: 0x180A527E0
	private void Awake() { }

	// RVA: 0xA52DA0 Offset: 0xA517A0 VA: 0x180A52DA0 Slot: 6
	public void SetGUID(Guid guid) { }

	// RVA: 0xA52C90 Offset: 0xA51690 VA: 0x180A52C90
	public ParkingSpot GetRandomFreeSpot() { }

	// RVA: 0xA52BD0 Offset: 0xA515D0 VA: 0x180A52BD0
	public int GetRandomFreeSpotIndex() { }

	// RVA: 0xA52A40 Offset: 0xA51440 VA: 0x180A52A40
	public List<ParkingSpot> GetFreeParkingSpots() { }

	// RVA: 0xA52E00 Offset: 0xA51800 VA: 0x180A52E00
	public void .ctor() { }
}
