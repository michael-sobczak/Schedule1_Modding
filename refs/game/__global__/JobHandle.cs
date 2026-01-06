public struct JobHandle : IEquatable<JobHandle> // TypeDefIndex: 11480
{
	// Fields
	internal ulong jobGroup; // 0x0
	internal int version; // 0x8

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x2C8FAA0 Offset: 0x2C8E4A0 VA: 0x182C8FAA0
	public void Complete() { }

	// RVA: 0x2C8FB30 Offset: 0x2C8E530 VA: 0x182C8FB30
	public bool get_IsCompleted() { }

	[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x2C8FB70 Offset: 0x2C8E570 VA: 0x182C8FB70
	public static void ScheduleBatchedJobs() { }

	[NativeMethod("ScheduleBatchedScriptingJobsAndComplete", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x2C8FAF0 Offset: 0x2C8E4F0 VA: 0x182C8FAF0
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[NativeMethod("ScheduleBatchedScriptingJobsAndIsCompleted", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x2C8FB30 Offset: 0x2C8E530 VA: 0x182C8FB30
	private static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job) { }

	// RVA: 0x2C8FA30 Offset: 0x2C8E430 VA: 0x182C8FA30
	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	// RVA: 0x2C8F8C0 Offset: 0x2C8E2C0 VA: 0x182C8F8C0
	public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs) { }

	// RVA: 0x2C8F970 Offset: 0x2C8E370 VA: 0x182C8F970
	public static JobHandle CombineDependencies(NativeSlice<JobHandle> jobs) { }

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x2C8F7B0 Offset: 0x2C8E1B0 VA: 0x182C8F7B0
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x2C8F860 Offset: 0x2C8E260 VA: 0x182C8F860
	internal static JobHandle CombineDependenciesInternalPtr(void* jobs, int count) { }

	// RVA: 0x2C8FAE0 Offset: 0x2C8E4E0 VA: 0x182C8FAE0 Slot: 4
	public bool Equals(JobHandle other) { }

	// RVA: 0x2C8F750 Offset: 0x2C8E150 VA: 0x182C8F750
	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

	// RVA: 0x2C8F810 Offset: 0x2C8E210 VA: 0x182C8F810
	private static void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret) { }
}
