public class BasicQueue<T> // TypeDefIndex: 12485
{
	// Fields
	private T[] Collection; // 0x0
	[CompilerGenerated]
	private int <WriteIndex>k__BackingField; // 0x0
	private T[] _resizeBuffer; // 0x0
	private int _read; // 0x0
	private int _written; // 0x0

	// Properties
	public int Capacity { get; }
	public int Count { get; }
	public int WriteIndex { get; set; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-BasicQueue<__Il2CppFullySharedGenericType>.get_Capacity
	|-BasicQueue<RigidbodyPrediction.MoveData>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	|-BasicQueue<__Il2CppFullySharedGenericType>.get_Count
	|-BasicQueue<RigidbodyPrediction.MoveData>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_WriteIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	|-BasicQueue<__Il2CppFullySharedGenericType>.get_WriteIndex
	|-BasicQueue<RigidbodyPrediction.MoveData>.get_WriteIndex
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_WriteIndex(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	|-BasicQueue<__Il2CppFullySharedGenericType>.set_WriteIndex
	|-BasicQueue<RigidbodyPrediction.MoveData>.set_WriteIndex
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1426A20 Offset: 0x1425420 VA: 0x181426A20
	|-BasicQueue<__Il2CppFullySharedGenericType>.Enqueue
	|
	|-RVA: 0x1426C20 Offset: 0x1425620 VA: 0x181426C20
	|-BasicQueue<RigidbodyPrediction.MoveData>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14271E0 Offset: 0x1425BE0 VA: 0x1814271E0
	|-BasicQueue<__Il2CppFullySharedGenericType>.TryDequeue
	|
	|-RVA: 0x14272D0 Offset: 0x1425CD0 VA: 0x1814272D0
	|-BasicQueue<RigidbodyPrediction.MoveData>.TryDequeue
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14267F0 Offset: 0x14251F0 VA: 0x1814267F0
	|-BasicQueue<__Il2CppFullySharedGenericType>.Dequeue
	|
	|-RVA: 0x14266B0 Offset: 0x14250B0 VA: 0x1814266B0
	|-BasicQueue<RigidbodyPrediction.MoveData>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public bool TryPeek(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427340 Offset: 0x1425D40 VA: 0x181427340
	|-BasicQueue<__Il2CppFullySharedGenericType>.TryPeek
	|
	|-RVA: 0x1427430 Offset: 0x1425E30 VA: 0x181427430
	|-BasicQueue<RigidbodyPrediction.MoveData>.TryPeek
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1426E90 Offset: 0x1425890 VA: 0x181426E90
	|-BasicQueue<__Il2CppFullySharedGenericType>.Peek
	|
	|-RVA: 0x1426D70 Offset: 0x1425770 VA: 0x181426D70
	|-BasicQueue<RigidbodyPrediction.MoveData>.Peek
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1426640 Offset: 0x1425040 VA: 0x181426640
	|-BasicQueue<__Il2CppFullySharedGenericType>.Clear
	|
	|-RVA: 0x14265A0 Offset: 0x1424FA0 VA: 0x1814265A0
	|-BasicQueue<RigidbodyPrediction.MoveData>.Clear
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427010 Offset: 0x1425A10 VA: 0x181427010
	|-BasicQueue<__Il2CppFullySharedGenericType>.Resize
	|
	|-RVA: 0x1427100 Offset: 0x1425B00 VA: 0x181427100
	|-BasicQueue<RigidbodyPrediction.MoveData>.Resize
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int simulatedIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427770 Offset: 0x1426170 VA: 0x181427770
	|-BasicQueue<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x1427710 Offset: 0x1426110 VA: 0x181427710
	|-BasicQueue<RigidbodyPrediction.MoveData>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int simulatedIndex, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427910 Offset: 0x1426310 VA: 0x181427910
	|-BasicQueue<__Il2CppFullySharedGenericType>.set_Item
	|
	|-RVA: 0x14278C0 Offset: 0x14262C0 VA: 0x1814278C0
	|-BasicQueue<RigidbodyPrediction.MoveData>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427670 Offset: 0x1426070 VA: 0x181427670
	|-BasicQueue<__Il2CppFullySharedGenericType>..ctor
	|-BasicQueue<RigidbodyPrediction.MoveData>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal static void <Clear>g__DefaultCollection|17_0(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427480 Offset: 0x1425E80 VA: 0x181427480
	|-BasicQueue<__Il2CppFullySharedGenericType>.<Clear>g__DefaultCollection|17_0
	|
	|-RVA: 0x1427620 Offset: 0x1426020 VA: 0x181427620
	|-BasicQueue<RigidbodyPrediction.MoveData>.<Clear>g__DefaultCollection|17_0
	*/
}
