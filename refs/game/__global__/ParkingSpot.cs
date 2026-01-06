public class ParkingSpot : MonoBehaviour // TypeDefIndex: 3352
{
	// Fields
	private ParkingLot ParentLot; // 0x20
	public Transform AlignmentPoint; // 0x28
	public EParkingAlignment Alignment; // 0x30
	[SerializeField]
	private LandVehicle OccupantVehicle_Readonly; // 0x38
	[CompilerGenerated]
	private LandVehicle <OccupantVehicle>k__BackingField; // 0x40

	// Properties
	public LandVehicle OccupantVehicle { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public LandVehicle get_OccupantVehicle() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_OccupantVehicle(LandVehicle value) { }

	// RVA: 0xA52EB0 Offset: 0xA518B0 VA: 0x180A52EB0
	private void Awake() { }

	// RVA: 0xA530B0 Offset: 0xA51AB0 VA: 0x180A530B0
	private void Init() { }

	// RVA: 0xA53230 Offset: 0xA51C30 VA: 0x180A53230
	public void SetOccupant(LandVehicle vehicle) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
