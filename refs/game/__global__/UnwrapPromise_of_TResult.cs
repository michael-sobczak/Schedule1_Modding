internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction // TypeDefIndex: 4063
{
	// Fields
	private byte _state; // 0x0
	private readonly bool _lookForOce; // 0x0

	// Properties
	public bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E7C10 Offset: 0x12E6610 VA: 0x1812E7C10
	|-UnwrapPromise<object>..ctor
	|
	|-RVA: 0x12E7F30 Offset: 0x12E6930 VA: 0x1812E7F30
	|-UnwrapPromise<VoidTaskResult>..ctor
	|
	|-RVA: 0x12E7D60 Offset: 0x12E6760 VA: 0x1812E7D60
	|-UnwrapPromise<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Invoke(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E67E0 Offset: 0x12E51E0 VA: 0x1812E67E0
	|-UnwrapPromise<object>.Invoke
	|
	|-RVA: 0x12E6940 Offset: 0x12E5340 VA: 0x1812E6940
	|-UnwrapPromise<VoidTaskResult>.Invoke
	|
	|-RVA: 0x12E66C0 Offset: 0x12E50C0 VA: 0x1812E66C0
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	private void InvokeCore(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E6540 Offset: 0x12E4F40 VA: 0x1812E6540
	|-UnwrapPromise<object>.InvokeCore
	|
	|-RVA: 0x12E6670 Offset: 0x12E5070 VA: 0x1812E6670
	|-UnwrapPromise<VoidTaskResult>.InvokeCore
	|
	|-RVA: 0x12E6590 Offset: 0x12E4F90 VA: 0x1812E6590
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.InvokeCore
	*/

	// RVA: -1 Offset: -1
	private void InvokeCoreAsync(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5FC0 Offset: 0x12E49C0 VA: 0x1812E5FC0
	|-UnwrapPromise<object>.InvokeCoreAsync
	|
	|-RVA: 0x12E6190 Offset: 0x12E4B90 VA: 0x1812E6190
	|-UnwrapPromise<VoidTaskResult>.InvokeCoreAsync
	|
	|-RVA: 0x12E6360 Offset: 0x12E4D60 VA: 0x1812E6360
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.InvokeCoreAsync
	*/

	// RVA: -1 Offset: -1
	private void ProcessCompletedOuterTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E6AA0 Offset: 0x12E54A0 VA: 0x1812E6AA0
	|-UnwrapPromise<object>.ProcessCompletedOuterTask
	|
	|-RVA: 0x12E6E50 Offset: 0x12E5850 VA: 0x1812E6E50
	|-UnwrapPromise<VoidTaskResult>.ProcessCompletedOuterTask
	|
	|-RVA: 0x12E6C60 Offset: 0x12E5660 VA: 0x1812E6C60
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.ProcessCompletedOuterTask
	*/

	// RVA: -1 Offset: -1
	private bool TrySetFromTask(Task task, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E7610 Offset: 0x12E6010 VA: 0x1812E7610
	|-UnwrapPromise<object>.TrySetFromTask
	|
	|-RVA: 0x12E7910 Offset: 0x12E6310 VA: 0x1812E7910
	|-UnwrapPromise<VoidTaskResult>.TrySetFromTask
	|
	|-RVA: 0x12E7200 Offset: 0x12E5C00 VA: 0x1812E7200
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.TrySetFromTask
	*/

	// RVA: -1 Offset: -1
	private void ProcessInnerTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E7010 Offset: 0x12E5A10 VA: 0x1812E7010
	|-UnwrapPromise<object>.ProcessInnerTask
	|
	|-RVA: 0x12E70A0 Offset: 0x12E5AA0 VA: 0x1812E70A0
	|-UnwrapPromise<VoidTaskResult>.ProcessInnerTask
	|
	|-RVA: 0x12E7130 Offset: 0x12E5B30 VA: 0x1812E7130
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.ProcessInnerTask
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool get_InvokeMayRunArbitraryCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-UnwrapPromise<object>.get_InvokeMayRunArbitraryCode
	|-UnwrapPromise<VoidTaskResult>.get_InvokeMayRunArbitraryCode
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.get_InvokeMayRunArbitraryCode
	*/
}
