public class TrashItemData // TypeDefIndex: 1119
{
	// Fields
	public string DataType; // 0x10
	public string TrashID; // 0x18
	public string GUID; // 0x20
	public Vector3 Position; // 0x28
	public Quaternion Rotation; // 0x34
	public TrashContentData Contents; // 0x48

	// Methods

	// RVA: 0x5EF1F0 Offset: 0x5EDBF0 VA: 0x1805EF1F0
	public void .ctor(string trashID, string guid, Vector3 position, Quaternion rotation) { }
}
