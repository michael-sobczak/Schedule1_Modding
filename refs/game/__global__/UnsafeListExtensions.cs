public static class UnsafeListExtensions // TypeDefIndex: 15970
{
	// Methods

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T, U>(UnsafeList<T> list, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF69340 Offset: 0xF67D40 VA: 0x180F69340
	|-UnsafeListExtensions.IndexOf<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<T, U>(UnsafeList<T> list, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF69160 Offset: 0xF67B60 VA: 0x180F69160
	|-UnsafeListExtensions.Contains<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static int IndexOf<T, U>(UnsafeList.ParallelReader<T> list, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF69250 Offset: 0xF67C50 VA: 0x180F69250
	|-UnsafeListExtensions.IndexOf<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static bool Contains<T, U>(UnsafeList.ParallelReader<T> list, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF69070 Offset: 0xF67A70 VA: 0x180F69070
	|-UnsafeListExtensions.Contains<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static bool ArraysEqual<T>(UnsafeList<T> array, UnsafeList<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08690 Offset: 0xF07090 VA: 0x180F08690
	|-UnsafeListExtensions.ArraysEqual<__Il2CppFullySharedGenericStructType>
	*/
}
