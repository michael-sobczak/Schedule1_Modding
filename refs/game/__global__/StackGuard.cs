internal sealed class StackGuard // TypeDefIndex: 15202
{
	// Fields
	private int _executionStackCount; // 0x10

	// Methods

	// RVA: 0x1FBB3D0 Offset: 0x1FB9DD0 VA: 0x181FBB3D0
	public bool TryEnterOnCurrentStack() { }

	// RVA: -1 Offset: -1
	public void RunOnEmptyStack<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF523B0 Offset: 0xF50DB0 VA: 0x180F523B0
	|-StackGuard.RunOnEmptyStack<object, object>
	|
	|-RVA: 0xF520F0 Offset: 0xF50AF0 VA: 0x180F520F0
	|-StackGuard.RunOnEmptyStack<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private R RunOnEmptyStackCore<R>(Func<object, R> action, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF51E20 Offset: 0xF50820 VA: 0x180F51E20
	|-StackGuard.RunOnEmptyStackCore<object>
	|
	|-RVA: 0xF51AF0 Offset: 0xF504F0 VA: 0x180F51AF0
	|-StackGuard.RunOnEmptyStackCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
