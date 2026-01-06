public class WorldStorageEntityData : SaveData // TypeDefIndex: 1125
{
	// Fields
	public string GUID; // 0x28
	public ItemSet Contents; // 0x30
	public GameDateTime LastContentChangeTime; // 0x38

	// Methods

	// RVA: 0x5F2B40 Offset: 0x5F1540 VA: 0x1805F2B40
	public void .ctor(Guid guid, ItemSet contents, GameDateTime lastContentChangeTime) { }
}
