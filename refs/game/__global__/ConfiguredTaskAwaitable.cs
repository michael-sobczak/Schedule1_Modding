public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4623
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0
	private readonly bool m_continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1330BD0 Offset: 0x132F5D0 VA: 0x181330BD0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<bool>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<DateTime>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<DateTimeOffset>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Decimal>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<double>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ChannelToken>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<char>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12113A0 Offset: 0x120FDA0 VA: 0x1812113A0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<bool>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<DateTime>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<DateTimeOffset>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Decimal>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<double>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ChannelToken>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<char>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D8B00 Offset: 0x14D7500 VA: 0x1814D8B00
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<bool>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<DateTime>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<DateTimeOffset>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Decimal>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<double>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ChannelToken>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<char>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12110B0 Offset: 0x120FAB0 VA: 0x1812110B0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<bool>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<char>.GetResult
	|
	|-RVA: 0x1211100 Offset: 0x120FB00 VA: 0x181211100
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<DateTime>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<double>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ChannelToken>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>.GetResult
	|
	|-RVA: 0x1211040 Offset: 0x120FA40 VA: 0x181211040
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<DateTimeOffset>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Decimal>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.GetResult
	|
	|-RVA: 0x1210FF0 Offset: 0x120F9F0 VA: 0x181210FF0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.GetResult
	|
	|-RVA: 0x1211310 Offset: 0x120FD10 VA: 0x181211310
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.GetResult
	|
	|-RVA: 0x1211270 Offset: 0x120FC70 VA: 0x181211270
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0x12112C0 Offset: 0x120FCC0 VA: 0x1812112C0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.GetResult
	|
	|-RVA: 0x1211160 Offset: 0x120FB60 VA: 0x181211160
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/
}
