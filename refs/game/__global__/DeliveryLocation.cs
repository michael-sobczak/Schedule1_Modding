public class DeliveryLocation : MonoBehaviour, IGUIDRegisterable // TypeDefIndex: 1516
{
	// Fields
	public string LocationName; // 0x20
	public string LocationDescription; // 0x28
	public Transform CustomerStandPoint; // 0x30
	public Transform TeleportPoint; // 0x38
	public POI PoI; // 0x40
	public string StaticGUID; // 0x48
	public List<Contract> ScheduledContracts; // 0x50
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x58

	// Properties
	public Guid GUID { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4F9F10 Offset: 0x4F8910 VA: 0x1804F9F10 Slot: 4
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x6D1920 Offset: 0x6D0320 VA: 0x1806D1920
	protected void set_GUID(Guid value) { }

	// RVA: 0x6DFE30 Offset: 0x6DE830 VA: 0x1806DFE30 Slot: 6
	public void SetGUID(Guid guid) { }

	// RVA: 0x6DFC80 Offset: 0x6DE680 VA: 0x1806DFC80
	private void Awake() { }

	// RVA: 0x6D1330 Offset: 0x6CFD30 VA: 0x1806D1330
	private void OnValidate() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 7
	public virtual string GetDescription() { }

	// RVA: 0x6DFE90 Offset: 0x6DE890 VA: 0x1806DFE90
	public void .ctor() { }
}
