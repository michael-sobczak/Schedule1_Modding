internal static class TMP_ListPool<T> // TypeDefIndex: 14938
{
	// Fields
	private static readonly TMP_ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12096D0 Offset: 0x12080D0 VA: 0x1812096D0
	|-TMP_ListPool<object>.Get
	|
	|-RVA: 0x10E74F0 Offset: 0x10E5EF0 VA: 0x1810E74F0
	|-TMP_ListPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1209800 Offset: 0x1208200 VA: 0x181209800
	|-TMP_ListPool<object>.Release
	|
	|-RVA: 0x1209990 Offset: 0x1208390 VA: 0x181209990
	|-TMP_ListPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1209AB0 Offset: 0x12084B0 VA: 0x181209AB0
	|-TMP_ListPool<object>..cctor
	|
	|-RVA: 0x1209D50 Offset: 0x1208750 VA: 0x181209D50
	|-TMP_ListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}
