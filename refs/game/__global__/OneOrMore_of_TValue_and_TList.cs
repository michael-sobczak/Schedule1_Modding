internal struct OneOrMore<TValue, TList> : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue> // TypeDefIndex: 7839
{
	// Fields
	private readonly bool m_IsSingle; // 0x0
	private readonly TValue m_Single; // 0x0
	private readonly TList m_Multiple; // 0x0

	// Properties
	public int Count { get; }
	public TValue Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE500 Offset: 0x10ECF00 VA: 0x1810EE500
	|-OneOrMore<object, ReadOnlyArray<object>>.get_Count
	|
	|-RVA: 0x10EE2F0 Offset: 0x10ECCF0 VA: 0x1810EE2F0
	|-OneOrMore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE860 Offset: 0x10ED260 VA: 0x1810EE860
	|-OneOrMore<object, ReadOnlyArray<object>>.get_Item
	|
	|-RVA: 0x10EE550 Offset: 0x10ECF50 VA: 0x1810EE550
	|-OneOrMore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TValue single) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE0E0 Offset: 0x10ECAE0 VA: 0x1810EE0E0
	|-OneOrMore<object, ReadOnlyArray<object>>..ctor
	|
	|-RVA: 0x10EDF20 Offset: 0x10EC920 VA: 0x1810EDF20
	|-OneOrMore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TList multiple) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE110 Offset: 0x10ECB10 VA: 0x1810EE110
	|-OneOrMore<object, ReadOnlyArray<object>>..ctor
	|
	|-RVA: 0x10EE130 Offset: 0x10ECB30 VA: 0x1810EE130
	|-OneOrMore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static OneOrMore<TValue, TList> op_Implicit(TValue single) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE970 Offset: 0x10ED370 VA: 0x1810EE970
	|-OneOrMore<object, ReadOnlyArray<object>>.op_Implicit
	|
	|-RVA: 0x10EEB80 Offset: 0x10ED580 VA: 0x1810EEB80
	|-OneOrMore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static OneOrMore<TValue, TList> op_Implicit(TList multiple) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE910 Offset: 0x10ED310 VA: 0x1810EE910
	|-OneOrMore<object, ReadOnlyArray<object>>.op_Implicit
	|
	|-RVA: 0x10EE9D0 Offset: 0x10ED3D0 VA: 0x1810EE9D0
	|-OneOrMore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EDDB0 Offset: 0x10EC7B0 VA: 0x1810EDDB0
	|-OneOrMore<object, ReadOnlyArray<object>>.GetEnumerator
	|
	|-RVA: 0x10EDC40 Offset: 0x10EC640 VA: 0x1810EDC40
	|-OneOrMore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EDE70 Offset: 0x10EC870 VA: 0x1810EDE70
	|-OneOrMore<object, ReadOnlyArray<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10EDEB0 Offset: 0x10EC8B0 VA: 0x1810EDEB0
	|-OneOrMore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
