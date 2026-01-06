public class LabOvenData : GridItemData // TypeDefIndex: 1077
{
	// Fields
	public ItemSet InputContents; // 0x58
	public ItemSet OutputContents; // 0x60
	public string CurrentIngredientID; // 0x68
	public int CurrentIngredientQuantity; // 0x70
	public EQuality CurrentIngredientQuality; // 0x74
	public string CurrentProductID; // 0x78
	public int CurrentCookProgress; // 0x80

	// Methods

	// RVA: 0x5DD580 Offset: 0x5DBF80 VA: 0x1805DD580
	public void .ctor(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string ingredientID, int currentIngredientQuantity, EQuality ingredientQuality, string productID, int currentCookProgress) { }
}
