public struct RingBuffer.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 18199
{
	// Fields
	[CompilerGenerated]
	private T <Current>k__BackingField; // 0x0
	private RingBuffer<T> _rollingCollection; // 0x0
	private readonly T[] _collection; // 0x0
	private int _read; // 0x0
	private int _startIndex; // 0x0

	// Properties
	public T Current { get; set; }
	public int ActualIndex { get; }
	public int SimulatedIndex { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C5950 Offset: 0x13C4350 VA: 0x1813C5950
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Current(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x167C3E0 Offset: 0x167ADE0 VA: 0x18167C3E0
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>.set_Current
	*/

	// RVA: -1 Offset: -1
	public int get_ActualIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x167AC30 Offset: 0x1679630 VA: 0x18167AC30
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>.get_ActualIndex
	*/

	// RVA: -1 Offset: -1
	public int get_SimulatedIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x167C390 Offset: 0x167AD90 VA: 0x18167C390
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>.get_SimulatedIndex
	*/

	// RVA: -1 Offset: -1
	public void .ctor(RingBuffer<T> c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1679F10 Offset: 0x1678910 VA: 0x181679F10
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1673480 Offset: 0x1671E80 VA: 0x181673480
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	public void SetStartIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16763E0 Offset: 0x1674DE0 VA: 0x1816763E0
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>.SetStartIndex
	*/

	// RVA: -1 Offset: -1
	public void AddStartIndex(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16717D0 Offset: 0x16701D0 VA: 0x1816717D0
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>.AddStartIndex
	*/

	// RVA: -1 Offset: -1
	public void ResetRead() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1675FB0 Offset: 0x16749B0 VA: 0x181675FB0
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>.ResetRead
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16760B0 Offset: 0x1674AB0 VA: 0x1816760B0
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1678000 Offset: 0x1676A00 VA: 0x181678000
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-RingBuffer.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/
}
