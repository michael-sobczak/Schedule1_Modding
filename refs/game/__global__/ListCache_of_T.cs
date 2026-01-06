public class ListCache<T> // TypeDefIndex: 12490
{
	// Fields
	public List<T> Collection; // 0x0
	private Stack<T> _cache; // 0x0

	// Properties
	public int Written { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Written() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-ListCache<int>.get_Written
	|-ListCache<object>.get_Written
	|
	|-RVA: 0x142B370 Offset: 0x1429D70 VA: 0x18142B370
	|-ListCache<__Il2CppFullySharedGenericType>.get_Written
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E4530 Offset: 0x18E2F30 VA: 0x1818E4530
	|-ListCache<int>..ctor
	|-ListCache<object>..ctor
	|
	|-RVA: 0x18E47A0 Offset: 0x18E31A0 VA: 0x1818E47A0
	|-ListCache<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E48D0 Offset: 0x18E32D0 VA: 0x1818E48D0
	|-ListCache<int>..ctor
	|-ListCache<object>..ctor
	|
	|-RVA: 0x18E4660 Offset: 0x18E3060 VA: 0x1818E4660
	|-ListCache<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private T Retrieve() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E4290 Offset: 0x18E2C90 VA: 0x1818E4290
	|-ListCache<int>.Retrieve
	|
	|-RVA: 0x18E4230 Offset: 0x18E2C30 VA: 0x1818E4230
	|-ListCache<object>.Retrieve
	|
	|-RVA: 0x18E42F0 Offset: 0x18E2CF0 VA: 0x1818E42F0
	|-ListCache<__Il2CppFullySharedGenericType>.Retrieve
	*/

	// RVA: -1 Offset: -1
	private void Store(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E4420 Offset: 0x18E2E20 VA: 0x1818E4420
	|-ListCache<int>.Store
	|
	|-RVA: 0x18E43F0 Offset: 0x18E2DF0 VA: 0x1818E43F0
	|-ListCache<object>.Store
	|
	|-RVA: 0x18E4450 Offset: 0x18E2E50 VA: 0x1818E4450
	|-ListCache<__Il2CppFullySharedGenericType>.Store
	*/

	// RVA: -1 Offset: -1
	public T AddReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E1010 Offset: 0x18DFA10 VA: 0x1818E1010
	|-ListCache<int>.AddReference
	|
	|-RVA: 0x18E1110 Offset: 0x18DFB10 VA: 0x1818E1110
	|-ListCache<object>.AddReference
	|
	|-RVA: 0x18E0E80 Offset: 0x18DF880 VA: 0x1818E0E80
	|-ListCache<__Il2CppFullySharedGenericType>.AddReference
	*/

	// RVA: -1 Offset: -1
	public T InsertReference(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E3810 Offset: 0x18E2210 VA: 0x1818E3810
	|-ListCache<int>.InsertReference
	|
	|-RVA: 0x18E3660 Offset: 0x18E2060 VA: 0x1818E3660
	|-ListCache<object>.InsertReference
	|
	|-RVA: 0x18E3460 Offset: 0x18E1E60 VA: 0x1818E3460
	|-ListCache<__Il2CppFullySharedGenericType>.InsertReference
	*/

	// RVA: -1 Offset: -1
	public void AddValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E1220 Offset: 0x18DFC20 VA: 0x1818E1220
	|-ListCache<int>.AddValue
	|
	|-RVA: 0x18E12A0 Offset: 0x18DFCA0 VA: 0x1818E12A0
	|-ListCache<object>.AddValue
	|
	|-RVA: 0x18E1320 Offset: 0x18DFD20 VA: 0x1818E1320
	|-ListCache<__Il2CppFullySharedGenericType>.AddValue
	*/

	// RVA: -1 Offset: -1
	public void InsertValue(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E39A0 Offset: 0x18E23A0 VA: 0x1818E39A0
	|-ListCache<int>.InsertValue
	|
	|-RVA: 0x18E3B90 Offset: 0x18E2590 VA: 0x1818E3B90
	|-ListCache<object>.InsertValue
	|
	|-RVA: 0x18E3A00 Offset: 0x18E2400 VA: 0x1818E3A00
	|-ListCache<__Il2CppFullySharedGenericType>.InsertValue
	*/

	// RVA: -1 Offset: -1
	public void AddValues(ListCache<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E2F20 Offset: 0x18E1920 VA: 0x1818E2F20
	|-ListCache<int>.AddValues
	|
	|-RVA: 0x18E2CB0 Offset: 0x18E16B0 VA: 0x1818E2CB0
	|-ListCache<object>.AddValues
	|
	|-RVA: 0x18E1F40 Offset: 0x18E0940 VA: 0x1818E1F40
	|-ListCache<__Il2CppFullySharedGenericType>.AddValues
	*/

	// RVA: -1 Offset: -1
	public void AddValues(T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E2820 Offset: 0x18E1220 VA: 0x1818E2820
	|-ListCache<int>.AddValues
	|
	|-RVA: 0x18E1400 Offset: 0x18DFE00 VA: 0x1818E1400
	|-ListCache<object>.AddValues
	|
	|-RVA: 0x18E1830 Offset: 0x18E0230 VA: 0x1818E1830
	|-ListCache<__Il2CppFullySharedGenericType>.AddValues
	*/

	// RVA: -1 Offset: -1
	public void AddValues(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E20A0 Offset: 0x18E0AA0 VA: 0x1818E20A0
	|-ListCache<int>.AddValues
	|
	|-RVA: 0x18E2920 Offset: 0x18E1320 VA: 0x1818E2920
	|-ListCache<object>.AddValues
	|
	|-RVA: 0x18E2DD0 Offset: 0x18E17D0 VA: 0x1818E2DD0
	|-ListCache<__Il2CppFullySharedGenericType>.AddValues
	*/

	// RVA: -1 Offset: -1
	public void AddValues(HashSet<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E2680 Offset: 0x18E1080 VA: 0x1818E2680
	|-ListCache<int>.AddValues
	|
	|-RVA: 0x18E3030 Offset: 0x18E1A30 VA: 0x1818E3030
	|-ListCache<object>.AddValues
	|
	|-RVA: 0x18E1510 Offset: 0x18DFF10 VA: 0x1818E1510
	|-ListCache<__Il2CppFullySharedGenericType>.AddValues
	*/

	// RVA: -1 Offset: -1
	public void AddValues(ISet<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E21A0 Offset: 0x18E0BA0 VA: 0x1818E21A0
	|-ListCache<int>.AddValues
	|
	|-RVA: 0x18E31E0 Offset: 0x18E1BE0 VA: 0x1818E31E0
	|-ListCache<object>.AddValues
	|
	|-RVA: 0x18E1940 Offset: 0x18E0340 VA: 0x1818E1940
	|-ListCache<__Il2CppFullySharedGenericType>.AddValues
	*/

	// RVA: -1 Offset: -1
	public void AddValues(IReadOnlyCollection<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E2410 Offset: 0x18E0E10 VA: 0x1818E2410
	|-ListCache<int>.AddValues
	|
	|-RVA: 0x18E2A30 Offset: 0x18E1430 VA: 0x1818E2A30
	|-ListCache<object>.AddValues
	|
	|-RVA: 0x18E1C40 Offset: 0x18E0640 VA: 0x1818E1C40
	|-ListCache<__Il2CppFullySharedGenericType>.AddValues
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E3D80 Offset: 0x18E2780 VA: 0x1818E3D80
	|-ListCache<int>.Reset
	|
	|-RVA: 0x18E3BF0 Offset: 0x18E25F0 VA: 0x1818E3BF0
	|-ListCache<object>.Reset
	|
	|-RVA: 0x18E3EF0 Offset: 0x18E28F0 VA: 0x1818E3EF0
	|-ListCache<__Il2CppFullySharedGenericType>.Reset
	*/
}
