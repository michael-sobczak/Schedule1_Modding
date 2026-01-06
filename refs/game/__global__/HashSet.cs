public struct HashSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 15663
{
	// Fields
	private HashSet<T> _set; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(HashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1666720 Offset: 0x1665120 VA: 0x181666720
	|-HashSet.Enumerator<ValueTuple<int, object>>..ctor
	|-HashSet.Enumerator<InternedString>..ctor
	|
	|-RVA: 0x1666A70 Offset: 0x1665470 VA: 0x181666A70
	|-HashSet.Enumerator<bool>..ctor
	|
	|-RVA: 0x166BC00 Offset: 0x166A600 VA: 0x18166BC00
	|-HashSet.Enumerator<int>..ctor
	|-HashSet.Enumerator<Int32Enum>..ctor
	|-HashSet.Enumerator<Scene>..ctor
	|-HashSet.Enumerator<uint>..ctor
	|-HashSet.Enumerator<UInt32Enum>..ctor
	|
	|-RVA: 0x166BF90 Offset: 0x166A990 VA: 0x18166BF90
	|-HashSet.Enumerator<object>..ctor
	|-HashSet.Enumerator<ulong>..ctor
	|-HashSet.Enumerator<Vector2Int>..ctor
	|
	|-RVA: 0x1670870 Offset: 0x166F270 VA: 0x181670870
	|-HashSet.Enumerator<Vector3Int>..ctor
	|
	|-RVA: 0x1679AE0 Offset: 0x16784E0 VA: 0x181679AE0
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-HashSet.Enumerator<ValueTuple<int, object>>.Dispose
	|-HashSet.Enumerator<bool>.Dispose
	|-HashSet.Enumerator<int>.Dispose
	|-HashSet.Enumerator<Int32Enum>.Dispose
	|-HashSet.Enumerator<InternedString>.Dispose
	|-HashSet.Enumerator<object>.Dispose
	|-HashSet.Enumerator<Scene>.Dispose
	|-HashSet.Enumerator<uint>.Dispose
	|-HashSet.Enumerator<UInt32Enum>.Dispose
	|-HashSet.Enumerator<ulong>.Dispose
	|-HashSet.Enumerator<Vector2Int>.Dispose
	|-HashSet.Enumerator<Vector3Int>.Dispose
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1662150 Offset: 0x1660B50 VA: 0x181662150
	|-HashSet.Enumerator<ValueTuple<int, object>>.MoveNext
	|
	|-RVA: 0x1662950 Offset: 0x1661350 VA: 0x181662950
	|-HashSet.Enumerator<bool>.MoveNext
	|
	|-RVA: 0x1667920 Offset: 0x1666320 VA: 0x181667920
	|-HashSet.Enumerator<int>.MoveNext
	|-HashSet.Enumerator<Int32Enum>.MoveNext
	|-HashSet.Enumerator<Scene>.MoveNext
	|-HashSet.Enumerator<uint>.MoveNext
	|-HashSet.Enumerator<UInt32Enum>.MoveNext
	|
	|-RVA: 0x1669080 Offset: 0x1667A80 VA: 0x181669080
	|-HashSet.Enumerator<InternedString>.MoveNext
	|
	|-RVA: 0x1667CD0 Offset: 0x16666D0 VA: 0x181667CD0
	|-HashSet.Enumerator<object>.MoveNext
	|
	|-RVA: 0x166D9B0 Offset: 0x166C3B0 VA: 0x18166D9B0
	|-HashSet.Enumerator<ulong>.MoveNext
	|-HashSet.Enumerator<Vector2Int>.MoveNext
	|
	|-RVA: 0x166E050 Offset: 0x166CA50 VA: 0x18166E050
	|-HashSet.Enumerator<Vector3Int>.MoveNext
	|
	|-RVA: 0x1672670 Offset: 0x1671070 VA: 0x181672670
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	|-HashSet.Enumerator<ValueTuple<int, object>>.get_Current
	|-HashSet.Enumerator<InternedString>.get_Current
	|
	|-RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	|-HashSet.Enumerator<bool>.get_Current
	|
	|-RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	|-HashSet.Enumerator<int>.get_Current
	|-HashSet.Enumerator<Int32Enum>.get_Current
	|-HashSet.Enumerator<Scene>.get_Current
	|-HashSet.Enumerator<uint>.get_Current
	|-HashSet.Enumerator<UInt32Enum>.get_Current
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-HashSet.Enumerator<object>.get_Current
	|-HashSet.Enumerator<ulong>.get_Current
	|-HashSet.Enumerator<Vector2Int>.get_Current
	|
	|-RVA: 0x9B6540 Offset: 0x9B4F40 VA: 0x1809B6540
	|-HashSet.Enumerator<Vector3Int>.get_Current
	|
	|-RVA: 0x167B650 Offset: 0x167A050 VA: 0x18167B650
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1665900 Offset: 0x1664300 VA: 0x181665900
	|-HashSet.Enumerator<ValueTuple<int, object>>.System.Collections.IEnumerator.get_Current
	|-HashSet.Enumerator<InternedString>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1665330 Offset: 0x1663D30 VA: 0x181665330
	|-HashSet.Enumerator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1669F90 Offset: 0x1668990 VA: 0x181669F90
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|-HashSet.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-HashSet.Enumerator<Scene>.System.Collections.IEnumerator.get_Current
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|-HashSet.Enumerator<UInt32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166A1D0 Offset: 0x1668BD0 VA: 0x18166A1D0
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166F970 Offset: 0x166E370 VA: 0x18166F970
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|-HashSet.Enumerator<Vector2Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166F110 Offset: 0x166DB10 VA: 0x18166F110
	|-HashSet.Enumerator<Vector3Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x16782F0 Offset: 0x1676CF0 VA: 0x1816782F0
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1664280 Offset: 0x1662C80 VA: 0x181664280
	|-HashSet.Enumerator<ValueTuple<int, object>>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<InternedString>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1664160 Offset: 0x1662B60 VA: 0x181664160
	|-HashSet.Enumerator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1669AD0 Offset: 0x16684D0 VA: 0x181669AD0
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<Scene>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<UInt32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x16695E0 Offset: 0x1667FE0 VA: 0x1816695E0
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|-HashSet.Enumerator<Vector2Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x166EB20 Offset: 0x166D520 VA: 0x18166EB20
	|-HashSet.Enumerator<Vector3Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x16766C0 Offset: 0x16750C0 VA: 0x1816766C0
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}
