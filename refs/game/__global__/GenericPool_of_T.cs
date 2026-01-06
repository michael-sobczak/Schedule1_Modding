public static class GenericPool<T> // TypeDefIndex: 13590
{
	// Fields
	private static readonly ObjectPool<T> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181A100 Offset: 0x1818B00 VA: 0x18181A100
	|-GenericPool<object>.Get
	|
	|-RVA: 0x12D6880 Offset: 0x12D5280 VA: 0x1812D6880
	|-GenericPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<T> Get(out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181A1D0 Offset: 0x1818BD0 VA: 0x18181A1D0
	|-GenericPool<object>.Get
	|
	|-RVA: 0x12D66F0 Offset: 0x12D50F0 VA: 0x1812D66F0
	|-GenericPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(T toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181A2D0 Offset: 0x1818CD0 VA: 0x18181A2D0
	|-GenericPool<object>.Release
	|
	|-RVA: 0x12D6A00 Offset: 0x12D5400 VA: 0x1812D6A00
	|-GenericPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181A3B0 Offset: 0x1818DB0 VA: 0x18181A3B0
	|-GenericPool<object>..cctor
	|
	|-RVA: 0x181A4C0 Offset: 0x1818EC0 VA: 0x18181A4C0
	|-GenericPool<__Il2CppFullySharedGenericType>..cctor
	*/
}
