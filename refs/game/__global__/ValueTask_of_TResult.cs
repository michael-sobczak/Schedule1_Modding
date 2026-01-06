public struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> // TypeDefIndex: 4017
{
	// Fields
	private static Task<TResult> s_canceledTask; // 0x0
	internal readonly object _obj; // 0x0
	internal readonly TResult _result; // 0x0
	internal readonly short _token; // 0x0
	internal readonly bool _continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TResult Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131AE40 Offset: 0x1319840 VA: 0x18131AE40
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x1295350 Offset: 0x1293D50 VA: 0x181295350
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131AE70 Offset: 0x1319870 VA: 0x18131AE70
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x1295550 Offset: 0x1293F50 VA: 0x181295550
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IValueTaskSource<TResult> source, short token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131AF00 Offset: 0x1319900 VA: 0x18131AF00
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x1314C20 Offset: 0x1313620 VA: 0x181314C20
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(object obj, TResult result, short token, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131AEC0 Offset: 0x13198C0 VA: 0x18131AEC0
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x1314DE0 Offset: 0x13137E0 VA: 0x181314DE0
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1319EC0 Offset: 0x13188C0 VA: 0x181319EC0
	|-ValueTask<int>.GetHashCode
	|
	|-RVA: 0x1319BF0 Offset: 0x13185F0 VA: 0x181319BF0
	|-ValueTask<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13193E0 Offset: 0x1317DE0 VA: 0x1813193E0
	|-ValueTask<int>.Equals
	|
	|-RVA: 0x1319500 Offset: 0x1317F00 VA: 0x181319500
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1319340 Offset: 0x1317D40 VA: 0x181319340
	|-ValueTask<int>.Equals
	|
	|-RVA: 0x1319640 Offset: 0x1318040 VA: 0x181319640
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> AsTask() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1319140 Offset: 0x1317B40 VA: 0x181319140
	|-ValueTask<int>.AsTask
	|
	|-RVA: 0x1318EB0 Offset: 0x13178B0 VA: 0x181318EB0
	|-ValueTask<__Il2CppFullySharedGenericType>.AsTask
	*/

	// RVA: -1 Offset: -1
	private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1319F20 Offset: 0x1318920 VA: 0x181319F20
	|-ValueTask<int>.GetTaskForValueTaskSource
	|
	|-RVA: 0x131A450 Offset: 0x1318E50 VA: 0x18131A450
	|-ValueTask<__Il2CppFullySharedGenericType>.GetTaskForValueTaskSource
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131B060 Offset: 0x1319A60 VA: 0x18131B060
	|-ValueTask<int>.get_IsCompleted
	|
	|-RVA: 0x1315160 Offset: 0x1313B60 VA: 0x181315160
	|-ValueTask<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131AF60 Offset: 0x1319960 VA: 0x18131AF60
	|-ValueTask<int>.get_IsCompletedSuccessfully
	|
	|-RVA: 0x1314FF0 Offset: 0x13139F0 VA: 0x181314FF0
	|-ValueTask<__Il2CppFullySharedGenericType>.get_IsCompletedSuccessfully
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131B160 Offset: 0x1319B60 VA: 0x18131B160
	|-ValueTask<int>.get_Result
	|
	|-RVA: 0x13152D0 Offset: 0x1313CD0 VA: 0x1813152D0
	|-ValueTask<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	public ValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1319A40 Offset: 0x1318440 VA: 0x181319A40
	|-ValueTask<int>.GetAwaiter
	|
	|-RVA: 0x1319A90 Offset: 0x1318490 VA: 0x181319A90
	|-ValueTask<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1319280 Offset: 0x1317C80 VA: 0x181319280
	|-ValueTask<int>.ConfigureAwait
	|
	|-RVA: 0x1314920 Offset: 0x1313320 VA: 0x181314920
	|-ValueTask<__Il2CppFullySharedGenericType>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131AA90 Offset: 0x1319490 VA: 0x18131AA90
	|-ValueTask<int>.ToString
	|
	|-RVA: 0x131AB70 Offset: 0x1319570 VA: 0x18131AB70
	|-ValueTask<__Il2CppFullySharedGenericType>.ToString
	*/
}
