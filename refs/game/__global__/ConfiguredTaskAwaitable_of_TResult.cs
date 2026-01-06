public struct ConfiguredTaskAwaitable<TResult> // TypeDefIndex: 4624
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D8A90 Offset: 0x14D7490 VA: 0x1814D8A90
	|-ConfiguredTaskAwaitable<Nullable<bool>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<DateTime>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<DateTimeOffset>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<Decimal>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<double>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<int>>..ctor
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>..ctor
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>..ctor
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>..ctor
	|-ConfiguredTaskAwaitable<bool>..ctor
	|-ConfiguredTaskAwaitable<ChannelToken>..ctor
	|-ConfiguredTaskAwaitable<char>..ctor
	|-ConfiguredTaskAwaitable<int>..ctor
	|-ConfiguredTaskAwaitable<object>..ctor
	|-ConfiguredTaskAwaitable<SerializableProjectConfiguration>..ctor
	|-ConfiguredTaskAwaitable<VoidTaskResult>..ctor
	|-ConfiguredTaskAwaitable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4944C0 Offset: 0x492EC0 VA: 0x1804944C0
	|-ConfiguredTaskAwaitable<Nullable<bool>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<DateTime>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<DateTimeOffset>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<Decimal>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<double>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<int>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|-ConfiguredTaskAwaitable<bool>.GetAwaiter
	|-ConfiguredTaskAwaitable<ChannelToken>.GetAwaiter
	|-ConfiguredTaskAwaitable<char>.GetAwaiter
	|-ConfiguredTaskAwaitable<int>.GetAwaiter
	|-ConfiguredTaskAwaitable<object>.GetAwaiter
	|-ConfiguredTaskAwaitable<SerializableProjectConfiguration>.GetAwaiter
	|-ConfiguredTaskAwaitable<VoidTaskResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<__Il2CppFullySharedGenericType>.GetAwaiter
	*/
}
