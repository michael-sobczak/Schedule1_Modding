public class SaveInfo // TypeDefIndex: 868
{
	// Fields
	public string SavePath; // 0x10
	public int SaveSlotNumber; // 0x18
	public string OrganisationName; // 0x20
	public DateTime DateCreated; // 0x28
	public DateTime DateLastPlayed; // 0x30
	public float Networth; // 0x38
	public string SaveVersion; // 0x40
	public MetaData MetaData; // 0x48

	// Methods

	// RVA: 0x5C7BE0 Offset: 0x5C65E0 VA: 0x1805C7BE0
	public void .ctor(string savePath, int saveSlotNumber, string organisationName, DateTime dateCreated, DateTime dateLastPlayed, float networth, string saveVersion, MetaData metaData) { }
}
