public static class NativeReferenceUnsafeUtility // TypeDefIndex: 15957
{
	// Methods

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeReference<T> reference) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-NativeReferenceUnsafeUtility.GetUnsafePtr<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeReference<T> reference) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-NativeReferenceUnsafeUtility.GetUnsafeReadOnlyPtr<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtrWithoutChecks<T>(NativeReference<T> reference) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-NativeReferenceUnsafeUtility.GetUnsafePtrWithoutChecks<__Il2CppFullySharedGenericStructType>
	*/
}
