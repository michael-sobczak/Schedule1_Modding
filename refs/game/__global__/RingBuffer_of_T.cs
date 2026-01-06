public class RingBuffer<T> // TypeDefIndex: 18200
{
	// Fields
	[CompilerGenerated]
	private int <WriteIndex>k__BackingField; // 0x0
	public T[] Collection; // 0x0
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x0
	private int _written; // 0x0
	private RingBuffer.Enumerator<T> _enumerator; // 0x0

	// Properties
	public int WriteIndex { get; set; }
	public int Count { get; }
	public int Capacity { get; }
	public bool Initialized { get; set; }
	public T Item { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_WriteIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AB8B0 Offset: 0x11AA2B0 VA: 0x1811AB8B0
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_WriteIndex
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_WriteIndex(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AE8B0 Offset: 0x11AD2B0 VA: 0x1811AE8B0
	|-RingBuffer<__Il2CppFullySharedGenericType>.set_WriteIndex
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AE020 Offset: 0x11ACA20 VA: 0x1811AE020
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ADFC0 Offset: 0x11AC9C0 VA: 0x1811ADFC0
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_Initialized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AE050 Offset: 0x11ACA50 VA: 0x1811AE050
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Initialized
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Initialized(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AE400 Offset: 0x11ACE00 VA: 0x1811AE400
	|-RingBuffer<__Il2CppFullySharedGenericType>.set_Initialized
	*/

	// RVA: -1 Offset: -1
	public void Initialize(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ACE60 Offset: 0x11AB860 VA: 0x1811ACE60
	|-RingBuffer<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AC4A0 Offset: 0x11AAEA0 VA: 0x1811AC4A0
	|-RingBuffer<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ADDD0 Offset: 0x11AC7D0 VA: 0x1811ADDD0
	|-RingBuffer<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public T Add(T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AC150 Offset: 0x11AAB50 VA: 0x1811AC150
	|-RingBuffer<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int simulatedIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AE210 Offset: 0x11ACC10 VA: 0x1811AE210
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int simulatedIndex, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AE4F0 Offset: 0x11ACEF0 VA: 0x1811AE4F0
	|-RingBuffer<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	private void IncreaseWritten() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ACC60 Offset: 0x11AB660 VA: 0x1811ACC60
	|-RingBuffer<__Il2CppFullySharedGenericType>.IncreaseWritten
	*/

	// RVA: -1 Offset: -1
	private int GetRealIndex(int simulatedIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ACB80 Offset: 0x11AB580 VA: 0x1811ACB80
	|-RingBuffer<__Il2CppFullySharedGenericType>.GetRealIndex
	*/

	// RVA: -1 Offset: -1
	public RingBuffer.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AC740 Offset: 0x11AB140 VA: 0x1811AC740
	|-RingBuffer<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(bool fromStart, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AD6E0 Offset: 0x11AC0E0 VA: 0x1811AD6E0
	|-RingBuffer<__Il2CppFullySharedGenericType>.RemoveRange
	*/

	// RVA: -1 Offset: -1
	private bool IsInitializedWithError() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AD490 Offset: 0x11ABE90 VA: 0x1811AD490
	|-RingBuffer<__Il2CppFullySharedGenericType>.IsInitializedWithError
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ADF20 Offset: 0x11AC920 VA: 0x1811ADF20
	|-RingBuffer<__Il2CppFullySharedGenericType>..ctor
	*/
}
