internal struct ByReference<T> // TypeDefIndex: 3788
{
	// Fields
	private IntPtr _value; // 0x0

	// Properties
	public T Value { get; }

	// Methods

	[Intrinsic]
	// RVA: -1 Offset: -1
	public void .ctor(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AF080 Offset: 0x11ADA80 VA: 0x1811AF080
	|-ByReference<byte>..ctor
	|-ByReference<char>..ctor
	|-ByReference<int>..ctor
	|-ByReference<ushort>..ctor
	|-ByReference<uint>..ctor
	|-ByReference<__Il2CppFullySharedGenericType>..ctor
	|-ByReference<jvalue>..ctor
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public ref T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC9ED0 Offset: 0xFC88D0 VA: 0x180FC9ED0
	|-ByReference<byte>.get_Value
	|-ByReference<char>.get_Value
	|-ByReference<int>.get_Value
	|-ByReference<ushort>.get_Value
	|-ByReference<uint>.get_Value
	|-ByReference<__Il2CppFullySharedGenericType>.get_Value
	|-ByReference<jvalue>.get_Value
	*/
}
