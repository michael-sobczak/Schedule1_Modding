public static class IJobParallelForExtensionsBurstSchedulable // TypeDefIndex: 15692
{
	// Methods

	// RVA: -1 Offset: -1
	public static void EarlyJobInit<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC6970 Offset: 0xEC5370 VA: 0x180EC6970
	|-IJobParallelForExtensionsBurstSchedulable.EarlyJobInit<__Il2CppFullySharedGenericStructType>
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2731120 Offset: 0x272FB20 VA: 0x182731120
	private static void CheckReflectionDataCorrect(IntPtr reflectionData) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC98C0 Offset: 0xEC82C0 VA: 0x180EC98C0
	|-IJobParallelForExtensionsBurstSchedulable.Schedule<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Run<T>(T jobData, int arrayLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC97A0 Offset: 0xEC81A0 VA: 0x180EC97A0
	|-IJobParallelForExtensionsBurstSchedulable.Run<__Il2CppFullySharedGenericStructType>
	*/
}
