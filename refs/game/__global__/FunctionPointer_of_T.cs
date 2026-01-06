public struct FunctionPointer<T> : IFunctionPointer // TypeDefIndex: 16314
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	private readonly IntPtr _ptr; // 0x0

	// Properties
	public IntPtr Value { get; }
	public T Invoke { get; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	|-FunctionPointer<object>..ctor
	|-FunctionPointer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public IntPtr get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-FunctionPointer<object>.get_Value
	|-FunctionPointer<__Il2CppFullySharedGenericType>.get_Value
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckIsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180CA70 Offset: 0x180B470 VA: 0x18180CA70
	|-FunctionPointer<object>.CheckIsCreated
	|
	|-RVA: 0x180C9C0 Offset: 0x180B3C0 VA: 0x18180C9C0
	|-FunctionPointer<__Il2CppFullySharedGenericType>.CheckIsCreated
	*/

	// RVA: -1 Offset: -1
	public T get_Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180CB50 Offset: 0x180B550 VA: 0x18180CB50
	|-FunctionPointer<object>.get_Invoke
	|
	|-RVA: 0x180CBD0 Offset: 0x180B5D0 VA: 0x18180CBD0
	|-FunctionPointer<__Il2CppFullySharedGenericType>.get_Invoke
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180CD00 Offset: 0x180B700 VA: 0x18180CD00
	|-FunctionPointer<object>.get_IsCreated
	|-FunctionPointer<__Il2CppFullySharedGenericType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IFunctionPointer Unity.Burst.IFunctionPointer.FromIntPtr(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180CAF0 Offset: 0x180B4F0 VA: 0x18180CAF0
	|-FunctionPointer<object>.Unity.Burst.IFunctionPointer.FromIntPtr
	|-FunctionPointer<__Il2CppFullySharedGenericType>.Unity.Burst.IFunctionPointer.FromIntPtr
	*/
}
