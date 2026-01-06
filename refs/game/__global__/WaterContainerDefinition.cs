public class WaterContainerDefinition : StorableItemDefinition // TypeDefIndex: 3091
{
	// Fields
	[SerializeField]
	public float Capacity; // 0xC0
	[SerializeField]
	public FillableWaterContainer FillablePrefab; // 0xC8

	// Methods

	// RVA: 0x8BC060 Offset: 0x8BAA60 VA: 0x1808BC060 Slot: 5
	public override void ValidateDefinition() { }

	// RVA: 0x9A7660 Offset: 0x9A6060 VA: 0x1809A7660 Slot: 4
	public override ItemInstance GetDefaultInstance(int quantity = 1) { }

	// RVA: 0x9A76D0 Offset: 0x9A60D0 VA: 0x1809A76D0
	public void .ctor() { }
}
