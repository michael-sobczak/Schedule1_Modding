private sealed class XHashtable.XHashtableState<TValue> // TypeDefIndex: 18625
{
	// Fields
	private int[] _buckets; // 0x0
	private XHashtable.XHashtableState.Entry<TValue>[] _entries; // 0x0
	private int _numEntries; // 0x0
	private XHashtable.ExtractKeyDelegate<TValue> _extractKey; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD000 Offset: 0x13FBA00 VA: 0x1813FD000
	|-XHashtable.XHashtableState<object>..ctor
	|
	|-RVA: 0x13FD0D0 Offset: 0x13FBAD0 VA: 0x1813FD0D0
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public XHashtable.XHashtableState<TValue> Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FC380 Offset: 0x13FAD80 VA: 0x1813FC380
	|-XHashtable.XHashtableState<object>.Resize
	|
	|-RVA: 0x13FBE20 Offset: 0x13FA820 VA: 0x1813FBE20
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FCD30 Offset: 0x13FB730 VA: 0x1813FCD30
	|-XHashtable.XHashtableState<object>.TryGetValue
	|
	|-RVA: 0x13FCE60 Offset: 0x13FB860 VA: 0x1813FCE60
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TValue value, out TValue newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FCAD0 Offset: 0x13FB4D0 VA: 0x1813FCAD0
	|-XHashtable.XHashtableState<object>.TryAdd
	|
	|-RVA: 0x13FC680 Offset: 0x13FB080 VA: 0x1813FC680
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FB840 Offset: 0x13FA240 VA: 0x1813FB840
	|-XHashtable.XHashtableState<object>.FindEntry
	|
	|-RVA: 0x13FBA10 Offset: 0x13FA410 VA: 0x1813FBA10
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.FindEntry
	*/

	// RVA: -1 Offset: -1
	private static int ComputeHashCode(string key, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FB7C0 Offset: 0x13FA1C0 VA: 0x1813FB7C0
	|-XHashtable.XHashtableState<object>.ComputeHashCode
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.ComputeHashCode
	*/
}
