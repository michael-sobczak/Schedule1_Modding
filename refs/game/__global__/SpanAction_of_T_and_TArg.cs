public sealed class SpanAction<T, TArg> : MulticastDelegate // TypeDefIndex: 5023
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DD130 Offset: 0x11DBB30 VA: 0x1811DD130
	|-SpanAction<char, ValueTuple<object, int, int>>..ctor
	|
	|-RVA: 0x11DD1E0 Offset: 0x11DBBE0 VA: 0x1811DD1E0
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>>..ctor
	|
	|-RVA: 0x11DD290 Offset: 0x11DBC90 VA: 0x1811DD290
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>..ctor
	|
	|-RVA: 0x11DD340 Offset: 0x11DBD40 VA: 0x1811DD340
	|-SpanAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(Span<T> span, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DD0F0 Offset: 0x11DBAF0 VA: 0x1811DD0F0
	|-SpanAction<char, ValueTuple<object, int, int>>.Invoke
	|
	|-RVA: 0x11DD0B0 Offset: 0x11DBAB0 VA: 0x1811DD0B0
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>>.Invoke
	|
	|-RVA: 0x11DD030 Offset: 0x11DBA30 VA: 0x1811DD030
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>.Invoke
	|
	|-RVA: 0x11DD080 Offset: 0x11DBA80 VA: 0x1811DD080
	|-SpanAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}
