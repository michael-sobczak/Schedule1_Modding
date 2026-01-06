internal class CancellationCallbackInfo // TypeDefIndex: 3947
{
	// Fields
	internal readonly Action<object> Callback; // 0x10
	internal readonly object StateForCallback; // 0x18
	internal readonly ExecutionContext TargetExecutionContext; // 0x20
	internal readonly CancellationTokenSource CancellationTokenSource; // 0x28
	private static ContextCallback s_executionContextCallback; // 0x0

	// Methods

	// RVA: 0x1CD3000 Offset: 0x1CD1A00 VA: 0x181CD3000
	internal void .ctor(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	// RVA: 0x1CD2E10 Offset: 0x1CD1810 VA: 0x181CD2E10
	internal void ExecuteCallback() { }

	// RVA: 0x1CD2F80 Offset: 0x1CD1980 VA: 0x181CD2F80
	private static void ExecutionContextCallback(object obj) { }
}
