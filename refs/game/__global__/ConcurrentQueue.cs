private sealed class ConcurrentQueue.<Enumerate>d__28<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 4941
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public ConcurrentQueue.Segment<T> head; // 0x0
	public ConcurrentQueue.Segment<T> tail; // 0x0
	public int tailTail; // 0x0
	public int headHead; // 0x0
	public ConcurrentQueue<T> <>4__this; // 0x0
	private int <headTail>5__2; // 0x0
	private int <i>5__3; // 0x0
	private ConcurrentQueue.Segment<T> <s>5__4; // 0x0
	private int <i>5__5; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	|-ConcurrentQueue.<Enumerate>d__28<ByteEnum>..ctor
	|-ConcurrentQueue.<Enumerate>d__28<int>..ctor
	|-ConcurrentQueue.<Enumerate>d__28<LocalPacket>..ctor
	|-ConcurrentQueue.<Enumerate>d__28<object>..ctor
	|-ConcurrentQueue.<Enumerate>d__28<Packet>..ctor
	|-ConcurrentQueue.<Enumerate>d__28<RemoteConnectionEvent>..ctor
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.RequestEventData>..ctor
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.SuccessEventData>..ctor
	|
	|-RVA: 0xFD0750 Offset: 0xFCF150 VA: 0x180FD0750
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-ConcurrentQueue.<Enumerate>d__28<ByteEnum>.System.IDisposable.Dispose
	|-ConcurrentQueue.<Enumerate>d__28<int>.System.IDisposable.Dispose
	|-ConcurrentQueue.<Enumerate>d__28<LocalPacket>.System.IDisposable.Dispose
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.IDisposable.Dispose
	|-ConcurrentQueue.<Enumerate>d__28<Packet>.System.IDisposable.Dispose
	|-ConcurrentQueue.<Enumerate>d__28<RemoteConnectionEvent>.System.IDisposable.Dispose
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.RequestEventData>.System.IDisposable.Dispose
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.SuccessEventData>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCF5E0 Offset: 0xFCDFE0 VA: 0x180FCF5E0
	|-ConcurrentQueue.<Enumerate>d__28<ByteEnum>.MoveNext
	|
	|-RVA: 0xFCFD40 Offset: 0xFCE740 VA: 0x180FCFD40
	|-ConcurrentQueue.<Enumerate>d__28<int>.MoveNext
	|
	|-RVA: 0xFCF940 Offset: 0xFCE340 VA: 0x180FCF940
	|-ConcurrentQueue.<Enumerate>d__28<LocalPacket>.MoveNext
	|
	|-RVA: 0xFCE2A0 Offset: 0xFCCCA0 VA: 0x180FCE2A0
	|-ConcurrentQueue.<Enumerate>d__28<object>.MoveNext
	|
	|-RVA: 0xFCDE60 Offset: 0xFCC860 VA: 0x180FCDE60
	|-ConcurrentQueue.<Enumerate>d__28<Packet>.MoveNext
	|
	|-RVA: 0xFCDAF0 Offset: 0xFCC4F0 VA: 0x180FCDAF0
	|-ConcurrentQueue.<Enumerate>d__28<RemoteConnectionEvent>.MoveNext
	|
	|-RVA: 0xFCE650 Offset: 0xFCD050 VA: 0x180FCE650
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0xFD00A0 Offset: 0xFCEAA0 VA: 0x180FD00A0
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.RequestEventData>.MoveNext
	|
	|-RVA: 0xFE3380 Offset: 0xFE1D80 VA: 0x180FE3380
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.SuccessEventData>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	|-ConcurrentQueue.<Enumerate>d__28<ByteEnum>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	|-ConcurrentQueue.<Enumerate>d__28<int>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	|-ConcurrentQueue.<Enumerate>d__28<LocalPacket>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x49D250 Offset: 0x49BC50 VA: 0x18049D250
	|-ConcurrentQueue.<Enumerate>d__28<Packet>.System.Collections.Generic.IEnumerator<T>.get_Current
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.RequestEventData>.System.Collections.Generic.IEnumerator<T>.get_Current
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.SuccessEventData>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0xFD0590 Offset: 0xFCEF90 VA: 0x180FD0590
	|-ConcurrentQueue.<Enumerate>d__28<RemoteConnectionEvent>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0xFD04E0 Offset: 0xFCEEE0 VA: 0x180FD04E0
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC9ED0 Offset: 0xFC88D0 VA: 0x180FC9ED0
	|-ConcurrentQueue.<Enumerate>d__28<ByteEnum>.System.Collections.IEnumerator.Reset
	|-ConcurrentQueue.<Enumerate>d__28<int>.System.Collections.IEnumerator.Reset
	|-ConcurrentQueue.<Enumerate>d__28<LocalPacket>.System.Collections.IEnumerator.Reset
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.Collections.IEnumerator.Reset
	|-ConcurrentQueue.<Enumerate>d__28<Packet>.System.Collections.IEnumerator.Reset
	|-ConcurrentQueue.<Enumerate>d__28<RemoteConnectionEvent>.System.Collections.IEnumerator.Reset
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.RequestEventData>.System.Collections.IEnumerator.Reset
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.SuccessEventData>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD06F0 Offset: 0xFCF0F0 VA: 0x180FD06F0
	|-ConcurrentQueue.<Enumerate>d__28<ByteEnum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFD0720 Offset: 0xFCF120 VA: 0x180FD0720
	|-ConcurrentQueue.<Enumerate>d__28<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFD0650 Offset: 0xFCF050 VA: 0x180FD0650
	|-ConcurrentQueue.<Enumerate>d__28<LocalPacket>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFD0680 Offset: 0xFCF080 VA: 0x180FD0680
	|-ConcurrentQueue.<Enumerate>d__28<Packet>.System.Collections.IEnumerator.get_Current
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.RequestEventData>.System.Collections.IEnumerator.get_Current
	|-ConcurrentQueue.<Enumerate>d__28<NatPunchModule.SuccessEventData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFD06C0 Offset: 0xFCF0C0 VA: 0x180FD06C0
	|-ConcurrentQueue.<Enumerate>d__28<RemoteConnectionEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFD05A0 Offset: 0xFCEFA0 VA: 0x180FD05A0
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}
