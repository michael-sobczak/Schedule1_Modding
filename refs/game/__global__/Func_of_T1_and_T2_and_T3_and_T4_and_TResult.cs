public sealed class Func<T1, T2, T3, T4, TResult> : MulticastDelegate // TypeDefIndex: 3582
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180C2E0 Offset: 0x180ACE0 VA: 0x18180C2E0
	|-Func<object, int, object, object, object>..ctor
	|
	|-RVA: 0x180C090 Offset: 0x180AA90 VA: 0x18180C090
	|-Func<object, object, bool, object, object>..ctor
	|
	|-RVA: 0x180C410 Offset: 0x180AE10 VA: 0x18180C410
	|-Func<object, Stream.ReadWriteParameters, object, object, object>..ctor
	|
	|-RVA: 0x180C1C0 Offset: 0x180ABC0 VA: 0x18180C1C0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC84DF0 Offset: 0xC837F0 VA: 0x180C84DF0
	|-Func<object, int, object, object, object>.Invoke
	|-Func<object, object, bool, object, object>.Invoke
	|
	|-RVA: 0x180C050 Offset: 0x180AA50 VA: 0x18180C050
	|-Func<object, Stream.ReadWriteParameters, object, object, object>.Invoke
	|
	|-RVA: 0x157FF20 Offset: 0x157E920 VA: 0x18157FF20
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}
