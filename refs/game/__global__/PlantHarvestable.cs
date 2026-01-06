public class PlantHarvestable : MonoBehaviour // TypeDefIndex: 2374
{
	// Fields
	public StorableItemDefinition Product; // 0x20
	public int ProductQuantity; // 0x28

	// Methods

	// RVA: 0x864790 Offset: 0x863190 VA: 0x180864790
	private void Awake() { }

	// RVA: 0x8647F0 Offset: 0x8631F0 VA: 0x1808647F0 Slot: 4
	public virtual void Harvest(bool giveProduct = True) { }

	// RVA: 0x864E40 Offset: 0x863840 VA: 0x180864E40
	public void .ctor() { }
}
