internal interface IAsyncOperationAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 17830
{
	// Properties
	public abstract bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsCompleted();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void GetResult();
}
