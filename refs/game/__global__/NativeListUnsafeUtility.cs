public static class NativeListUnsafeUtility // TypeDefIndex: 15956
{
	// Methods

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09B50 Offset: 0xF08550 VA: 0x180F09B50
	|-NativeListUnsafeUtility.GetUnsafePtr<byte>
	|-NativeListUnsafeUtility.GetUnsafePtr<int>
	|-NativeListUnsafeUtility.GetUnsafePtr<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09B50 Offset: 0xF08550 VA: 0x180F09B50
	|-NativeListUnsafeUtility.GetUnsafeReadOnlyPtr<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void* GetInternalListDataPtrUnchecked<T>(ref NativeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-NativeListUnsafeUtility.GetInternalListDataPtrUnchecked<__Il2CppFullySharedGenericStructType>
	*/
}
