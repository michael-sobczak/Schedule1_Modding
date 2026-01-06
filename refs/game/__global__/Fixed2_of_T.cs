internal struct Fixed2<T> // TypeDefIndex: 8903
{
	// Fields
	public T item1; // 0x0
	public T item2; // 0x0

	// Properties
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T item1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C6A90 Offset: 0x17C5490 VA: 0x1817C6A90
	|-Fixed2<float>..ctor
	|
	|-RVA: 0x17C6C60 Offset: 0x17C5660 VA: 0x1817C6C60
	|-Fixed2<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x17C6D90 Offset: 0x17C5790 VA: 0x1817C6D90
	|-Fixed2<float4>..ctor
	|
	|-RVA: 0x17C6DD0 Offset: 0x17C57D0 VA: 0x1817C6DD0
	|-Fixed2<float4x4>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T item1, T item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B38F0 Offset: 0x7B22F0 VA: 0x1807B38F0
	|-Fixed2<float>..ctor
	|
	|-RVA: 0x17C6AD0 Offset: 0x17C54D0 VA: 0x1817C6AD0
	|-Fixed2<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x1330B70 Offset: 0x132F570 VA: 0x181330B70
	|-Fixed2<float4>..ctor
	|
	|-RVA: 0x17C6C10 Offset: 0x17C5610 VA: 0x1817C6C10
	|-Fixed2<float4x4>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6CE40 Offset: 0xF6B840 VA: 0x180F6CE40
	|-Fixed2<float>.get_Item
	|
	|-RVA: 0x17C6E40 Offset: 0x17C5840 VA: 0x1817C6E40
	|-Fixed2<__Il2CppFullySharedGenericStructType>.get_Item
	|
	|-RVA: 0xF6CB90 Offset: 0xF6B590 VA: 0x180F6CB90
	|-Fixed2<float4>.get_Item
	|
	|-RVA: 0xF6CD50 Offset: 0xF6B750 VA: 0x180F6CD50
	|-Fixed2<float4x4>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF73260 Offset: 0xF71C60 VA: 0x180F73260
	|-Fixed2<float>.set_Item
	|
	|-RVA: 0x17C6F20 Offset: 0x17C5920 VA: 0x1817C6F20
	|-Fixed2<__Il2CppFullySharedGenericStructType>.set_Item
	|
	|-RVA: 0xF72E70 Offset: 0xF71870 VA: 0x180F72E70
	|-Fixed2<float4>.set_Item
	|
	|-RVA: 0xF73180 Offset: 0xF71B80 VA: 0x180F73180
	|-Fixed2<float4x4>.set_Item
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void CheckRange(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-Fixed2<float>.CheckRange
	|-Fixed2<__Il2CppFullySharedGenericStructType>.CheckRange
	|-Fixed2<float4>.CheckRange
	|-Fixed2<float4x4>.CheckRange
	*/
}
