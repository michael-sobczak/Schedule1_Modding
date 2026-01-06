public static class ObjectPoolSimple<T> // TypeDefIndex: 13389
{
	// Fields
	private static List<T> pool; // 0x0
	private static readonly HashSet<T> inPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T Claim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8B40 Offset: 0x10E7540 VA: 0x1810E8B40
	|-ObjectPoolSimple<object>.Claim
	*/

	// RVA: -1 Offset: -1
	public static void Release(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9230 Offset: 0x10E7C30 VA: 0x1810E9230
	|-ObjectPoolSimple<object>.Release
	*/

	// RVA: -1 Offset: -1
	public static void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8FA0 Offset: 0x10E79A0 VA: 0x1810E8FA0
	|-ObjectPoolSimple<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public static int GetSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9170 Offset: 0x10E7B70 VA: 0x1810E9170
	|-ObjectPoolSimple<object>.GetSize
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9470 Offset: 0x10E7E70 VA: 0x1810E9470
	|-ObjectPoolSimple<object>..cctor
	*/
}
