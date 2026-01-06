private class ReadOnlyCollectionBuilder.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 15607
{
	// Fields
	private readonly ReadOnlyCollectionBuilder<T> _builder; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ReadOnlyCollectionBuilder<T> builder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166BDC0 Offset: 0x166A7C0 VA: 0x18166BDC0
	|-ReadOnlyCollectionBuilder.Enumerator<object>..ctor
	|
	|-RVA: 0x167A3D0 Offset: 0x1678DD0 VA: 0x18167A3D0
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	|-ReadOnlyCollectionBuilder.Enumerator<object>.get_Current
	|
	|-RVA: 0x11C9720 Offset: 0x11C8120 VA: 0x1811C9720
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-ReadOnlyCollectionBuilder.Enumerator<object>.Dispose
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1669D70 Offset: 0x1668770 VA: 0x181669D70
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1678B30 Offset: 0x1677530 VA: 0x181678B30
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1668AE0 Offset: 0x16674E0 VA: 0x181668AE0
	|-ReadOnlyCollectionBuilder.Enumerator<object>.MoveNext
	|
	|-RVA: 0x1674310 Offset: 0x1672D10 VA: 0x181674310
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1669BF0 Offset: 0x16685F0 VA: 0x181669BF0
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1677200 Offset: 0x1675C00 VA: 0x181677200
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}
