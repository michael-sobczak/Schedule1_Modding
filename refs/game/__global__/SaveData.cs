public class SaveData // TypeDefIndex: 1106
{
	// Fields
	public string DataType; // 0x10
	public int DataVersion; // 0x18
	public string GameVersion; // 0x20

	// Methods

	// RVA: 0x5EB4F0 Offset: 0x5E9EF0 VA: 0x1805EB4F0
	public void .ctor() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	protected virtual int GetDataVersion() { }

	// RVA: 0x5EB400 Offset: 0x5E9E00 VA: 0x1805EB400 Slot: 5
	public virtual string GetJson(bool prettyPrint = True) { }
}
