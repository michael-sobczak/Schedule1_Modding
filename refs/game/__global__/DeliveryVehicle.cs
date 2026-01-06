public class DeliveryVehicle : MonoBehaviour // TypeDefIndex: 1975
{
	// Fields
	[CompilerGenerated]
	private LandVehicle <Vehicle>k__BackingField; // 0x20
	[CompilerGenerated]
	private DeliveryInstance <ActiveDelivery>k__BackingField; // 0x28
	public string GUID; // 0x30

	// Properties
	public LandVehicle Vehicle { get; set; }
	public DeliveryInstance ActiveDelivery { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public LandVehicle get_Vehicle() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_Vehicle(LandVehicle value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public DeliveryInstance get_ActiveDelivery() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_ActiveDelivery(DeliveryInstance value) { }

	// RVA: 0x79ABA0 Offset: 0x7995A0 VA: 0x18079ABA0
	private void Awake() { }

	// RVA: 0x79A950 Offset: 0x799350 VA: 0x18079A950
	public void Activate(DeliveryInstance instance) { }

	// RVA: 0x79AC40 Offset: 0x799640 VA: 0x18079AC40
	public void Deactivate() { }

	// RVA: 0x79AE60 Offset: 0x799860 VA: 0x18079AE60
	public void .ctor() { }
}
