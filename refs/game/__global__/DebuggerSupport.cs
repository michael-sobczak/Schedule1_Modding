internal static class DebuggerSupport // TypeDefIndex: 4040
{
	// Fields
	private static readonly LowLevelDictionary<int, Task> s_activeTasks; // 0x0
	private static readonly object s_activeTasksLock; // 0x8

	// Properties
	public static bool LoggingOn { get; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool get_LoggingOn() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	// RVA: 0x1CEF070 Offset: 0x1CEDA70 VA: 0x181CEF070
	public static void AddToActiveTasks(Task task) { }

	// RVA: 0x1CEEF30 Offset: 0x1CED930 VA: 0x181CEEF30
	private static void AddToActiveTasksNonInlined(Task task) { }

	// RVA: 0x1CEF230 Offset: 0x1CEDC30 VA: 0x181CEF230
	public static void RemoveFromActiveTasks(Task task) { }

	// RVA: 0x1CEF100 Offset: 0x1CEDB00 VA: 0x181CEF100
	private static void RemoveFromActiveTasksNonInlined(Task task) { }

	// RVA: 0x1CEF2C0 Offset: 0x1CEDCC0 VA: 0x181CEF2C0
	private static void .cctor() { }
}
