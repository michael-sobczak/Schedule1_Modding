public class LoadingDock : MonoBehaviour, IGUIDRegisterable, ITransitEntity // TypeDefIndex: 1976
{
	// Fields
	[CompilerGenerated]
	private LandVehicle <DynamicOccupant>k__BackingField; // 0x20
	[CompilerGenerated]
	private LandVehicle <StaticOccupant>k__BackingField; // 0x28
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x30
	[SerializeField]
	protected string BakedGUID; // 0x40
	[CompilerGenerated]
	private List<ItemSlot> <InputSlots>k__BackingField; // 0x48
	[CompilerGenerated]
	private List<ItemSlot> <OutputSlots>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly bool <Selectable>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <IsAcceptingItems>k__BackingField; // 0x59
	[CompilerGenerated]
	private bool <IsDestroyed>k__BackingField; // 0x5A
	public Property ParentProperty; // 0x60
	public VehicleDetector VehicleDetector; // 0x68
	public ParkingLot Parking; // 0x70
	public Transform uiPoint; // 0x78
	public Transform[] accessPoints; // 0x80
	public GameObject[] OutlineRenderers; // 0x88
	private Outlinable OutlineEffect; // 0x90

	// Properties
	public LandVehicle DynamicOccupant { get; set; }
	public LandVehicle StaticOccupant { get; set; }
	public bool IsInUse { get; }
	public Guid GUID { get; set; }
	public string Name { get; }
	public List<ItemSlot> InputSlots { get; set; }
	public List<ItemSlot> OutputSlots { get; set; }
	public Transform LinkOrigin { get; }
	public Transform[] AccessPoints { get; }
	public bool Selectable { get; }
	public bool IsAcceptingItems { get; set; }
	public bool IsDestroyed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public LandVehicle get_DynamicOccupant() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_DynamicOccupant(LandVehicle value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public LandVehicle get_StaticOccupant() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_StaticOccupant(LandVehicle value) { }

	// RVA: 0x79D130 Offset: 0x79BB30 VA: 0x18079D130
	public bool get_IsInUse() { }

	[CompilerGenerated]
	// RVA: 0x6FC320 Offset: 0x6FAD20 VA: 0x1806FC320 Slot: 17
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x6FC3B0 Offset: 0x6FADB0 VA: 0x1806FC3B0
	protected void set_GUID(Guid value) { }

	[Button]
	// RVA: 0x6FBEE0 Offset: 0x6FA8E0 VA: 0x1806FBEE0
	public void RegenerateGUID() { }

	// RVA: 0x79D1C0 Offset: 0x79BBC0 VA: 0x18079D1C0 Slot: 7
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 8
	public List<ItemSlot> get_InputSlots() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 9
	public void set_InputSlots(List<ItemSlot> value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 10
	public List<ItemSlot> get_OutputSlots() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 11
	public void set_OutputSlots(List<ItemSlot> value) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210 Slot: 12
	public Transform get_LinkOrigin() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400 Slot: 13
	public Transform[] get_AccessPoints() { }

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0 Slot: 14
	public bool get_Selectable() { }

	[CompilerGenerated]
	// RVA: 0x79D110 Offset: 0x79BB10 VA: 0x18079D110 Slot: 15
	public bool get_IsAcceptingItems() { }

	[CompilerGenerated]
	// RVA: 0x79D240 Offset: 0x79BC40 VA: 0x18079D240
	public void set_IsAcceptingItems(bool value) { }

	[CompilerGenerated]
	// RVA: 0x79D120 Offset: 0x79BB20 VA: 0x18079D120 Slot: 16
	public bool get_IsDestroyed() { }

	[CompilerGenerated]
	// RVA: 0x79D250 Offset: 0x79BC50 VA: 0x18079D250
	public void set_IsDestroyed(bool value) { }

	// RVA: 0x79C340 Offset: 0x79AD40 VA: 0x18079C340
	private void Awake() { }

	// RVA: 0x79CFC0 Offset: 0x79B9C0 VA: 0x18079CFC0
	private void Start() { }

	// RVA: 0x79C890 Offset: 0x79B290 VA: 0x18079C890 Slot: 6
	public void SetGUID(Guid guid) { }

	// RVA: 0x79C430 Offset: 0x79AE30 VA: 0x18079C430
	private void RefreshOccupant() { }

	// RVA: 0x79C8F0 Offset: 0x79B2F0 VA: 0x18079C8F0
	private void SetOccupant(LandVehicle occupant) { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void SetStaticOccupant(LandVehicle vehicle) { }

	// RVA: 0x79CBB0 Offset: 0x79B5B0 VA: 0x18079CBB0 Slot: 29
	public virtual void ShowOutline(Color color) { }

	// RVA: 0x79C3B0 Offset: 0x79ADB0 VA: 0x18079C3B0 Slot: 30
	public virtual void HideOutline() { }

	// RVA: 0x79D030 Offset: 0x79BA30 VA: 0x18079D030
	public void .ctor() { }
}
