public class PourSoilTask : GrowContainerPourTask // TypeDefIndex: 813
{
	// Fields
	private SoilDefinition _soilDefinition; // 0xD0
	private PourableSoil _pourableSoil; // 0xD8
	private Collider _hoveredTopCollider; // 0xE0
	private GrowContainer _growContainer; // 0xE8

	// Methods

	// RVA: 0x5AC940 Offset: 0x5AB340 VA: 0x1805AC940
	public void .ctor(GrowContainer growContainer, ItemInstance itemInstance, Pourable pourablePrefab) { }

	// RVA: 0x5AC480 Offset: 0x5AAE80 VA: 0x1805AC480 Slot: 17
	protected override void OnInitialPour() { }

	// RVA: 0x5AC6E0 Offset: 0x5AB0E0 VA: 0x1805AC6E0 Slot: 9
	public override void Update() { }

	// RVA: 0x5AC500 Offset: 0x5AAF00 VA: 0x1805AC500 Slot: 6
	public override void StopTask() { }

	// RVA: 0x5AC540 Offset: 0x5AAF40 VA: 0x1805AC540 Slot: 10
	protected override void UpdateCursor() { }

	// RVA: 0x5AC6B0 Offset: 0x5AB0B0 VA: 0x1805AC6B0
	private void UpdateHover() { }

	// RVA: 0x5AC2F0 Offset: 0x5AACF0 VA: 0x1805AC2F0
	private Collider GetHoveredTopCollider() { }
}
