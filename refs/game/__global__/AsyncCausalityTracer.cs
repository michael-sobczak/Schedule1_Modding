internal static class AsyncCausalityTracer // TypeDefIndex: 4088
{
	// Properties
	[FriendAccessAllowed]
	internal static bool LoggingOn { get; }

	// Methods

	[FriendAccessAllowed]
	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	internal static bool get_LoggingOn() { }

	[FriendAccessAllowed]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[FriendAccessAllowed]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }
}
