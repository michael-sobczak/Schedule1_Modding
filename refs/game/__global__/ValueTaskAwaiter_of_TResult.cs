public struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4617
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1318800 Offset: 0x1317200 VA: 0x181318800
	|-ValueTaskAwaiter<int>..ctor
	|
	|-RVA: 0x1318730 Offset: 0x1317130 VA: 0x181318730
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13188C0 Offset: 0x13172C0 VA: 0x1813188C0
	|-ValueTaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x1318810 Offset: 0x1317210 VA: 0x181318810
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13148E0 Offset: 0x13132E0 VA: 0x1813148E0
	|-ValueTaskAwaiter<int>.GetResult
	|
	|-RVA: 0x1318110 Offset: 0x1316B10 VA: 0x181318110
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1318230 Offset: 0x1316C30 VA: 0x181318230
	|-ValueTaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x1318420 Offset: 0x1316E20 VA: 0x181318420
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/
}
