public static class NativeArrayExtensions // TypeDefIndex: 15849
{
	// Methods

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static bool Contains<T, U>(NativeArray<T> array, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08B00 Offset: 0xF07500 VA: 0x180F08B00
	|-NativeArrayExtensions.Contains<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static int IndexOf<T, U>(NativeArray<T> array, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08E10 Offset: 0xF07810 VA: 0x180F08E10
	|-NativeArrayExtensions.IndexOf<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static bool Contains<T, U>(NativeArray.ReadOnly<T> array, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08D20 Offset: 0xF07720 VA: 0x180F08D20
	|-NativeArrayExtensions.Contains<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static int IndexOf<T, U>(NativeArray.ReadOnly<T> array, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08F40 Offset: 0xF07940 VA: 0x180F08F40
	|-NativeArrayExtensions.IndexOf<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static bool Contains<T, U>(NativeList<T> list, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08B00 Offset: 0xF07500 VA: 0x180F08B00
	|-NativeArrayExtensions.Contains<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T, U>(NativeList<T> list, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08E10 Offset: 0xF07810 VA: 0x180F08E10
	|-NativeArrayExtensions.IndexOf<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static bool Contains<T, U>(void* ptr, int length, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08C30 Offset: 0xF07630 VA: 0x180F08C30
	|-NativeArrayExtensions.Contains<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static int IndexOf<T, U>(void* ptr, int length, U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09030 Offset: 0xF07A30 VA: 0x180F09030
	|-NativeArrayExtensions.IndexOf<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static NativeArray<U> Reinterpret<T, U>(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09780 Offset: 0xF08180 VA: 0x180F09780
	|-NativeArrayExtensions.Reinterpret<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static bool ArraysEqual<T>(NativeArray<T> array, NativeArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08690 Offset: 0xF07090 VA: 0x180F08690
	|-NativeArrayExtensions.ArraysEqual<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static bool ArraysEqual<T>(NativeList<T> array, NativeArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08900 Offset: 0xF07300 VA: 0x180F08900
	|-NativeArrayExtensions.ArraysEqual<__Il2CppFullySharedGenericStructType>
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void CheckReinterpretSize<T, U>(ref NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08980 Offset: 0xF07380 VA: 0x180F08980
	|-NativeArrayExtensions.CheckReinterpretSize<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	internal static void Initialize<T>(ref NativeArray<T> array, int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09270 Offset: 0xF07C70 VA: 0x180F09270
	|-NativeArrayExtensions.Initialize<byte>
	|
	|-RVA: 0xF09610 Offset: 0xF08010 VA: 0x180F09610
	|-NativeArrayExtensions.Initialize<int>
	|
	|-RVA: 0xF096C0 Offset: 0xF080C0 VA: 0x180F096C0
	|-NativeArrayExtensions.Initialize<float>
	|
	|-RVA: 0xF09490 Offset: 0xF07E90 VA: 0x180F09490
	|-NativeArrayExtensions.Initialize<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	internal static void Initialize<T, U>(ref NativeArray<T> array, int length, ref U allocator, NativeArrayOptions options = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09320 Offset: 0xF07D20 VA: 0x180F09320
	|-NativeArrayExtensions.Initialize<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/
}
