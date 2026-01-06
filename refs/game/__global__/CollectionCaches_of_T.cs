public static class CollectionCaches<T> // TypeDefIndex: 18174
{
	// Fields
	private static readonly Stack<T[]> _arrayCache; // 0x0
	private static readonly Stack<List<T>> _listCache; // 0x0
	private static readonly Stack<HashSet<T>> _hashsetCache; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T[] RetrieveArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1442A20 Offset: 0x1441420 VA: 0x181442A20
	|-CollectionCaches<bool>.RetrieveArray
	|-CollectionCaches<int>.RetrieveArray
	|-CollectionCaches<object>.RetrieveArray
	|-CollectionCaches<UInt32Enum>.RetrieveArray
	|
	|-RVA: 0x14427F0 Offset: 0x14411F0 VA: 0x1814427F0
	|-CollectionCaches<__Il2CppFullySharedGenericType>.RetrieveArray
	*/

	// RVA: -1 Offset: -1
	public static List<T> RetrieveList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14444D0 Offset: 0x1442ED0 VA: 0x1814444D0
	|-CollectionCaches<bool>.RetrieveList
	|-CollectionCaches<int>.RetrieveList
	|-CollectionCaches<object>.RetrieveList
	|-CollectionCaches<UInt32Enum>.RetrieveList
	|
	|-RVA: 0x1444CB0 Offset: 0x14436B0 VA: 0x181444CB0
	|-CollectionCaches<__Il2CppFullySharedGenericType>.RetrieveList
	*/

	// RVA: -1 Offset: -1
	public static List<T> RetrieveList(T entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1444A40 Offset: 0x1443440 VA: 0x181444A40
	|-CollectionCaches<bool>.RetrieveList
	|
	|-RVA: 0x14451B0 Offset: 0x1443BB0 VA: 0x1814451B0
	|-CollectionCaches<int>.RetrieveList
	|
	|-RVA: 0x1444F30 Offset: 0x1443930 VA: 0x181444F30
	|-CollectionCaches<object>.RetrieveList
	|
	|-RVA: 0x1444260 Offset: 0x1442C60 VA: 0x181444260
	|-CollectionCaches<UInt32Enum>.RetrieveList
	|
	|-RVA: 0x14446B0 Offset: 0x14430B0 VA: 0x1814446B0
	|-CollectionCaches<__Il2CppFullySharedGenericType>.RetrieveList
	*/

	// RVA: -1 Offset: -1
	public static HashSet<T> RetrieveHashSet() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1442BD0 Offset: 0x14415D0 VA: 0x181442BD0
	|-CollectionCaches<bool>.RetrieveHashSet
	|
	|-RVA: 0x1443DE0 Offset: 0x14427E0 VA: 0x181443DE0
	|-CollectionCaches<int>.RetrieveHashSet
	|
	|-RVA: 0x1442FE0 Offset: 0x14419E0 VA: 0x181442FE0
	|-CollectionCaches<object>.RetrieveHashSet
	|
	|-RVA: 0x14431D0 Offset: 0x1441BD0 VA: 0x1814431D0
	|-CollectionCaches<UInt32Enum>.RetrieveHashSet
	|
	|-RVA: 0x1443FD0 Offset: 0x14429D0 VA: 0x181443FD0
	|-CollectionCaches<__Il2CppFullySharedGenericType>.RetrieveHashSet
	*/

	// RVA: -1 Offset: -1
	public static HashSet<T> RetrieveHashSet(T entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1443BB0 Offset: 0x14425B0 VA: 0x181443BB0
	|-CollectionCaches<bool>.RetrieveHashSet
	|
	|-RVA: 0x14433C0 Offset: 0x1441DC0 VA: 0x1814433C0
	|-CollectionCaches<int>.RetrieveHashSet
	|
	|-RVA: 0x1443990 Offset: 0x1442390 VA: 0x181443990
	|-CollectionCaches<object>.RetrieveHashSet
	|
	|-RVA: 0x1442DC0 Offset: 0x14417C0 VA: 0x181442DC0
	|-CollectionCaches<UInt32Enum>.RetrieveHashSet
	|
	|-RVA: 0x14435E0 Offset: 0x1441FE0 VA: 0x1814435E0
	|-CollectionCaches<__Il2CppFullySharedGenericType>.RetrieveHashSet
	*/

	// RVA: -1 Offset: -1
	public static void StoreAndDefault(ref T[] value, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445AC0 Offset: 0x14444C0 VA: 0x181445AC0
	|-CollectionCaches<bool>.StoreAndDefault
	|
	|-RVA: 0x1445750 Offset: 0x1444150 VA: 0x181445750
	|-CollectionCaches<int>.StoreAndDefault
	|-CollectionCaches<UInt32Enum>.StoreAndDefault
	|
	|-RVA: 0x1445D50 Offset: 0x1444750 VA: 0x181445D50
	|-CollectionCaches<object>.StoreAndDefault
	|
	|-RVA: 0x1445C60 Offset: 0x1444660 VA: 0x181445C60
	|-CollectionCaches<__Il2CppFullySharedGenericType>.StoreAndDefault
	*/

	// RVA: -1 Offset: -1
	public static void Store(T[] value, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446300 Offset: 0x1444D00 VA: 0x181446300
	|-CollectionCaches<bool>.Store
	|
	|-RVA: 0x14460D0 Offset: 0x1444AD0 VA: 0x1814460D0
	|-CollectionCaches<int>.Store
	|-CollectionCaches<UInt32Enum>.Store
	|
	|-RVA: 0x14467A0 Offset: 0x14451A0 VA: 0x1814467A0
	|-CollectionCaches<object>.Store
	|
	|-RVA: 0x1446530 Offset: 0x1444F30 VA: 0x181446530
	|-CollectionCaches<__Il2CppFullySharedGenericType>.Store
	*/

	// RVA: -1 Offset: -1
	public static void StoreAndDefault(ref List<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14455C0 Offset: 0x1443FC0 VA: 0x1814455C0
	|-CollectionCaches<bool>.StoreAndDefault
	|-CollectionCaches<int>.StoreAndDefault
	|-CollectionCaches<UInt32Enum>.StoreAndDefault
	|
	|-RVA: 0x1445F30 Offset: 0x1444930 VA: 0x181445F30
	|-CollectionCaches<object>.StoreAndDefault
	|
	|-RVA: 0x1445900 Offset: 0x1444300 VA: 0x181445900
	|-CollectionCaches<__Il2CppFullySharedGenericType>.StoreAndDefault
	*/

	// RVA: -1 Offset: -1
	public static void Store(List<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14468E0 Offset: 0x14452E0 VA: 0x1814468E0
	|-CollectionCaches<bool>.Store
	|-CollectionCaches<int>.Store
	|-CollectionCaches<UInt32Enum>.Store
	|
	|-RVA: 0x1446410 Offset: 0x1444E10 VA: 0x181446410
	|-CollectionCaches<object>.Store
	|
	|-RVA: 0x14469E0 Offset: 0x14453E0 VA: 0x1814469E0
	|-CollectionCaches<__Il2CppFullySharedGenericType>.Store
	*/

	// RVA: -1 Offset: -1
	public static void StoreAndDefault(ref HashSet<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445420 Offset: 0x1443E20 VA: 0x181445420
	|-CollectionCaches<bool>.StoreAndDefault
	|-CollectionCaches<int>.StoreAndDefault
	|-CollectionCaches<object>.StoreAndDefault
	|-CollectionCaches<UInt32Enum>.StoreAndDefault
	|
	|-RVA: 0x14459E0 Offset: 0x14443E0 VA: 0x1814459E0
	|-CollectionCaches<__Il2CppFullySharedGenericType>.StoreAndDefault
	*/

	// RVA: -1 Offset: -1
	public static void Store(HashSet<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14461F0 Offset: 0x1444BF0 VA: 0x1814461F0
	|-CollectionCaches<bool>.Store
	|-CollectionCaches<int>.Store
	|-CollectionCaches<object>.Store
	|-CollectionCaches<UInt32Enum>.Store
	|
	|-RVA: 0x1446B60 Offset: 0x1445560 VA: 0x181446B60
	|-CollectionCaches<__Il2CppFullySharedGenericType>.Store
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446CE0 Offset: 0x14456E0 VA: 0x181446CE0
	|-CollectionCaches<bool>..cctor
	|-CollectionCaches<int>..cctor
	|-CollectionCaches<object>..cctor
	|-CollectionCaches<UInt32Enum>..cctor
	|
	|-RVA: 0x1446FB0 Offset: 0x14459B0 VA: 0x181446FB0
	|-CollectionCaches<__Il2CppFullySharedGenericType>..cctor
	*/
}
