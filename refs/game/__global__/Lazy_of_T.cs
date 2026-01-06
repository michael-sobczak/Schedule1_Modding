public class Lazy<T> // TypeDefIndex: 3681
{
	// Fields
	private LazyHelper _state; // 0x0
	private Func<T> _factory; // 0x0
	private T _value; // 0x0

	// Properties
	public bool IsValueCreated { get; }
	[DebuggerBrowsable(0)]
	public T Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static T CreateViaDefaultConstructor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D5CA0 Offset: 0x18D46A0 VA: 0x1818D5CA0
	|-Lazy<bool>.CreateViaDefaultConstructor
	|
	|-RVA: 0x18D5B90 Offset: 0x18D4590 VA: 0x1818D5B90
	|-Lazy<object>.CreateViaDefaultConstructor
	|
	|-RVA: 0x18D5DA0 Offset: 0x18D47A0 VA: 0x1818D5DA0
	|-Lazy<__Il2CppFullySharedGenericType>.CreateViaDefaultConstructor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D7710 Offset: 0x18D6110 VA: 0x1818D7710
	|-Lazy<bool>..ctor
	|
	|-RVA: 0x18D74E0 Offset: 0x18D5EE0 VA: 0x1818D74E0
	|-Lazy<object>..ctor
	|
	|-RVA: 0x18D76E0 Offset: 0x18D60E0 VA: 0x1818D76E0
	|-Lazy<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D7AA0 Offset: 0x18D64A0 VA: 0x1818D7AA0
	|-Lazy<bool>..ctor
	|
	|-RVA: 0x18D7890 Offset: 0x18D6290 VA: 0x1818D7890
	|-Lazy<object>..ctor
	|
	|-RVA: 0x18D7980 Offset: 0x18D6380 VA: 0x1818D7980
	|-Lazy<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D79B0 Offset: 0x18D63B0 VA: 0x1818D79B0
	|-Lazy<bool>..ctor
	|
	|-RVA: 0x18D77A0 Offset: 0x18D61A0 VA: 0x1818D77A0
	|-Lazy<object>..ctor
	|
	|-RVA: 0x18D7570 Offset: 0x18D5F70 VA: 0x1818D7570
	|-Lazy<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void ViaConstructor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D6EC0 Offset: 0x18D58C0 VA: 0x1818D6EC0
	|-Lazy<bool>.ViaConstructor
	|
	|-RVA: 0x18D6F00 Offset: 0x18D5900 VA: 0x1818D6F00
	|-Lazy<object>.ViaConstructor
	|
	|-RVA: 0x18D6F50 Offset: 0x18D5950 VA: 0x1818D6F50
	|-Lazy<__Il2CppFullySharedGenericType>.ViaConstructor
	*/

	// RVA: -1 Offset: -1
	private void ViaFactory(LazyThreadSafetyMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D7180 Offset: 0x18D5B80 VA: 0x1818D7180
	|-Lazy<bool>.ViaFactory
	|
	|-RVA: 0x18D7050 Offset: 0x18D5A50 VA: 0x1818D7050
	|-Lazy<object>.ViaFactory
	|
	|-RVA: 0x18D72A0 Offset: 0x18D5CA0 VA: 0x1818D72A0
	|-Lazy<__Il2CppFullySharedGenericType>.ViaFactory
	*/

	// RVA: -1 Offset: -1
	private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D6170 Offset: 0x18D4B70 VA: 0x1818D6170
	|-Lazy<bool>.ExecutionAndPublication
	|
	|-RVA: 0x18D6030 Offset: 0x18D4A30 VA: 0x1818D6030
	|-Lazy<object>.ExecutionAndPublication
	|
	|-RVA: 0x18D5F00 Offset: 0x18D4900 VA: 0x1818D5F00
	|-Lazy<__Il2CppFullySharedGenericType>.ExecutionAndPublication
	*/

	// RVA: -1 Offset: -1
	private void PublicationOnly(LazyHelper publicationOnly, T possibleValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D6AF0 Offset: 0x18D54F0 VA: 0x1818D6AF0
	|-Lazy<bool>.PublicationOnly
	|
	|-RVA: 0x18D6850 Offset: 0x18D5250 VA: 0x1818D6850
	|-Lazy<object>.PublicationOnly
	|
	|-RVA: 0x18D6910 Offset: 0x18D5310 VA: 0x1818D6910
	|-Lazy<__Il2CppFullySharedGenericType>.PublicationOnly
	*/

	// RVA: -1 Offset: -1
	private void PublicationOnlyViaConstructor(LazyHelper initializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D6380 Offset: 0x18D4D80 VA: 0x1818D6380
	|-Lazy<bool>.PublicationOnlyViaConstructor
	|
	|-RVA: 0x18D63E0 Offset: 0x18D4DE0 VA: 0x1818D63E0
	|-Lazy<object>.PublicationOnlyViaConstructor
	|
	|-RVA: 0x18D62A0 Offset: 0x18D4CA0 VA: 0x1818D62A0
	|-Lazy<__Il2CppFullySharedGenericType>.PublicationOnlyViaConstructor
	*/

	// RVA: -1 Offset: -1
	private void PublicationOnlyViaFactory(LazyHelper initializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D6440 Offset: 0x18D4E40 VA: 0x1818D6440
	|-Lazy<bool>.PublicationOnlyViaFactory
	|
	|-RVA: 0x18D65F0 Offset: 0x18D4FF0 VA: 0x1818D65F0
	|-Lazy<object>.PublicationOnlyViaFactory
	|
	|-RVA: 0x18D64D0 Offset: 0x18D4ED0 VA: 0x1818D64D0
	|-Lazy<__Il2CppFullySharedGenericType>.PublicationOnlyViaFactory
	*/

	// RVA: -1 Offset: -1
	private void PublicationOnlyWaitForOtherThreadToPublish() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D6750 Offset: 0x18D5150 VA: 0x1818D6750
	|-Lazy<bool>.PublicationOnlyWaitForOtherThreadToPublish
	|
	|-RVA: 0x18D67D0 Offset: 0x18D51D0 VA: 0x1818D67D0
	|-Lazy<object>.PublicationOnlyWaitForOtherThreadToPublish
	|
	|-RVA: 0x18D6680 Offset: 0x18D5080 VA: 0x1818D6680
	|-Lazy<__Il2CppFullySharedGenericType>.PublicationOnlyWaitForOtherThreadToPublish
	*/

	// RVA: -1 Offset: -1
	private T CreateValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D57F0 Offset: 0x18D41F0 VA: 0x1818D57F0
	|-Lazy<bool>.CreateValue
	|
	|-RVA: 0x18D5640 Offset: 0x18D4040 VA: 0x1818D5640
	|-Lazy<object>.CreateValue
	|
	|-RVA: 0x18D59A0 Offset: 0x18D43A0 VA: 0x1818D59A0
	|-Lazy<__Il2CppFullySharedGenericType>.CreateValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D6C40 Offset: 0x18D5640 VA: 0x1818D6C40
	|-Lazy<bool>.ToString
	|
	|-RVA: 0x18D6BA0 Offset: 0x18D55A0 VA: 0x1818D6BA0
	|-Lazy<object>.ToString
	|
	|-RVA: 0x18D6D00 Offset: 0x18D5700 VA: 0x1818D6D00
	|-Lazy<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public bool get_IsValueCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D7B90 Offset: 0x18D6590 VA: 0x1818D7B90
	|-Lazy<bool>.get_IsValueCreated
	|-Lazy<object>.get_IsValueCreated
	|
	|-RVA: 0x18D7BB0 Offset: 0x18D65B0 VA: 0x1818D7BB0
	|-Lazy<__Il2CppFullySharedGenericType>.get_IsValueCreated
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D7BF0 Offset: 0x18D65F0 VA: 0x1818D7BF0
	|-Lazy<bool>.get_Value
	|
	|-RVA: 0x18D7DD0 Offset: 0x18D67D0 VA: 0x1818D7DD0
	|-Lazy<object>.get_Value
	|
	|-RVA: 0x18D7FB0 Offset: 0x18D69B0 VA: 0x1818D7FB0
	|-Lazy<__Il2CppFullySharedGenericType>.get_Value
	*/
}
