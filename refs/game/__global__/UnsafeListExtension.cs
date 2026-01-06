public static class UnsafeListExtension // TypeDefIndex: 15930
{
	// Methods

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	internal static ref UnsafeList ListData<T>(ref UnsafeList<T> from) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF064A0 Offset: 0xF04EA0 VA: 0x180F064A0
	|-UnsafeListExtension.ListData<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Sort<T>(UnsafeList list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF68FF0 Offset: 0xF679F0 VA: 0x180F68FF0
	|-UnsafeListExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Sort<T, U>(UnsafeList list, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF68E20 Offset: 0xF67820 VA: 0x180F68E20
	|-UnsafeListExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Obsolete("Instead call SortJob(this UnsafeList).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	[Extension]
	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T>(UnsafeList container, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF68F20 Offset: 0xF67920 VA: 0x180F68F20
	|-UnsafeListExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static SortJob<T, NativeSortExtension.DefaultComparer<T>> SortJob<T>(UnsafeList list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF68C30 Offset: 0xF67630 VA: 0x180F68C30
	|-UnsafeListExtension.SortJob<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this UnsafeList, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T, U>(UnsafeList container, U comp, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF68CE0 Offset: 0xF676E0 VA: 0x180F68CE0
	|-UnsafeListExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static SortJob<T, U> SortJob<T, U>(UnsafeList list, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF68AE0 Offset: 0xF674E0 VA: 0x180F68AE0
	|-UnsafeListExtension.SortJob<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(UnsafeList container, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF68A10 Offset: 0xF67410 VA: 0x180F68A10
	|-UnsafeListExtension.BinarySearch<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T, U>(UnsafeList container, T value, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF688C0 Offset: 0xF672C0 VA: 0x180F688C0
	|-UnsafeListExtension.BinarySearch<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/
}
