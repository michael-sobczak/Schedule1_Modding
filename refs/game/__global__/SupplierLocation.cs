public class SupplierLocation : MonoBehaviour // TypeDefIndex: 1528
{
	// Fields
	public static List<SupplierLocation> AllLocations; // 0x0
	[CompilerGenerated]
	private Supplier <ActiveSupplier>k__BackingField; // 0x20
	[Header("Settings")]
	public string LocationName; // 0x28
	public string LocationDescription; // 0x30
	[Header("References")]
	public Transform GenericContainer; // 0x38
	public Transform SupplierStandPoint; // 0x40
	public WorldStorageEntity[] DeliveryBays; // 0x48
	public POI PoI; // 0x50
	private SupplierLocationConfiguration[] configs; // 0x58

	// Properties
	public bool IsOccupied { get; }
	public Supplier ActiveSupplier { get; set; }

	// Methods

	// RVA: 0x6FE6E0 Offset: 0x6FD0E0 VA: 0x1806FE6E0
	public bool get_IsOccupied() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Supplier get_ActiveSupplier() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_ActiveSupplier(Supplier value) { }

	// RVA: 0x6FE0C0 Offset: 0x6FCAC0 VA: 0x1806FE0C0
	public void Awake() { }

	// RVA: 0x6FE2F0 Offset: 0x6FCCF0 VA: 0x1806FE2F0
	private void OnDestroy() { }

	// RVA: 0x6FE370 Offset: 0x6FCD70 VA: 0x1806FE370
	public void SetActiveSupplier(Supplier supplier) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x6FE650 Offset: 0x6FD050 VA: 0x1806FE650
	private static void .cctor() { }
}
