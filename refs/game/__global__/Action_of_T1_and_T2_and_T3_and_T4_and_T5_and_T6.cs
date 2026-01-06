public sealed class Action<T1, T2, T3, T4, T5, T6> : MulticastDelegate // TypeDefIndex: 3575
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15803B0 Offset: 0x157EDB0 VA: 0x1815803B0
	|-Action<int, bool, bool, bool, bool, object>..ctor
	|
	|-RVA: 0x15800B0 Offset: 0x157EAB0 VA: 0x1815800B0
	|-Action<long, long, uint, object, object, object>..ctor
	|
	|-RVA: 0x1580280 Offset: 0x157EC80 VA: 0x181580280
	|-Action<object, IntPtr, IntPtr, int, int, object>..ctor
	|
	|-RVA: 0x1580160 Offset: 0x157EB60 VA: 0x181580160
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1580060 Offset: 0x157EA60 VA: 0x181580060
	|-Action<int, bool, bool, bool, bool, object>.Invoke
	|
	|-RVA: 0x1580090 Offset: 0x157EA90 VA: 0x181580090
	|-Action<long, long, uint, object, object, object>.Invoke
	|-Action<object, IntPtr, IntPtr, int, int, object>.Invoke
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}
