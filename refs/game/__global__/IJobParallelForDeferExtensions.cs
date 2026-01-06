public static class IJobParallelForDeferExtensions // TypeDefIndex: 15696
{
	// Methods

	// RVA: -1 Offset: -1
	public static void EarlyJobInit<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC6970 Offset: 0xEC5370 VA: 0x180EC6970
	|-IJobParallelForDeferExtensions.EarlyJobInit<__Il2CppFullySharedGenericStructType>
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x27310B0 Offset: 0x272FAB0 VA: 0x1827310B0
	private static void CheckReflectionDataCorrect(IntPtr reflectionData) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T, U>(T jobData, NativeList<U> list, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC9A10 Offset: 0xEC8410 VA: 0x180EC9A10
	|-IJobParallelForDeferExtensions.Schedule<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle ScheduleByRef<T, U>(ref T jobData, NativeList<U> list, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC9A10 Offset: 0xEC8410 VA: 0x180EC9A10
	|-IJobParallelForDeferExtensions.ScheduleByRef<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T>(T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC9AD0 Offset: 0xEC84D0 VA: 0x180EC9AD0
	|-IJobParallelForDeferExtensions.Schedule<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle ScheduleByRef<T>(ref T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC9AD0 Offset: 0xEC84D0 VA: 0x180EC9AD0
	|-IJobParallelForDeferExtensions.ScheduleByRef<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static JobHandle ScheduleInternal<T>(ref T jobData, int innerloopBatchCount, void* forEachListPtr, void* atomicSafetyHandlePtr, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC9B80 Offset: 0xEC8580 VA: 0x180EC9B80
	|-IJobParallelForDeferExtensions.ScheduleInternal<__Il2CppFullySharedGenericStructType>
	*/
}
