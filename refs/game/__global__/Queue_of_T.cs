public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 4996
{
	// Fields
	private T[] _array; // 0x0
	private int _head; // 0x0
	private int _tail; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private const int MinimumGrow = 4;
	private const int GrowFactor = 200;

	// Properties
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B7A0 Offset: 0x110A1A0 VA: 0x18110B7A0
	|-Queue<ValueTuple<IntPtr, object>>..ctor
	|-Queue<Int2>..ctor
	|-Queue<Int3>..ctor
	|-Queue<int>..ctor
	|-Queue<LocalPacket>..ctor
	|-Queue<LocalPacket>..ctor
	|-Queue<object>..ctor
	|-Queue<Packet>..ctor
	|-Queue<ushort>..ctor
	|-Queue<EventDispatcher.EventRecord>..ctor
	|-Queue<GraphUpdateProcessor.GUOSingle>..ctor
	|-Queue<NetworkAnimator.ReceivedServerData>..ctor
	|
	|-RVA: 0x110B8E0 Offset: 0x110A2E0 VA: 0x18110B8E0
	|-Queue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B7F0 Offset: 0x110A1F0 VA: 0x18110B7F0
	|-Queue<ValueTuple<IntPtr, object>>..ctor
	|-Queue<Int2>..ctor
	|-Queue<Int3>..ctor
	|-Queue<int>..ctor
	|-Queue<LocalPacket>..ctor
	|-Queue<LocalPacket>..ctor
	|-Queue<object>..ctor
	|-Queue<Packet>..ctor
	|-Queue<ushort>..ctor
	|-Queue<__Il2CppFullySharedGenericType>..ctor
	|-Queue<EventDispatcher.EventRecord>..ctor
	|-Queue<GraphUpdateProcessor.GUOSingle>..ctor
	|-Queue<NetworkAnimator.ReceivedServerData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	|-Queue<ValueTuple<IntPtr, object>>.get_Count
	|-Queue<Int2>.get_Count
	|-Queue<Int3>.get_Count
	|-Queue<int>.get_Count
	|-Queue<LocalPacket>.get_Count
	|-Queue<LocalPacket>.get_Count
	|-Queue<object>.get_Count
	|-Queue<Packet>.get_Count
	|-Queue<ushort>.get_Count
	|-Queue<__Il2CppFullySharedGenericType>.get_Count
	|-Queue<EventDispatcher.EventRecord>.get_Count
	|-Queue<GraphUpdateProcessor.GUOSingle>.get_Count
	|-Queue<NetworkAnimator.ReceivedServerData>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-Queue<ValueTuple<IntPtr, object>>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<Int2>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<Int3>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<int>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<LocalPacket>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<LocalPacket>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<object>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<Packet>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<ushort>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<GraphUpdateProcessor.GUOSingle>.System.Collections.ICollection.get_IsSynchronized
	|-Queue<NetworkAnimator.ReceivedServerData>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B2D0 Offset: 0x1109CD0 VA: 0x18110B2D0
	|-Queue<ValueTuple<IntPtr, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110B180 Offset: 0x1109B80 VA: 0x18110B180
	|-Queue<Int2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110B030 Offset: 0x1109A30 VA: 0x18110B030
	|-Queue<Int3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110B340 Offset: 0x1109D40 VA: 0x18110B340
	|-Queue<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110B110 Offset: 0x1109B10 VA: 0x18110B110
	|-Queue<LocalPacket>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110B260 Offset: 0x1109C60 VA: 0x18110B260
	|-Queue<LocalPacket>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110B0A0 Offset: 0x1109AA0 VA: 0x18110B0A0
	|-Queue<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110B500 Offset: 0x1109F00 VA: 0x18110B500
	|-Queue<Packet>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110AFC0 Offset: 0x11099C0 VA: 0x18110AFC0
	|-Queue<ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110B1F0 Offset: 0x1109BF0 VA: 0x18110B1F0
	|-Queue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110B420 Offset: 0x1109E20 VA: 0x18110B420
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110B3B0 Offset: 0x1109DB0 VA: 0x18110B3B0
	|-Queue<GraphUpdateProcessor.GUOSingle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x110B490 Offset: 0x1109E90 VA: 0x18110B490
	|-Queue<NetworkAnimator.ReceivedServerData>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1107A70 Offset: 0x1106470 VA: 0x181107A70
	|-Queue<ValueTuple<IntPtr, object>>.Clear
	|-Queue<LocalPacket>.Clear
	|-Queue<LocalPacket>.Clear
	|-Queue<object>.Clear
	|-Queue<Packet>.Clear
	|-Queue<EventDispatcher.EventRecord>.Clear
	|-Queue<GraphUpdateProcessor.GUOSingle>.Clear
	|-Queue<NetworkAnimator.ReceivedServerData>.Clear
	|
	|-RVA: 0x1107A50 Offset: 0x1106450 VA: 0x181107A50
	|-Queue<Int2>.Clear
	|-Queue<Int3>.Clear
	|-Queue<int>.Clear
	|-Queue<ushort>.Clear
	|
	|-RVA: 0x1107AE0 Offset: 0x11064E0 VA: 0x181107AE0
	|-Queue<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110ACB0 Offset: 0x11096B0 VA: 0x18110ACB0
	|-Queue<ValueTuple<IntPtr, object>>.System.Collections.ICollection.CopyTo
	|-Queue<Int2>.System.Collections.ICollection.CopyTo
	|-Queue<Int3>.System.Collections.ICollection.CopyTo
	|-Queue<int>.System.Collections.ICollection.CopyTo
	|-Queue<LocalPacket>.System.Collections.ICollection.CopyTo
	|-Queue<LocalPacket>.System.Collections.ICollection.CopyTo
	|-Queue<object>.System.Collections.ICollection.CopyTo
	|-Queue<Packet>.System.Collections.ICollection.CopyTo
	|-Queue<ushort>.System.Collections.ICollection.CopyTo
	|-Queue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.CopyTo
	|-Queue<GraphUpdateProcessor.GUOSingle>.System.Collections.ICollection.CopyTo
	|-Queue<NetworkAnimator.ReceivedServerData>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1109740 Offset: 0x1108140 VA: 0x181109740
	|-Queue<ValueTuple<IntPtr, object>>.Enqueue
	|-Queue<NetworkAnimator.ReceivedServerData>.Enqueue
	|
	|-RVA: 0x1109A90 Offset: 0x1108490 VA: 0x181109A90
	|-Queue<Int2>.Enqueue
	|
	|-RVA: 0x110A100 Offset: 0x1108B00 VA: 0x18110A100
	|-Queue<Int3>.Enqueue
	|
	|-RVA: 0x1109C20 Offset: 0x1108620 VA: 0x181109C20
	|-Queue<int>.Enqueue
	|
	|-RVA: 0x1109590 Offset: 0x1107F90 VA: 0x181109590
	|-Queue<LocalPacket>.Enqueue
	|-Queue<LocalPacket>.Enqueue
	|-Queue<EventDispatcher.EventRecord>.Enqueue
	|
	|-RVA: 0x11093F0 Offset: 0x1107DF0 VA: 0x1811093F0
	|-Queue<object>.Enqueue
	|
	|-RVA: 0x1109DB0 Offset: 0x11087B0 VA: 0x181109DB0
	|-Queue<Packet>.Enqueue
	|-Queue<GraphUpdateProcessor.GUOSingle>.Enqueue
	|
	|-RVA: 0x1109F70 Offset: 0x1108970 VA: 0x181109F70
	|-Queue<ushort>.Enqueue
	|
	|-RVA: 0x11098F0 Offset: 0x11082F0 VA: 0x1811098F0
	|-Queue<__Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public Queue.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110A2A0 Offset: 0x1108CA0 VA: 0x18110A2A0
	|-Queue<ValueTuple<IntPtr, object>>.GetEnumerator
	|-Queue<LocalPacket>.GetEnumerator
	|-Queue<LocalPacket>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.GetEnumerator
	|-Queue<NetworkAnimator.ReceivedServerData>.GetEnumerator
	|
	|-RVA: 0x110A2D0 Offset: 0x1108CD0 VA: 0x18110A2D0
	|-Queue<Int2>.GetEnumerator
	|-Queue<object>.GetEnumerator
	|
	|-RVA: 0x110A440 Offset: 0x1108E40 VA: 0x18110A440
	|-Queue<Int3>.GetEnumerator
	|
	|-RVA: 0x110A470 Offset: 0x1108E70 VA: 0x18110A470
	|-Queue<int>.GetEnumerator
	|
	|-RVA: 0x110A350 Offset: 0x1108D50 VA: 0x18110A350
	|-Queue<Packet>.GetEnumerator
	|-Queue<GraphUpdateProcessor.GUOSingle>.GetEnumerator
	|
	|-RVA: 0x110A310 Offset: 0x1108D10 VA: 0x18110A310
	|-Queue<ushort>.GetEnumerator
	|
	|-RVA: 0x110A390 Offset: 0x1108D90 VA: 0x18110A390
	|-Queue<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110A9C0 Offset: 0x11093C0 VA: 0x18110A9C0
	|-Queue<ValueTuple<IntPtr, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<LocalPacket>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<LocalPacket>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<NetworkAnimator.ReceivedServerData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x110AA30 Offset: 0x1109430 VA: 0x18110AA30
	|-Queue<Int2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x110AAA0 Offset: 0x11094A0 VA: 0x18110AAA0
	|-Queue<Int3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x110A950 Offset: 0x1109350 VA: 0x18110A950
	|-Queue<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x110AB10 Offset: 0x1109510 VA: 0x18110AB10
	|-Queue<Packet>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<GraphUpdateProcessor.GUOSingle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x110AC40 Offset: 0x1109640 VA: 0x18110AC40
	|-Queue<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x110AB90 Offset: 0x1109590 VA: 0x18110AB90
	|-Queue<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110A9C0 Offset: 0x11093C0 VA: 0x18110A9C0
	|-Queue<ValueTuple<IntPtr, object>>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<LocalPacket>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<LocalPacket>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<NetworkAnimator.ReceivedServerData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x110AA30 Offset: 0x1109430 VA: 0x18110AA30
	|-Queue<Int2>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x110AAA0 Offset: 0x11094A0 VA: 0x18110AAA0
	|-Queue<Int3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x110A950 Offset: 0x1109350 VA: 0x18110A950
	|-Queue<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x110AB10 Offset: 0x1109510 VA: 0x18110AB10
	|-Queue<Packet>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<GraphUpdateProcessor.GUOSingle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x110AC40 Offset: 0x1109640 VA: 0x18110AC40
	|-Queue<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x110AB90 Offset: 0x1109590 VA: 0x18110AB90
	|-Queue<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1108C00 Offset: 0x1107600 VA: 0x181108C00
	|-Queue<ValueTuple<IntPtr, object>>.Dequeue
	|-Queue<NetworkAnimator.ReceivedServerData>.Dequeue
	|
	|-RVA: 0x1108DC0 Offset: 0x11077C0 VA: 0x181108DC0
	|-Queue<Int2>.Dequeue
	|
	|-RVA: 0x11092D0 Offset: 0x1107CD0 VA: 0x1811092D0
	|-Queue<Int3>.Dequeue
	|
	|-RVA: 0x1109370 Offset: 0x1107D70 VA: 0x181109370
	|-Queue<int>.Dequeue
	|
	|-RVA: 0x1108CE0 Offset: 0x11076E0 VA: 0x181108CE0
	|-Queue<LocalPacket>.Dequeue
	|-Queue<LocalPacket>.Dequeue
	|-Queue<EventDispatcher.EventRecord>.Dequeue
	|
	|-RVA: 0x1109120 Offset: 0x1107B20 VA: 0x181109120
	|-Queue<object>.Dequeue
	|
	|-RVA: 0x11091D0 Offset: 0x1107BD0 VA: 0x1811091D0
	|-Queue<Packet>.Dequeue
	|-Queue<GraphUpdateProcessor.GUOSingle>.Dequeue
	|
	|-RVA: 0x1108E40 Offset: 0x1107840 VA: 0x181108E40
	|-Queue<ushort>.Dequeue
	|
	|-RVA: 0x1108EC0 Offset: 0x11078C0 VA: 0x181108EC0
	|-Queue<__Il2CppFullySharedGenericType>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110A4E0 Offset: 0x1108EE0 VA: 0x18110A4E0
	|-Queue<ValueTuple<IntPtr, object>>.Peek
	|-Queue<LocalPacket>.Peek
	|-Queue<LocalPacket>.Peek
	|-Queue<EventDispatcher.EventRecord>.Peek
	|-Queue<NetworkAnimator.ReceivedServerData>.Peek
	|
	|-RVA: 0x110A6B0 Offset: 0x11090B0 VA: 0x18110A6B0
	|-Queue<Int2>.Peek
	|-Queue<object>.Peek
	|
	|-RVA: 0x110A550 Offset: 0x1108F50 VA: 0x18110A550
	|-Queue<Int3>.Peek
	|
	|-RVA: 0x110A5D0 Offset: 0x1108FD0 VA: 0x18110A5D0
	|-Queue<int>.Peek
	|
	|-RVA: 0x110A630 Offset: 0x1109030 VA: 0x18110A630
	|-Queue<Packet>.Peek
	|-Queue<GraphUpdateProcessor.GUOSingle>.Peek
	|
	|-RVA: 0x110A7F0 Offset: 0x11091F0 VA: 0x18110A7F0
	|-Queue<ushort>.Peek
	|
	|-RVA: 0x110A710 Offset: 0x1109110 VA: 0x18110A710
	|-Queue<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1108870 Offset: 0x1107270 VA: 0x181108870
	|-Queue<ValueTuple<IntPtr, object>>.Contains
	|
	|-RVA: 0x1108620 Offset: 0x1107020 VA: 0x181108620
	|-Queue<Int2>.Contains
	|
	|-RVA: 0x11081B0 Offset: 0x1106BB0 VA: 0x1811081B0
	|-Queue<Int3>.Contains
	|
	|-RVA: 0x11082F0 Offset: 0x1106CF0 VA: 0x1811082F0
	|-Queue<int>.Contains
	|
	|-RVA: 0x1108AD0 Offset: 0x11074D0 VA: 0x181108AD0
	|-Queue<LocalPacket>.Contains
	|
	|-RVA: 0x11083F0 Offset: 0x1106DF0 VA: 0x1811083F0
	|-Queue<LocalPacket>.Contains
	|
	|-RVA: 0x1107F60 Offset: 0x1106960 VA: 0x181107F60
	|-Queue<object>.Contains
	|
	|-RVA: 0x1108060 Offset: 0x1106A60 VA: 0x181108060
	|-Queue<Packet>.Contains
	|
	|-RVA: 0x1108520 Offset: 0x1106F20 VA: 0x181108520
	|-Queue<ushort>.Contains
	|
	|-RVA: 0x1107CA0 Offset: 0x11066A0 VA: 0x181107CA0
	|-Queue<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x11089A0 Offset: 0x11073A0 VA: 0x1811089A0
	|-Queue<EventDispatcher.EventRecord>.Contains
	|
	|-RVA: 0x1108720 Offset: 0x1107120 VA: 0x181108720
	|-Queue<GraphUpdateProcessor.GUOSingle>.Contains
	|
	|-RVA: 0x1107B70 Offset: 0x1106570 VA: 0x181107B70
	|-Queue<NetworkAnimator.ReceivedServerData>.Contains
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B5C0 Offset: 0x1109FC0 VA: 0x18110B5C0
	|-Queue<ValueTuple<IntPtr, object>>.ToArray
	|-Queue<Int2>.ToArray
	|-Queue<Int3>.ToArray
	|-Queue<int>.ToArray
	|-Queue<LocalPacket>.ToArray
	|-Queue<LocalPacket>.ToArray
	|-Queue<object>.ToArray
	|-Queue<Packet>.ToArray
	|-Queue<ushort>.ToArray
	|-Queue<EventDispatcher.EventRecord>.ToArray
	|-Queue<GraphUpdateProcessor.GUOSingle>.ToArray
	|-Queue<NetworkAnimator.ReceivedServerData>.ToArray
	|
	|-RVA: 0x110B6B0 Offset: 0x110A0B0 VA: 0x18110B6B0
	|-Queue<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110A850 Offset: 0x1109250 VA: 0x18110A850
	|-Queue<ValueTuple<IntPtr, object>>.SetCapacity
	|-Queue<Int2>.SetCapacity
	|-Queue<Int3>.SetCapacity
	|-Queue<int>.SetCapacity
	|-Queue<LocalPacket>.SetCapacity
	|-Queue<LocalPacket>.SetCapacity
	|-Queue<object>.SetCapacity
	|-Queue<Packet>.SetCapacity
	|-Queue<ushort>.SetCapacity
	|-Queue<__Il2CppFullySharedGenericType>.SetCapacity
	|-Queue<EventDispatcher.EventRecord>.SetCapacity
	|-Queue<GraphUpdateProcessor.GUOSingle>.SetCapacity
	|-Queue<NetworkAnimator.ReceivedServerData>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private void MoveNext(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110A4B0 Offset: 0x1108EB0 VA: 0x18110A4B0
	|-Queue<ValueTuple<IntPtr, object>>.MoveNext
	|-Queue<Int2>.MoveNext
	|-Queue<Int3>.MoveNext
	|-Queue<int>.MoveNext
	|-Queue<LocalPacket>.MoveNext
	|-Queue<LocalPacket>.MoveNext
	|-Queue<object>.MoveNext
	|-Queue<Packet>.MoveNext
	|-Queue<ushort>.MoveNext
	|-Queue<__Il2CppFullySharedGenericType>.MoveNext
	|-Queue<EventDispatcher.EventRecord>.MoveNext
	|-Queue<GraphUpdateProcessor.GUOSingle>.MoveNext
	|-Queue<NetworkAnimator.ReceivedServerData>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void ThrowForEmptyQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B570 Offset: 0x1109F70 VA: 0x18110B570
	|-Queue<ValueTuple<IntPtr, object>>.ThrowForEmptyQueue
	|-Queue<Int2>.ThrowForEmptyQueue
	|-Queue<Int3>.ThrowForEmptyQueue
	|-Queue<int>.ThrowForEmptyQueue
	|-Queue<LocalPacket>.ThrowForEmptyQueue
	|-Queue<LocalPacket>.ThrowForEmptyQueue
	|-Queue<object>.ThrowForEmptyQueue
	|-Queue<Packet>.ThrowForEmptyQueue
	|-Queue<ushort>.ThrowForEmptyQueue
	|-Queue<__Il2CppFullySharedGenericType>.ThrowForEmptyQueue
	|-Queue<EventDispatcher.EventRecord>.ThrowForEmptyQueue
	|-Queue<GraphUpdateProcessor.GUOSingle>.ThrowForEmptyQueue
	|-Queue<NetworkAnimator.ReceivedServerData>.ThrowForEmptyQueue
	*/
}
