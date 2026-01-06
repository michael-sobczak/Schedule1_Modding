public static class HashSetPool<T> // TypeDefIndex: 13595
{
	// Fields
	private static readonly ObjectPool<HashSet<T>> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static HashSet<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E74F0 Offset: 0x10E5EF0 VA: 0x1810E74F0
	|-HashSetPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<HashSet<T>> Get(out HashSet<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E99D0 Offset: 0x14E83D0 VA: 0x1814E99D0
	|-HashSetPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(HashSet<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E9B00 Offset: 0x14E8500 VA: 0x1814E9B00
	|-HashSetPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E9C20 Offset: 0x14E8620 VA: 0x1814E9C20
	|-HashSetPool<__Il2CppFullySharedGenericType>..cctor
	*/
}
