internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 4070
{
	// Fields
	private static readonly SendOrPostCallback s_postCallback; // 0x0
	private static ContextCallback s_postActionCallback; // 0x8
	private readonly SynchronizationContext m_syncContext; // 0x20

	// Methods

	// RVA: 0x1CF6290 Offset: 0x1CF4C90 VA: 0x181CF6290
	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext) { }

	// RVA: 0x1CF6010 Offset: 0x1CF4A10 VA: 0x181CF6010 Slot: 4
	internal sealed override void Run(Task ignored, bool canInlineContinuationTask) { }

	// RVA: 0x1CF5F60 Offset: 0x1CF4960 VA: 0x181CF5F60
	private static void PostAction(object state) { }

	// RVA: 0x1CF5E80 Offset: 0x1CF4880 VA: 0x181CF5E80
	private static ContextCallback GetPostActionCallback() { }

	// RVA: 0x1CF61C0 Offset: 0x1CF4BC0 VA: 0x181CF61C0
	private static void .cctor() { }
}
