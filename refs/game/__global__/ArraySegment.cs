public struct ArraySegment.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3596
{
	// Fields
	private readonly T[] _array; // 0x0
	private readonly int _start; // 0x0
	private readonly int _end; // 0x0
	private int _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ArraySegment<T> arraySegment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1666360 Offset: 0x1664D60 VA: 0x181666360
	|-ArraySegment.Enumerator<byte>..ctor
	|-ArraySegment.Enumerator<char>..ctor
	|
	|-RVA: 0x16794B0 Offset: 0x1677EB0 VA: 0x1816794B0
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1662C10 Offset: 0x1661610 VA: 0x181662C10
	|-ArraySegment.Enumerator<byte>.MoveNext
	|-ArraySegment.Enumerator<char>.MoveNext
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1667390 Offset: 0x1665D90 VA: 0x181667390
	|-ArraySegment.Enumerator<byte>.get_Current
	|
	|-RVA: 0x1666D90 Offset: 0x1665790 VA: 0x181666D90
	|-ArraySegment.Enumerator<char>.get_Current
	|
	|-RVA: 0x167AFE0 Offset: 0x16799E0 VA: 0x18167AFE0
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1665C40 Offset: 0x1664640 VA: 0x181665C40
	|-ArraySegment.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1665A70 Offset: 0x1664470 VA: 0x181665A70
	|-ArraySegment.Enumerator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1677AD0 Offset: 0x16764D0 VA: 0x181677AD0
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1664270 Offset: 0x1662C70 VA: 0x181664270
	|-ArraySegment.Enumerator<byte>.System.Collections.IEnumerator.Reset
	|-ArraySegment.Enumerator<char>.System.Collections.IEnumerator.Reset
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-ArraySegment.Enumerator<byte>.Dispose
	|-ArraySegment.Enumerator<char>.Dispose
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/
}
