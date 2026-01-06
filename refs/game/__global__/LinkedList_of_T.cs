public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 9877
{
	// Fields
	internal LinkedListNode<T> head; // 0x0
	internal int count; // 0x0
	internal int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo _siInfo; // 0x0

	// Properties
	public int Count { get; }
	public LinkedListNode<T> First { get; }
	public LinkedListNode<T> Last { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	|-LinkedList<ValueTuple<object, object>>..ctor
	|-LinkedList<ValueTuple<object, object, object>>..ctor
	|-LinkedList<BezierSegment>..ctor
	|-LinkedList<object>..ctor
	|-LinkedList<__Il2CppFullySharedGenericType>..ctor
	|-LinkedList<UIRenderDevice.DeviceToFree>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DFFB0 Offset: 0x18DE9B0 VA: 0x1818DFFB0
	|-LinkedList<ValueTuple<object, object>>..ctor
	|-LinkedList<ValueTuple<object, object, object>>..ctor
	|-LinkedList<BezierSegment>..ctor
	|-LinkedList<object>..ctor
	|-LinkedList<__Il2CppFullySharedGenericType>..ctor
	|-LinkedList<UIRenderDevice.DeviceToFree>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	|-LinkedList<ValueTuple<object, object>>.get_Count
	|-LinkedList<ValueTuple<object, object, object>>.get_Count
	|-LinkedList<BezierSegment>.get_Count
	|-LinkedList<object>.get_Count
	|-LinkedList<__Il2CppFullySharedGenericType>.get_Count
	|-LinkedList<UIRenderDevice.DeviceToFree>.get_Count
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-LinkedList<ValueTuple<object, object>>.get_First
	|-LinkedList<ValueTuple<object, object, object>>.get_First
	|-LinkedList<BezierSegment>.get_First
	|-LinkedList<object>.get_First
	|-LinkedList<__Il2CppFullySharedGenericType>.get_First
	|-LinkedList<UIRenderDevice.DeviceToFree>.get_First
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_Last() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DFFF0 Offset: 0x18DE9F0 VA: 0x1818DFFF0
	|-LinkedList<ValueTuple<object, object>>.get_Last
	|-LinkedList<ValueTuple<object, object, object>>.get_Last
	|-LinkedList<BezierSegment>.get_Last
	|-LinkedList<object>.get_Last
	|-LinkedList<UIRenderDevice.DeviceToFree>.get_Last
	|
	|-RVA: 0x18E0010 Offset: 0x18DEA10 VA: 0x1818E0010
	|-LinkedList<__Il2CppFullySharedGenericType>.get_Last
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-LinkedList<BezierSegment>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-LinkedList<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DDDE0 Offset: 0x18DC7E0 VA: 0x1818DDDE0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x18DDC30 Offset: 0x18DC630 VA: 0x1818DDC30
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x18DDC70 Offset: 0x18DC670 VA: 0x1818DDC70
	|-LinkedList<BezierSegment>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x18DDCB0 Offset: 0x18DC6B0 VA: 0x1818DDCB0
	|-LinkedList<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x18DDD00 Offset: 0x18DC700 VA: 0x1818DDD00
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x18DDCD0 Offset: 0x18DC6D0 VA: 0x1818DDCD0
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddFirst(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D8620 Offset: 0x18D7020 VA: 0x1818D8620
	|-LinkedList<ValueTuple<object, object>>.AddFirst
	|
	|-RVA: 0x18D8760 Offset: 0x18D7160 VA: 0x1818D8760
	|-LinkedList<ValueTuple<object, object, object>>.AddFirst
	|
	|-RVA: 0x18D8B30 Offset: 0x18D7530 VA: 0x1818D8B30
	|-LinkedList<BezierSegment>.AddFirst
	|
	|-RVA: 0x18D88A0 Offset: 0x18D72A0 VA: 0x1818D88A0
	|-LinkedList<object>.AddFirst
	|
	|-RVA: 0x18D89D0 Offset: 0x18D73D0 VA: 0x1818D89D0
	|-LinkedList<__Il2CppFullySharedGenericType>.AddFirst
	|
	|-RVA: 0x18D8C60 Offset: 0x18D7660 VA: 0x1818D8C60
	|-LinkedList<UIRenderDevice.DeviceToFree>.AddFirst
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddLast(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D9320 Offset: 0x18D7D20 VA: 0x1818D9320
	|-LinkedList<ValueTuple<object, object>>.AddLast
	|
	|-RVA: 0x18D90F0 Offset: 0x18D7AF0 VA: 0x1818D90F0
	|-LinkedList<ValueTuple<object, object, object>>.AddLast
	|
	|-RVA: 0x18D8FE0 Offset: 0x18D79E0 VA: 0x1818D8FE0
	|-LinkedList<BezierSegment>.AddLast
	|
	|-RVA: 0x18D9430 Offset: 0x18D7E30 VA: 0x1818D9430
	|-LinkedList<object>.AddLast
	|
	|-RVA: 0x18D9540 Offset: 0x18D7F40 VA: 0x1818D9540
	|-LinkedList<__Il2CppFullySharedGenericType>.AddLast
	|
	|-RVA: 0x18D9210 Offset: 0x18D7C10 VA: 0x1818D9210
	|-LinkedList<UIRenderDevice.DeviceToFree>.AddLast
	*/

	// RVA: -1 Offset: -1
	public void AddLast(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D8DA0 Offset: 0x18D77A0 VA: 0x1818D8DA0
	|-LinkedList<ValueTuple<object, object>>.AddLast
	|-LinkedList<ValueTuple<object, object, object>>.AddLast
	|-LinkedList<BezierSegment>.AddLast
	|-LinkedList<object>.AddLast
	|-LinkedList<UIRenderDevice.DeviceToFree>.AddLast
	|
	|-RVA: 0x18D8F10 Offset: 0x18D7910 VA: 0x1818D8F10
	|-LinkedList<__Il2CppFullySharedGenericType>.AddLast
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D9690 Offset: 0x18D8090 VA: 0x1818D9690
	|-LinkedList<ValueTuple<object, object>>.Clear
	|-LinkedList<ValueTuple<object, object, object>>.Clear
	|-LinkedList<BezierSegment>.Clear
	|-LinkedList<object>.Clear
	|-LinkedList<UIRenderDevice.DeviceToFree>.Clear
	|
	|-RVA: 0x18D9740 Offset: 0x18D8140 VA: 0x1818D9740
	|-LinkedList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D97D0 Offset: 0x18D81D0 VA: 0x1818D97D0
	|-LinkedList<ValueTuple<object, object>>.Contains
	|
	|-RVA: 0x18D9950 Offset: 0x18D8350 VA: 0x1818D9950
	|-LinkedList<ValueTuple<object, object, object>>.Contains
	|
	|-RVA: 0x18D9910 Offset: 0x18D8310 VA: 0x1818D9910
	|-LinkedList<BezierSegment>.Contains
	|
	|-RVA: 0x18D9990 Offset: 0x18D8390 VA: 0x1818D9990
	|-LinkedList<object>.Contains
	|
	|-RVA: 0x18D9830 Offset: 0x18D8230 VA: 0x1818D9830
	|-LinkedList<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x18D9800 Offset: 0x18D8200 VA: 0x1818D9800
	|-LinkedList<UIRenderDevice.DeviceToFree>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D9E20 Offset: 0x18D8820 VA: 0x1818D9E20
	|-LinkedList<ValueTuple<object, object>>.CopyTo
	|
	|-RVA: 0x18D9BF0 Offset: 0x18D85F0 VA: 0x1818D9BF0
	|-LinkedList<ValueTuple<object, object, object>>.CopyTo
	|
	|-RVA: 0x18D99C0 Offset: 0x18D83C0 VA: 0x1818D99C0
	|-LinkedList<BezierSegment>.CopyTo
	|
	|-RVA: 0x18DA050 Offset: 0x18D8A50 VA: 0x1818DA050
	|-LinkedList<object>.CopyTo
	|
	|-RVA: 0x18DA260 Offset: 0x18D8C60 VA: 0x1818DA260
	|-LinkedList<__Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x18DA580 Offset: 0x18D8F80 VA: 0x1818DA580
	|-LinkedList<UIRenderDevice.DeviceToFree>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> Find(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DAF70 Offset: 0x18D9970 VA: 0x1818DAF70
	|-LinkedList<ValueTuple<object, object>>.Find
	|
	|-RVA: 0x18DAA40 Offset: 0x18D9440 VA: 0x1818DAA40
	|-LinkedList<ValueTuple<object, object, object>>.Find
	|
	|-RVA: 0x18DAC00 Offset: 0x18D9600 VA: 0x1818DAC00
	|-LinkedList<BezierSegment>.Find
	|
	|-RVA: 0x18DB120 Offset: 0x18D9B20 VA: 0x1818DB120
	|-LinkedList<object>.Find
	|
	|-RVA: 0x18DA7B0 Offset: 0x18D91B0 VA: 0x1818DA7B0
	|-LinkedList<__Il2CppFullySharedGenericType>.Find
	|
	|-RVA: 0x18DADC0 Offset: 0x18D97C0 VA: 0x1818DADC0
	|-LinkedList<UIRenderDevice.DeviceToFree>.Find
	*/

	// RVA: -1 Offset: -1
	public LinkedList.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DB380 Offset: 0x18D9D80 VA: 0x1818DB380
	|-LinkedList<ValueTuple<object, object>>.GetEnumerator
	|-LinkedList<UIRenderDevice.DeviceToFree>.GetEnumerator
	|
	|-RVA: 0x18DB400 Offset: 0x18D9E00 VA: 0x1818DB400
	|-LinkedList<ValueTuple<object, object, object>>.GetEnumerator
	|
	|-RVA: 0x18DB440 Offset: 0x18D9E40 VA: 0x1818DB440
	|-LinkedList<BezierSegment>.GetEnumerator
	|
	|-RVA: 0x18DB3C0 Offset: 0x18D9DC0 VA: 0x1818DB3C0
	|-LinkedList<object>.GetEnumerator
	|
	|-RVA: 0x18DB2D0 Offset: 0x18D9CD0 VA: 0x1818DB2D0
	|-LinkedList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DDE10 Offset: 0x18DC810 VA: 0x1818DDE10
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x18DE010 Offset: 0x18DCA10 VA: 0x1818DE010
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x18DDF60 Offset: 0x18DC960 VA: 0x1818DDF60
	|-LinkedList<BezierSegment>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x18DE0C0 Offset: 0x18DCAC0 VA: 0x1818DE0C0
	|-LinkedList<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x18DDEB0 Offset: 0x18DC8B0 VA: 0x1818DDEB0
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DD820 Offset: 0x18DC220 VA: 0x1818DD820
	|-LinkedList<ValueTuple<object, object>>.Remove
	|
	|-RVA: 0x18DDBB0 Offset: 0x18DC5B0 VA: 0x1818DDBB0
	|-LinkedList<ValueTuple<object, object, object>>.Remove
	|
	|-RVA: 0x18DD950 Offset: 0x18DC350 VA: 0x1818DD950
	|-LinkedList<BezierSegment>.Remove
	|
	|-RVA: 0x18DD9D0 Offset: 0x18DC3D0 VA: 0x1818DD9D0
	|-LinkedList<object>.Remove
	|
	|-RVA: 0x18DDA30 Offset: 0x18DC430 VA: 0x1818DDA30
	|-LinkedList<__Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0x18DDB40 Offset: 0x18DC540 VA: 0x1818DDB40
	|-LinkedList<UIRenderDevice.DeviceToFree>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Remove(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DD890 Offset: 0x18DC290 VA: 0x1818DD890
	|-LinkedList<ValueTuple<object, object>>.Remove
	|-LinkedList<ValueTuple<object, object, object>>.Remove
	|-LinkedList<BezierSegment>.Remove
	|-LinkedList<object>.Remove
	|-LinkedList<UIRenderDevice.DeviceToFree>.Remove
	|
	|-RVA: 0x18DD7C0 Offset: 0x18DC1C0 VA: 0x1818DD7C0
	|-LinkedList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveFirst() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DD6C0 Offset: 0x18DC0C0 VA: 0x1818DD6C0
	|-LinkedList<ValueTuple<object, object>>.RemoveFirst
	|-LinkedList<ValueTuple<object, object, object>>.RemoveFirst
	|-LinkedList<BezierSegment>.RemoveFirst
	|-LinkedList<object>.RemoveFirst
	|-LinkedList<UIRenderDevice.DeviceToFree>.RemoveFirst
	|
	|-RVA: 0x18DD740 Offset: 0x18DC140 VA: 0x1818DD740
	|-LinkedList<__Il2CppFullySharedGenericType>.RemoveFirst
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DB7A0 Offset: 0x18DA1A0 VA: 0x1818DB7A0
	|-LinkedList<ValueTuple<object, object>>.GetObjectData
	|
	|-RVA: 0x18DBAC0 Offset: 0x18DA4C0 VA: 0x1818DBAC0
	|-LinkedList<ValueTuple<object, object, object>>.GetObjectData
	|
	|-RVA: 0x18DB610 Offset: 0x18DA010 VA: 0x1818DB610
	|-LinkedList<BezierSegment>.GetObjectData
	|
	|-RVA: 0x18DB480 Offset: 0x18D9E80 VA: 0x1818DB480
	|-LinkedList<object>.GetObjectData
	|
	|-RVA: 0x18DBC50 Offset: 0x18DA650 VA: 0x1818DBC50
	|-LinkedList<__Il2CppFullySharedGenericType>.GetObjectData
	|
	|-RVA: 0x18DB930 Offset: 0x18DA330 VA: 0x1818DB930
	|-LinkedList<UIRenderDevice.DeviceToFree>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DCAA0 Offset: 0x18DB4A0 VA: 0x1818DCAA0
	|-LinkedList<ValueTuple<object, object>>.OnDeserialization
	|
	|-RVA: 0x18DD380 Offset: 0x18DBD80 VA: 0x1818DD380
	|-LinkedList<ValueTuple<object, object, object>>.OnDeserialization
	|
	|-RVA: 0x18DC450 Offset: 0x18DAE50 VA: 0x1818DC450
	|-LinkedList<BezierSegment>.OnDeserialization
	|
	|-RVA: 0x18DD060 Offset: 0x18DBA60 VA: 0x1818DD060
	|-LinkedList<object>.OnDeserialization
	|
	|-RVA: 0x18DCDC0 Offset: 0x18DB7C0 VA: 0x1818DCDC0
	|-LinkedList<__Il2CppFullySharedGenericType>.OnDeserialization
	|
	|-RVA: 0x18DC780 Offset: 0x18DB180 VA: 0x1818DC780
	|-LinkedList<UIRenderDevice.DeviceToFree>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DBFB0 Offset: 0x18DA9B0 VA: 0x1818DBFB0
	|-LinkedList<ValueTuple<object, object>>.InternalInsertNodeBefore
	|-LinkedList<ValueTuple<object, object, object>>.InternalInsertNodeBefore
	|-LinkedList<BezierSegment>.InternalInsertNodeBefore
	|-LinkedList<object>.InternalInsertNodeBefore
	|-LinkedList<UIRenderDevice.DeviceToFree>.InternalInsertNodeBefore
	|
	|-RVA: 0x18DBDF0 Offset: 0x18DA7F0 VA: 0x1818DBDF0
	|-LinkedList<__Il2CppFullySharedGenericType>.InternalInsertNodeBefore
	*/

	// RVA: -1 Offset: -1
	private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DC040 Offset: 0x18DAA40 VA: 0x1818DC040
	|-LinkedList<ValueTuple<object, object>>.InternalInsertNodeToEmptyList
	|-LinkedList<ValueTuple<object, object, object>>.InternalInsertNodeToEmptyList
	|-LinkedList<BezierSegment>.InternalInsertNodeToEmptyList
	|-LinkedList<object>.InternalInsertNodeToEmptyList
	|-LinkedList<UIRenderDevice.DeviceToFree>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x18DC0A0 Offset: 0x18DAAA0 VA: 0x1818DC0A0
	|-LinkedList<__Il2CppFullySharedGenericType>.InternalInsertNodeToEmptyList
	*/

	// RVA: -1 Offset: -1
	internal void InternalRemoveNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DC180 Offset: 0x18DAB80 VA: 0x1818DC180
	|-LinkedList<ValueTuple<object, object>>.InternalRemoveNode
	|-LinkedList<ValueTuple<object, object, object>>.InternalRemoveNode
	|-LinkedList<BezierSegment>.InternalRemoveNode
	|-LinkedList<object>.InternalRemoveNode
	|-LinkedList<UIRenderDevice.DeviceToFree>.InternalRemoveNode
	|
	|-RVA: 0x18DC250 Offset: 0x18DAC50 VA: 0x1818DC250
	|-LinkedList<__Il2CppFullySharedGenericType>.InternalRemoveNode
	*/

	// RVA: -1 Offset: -1
	internal void ValidateNewNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DFCF0 Offset: 0x18DE6F0 VA: 0x1818DFCF0
	|-LinkedList<ValueTuple<object, object>>.ValidateNewNode
	|-LinkedList<ValueTuple<object, object, object>>.ValidateNewNode
	|-LinkedList<BezierSegment>.ValidateNewNode
	|-LinkedList<object>.ValidateNewNode
	|-LinkedList<UIRenderDevice.DeviceToFree>.ValidateNewNode
	|
	|-RVA: 0x18DFD90 Offset: 0x18DE790 VA: 0x1818DFD90
	|-LinkedList<__Il2CppFullySharedGenericType>.ValidateNewNode
	*/

	// RVA: -1 Offset: -1
	internal void ValidateNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DFE50 Offset: 0x18DE850 VA: 0x1818DFE50
	|-LinkedList<ValueTuple<object, object>>.ValidateNode
	|-LinkedList<ValueTuple<object, object, object>>.ValidateNode
	|-LinkedList<BezierSegment>.ValidateNode
	|-LinkedList<object>.ValidateNode
	|-LinkedList<UIRenderDevice.DeviceToFree>.ValidateNode
	|
	|-RVA: 0x18DFEF0 Offset: 0x18DE8F0 VA: 0x1818DFEF0
	|-LinkedList<__Il2CppFullySharedGenericType>.ValidateNode
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.get_IsSynchronized
	|-LinkedList<BezierSegment>.System.Collections.ICollection.get_IsSynchronized
	|-LinkedList<object>.System.Collections.ICollection.get_IsSynchronized
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DFBA0 Offset: 0x18DE5A0 VA: 0x1818DFBA0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x18DFA50 Offset: 0x18DE450 VA: 0x1818DFA50
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x18DFAC0 Offset: 0x18DE4C0 VA: 0x1818DFAC0
	|-LinkedList<BezierSegment>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x18DFC10 Offset: 0x18DE610 VA: 0x1818DFC10
	|-LinkedList<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x18DFB30 Offset: 0x18DE530 VA: 0x1818DFB30
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x18DFC80 Offset: 0x18DE680 VA: 0x1818DFC80
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DF220 Offset: 0x18DDC20 VA: 0x1818DF220
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x18DF630 Offset: 0x18DE030 VA: 0x1818DF630
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x18DE950 Offset: 0x18DD350 VA: 0x1818DE950
	|-LinkedList<BezierSegment>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x18DE150 Offset: 0x18DCB50 VA: 0x1818DE150
	|-LinkedList<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x18DED70 Offset: 0x18DD770 VA: 0x1818DED70
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x18DE540 Offset: 0x18DCF40 VA: 0x1818DE540
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18DDE10 Offset: 0x18DC810 VA: 0x1818DDE10
	|-LinkedList<ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x18DE010 Offset: 0x18DCA10 VA: 0x1818DE010
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x18DDF60 Offset: 0x18DC960 VA: 0x1818DDF60
	|-LinkedList<BezierSegment>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x18DE0C0 Offset: 0x18DCAC0 VA: 0x1818DE0C0
	|-LinkedList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x18DDEB0 Offset: 0x18DC8B0 VA: 0x1818DDEB0
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
