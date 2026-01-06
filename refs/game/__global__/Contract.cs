public static class Contract // TypeDefIndex: 4874
{
	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: -1 Offset: -1
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6ADE0 Offset: 0xE697E0 VA: 0x180E6ADE0
	|-Contract.ForAll<object>
	|
	|-RVA: 0xE6AAF0 Offset: 0xE694F0 VA: 0x180E6AAF0
	|-Contract.ForAll<__Il2CppFullySharedGenericType>
	*/
}
