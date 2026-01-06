internal sealed class XHashtable<TValue> // TypeDefIndex: 18626
{
	// Fields
	private XHashtable.XHashtableState<TValue> _state; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD720 Offset: 0x13FC120 VA: 0x1813FD720
	|-XHashtable<object>..ctor
	|
	|-RVA: 0x13FD680 Offset: 0x13FC080 VA: 0x1813FD680
	|-XHashtable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD520 Offset: 0x13FBF20 VA: 0x1813FD520
	|-XHashtable<object>.TryGetValue
	|
	|-RVA: 0x13FD4E0 Offset: 0x13FBEE0 VA: 0x1813FD4E0
	|-XHashtable<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue Add(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD1A0 Offset: 0x13FBBA0 VA: 0x1813FD1A0
	|-XHashtable<object>.Add
	|
	|-RVA: 0x13FD2C0 Offset: 0x13FBCC0 VA: 0x1813FD2C0
	|-XHashtable<__Il2CppFullySharedGenericType>.Add
	*/
}
