internal sealed class CompletionActionInvoker : IThreadPoolWorkItem // TypeDefIndex: 4054
{
	// Fields
	private readonly ITaskCompletionAction m_action; // 0x10
	private readonly Task m_completingTask; // 0x18

	// Methods

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	internal void .ctor(ITaskCompletionAction action, Task completingTask) { }

	// RVA: 0x1CEEB90 Offset: 0x1CED590 VA: 0x181CEEB90 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void MarkAborted(ThreadAbortException e) { }
}
