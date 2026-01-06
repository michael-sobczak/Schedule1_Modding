internal abstract class AsyncOperationBase<T> : CustomYieldInstruction, IAsyncOperation<T>, IEnumerator, INotifyCompletion // TypeDefIndex: 17823
{
	// Fields
	private Action<IAsyncOperation<T>> m_CompletedCallback; // 0x0

	// Properties
	public override bool keepWaiting { get; }
	public abstract bool IsCompleted { get; }
	public bool IsDone { get; }
	public abstract AsyncOperationStatus Status { get; }
	public abstract Exception Exception { get; }
	public abstract T Result { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public override bool get_keepWaiting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129EE10 Offset: 0x129D810 VA: 0x18129EE10
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_keepWaiting
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsCompleted();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4DD630 Offset: 0x4DC030 VA: 0x1804DD630
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_IsDone
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public abstract AsyncOperationStatus get_Status();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Status
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public abstract Exception get_Exception();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Exception
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public abstract T get_Result();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public abstract T GetResult();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public abstract AsyncOperationBase<T> GetAwaiter();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void add_Completed(Action<IAsyncOperation<T>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129ECC0 Offset: 0x129D6C0 VA: 0x18129ECC0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_Completed
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void remove_Completed(Action<IAsyncOperation<T>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129EE40 Offset: 0x129D840 VA: 0x18129EE40
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_Completed
	*/

	// RVA: -1 Offset: -1
	protected void DidComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129EB80 Offset: 0x129D580 VA: 0x18129EB80
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.DidComplete
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public virtual void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129EBC0 Offset: 0x129D5C0 VA: 0x18129EBC0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>..ctor
	*/
}
