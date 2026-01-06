internal class AsyncOperation<T> : IAsyncOperation<T>, IEnumerator // TypeDefIndex: 17813
{
	// Fields
	[CompilerGenerated]
	private bool <IsDone>k__BackingField; // 0x0
	[CompilerGenerated]
	private AsyncOperationStatus <Status>k__BackingField; // 0x0
	[CompilerGenerated]
	private Exception <Exception>k__BackingField; // 0x0
	[CompilerGenerated]
	private T <Result>k__BackingField; // 0x0
	protected Action<IAsyncOperation<T>> m_CompletedCallback; // 0x0

	// Properties
	public bool IsDone { get; set; }
	public AsyncOperationStatus Status { get; set; }
	public Exception Exception { get; set; }
	public T Result { get; set; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F590 Offset: 0x129DF90 VA: 0x18129F590
	|-AsyncOperation<__Il2CppFullySharedGenericType>.get_IsDone
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_IsDone(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F7F0 Offset: 0x129E1F0 VA: 0x18129F7F0
	|-AsyncOperation<__Il2CppFullySharedGenericType>.set_IsDone
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE8F90 Offset: 0xFE7990 VA: 0x180FE8F90
	|-AsyncOperation<__Il2CppFullySharedGenericType>.get_Status
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_Status(AsyncOperationStatus value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F920 Offset: 0x129E320 VA: 0x18129F920
	|-AsyncOperation<__Il2CppFullySharedGenericType>.set_Status
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void add_Completed(Action<IAsyncOperation<T>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F400 Offset: 0x129DE00 VA: 0x18129F400
	|-AsyncOperation<__Il2CppFullySharedGenericType>.add_Completed
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void remove_Completed(Action<IAsyncOperation<T>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F670 Offset: 0x129E070 VA: 0x18129F670
	|-AsyncOperation<__Il2CppFullySharedGenericType>.remove_Completed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public Exception get_Exception() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F560 Offset: 0x129DF60 VA: 0x18129F560
	|-AsyncOperation<__Il2CppFullySharedGenericType>.get_Exception
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_Exception(Exception value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F780 Offset: 0x129E180 VA: 0x18129F780
	|-AsyncOperation<__Il2CppFullySharedGenericType>.set_Exception
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public T get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F5C0 Offset: 0x129DFC0 VA: 0x18129F5C0
	|-AsyncOperation<__Il2CppFullySharedGenericType>.get_Result
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_Result(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F860 Offset: 0x129E260 VA: 0x18129F860
	|-AsyncOperation<__Il2CppFullySharedGenericType>.set_Result
	*/

	// RVA: -1 Offset: -1
	public void SetInProgress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F1E0 Offset: 0x129DBE0 VA: 0x18129F1E0
	|-AsyncOperation<__Il2CppFullySharedGenericType>.SetInProgress
	*/

	// RVA: -1 Offset: -1
	public void Succeed(T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F200 Offset: 0x129DC00 VA: 0x18129F200
	|-AsyncOperation<__Il2CppFullySharedGenericType>.Succeed
	*/

	// RVA: -1 Offset: -1
	public void Fail(Exception reason) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F0A0 Offset: 0x129DAA0 VA: 0x18129F0A0
	|-AsyncOperation<__Il2CppFullySharedGenericType>.Fail
	*/

	// RVA: -1 Offset: -1
	public void Cancel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129EF30 Offset: 0x129D930 VA: 0x18129EF30
	|-AsyncOperation<__Il2CppFullySharedGenericType>.Cancel
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.IEnumerator.MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F3D0 Offset: 0x129DDD0 VA: 0x18129F3D0
	|-AsyncOperation<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-AsyncOperation<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	|-AsyncOperation<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	|-AsyncOperation<__Il2CppFullySharedGenericType>..ctor
	*/
}
