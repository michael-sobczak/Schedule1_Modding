public class DynamicArray<T> // TypeDefIndex: 13573
{
	// Fields
	private T[] m_Array; // 0x0
	[CompilerGenerated]
	private int <size>k__BackingField; // 0x0

	// Properties
	public int size { get; set; }
	public int capacity { get; }
	public T Item { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_size() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	|-DynamicArray<object>.get_size
	|-DynamicArray<RendererListResource>.get_size
	|-DynamicArray<__Il2CppFullySharedGenericType>.get_size
	|-DynamicArray<RenderGraph.CompiledPassInfo>.get_size
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.get_size
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_size(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	|-DynamicArray<object>.set_size
	|-DynamicArray<RendererListResource>.set_size
	|-DynamicArray<__Il2CppFullySharedGenericType>.set_size
	|-DynamicArray<RenderGraph.CompiledPassInfo>.set_size
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.set_size
	*/

	// RVA: -1 Offset: -1
	public int get_capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-DynamicArray<object>.get_capacity
	|-DynamicArray<RendererListResource>.get_capacity
	|-DynamicArray<__Il2CppFullySharedGenericType>.get_capacity
	|-DynamicArray<RenderGraph.CompiledPassInfo>.get_capacity
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.get_capacity
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1634A10 Offset: 0x1633410 VA: 0x181634A10
	|-DynamicArray<object>..ctor
	|-DynamicArray<RendererListResource>..ctor
	|-DynamicArray<RenderGraph.CompiledPassInfo>..ctor
	|-DynamicArray<RenderGraph.CompiledResourceInfo>..ctor
	|
	|-RVA: 0x1634AF0 Offset: 0x16334F0 VA: 0x181634AF0
	|-DynamicArray<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1634A80 Offset: 0x1633480 VA: 0x181634A80
	|-DynamicArray<object>..ctor
	|-DynamicArray<RendererListResource>..ctor
	|-DynamicArray<RenderGraph.CompiledPassInfo>..ctor
	|-DynamicArray<RenderGraph.CompiledResourceInfo>..ctor
	|
	|-RVA: 0x1634B70 Offset: 0x1633570 VA: 0x181634B70
	|-DynamicArray<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB890 Offset: 0xBCA290 VA: 0x180BCB890
	|-DynamicArray<object>.Clear
	|-DynamicArray<RendererListResource>.Clear
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Clear
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Clear
	|
	|-RVA: 0x16321D0 Offset: 0x1630BD0 VA: 0x1816321D0
	|-DynamicArray<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16322D0 Offset: 0x1630CD0 VA: 0x1816322D0
	|-DynamicArray<object>.Contains
	|
	|-RVA: 0x16323A0 Offset: 0x1630DA0 VA: 0x1816323A0
	|-DynamicArray<RendererListResource>.Contains
	|
	|-RVA: 0x16321F0 Offset: 0x1630BF0 VA: 0x1816321F0
	|-DynamicArray<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x1632340 Offset: 0x1630D40 VA: 0x181632340
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Contains
	|
	|-RVA: 0x1632300 Offset: 0x1630D00 VA: 0x181632300
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Contains
	*/

	// RVA: -1 Offset: -1
	public int Add(in T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1631E90 Offset: 0x1630890 VA: 0x181631E90
	|-DynamicArray<object>.Add
	|
	|-RVA: 0x1632060 Offset: 0x1630A60 VA: 0x181632060
	|-DynamicArray<RendererListResource>.Add
	|
	|-RVA: 0x1631B80 Offset: 0x1630580 VA: 0x181631B80
	|-DynamicArray<__Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0x1631D70 Offset: 0x1630770 VA: 0x181631D70
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Add
	|
	|-RVA: 0x1631F70 Offset: 0x1630970 VA: 0x181631F70
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(DynamicArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1631A60 Offset: 0x1630460 VA: 0x181631A60
	|-DynamicArray<object>.AddRange
	|
	|-RVA: 0x16313A0 Offset: 0x162FDA0 VA: 0x1816313A0
	|-DynamicArray<RendererListResource>.AddRange
	|
	|-RVA: 0x16316D0 Offset: 0x16300D0 VA: 0x1816316D0
	|-DynamicArray<__Il2CppFullySharedGenericType>.AddRange
	|
	|-RVA: 0x16318F0 Offset: 0x16302F0 VA: 0x1816318F0
	|-DynamicArray<RenderGraph.CompiledPassInfo>.AddRange
	|
	|-RVA: 0x1631590 Offset: 0x162FF90 VA: 0x181631590
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.AddRange
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1634560 Offset: 0x1632F60 VA: 0x181634560
	|-DynamicArray<object>.Remove
	|
	|-RVA: 0x16342E0 Offset: 0x1632CE0 VA: 0x1816342E0
	|-DynamicArray<RendererListResource>.Remove
	|
	|-RVA: 0x1634700 Offset: 0x1633100 VA: 0x181634700
	|-DynamicArray<__Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0x1634450 Offset: 0x1632E50 VA: 0x181634450
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Remove
	|
	|-RVA: 0x1634620 Offset: 0x1633020 VA: 0x181634620
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1633F00 Offset: 0x1632900 VA: 0x181633F00
	|-DynamicArray<object>.RemoveAt
	|-DynamicArray<RendererListResource>.RemoveAt
	|-DynamicArray<RenderGraph.CompiledPassInfo>.RemoveAt
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.RemoveAt
	|
	|-RVA: 0x1633F90 Offset: 0x1632990 VA: 0x181633F90
	|-DynamicArray<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16340E0 Offset: 0x1632AE0 VA: 0x1816340E0
	|-DynamicArray<object>.RemoveRange
	|-DynamicArray<RendererListResource>.RemoveRange
	|-DynamicArray<RenderGraph.CompiledPassInfo>.RemoveRange
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.RemoveRange
	|
	|-RVA: 0x1634180 Offset: 0x1632B80 VA: 0x181634180
	|-DynamicArray<__Il2CppFullySharedGenericType>.RemoveRange
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1632650 Offset: 0x1631050 VA: 0x181632650
	|-DynamicArray<object>.FindIndex
	|
	|-RVA: 0x1632460 Offset: 0x1630E60 VA: 0x181632460
	|-DynamicArray<RendererListResource>.FindIndex
	|
	|-RVA: 0x16326E0 Offset: 0x16310E0 VA: 0x1816326E0
	|-DynamicArray<__Il2CppFullySharedGenericType>.FindIndex
	|
	|-RVA: 0x1632840 Offset: 0x1631240 VA: 0x181632840
	|-DynamicArray<RenderGraph.CompiledPassInfo>.FindIndex
	|
	|-RVA: 0x16325A0 Offset: 0x1630FA0 VA: 0x1816325A0
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1633C40 Offset: 0x1632640 VA: 0x181633C40
	|-DynamicArray<object>.IndexOf
	|
	|-RVA: 0x1632A70 Offset: 0x1631470 VA: 0x181632A70
	|-DynamicArray<RendererListResource>.IndexOf
	|
	|-RVA: 0x1633260 Offset: 0x1631C60 VA: 0x181633260
	|-DynamicArray<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x1633750 Offset: 0x1632150 VA: 0x181633750
	|-DynamicArray<RenderGraph.CompiledPassInfo>.IndexOf
	|
	|-RVA: 0x1632CB0 Offset: 0x16316B0 VA: 0x181632CB0
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16336B0 Offset: 0x16320B0 VA: 0x1816336B0
	|-DynamicArray<object>.IndexOf
	|
	|-RVA: 0x1633480 Offset: 0x1631E80 VA: 0x181633480
	|-DynamicArray<RendererListResource>.IndexOf
	|
	|-RVA: 0x1633060 Offset: 0x1631A60 VA: 0x181633060
	|-DynamicArray<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x1633D80 Offset: 0x1632780 VA: 0x181633D80
	|-DynamicArray<RenderGraph.CompiledPassInfo>.IndexOf
	|
	|-RVA: 0x1632940 Offset: 0x1631340 VA: 0x181632940
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1633CF0 Offset: 0x16326F0 VA: 0x181633CF0
	|-DynamicArray<object>.IndexOf
	|
	|-RVA: 0x1633A10 Offset: 0x1632410 VA: 0x181633A10
	|-DynamicArray<RendererListResource>.IndexOf
	|
	|-RVA: 0x1632DE0 Offset: 0x16317E0 VA: 0x181632DE0
	|-DynamicArray<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x1632EE0 Offset: 0x16318E0 VA: 0x181632EE0
	|-DynamicArray<RenderGraph.CompiledPassInfo>.IndexOf
	|
	|-RVA: 0x16338E0 Offset: 0x16322E0 VA: 0x1816338E0
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public void Resize(int newSize, bool keepContent = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16348E0 Offset: 0x16332E0 VA: 0x1816348E0
	|-DynamicArray<object>.Resize
	|-DynamicArray<RendererListResource>.Resize
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Resize
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Resize
	|
	|-RVA: 0x1634920 Offset: 0x1633320 VA: 0x181634920
	|-DynamicArray<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	public void Reserve(int newCapacity, bool keepContent = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1634810 Offset: 0x1633210 VA: 0x181634810
	|-DynamicArray<object>.Reserve
	|-DynamicArray<RendererListResource>.Reserve
	|-DynamicArray<__Il2CppFullySharedGenericType>.Reserve
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Reserve
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Reserve
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1634C80 Offset: 0x1633680 VA: 0x181634C80
	|-DynamicArray<object>.get_Item
	|
	|-RVA: 0x1634CF0 Offset: 0x16336F0 VA: 0x181634CF0
	|-DynamicArray<RendererListResource>.get_Item
	|
	|-RVA: 0x1634CB0 Offset: 0x16336B0 VA: 0x181634CB0
	|-DynamicArray<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x1634C00 Offset: 0x1633600 VA: 0x181634C00
	|-DynamicArray<RenderGraph.CompiledPassInfo>.get_Item
	|
	|-RVA: 0x1634C40 Offset: 0x1633640 VA: 0x181634C40
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.get_Item
	*/

	// RVA: -1 Offset: -1
	public static T[] op_Implicit(DynamicArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC85EC0 Offset: 0xC848C0 VA: 0x180C85EC0
	|-DynamicArray<object>.op_Implicit
	|-DynamicArray<RendererListResource>.op_Implicit
	|-DynamicArray<__Il2CppFullySharedGenericType>.op_Implicit
	|-DynamicArray<RenderGraph.CompiledPassInfo>.op_Implicit
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public DynamicArray.Iterator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1632910 Offset: 0x1631310 VA: 0x181632910
	|-DynamicArray<object>.GetEnumerator
	|-DynamicArray<RendererListResource>.GetEnumerator
	|-DynamicArray<__Il2CppFullySharedGenericType>.GetEnumerator
	|-DynamicArray<RenderGraph.CompiledPassInfo>.GetEnumerator
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public DynamicArray.RangeEnumerable<T> SubRange(int first, int numItems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1634990 Offset: 0x1633390 VA: 0x181634990
	|-DynamicArray<object>.SubRange
	|-DynamicArray<RendererListResource>.SubRange
	|-DynamicArray<__Il2CppFullySharedGenericType>.SubRange
	|-DynamicArray<RenderGraph.CompiledPassInfo>.SubRange
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.SubRange
	*/

	// RVA: -1 Offset: -1
	internal void BumpVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-DynamicArray<object>.BumpVersion
	|-DynamicArray<RendererListResource>.BumpVersion
	|-DynamicArray<__Il2CppFullySharedGenericType>.BumpVersion
	|-DynamicArray<RenderGraph.CompiledPassInfo>.BumpVersion
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.BumpVersion
	*/
}
