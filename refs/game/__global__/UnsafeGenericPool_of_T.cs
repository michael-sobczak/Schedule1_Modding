public static class UnsafeGenericPool<T> // TypeDefIndex: 13591
{
	// Fields
	private static readonly ObjectPool<T> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6880 Offset: 0x12D5280 VA: 0x1812D6880
	|-UnsafeGenericPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<T> Get(out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D66F0 Offset: 0x12D50F0 VA: 0x1812D66F0
	|-UnsafeGenericPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(T toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6A00 Offset: 0x12D5400 VA: 0x1812D6A00
	|-UnsafeGenericPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6BD0 Offset: 0x12D55D0 VA: 0x1812D6BD0
	|-UnsafeGenericPool<__Il2CppFullySharedGenericType>..cctor
	*/
}
