internal class BidirectionalDictionary<TFirst, TSecond> // TypeDefIndex: 11114
{
	// Fields
	private readonly IDictionary<TFirst, TSecond> _firstToSecond; // 0x0
	private readonly IDictionary<TSecond, TFirst> _secondToFirst; // 0x0
	private readonly string _duplicateFirstErrorMessage; // 0x0
	private readonly string _duplicateSecondErrorMessage; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142AA30 Offset: 0x1429430 VA: 0x18142AA30
	|-BidirectionalDictionary<object, object>..ctor
	|
	|-RVA: 0x142B030 Offset: 0x1429A30 VA: 0x18142B030
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142B190 Offset: 0x1429B90 VA: 0x18142B190
	|-BidirectionalDictionary<object, object>..ctor
	|
	|-RVA: 0x142AC90 Offset: 0x1429690 VA: 0x18142AC90
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142AE30 Offset: 0x1429830 VA: 0x18142AE30
	|-BidirectionalDictionary<object, object>..ctor
	|
	|-RVA: 0x142AD10 Offset: 0x1429710 VA: 0x18142AD10
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Set(TFirst first, TSecond second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1429900 Offset: 0x1428300 VA: 0x181429900
	|-BidirectionalDictionary<object, object>.Set
	|
	|-RVA: 0x1429C40 Offset: 0x1428640 VA: 0x181429C40
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Set
	*/

	// RVA: -1 Offset: -1
	public bool TryGetByFirst(TFirst first, out TSecond second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142A490 Offset: 0x1428E90 VA: 0x18142A490
	|-BidirectionalDictionary<object, object>.TryGetByFirst
	|
	|-RVA: 0x142A500 Offset: 0x1428F00 VA: 0x18142A500
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetByFirst
	*/

	// RVA: -1 Offset: -1
	public bool TryGetBySecond(TSecond second, out TFirst first) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142A700 Offset: 0x1429100 VA: 0x18142A700
	|-BidirectionalDictionary<object, object>.TryGetBySecond
	|
	|-RVA: 0x142A600 Offset: 0x1429000 VA: 0x18142A600
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetBySecond
	*/
}
