public class BidirectionalDictionary<T1, T2> : IEnumerable // TypeDefIndex: 518
{
	// Fields
	private Dictionary<T1, T2> t1ToT2Dict; // 0x0
	private Dictionary<T2, T1> t2ToT1Dict; // 0x0

	// Properties
	public IEnumerable<T1> FirstTypes { get; }
	public IEnumerable<T2> SecondTypes { get; }
	public int Count { get; }
	public Dictionary<T1, T2> First { get; }
	public Dictionary<T2, T1> Second { get; }
	public T1 Item { get; set; }
	public T2 Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public IEnumerable<T1> get_FirstTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142B340 Offset: 0x1429D40 VA: 0x18142B340
	|-BidirectionalDictionary<CSteamID, int>.get_FirstTypes
	|-BidirectionalDictionary<HSteamNetConnection, int>.get_FirstTypes
	|
	|-RVA: 0x142B370 Offset: 0x1429D70 VA: 0x18142B370
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_FirstTypes
	*/

	// RVA: -1 Offset: -1
	public IEnumerable<T2> get_SecondTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142B3D0 Offset: 0x1429DD0 VA: 0x18142B3D0
	|-BidirectionalDictionary<CSteamID, int>.get_SecondTypes
	|-BidirectionalDictionary<HSteamNetConnection, int>.get_SecondTypes
	|
	|-RVA: 0x142B3A0 Offset: 0x1429DA0 VA: 0x18142B3A0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_SecondTypes
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428A50 Offset: 0x1427450 VA: 0x181428A50
	|-BidirectionalDictionary<CSteamID, int>.GetEnumerator
	|
	|-RVA: 0x1428B70 Offset: 0x1427570 VA: 0x181428B70
	|-BidirectionalDictionary<HSteamNetConnection, int>.GetEnumerator
	|
	|-RVA: 0x1428AC0 Offset: 0x14274C0 VA: 0x181428AC0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142B310 Offset: 0x1429D10 VA: 0x18142B310
	|-BidirectionalDictionary<CSteamID, int>.get_Count
	|-BidirectionalDictionary<HSteamNetConnection, int>.get_Count
	|
	|-RVA: 0x142B2E0 Offset: 0x1429CE0 VA: 0x18142B2E0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public Dictionary<T1, T2> get_First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-BidirectionalDictionary<CSteamID, int>.get_First
	|-BidirectionalDictionary<HSteamNetConnection, int>.get_First
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_First
	*/

	// RVA: -1 Offset: -1
	public Dictionary<T2, T1> get_Second() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-BidirectionalDictionary<CSteamID, int>.get_Second
	|-BidirectionalDictionary<HSteamNetConnection, int>.get_Second
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Second
	*/

	// RVA: -1 Offset: -1
	public void Add(T1 key, T2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14284C0 Offset: 0x1426EC0 VA: 0x1814284C0
	|-BidirectionalDictionary<CSteamID, int>.Add
	|
	|-RVA: 0x1428640 Offset: 0x1427040 VA: 0x181428640
	|-BidirectionalDictionary<HSteamNetConnection, int>.Add
	|
	|-RVA: 0x1427AC0 Offset: 0x14264C0 VA: 0x181427AC0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(T2 key, T1 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428340 Offset: 0x1426D40 VA: 0x181428340
	|-BidirectionalDictionary<CSteamID, int>.Add
	|
	|-RVA: 0x14281C0 Offset: 0x1426BC0 VA: 0x1814281C0
	|-BidirectionalDictionary<HSteamNetConnection, int>.Add
	|
	|-RVA: 0x1427E40 Offset: 0x1426840 VA: 0x181427E40
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T2 Get(T1 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428C40 Offset: 0x1427640 VA: 0x181428C40
	|-BidirectionalDictionary<CSteamID, int>.Get
	|
	|-RVA: 0x1428C10 Offset: 0x1427610 VA: 0x181428C10
	|-BidirectionalDictionary<HSteamNetConnection, int>.Get
	|
	|-RVA: 0x1428DE0 Offset: 0x14277E0 VA: 0x181428DE0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public T1 Get(T2 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428C70 Offset: 0x1427670 VA: 0x181428C70
	|-BidirectionalDictionary<CSteamID, int>.Get
	|
	|-RVA: 0x1428BE0 Offset: 0x14275E0 VA: 0x181428BE0
	|-BidirectionalDictionary<HSteamNetConnection, int>.Get
	|
	|-RVA: 0x1428CA0 Offset: 0x14276A0 VA: 0x181428CA0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(T1 key, out T2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142A8D0 Offset: 0x14292D0 VA: 0x18142A8D0
	|-BidirectionalDictionary<CSteamID, int>.TryGetValue
	|
	|-RVA: 0x142A770 Offset: 0x1429170 VA: 0x18142A770
	|-BidirectionalDictionary<HSteamNetConnection, int>.TryGetValue
	|
	|-RVA: 0x142A930 Offset: 0x1429330 VA: 0x18142A930
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(T2 key, out T1 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142A8A0 Offset: 0x14292A0 VA: 0x18142A8A0
	|-BidirectionalDictionary<CSteamID, int>.TryGetValue
	|
	|-RVA: 0x142A900 Offset: 0x1429300 VA: 0x18142A900
	|-BidirectionalDictionary<HSteamNetConnection, int>.TryGetValue
	|
	|-RVA: 0x142A7A0 Offset: 0x14291A0 VA: 0x18142A7A0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T1 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428900 Offset: 0x1427300 VA: 0x181428900
	|-BidirectionalDictionary<CSteamID, int>.Contains
	|
	|-RVA: 0x14288D0 Offset: 0x14272D0 VA: 0x1814288D0
	|-BidirectionalDictionary<HSteamNetConnection, int>.Contains
	|
	|-RVA: 0x1428960 Offset: 0x1427360 VA: 0x181428960
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T2 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428930 Offset: 0x1427330 VA: 0x181428930
	|-BidirectionalDictionary<CSteamID, int>.Contains
	|
	|-RVA: 0x14287B0 Offset: 0x14271B0 VA: 0x1814287B0
	|-BidirectionalDictionary<HSteamNetConnection, int>.Contains
	|
	|-RVA: 0x14287E0 Offset: 0x14271E0 VA: 0x1814287E0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public void Remove(T1 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428F20 Offset: 0x1427920 VA: 0x181428F20
	|-BidirectionalDictionary<CSteamID, int>.Remove
	|
	|-RVA: 0x1429820 Offset: 0x1428220 VA: 0x181429820
	|-BidirectionalDictionary<HSteamNetConnection, int>.Remove
	|
	|-RVA: 0x1429000 Offset: 0x1427A00 VA: 0x181429000
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Remove(T2 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1429350 Offset: 0x1427D50 VA: 0x181429350
	|-BidirectionalDictionary<CSteamID, int>.Remove
	|
	|-RVA: 0x1429750 Offset: 0x1428150 VA: 0x181429750
	|-BidirectionalDictionary<HSteamNetConnection, int>.Remove
	|
	|-RVA: 0x1429420 Offset: 0x1427E20 VA: 0x181429420
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public T1 get_Item(T2 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428C70 Offset: 0x1427670 VA: 0x181428C70
	|-BidirectionalDictionary<CSteamID, int>.get_Item
	|
	|-RVA: 0x1428BE0 Offset: 0x14275E0 VA: 0x181428BE0
	|-BidirectionalDictionary<HSteamNetConnection, int>.get_Item
	|
	|-RVA: 0x1428CA0 Offset: 0x14276A0 VA: 0x181428CA0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(T2 key, T1 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142B9F0 Offset: 0x142A3F0 VA: 0x18142B9F0
	|-BidirectionalDictionary<CSteamID, int>.set_Item
	|
	|-RVA: 0x142BB80 Offset: 0x142A580 VA: 0x18142BB80
	|-BidirectionalDictionary<HSteamNetConnection, int>.set_Item
	|
	|-RVA: 0x142B880 Offset: 0x142A280 VA: 0x18142B880
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item(T1 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428C40 Offset: 0x1427640 VA: 0x181428C40
	|-BidirectionalDictionary<CSteamID, int>.get_Item
	|
	|-RVA: 0x1428C10 Offset: 0x1427610 VA: 0x181428C10
	|-BidirectionalDictionary<HSteamNetConnection, int>.get_Item
	|
	|-RVA: 0x1428DE0 Offset: 0x14277E0 VA: 0x181428DE0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(T1 key, T2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142B570 Offset: 0x1429F70 VA: 0x18142B570
	|-BidirectionalDictionary<CSteamID, int>.set_Item
	|
	|-RVA: 0x142B700 Offset: 0x142A100 VA: 0x18142B700
	|-BidirectionalDictionary<HSteamNetConnection, int>.set_Item
	|
	|-RVA: 0x142B400 Offset: 0x1429E00 VA: 0x18142B400
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142AF50 Offset: 0x1429950 VA: 0x18142AF50
	|-BidirectionalDictionary<CSteamID, int>..ctor
	|
	|-RVA: 0x142B0B0 Offset: 0x1429AB0 VA: 0x18142B0B0
	|-BidirectionalDictionary<HSteamNetConnection, int>..ctor
	|
	|-RVA: 0x142ABB0 Offset: 0x14295B0 VA: 0x18142ABB0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
