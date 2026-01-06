internal struct ValueListBuilder<T> // TypeDefIndex: 9870
{
	// Fields
	private Span<T> _span; // 0x0
	private T[] _arrayFromPool; // 0x0
	private int _pos; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Span<T> initialSpan) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13175B0 Offset: 0x1315FB0 VA: 0x1813175B0
	|-ValueListBuilder<int>..ctor
	|-ValueListBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	|-ValueListBuilder<int>.get_Length
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13175C0 Offset: 0x1315FC0 VA: 0x1813175C0
	|-ValueListBuilder<int>.get_Item
	|
	|-RVA: 0x13175E0 Offset: 0x1315FE0 VA: 0x1813175E0
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void Append(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1316570 Offset: 0x1314F70 VA: 0x181316570
	|-ValueListBuilder<int>.Append
	|
	|-RVA: 0x1316690 Offset: 0x1315090 VA: 0x181316690
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Append
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> AsSpan() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13169B0 Offset: 0x13153B0 VA: 0x1813169B0
	|-ValueListBuilder<int>.AsSpan
	|
	|-RVA: 0x13168A0 Offset: 0x13152A0 VA: 0x1813168A0
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.AsSpan
	*/

	// RVA: -1 Offset: -1
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1316B80 Offset: 0x1315580 VA: 0x181316B80
	|-ValueListBuilder<int>.Dispose
	|
	|-RVA: 0x1316A90 Offset: 0x1315490 VA: 0x181316A90
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	private void Grow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1316F50 Offset: 0x1315950 VA: 0x181316F50
	|-ValueListBuilder<int>.Grow
	|
	|-RVA: 0x1317170 Offset: 0x1315B70 VA: 0x181317170
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Grow
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317480 Offset: 0x1315E80 VA: 0x181317480
	|-ValueListBuilder<int>.Pop
	|
	|-RVA: 0x13174B0 Offset: 0x1315EB0 VA: 0x1813174B0
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Pop
	*/
}
