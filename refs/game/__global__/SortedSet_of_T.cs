public class SortedSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 9906
{
	// Fields
	private SortedSet.Node<T> root; // 0x0
	private IComparer<T> comparer; // 0x0
	private int count; // 0x0
	private int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo siInfo; // 0x0

	// Properties
	public int Count { get; }
	public IComparer<T> Comparer { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public T Min { get; }
	internal virtual T MinInternal { get; }
	public T Max { get; }
	internal virtual T MaxInternal { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DCAB0 Offset: 0x11DB4B0 VA: 0x1811DCAB0
	|-SortedSet<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0x11DC940 Offset: 0x11DB340 VA: 0x1811DC940
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DCA40 Offset: 0x11DB440 VA: 0x1811DCA40
	|-SortedSet<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0x11DC990 Offset: 0x11DB390 VA: 0x1811DC990
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DCA00 Offset: 0x11DB400 VA: 0x1811DCA00
	|-SortedSet<KeyValuePair<object, char>>..ctor
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private bool ContainsAllElements(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D4530 Offset: 0x11D2F30 VA: 0x1811D4530
	|-SortedSet<KeyValuePair<object, char>>.ContainsAllElements
	|
	|-RVA: 0x11D4760 Offset: 0x11D3160 VA: 0x1811D4760
	|-SortedSet<__Il2CppFullySharedGenericType>.ContainsAllElements
	*/

	// RVA: -1 Offset: -1 Slot: 27
	internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D7170 Offset: 0x11D5B70 VA: 0x1811D7170
	|-SortedSet<KeyValuePair<object, char>>.InOrderTreeWalk
	|
	|-RVA: 0x11D6EF0 Offset: 0x11D58F0 VA: 0x1811D6EF0
	|-SortedSet<__Il2CppFullySharedGenericType>.InOrderTreeWalk
	*/

	// RVA: -1 Offset: -1 Slot: 28
	internal virtual bool BreadthFirstTreeWalk(TreeWalkPredicate<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D3780 Offset: 0x11D2180 VA: 0x1811D3780
	|-SortedSet<KeyValuePair<object, char>>.BreadthFirstTreeWalk
	|
	|-RVA: 0x11D38D0 Offset: 0x11D22D0 VA: 0x1811D38D0
	|-SortedSet<__Il2CppFullySharedGenericType>.BreadthFirstTreeWalk
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DCB00 Offset: 0x11DB500 VA: 0x1811DCB00
	|-SortedSet<KeyValuePair<object, char>>.get_Count
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public IComparer<T> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-SortedSet<KeyValuePair<object, char>>.get_Comparer
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Comparer
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.ICollection.get_IsSynchronized
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DC810 Offset: 0x11DB210 VA: 0x1811DC810
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11DC880 Offset: 0x11DB280 VA: 0x1811DC880
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	internal virtual void VersionCheck() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-SortedSet<KeyValuePair<object, char>>.VersionCheck
	|-SortedSet<__Il2CppFullySharedGenericType>.VersionCheck
	*/

	// RVA: -1 Offset: -1 Slot: 30
	internal virtual bool IsWithinRange(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-SortedSet<KeyValuePair<object, char>>.IsWithinRange
	|-SortedSet<__Il2CppFullySharedGenericType>.IsWithinRange
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D3670 Offset: 0x11D2070 VA: 0x1811D3670
	|-SortedSet<KeyValuePair<object, char>>.Add
	|
	|-RVA: 0x11D36A0 Offset: 0x11D20A0 VA: 0x1811D36A0
	|-SortedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D3670 Offset: 0x11D2070 VA: 0x1811D3670
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x11DBD50 Offset: 0x11DA750 VA: 0x1811DBD50
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 31
	internal virtual bool AddIfNotPresent(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D3070 Offset: 0x11D1A70 VA: 0x1811D3070
	|-SortedSet<KeyValuePair<object, char>>.AddIfNotPresent
	|
	|-RVA: 0x11D2B50 Offset: 0x11D1550 VA: 0x1811D2B50
	|-SortedSet<__Il2CppFullySharedGenericType>.AddIfNotPresent
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DB030 Offset: 0x11D9A30 VA: 0x1811DB030
	|-SortedSet<KeyValuePair<object, char>>.Remove
	|
	|-RVA: 0x11DAF50 Offset: 0x11D9950 VA: 0x1811DAF50
	|-SortedSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 32
	internal virtual bool DoRemove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D5140 Offset: 0x11D3B40 VA: 0x1811D5140
	|-SortedSet<KeyValuePair<object, char>>.DoRemove
	|
	|-RVA: 0x11D56E0 Offset: 0x11D40E0 VA: 0x1811D56E0
	|-SortedSet<__Il2CppFullySharedGenericType>.DoRemove
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D4500 Offset: 0x11D2F00 VA: 0x1811D4500
	|-SortedSet<KeyValuePair<object, char>>.Clear
	|-SortedSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public virtual bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D4AB0 Offset: 0x11D34B0 VA: 0x1811D4AB0
	|-SortedSet<KeyValuePair<object, char>>.Contains
	|
	|-RVA: 0x11D49C0 Offset: 0x11D33C0 VA: 0x1811D49C0
	|-SortedSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D4E10 Offset: 0x11D3810 VA: 0x1811D4E10
	|-SortedSet<KeyValuePair<object, char>>.CopyTo
	|
	|-RVA: 0x11D4AE0 Offset: 0x11D34E0 VA: 0x1811D4AE0
	|-SortedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D4E90 Offset: 0x11D3890 VA: 0x1811D4E90
	|-SortedSet<KeyValuePair<object, char>>.CopyTo
	|
	|-RVA: 0x11D4B60 Offset: 0x11D3560 VA: 0x1811D4B60
	|-SortedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DC3A0 Offset: 0x11DADA0 VA: 0x1811DC3A0
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11DBF30 Offset: 0x11DA930 VA: 0x1811DBF30
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D6440 Offset: 0x11D4E40 VA: 0x1811D6440
	|-SortedSet<KeyValuePair<object, char>>.GetEnumerator
	|
	|-RVA: 0x11D6480 Offset: 0x11D4E80 VA: 0x1811D6480
	|-SortedSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DBE30 Offset: 0x11DA830 VA: 0x1811DBE30
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x11DBEC0 Offset: 0x11DA8C0 VA: 0x1811DBEC0
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DBE30 Offset: 0x11DA830 VA: 0x1811DBE30
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11DBEC0 Offset: 0x11DA8C0 VA: 0x1811DBEC0
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void InsertionBalance(SortedSet.Node<T> current, ref SortedSet.Node<T> parent, SortedSet.Node<T> grandParent, SortedSet.Node<T> greatGrandParent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D7300 Offset: 0x11D5D00 VA: 0x1811D7300
	|-SortedSet<KeyValuePair<object, char>>.InsertionBalance
	|
	|-RVA: 0x11D7470 Offset: 0x11D5E70 VA: 0x1811D7470
	|-SortedSet<__Il2CppFullySharedGenericType>.InsertionBalance
	*/

	// RVA: -1 Offset: -1
	private void ReplaceChildOrRoot(SortedSet.Node<T> parent, SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DB060 Offset: 0x11D9A60 VA: 0x1811DB060
	|-SortedSet<KeyValuePair<object, char>>.ReplaceChildOrRoot
	|
	|-RVA: 0x11DB0B0 Offset: 0x11D9AB0 VA: 0x1811DB0B0
	|-SortedSet<__Il2CppFullySharedGenericType>.ReplaceChildOrRoot
	*/

	// RVA: -1 Offset: -1
	private void ReplaceNode(SortedSet.Node<T> match, SortedSet.Node<T> parentOfMatch, SortedSet.Node<T> successor, SortedSet.Node<T> parentOfSuccessor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DB310 Offset: 0x11D9D10 VA: 0x1811DB310
	|-SortedSet<KeyValuePair<object, char>>.ReplaceNode
	|
	|-RVA: 0x11DB100 Offset: 0x11D9B00 VA: 0x1811DB100
	|-SortedSet<__Il2CppFullySharedGenericType>.ReplaceNode
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal virtual SortedSet.Node<T> FindNode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D5C60 Offset: 0x11D4660 VA: 0x1811D5C60
	|-SortedSet<KeyValuePair<object, char>>.FindNode
	|
	|-RVA: 0x11D5DA0 Offset: 0x11D47A0 VA: 0x1811D5DA0
	|-SortedSet<__Il2CppFullySharedGenericType>.FindNode
	*/

	// RVA: -1 Offset: -1 Slot: 36
	internal virtual int InternalIndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D7600 Offset: 0x11D6000 VA: 0x1811D7600
	|-SortedSet<KeyValuePair<object, char>>.InternalIndexOf
	|
	|-RVA: 0x11D7760 Offset: 0x11D6160 VA: 0x1811D7760
	|-SortedSet<__Il2CppFullySharedGenericType>.InternalIndexOf
	*/

	// RVA: -1 Offset: -1
	internal SortedSet.Node<T> FindRange(T from, T to, bool lowerBoundActive, bool upperBoundActive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D5F50 Offset: 0x11D4950 VA: 0x1811D5F50
	|-SortedSet<KeyValuePair<object, char>>.FindRange
	|
	|-RVA: 0x11D6180 Offset: 0x11D4B80 VA: 0x1811D6180
	|-SortedSet<__Il2CppFullySharedGenericType>.FindRange
	*/

	// RVA: -1 Offset: -1
	internal void UpdateVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x653CB0 Offset: 0x6526B0 VA: 0x180653CB0
	|-SortedSet<KeyValuePair<object, char>>.UpdateVersion
	|-SortedSet<__Il2CppFullySharedGenericType>.UpdateVersion
	*/

	// RVA: -1 Offset: -1
	private bool HasEqualComparer(SortedSet<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D6EA0 Offset: 0x11D58A0 VA: 0x1811D6EA0
	|-SortedSet<KeyValuePair<object, char>>.HasEqualComparer
	|
	|-RVA: 0x11D6DC0 Offset: 0x11D57C0 VA: 0x1811D6DC0
	|-SortedSet<__Il2CppFullySharedGenericType>.HasEqualComparer
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool IsSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D9030 Offset: 0x11D7A30 VA: 0x1811D9030
	|-SortedSet<KeyValuePair<object, char>>.IsSubsetOf
	|
	|-RVA: 0x11D8E50 Offset: 0x11D7850 VA: 0x1811D8E50
	|-SortedSet<__Il2CppFullySharedGenericType>.IsSubsetOf
	*/

	// RVA: -1 Offset: -1
	private bool IsSubsetOfSortedSetWithSameComparer(SortedSet<T> asSorted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D8BC0 Offset: 0x11D75C0 VA: 0x1811D8BC0
	|-SortedSet<KeyValuePair<object, char>>.IsSubsetOfSortedSetWithSameComparer
	|
	|-RVA: 0x11D8810 Offset: 0x11D7210 VA: 0x1811D8810
	|-SortedSet<__Il2CppFullySharedGenericType>.IsSubsetOfSortedSetWithSameComparer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool IsProperSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D7940 Offset: 0x11D6340 VA: 0x1811D7940
	|-SortedSet<KeyValuePair<object, char>>.IsProperSubsetOf
	|
	|-RVA: 0x11D7B70 Offset: 0x11D6570 VA: 0x1811D7B70
	|-SortedSet<__Il2CppFullySharedGenericType>.IsProperSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool IsSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D9740 Offset: 0x11D8140 VA: 0x1811D9740
	|-SortedSet<KeyValuePair<object, char>>.IsSupersetOf
	|
	|-RVA: 0x11D91F0 Offset: 0x11D7BF0 VA: 0x1811D91F0
	|-SortedSet<__Il2CppFullySharedGenericType>.IsSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool IsProperSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D7DC0 Offset: 0x11D67C0 VA: 0x1811D7DC0
	|-SortedSet<KeyValuePair<object, char>>.IsProperSupersetOf
	|
	|-RVA: 0x11D8250 Offset: 0x11D6C50 VA: 0x1811D8250
	|-SortedSet<__Il2CppFullySharedGenericType>.IsProperSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool SetEquals(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DB440 Offset: 0x11D9E40 VA: 0x1811DB440
	|-SortedSet<KeyValuePair<object, char>>.SetEquals
	|
	|-RVA: 0x11DB890 Offset: 0x11DA290 VA: 0x1811DB890
	|-SortedSet<__Il2CppFullySharedGenericType>.SetEquals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool Overlaps(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DA940 Offset: 0x11D9340 VA: 0x1811DA940
	|-SortedSet<KeyValuePair<object, char>>.Overlaps
	|
	|-RVA: 0x11DA360 Offset: 0x11D8D60 VA: 0x1811DA360
	|-SortedSet<__Il2CppFullySharedGenericType>.Overlaps
	*/

	// RVA: -1 Offset: -1
	private SortedSet.ElementCount<T> CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D3B10 Offset: 0x11D2510 VA: 0x1811D3B10
	|-SortedSet<KeyValuePair<object, char>>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x11D3FE0 Offset: 0x11D29E0 VA: 0x1811D3FE0
	|-SortedSet<__Il2CppFullySharedGenericType>.CheckUniqueAndUnfoundElements
	*/

	// RVA: -1 Offset: -1
	public T get_Min() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DCF60 Offset: 0x11DB960 VA: 0x1811DCF60
	|-SortedSet<KeyValuePair<object, char>>.get_Min
	|
	|-RVA: 0x11DCF90 Offset: 0x11DB990 VA: 0x1811DCF90
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Min
	*/

	// RVA: -1 Offset: -1 Slot: 37
	internal virtual T get_MinInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DCDB0 Offset: 0x11DB7B0 VA: 0x1811DCDB0
	|-SortedSet<KeyValuePair<object, char>>.get_MinInternal
	|
	|-RVA: 0x11DCDF0 Offset: 0x11DB7F0 VA: 0x1811DCDF0
	|-SortedSet<__Il2CppFullySharedGenericType>.get_MinInternal
	*/

	// RVA: -1 Offset: -1
	public T get_Max() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DCCE0 Offset: 0x11DB6E0 VA: 0x1811DCCE0
	|-SortedSet<KeyValuePair<object, char>>.get_Max
	|
	|-RVA: 0x11DCD10 Offset: 0x11DB710 VA: 0x1811DCD10
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Max
	*/

	// RVA: -1 Offset: -1 Slot: 38
	internal virtual T get_MaxInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DCCA0 Offset: 0x11DB6A0 VA: 0x1811DCCA0
	|-SortedSet<KeyValuePair<object, char>>.get_MaxInternal
	|
	|-RVA: 0x11DCB30 Offset: 0x11DB530 VA: 0x1811DCB30
	|-SortedSet<__Il2CppFullySharedGenericType>.get_MaxInternal
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public virtual SortedSet<T> GetViewBetween(T lowerValue, T upperValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D6BF0 Offset: 0x11D55F0 VA: 0x1811D6BF0
	|-SortedSet<KeyValuePair<object, char>>.GetViewBetween
	|
	|-RVA: 0x11D68F0 Offset: 0x11D52F0 VA: 0x1811D68F0
	|-SortedSet<__Il2CppFullySharedGenericType>.GetViewBetween
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DC910 Offset: 0x11DB310 VA: 0x1811DC910
	|-SortedSet<KeyValuePair<object, char>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 40
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D64C0 Offset: 0x11D4EC0 VA: 0x1811D64C0
	|-SortedSet<KeyValuePair<object, char>>.GetObjectData
	|
	|-RVA: 0x11D66D0 Offset: 0x11D50D0 VA: 0x1811D66D0
	|-SortedSet<__Il2CppFullySharedGenericType>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DC8F0 Offset: 0x11DB2F0 VA: 0x1811DC8F0
	|-SortedSet<KeyValuePair<object, char>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 41
	protected virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D9FB0 Offset: 0x11D89B0 VA: 0x1811D9FB0
	|-SortedSet<KeyValuePair<object, char>>.OnDeserialization
	|
	|-RVA: 0x11D9B80 Offset: 0x11D8580 VA: 0x1811D9B80
	|-SortedSet<__Il2CppFullySharedGenericType>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private static int Log2(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D9B70 Offset: 0x11D8570 VA: 0x1811D9B70
	|-SortedSet<KeyValuePair<object, char>>.Log2
	|-SortedSet<__Il2CppFullySharedGenericType>.Log2
	*/
}
