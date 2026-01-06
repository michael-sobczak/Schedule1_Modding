public static class JobsUtility // TypeDefIndex: 11486
{
	// Fields
	internal static JobsUtility.PanicFunction_ PanicFunction; // 0x0

	// Properties
	public static bool IsExecutingJob { get; }
	public static bool JobCompilerEnabled { set; }

	// Methods

	// RVA: 0x2C8FD20 Offset: 0x2C8E720 VA: 0x182C8FD20
	public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x2C8FD70 Offset: 0x2C8E770 VA: 0x182C8FD70
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[FreeFunction("ScheduleManagedJob", ThrowsException = True, IsThreadSafe = True)]
	// RVA: 0x2C900E0 Offset: 0x2C8EAE0 VA: 0x182C900E0
	public static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters) { }

	[FreeFunction("ScheduleManagedJobParallelFor", ThrowsException = True, IsThreadSafe = True)]
	// RVA: 0x2C90020 Offset: 0x2C8EA20 VA: 0x182C90020
	public static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[FreeFunction("ScheduleManagedJobParallelForDeferArraySize", ThrowsException = True, IsThreadSafe = True)]
	// RVA: 0x2C8FE80 Offset: 0x2C8E880 VA: 0x182C8FE80
	public static JobHandle ScheduleParallelForDeferArraySize(ref JobsUtility.JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle) { }

	[FreeFunction("ScheduleManagedJobParallelForTransform", ThrowsException = True)]
	// RVA: 0x2C8FF60 Offset: 0x2C8E960 VA: 0x182C8FF60
	public static JobHandle ScheduleParallelForTransform(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray) { }

	[FreeFunction(ThrowsException = True, IsThreadSafe = True)]
	// RVA: 0x2C8FC50 Offset: 0x2C8E650 VA: 0x182C8FC50
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x2C8FBE0 Offset: 0x2C8E5E0 VA: 0x182C8FBE0
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x2C8FCC0 Offset: 0x2C8E6C0 VA: 0x182C8FCC0
	public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0) { }

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x2C90130 Offset: 0x2C8EB30 VA: 0x182C90130
	public static bool get_IsExecutingJob() { }

	[FreeFunction]
	// RVA: 0x2C90160 Offset: 0x2C8EB60 VA: 0x182C90160
	public static void set_JobCompilerEnabled(bool value) { }

	[RequiredByNativeCode]
	// RVA: 0x2C8FDD0 Offset: 0x2C8E7D0 VA: 0x182C8FDD0
	private static void InvokePanicFunction() { }

	// RVA: 0x2C90090 Offset: 0x2C8EA90 VA: 0x182C90090
	private static void Schedule_Injected(ref JobsUtility.JobScheduleParameters parameters, out JobHandle ret) { }

	// RVA: 0x2C8FFC0 Offset: 0x2C8E9C0 VA: 0x182C8FFC0
	private static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

	// RVA: 0x2C8FE20 Offset: 0x2C8E820 VA: 0x182C8FE20
	private static void ScheduleParallelForDeferArraySize_Injected(ref JobsUtility.JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle, out JobHandle ret) { }

	// RVA: 0x2C8FF00 Offset: 0x2C8E900 VA: 0x182C8FF00
	private static void ScheduleParallelForTransform_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) { }
}
