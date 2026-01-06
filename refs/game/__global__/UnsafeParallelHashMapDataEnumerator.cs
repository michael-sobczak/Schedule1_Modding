internal struct UnsafeParallelHashMapDataEnumerator // TypeDefIndex: 15984
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeParallelHashMapData* m_Buffer; // 0x0
	internal int m_Index; // 0x8
	internal int m_BucketIndex; // 0xC
	internal int m_NextIndex; // 0x10

	// Methods

	// RVA: 0x2740EA0 Offset: 0x273F8A0 VA: 0x182740EA0
	internal void .ctor(UnsafeParallelHashMapData* data) { }

	// RVA: 0x2740DC0 Offset: 0x273F7C0 VA: 0x182740DC0
	internal bool MoveNext() { }

	// RVA: 0x2740E80 Offset: 0x273F880 VA: 0x182740E80
	internal void Reset() { }

	// RVA: -1 Offset: -1
	internal KeyValue<TKey, TValue> GetCurrent<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6ADE0 Offset: 0xF697E0 VA: 0x180F6ADE0
	|-UnsafeParallelHashMapDataEnumerator.GetCurrent<int, int>
	|-UnsafeParallelHashMapDataEnumerator.GetCurrent<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal TKey GetCurrentKey<TKey>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6ACB0 Offset: 0xF696B0 VA: 0x180F6ACB0
	|-UnsafeParallelHashMapDataEnumerator.GetCurrentKey<__Il2CppFullySharedGenericStructType>
	*/
}
