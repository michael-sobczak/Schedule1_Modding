public class GenericSaveData : SaveData // TypeDefIndex: 1009
{
	// Fields
	public string GUID; // 0x28
	public List<GenericSaveData.BoolValue> boolValues; // 0x30
	public List<GenericSaveData.FloatValue> floatValues; // 0x38
	public List<GenericSaveData.IntValue> intValues; // 0x40
	public List<GenericSaveData.StringValue> stringValues; // 0x48

	// Methods

	// RVA: 0x5DACC0 Offset: 0x5D96C0 VA: 0x1805DACC0
	public void .ctor(string guid) { }

	// RVA: 0x5DA6C0 Offset: 0x5D90C0 VA: 0x1805DA6C0
	public void Add(string key, bool value) { }

	// RVA: 0x5DA5C0 Offset: 0x5D8FC0 VA: 0x1805DA5C0
	public void Add(string key, float value) { }

	// RVA: 0x5DA7C0 Offset: 0x5D91C0 VA: 0x1805DA7C0
	public void Add(string key, int value) { }

	// RVA: 0x5DA4B0 Offset: 0x5D8EB0 VA: 0x1805DA4B0
	public void Add(string key, string value) { }

	// RVA: 0x5DA8C0 Offset: 0x5D92C0 VA: 0x1805DA8C0
	public bool GetBool(string key, bool defaultValue = False) { }

	// RVA: 0x5DA9C0 Offset: 0x5D93C0 VA: 0x1805DA9C0
	public float GetFloat(string key, float defaultValue = 0) { }

	// RVA: 0x5DAAC0 Offset: 0x5D94C0 VA: 0x1805DAAC0
	public int GetInt(string key, int defaultValue = 0) { }

	// RVA: 0x5DABC0 Offset: 0x5D95C0 VA: 0x1805DABC0
	public string GetString(string key, string defaultValue = "") { }
}
