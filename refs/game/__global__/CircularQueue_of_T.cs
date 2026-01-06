public class CircularQueue<T> // TypeDefIndex: 24
{
	// Fields
	public NativeArray<T> q; // 0x0
	private int idx; // 0x0
	private int cap; // 0x0
	private int length; // 0x0

	// Properties
	public T Item { get; }
	public int Capacity { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14405D0 Offset: 0x143EFD0 VA: 0x1814405D0
	|-CircularQueue<bool>..ctor
	|
	|-RVA: 0x1440650 Offset: 0x143F050 VA: 0x181440650
	|-CircularQueue<Vector3>..ctor
	|
	|-RVA: 0x1440550 Offset: 0x143EF50 VA: 0x181440550
	|-CircularQueue<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14406D0 Offset: 0x143F0D0 VA: 0x1814406D0
	|-CircularQueue<bool>.get_Item
	|
	|-RVA: 0x14407A0 Offset: 0x143F1A0 VA: 0x1814407A0
	|-CircularQueue<Vector3>.get_Item
	|
	|-RVA: 0x14406E0 Offset: 0x143F0E0 VA: 0x1814406E0
	|-CircularQueue<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	|-CircularQueue<bool>.get_Capacity
	|-CircularQueue<Vector3>.get_Capacity
	|-CircularQueue<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	|-CircularQueue<bool>.get_Count
	|-CircularQueue<Vector3>.get_Count
	|-CircularQueue<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1440410 Offset: 0x143EE10 VA: 0x181440410
	|-CircularQueue<bool>.Enqueue
	|
	|-RVA: 0x14403C0 Offset: 0x143EDC0 VA: 0x1814403C0
	|-CircularQueue<Vector3>.Enqueue
	|
	|-RVA: 0x1440450 Offset: 0x143EE50 VA: 0x181440450
	|-CircularQueue<__Il2CppFullySharedGenericStructType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public void Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1440380 Offset: 0x143ED80 VA: 0x181440380
	|-CircularQueue<bool>.Dequeue
	|
	|-RVA: 0x1440320 Offset: 0x143ED20 VA: 0x181440320
	|-CircularQueue<Vector3>.Dequeue
	|
	|-RVA: 0x14401E0 Offset: 0x143EBE0 VA: 0x1814401E0
	|-CircularQueue<__Il2CppFullySharedGenericStructType>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1440060 Offset: 0x143EA60 VA: 0x181440060
	|-CircularQueue<bool>.Clear
	|
	|-RVA: 0x14400E0 Offset: 0x143EAE0 VA: 0x1814400E0
	|-CircularQueue<Vector3>.Clear
	|
	|-RVA: 0x1440160 Offset: 0x143EB60 VA: 0x181440160
	|-CircularQueue<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	private int modulo(int i, int m) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14407D0 Offset: 0x143F1D0 VA: 0x1814407D0
	|-CircularQueue<bool>.modulo
	|-CircularQueue<Vector3>.modulo
	|-CircularQueue<__Il2CppFullySharedGenericStructType>.modulo
	*/
}
