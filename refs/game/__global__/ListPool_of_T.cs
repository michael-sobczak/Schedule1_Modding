public static class ListPool<T> // TypeDefIndex: 13593
{
	// Fields
	private static readonly ObjectPool<List<T>> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181A100 Offset: 0x1818B00 VA: 0x18181A100
	|-ListPool<int>.Get
	|-ListPool<object>.Get
	|
	|-RVA: 0x10E74F0 Offset: 0x10E5EF0 VA: 0x1810E74F0
	|-ListPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<List<T>> Get(out List<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181A1D0 Offset: 0x1818BD0 VA: 0x18181A1D0
	|-ListPool<int>.Get
	|-ListPool<object>.Get
	|
	|-RVA: 0x14E99D0 Offset: 0x14E83D0 VA: 0x1814E99D0
	|-ListPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181A2D0 Offset: 0x1818CD0 VA: 0x18181A2D0
	|-ListPool<int>.Release
	|-ListPool<object>.Release
	|
	|-RVA: 0x14E9B00 Offset: 0x14E8500 VA: 0x1814E9B00
	|-ListPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E90C0 Offset: 0x18E7AC0 VA: 0x1818E90C0
	|-ListPool<int>..cctor
	|-ListPool<object>..cctor
	|
	|-RVA: 0x14E9C20 Offset: 0x14E8620 VA: 0x1814E9C20
	|-ListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}
