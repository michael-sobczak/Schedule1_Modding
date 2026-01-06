public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 4583
{
	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B1930 Offset: 0x12B0330 VA: 0x1812B1930
	|-AsyncValueTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x12B1850 Offset: 0x12B0250 VA: 0x1812B1850
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5510 Offset: 0xDC3F10 VA: 0x180DC5510
	|-AsyncValueTaskMethodBuilder<int>.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0xDC5480 Offset: 0xDC3E80 VA: 0x180DC5480
	|-AsyncValueTaskMethodBuilder<int>.Start<StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0xDC53A0 Offset: 0xDC3DA0 VA: 0x180DC53A0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.Start<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B1F50 Offset: 0x12B0950 VA: 0x1812B1F50
	|-AsyncValueTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x12B1E50 Offset: 0x12B0850 VA: 0x1812B1E50
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B1AE0 Offset: 0x12B04E0 VA: 0x1812B1AE0
	|-AsyncValueTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x12B1B90 Offset: 0x12B0590 VA: 0x1812B1B90
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B1A40 Offset: 0x12B0440 VA: 0x1812B1A40
	|-AsyncValueTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x12B1940 Offset: 0x12B0340 VA: 0x1812B1940
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B2320 Offset: 0x12B0D20 VA: 0x1812B2320
	|-AsyncValueTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x12B1FE0 Offset: 0x12B09E0 VA: 0x1812B1FE0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5130 Offset: 0xDC3B30 VA: 0x180DC5130
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0xDC5090 Offset: 0xDC3A90 VA: 0x180DC5090
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0xDC51D0 Offset: 0xDC3BD0 VA: 0x180DC51D0
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0xDC5270 Offset: 0xDC3C70 VA: 0x180DC5270
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}
