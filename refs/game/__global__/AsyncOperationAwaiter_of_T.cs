internal struct AsyncOperationAwaiter<T> : IAsyncOperationAwaiter<T>, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 17819
{
	// Fields
	private IAsyncOperation<T> m_Operation; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IAsyncOperation<T> asyncOperation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	|-AsyncOperationAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129E710 Offset: 0x129D110 VA: 0x18129E710
	|-AsyncOperationAwaiter<__Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129E8E0 Offset: 0x129D2E0 VA: 0x18129E8E0
	|-AsyncOperationAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129EAB0 Offset: 0x129D4B0 VA: 0x18129EAB0
	|-AsyncOperationAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129E4D0 Offset: 0x129CED0 VA: 0x18129E4D0
	|-AsyncOperationAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/
}
