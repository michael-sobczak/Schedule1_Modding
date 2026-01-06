internal struct AsyncMethodBuilderCore // TypeDefIndex: 4634
{
	// Fields
	internal IAsyncStateMachine m_stateMachine; // 0x0
	internal Action m_defaultContextAction; // 0x8

	// Methods

	// RVA: 0x1B5EED0 Offset: 0x1B5D8D0 VA: 0x181B5EED0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x1B5E8F0 Offset: 0x1B5D2F0 VA: 0x181B5E8F0
	internal Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize) { }

	// RVA: 0x1B5EB10 Offset: 0x1B5D510 VA: 0x181B5EB10
	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	// RVA: 0x1B5ECF0 Offset: 0x1B5D6F0 VA: 0x181B5ECF0
	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask) { }

	// RVA: 0x1B5EFA0 Offset: 0x1B5D9A0 VA: 0x181B5EFA0
	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	// RVA: 0x1B5E7B0 Offset: 0x1B5D1B0 VA: 0x181B5E7B0
	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0x1B5F290 Offset: 0x1B5DC90 VA: 0x181B5F290
	internal static Task TryGetContinuationTask(Action action) { }
}
