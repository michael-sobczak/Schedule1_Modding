internal class WebCompletionSource<T> // TypeDefIndex: 10089
{
	// Fields
	private TaskCompletionSource<WebCompletionSource.Result<T>> completion; // 0x0
	private WebCompletionSource.Result<T> currentResult; // 0x0

	// Properties
	internal WebCompletionSource.Result<T> CurrentResult { get; }
	internal Task Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(bool runAsync = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C7960 Offset: 0x13C6360 VA: 0x1813C7960
	|-WebCompletionSource<ValueTuple<bool, object>>..ctor
	|-WebCompletionSource<object>..ctor
	|
	|-RVA: 0x13C7A00 Offset: 0x13C6400 VA: 0x1813C7A00
	|-WebCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal WebCompletionSource.Result<T> get_CurrentResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-WebCompletionSource<ValueTuple<bool, object>>.get_CurrentResult
	|-WebCompletionSource<object>.get_CurrentResult
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.get_CurrentResult
	*/

	// RVA: -1 Offset: -1
	internal Task get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C7AA0 Offset: 0x13C64A0 VA: 0x1813C7AA0
	|-WebCompletionSource<ValueTuple<bool, object>>.get_Task
	|-WebCompletionSource<object>.get_Task
	|
	|-RVA: 0x10EB270 Offset: 0x10E9C70 VA: 0x1810EB270
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCompleted(T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C73F0 Offset: 0x13C5DF0 VA: 0x1813C73F0
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCompleted
	|
	|-RVA: 0x13C7020 Offset: 0x13C5A20 VA: 0x1813C7020
	|-WebCompletionSource<object>.TrySetCompleted
	|
	|-RVA: 0x13C7280 Offset: 0x13C5C80 VA: 0x1813C7280
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C70E0 Offset: 0x13C5AE0 VA: 0x1813C70E0
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCompleted
	|-WebCompletionSource<object>.TrySetCompleted
	|
	|-RVA: 0x13C71A0 Offset: 0x13C5BA0 VA: 0x1813C71A0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C6F10 Offset: 0x13C5910 VA: 0x1813C6F10
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0x13C6D80 Offset: 0x13C5780 VA: 0x1813C6D80
	|-WebCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x13C6E90 Offset: 0x13C5890 VA: 0x1813C6E90
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(OperationCanceledException error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C6CB0 Offset: 0x13C56B0 VA: 0x1813C6CB0
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|-WebCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x13C6BD0 Offset: 0x13C55D0 VA: 0x1813C6BD0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetException(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C7590 Offset: 0x13C5F90 VA: 0x1813C7590
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetException
	|-WebCompletionSource<object>.TrySetException
	|
	|-RVA: 0x13C74B0 Offset: 0x13C5EB0 VA: 0x1813C74B0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetException
	*/

	// RVA: -1 Offset: -1
	public void ThrowOnError() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C6A60 Offset: 0x13C5460 VA: 0x1813C6A60
	|-WebCompletionSource<ValueTuple<bool, object>>.ThrowOnError
	|-WebCompletionSource<object>.ThrowOnError
	|
	|-RVA: 0x13C6AE0 Offset: 0x13C54E0 VA: 0x1813C6AE0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.ThrowOnError
	*/

	[AsyncStateMachine(typeof(WebCompletionSource.<WaitForCompletion>d__15<T>))]
	// RVA: -1 Offset: -1
	public Task<T> WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C7760 Offset: 0x13C6160 VA: 0x1813C7760
	|-WebCompletionSource<ValueTuple<bool, object>>.WaitForCompletion
	|
	|-RVA: 0x13C7860 Offset: 0x13C6260 VA: 0x1813C7860
	|-WebCompletionSource<object>.WaitForCompletion
	|
	|-RVA: 0x13C7660 Offset: 0x13C6060 VA: 0x1813C7660
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/
}
