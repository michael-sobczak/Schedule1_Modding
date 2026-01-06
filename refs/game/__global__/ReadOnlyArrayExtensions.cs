public static class ReadOnlyArrayExtensions // TypeDefIndex: 7844
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<TValue>(ReadOnlyArray<TValue> array, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF29090 Offset: 0xF27A90 VA: 0x180F29090
	|-ReadOnlyArrayExtensions.Contains<InternedString>
	|
	|-RVA: 0xF28EC0 Offset: 0xF278C0 VA: 0x180F28EC0
	|-ReadOnlyArrayExtensions.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ContainsReference<TValue>(ReadOnlyArray<TValue> array, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF28E20 Offset: 0xF27820 VA: 0x180F28E20
	|-ReadOnlyArrayExtensions.ContainsReference<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfReference<TValue>(ReadOnlyArray<TValue> array, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF29560 Offset: 0xF27F60 VA: 0x180F29560
	|-ReadOnlyArrayExtensions.IndexOfReference<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static bool HaveEqualReferences<TValue>(ReadOnlyArray<TValue> array1, IReadOnlyList<TValue> array2, int count = 2147483647) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF293B0 Offset: 0xF27DB0 VA: 0x180F293B0
	|-ReadOnlyArrayExtensions.HaveEqualReferences<object>
	|
	|-RVA: 0xF29150 Offset: 0xF27B50 VA: 0x180F29150
	|-ReadOnlyArrayExtensions.HaveEqualReferences<__Il2CppFullySharedGenericType>
	*/
}
