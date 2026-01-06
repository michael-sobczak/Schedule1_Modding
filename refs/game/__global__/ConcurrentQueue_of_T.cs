public class ConcurrentQueue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 4942
{
	// Fields
	private const int InitialSegmentLength = 32;
	private const int MaxSegmentLength = 1048576;
	private object _crossSegmentLock; // 0x0
	private ConcurrentQueue.Segment<T> _tail; // 0x0
	private ConcurrentQueue.Segment<T> _head; // 0x0

	// Properties
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public bool IsEmpty { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D4F90 Offset: 0x14D3990 VA: 0x1814D4F90
	|-ConcurrentQueue<ByteEnum>..ctor
	|
	|-RVA: 0x14D4AE0 Offset: 0x14D34E0 VA: 0x1814D4AE0
	|-ConcurrentQueue<int>..ctor
	|
	|-RVA: 0x14D5080 Offset: 0x14D3A80 VA: 0x1814D5080
	|-ConcurrentQueue<LocalPacket>..ctor
	|
	|-RVA: 0x14D49F0 Offset: 0x14D33F0 VA: 0x1814D49F0
	|-ConcurrentQueue<object>..ctor
	|
	|-RVA: 0x14D4BD0 Offset: 0x14D35D0 VA: 0x1814D4BD0
	|-ConcurrentQueue<Packet>..ctor
	|
	|-RVA: 0x14D4DB0 Offset: 0x14D37B0 VA: 0x1814D4DB0
	|-ConcurrentQueue<RemoteConnectionEvent>..ctor
	|
	|-RVA: 0x14D4EA0 Offset: 0x14D38A0 VA: 0x1814D4EA0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x14D4900 Offset: 0x14D3300 VA: 0x1814D4900
	|-ConcurrentQueue<NatPunchModule.RequestEventData>..ctor
	|
	|-RVA: 0x14D4CC0 Offset: 0x14D36C0 VA: 0x1814D4CC0
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D0600 Offset: 0x14CF000 VA: 0x1814D0600
	|-ConcurrentQueue<ByteEnum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14D0900 Offset: 0x14CF300 VA: 0x1814D0900
	|-ConcurrentQueue<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14D0300 Offset: 0x14CED00 VA: 0x1814D0300
	|-ConcurrentQueue<LocalPacket>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14D0A00 Offset: 0x14CF400 VA: 0x1814D0A00
	|-ConcurrentQueue<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14D0700 Offset: 0x14CF100 VA: 0x1814D0700
	|-ConcurrentQueue<Packet>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14D0800 Offset: 0x14CF200 VA: 0x1814D0800
	|-ConcurrentQueue<RemoteConnectionEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14D0400 Offset: 0x14CEE00 VA: 0x1814D0400
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14D0500 Offset: 0x14CEF00 VA: 0x1814D0500
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14D0B00 Offset: 0x14CF500 VA: 0x1814D0B00
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ConcurrentQueue<ByteEnum>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentQueue<int>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentQueue<LocalPacket>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentQueue<object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentQueue<Packet>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentQueue<RemoteConnectionEvent>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1100 Offset: 0x14BFB00 VA: 0x1814C1100
	|-ConcurrentQueue<ByteEnum>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentQueue<int>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentQueue<LocalPacket>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentQueue<object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentQueue<Packet>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentQueue<RemoteConnectionEvent>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D0C00 Offset: 0x14CF600 VA: 0x1814D0C00
	|-ConcurrentQueue<ByteEnum>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentQueue<int>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentQueue<LocalPacket>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentQueue<object>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentQueue<Packet>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentQueue<RemoteConnectionEvent>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D73E0 Offset: 0x14D5DE0 VA: 0x1814D73E0
	|-ConcurrentQueue<ByteEnum>.get_IsEmpty
	|
	|-RVA: 0x14D7240 Offset: 0x14D5C40 VA: 0x1814D7240
	|-ConcurrentQueue<int>.get_IsEmpty
	|
	|-RVA: 0x14D7310 Offset: 0x14D5D10 VA: 0x1814D7310
	|-ConcurrentQueue<LocalPacket>.get_IsEmpty
	|
	|-RVA: 0x14D6FD0 Offset: 0x14D59D0 VA: 0x1814D6FD0
	|-ConcurrentQueue<object>.get_IsEmpty
	|
	|-RVA: 0x14D7170 Offset: 0x14D5B70 VA: 0x1814D7170
	|-ConcurrentQueue<Packet>.get_IsEmpty
	|
	|-RVA: 0x14D7540 Offset: 0x14D5F40 VA: 0x1814D7540
	|-ConcurrentQueue<RemoteConnectionEvent>.get_IsEmpty
	|
	|-RVA: 0x14D74A0 Offset: 0x14D5EA0 VA: 0x1814D74A0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.get_IsEmpty
	|
	|-RVA: 0x14D70A0 Offset: 0x14D5AA0 VA: 0x1814D70A0
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.get_IsEmpty
	|
	|-RVA: 0x14D7610 Offset: 0x14D6010 VA: 0x1814D7610
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D1C30 Offset: 0x14D0630 VA: 0x1814D1C30
	|-ConcurrentQueue<ByteEnum>.ToArray
	|
	|-RVA: 0x14D2CD0 Offset: 0x14D16D0 VA: 0x1814D2CD0
	|-ConcurrentQueue<int>.ToArray
	|
	|-RVA: 0x14D1810 Offset: 0x14D0210 VA: 0x1814D1810
	|-ConcurrentQueue<LocalPacket>.ToArray
	|
	|-RVA: 0x14D28B0 Offset: 0x14D12B0 VA: 0x1814D28B0
	|-ConcurrentQueue<object>.ToArray
	|
	|-RVA: 0x14D0C50 Offset: 0x14CF650 VA: 0x1814D0C50
	|-ConcurrentQueue<Packet>.ToArray
	|
	|-RVA: 0x14D1410 Offset: 0x14CFE10 VA: 0x1814D1410
	|-ConcurrentQueue<RemoteConnectionEvent>.ToArray
	|
	|-RVA: 0x14D1090 Offset: 0x14CFA90 VA: 0x1814D1090
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.ToArray
	|
	|-RVA: 0x14D2030 Offset: 0x14D0A30 VA: 0x1814D2030
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.ToArray
	|
	|-RVA: 0x14D2470 Offset: 0x14D0E70 VA: 0x1814D2470
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.ToArray
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D6C70 Offset: 0x14D5670 VA: 0x1814D6C70
	|-ConcurrentQueue<ByteEnum>.get_Count
	|
	|-RVA: 0x14D65B0 Offset: 0x14D4FB0 VA: 0x1814D65B0
	|-ConcurrentQueue<int>.get_Count
	|
	|-RVA: 0x14D5170 Offset: 0x14D3B70 VA: 0x1814D5170
	|-ConcurrentQueue<LocalPacket>.get_Count
	|
	|-RVA: 0x14D5EF0 Offset: 0x14D48F0 VA: 0x1814D5EF0
	|-ConcurrentQueue<object>.get_Count
	|
	|-RVA: 0x14D6910 Offset: 0x14D5310 VA: 0x1814D6910
	|-ConcurrentQueue<Packet>.get_Count
	|
	|-RVA: 0x14D54D0 Offset: 0x14D3ED0 VA: 0x1814D54D0
	|-ConcurrentQueue<RemoteConnectionEvent>.get_Count
	|
	|-RVA: 0x14D5830 Offset: 0x14D4230 VA: 0x1814D5830
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.get_Count
	|
	|-RVA: 0x14D6250 Offset: 0x14D4C50 VA: 0x1814D6250
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.get_Count
	|
	|-RVA: 0x14D5B90 Offset: 0x14D4590 VA: 0x1814D5B90
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.get_Count
	*/

	// RVA: -1 Offset: -1
	private static int GetCount(ConcurrentQueue.Segment<T> s, int head, int tail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14CE030 Offset: 0x14CCA30 VA: 0x1814CE030
	|-ConcurrentQueue<ByteEnum>.GetCount
	|-ConcurrentQueue<int>.GetCount
	|-ConcurrentQueue<LocalPacket>.GetCount
	|-ConcurrentQueue<object>.GetCount
	|-ConcurrentQueue<Packet>.GetCount
	|-ConcurrentQueue<RemoteConnectionEvent>.GetCount
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.GetCount
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.GetCount
	|
	|-RVA: 0x14CE0E0 Offset: 0x14CCAE0 VA: 0x1814CE0E0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetCount
	*/

	// RVA: -1 Offset: -1
	private static long GetCount(ConcurrentQueue.Segment<T> head, int headHead, ConcurrentQueue.Segment<T> tail, int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14CE1C0 Offset: 0x14CCBC0 VA: 0x1814CE1C0
	|-ConcurrentQueue<ByteEnum>.GetCount
	|-ConcurrentQueue<int>.GetCount
	|-ConcurrentQueue<LocalPacket>.GetCount
	|-ConcurrentQueue<object>.GetCount
	|-ConcurrentQueue<Packet>.GetCount
	|-ConcurrentQueue<RemoteConnectionEvent>.GetCount
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.GetCount
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.GetCount
	|
	|-RVA: 0x14CE340 Offset: 0x14CCD40 VA: 0x1814CE340
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetCount
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C9950 Offset: 0x14C8350 VA: 0x1814C9950
	|-ConcurrentQueue<ByteEnum>.CopyTo
	|
	|-RVA: 0x14CA600 Offset: 0x14C9000 VA: 0x1814CA600
	|-ConcurrentQueue<int>.CopyTo
	|
	|-RVA: 0x14C9D80 Offset: 0x14C8780 VA: 0x1814C9D80
	|-ConcurrentQueue<LocalPacket>.CopyTo
	|
	|-RVA: 0x14CAEA0 Offset: 0x14C98A0 VA: 0x1814CAEA0
	|-ConcurrentQueue<object>.CopyTo
	|
	|-RVA: 0x14CAA30 Offset: 0x14C9430 VA: 0x1814CAA30
	|-ConcurrentQueue<Packet>.CopyTo
	|
	|-RVA: 0x14CB2E0 Offset: 0x14C9CE0 VA: 0x1814CB2E0
	|-ConcurrentQueue<RemoteConnectionEvent>.CopyTo
	|
	|-RVA: 0x14CA250 Offset: 0x14C8C50 VA: 0x1814CA250
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x14CB710 Offset: 0x14CA110 VA: 0x1814CB710
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.CopyTo
	|
	|-RVA: 0x14CBB80 Offset: 0x14CA580 VA: 0x1814CBB80
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14CE520 Offset: 0x14CCF20 VA: 0x1814CE520
	|-ConcurrentQueue<ByteEnum>.GetEnumerator
	|
	|-RVA: 0x14CE6F0 Offset: 0x14CD0F0 VA: 0x1814CE6F0
	|-ConcurrentQueue<int>.GetEnumerator
	|
	|-RVA: 0x14CE830 Offset: 0x14CD230 VA: 0x1814CE830
	|-ConcurrentQueue<LocalPacket>.GetEnumerator
	|
	|-RVA: 0x14CEA10 Offset: 0x14CD410 VA: 0x1814CEA10
	|-ConcurrentQueue<object>.GetEnumerator
	|
	|-RVA: 0x14CE5C0 Offset: 0x14CCFC0 VA: 0x1814CE5C0
	|-ConcurrentQueue<Packet>.GetEnumerator
	|
	|-RVA: 0x14CE790 Offset: 0x14CD190 VA: 0x1814CE790
	|-ConcurrentQueue<RemoteConnectionEvent>.GetEnumerator
	|
	|-RVA: 0x14CE660 Offset: 0x14CD060 VA: 0x1814CE660
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x14CE970 Offset: 0x14CD370 VA: 0x1814CE970
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.GetEnumerator
	|
	|-RVA: 0x14CE8D0 Offset: 0x14CD2D0 VA: 0x1814CE8D0
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void SnapForObservation(out ConcurrentQueue.Segment<T> head, out int headHead, out ConcurrentQueue.Segment<T> tail, out int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14CF570 Offset: 0x14CDF70 VA: 0x1814CF570
	|-ConcurrentQueue<ByteEnum>.SnapForObservation
	|
	|-RVA: 0x14CF870 Offset: 0x14CE270 VA: 0x1814CF870
	|-ConcurrentQueue<int>.SnapForObservation
	|
	|-RVA: 0x14D0000 Offset: 0x14CEA00 VA: 0x1814D0000
	|-ConcurrentQueue<LocalPacket>.SnapForObservation
	|
	|-RVA: 0x14CFB80 Offset: 0x14CE580 VA: 0x1814CFB80
	|-ConcurrentQueue<object>.SnapForObservation
	|
	|-RVA: 0x14D0180 Offset: 0x14CEB80 VA: 0x1814D0180
	|-ConcurrentQueue<Packet>.SnapForObservation
	|
	|-RVA: 0x14CFD00 Offset: 0x14CE700 VA: 0x1814CFD00
	|-ConcurrentQueue<RemoteConnectionEvent>.SnapForObservation
	|
	|-RVA: 0x14CF9F0 Offset: 0x14CE3F0 VA: 0x1814CF9F0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.SnapForObservation
	|
	|-RVA: 0x14CF6F0 Offset: 0x14CE0F0 VA: 0x1814CF6F0
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.SnapForObservation
	|
	|-RVA: 0x14CFE80 Offset: 0x14CE880 VA: 0x1814CFE80
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.SnapForObservation
	*/

	// RVA: -1 Offset: -1
	private T GetItemWhenAvailable(ConcurrentQueue.Segment<T> segment, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14CF250 Offset: 0x14CDC50 VA: 0x1814CF250
	|-ConcurrentQueue<ByteEnum>.GetItemWhenAvailable
	|
	|-RVA: 0x14CF150 Offset: 0x14CDB50 VA: 0x1814CF150
	|-ConcurrentQueue<int>.GetItemWhenAvailable
	|
	|-RVA: 0x14CF450 Offset: 0x14CDE50 VA: 0x1814CF450
	|-ConcurrentQueue<LocalPacket>.GetItemWhenAvailable
	|
	|-RVA: 0x14CF050 Offset: 0x14CDA50 VA: 0x1814CF050
	|-ConcurrentQueue<object>.GetItemWhenAvailable
	|
	|-RVA: 0x14CEAB0 Offset: 0x14CD4B0 VA: 0x1814CEAB0
	|-ConcurrentQueue<Packet>.GetItemWhenAvailable
	|
	|-RVA: 0x14CF350 Offset: 0x14CDD50 VA: 0x1814CF350
	|-ConcurrentQueue<RemoteConnectionEvent>.GetItemWhenAvailable
	|
	|-RVA: 0x14CED10 Offset: 0x14CD710 VA: 0x1814CED10
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetItemWhenAvailable
	|
	|-RVA: 0x14CEF20 Offset: 0x14CD920 VA: 0x1814CEF20
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.GetItemWhenAvailable
	|
	|-RVA: 0x14CEBE0 Offset: 0x14CD5E0 VA: 0x1814CEBE0
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.GetItemWhenAvailable
	*/

	[IteratorStateMachine(typeof(ConcurrentQueue.<Enumerate>d__28<T>))]
	// RVA: -1 Offset: -1
	private IEnumerator<T> Enumerate(ConcurrentQueue.Segment<T> head, int headHead, ConcurrentQueue.Segment<T> tail, int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14CDD20 Offset: 0x14CC720 VA: 0x1814CDD20
	|-ConcurrentQueue<ByteEnum>.Enumerate
	|-ConcurrentQueue<int>.Enumerate
	|
	|-RVA: 0x14CDC40 Offset: 0x14CC640 VA: 0x1814CDC40
	|-ConcurrentQueue<LocalPacket>.Enumerate
	|
	|-RVA: 0x14CDB60 Offset: 0x14CC560 VA: 0x1814CDB60
	|-ConcurrentQueue<object>.Enumerate
	|-ConcurrentQueue<RemoteConnectionEvent>.Enumerate
	|
	|-RVA: 0x14CDA80 Offset: 0x14CC480 VA: 0x1814CDA80
	|-ConcurrentQueue<Packet>.Enumerate
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.Enumerate
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.Enumerate
	|
	|-RVA: 0x14CDE00 Offset: 0x14CC800 VA: 0x1814CDE00
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.Enumerate
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14CD8B0 Offset: 0x14CC2B0 VA: 0x1814CD8B0
	|-ConcurrentQueue<ByteEnum>.Enqueue
	|
	|-RVA: 0x14CD780 Offset: 0x14CC180 VA: 0x1814CD780
	|-ConcurrentQueue<int>.Enqueue
	|
	|-RVA: 0x14CD810 Offset: 0x14CC210 VA: 0x1814CD810
	|-ConcurrentQueue<LocalPacket>.Enqueue
	|
	|-RVA: 0x14CD6F0 Offset: 0x14CC0F0 VA: 0x1814CD6F0
	|-ConcurrentQueue<object>.Enqueue
	|
	|-RVA: 0x14CD640 Offset: 0x14CC040 VA: 0x1814CD640
	|-ConcurrentQueue<Packet>.Enqueue
	|
	|-RVA: 0x14CD940 Offset: 0x14CC340 VA: 0x1814CD940
	|-ConcurrentQueue<RemoteConnectionEvent>.Enqueue
	|
	|-RVA: 0x14CD420 Offset: 0x14CBE20 VA: 0x1814CD420
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.Enqueue
	|
	|-RVA: 0x14CD590 Offset: 0x14CBF90 VA: 0x1814CD590
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.Enqueue
	|
	|-RVA: 0x14CD9D0 Offset: 0x14CC3D0 VA: 0x1814CD9D0
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.Enqueue
	*/

	// RVA: -1 Offset: -1
	private void EnqueueSlow(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14CCB70 Offset: 0x14CB570 VA: 0x1814CCB70
	|-ConcurrentQueue<ByteEnum>.EnqueueSlow
	|
	|-RVA: 0x14CCD80 Offset: 0x14CB780 VA: 0x1814CCD80
	|-ConcurrentQueue<int>.EnqueueSlow
	|
	|-RVA: 0x14CD1E0 Offset: 0x14CBBE0 VA: 0x1814CD1E0
	|-ConcurrentQueue<LocalPacket>.EnqueueSlow
	|
	|-RVA: 0x14CC490 Offset: 0x14CAE90 VA: 0x1814CC490
	|-ConcurrentQueue<object>.EnqueueSlow
	|
	|-RVA: 0x14CCF90 Offset: 0x14CB990 VA: 0x1814CCF90
	|-ConcurrentQueue<Packet>.EnqueueSlow
	|
	|-RVA: 0x14CC6A0 Offset: 0x14CB0A0 VA: 0x1814CC6A0
	|-ConcurrentQueue<RemoteConnectionEvent>.EnqueueSlow
	|
	|-RVA: 0x14CC8B0 Offset: 0x14CB2B0 VA: 0x1814CC8B0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.EnqueueSlow
	|
	|-RVA: 0x14CC240 Offset: 0x14CAC40 VA: 0x1814CC240
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.EnqueueSlow
	|
	|-RVA: 0x14CBFF0 Offset: 0x14CA9F0 VA: 0x1814CBFF0
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.EnqueueSlow
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D3E80 Offset: 0x14D2880 VA: 0x1814D3E80
	|-ConcurrentQueue<ByteEnum>.TryDequeue
	|
	|-RVA: 0x14D4030 Offset: 0x14D2A30 VA: 0x1814D4030
	|-ConcurrentQueue<int>.TryDequeue
	|
	|-RVA: 0x14D3FA0 Offset: 0x14D29A0 VA: 0x1814D3FA0
	|-ConcurrentQueue<LocalPacket>.TryDequeue
	|
	|-RVA: 0x14D3CD0 Offset: 0x14D26D0 VA: 0x1814D3CD0
	|-ConcurrentQueue<object>.TryDequeue
	|
	|-RVA: 0x14D40C0 Offset: 0x14D2AC0 VA: 0x1814D40C0
	|-ConcurrentQueue<Packet>.TryDequeue
	|
	|-RVA: 0x14D4150 Offset: 0x14D2B50 VA: 0x1814D4150
	|-ConcurrentQueue<RemoteConnectionEvent>.TryDequeue
	|
	|-RVA: 0x14D3D60 Offset: 0x14D2760 VA: 0x1814D3D60
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.TryDequeue
	|
	|-RVA: 0x14D3DF0 Offset: 0x14D27F0 VA: 0x1814D3DF0
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.TryDequeue
	|
	|-RVA: 0x14D3F10 Offset: 0x14D2910 VA: 0x1814D3F10
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.TryDequeue
	*/

	// RVA: -1 Offset: -1
	private bool TryDequeueSlow(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D3370 Offset: 0x14D1D70 VA: 0x1814D3370
	|-ConcurrentQueue<ByteEnum>.TryDequeueSlow
	|
	|-RVA: 0x14D3610 Offset: 0x14D2010 VA: 0x1814D3610
	|-ConcurrentQueue<int>.TryDequeueSlow
	|
	|-RVA: 0x14D3220 Offset: 0x14D1C20 VA: 0x1814D3220
	|-ConcurrentQueue<LocalPacket>.TryDequeueSlow
	|
	|-RVA: 0x14D3760 Offset: 0x14D2160 VA: 0x1814D3760
	|-ConcurrentQueue<object>.TryDequeueSlow
	|
	|-RVA: 0x14D30D0 Offset: 0x14D1AD0 VA: 0x1814D30D0
	|-ConcurrentQueue<Packet>.TryDequeueSlow
	|
	|-RVA: 0x14D34C0 Offset: 0x14D1EC0 VA: 0x1814D34C0
	|-ConcurrentQueue<RemoteConnectionEvent>.TryDequeueSlow
	|
	|-RVA: 0x14D3A00 Offset: 0x14D2400 VA: 0x1814D3A00
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.TryDequeueSlow
	|
	|-RVA: 0x14D38B0 Offset: 0x14D22B0 VA: 0x1814D38B0
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.TryDequeueSlow
	|
	|-RVA: 0x14D3B80 Offset: 0x14D2580 VA: 0x1814D3B80
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.TryDequeueSlow
	*/

	// RVA: -1 Offset: -1
	private bool TryPeek(out T result, bool resultUsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D4840 Offset: 0x14D3240 VA: 0x1814D4840
	|-ConcurrentQueue<ByteEnum>.TryPeek
	|
	|-RVA: 0x14D4780 Offset: 0x14D3180 VA: 0x1814D4780
	|-ConcurrentQueue<int>.TryPeek
	|
	|-RVA: 0x14D4450 Offset: 0x14D2E50 VA: 0x1814D4450
	|-ConcurrentQueue<LocalPacket>.TryPeek
	|
	|-RVA: 0x14D46C0 Offset: 0x14D30C0 VA: 0x1814D46C0
	|-ConcurrentQueue<object>.TryPeek
	|
	|-RVA: 0x14D4520 Offset: 0x14D2F20 VA: 0x1814D4520
	|-ConcurrentQueue<Packet>.TryPeek
	|
	|-RVA: 0x14D42B0 Offset: 0x14D2CB0 VA: 0x1814D42B0
	|-ConcurrentQueue<RemoteConnectionEvent>.TryPeek
	|
	|-RVA: 0x14D4370 Offset: 0x14D2D70 VA: 0x1814D4370
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.TryPeek
	|
	|-RVA: 0x14D45F0 Offset: 0x14D2FF0 VA: 0x1814D45F0
	|-ConcurrentQueue<NatPunchModule.RequestEventData>.TryPeek
	|
	|-RVA: 0x14D41E0 Offset: 0x14D2BE0 VA: 0x1814D41E0
	|-ConcurrentQueue<NatPunchModule.SuccessEventData>.TryPeek
	*/
}
