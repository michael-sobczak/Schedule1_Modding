public class BuildUpdate_AirConditioner : BuildUpdate_Grid // TypeDefIndex: 2111
{
	// Fields
	private AirConditioner _ac; // 0x68
	private AirConditioner.EMode _currentMode; // 0x70
	private Property _currentProperty; // 0x78

	// Methods

	// RVA: 0x7F6DE0 Offset: 0x7F57E0 VA: 0x1807F6DE0 Slot: 5
	public override void Initialize(GridItem buildableItemClass, ItemInstance itemInstance, GameObject ghostModel) { }

	// RVA: 0x7F7490 Offset: 0x7F5E90 VA: 0x1807F7490 Slot: 7
	protected override void Update() { }

	// RVA: 0x7F6D80 Offset: 0x7F5780 VA: 0x1807F6D80
	private void CycleACMode() { }

	// RVA: 0x7F7450 Offset: 0x7F5E50 VA: 0x1807F7450
	private void SetACMode(AirConditioner.EMode mode) { }

	// RVA: 0x7F72A0 Offset: 0x7F5CA0 VA: 0x1807F72A0 Slot: 11
	protected override void OnPlacedObjectPreSpawn(GridItem item) { }

	// RVA: 0x7F6F00 Offset: 0x7F5900 VA: 0x1807F6F00 Slot: 12
	protected override void OnClosestIntersectionChanged(TileIntersection previous, TileIntersection current) { }

	// RVA: 0x7F6C20 Offset: 0x7F5620 VA: 0x1807F6C20
	private void AddToProperty(Property property) { }

	// RVA: 0x7F7340 Offset: 0x7F5D40 VA: 0x1807F7340
	public void RemoveFromPropery() { }

	// RVA: 0x7F7530 Offset: 0x7F5F30 VA: 0x1807F7530
	public void .ctor() { }
}
