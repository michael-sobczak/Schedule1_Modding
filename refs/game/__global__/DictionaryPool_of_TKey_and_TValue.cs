public static class DictionaryPool<TKey, TValue> // TypeDefIndex: 13597
{
	// Fields
	private static readonly ObjectPool<Dictionary<TKey, TValue>> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TValue> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E74F0 Offset: 0x10E5EF0 VA: 0x1810E74F0
	|-DictionaryPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<Dictionary<TKey, TValue>> Get(out Dictionary<TKey, TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E99D0 Offset: 0x14E83D0 VA: 0x1814E99D0
	|-DictionaryPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(Dictionary<TKey, TValue> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E9B00 Offset: 0x14E8500 VA: 0x1814E9B00
	|-DictionaryPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E9C20 Offset: 0x14E8620 VA: 0x1814E9C20
	|-DictionaryPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}
