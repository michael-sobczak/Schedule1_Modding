public class GrowContainerData : GridItemData // TypeDefIndex: 1074
{
	// Fields
	public string SoilID; // 0x58
	public float SoilLevel; // 0x60
	public int RemainingSoilUses; // 0x64
	public float WaterLevel; // 0x68
	public string[] AppliedAdditives; // 0x70

	// Methods

	// RVA: 0x5DB960 Offset: 0x5DA360 VA: 0x1805DB960
	public void .ctor(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, string[] appliedAdditives) { }

	// RVA: 0x5DB6F0 Offset: 0x5DA0F0 VA: 0x1805DB6F0
	public void ConvertOldAdditiveFormatToNew() { }
}
