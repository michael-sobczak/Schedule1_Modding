public static class IJobParallelForBatchExtensions // TypeDefIndex: 15688
{
	// Methods

	// RVA: -1 Offset: -1
	public static void EarlyJobInit<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC6970 Offset: 0xEC5370 VA: 0x180EC6970
	|-IJobParallelForBatchExtensions.EarlyJobInit<__Il2CppFullySharedGenericStructType>
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2731040 Offset: 0x272FA40 VA: 0x182731040
	private static void CheckReflectionDataCorrect(IntPtr reflectionData) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle ScheduleBatch<T>(T jobData, int arrayLength, int minIndicesPerJobCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC98C0 Offset: 0xEC82C0 VA: 0x180EC98C0
	|-IJobParallelForBatchExtensions.ScheduleBatch<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void RunBatch<T>(T jobData, int arrayLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC97A0 Offset: 0xEC81A0 VA: 0x180EC97A0
	|-IJobParallelForBatchExtensions.RunBatch<__Il2CppFullySharedGenericStructType>
	*/
}
