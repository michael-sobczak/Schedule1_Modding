public class CauldronData : GridItemData // TypeDefIndex: 1070
{
	// Fields
	public ItemSet Ingredients; // 0x58
	public ItemSet Liquid; // 0x60
	public ItemSet Output; // 0x68
	public int RemainingCookTime; // 0x70
	public EQuality InputQuality; // 0x74

	// Methods

	// RVA: 0x5D6380 Offset: 0x5D4D80 VA: 0x1805D6380
	public void .ctor(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet ingredients, ItemSet liquid, ItemSet output, int remainingCookTime, EQuality inputQuality) { }
}
