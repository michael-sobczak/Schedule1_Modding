public class PropertyData : SaveData // TypeDefIndex: 1100
{
	// Fields
	public string PropertyCode; // 0x28
	public bool IsOwned; // 0x30
	public bool[] SwitchStates; // 0x38
	public bool[] ToggleableStates; // 0x40
	public DynamicSaveData[] Employees; // 0x48
	public DynamicSaveData[] Objects; // 0x50

	// Methods

	// RVA: 0x5E9E10 Offset: 0x5E8810 VA: 0x1805E9E10
	public void .ctor(string propertyCode, bool isOwned, bool[] switchStates, bool[] toggleableStates, DynamicSaveData[] employees, DynamicSaveData[] objects) { }
}
