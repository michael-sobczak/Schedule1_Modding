internal abstract class EnumerableSorter<TElement> // TypeDefIndex: 15076
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void ComputeKeys(TElement[] elements, int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int CompareKeys(int index1, int index2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.CompareKeys
	*/

	// RVA: -1 Offset: -1
	internal int[] Sort(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165FCE0 Offset: 0x165E6E0 VA: 0x18165FCE0
	|-EnumerableSorter<ValueTuple<object, object>>.Sort
	|
	|-RVA: 0x165F7A0 Offset: 0x165E1A0 VA: 0x18165F7A0
	|-EnumerableSorter<CoordinateFootprintTilePair>.Sort
	|
	|-RVA: 0x165F5E0 Offset: 0x165DFE0 VA: 0x18165F5E0
	|-EnumerableSorter<CoordinateStorageFootprintTilePair>.Sort
	|
	|-RVA: 0x165FA40 Offset: 0x165E440 VA: 0x18165FA40
	|-EnumerableSorter<GlyphPairAdjustmentRecord>.Sort
	|
	|-RVA: 0x165FDC0 Offset: 0x165E7C0 VA: 0x18165FDC0
	|-EnumerableSorter<Int32Enum>.Sort
	|
	|-RVA: 0x165FB20 Offset: 0x165E520 VA: 0x18165FB20
	|-EnumerableSorter<Label>.Sort
	|
	|-RVA: 0x165FEA0 Offset: 0x165E8A0 VA: 0x18165FEA0
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.Sort
	|
	|-RVA: 0x165F880 Offset: 0x165E280 VA: 0x18165F880
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.Sort
	|
	|-RVA: 0x165FF80 Offset: 0x165E980 VA: 0x18165FF80
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.Sort
	|
	|-RVA: 0x165F500 Offset: 0x165DF00 VA: 0x18165F500
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.Sort
	|
	|-RVA: 0x165FC00 Offset: 0x165E600 VA: 0x18165FC00
	|-EnumerableSorter<object>.Sort
	|
	|-RVA: 0x165F960 Offset: 0x165E360 VA: 0x18165F960
	|-EnumerableSorter<RaycastHit>.Sort
	|
	|-RVA: 0x165F6C0 Offset: 0x165E0C0 VA: 0x18165F6C0
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165F040 Offset: 0x165DA40 VA: 0x18165F040
	|-EnumerableSorter<ValueTuple<object, object>>.QuickSort
	|-EnumerableSorter<CoordinateFootprintTilePair>.QuickSort
	|-EnumerableSorter<CoordinateStorageFootprintTilePair>.QuickSort
	|-EnumerableSorter<GlyphPairAdjustmentRecord>.QuickSort
	|-EnumerableSorter<Int32Enum>.QuickSort
	|-EnumerableSorter<Label>.QuickSort
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.QuickSort
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.QuickSort
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.QuickSort
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.QuickSort
	|-EnumerableSorter<object>.QuickSort
	|-EnumerableSorter<RaycastHit>.QuickSort
	|
	|-RVA: 0x165F2A0 Offset: 0x165DCA0 VA: 0x18165F2A0
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.QuickSort
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	|-EnumerableSorter<ValueTuple<object, object>>..ctor
	|-EnumerableSorter<CoordinateFootprintTilePair>..ctor
	|-EnumerableSorter<CoordinateStorageFootprintTilePair>..ctor
	|-EnumerableSorter<GlyphPairAdjustmentRecord>..ctor
	|-EnumerableSorter<Int32Enum>..ctor
	|-EnumerableSorter<Label>..ctor
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>..ctor
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>..ctor
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>..ctor
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>..ctor
	|-EnumerableSorter<object>..ctor
	|-EnumerableSorter<RaycastHit>..ctor
	|-EnumerableSorter<__Il2CppFullySharedGenericType>..ctor
	*/
}
