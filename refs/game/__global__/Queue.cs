public struct Queue.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 4995
{
	// Fields
	private readonly Queue<T> _q; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Queue<T> q) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1666280 Offset: 0x1664C80 VA: 0x181666280
	|-Queue.Enumerator<ValueTuple<IntPtr, object>>..ctor
	|-Queue.Enumerator<LocalPacket>..ctor
	|-Queue.Enumerator<LocalPacket>..ctor
	|-Queue.Enumerator<EventDispatcher.EventRecord>..ctor
	|-Queue.Enumerator<NetworkAnimator.ReceivedServerData>..ctor
	|
	|-RVA: 0x166B900 Offset: 0x166A300 VA: 0x18166B900
	|-Queue.Enumerator<Int2>..ctor
	|-Queue.Enumerator<object>..ctor
	|
	|-RVA: 0x166BB60 Offset: 0x166A560 VA: 0x18166BB60
	|-Queue.Enumerator<Int3>..ctor
	|
	|-RVA: 0x166BC80 Offset: 0x166A680 VA: 0x18166BC80
	|-Queue.Enumerator<int>..ctor
	|
	|-RVA: 0x166BE60 Offset: 0x166A860 VA: 0x18166BE60
	|-Queue.Enumerator<Packet>..ctor
	|-Queue.Enumerator<GraphUpdateProcessor.GUOSingle>..ctor
	|
	|-RVA: 0x16706F0 Offset: 0x166F0F0 VA: 0x1816706F0
	|-Queue.Enumerator<ushort>..ctor
	|
	|-RVA: 0x167A200 Offset: 0x1678C00 VA: 0x18167A200
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16618D0 Offset: 0x16602D0 VA: 0x1816618D0
	|-Queue.Enumerator<ValueTuple<IntPtr, object>>.Dispose
	|-Queue.Enumerator<LocalPacket>.Dispose
	|-Queue.Enumerator<LocalPacket>.Dispose
	|-Queue.Enumerator<EventDispatcher.EventRecord>.Dispose
	|-Queue.Enumerator<NetworkAnimator.ReceivedServerData>.Dispose
	|
	|-RVA: 0x16675C0 Offset: 0x1665FC0 VA: 0x1816675C0
	|-Queue.Enumerator<Int2>.Dispose
	|-Queue.Enumerator<object>.Dispose
	|
	|-RVA: 0x1667670 Offset: 0x1666070 VA: 0x181667670
	|-Queue.Enumerator<Int3>.Dispose
	|
	|-RVA: 0x1667660 Offset: 0x1666060 VA: 0x181667660
	|-Queue.Enumerator<int>.Dispose
	|
	|-RVA: 0x1667640 Offset: 0x1666040 VA: 0x181667640
	|-Queue.Enumerator<Packet>.Dispose
	|-Queue.Enumerator<GraphUpdateProcessor.GUOSingle>.Dispose
	|
	|-RVA: 0x166CFC0 Offset: 0x166B9C0 VA: 0x18166CFC0
	|-Queue.Enumerator<ushort>.Dispose
	|
	|-RVA: 0x1671B10 Offset: 0x1670510 VA: 0x181671B10
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1663360 Offset: 0x1661D60 VA: 0x181663360
	|-Queue.Enumerator<ValueTuple<IntPtr, object>>.MoveNext
	|-Queue.Enumerator<NetworkAnimator.ReceivedServerData>.MoveNext
	|
	|-RVA: 0x1668ED0 Offset: 0x16678D0 VA: 0x181668ED0
	|-Queue.Enumerator<Int2>.MoveNext
	|
	|-RVA: 0x16693D0 Offset: 0x1667DD0 VA: 0x1816693D0
	|-Queue.Enumerator<Int3>.MoveNext
	|
	|-RVA: 0x16692F0 Offset: 0x1667CF0 VA: 0x1816692F0
	|-Queue.Enumerator<int>.MoveNext
	|
	|-RVA: 0x1668170 Offset: 0x1666B70 VA: 0x181668170
	|-Queue.Enumerator<LocalPacket>.MoveNext
	|-Queue.Enumerator<LocalPacket>.MoveNext
	|-Queue.Enumerator<EventDispatcher.EventRecord>.MoveNext
	|
	|-RVA: 0x1668B80 Offset: 0x1667580 VA: 0x181668B80
	|-Queue.Enumerator<object>.MoveNext
	|
	|-RVA: 0x1668060 Offset: 0x1666A60 VA: 0x181668060
	|-Queue.Enumerator<Packet>.MoveNext
	|-Queue.Enumerator<GraphUpdateProcessor.GUOSingle>.MoveNext
	|
	|-RVA: 0x166E4A0 Offset: 0x166CEA0 VA: 0x18166E4A0
	|-Queue.Enumerator<ushort>.MoveNext
	|
	|-RVA: 0x1674A70 Offset: 0x1673470 VA: 0x181674A70
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1666DE0 Offset: 0x16657E0 VA: 0x181666DE0
	|-Queue.Enumerator<ValueTuple<IntPtr, object>>.get_Current
	|-Queue.Enumerator<LocalPacket>.get_Current
	|-Queue.Enumerator<LocalPacket>.get_Current
	|-Queue.Enumerator<EventDispatcher.EventRecord>.get_Current
	|-Queue.Enumerator<NetworkAnimator.ReceivedServerData>.get_Current
	|
	|-RVA: 0x166C880 Offset: 0x166B280 VA: 0x18166C880
	|-Queue.Enumerator<Int2>.get_Current
	|-Queue.Enumerator<object>.get_Current
	|
	|-RVA: 0x166C990 Offset: 0x166B390 VA: 0x18166C990
	|-Queue.Enumerator<Int3>.get_Current
	|
	|-RVA: 0x166C2F0 Offset: 0x166ACF0 VA: 0x18166C2F0
	|-Queue.Enumerator<int>.get_Current
	|
	|-RVA: 0x166C740 Offset: 0x166B140 VA: 0x18166C740
	|-Queue.Enumerator<Packet>.get_Current
	|-Queue.Enumerator<GraphUpdateProcessor.GUOSingle>.get_Current
	|
	|-RVA: 0x1671200 Offset: 0x166FC00 VA: 0x181671200
	|-Queue.Enumerator<ushort>.get_Current
	|
	|-RVA: 0x167B240 Offset: 0x1679C40 VA: 0x18167B240
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1665ED0 Offset: 0x16648D0 VA: 0x181665ED0
	|-Queue.Enumerator<ValueTuple<IntPtr, object>>.ThrowEnumerationNotStartedOrEnded
	|-Queue.Enumerator<Int2>.ThrowEnumerationNotStartedOrEnded
	|-Queue.Enumerator<Int3>.ThrowEnumerationNotStartedOrEnded
	|-Queue.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|-Queue.Enumerator<LocalPacket>.ThrowEnumerationNotStartedOrEnded
	|-Queue.Enumerator<LocalPacket>.ThrowEnumerationNotStartedOrEnded
	|-Queue.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|-Queue.Enumerator<Packet>.ThrowEnumerationNotStartedOrEnded
	|-Queue.Enumerator<ushort>.ThrowEnumerationNotStartedOrEnded
	|-Queue.Enumerator<EventDispatcher.EventRecord>.ThrowEnumerationNotStartedOrEnded
	|-Queue.Enumerator<GraphUpdateProcessor.GUOSingle>.ThrowEnumerationNotStartedOrEnded
	|-Queue.Enumerator<NetworkAnimator.ReceivedServerData>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x1678F40 Offset: 0x1677940 VA: 0x181678F40
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16647D0 Offset: 0x16631D0 VA: 0x1816647D0
	|-Queue.Enumerator<ValueTuple<IntPtr, object>>.System.Collections.IEnumerator.get_Current
	|-Queue.Enumerator<LocalPacket>.System.Collections.IEnumerator.get_Current
	|-Queue.Enumerator<LocalPacket>.System.Collections.IEnumerator.get_Current
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.get_Current
	|-Queue.Enumerator<NetworkAnimator.ReceivedServerData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166A930 Offset: 0x1669330 VA: 0x18166A930
	|-Queue.Enumerator<Int2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166AAF0 Offset: 0x16694F0 VA: 0x18166AAF0
	|-Queue.Enumerator<Int3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166B7A0 Offset: 0x166A1A0 VA: 0x18166B7A0
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166A360 Offset: 0x1668D60 VA: 0x18166A360
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166AED0 Offset: 0x16698D0 VA: 0x18166AED0
	|-Queue.Enumerator<Packet>.System.Collections.IEnumerator.get_Current
	|-Queue.Enumerator<GraphUpdateProcessor.GUOSingle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166F1E0 Offset: 0x166DBE0 VA: 0x18166F1E0
	|-Queue.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110C2B0 Offset: 0x110ACB0 VA: 0x18110C2B0
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1663ED0 Offset: 0x16628D0 VA: 0x181663ED0
	|-Queue.Enumerator<ValueTuple<IntPtr, object>>.System.Collections.IEnumerator.Reset
	|-Queue.Enumerator<LocalPacket>.System.Collections.IEnumerator.Reset
	|-Queue.Enumerator<LocalPacket>.System.Collections.IEnumerator.Reset
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.Reset
	|-Queue.Enumerator<NetworkAnimator.ReceivedServerData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x16698A0 Offset: 0x16682A0 VA: 0x1816698A0
	|-Queue.Enumerator<Int2>.System.Collections.IEnumerator.Reset
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1669C40 Offset: 0x1668640 VA: 0x181669C40
	|-Queue.Enumerator<Int3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1669A00 Offset: 0x1668400 VA: 0x181669A00
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1669660 Offset: 0x1668060 VA: 0x181669660
	|-Queue.Enumerator<Packet>.System.Collections.IEnumerator.Reset
	|-Queue.Enumerator<GraphUpdateProcessor.GUOSingle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x166E9C0 Offset: 0x166D3C0 VA: 0x18166E9C0
	|-Queue.Enumerator<ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1676940 Offset: 0x1675340 VA: 0x181676940
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}
