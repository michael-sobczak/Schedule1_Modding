public class DynamicSaveData : SaveData // TypeDefIndex: 996
{
	// Fields
	public string BaseData; // 0x28
	public List<DynamicSaveData.AdditionalData> AdditionalDatas; // 0x30

	// Methods

	// RVA: 0x5DA120 Offset: 0x5D8B20 VA: 0x1805DA120
	public void .ctor(SaveData baseData) { }

	// RVA: 0x5D9C70 Offset: 0x5D8670 VA: 0x1805D9C70
	public void AddData(string name, string contents) { }

	// RVA: 0x5D9EC0 Offset: 0x5D88C0 VA: 0x1805D9EC0
	public void AddData(string name, SaveData data) { }

	// RVA: 0x5D9F20 Offset: 0x5D8920 VA: 0x1805D9F20
	public string GetData(string name) { }

	// RVA: 0x5DA090 Offset: 0x5D8A90 VA: 0x1805DA090
	public bool TryGetData(string name, out string data) { }

	// RVA: -1 Offset: -1
	public T GetData<T>(string name, bool warn = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82630 Offset: 0xE81030 VA: 0x180E82630
	|-DynamicSaveData.GetData<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetData<T>(string name, out T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82890 Offset: 0xE81290 VA: 0x180E82890
	|-DynamicSaveData.TryGetData<object>
	*/

	// RVA: -1 Offset: -1
	public T ExtractBaseData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82570 Offset: 0xE80F70 VA: 0x180E82570
	|-DynamicSaveData.ExtractBaseData<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryExtractBaseData<T>(out T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82740 Offset: 0xE81140 VA: 0x180E82740
	|-DynamicSaveData.TryExtractBaseData<object>
	*/
}
