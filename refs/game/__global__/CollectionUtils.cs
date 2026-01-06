internal static class CollectionUtils // TypeDefIndex: 11117
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE663A0 Offset: 0xE64DA0 VA: 0x180E663A0
	|-CollectionUtils.IsNullOrEmpty<object>
	|-CollectionUtils.IsNullOrEmpty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE64FB0 Offset: 0xE639B0 VA: 0x180E64FB0
	|-CollectionUtils.AddRange<object>
	|
	|-RVA: 0xE64CA0 Offset: 0xE636A0 VA: 0x180E64CA0
	|-CollectionUtils.AddRange<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D5BA60 Offset: 0x1D5A460 VA: 0x181D5BA60
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0x1D5BCF0 Offset: 0x1D5A6F0 VA: 0x181D5BCF0
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0x1D5BE10 Offset: 0x1D5A810 VA: 0x181D5BE10
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static bool AddDistinct<T>(IList<T> list, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE645A0 Offset: 0xE62FA0 VA: 0x180E645A0
	|-CollectionUtils.AddDistinct<object>
	|
	|-RVA: 0xE644B0 Offset: 0xE62EB0 VA: 0x180E644B0
	|-CollectionUtils.AddDistinct<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool AddDistinct<T>(IList<T> list, T value, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE64660 Offset: 0xE63060 VA: 0x180E64660
	|-CollectionUtils.AddDistinct<object>
	|
	|-RVA: 0xE64350 Offset: 0xE62D50 VA: 0x180E64350
	|-CollectionUtils.AddDistinct<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ContainsValue<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE65590 Offset: 0xE63F90 VA: 0x180E65590
	|-CollectionUtils.ContainsValue<object>
	|
	|-RVA: 0xE65250 Offset: 0xE63C50 VA: 0x180E65250
	|-CollectionUtils.ContainsValue<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool AddRangeDistinct<T>(IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE64A20 Offset: 0xE63420 VA: 0x180E64A20
	|-CollectionUtils.AddRangeDistinct<object>
	|
	|-RVA: 0xE64700 Offset: 0xE63100 VA: 0x180E64700
	|-CollectionUtils.AddRangeDistinct<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE66200 Offset: 0xE64C00 VA: 0x180E66200
	|-CollectionUtils.IndexOf<object>
	|
	|-RVA: 0xE65F60 Offset: 0xE64960 VA: 0x180E65F60
	|-CollectionUtils.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE65930 Offset: 0xE64330 VA: 0x180E65930
	|-CollectionUtils.Contains<object>
	|
	|-RVA: 0xE657A0 Offset: 0xE641A0 VA: 0x180E657A0
	|-CollectionUtils.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE65EE0 Offset: 0xE648E0 VA: 0x180E65EE0
	|-CollectionUtils.IndexOfReference<object>
	|
	|-RVA: 0xE65D80 Offset: 0xE64780 VA: 0x180E65D80
	|-CollectionUtils.IndexOfReference<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void FastReverse<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE65C70 Offset: 0xE64670 VA: 0x180E65C70
	|-CollectionUtils.FastReverse<JsonPosition>
	|
	|-RVA: 0xE659F0 Offset: 0xE643F0 VA: 0x180E659F0
	|-CollectionUtils.FastReverse<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D5B6B0 Offset: 0x1D5A0B0 VA: 0x181D5B6B0
	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0x1D5B470 Offset: 0x1D59E70 VA: 0x181D5B470
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0x1D5BBF0 Offset: 0x1D5A5F0 VA: 0x181D5BBF0
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0x1D5C0C0 Offset: 0x1D5AAC0 VA: 0x181D5C0C0
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

	// RVA: -1 Offset: -1
	public static T[] ArrayEmpty<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454A40 Offset: 0x453440 VA: 0x180454A40
	|-CollectionUtils.ArrayEmpty<byte>
	|-CollectionUtils.ArrayEmpty<int>
	|-CollectionUtils.ArrayEmpty<object>
	|-CollectionUtils.ArrayEmpty<__Il2CppFullySharedGenericType>
	*/
}
