public class RollingAverage<T> // TypeDefIndex: 27
{
	// Fields
	private readonly T[] buffer; // 0x0
	private readonly Func<T, T, T> add; // 0x0
	private readonly Func<T, T, T> sub; // 0x0
	private readonly Func<T, float, T> div; // 0x0
	private int head; // 0x0
	private int count; // 0x0
	private T sum; // 0x0

	// Properties
	public T Average { get; }
	public int Count { get; }
	public int Capacity { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, Func<T, T, T> add, Func<T, T, T> sub, Func<T, float, T> div) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B0600 Offset: 0x11AF000 VA: 0x1811B0600
	|-RollingAverage<float>..ctor
	|
	|-RVA: 0x11B0500 Offset: 0x11AEF00 VA: 0x1811B0500
	|-RollingAverage<Vector3>..ctor
	|
	|-RVA: 0x11B0250 Offset: 0x11AEC50 VA: 0x1811B0250
	|-RollingAverage<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AF550 Offset: 0x11ADF50 VA: 0x1811AF550
	|-RollingAverage<float>.Add
	|
	|-RVA: 0x11AFE90 Offset: 0x11AE890 VA: 0x1811AFE90
	|-RollingAverage<Vector3>.Add
	|
	|-RVA: 0x11AF660 Offset: 0x11AE060 VA: 0x1811AF660
	|-RollingAverage<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T get_Average() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B09B0 Offset: 0x11AF3B0 VA: 0x1811B09B0
	|-RollingAverage<float>.get_Average
	|
	|-RVA: 0x11B0920 Offset: 0x11AF320 VA: 0x1811B0920
	|-RollingAverage<Vector3>.get_Average
	|
	|-RVA: 0x11B0700 Offset: 0x11AF100 VA: 0x1811B0700
	|-RollingAverage<__Il2CppFullySharedGenericType>.get_Average
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	|-RollingAverage<float>.get_Count
	|-RollingAverage<Vector3>.get_Count
	|
	|-RVA: 0x11B0A40 Offset: 0x11AF440 VA: 0x1811B0A40
	|-RollingAverage<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-RollingAverage<float>.get_Capacity
	|-RollingAverage<Vector3>.get_Capacity
	|
	|-RVA: 0x11B0A00 Offset: 0x11AF400 VA: 0x1811B0A00
	|-RollingAverage<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B00A0 Offset: 0x11AEAA0 VA: 0x1811B00A0
	|-RollingAverage<float>.Clear
	|
	|-RVA: 0x11B0060 Offset: 0x11AEA60 VA: 0x1811B0060
	|-RollingAverage<Vector3>.Clear
	|
	|-RVA: 0x11B00E0 Offset: 0x11AEAE0 VA: 0x1811B00E0
	|-RollingAverage<__Il2CppFullySharedGenericType>.Clear
	*/
}
