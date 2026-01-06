internal class ObjectListPool<T> // TypeDefIndex: 7026
{
	// Fields
	private static ObjectPool<List<T>> pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E73E0 Offset: 0x10E5DE0 VA: 0x1810E73E0
	|-ObjectListPool<object>.Get
	|
	|-RVA: 0x10E74F0 Offset: 0x10E5EF0 VA: 0x1810E74F0
	|-ObjectListPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> elements) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E7770 Offset: 0x10E6170 VA: 0x1810E7770
	|-ObjectListPool<object>.Release
	|
	|-RVA: 0x10E7600 Offset: 0x10E6000 VA: 0x1810E7600
	|-ObjectListPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E7BA0 Offset: 0x10E65A0 VA: 0x1810E7BA0
	|-ObjectListPool<object>..cctor
	|
	|-RVA: 0x10E7930 Offset: 0x10E6330 VA: 0x1810E7930
	|-ObjectListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}
