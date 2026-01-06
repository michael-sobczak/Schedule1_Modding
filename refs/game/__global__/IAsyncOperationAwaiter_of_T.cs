internal interface IAsyncOperationAwaiter<T> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 17831
{
	// Properties
	public abstract bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsCompleted();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncOperationAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T GetResult();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncOperationAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/
}
