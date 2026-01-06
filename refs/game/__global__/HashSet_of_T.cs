public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 15664
{
	// Fields
	private const int Lower31BitMask = 2147483647;
	private const int StackAllocThreshold = 100;
	private const int ShrinkThreshold = 3;
	private const string CapacityName = "Capacity";
	private const string ElementsName = "Elements";
	private const string ComparerName = "Comparer";
	private const string VersionName = "Version";
	private int[] _buckets; // 0x0
	private HashSet.Slot<T>[] _slots; // 0x0
	private int _count; // 0x0
	private int _lastIndex; // 0x0
	private int _freeList; // 0x0
	private IEqualityComparer<T> _comparer; // 0x0
	private int _version; // 0x0
	private SerializationInfo _siInfo; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	public IEqualityComparer<T> Comparer { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821600 Offset: 0x1820000 VA: 0x181821600
	|-HashSet<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x183AAB0 Offset: 0x18394B0 VA: 0x18183AAB0
	|-HashSet<bool>..ctor
	|
	|-RVA: 0x1839390 Offset: 0x1837D90 VA: 0x181839390
	|-HashSet<int>..ctor
	|
	|-RVA: 0x183A5F0 Offset: 0x1838FF0 VA: 0x18183A5F0
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x183A4F0 Offset: 0x1838EF0 VA: 0x18183A4F0
	|-HashSet<InternedString>..ctor
	|
	|-RVA: 0x1839420 Offset: 0x1837E20 VA: 0x181839420
	|-HashSet<object>..ctor
	|
	|-RVA: 0x1838C80 Offset: 0x1837680 VA: 0x181838C80
	|-HashSet<Scene>..ctor
	|
	|-RVA: 0x18386F0 Offset: 0x18370F0 VA: 0x1818386F0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x184D7A0 Offset: 0x184C1A0 VA: 0x18184D7A0
	|-HashSet<UInt32Enum>..ctor
	|
	|-RVA: 0x184DDF0 Offset: 0x184C7F0 VA: 0x18184DDF0
	|-HashSet<ulong>..ctor
	|
	|-RVA: 0x184CE70 Offset: 0x184B870 VA: 0x18184CE70
	|-HashSet<Vector2Int>..ctor
	|
	|-RVA: 0x184CF60 Offset: 0x184B960 VA: 0x18184CF60
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x184D660 Offset: 0x184C060 VA: 0x18184D660
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821C60 Offset: 0x1820660 VA: 0x181821C60
	|-HashSet<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x183A480 Offset: 0x1838E80 VA: 0x18183A480
	|-HashSet<bool>..ctor
	|
	|-RVA: 0x183A580 Offset: 0x1838F80 VA: 0x18183A580
	|-HashSet<int>..ctor
	|
	|-RVA: 0x183A230 Offset: 0x1838C30 VA: 0x18183A230
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x18396F0 Offset: 0x18380F0 VA: 0x1818396F0
	|-HashSet<InternedString>..ctor
	|
	|-RVA: 0x1839B70 Offset: 0x1838570 VA: 0x181839B70
	|-HashSet<object>..ctor
	|
	|-RVA: 0x1837C00 Offset: 0x1836600 VA: 0x181837C00
	|-HashSet<Scene>..ctor
	|
	|-RVA: 0x1838410 Offset: 0x1836E10 VA: 0x181838410
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x184DD80 Offset: 0x184C780 VA: 0x18184DD80
	|-HashSet<UInt32Enum>..ctor
	|
	|-RVA: 0x184D590 Offset: 0x184BF90 VA: 0x18184D590
	|-HashSet<ulong>..ctor
	|
	|-RVA: 0x184DD10 Offset: 0x184C710 VA: 0x18184DD10
	|-HashSet<Vector2Int>..ctor
	|
	|-RVA: 0x184D230 Offset: 0x184BC30 VA: 0x18184D230
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x184DCA0 Offset: 0x184C6A0 VA: 0x18184DCA0
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18214E0 Offset: 0x181FEE0 VA: 0x1818214E0
	|-HashSet<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x1838D10 Offset: 0x1837710 VA: 0x181838D10
	|-HashSet<bool>..ctor
	|
	|-RVA: 0x183A0B0 Offset: 0x1838AB0 VA: 0x18183A0B0
	|-HashSet<int>..ctor
	|
	|-RVA: 0x18381A0 Offset: 0x1836BA0 VA: 0x1818381A0
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x1838480 Offset: 0x1836E80 VA: 0x181838480
	|-HashSet<InternedString>..ctor
	|
	|-RVA: 0x18394B0 Offset: 0x1837EB0 VA: 0x1818394B0
	|-HashSet<object>..ctor
	|
	|-RVA: 0x1838080 Offset: 0x1836A80 VA: 0x181838080
	|-HashSet<Scene>..ctor
	|
	|-RVA: 0x18395D0 Offset: 0x1837FD0 VA: 0x1818395D0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x184CFF0 Offset: 0x184B9F0 VA: 0x18184CFF0
	|-HashSet<UInt32Enum>..ctor
	|
	|-RVA: 0x184E660 Offset: 0x184D060 VA: 0x18184E660
	|-HashSet<ulong>..ctor
	|
	|-RVA: 0x184DFE0 Offset: 0x184C9E0 VA: 0x18184DFE0
	|-HashSet<Vector2Int>..ctor
	|
	|-RVA: 0x184D110 Offset: 0x184BB10 VA: 0x18184D110
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x184DEE0 Offset: 0x184C8E0 VA: 0x18184DEE0
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821690 Offset: 0x1820090 VA: 0x181821690
	|-HashSet<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x183B080 Offset: 0x1839A80 VA: 0x18183B080
	|-HashSet<bool>..ctor
	|
	|-RVA: 0x1838690 Offset: 0x1837090 VA: 0x181838690
	|-HashSet<int>..ctor
	|
	|-RVA: 0x1839240 Offset: 0x1837C40 VA: 0x181839240
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x1839C40 Offset: 0x1838640 VA: 0x181839C40
	|-HashSet<InternedString>..ctor
	|
	|-RVA: 0x183A1D0 Offset: 0x1838BD0 VA: 0x18183A1D0
	|-HashSet<object>..ctor
	|
	|-RVA: 0x18383B0 Offset: 0x1836DB0 VA: 0x1818383B0
	|-HashSet<Scene>..ctor
	|
	|-RVA: 0x1839BE0 Offset: 0x18385E0 VA: 0x181839BE0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x184CF00 Offset: 0x184B900 VA: 0x18184CF00
	|-HashSet<UInt32Enum>..ctor
	|
	|-RVA: 0x184DC40 Offset: 0x184C640 VA: 0x18184DC40
	|-HashSet<ulong>..ctor
	|
	|-RVA: 0x184DE80 Offset: 0x184C880 VA: 0x18184DE80
	|-HashSet<Vector2Int>..ctor
	|
	|-RVA: 0x184D600 Offset: 0x184C000 VA: 0x18184D600
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x184E510 Offset: 0x184CF10 VA: 0x18184E510
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18217E0 Offset: 0x18201E0 VA: 0x1818217E0
	|-HashSet<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x1838E30 Offset: 0x1837830 VA: 0x181838E30
	|-HashSet<bool>..ctor
	|
	|-RVA: 0x1839760 Offset: 0x1838160 VA: 0x181839760
	|-HashSet<int>..ctor
	|
	|-RVA: 0x1838870 Offset: 0x1837270 VA: 0x181838870
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x183AC30 Offset: 0x1839630 VA: 0x18183AC30
	|-HashSet<InternedString>..ctor
	|
	|-RVA: 0x183A680 Offset: 0x1839080 VA: 0x18183A680
	|-HashSet<object>..ctor
	|
	|-RVA: 0x1839CA0 Offset: 0x18386A0 VA: 0x181839CA0
	|-HashSet<Scene>..ctor
	|
	|-RVA: 0x1837C70 Offset: 0x1836670 VA: 0x181837C70
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x184CA60 Offset: 0x184B460 VA: 0x18184CA60
	|-HashSet<UInt32Enum>..ctor
	|
	|-RVA: 0x184E100 Offset: 0x184CB00 VA: 0x18184E100
	|-HashSet<ulong>..ctor
	|
	|-RVA: 0x184E780 Offset: 0x184D180 VA: 0x18184E780
	|-HashSet<Vector2Int>..ctor
	|
	|-RVA: 0x184D830 Offset: 0x184C230 VA: 0x18184D830
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x184D390 Offset: 0x184BD90 VA: 0x18184D390
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821C20 Offset: 0x1820620 VA: 0x181821C20
	|-HashSet<ValueTuple<int, object>>..ctor
	|-HashSet<bool>..ctor
	|-HashSet<int>..ctor
	|-HashSet<Int32Enum>..ctor
	|-HashSet<InternedString>..ctor
	|-HashSet<object>..ctor
	|-HashSet<Scene>..ctor
	|-HashSet<uint>..ctor
	|-HashSet<UInt32Enum>..ctor
	|-HashSet<ulong>..ctor
	|-HashSet<Vector2Int>..ctor
	|-HashSet<Vector3Int>..ctor
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CopyFrom(HashSet<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181E780 Offset: 0x181D180 VA: 0x18181E780
	|-HashSet<ValueTuple<int, object>>.CopyFrom
	|
	|-RVA: 0x1827A70 Offset: 0x1826470 VA: 0x181827A70
	|-HashSet<bool>.CopyFrom
	|
	|-RVA: 0x18271F0 Offset: 0x1825BF0 VA: 0x1818271F0
	|-HashSet<int>.CopyFrom
	|
	|-RVA: 0x18277A0 Offset: 0x18261A0 VA: 0x1818277A0
	|-HashSet<Int32Enum>.CopyFrom
	|
	|-RVA: 0x18274C0 Offset: 0x1825EC0 VA: 0x1818274C0
	|-HashSet<InternedString>.CopyFrom
	|
	|-RVA: 0x1826980 Offset: 0x1825380 VA: 0x181826980
	|-HashSet<object>.CopyFrom
	|
	|-RVA: 0x1826C50 Offset: 0x1825650 VA: 0x181826C50
	|-HashSet<Scene>.CopyFrom
	|
	|-RVA: 0x1826F20 Offset: 0x1825920 VA: 0x181826F20
	|-HashSet<uint>.CopyFrom
	|
	|-RVA: 0x183FE30 Offset: 0x183E830 VA: 0x18183FE30
	|-HashSet<UInt32Enum>.CopyFrom
	|
	|-RVA: 0x183FB60 Offset: 0x183E560 VA: 0x18183FB60
	|-HashSet<ulong>.CopyFrom
	|
	|-RVA: 0x183F890 Offset: 0x183E290 VA: 0x18183F890
	|-HashSet<Vector2Int>.CopyFrom
	|
	|-RVA: 0x183F5A0 Offset: 0x183DFA0 VA: 0x18183F5A0
	|-HashSet<Vector3Int>.CopyFrom
	|
	|-RVA: 0x1840100 Offset: 0x183EB00 VA: 0x181840100
	|-HashSet<__Il2CppFullySharedGenericType>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18216F0 Offset: 0x18200F0 VA: 0x1818216F0
	|-HashSet<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x183AB40 Offset: 0x1839540 VA: 0x18183AB40
	|-HashSet<bool>..ctor
	|
	|-RVA: 0x183A390 Offset: 0x1838D90 VA: 0x18183A390
	|-HashSet<int>..ctor
	|
	|-RVA: 0x18385A0 Offset: 0x1836FA0 VA: 0x1818385A0
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x1838780 Offset: 0x1837180 VA: 0x181838780
	|-HashSet<InternedString>..ctor
	|
	|-RVA: 0x18382C0 Offset: 0x1836CC0 VA: 0x1818382C0
	|-HashSet<object>..ctor
	|
	|-RVA: 0x183A2A0 Offset: 0x1838CA0 VA: 0x18183A2A0
	|-HashSet<Scene>..ctor
	|
	|-RVA: 0x18392A0 Offset: 0x1837CA0 VA: 0x1818392A0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x184EB90 Offset: 0x184D590 VA: 0x18184EB90
	|-HashSet<UInt32Enum>..ctor
	|
	|-RVA: 0x184D2A0 Offset: 0x184BCA0 VA: 0x18184D2A0
	|-HashSet<ulong>..ctor
	|
	|-RVA: 0x184E570 Offset: 0x184CF70 VA: 0x18184E570
	|-HashSet<Vector2Int>..ctor
	|
	|-RVA: 0x184D6B0 Offset: 0x184C0B0 VA: 0x18184D6B0
	|-HashSet<Vector3Int>..ctor
	|
	|-RVA: 0x184DF40 Offset: 0x184C940 VA: 0x18184DF40
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181DD60 Offset: 0x181C760 VA: 0x18181DD60
	|-HashSet<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1823560 Offset: 0x1821F60 VA: 0x181823560
	|-HashSet<bool>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1823580 Offset: 0x1821F80 VA: 0x181823580
	|-HashSet<int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1823540 Offset: 0x1821F40 VA: 0x181823540
	|-HashSet<Int32Enum>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1823510 Offset: 0x1821F10 VA: 0x181823510
	|-HashSet<InternedString>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x18234F0 Offset: 0x1821EF0 VA: 0x1818234F0
	|-HashSet<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x18235A0 Offset: 0x1821FA0 VA: 0x1818235A0
	|-HashSet<Scene>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x18235C0 Offset: 0x1821FC0 VA: 0x1818235C0
	|-HashSet<uint>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x183C6D0 Offset: 0x183B0D0 VA: 0x18183C6D0
	|-HashSet<UInt32Enum>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x183C820 Offset: 0x183B220 VA: 0x18183C820
	|-HashSet<ulong>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x183C6B0 Offset: 0x183B0B0 VA: 0x18183C6B0
	|-HashSet<Vector2Int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x183C7E0 Offset: 0x183B1E0 VA: 0x18183C7E0
	|-HashSet<Vector3Int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x184B140 Offset: 0x1849B40 VA: 0x18184B140
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181E2C0 Offset: 0x181CCC0 VA: 0x18181E2C0
	|-HashSet<ValueTuple<int, object>>.Clear
	|-HashSet<bool>.Clear
	|-HashSet<int>.Clear
	|-HashSet<Int32Enum>.Clear
	|-HashSet<InternedString>.Clear
	|-HashSet<object>.Clear
	|-HashSet<Scene>.Clear
	|-HashSet<uint>.Clear
	|-HashSet<UInt32Enum>.Clear
	|-HashSet<ulong>.Clear
	|-HashSet<Vector2Int>.Clear
	|-HashSet<Vector3Int>.Clear
	|-HashSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181E550 Offset: 0x181CF50 VA: 0x18181E550
	|-HashSet<ValueTuple<int, object>>.Contains
	|-HashSet<InternedString>.Contains
	|
	|-RVA: 0x18262F0 Offset: 0x1824CF0 VA: 0x1818262F0
	|-HashSet<bool>.Contains
	|
	|-RVA: 0x1826480 Offset: 0x1824E80 VA: 0x181826480
	|-HashSet<int>.Contains
	|-HashSet<Int32Enum>.Contains
	|
	|-RVA: 0x1826650 Offset: 0x1825050 VA: 0x181826650
	|-HashSet<object>.Contains
	|
	|-RVA: 0x18267E0 Offset: 0x18251E0 VA: 0x1818267E0
	|-HashSet<Scene>.Contains
	|
	|-RVA: 0x1826160 Offset: 0x1824B60 VA: 0x181826160
	|-HashSet<uint>.Contains
	|-HashSet<UInt32Enum>.Contains
	|
	|-RVA: 0x183F1C0 Offset: 0x183DBC0 VA: 0x18183F1C0
	|-HashSet<ulong>.Contains
	|
	|-RVA: 0x183ECE0 Offset: 0x183D6E0 VA: 0x18183ECE0
	|-HashSet<Vector2Int>.Contains
	|
	|-RVA: 0x183F350 Offset: 0x183DD50 VA: 0x18183F350
	|-HashSet<Vector3Int>.Contains
	|
	|-RVA: 0x183EE70 Offset: 0x183D870 VA: 0x18183EE70
	|-HashSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181ED10 Offset: 0x181D710 VA: 0x18181ED10
	|-HashSet<ValueTuple<int, object>>.CopyTo
	|
	|-RVA: 0x1828280 Offset: 0x1826C80 VA: 0x181828280
	|-HashSet<bool>.CopyTo
	|
	|-RVA: 0x1828250 Offset: 0x1826C50 VA: 0x181828250
	|-HashSet<int>.CopyTo
	|-HashSet<Int32Enum>.CopyTo
	|-HashSet<Scene>.CopyTo
	|-HashSet<uint>.CopyTo
	|-HashSet<UInt32Enum>.CopyTo
	|
	|-RVA: 0x18282B0 Offset: 0x1826CB0 VA: 0x1818282B0
	|-HashSet<InternedString>.CopyTo
	|
	|-RVA: 0x18287E0 Offset: 0x18271E0 VA: 0x1818287E0
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x1840DF0 Offset: 0x183F7F0 VA: 0x181840DF0
	|-HashSet<ulong>.CopyTo
	|-HashSet<Vector2Int>.CopyTo
	|
	|-RVA: 0x1840500 Offset: 0x183EF00 VA: 0x181840500
	|-HashSet<Vector3Int>.CopyTo
	|
	|-RVA: 0x1840B70 Offset: 0x183F570 VA: 0x181840B70
	|-HashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1820990 Offset: 0x181F390 VA: 0x181820990
	|-HashSet<ValueTuple<int, object>>.Remove
	|-HashSet<InternedString>.Remove
	|
	|-RVA: 0x18342F0 Offset: 0x1832CF0 VA: 0x1818342F0
	|-HashSet<bool>.Remove
	|
	|-RVA: 0x1833DF0 Offset: 0x18327F0 VA: 0x181833DF0
	|-HashSet<int>.Remove
	|-HashSet<Int32Enum>.Remove
	|
	|-RVA: 0x1834090 Offset: 0x1832A90 VA: 0x181834090
	|-HashSet<object>.Remove
	|
	|-RVA: 0x1833B80 Offset: 0x1832580 VA: 0x181833B80
	|-HashSet<Scene>.Remove
	|
	|-RVA: 0x1833930 Offset: 0x1832330 VA: 0x181833930
	|-HashSet<uint>.Remove
	|-HashSet<UInt32Enum>.Remove
	|
	|-RVA: 0x1849580 Offset: 0x1847F80 VA: 0x181849580
	|-HashSet<ulong>.Remove
	|
	|-RVA: 0x18497C0 Offset: 0x18481C0 VA: 0x1818497C0
	|-HashSet<Vector2Int>.Remove
	|
	|-RVA: 0x1849270 Offset: 0x1847C70 VA: 0x181849270
	|-HashSet<Vector3Int>.Remove
	|
	|-RVA: 0x1849A10 Offset: 0x1848410 VA: 0x181849A10
	|-HashSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	|-HashSet<ValueTuple<int, object>>.get_Count
	|-HashSet<bool>.get_Count
	|-HashSet<int>.get_Count
	|-HashSet<Int32Enum>.get_Count
	|-HashSet<InternedString>.get_Count
	|-HashSet<object>.get_Count
	|-HashSet<Scene>.get_Count
	|-HashSet<uint>.get_Count
	|-HashSet<UInt32Enum>.get_Count
	|-HashSet<ulong>.get_Count
	|-HashSet<Vector2Int>.get_Count
	|-HashSet<Vector3Int>.get_Count
	|-HashSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-HashSet<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<bool>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<InternedString>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<Scene>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<UInt32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<ulong>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<Vector2Int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<Vector3Int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public HashSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181ED40 Offset: 0x181D740 VA: 0x18181ED40
	|-HashSet<ValueTuple<int, object>>.GetEnumerator
	|-HashSet<InternedString>.GetEnumerator
	|
	|-RVA: 0x1828810 Offset: 0x1827210 VA: 0x181828810
	|-HashSet<bool>.GetEnumerator
	|
	|-RVA: 0x1828890 Offset: 0x1827290 VA: 0x181828890
	|-HashSet<int>.GetEnumerator
	|-HashSet<Int32Enum>.GetEnumerator
	|-HashSet<Scene>.GetEnumerator
	|-HashSet<uint>.GetEnumerator
	|-HashSet<UInt32Enum>.GetEnumerator
	|
	|-RVA: 0x1828850 Offset: 0x1827250 VA: 0x181828850
	|-HashSet<object>.GetEnumerator
	|-HashSet<ulong>.GetEnumerator
	|-HashSet<Vector2Int>.GetEnumerator
	|
	|-RVA: 0x1840E20 Offset: 0x183F820 VA: 0x181840E20
	|-HashSet<Vector3Int>.GetEnumerator
	|
	|-RVA: 0x1840E60 Offset: 0x183F860 VA: 0x181840E60
	|-HashSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821000 Offset: 0x181FA00 VA: 0x181821000
	|-HashSet<ValueTuple<int, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<InternedString>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1835E40 Offset: 0x1834840 VA: 0x181835E40
	|-HashSet<bool>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1835D60 Offset: 0x1834760 VA: 0x181835D60
	|-HashSet<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<Scene>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<UInt32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1835DD0 Offset: 0x18347D0 VA: 0x181835DD0
	|-HashSet<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-HashSet<Vector2Int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x184B230 Offset: 0x1849C30 VA: 0x18184B230
	|-HashSet<Vector3Int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x184B2A0 Offset: 0x1849CA0 VA: 0x18184B2A0
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821000 Offset: 0x181FA00 VA: 0x181821000
	|-HashSet<ValueTuple<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<InternedString>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1835E40 Offset: 0x1834840 VA: 0x181835E40
	|-HashSet<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1835D60 Offset: 0x1834760 VA: 0x181835D60
	|-HashSet<int>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<Scene>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<uint>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<UInt32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1835DD0 Offset: 0x18347D0 VA: 0x181835DD0
	|-HashSet<object>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<ulong>.System.Collections.IEnumerable.GetEnumerator
	|-HashSet<Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x184B230 Offset: 0x1849C30 VA: 0x18184B230
	|-HashSet<Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x184B2A0 Offset: 0x1849CA0 VA: 0x18184B2A0
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181ED80 Offset: 0x181D780 VA: 0x18181ED80
	|-HashSet<ValueTuple<int, object>>.GetObjectData
	|
	|-RVA: 0x1828B00 Offset: 0x1827500 VA: 0x181828B00
	|-HashSet<bool>.GetObjectData
	|
	|-RVA: 0x1828D30 Offset: 0x1827730 VA: 0x181828D30
	|-HashSet<int>.GetObjectData
	|
	|-RVA: 0x18295F0 Offset: 0x1827FF0 VA: 0x1818295F0
	|-HashSet<Int32Enum>.GetObjectData
	|
	|-RVA: 0x1828F60 Offset: 0x1827960 VA: 0x181828F60
	|-HashSet<InternedString>.GetObjectData
	|
	|-RVA: 0x18293C0 Offset: 0x1827DC0 VA: 0x1818293C0
	|-HashSet<object>.GetObjectData
	|
	|-RVA: 0x1829190 Offset: 0x1827B90 VA: 0x181829190
	|-HashSet<Scene>.GetObjectData
	|
	|-RVA: 0x18288D0 Offset: 0x18272D0 VA: 0x1818288D0
	|-HashSet<uint>.GetObjectData
	|
	|-RVA: 0x1841580 Offset: 0x183FF80 VA: 0x181841580
	|-HashSet<UInt32Enum>.GetObjectData
	|
	|-RVA: 0x1841120 Offset: 0x183FB20 VA: 0x181841120
	|-HashSet<ulong>.GetObjectData
	|
	|-RVA: 0x18417B0 Offset: 0x18401B0 VA: 0x1818417B0
	|-HashSet<Vector2Int>.GetObjectData
	|
	|-RVA: 0x1841350 Offset: 0x183FD50 VA: 0x181841350
	|-HashSet<Vector3Int>.GetObjectData
	|
	|-RVA: 0x1840F10 Offset: 0x183F910 VA: 0x181840F10
	|-HashSet<__Il2CppFullySharedGenericType>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181FEE0 Offset: 0x181E8E0 VA: 0x18181FEE0
	|-HashSet<ValueTuple<int, object>>.OnDeserialization
	|
	|-RVA: 0x182FE70 Offset: 0x182E870 VA: 0x18182FE70
	|-HashSet<bool>.OnDeserialization
	|
	|-RVA: 0x1831810 Offset: 0x1830210 VA: 0x181831810
	|-HashSet<int>.OnDeserialization
	|
	|-RVA: 0x1831EB0 Offset: 0x18308B0 VA: 0x181831EB0
	|-HashSet<Int32Enum>.OnDeserialization
	|
	|-RVA: 0x182F760 Offset: 0x182E160 VA: 0x18182F760
	|-HashSet<InternedString>.OnDeserialization
	|
	|-RVA: 0x18311A0 Offset: 0x182FBA0 VA: 0x1818311A0
	|-HashSet<object>.OnDeserialization
	|
	|-RVA: 0x1830B40 Offset: 0x182F540 VA: 0x181830B40
	|-HashSet<Scene>.OnDeserialization
	|
	|-RVA: 0x18304E0 Offset: 0x182EEE0 VA: 0x1818304E0
	|-HashSet<uint>.OnDeserialization
	|
	|-RVA: 0x1847A60 Offset: 0x1846460 VA: 0x181847A60
	|-HashSet<UInt32Enum>.OnDeserialization
	|
	|-RVA: 0x1846C90 Offset: 0x1845690 VA: 0x181846C90
	|-HashSet<ulong>.OnDeserialization
	|
	|-RVA: 0x1846630 Offset: 0x1845030 VA: 0x181846630
	|-HashSet<Vector2Int>.OnDeserialization
	|
	|-RVA: 0x1847300 Offset: 0x1845D00 VA: 0x181847300
	|-HashSet<Vector3Int>.OnDeserialization
	|
	|-RVA: 0x1846210 Offset: 0x1844C10 VA: 0x181846210
	|-HashSet<__Il2CppFullySharedGenericType>.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181DD60 Offset: 0x181C760 VA: 0x18181DD60
	|-HashSet<ValueTuple<int, object>>.Add
	|
	|-RVA: 0x1823560 Offset: 0x1821F60 VA: 0x181823560
	|-HashSet<bool>.Add
	|
	|-RVA: 0x1823580 Offset: 0x1821F80 VA: 0x181823580
	|-HashSet<int>.Add
	|
	|-RVA: 0x1823540 Offset: 0x1821F40 VA: 0x181823540
	|-HashSet<Int32Enum>.Add
	|
	|-RVA: 0x1823510 Offset: 0x1821F10 VA: 0x181823510
	|-HashSet<InternedString>.Add
	|
	|-RVA: 0x18234F0 Offset: 0x1821EF0 VA: 0x1818234F0
	|-HashSet<object>.Add
	|
	|-RVA: 0x18235A0 Offset: 0x1821FA0 VA: 0x1818235A0
	|-HashSet<Scene>.Add
	|
	|-RVA: 0x18235C0 Offset: 0x1821FC0 VA: 0x1818235C0
	|-HashSet<uint>.Add
	|
	|-RVA: 0x183C6D0 Offset: 0x183B0D0 VA: 0x18183C6D0
	|-HashSet<UInt32Enum>.Add
	|
	|-RVA: 0x183C820 Offset: 0x183B220 VA: 0x18183C820
	|-HashSet<ulong>.Add
	|
	|-RVA: 0x183C6B0 Offset: 0x183B0B0 VA: 0x18183C6B0
	|-HashSet<Vector2Int>.Add
	|
	|-RVA: 0x183C7E0 Offset: 0x183B1E0 VA: 0x18183C7E0
	|-HashSet<Vector3Int>.Add
	|
	|-RVA: 0x183C6F0 Offset: 0x183B0F0 VA: 0x18183C6F0
	|-HashSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public void UnionWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18212A0 Offset: 0x181FCA0 VA: 0x1818212A0
	|-HashSet<ValueTuple<int, object>>.UnionWith
	|
	|-RVA: 0x1836D00 Offset: 0x1835700 VA: 0x181836D00
	|-HashSet<bool>.UnionWith
	|
	|-RVA: 0x1837140 Offset: 0x1835B40 VA: 0x181837140
	|-HashSet<int>.UnionWith
	|
	|-RVA: 0x1836F20 Offset: 0x1835920 VA: 0x181836F20
	|-HashSet<Int32Enum>.UnionWith
	|
	|-RVA: 0x18379C0 Offset: 0x18363C0 VA: 0x1818379C0
	|-HashSet<InternedString>.UnionWith
	|
	|-RVA: 0x18377A0 Offset: 0x18361A0 VA: 0x1818377A0
	|-HashSet<object>.UnionWith
	|
	|-RVA: 0x1837360 Offset: 0x1835D60 VA: 0x181837360
	|-HashSet<Scene>.UnionWith
	|
	|-RVA: 0x1837580 Offset: 0x1835F80 VA: 0x181837580
	|-HashSet<uint>.UnionWith
	|
	|-RVA: 0x184C3D0 Offset: 0x184ADD0 VA: 0x18184C3D0
	|-HashSet<UInt32Enum>.UnionWith
	|
	|-RVA: 0x184C5F0 Offset: 0x184AFF0 VA: 0x18184C5F0
	|-HashSet<ulong>.UnionWith
	|
	|-RVA: 0x184C1B0 Offset: 0x184ABB0 VA: 0x18184C1B0
	|-HashSet<Vector2Int>.UnionWith
	|
	|-RVA: 0x184C810 Offset: 0x184B210 VA: 0x18184C810
	|-HashSet<Vector3Int>.UnionWith
	|
	|-RVA: 0x184BE80 Offset: 0x184A880 VA: 0x18184BE80
	|-HashSet<__Il2CppFullySharedGenericType>.UnionWith
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public bool IsSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181FB50 Offset: 0x181E550 VA: 0x18181FB50
	|-HashSet<ValueTuple<int, object>>.IsSubsetOf
	|
	|-RVA: 0x182E380 Offset: 0x182CD80 VA: 0x18182E380
	|-HashSet<bool>.IsSubsetOf
	|
	|-RVA: 0x182DE70 Offset: 0x182C870 VA: 0x18182DE70
	|-HashSet<int>.IsSubsetOf
	|
	|-RVA: 0x182E6E0 Offset: 0x182D0E0 VA: 0x18182E6E0
	|-HashSet<Int32Enum>.IsSubsetOf
	|
	|-RVA: 0x182E890 Offset: 0x182D290 VA: 0x18182E890
	|-HashSet<InternedString>.IsSubsetOf
	|
	|-RVA: 0x182E530 Offset: 0x182CF30 VA: 0x18182E530
	|-HashSet<object>.IsSubsetOf
	|
	|-RVA: 0x182E1D0 Offset: 0x182CBD0 VA: 0x18182E1D0
	|-HashSet<Scene>.IsSubsetOf
	|
	|-RVA: 0x182E020 Offset: 0x182CA20 VA: 0x18182E020
	|-HashSet<uint>.IsSubsetOf
	|
	|-RVA: 0x18455B0 Offset: 0x1843FB0 VA: 0x1818455B0
	|-HashSet<UInt32Enum>.IsSubsetOf
	|
	|-RVA: 0x1845400 Offset: 0x1843E00 VA: 0x181845400
	|-HashSet<ulong>.IsSubsetOf
	|
	|-RVA: 0x1845250 Offset: 0x1843C50 VA: 0x181845250
	|-HashSet<Vector2Int>.IsSubsetOf
	|
	|-RVA: 0x18450A0 Offset: 0x1843AA0 VA: 0x1818450A0
	|-HashSet<Vector3Int>.IsSubsetOf
	|
	|-RVA: 0x1845760 Offset: 0x1844160 VA: 0x181845760
	|-HashSet<__Il2CppFullySharedGenericType>.IsSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool IsProperSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181F570 Offset: 0x181DF70 VA: 0x18181F570
	|-HashSet<ValueTuple<int, object>>.IsProperSubsetOf
	|
	|-RVA: 0x182B6E0 Offset: 0x182A0E0 VA: 0x18182B6E0
	|-HashSet<bool>.IsProperSubsetOf
	|
	|-RVA: 0x182C220 Offset: 0x182AC20 VA: 0x18182C220
	|-HashSet<int>.IsProperSubsetOf
	|
	|-RVA: 0x182C460 Offset: 0x182AE60 VA: 0x18182C460
	|-HashSet<Int32Enum>.IsProperSubsetOf
	|
	|-RVA: 0x182BFE0 Offset: 0x182A9E0 VA: 0x18182BFE0
	|-HashSet<InternedString>.IsProperSubsetOf
	|
	|-RVA: 0x182BDA0 Offset: 0x182A7A0 VA: 0x18182BDA0
	|-HashSet<object>.IsProperSubsetOf
	|
	|-RVA: 0x182BB60 Offset: 0x182A560 VA: 0x18182BB60
	|-HashSet<Scene>.IsProperSubsetOf
	|
	|-RVA: 0x182B920 Offset: 0x182A320 VA: 0x18182B920
	|-HashSet<uint>.IsProperSubsetOf
	|
	|-RVA: 0x18435B0 Offset: 0x1841FB0 VA: 0x1818435B0
	|-HashSet<UInt32Enum>.IsProperSubsetOf
	|
	|-RVA: 0x18437F0 Offset: 0x18421F0 VA: 0x1818437F0
	|-HashSet<ulong>.IsProperSubsetOf
	|
	|-RVA: 0x1843C50 Offset: 0x1842650 VA: 0x181843C50
	|-HashSet<Vector2Int>.IsProperSubsetOf
	|
	|-RVA: 0x1843370 Offset: 0x1841D70 VA: 0x181843370
	|-HashSet<Vector3Int>.IsProperSubsetOf
	|
	|-RVA: 0x1843A30 Offset: 0x1842430 VA: 0x181843A30
	|-HashSet<__Il2CppFullySharedGenericType>.IsProperSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool IsSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181FD00 Offset: 0x181E700 VA: 0x18181FD00
	|-HashSet<ValueTuple<int, object>>.IsSupersetOf
	|
	|-RVA: 0x182EE00 Offset: 0x182D800 VA: 0x18182EE00
	|-HashSet<bool>.IsSupersetOf
	|
	|-RVA: 0x182F3A0 Offset: 0x182DDA0 VA: 0x18182F3A0
	|-HashSet<int>.IsSupersetOf
	|
	|-RVA: 0x182F580 Offset: 0x182DF80 VA: 0x18182F580
	|-HashSet<Int32Enum>.IsSupersetOf
	|
	|-RVA: 0x182F1C0 Offset: 0x182DBC0 VA: 0x18182F1C0
	|-HashSet<InternedString>.IsSupersetOf
	|
	|-RVA: 0x182EC20 Offset: 0x182D620 VA: 0x18182EC20
	|-HashSet<object>.IsSupersetOf
	|
	|-RVA: 0x182EFE0 Offset: 0x182D9E0 VA: 0x18182EFE0
	|-HashSet<Scene>.IsSupersetOf
	|
	|-RVA: 0x182EA40 Offset: 0x182D440 VA: 0x18182EA40
	|-HashSet<uint>.IsSupersetOf
	|
	|-RVA: 0x18458F0 Offset: 0x18442F0 VA: 0x1818458F0
	|-HashSet<UInt32Enum>.IsSupersetOf
	|
	|-RVA: 0x1846030 Offset: 0x1844A30 VA: 0x181846030
	|-HashSet<ulong>.IsSupersetOf
	|
	|-RVA: 0x1845C70 Offset: 0x1844670 VA: 0x181845C70
	|-HashSet<Vector2Int>.IsSupersetOf
	|
	|-RVA: 0x1845E50 Offset: 0x1844850 VA: 0x181845E50
	|-HashSet<Vector3Int>.IsSupersetOf
	|
	|-RVA: 0x1845AD0 Offset: 0x18444D0 VA: 0x181845AD0
	|-HashSet<__Il2CppFullySharedGenericType>.IsSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool IsProperSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181F7B0 Offset: 0x181E1B0 VA: 0x18181F7B0
	|-HashSet<ValueTuple<int, object>>.IsProperSupersetOf
	|
	|-RVA: 0x182CCD0 Offset: 0x182B6D0 VA: 0x18182CCD0
	|-HashSet<bool>.IsProperSupersetOf
	|
	|-RVA: 0x182CEE0 Offset: 0x182B8E0 VA: 0x18182CEE0
	|-HashSet<int>.IsProperSupersetOf
	|
	|-RVA: 0x182D0F0 Offset: 0x182BAF0 VA: 0x18182D0F0
	|-HashSet<Int32Enum>.IsProperSupersetOf
	|
	|-RVA: 0x182C8B0 Offset: 0x182B2B0 VA: 0x18182C8B0
	|-HashSet<InternedString>.IsProperSupersetOf
	|
	|-RVA: 0x182D300 Offset: 0x182BD00 VA: 0x18182D300
	|-HashSet<object>.IsProperSupersetOf
	|
	|-RVA: 0x182C6A0 Offset: 0x182B0A0 VA: 0x18182C6A0
	|-HashSet<Scene>.IsProperSupersetOf
	|
	|-RVA: 0x182CAC0 Offset: 0x182B4C0 VA: 0x18182CAC0
	|-HashSet<uint>.IsProperSupersetOf
	|
	|-RVA: 0x18446B0 Offset: 0x18430B0 VA: 0x1818446B0
	|-HashSet<UInt32Enum>.IsProperSupersetOf
	|
	|-RVA: 0x1843E90 Offset: 0x1842890 VA: 0x181843E90
	|-HashSet<ulong>.IsProperSupersetOf
	|
	|-RVA: 0x18440A0 Offset: 0x1842AA0 VA: 0x1818440A0
	|-HashSet<Vector2Int>.IsProperSupersetOf
	|
	|-RVA: 0x18442B0 Offset: 0x1842CB0 VA: 0x1818442B0
	|-HashSet<Vector3Int>.IsProperSupersetOf
	|
	|-RVA: 0x18444C0 Offset: 0x1842EC0 VA: 0x1818444C0
	|-HashSet<__Il2CppFullySharedGenericType>.IsProperSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Overlaps(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18205F0 Offset: 0x181EFF0 VA: 0x1818205F0
	|-HashSet<ValueTuple<int, object>>.Overlaps
	|
	|-RVA: 0x18331D0 Offset: 0x1831BD0 VA: 0x1818331D0
	|-HashSet<bool>.Overlaps
	|
	|-RVA: 0x1832550 Offset: 0x1830F50 VA: 0x181832550
	|-HashSet<int>.Overlaps
	|
	|-RVA: 0x1832750 Offset: 0x1831150 VA: 0x181832750
	|-HashSet<Int32Enum>.Overlaps
	|
	|-RVA: 0x1832D50 Offset: 0x1831750 VA: 0x181832D50
	|-HashSet<InternedString>.Overlaps
	|
	|-RVA: 0x1832B50 Offset: 0x1831550 VA: 0x181832B50
	|-HashSet<object>.Overlaps
	|
	|-RVA: 0x1832950 Offset: 0x1831350 VA: 0x181832950
	|-HashSet<Scene>.Overlaps
	|
	|-RVA: 0x1832FD0 Offset: 0x18319D0 VA: 0x181832FD0
	|-HashSet<uint>.Overlaps
	|
	|-RVA: 0x18482C0 Offset: 0x1846CC0 VA: 0x1818482C0
	|-HashSet<UInt32Enum>.Overlaps
	|
	|-RVA: 0x18480C0 Offset: 0x1846AC0 VA: 0x1818480C0
	|-HashSet<ulong>.Overlaps
	|
	|-RVA: 0x1848A30 Offset: 0x1847430 VA: 0x181848A30
	|-HashSet<Vector2Int>.Overlaps
	|
	|-RVA: 0x18484C0 Offset: 0x1846EC0 VA: 0x1818484C0
	|-HashSet<Vector3Int>.Overlaps
	|
	|-RVA: 0x1848740 Offset: 0x1847140 VA: 0x181848740
	|-HashSet<__Il2CppFullySharedGenericType>.Overlaps
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool SetEquals(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1820DD0 Offset: 0x181F7D0 VA: 0x181820DD0
	|-HashSet<ValueTuple<int, object>>.SetEquals
	|
	|-RVA: 0x1835040 Offset: 0x1833A40 VA: 0x181835040
	|-HashSet<bool>.SetEquals
	|
	|-RVA: 0x1834E10 Offset: 0x1833810 VA: 0x181834E10
	|-HashSet<int>.SetEquals
	|
	|-RVA: 0x18354A0 Offset: 0x1833EA0 VA: 0x1818354A0
	|-HashSet<Int32Enum>.SetEquals
	|
	|-RVA: 0x18356D0 Offset: 0x18340D0 VA: 0x1818356D0
	|-HashSet<InternedString>.SetEquals
	|
	|-RVA: 0x1835B30 Offset: 0x1834530 VA: 0x181835B30
	|-HashSet<object>.SetEquals
	|
	|-RVA: 0x1835270 Offset: 0x1833C70 VA: 0x181835270
	|-HashSet<Scene>.SetEquals
	|
	|-RVA: 0x1835900 Offset: 0x1834300 VA: 0x181835900
	|-HashSet<uint>.SetEquals
	|
	|-RVA: 0x184A8B0 Offset: 0x18492B0 VA: 0x18184A8B0
	|-HashSet<UInt32Enum>.SetEquals
	|
	|-RVA: 0x184AAE0 Offset: 0x18494E0 VA: 0x18184AAE0
	|-HashSet<ulong>.SetEquals
	|
	|-RVA: 0x184A680 Offset: 0x1849080 VA: 0x18184A680
	|-HashSet<Vector2Int>.SetEquals
	|
	|-RVA: 0x184AF10 Offset: 0x1849910 VA: 0x18184AF10
	|-HashSet<Vector3Int>.SetEquals
	|
	|-RVA: 0x184AD10 Offset: 0x1849710 VA: 0x18184AD10
	|-HashSet<__Il2CppFullySharedGenericType>.SetEquals
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181EA60 Offset: 0x181D460 VA: 0x18181EA60
	|-HashSet<ValueTuple<int, object>>.CopyTo
	|
	|-RVA: 0x18282E0 Offset: 0x1826CE0 VA: 0x1818282E0
	|-HashSet<bool>.CopyTo
	|
	|-RVA: 0x1827D40 Offset: 0x1826740 VA: 0x181827D40
	|-HashSet<int>.CopyTo
	|-HashSet<Int32Enum>.CopyTo
	|-HashSet<Scene>.CopyTo
	|-HashSet<uint>.CopyTo
	|-HashSet<UInt32Enum>.CopyTo
	|
	|-RVA: 0x18287B0 Offset: 0x18271B0 VA: 0x1818287B0
	|-HashSet<InternedString>.CopyTo
	|
	|-RVA: 0x1828220 Offset: 0x1826C20 VA: 0x181828220
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x1840530 Offset: 0x183EF30 VA: 0x181840530
	|-HashSet<ulong>.CopyTo
	|-HashSet<Vector2Int>.CopyTo
	|
	|-RVA: 0x18404D0 Offset: 0x183EED0 VA: 0x1818404D0
	|-HashSet<Vector3Int>.CopyTo
	|
	|-RVA: 0x1840900 Offset: 0x183F300 VA: 0x181840900
	|-HashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181EA90 Offset: 0x181D490 VA: 0x18181EA90
	|-HashSet<ValueTuple<int, object>>.CopyTo
	|
	|-RVA: 0x1828310 Offset: 0x1826D10 VA: 0x181828310
	|-HashSet<bool>.CopyTo
	|
	|-RVA: 0x1827FE0 Offset: 0x18269E0 VA: 0x181827FE0
	|-HashSet<int>.CopyTo
	|-HashSet<Int32Enum>.CopyTo
	|-HashSet<Scene>.CopyTo
	|-HashSet<uint>.CopyTo
	|-HashSet<UInt32Enum>.CopyTo
	|
	|-RVA: 0x1828540 Offset: 0x1826F40 VA: 0x181828540
	|-HashSet<InternedString>.CopyTo
	|
	|-RVA: 0x1827D70 Offset: 0x1826770 VA: 0x181827D70
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x1840930 Offset: 0x183F330 VA: 0x181840930
	|-HashSet<ulong>.CopyTo
	|-HashSet<Vector2Int>.CopyTo
	|
	|-RVA: 0x1840BA0 Offset: 0x183F5A0 VA: 0x181840BA0
	|-HashSet<Vector3Int>.CopyTo
	|
	|-RVA: 0x1840560 Offset: 0x183EF60 VA: 0x181840560
	|-HashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public int RemoveWhere(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1820870 Offset: 0x181F270 VA: 0x181820870
	|-HashSet<ValueTuple<int, object>>.RemoveWhere
	|-HashSet<InternedString>.RemoveWhere
	|
	|-RVA: 0x18335F0 Offset: 0x1831FF0 VA: 0x1818335F0
	|-HashSet<bool>.RemoveWhere
	|
	|-RVA: 0x18333D0 Offset: 0x1831DD0 VA: 0x1818333D0
	|-HashSet<int>.RemoveWhere
	|-HashSet<Int32Enum>.RemoveWhere
	|
	|-RVA: 0x1833710 Offset: 0x1832110 VA: 0x181833710
	|-HashSet<object>.RemoveWhere
	|
	|-RVA: 0x1833820 Offset: 0x1832220 VA: 0x181833820
	|-HashSet<Scene>.RemoveWhere
	|
	|-RVA: 0x18334E0 Offset: 0x1831EE0 VA: 0x1818334E0
	|-HashSet<uint>.RemoveWhere
	|-HashSet<UInt32Enum>.RemoveWhere
	|
	|-RVA: 0x1848D70 Offset: 0x1847770 VA: 0x181848D70
	|-HashSet<ulong>.RemoveWhere
	|
	|-RVA: 0x1848E80 Offset: 0x1847880 VA: 0x181848E80
	|-HashSet<Vector2Int>.RemoveWhere
	|
	|-RVA: 0x1848C30 Offset: 0x1847630 VA: 0x181848C30
	|-HashSet<Vector3Int>.RemoveWhere
	|
	|-RVA: 0x1848F90 Offset: 0x1847990 VA: 0x181848F90
	|-HashSet<__Il2CppFullySharedGenericType>.RemoveWhere
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	|-HashSet<ValueTuple<int, object>>.get_Comparer
	|-HashSet<bool>.get_Comparer
	|-HashSet<int>.get_Comparer
	|-HashSet<Int32Enum>.get_Comparer
	|-HashSet<InternedString>.get_Comparer
	|-HashSet<object>.get_Comparer
	|-HashSet<Scene>.get_Comparer
	|-HashSet<uint>.get_Comparer
	|-HashSet<UInt32Enum>.get_Comparer
	|-HashSet<ulong>.get_Comparer
	|-HashSet<Vector2Int>.get_Comparer
	|-HashSet<Vector3Int>.get_Comparer
	|-HashSet<__Il2CppFullySharedGenericType>.get_Comparer
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1821070 Offset: 0x181FA70 VA: 0x181821070
	|-HashSet<ValueTuple<int, object>>.TrimExcess
	|
	|-RVA: 0x18362B0 Offset: 0x1834CB0 VA: 0x1818362B0
	|-HashSet<bool>.TrimExcess
	|
	|-RVA: 0x1836B00 Offset: 0x1835500 VA: 0x181836B00
	|-HashSet<int>.TrimExcess
	|
	|-RVA: 0x18366D0 Offset: 0x18350D0 VA: 0x1818366D0
	|-HashSet<Int32Enum>.TrimExcess
	|
	|-RVA: 0x18368D0 Offset: 0x18352D0 VA: 0x1818368D0
	|-HashSet<InternedString>.TrimExcess
	|
	|-RVA: 0x18364B0 Offset: 0x1834EB0 VA: 0x1818364B0
	|-HashSet<object>.TrimExcess
	|
	|-RVA: 0x1835EB0 Offset: 0x18348B0 VA: 0x181835EB0
	|-HashSet<Scene>.TrimExcess
	|
	|-RVA: 0x18360B0 Offset: 0x1834AB0 VA: 0x1818360B0
	|-HashSet<uint>.TrimExcess
	|
	|-RVA: 0x184B350 Offset: 0x1849D50 VA: 0x18184B350
	|-HashSet<UInt32Enum>.TrimExcess
	|
	|-RVA: 0x184B8B0 Offset: 0x184A2B0 VA: 0x18184B8B0
	|-HashSet<ulong>.TrimExcess
	|
	|-RVA: 0x184BC90 Offset: 0x184A690 VA: 0x18184BC90
	|-HashSet<Vector2Int>.TrimExcess
	|
	|-RVA: 0x184BAA0 Offset: 0x184A4A0 VA: 0x18184BAA0
	|-HashSet<Vector3Int>.TrimExcess
	|
	|-RVA: 0x184B550 Offset: 0x1849F50 VA: 0x18184B550
	|-HashSet<__Il2CppFullySharedGenericType>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	private int Initialize(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181F1A0 Offset: 0x181DBA0 VA: 0x18181F1A0
	|-HashSet<ValueTuple<int, object>>.Initialize
	|
	|-RVA: 0x182A9C0 Offset: 0x18293C0 VA: 0x18182A9C0
	|-HashSet<bool>.Initialize
	|
	|-RVA: 0x182A8F0 Offset: 0x18292F0 VA: 0x18182A8F0
	|-HashSet<int>.Initialize
	|
	|-RVA: 0x182A680 Offset: 0x1829080 VA: 0x18182A680
	|-HashSet<Int32Enum>.Initialize
	|
	|-RVA: 0x182A5B0 Offset: 0x1828FB0 VA: 0x18182A5B0
	|-HashSet<InternedString>.Initialize
	|
	|-RVA: 0x182A750 Offset: 0x1829150 VA: 0x18182A750
	|-HashSet<object>.Initialize
	|
	|-RVA: 0x182AA90 Offset: 0x1829490 VA: 0x18182AA90
	|-HashSet<Scene>.Initialize
	|
	|-RVA: 0x182A820 Offset: 0x1829220 VA: 0x18182A820
	|-HashSet<uint>.Initialize
	|
	|-RVA: 0x1842260 Offset: 0x1840C60 VA: 0x181842260
	|-HashSet<UInt32Enum>.Initialize
	|
	|-RVA: 0x1842400 Offset: 0x1840E00 VA: 0x181842400
	|-HashSet<ulong>.Initialize
	|
	|-RVA: 0x1842330 Offset: 0x1840D30 VA: 0x181842330
	|-HashSet<Vector2Int>.Initialize
	|
	|-RVA: 0x18424D0 Offset: 0x1840ED0 VA: 0x1818424D0
	|-HashSet<Vector3Int>.Initialize
	|
	|-RVA: 0x18425A0 Offset: 0x1840FA0 VA: 0x1818425A0
	|-HashSet<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181EFB0 Offset: 0x181D9B0 VA: 0x18181EFB0
	|-HashSet<ValueTuple<int, object>>.IncreaseCapacity
	|
	|-RVA: 0x182A1D0 Offset: 0x1828BD0 VA: 0x18182A1D0
	|-HashSet<bool>.IncreaseCapacity
	|
	|-RVA: 0x1829C00 Offset: 0x1828600 VA: 0x181829C00
	|-HashSet<int>.IncreaseCapacity
	|
	|-RVA: 0x182A3C0 Offset: 0x1828DC0 VA: 0x18182A3C0
	|-HashSet<Int32Enum>.IncreaseCapacity
	|
	|-RVA: 0x1829A10 Offset: 0x1828410 VA: 0x181829A10
	|-HashSet<InternedString>.IncreaseCapacity
	|
	|-RVA: 0x1829FE0 Offset: 0x18289E0 VA: 0x181829FE0
	|-HashSet<object>.IncreaseCapacity
	|
	|-RVA: 0x1829820 Offset: 0x1828220 VA: 0x181829820
	|-HashSet<Scene>.IncreaseCapacity
	|
	|-RVA: 0x1829DF0 Offset: 0x18287F0 VA: 0x181829DF0
	|-HashSet<uint>.IncreaseCapacity
	|
	|-RVA: 0x1841DC0 Offset: 0x18407C0 VA: 0x181841DC0
	|-HashSet<UInt32Enum>.IncreaseCapacity
	|
	|-RVA: 0x1841BD0 Offset: 0x18405D0 VA: 0x181841BD0
	|-HashSet<ulong>.IncreaseCapacity
	|
	|-RVA: 0x18419E0 Offset: 0x18403E0 VA: 0x1818419E0
	|-HashSet<Vector2Int>.IncreaseCapacity
	|
	|-RVA: 0x1841FB0 Offset: 0x18409B0 VA: 0x181841FB0
	|-HashSet<Vector3Int>.IncreaseCapacity
	|
	|-RVA: 0x18421A0 Offset: 0x1840BA0 VA: 0x1818421A0
	|-HashSet<__Il2CppFullySharedGenericType>.IncreaseCapacity
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1820C90 Offset: 0x181F690 VA: 0x181820C90
	|-HashSet<ValueTuple<int, object>>.SetCapacity
	|
	|-RVA: 0x1834B90 Offset: 0x1833590 VA: 0x181834B90
	|-HashSet<bool>.SetCapacity
	|
	|-RVA: 0x1834CD0 Offset: 0x18336D0 VA: 0x181834CD0
	|-HashSet<int>.SetCapacity
	|
	|-RVA: 0x1834690 Offset: 0x1833090 VA: 0x181834690
	|-HashSet<Int32Enum>.SetCapacity
	|
	|-RVA: 0x1834A50 Offset: 0x1833450 VA: 0x181834A50
	|-HashSet<InternedString>.SetCapacity
	|
	|-RVA: 0x18347D0 Offset: 0x18331D0 VA: 0x1818347D0
	|-HashSet<object>.SetCapacity
	|
	|-RVA: 0x1834550 Offset: 0x1832F50 VA: 0x181834550
	|-HashSet<Scene>.SetCapacity
	|
	|-RVA: 0x1834910 Offset: 0x1833310 VA: 0x181834910
	|-HashSet<uint>.SetCapacity
	|
	|-RVA: 0x184A0D0 Offset: 0x1848AD0 VA: 0x18184A0D0
	|-HashSet<UInt32Enum>.SetCapacity
	|
	|-RVA: 0x1849F90 Offset: 0x1848990 VA: 0x181849F90
	|-HashSet<ulong>.SetCapacity
	|
	|-RVA: 0x184A540 Offset: 0x1848F40 VA: 0x18184A540
	|-HashSet<Vector2Int>.SetCapacity
	|
	|-RVA: 0x184A400 Offset: 0x1848E00 VA: 0x18184A400
	|-HashSet<Vector3Int>.SetCapacity
	|
	|-RVA: 0x184A210 Offset: 0x1848C10 VA: 0x18184A210
	|-HashSet<__Il2CppFullySharedGenericType>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private bool AddIfNotPresent(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181D8F0 Offset: 0x181C2F0 VA: 0x18181D8F0
	|-HashSet<ValueTuple<int, object>>.AddIfNotPresent
	|
	|-RVA: 0x18222B0 Offset: 0x1820CB0 VA: 0x1818222B0
	|-HashSet<bool>.AddIfNotPresent
	|
	|-RVA: 0x1821CD0 Offset: 0x18206D0 VA: 0x181821CD0
	|-HashSet<int>.AddIfNotPresent
	|
	|-RVA: 0x1822900 Offset: 0x1821300 VA: 0x181822900
	|-HashSet<Int32Enum>.AddIfNotPresent
	|
	|-RVA: 0x1822570 Offset: 0x1820F70 VA: 0x181822570
	|-HashSet<InternedString>.AddIfNotPresent
	|
	|-RVA: 0x1822C10 Offset: 0x1821610 VA: 0x181822C10
	|-HashSet<object>.AddIfNotPresent
	|
	|-RVA: 0x1821FE0 Offset: 0x18209E0 VA: 0x181821FE0
	|-HashSet<Scene>.AddIfNotPresent
	|
	|-RVA: 0x1822EE0 Offset: 0x18218E0 VA: 0x181822EE0
	|-HashSet<uint>.AddIfNotPresent
	|
	|-RVA: 0x183B420 Offset: 0x1839E20 VA: 0x18183B420
	|-HashSet<UInt32Enum>.AddIfNotPresent
	|
	|-RVA: 0x183B170 Offset: 0x1839B70 VA: 0x18183B170
	|-HashSet<ulong>.AddIfNotPresent
	|
	|-RVA: 0x183C040 Offset: 0x183AA40 VA: 0x18183C040
	|-HashSet<Vector2Int>.AddIfNotPresent
	|
	|-RVA: 0x183B6E0 Offset: 0x183A0E0 VA: 0x18183B6E0
	|-HashSet<Vector3Int>.AddIfNotPresent
	|
	|-RVA: 0x183BA70 Offset: 0x183A470 VA: 0x18183BA70
	|-HashSet<__Il2CppFullySharedGenericType>.AddIfNotPresent
	*/

	// RVA: -1 Offset: -1
	private void AddValue(int index, int hashCode, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181DC80 Offset: 0x181C680 VA: 0x18181DC80
	|-HashSet<ValueTuple<int, object>>.AddValue
	|
	|-RVA: 0x1823280 Offset: 0x1821C80 VA: 0x181823280
	|-HashSet<bool>.AddValue
	|
	|-RVA: 0x1823340 Offset: 0x1821D40 VA: 0x181823340
	|-HashSet<int>.AddValue
	|-HashSet<Int32Enum>.AddValue
	|-HashSet<Scene>.AddValue
	|-HashSet<uint>.AddValue
	|-HashSet<UInt32Enum>.AddValue
	|
	|-RVA: 0x1823400 Offset: 0x1821E00 VA: 0x181823400
	|-HashSet<InternedString>.AddValue
	|
	|-RVA: 0x18231A0 Offset: 0x1821BA0 VA: 0x1818231A0
	|-HashSet<object>.AddValue
	|
	|-RVA: 0x183C530 Offset: 0x183AF30 VA: 0x18183C530
	|-HashSet<ulong>.AddValue
	|-HashSet<Vector2Int>.AddValue
	|
	|-RVA: 0x183C5E0 Offset: 0x183AFE0 VA: 0x18183C5E0
	|-HashSet<Vector3Int>.AddValue
	|
	|-RVA: 0x183C300 Offset: 0x183AD00 VA: 0x18183C300
	|-HashSet<__Il2CppFullySharedGenericType>.AddValue
	*/

	// RVA: -1 Offset: -1
	private bool ContainsAllElements(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181E320 Offset: 0x181CD20 VA: 0x18181E320
	|-HashSet<ValueTuple<int, object>>.ContainsAllElements
	|
	|-RVA: 0x1825DF0 Offset: 0x18247F0 VA: 0x181825DF0
	|-HashSet<bool>.ContainsAllElements
	|
	|-RVA: 0x1825A90 Offset: 0x1824490 VA: 0x181825A90
	|-HashSet<int>.ContainsAllElements
	|
	|-RVA: 0x1825FB0 Offset: 0x18249B0 VA: 0x181825FB0
	|-HashSet<Int32Enum>.ContainsAllElements
	|
	|-RVA: 0x18256A0 Offset: 0x18240A0 VA: 0x1818256A0
	|-HashSet<InternedString>.ContainsAllElements
	|
	|-RVA: 0x18258D0 Offset: 0x18242D0 VA: 0x1818258D0
	|-HashSet<object>.ContainsAllElements
	|
	|-RVA: 0x1825C40 Offset: 0x1824640 VA: 0x181825C40
	|-HashSet<Scene>.ContainsAllElements
	|
	|-RVA: 0x18254F0 Offset: 0x1823EF0 VA: 0x1818254F0
	|-HashSet<uint>.ContainsAllElements
	|
	|-RVA: 0x183E490 Offset: 0x183CE90 VA: 0x18183E490
	|-HashSet<UInt32Enum>.ContainsAllElements
	|
	|-RVA: 0x183E640 Offset: 0x183D040 VA: 0x18183E640
	|-HashSet<ulong>.ContainsAllElements
	|
	|-RVA: 0x183E2D0 Offset: 0x183CCD0 VA: 0x18183E2D0
	|-HashSet<Vector2Int>.ContainsAllElements
	|
	|-RVA: 0x183E800 Offset: 0x183D200 VA: 0x18183E800
	|-HashSet<Vector3Int>.ContainsAllElements
	|
	|-RVA: 0x183EA40 Offset: 0x183D440 VA: 0x18183EA40
	|-HashSet<__Il2CppFullySharedGenericType>.ContainsAllElements
	*/

	// RVA: -1 Offset: -1
	private bool IsSubsetOfHashSetWithSameEC(HashSet<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181F9C0 Offset: 0x181E3C0 VA: 0x18181F9C0
	|-HashSet<ValueTuple<int, object>>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x182D510 Offset: 0x182BF10 VA: 0x18182D510
	|-HashSet<bool>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x182D830 Offset: 0x182C230 VA: 0x18182D830
	|-HashSet<int>.IsSubsetOfHashSetWithSameEC
	|-HashSet<Int32Enum>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x182D9C0 Offset: 0x182C3C0 VA: 0x18182D9C0
	|-HashSet<InternedString>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x182DB50 Offset: 0x182C550 VA: 0x18182DB50
	|-HashSet<object>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x182DCE0 Offset: 0x182C6E0 VA: 0x18182DCE0
	|-HashSet<Scene>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x182D6A0 Offset: 0x182C0A0 VA: 0x18182D6A0
	|-HashSet<uint>.IsSubsetOfHashSetWithSameEC
	|-HashSet<UInt32Enum>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x1844A50 Offset: 0x1843450 VA: 0x181844A50
	|-HashSet<ulong>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x18448C0 Offset: 0x18432C0 VA: 0x1818448C0
	|-HashSet<Vector2Int>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x1844F00 Offset: 0x1843900 VA: 0x181844F00
	|-HashSet<Vector3Int>.IsSubsetOfHashSetWithSameEC
	|
	|-RVA: 0x1844BE0 Offset: 0x18435E0 VA: 0x181844BE0
	|-HashSet<__Il2CppFullySharedGenericType>.IsSubsetOfHashSetWithSameEC
	*/

	// RVA: -1 Offset: -1
	private int InternalIndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181F340 Offset: 0x181DD40 VA: 0x18181F340
	|-HashSet<ValueTuple<int, object>>.InternalIndexOf
	|-HashSet<InternedString>.InternalIndexOf
	|
	|-RVA: 0x182B3E0 Offset: 0x1829DE0 VA: 0x18182B3E0
	|-HashSet<bool>.InternalIndexOf
	|
	|-RVA: 0x182B080 Offset: 0x1829A80 VA: 0x18182B080
	|-HashSet<int>.InternalIndexOf
	|-HashSet<Int32Enum>.InternalIndexOf
	|
	|-RVA: 0x182AF00 Offset: 0x1829900 VA: 0x18182AF00
	|-HashSet<object>.InternalIndexOf
	|
	|-RVA: 0x182B250 Offset: 0x1829C50 VA: 0x18182B250
	|-HashSet<Scene>.InternalIndexOf
	|
	|-RVA: 0x182B560 Offset: 0x1829F60 VA: 0x18182B560
	|-HashSet<uint>.InternalIndexOf
	|-HashSet<UInt32Enum>.InternalIndexOf
	|
	|-RVA: 0x1842FB0 Offset: 0x18419B0 VA: 0x181842FB0
	|-HashSet<ulong>.InternalIndexOf
	|
	|-RVA: 0x1842E20 Offset: 0x1841820 VA: 0x181842E20
	|-HashSet<Vector2Int>.InternalIndexOf
	|
	|-RVA: 0x1843130 Offset: 0x1841B30 VA: 0x181843130
	|-HashSet<Vector3Int>.InternalIndexOf
	|
	|-RVA: 0x1842AD0 Offset: 0x18414D0 VA: 0x181842AD0
	|-HashSet<__Il2CppFullySharedGenericType>.InternalIndexOf
	*/

	// RVA: -1 Offset: -1
	private HashSet.ElementCount<T> CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181DE10 Offset: 0x181C810 VA: 0x18181DE10
	|-HashSet<ValueTuple<int, object>>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1824660 Offset: 0x1823060 VA: 0x181824660
	|-HashSet<bool>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x18235E0 Offset: 0x1821FE0 VA: 0x1818235E0
	|-HashSet<int>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1824240 Offset: 0x1822C40 VA: 0x181824240
	|-HashSet<Int32Enum>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1825040 Offset: 0x1823A40 VA: 0x181825040
	|-HashSet<InternedString>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1824A80 Offset: 0x1823480 VA: 0x181824A80
	|-HashSet<object>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1823E20 Offset: 0x1822820 VA: 0x181823E20
	|-HashSet<Scene>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x1823A00 Offset: 0x1822400 VA: 0x181823A00
	|-HashSet<uint>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x183DEB0 Offset: 0x183C8B0 VA: 0x18183DEB0
	|-HashSet<UInt32Enum>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x183CF10 Offset: 0x183B910 VA: 0x18183CF10
	|-HashSet<ulong>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x183C950 Offset: 0x183B350 VA: 0x18183C950
	|-HashSet<Vector2Int>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x183D4D0 Offset: 0x183BED0 VA: 0x18183D4D0
	|-HashSet<Vector3Int>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x183D990 Offset: 0x183C390 VA: 0x18183D990
	|-HashSet<__Il2CppFullySharedGenericType>.CheckUniqueAndUnfoundElements
	*/

	// RVA: -1 Offset: -1
	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181DD90 Offset: 0x181C790 VA: 0x18181DD90
	|-HashSet<ValueTuple<int, object>>.AreEqualityComparersEqual
	|-HashSet<bool>.AreEqualityComparersEqual
	|-HashSet<int>.AreEqualityComparersEqual
	|-HashSet<Int32Enum>.AreEqualityComparersEqual
	|-HashSet<InternedString>.AreEqualityComparersEqual
	|-HashSet<object>.AreEqualityComparersEqual
	|-HashSet<Scene>.AreEqualityComparersEqual
	|-HashSet<uint>.AreEqualityComparersEqual
	|-HashSet<UInt32Enum>.AreEqualityComparersEqual
	|-HashSet<ulong>.AreEqualityComparersEqual
	|-HashSet<Vector2Int>.AreEqualityComparersEqual
	|-HashSet<Vector3Int>.AreEqualityComparersEqual
	|
	|-RVA: 0x183C840 Offset: 0x183B240 VA: 0x18183C840
	|-HashSet<__Il2CppFullySharedGenericType>.AreEqualityComparersEqual
	*/

	// RVA: -1 Offset: -1
	private int InternalGetHashCode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181F270 Offset: 0x181DC70 VA: 0x18181F270
	|-HashSet<ValueTuple<int, object>>.InternalGetHashCode
	|-HashSet<InternedString>.InternalGetHashCode
	|
	|-RVA: 0x182AC30 Offset: 0x1829630 VA: 0x18182AC30
	|-HashSet<bool>.InternalGetHashCode
	|
	|-RVA: 0x182AD00 Offset: 0x1829700 VA: 0x18182AD00
	|-HashSet<int>.InternalGetHashCode
	|-HashSet<Int32Enum>.InternalGetHashCode
	|
	|-RVA: 0x182AB60 Offset: 0x1829560 VA: 0x18182AB60
	|-HashSet<object>.InternalGetHashCode
	|
	|-RVA: 0x182AD60 Offset: 0x1829760 VA: 0x18182AD60
	|-HashSet<Scene>.InternalGetHashCode
	|
	|-RVA: 0x182AE30 Offset: 0x1829830 VA: 0x18182AE30
	|-HashSet<uint>.InternalGetHashCode
	|-HashSet<UInt32Enum>.InternalGetHashCode
	|
	|-RVA: 0x1842920 Offset: 0x1841320 VA: 0x181842920
	|-HashSet<ulong>.InternalGetHashCode
	|
	|-RVA: 0x1842850 Offset: 0x1841250 VA: 0x181842850
	|-HashSet<Vector2Int>.InternalGetHashCode
	|
	|-RVA: 0x18429F0 Offset: 0x18413F0 VA: 0x1818429F0
	|-HashSet<Vector3Int>.InternalGetHashCode
	|
	|-RVA: 0x1842670 Offset: 0x1841070 VA: 0x181842670
	|-HashSet<__Il2CppFullySharedGenericType>.InternalGetHashCode
	*/
}
