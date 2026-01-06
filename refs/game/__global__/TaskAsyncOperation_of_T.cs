internal class TaskAsyncOperation<T> : AsyncOperationBase<T> // TypeDefIndex: 17835
{
	// Fields
	private Task<T> m_Task; // 0x0

	// Properties
	public override bool IsCompleted { get; }
	public override T Result { get; }
	public override AsyncOperationStatus Status { get; }
	public override Exception Exception { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 15
	public override bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1210EA0 Offset: 0x120F8A0 VA: 0x181210EA0
	|-TaskAsyncOperation<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public override T get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1210EC0 Offset: 0x120F8C0 VA: 0x181210EC0
	|-TaskAsyncOperation<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public override T GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12109C0 Offset: 0x120F3C0 VA: 0x1812109C0
	|-TaskAsyncOperation<__Il2CppFullySharedGenericType>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public override AsyncOperationBase<T> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	|-TaskAsyncOperation<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public override AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1210F70 Offset: 0x120F970 VA: 0x181210F70
	|-TaskAsyncOperation<__Il2CppFullySharedGenericType>.get_Status
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override Exception get_Exception() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1210E80 Offset: 0x120F880 VA: 0x181210E80
	|-TaskAsyncOperation<__Il2CppFullySharedGenericType>.get_Exception
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Task<T> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1210C00 Offset: 0x120F600 VA: 0x181210C00
	|-TaskAsyncOperation<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static TaskAsyncOperation<T> Run(Func<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1210AA0 Offset: 0x120F4A0 VA: 0x181210AA0
	|-TaskAsyncOperation<__Il2CppFullySharedGenericType>.Run
	*/
}
