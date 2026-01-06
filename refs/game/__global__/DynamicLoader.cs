public class DynamicLoader // TypeDefIndex: 880
{
	// Methods

	// RVA: 0x5BE580 Offset: 0x5BCF80 VA: 0x1805BE580
	public void Load(string serializedDynamicSaveData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public virtual void Load(DynamicSaveData saveData) { }

	// RVA: -1 Offset: -1
	public static T ExtractBaseData<T>(DynamicSaveData saveData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE822F0 Offset: 0xE80CF0 VA: 0x180E822F0
	|-DynamicLoader.ExtractBaseData<object>
	*/

	// RVA: -1 Offset: -1
	public static bool TryExtractBaseData<T>(DynamicSaveData saveData, out T baseData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82430 Offset: 0xE80E30 VA: 0x180E82430
	|-DynamicLoader.TryExtractBaseData<object>
	*/

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
