public class CGDataReference // TypeDefIndex: 10613
{
	// Fields
	[SerializeField]
	private CGModule m_Module; // 0x10
	[SerializeField]
	private string m_SlotName; // 0x18
	private CGModuleOutputSlot mSlot; // 0x20

	// Properties
	public CGData[] Data { get; }
	public CGModuleOutputSlot Slot { get; }
	public bool HasValue { get; }
	public bool IsEmpty { get; }
	public CGModule Module { get; }
	public string SlotName { get; }

	// Methods

	// RVA: 0x4D6E40 Offset: 0x4D5840 VA: 0x1804D6E40
	public CGData[] get_Data() { }

	// RVA: 0x4D6EF0 Offset: 0x4D58F0 VA: 0x1804D6EF0
	public CGModuleOutputSlot get_Slot() { }

	// RVA: 0x4D6EB0 Offset: 0x4D58B0 VA: 0x1804D6EB0
	public bool get_HasValue() { }

	// RVA: 0x4D6EE0 Offset: 0x4D58E0 VA: 0x1804D6EE0
	public bool get_IsEmpty() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public CGModule get_Module() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_SlotName() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x4D6D40 Offset: 0x4D5740 VA: 0x1804D6D40
	public void .ctor(CGModule module, string slotName) { }

	// RVA: 0x4D6DB0 Offset: 0x4D57B0 VA: 0x1804D6DB0
	public void .ctor(CurvyGenerator generator, string moduleName, string slotName) { }

	// RVA: 0x4D6CC0 Offset: 0x4D56C0 VA: 0x1804D6CC0
	public void Clear() { }

	// RVA: -1 Offset: -1
	public T GetData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B300 Offset: 0xE59D00 VA: 0x180E5B300
	|-CGDataReference.GetData<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetAllData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B2A0 Offset: 0xE59CA0 VA: 0x180E5B2A0
	|-CGDataReference.GetAllData<object>
	*/

	// RVA: 0x4D70E0 Offset: 0x4D5AE0 VA: 0x1804D70E0
	public void setINTERNAL(CGModule module, string slotName) { }

	// RVA: 0x4D7070 Offset: 0x4D5A70 VA: 0x1804D7070
	public void setINTERNAL(CurvyGenerator generator, string moduleName, string slotName) { }
}
