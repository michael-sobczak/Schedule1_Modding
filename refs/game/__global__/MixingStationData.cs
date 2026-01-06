public class MixingStationData : GridItemData // TypeDefIndex: 1078
{
	// Fields
	public ItemSet ProductContents; // 0x58
	public ItemSet MixerContents; // 0x60
	public ItemSet OutputContents; // 0x68
	public MixOperation CurrentMixOperation; // 0x70
	public int CurrentMixTime; // 0x78

	// Methods

	// RVA: 0x5E5350 Offset: 0x5E3D50 VA: 0x1805E5350
	public void .ctor(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet productContents, ItemSet mixerContents, ItemSet outputContents, MixOperation currentMixOperation, int currentMixTime) { }
}
