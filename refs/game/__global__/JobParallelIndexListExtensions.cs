public static class JobParallelIndexListExtensions // TypeDefIndex: 15701
{
	// Methods

	// RVA: -1 Offset: -1
	public static void EarlyJobInit<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC6970 Offset: 0xEC5370 VA: 0x180EC6970
	|-JobParallelIndexListExtensions.EarlyJobInit<__Il2CppFullySharedGenericStructType>
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x27311F0 Offset: 0x272FBF0 VA: 0x1827311F0
	private static void CheckReflectionDataCorrect(IntPtr reflectionData) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle ScheduleAppend<T>(T jobData, NativeList<int> indices, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5600 Offset: 0xEE4000 VA: 0x180EE5600
	|-JobParallelIndexListExtensions.ScheduleAppend<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle ScheduleFilter<T>(T jobData, NativeList<int> indices, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE58E0 Offset: 0xEE42E0 VA: 0x180EE58E0
	|-JobParallelIndexListExtensions.ScheduleFilter<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void RunAppend<T>(T jobData, NativeList<int> indices, int arrayLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE50A0 Offset: 0xEE3AA0 VA: 0x180EE50A0
	|-JobParallelIndexListExtensions.RunAppend<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void RunFilter<T>(T jobData, NativeList<int> indices) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5350 Offset: 0xEE3D50 VA: 0x180EE5350
	|-JobParallelIndexListExtensions.RunFilter<__Il2CppFullySharedGenericStructType>
	*/
}
