public class ChemistryStationData : GridItemData // TypeDefIndex: 1071
{
	// Fields
	public ItemSet InputContents; // 0x58
	public ItemSet OutputContents; // 0x60
	public string CurrentRecipeID; // 0x68
	public EQuality ProductQuality; // 0x70
	public Color StartLiquidColor; // 0x74
	public float LiquidLevel; // 0x84
	public int CurrentTime; // 0x88

	// Methods

	// RVA: 0x5D71D0 Offset: 0x5D5BD0 VA: 0x1805D71D0
	public void .ctor(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string currentRecipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime) { }
}
