public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4620
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	|-TaskAwaiter<Nullable<bool>>..ctor
	|-TaskAwaiter<Nullable<DateTime>>..ctor
	|-TaskAwaiter<Nullable<DateTimeOffset>>..ctor
	|-TaskAwaiter<Nullable<Decimal>>..ctor
	|-TaskAwaiter<Nullable<double>>..ctor
	|-TaskAwaiter<Nullable<int>>..ctor
	|-TaskAwaiter<ValueTuple<bool, object>>..ctor
	|-TaskAwaiter<ValueTuple<object, object, int>>..ctor
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>..ctor
	|-TaskAwaiter<bool>..ctor
	|-TaskAwaiter<ChannelToken>..ctor
	|-TaskAwaiter<char>..ctor
	|-TaskAwaiter<int>..ctor
	|-TaskAwaiter<object>..ctor
	|-TaskAwaiter<SerializableProjectConfiguration>..ctor
	|-TaskAwaiter<VoidTaskResult>..ctor
	|-TaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12113A0 Offset: 0x120FDA0 VA: 0x1812113A0
	|-TaskAwaiter<Nullable<bool>>.get_IsCompleted
	|-TaskAwaiter<Nullable<DateTime>>.get_IsCompleted
	|-TaskAwaiter<Nullable<DateTimeOffset>>.get_IsCompleted
	|-TaskAwaiter<Nullable<Decimal>>.get_IsCompleted
	|-TaskAwaiter<Nullable<double>>.get_IsCompleted
	|-TaskAwaiter<Nullable<int>>.get_IsCompleted
	|-TaskAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|-TaskAwaiter<ValueTuple<object, object, int>>.get_IsCompleted
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.get_IsCompleted
	|-TaskAwaiter<bool>.get_IsCompleted
	|-TaskAwaiter<ChannelToken>.get_IsCompleted
	|-TaskAwaiter<char>.get_IsCompleted
	|-TaskAwaiter<int>.get_IsCompleted
	|-TaskAwaiter<object>.get_IsCompleted
	|-TaskAwaiter<SerializableProjectConfiguration>.get_IsCompleted
	|-TaskAwaiter<VoidTaskResult>.get_IsCompleted
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1211380 Offset: 0x120FD80 VA: 0x181211380
	|-TaskAwaiter<Nullable<bool>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<DateTime>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<DateTimeOffset>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<Decimal>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<double>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|-TaskAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|-TaskAwaiter<ValueTuple<object, object, int>>.UnsafeOnCompleted
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.UnsafeOnCompleted
	|-TaskAwaiter<bool>.UnsafeOnCompleted
	|-TaskAwaiter<ChannelToken>.UnsafeOnCompleted
	|-TaskAwaiter<char>.UnsafeOnCompleted
	|-TaskAwaiter<int>.UnsafeOnCompleted
	|-TaskAwaiter<object>.UnsafeOnCompleted
	|-TaskAwaiter<SerializableProjectConfiguration>.UnsafeOnCompleted
	|-TaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12110B0 Offset: 0x120FAB0 VA: 0x1812110B0
	|-TaskAwaiter<Nullable<bool>>.GetResult
	|-TaskAwaiter<char>.GetResult
	|
	|-RVA: 0x1211100 Offset: 0x120FB00 VA: 0x181211100
	|-TaskAwaiter<Nullable<DateTime>>.GetResult
	|-TaskAwaiter<Nullable<double>>.GetResult
	|-TaskAwaiter<ValueTuple<bool, object>>.GetResult
	|-TaskAwaiter<ChannelToken>.GetResult
	|-TaskAwaiter<SerializableProjectConfiguration>.GetResult
	|
	|-RVA: 0x1211040 Offset: 0x120FA40 VA: 0x181211040
	|-TaskAwaiter<Nullable<DateTimeOffset>>.GetResult
	|-TaskAwaiter<Nullable<Decimal>>.GetResult
	|-TaskAwaiter<ValueTuple<object, object, int>>.GetResult
	|
	|-RVA: 0x1210FF0 Offset: 0x120F9F0 VA: 0x181210FF0
	|-TaskAwaiter<Nullable<int>>.GetResult
	|-TaskAwaiter<object>.GetResult
	|
	|-RVA: 0x1211310 Offset: 0x120FD10 VA: 0x181211310
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.GetResult
	|
	|-RVA: 0x1211270 Offset: 0x120FC70 VA: 0x181211270
	|-TaskAwaiter<bool>.GetResult
	|-TaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0x12112C0 Offset: 0x120FCC0 VA: 0x1812112C0
	|-TaskAwaiter<int>.GetResult
	|
	|-RVA: 0x1211160 Offset: 0x120FB60 VA: 0x181211160
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/
}
