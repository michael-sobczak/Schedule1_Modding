internal class MinimumBinaryHeap<T> : MinimumBinaryHeap // TypeDefIndex: 19240
{
	// Fields
	private readonly object m_Lock; // 0x0
	private readonly IComparer<T> m_Comparer; // 0x0
	private readonly int m_MinimumCapacity; // 0x0
	private T[] m_HeapArray; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	public int Count { get; set; }
	public T Min { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	|-MinimumBinaryHeap<object>.get_Count
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	|-MinimumBinaryHeap<object>.set_Count
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.set_Count
	*/

	// RVA: -1 Offset: -1
	public T get_Min() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10628D0 Offset: 0x10612D0 VA: 0x1810628D0
	|-MinimumBinaryHeap<object>.get_Min
	|
	|-RVA: 0x1062900 Offset: 0x1061300 VA: 0x181062900
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.get_Min
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<T> comparer, int minimumCapacity = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10624A0 Offset: 0x1060EA0 VA: 0x1810624A0
	|-MinimumBinaryHeap<object>..ctor
	|
	|-RVA: 0x1062470 Offset: 0x1060E70 VA: 0x181062470
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(ICollection<T> collection, IComparer<T> comparer, int minimumCapacity = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10624D0 Offset: 0x1060ED0 VA: 0x1810624D0
	|-MinimumBinaryHeap<object>..ctor
	|
	|-RVA: 0x1061F20 Offset: 0x1060920 VA: 0x181061F20
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Insert(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1060F00 Offset: 0x105F900 VA: 0x181060F00
	|-MinimumBinaryHeap<object>.Insert
	|
	|-RVA: 0x1060A00 Offset: 0x105F400 VA: 0x181060A00
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	private void IncreaseHeapCapacityWhenFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1060680 Offset: 0x105F080 VA: 0x181060680
	|-MinimumBinaryHeap<object>.IncreaseHeapCapacityWhenFull
	|
	|-RVA: 0x1060530 Offset: 0x105EF30 VA: 0x181060530
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.IncreaseHeapCapacityWhenFull
	*/

	// RVA: -1 Offset: -1
	public void Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1061480 Offset: 0x105FE80 VA: 0x181061480
	|-MinimumBinaryHeap<object>.Remove
	|
	|-RVA: 0x1061660 Offset: 0x1060060 VA: 0x181061660
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	private int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1060770 Offset: 0x105F170 VA: 0x181060770
	|-MinimumBinaryHeap<object>.IndexOf
	|
	|-RVA: 0x1060800 Offset: 0x105F200 VA: 0x181060800
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public T ExtractMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1060100 Offset: 0x105EB00 VA: 0x181060100
	|-MinimumBinaryHeap<object>.ExtractMin
	|
	|-RVA: 0x105FB20 Offset: 0x105E520 VA: 0x18105FB20
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.ExtractMin
	*/

	// RVA: -1 Offset: -1
	private void DecreaseHeapCapacityWhenSpare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105FA30 Offset: 0x105E430 VA: 0x18105FA30
	|-MinimumBinaryHeap<object>.DecreaseHeapCapacityWhenSpare
	|
	|-RVA: 0x105F8C0 Offset: 0x105E2C0 VA: 0x18105F8C0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.DecreaseHeapCapacityWhenSpare
	*/

	// RVA: -1 Offset: -1
	private void MinHeapify() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1061260 Offset: 0x105FC60 VA: 0x181061260
	|-MinimumBinaryHeap<object>.MinHeapify
	|
	|-RVA: 0x1061390 Offset: 0x105FD90 VA: 0x181061390
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.MinHeapify
	*/

	// RVA: -1 Offset: -1
	private static void Swap(ref T lhs, ref T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4B9E0 Offset: 0xE4A3E0 VA: 0x180E4B9E0
	|-MinimumBinaryHeap<object>.Swap
	|
	|-RVA: 0x1061910 Offset: 0x1060310 VA: 0x181061910
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1
	private static int GetParentIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1060510 Offset: 0x105EF10 VA: 0x181060510
	|-MinimumBinaryHeap<object>.GetParentIndex
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetParentIndex
	*/

	// RVA: -1 Offset: -1
	private static int GetLeftChildIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1060500 Offset: 0x105EF00 VA: 0x181060500
	|-MinimumBinaryHeap<object>.GetLeftChildIndex
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetLeftChildIndex
	*/

	// RVA: -1 Offset: -1
	private static int GetRightChildIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1060520 Offset: 0x105EF20 VA: 0x181060520
	|-MinimumBinaryHeap<object>.GetRightChildIndex
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetRightChildIndex
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <MinHeapify>g__UpdateSmallestIndex|21_0(ref MinimumBinaryHeap.<>c__DisplayClass21_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1061EA0 Offset: 0x10608A0 VA: 0x181061EA0
	|-MinimumBinaryHeap<object>.<MinHeapify>g__UpdateSmallestIndex|21_0
	|
	|-RVA: 0x1061DC0 Offset: 0x10607C0 VA: 0x181061DC0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.<MinHeapify>g__UpdateSmallestIndex|21_0
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(int candidate, ref MinimumBinaryHeap.<>c__DisplayClass21_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1061B50 Offset: 0x1060550 VA: 0x181061B50
	|-MinimumBinaryHeap<object>.<MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1
	|
	|-RVA: 0x1061C10 Offset: 0x1060610 VA: 0x181061C10
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.<MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1
	*/
}
