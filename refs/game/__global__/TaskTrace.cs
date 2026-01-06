internal static class TaskTrace // TypeDefIndex: 3549
{
	// Fields
	private static TaskTraceCallbacks s_callbacks; // 0x0

	// Properties
	public static bool Enabled { get; }

	// Methods

	// RVA: 0x1AB4AF0 Offset: 0x1AB34F0 VA: 0x181AB4AF0
	public static bool get_Enabled() { }

	// RVA: 0x1AB4970 Offset: 0x1AB3370 VA: 0x181AB4970
	public static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x1AB49F0 Offset: 0x1AB33F0 VA: 0x181AB49F0
	public static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x1AB4A70 Offset: 0x1AB3470 VA: 0x181AB4A70
	public static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x1AB48D0 Offset: 0x1AB32D0 VA: 0x181AB48D0
	public static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions) { }
}
