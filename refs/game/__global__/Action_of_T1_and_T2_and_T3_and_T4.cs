public sealed class Action<T1, T2, T3, T4> : MulticastDelegate // TypeDefIndex: 3573
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157FDF0 Offset: 0x157E7F0 VA: 0x18157FDF0
	|-Action<object, double, InputEventPtr, long>..ctor
	|
	|-RVA: 0x157FA60 Offset: 0x157E460 VA: 0x18157FA60
	|-Action<object, double, long, int>..ctor
	|
	|-RVA: 0x157FCC0 Offset: 0x157E6C0 VA: 0x18157FCC0
	|-Action<object, object, DateTime, object>..ctor
	|
	|-RVA: 0x157F940 Offset: 0x157E340 VA: 0x18157F940
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157F920 Offset: 0x157E320 VA: 0x18157F920
	|-Action<object, double, InputEventPtr, long>.Invoke
	|-Action<object, double, long, int>.Invoke
	|
	|-RVA: 0xC84DF0 Offset: 0xC837F0 VA: 0x180C84DF0
	|-Action<object, object, DateTime, object>.Invoke
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}
