public struct KeyValue<TKey, TValue> // TypeDefIndex: 15983
{
	// Fields
	internal UnsafeParallelHashMapData* m_Buffer; // 0x0
	internal int m_Index; // 0x0
	internal int m_Next; // 0x0

	// Properties
	public static KeyValue<TKey, TValue> Null { get; }
	public TKey Key { get; }
	public TValue Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static KeyValue<TKey, TValue> get_Null() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD560 Offset: 0x18CBF60 VA: 0x1818CD560
	|-KeyValue<int, int>.get_Null
	|-KeyValue<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Null
	*/

	// RVA: -1 Offset: -1
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD500 Offset: 0x18CBF00 VA: 0x1818CD500
	|-KeyValue<int, int>.get_Key
	|
	|-RVA: 0x18CD390 Offset: 0x18CBD90 VA: 0x1818CD390
	|-KeyValue<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Key
	*/

	// RVA: -1 Offset: -1
	public ref TValue get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD670 Offset: 0x18CC070 VA: 0x1818CD670
	|-KeyValue<int, int>.get_Value
	|
	|-RVA: 0x18CD580 Offset: 0x18CBF80 VA: 0x1818CD580
	|-KeyValue<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Value
	*/

	// RVA: -1 Offset: -1
	public bool GetKeyValue(out TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD020 Offset: 0x18CBA20 VA: 0x1818CD020
	|-KeyValue<int, int>.GetKeyValue
	|
	|-RVA: 0x18CD0D0 Offset: 0x18CBAD0 VA: 0x1818CD0D0
	|-KeyValue<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyValue
	*/
}
