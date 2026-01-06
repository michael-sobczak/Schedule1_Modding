private class OneOrMore.Enumerator<TValue, TList> : IEnumerator<TValue>, IEnumerator, IDisposable // TypeDefIndex: 7838
{
	// Fields
	internal int m_Index; // 0x0
	internal OneOrMore<TValue, TList> m_List; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x168B120 Offset: 0x1689B20 VA: 0x18168B120
	|-OneOrMore.Enumerator<object, ReadOnlyArray<object>>.MoveNext
	|
	|-RVA: 0x16A85E0 Offset: 0x16A6FE0 VA: 0x1816A85E0
	|-OneOrMore.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1663BF0 Offset: 0x16625F0 VA: 0x181663BF0
	|-OneOrMore.Enumerator<object, ReadOnlyArray<object>>.Reset
	|
	|-RVA: 0x16A9090 Offset: 0x16A7A90 VA: 0x1816A9090
	|-OneOrMore.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16904B0 Offset: 0x168EEB0 VA: 0x1816904B0
	|-OneOrMore.Enumerator<object, ReadOnlyArray<object>>.get_Current
	|
	|-RVA: 0x16ADDA0 Offset: 0x16AC7A0 VA: 0x1816ADDA0
	|-OneOrMore.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x168D830 Offset: 0x168C230 VA: 0x18168D830
	|-OneOrMore.Enumerator<object, ReadOnlyArray<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x16ACBA0 Offset: 0x16AB5A0 VA: 0x1816ACBA0
	|-OneOrMore.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-OneOrMore.Enumerator<object, ReadOnlyArray<object>>.Dispose
	|-OneOrMore.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E0C50 Offset: 0x5DF650 VA: 0x1805E0C50
	|-OneOrMore.Enumerator<object, ReadOnlyArray<object>>..ctor
	|
	|-RVA: 0x16ACF80 Offset: 0x16AB980 VA: 0x1816ACF80
	|-OneOrMore.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
