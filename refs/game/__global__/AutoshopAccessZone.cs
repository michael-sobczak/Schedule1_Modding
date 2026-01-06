public class AutoshopAccessZone : NPCPresenceAccessZone // TypeDefIndex: 3325
{
	// Fields
	public Animation RollerDoorAnim; // 0x60
	public VehicleDetector VehicleDetection; // 0x68
	private bool rollerDoorOpen; // 0x70

	// Methods

	// RVA: 0xA48A90 Offset: 0xA47490 VA: 0x180A48A90 Slot: 5
	public override void SetIsOpen(bool open) { }

	// RVA: 0xA48940 Offset: 0xA47340 VA: 0x180A48940 Slot: 7
	protected override void MinPass() { }

	// RVA: 0xA48B20 Offset: 0xA47520 VA: 0x180A48B20
	public void .ctor() { }
}
