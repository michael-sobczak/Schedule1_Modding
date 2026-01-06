internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement> // TypeDefIndex: 15077
{
	// Fields
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0
	internal EnumerableSorter<TElement> next; // 0x0
	internal TKey[] keys; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16602D0 Offset: 0x165ECD0 VA: 0x1816602D0
	|-EnumerableSorter<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x16617B0 Offset: 0x16601B0 VA: 0x1816617B0
	|-EnumerableSorter<CoordinateFootprintTilePair, int>..ctor
	|-EnumerableSorter<CoordinateStorageFootprintTilePair, int>..ctor
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<Int32Enum, float>..ctor
	|-EnumerableSorter<Label, int>..ctor
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<object, byte>..ctor
	|-EnumerableSorter<object, int>..ctor
	|-EnumerableSorter<object, Int32Enum>..ctor
	|-EnumerableSorter<object, object>..ctor
	|-EnumerableSorter<object, float>..ctor
	|-EnumerableSorter<object, uint>..ctor
	|-EnumerableSorter<RaycastHit, float>..ctor
	|
	|-RVA: 0x1661840 Offset: 0x1660240 VA: 0x181661840
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override void ComputeKeys(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16601A0 Offset: 0x165EBA0 VA: 0x1816601A0
	|-EnumerableSorter<ValueTuple<object, object>, object>.ComputeKeys
	|
	|-RVA: 0x16612C0 Offset: 0x165FCC0 VA: 0x1816612C0
	|-EnumerableSorter<CoordinateFootprintTilePair, int>.ComputeKeys
	|-EnumerableSorter<CoordinateStorageFootprintTilePair, int>.ComputeKeys
	|
	|-RVA: 0x1660B50 Offset: 0x165F550 VA: 0x181660B50
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>.ComputeKeys
	|
	|-RVA: 0x16611A0 Offset: 0x165FBA0 VA: 0x1816611A0
	|-EnumerableSorter<Int32Enum, float>.ComputeKeys
	|
	|-RVA: 0x1661510 Offset: 0x165FF10 VA: 0x181661510
	|-EnumerableSorter<Label, int>.ComputeKeys
	|
	|-RVA: 0x1660CC0 Offset: 0x165F6C0 VA: 0x181660CC0
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.ComputeKeys
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.ComputeKeys
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.ComputeKeys
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.ComputeKeys
	|
	|-RVA: 0x1661400 Offset: 0x165FE00 VA: 0x181661400
	|-EnumerableSorter<object, byte>.ComputeKeys
	|
	|-RVA: 0x1661070 Offset: 0x165FA70 VA: 0x181661070
	|-EnumerableSorter<object, int>.ComputeKeys
	|-EnumerableSorter<object, Int32Enum>.ComputeKeys
	|-EnumerableSorter<object, uint>.ComputeKeys
	|
	|-RVA: 0x1660A30 Offset: 0x165F430 VA: 0x181660A30
	|-EnumerableSorter<object, object>.ComputeKeys
	|
	|-RVA: 0x1661680 Offset: 0x1660080 VA: 0x181661680
	|-EnumerableSorter<object, float>.ComputeKeys
	|
	|-RVA: 0x16608C0 Offset: 0x165F2C0 VA: 0x1816608C0
	|-EnumerableSorter<RaycastHit, float>.ComputeKeys
	|
	|-RVA: 0x1660E10 Offset: 0x165F810 VA: 0x181660E10
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1660060 Offset: 0x165EA60 VA: 0x181660060
	|-EnumerableSorter<ValueTuple<object, object>, object>.CompareKeys
	|-EnumerableSorter<object, object>.CompareKeys
	|
	|-RVA: 0x1660350 Offset: 0x165ED50 VA: 0x181660350
	|-EnumerableSorter<CoordinateFootprintTilePair, int>.CompareKeys
	|-EnumerableSorter<CoordinateStorageFootprintTilePair, int>.CompareKeys
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<Label, int>.CompareKeys
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<object, int>.CompareKeys
	|-EnumerableSorter<object, Int32Enum>.CompareKeys
	|-EnumerableSorter<object, uint>.CompareKeys
	|
	|-RVA: 0x16607C0 Offset: 0x165F1C0 VA: 0x1816607C0
	|-EnumerableSorter<Int32Enum, float>.CompareKeys
	|-EnumerableSorter<object, float>.CompareKeys
	|-EnumerableSorter<RaycastHit, float>.CompareKeys
	|
	|-RVA: 0x1660440 Offset: 0x165EE40 VA: 0x181660440
	|-EnumerableSorter<object, byte>.CompareKeys
	|
	|-RVA: 0x1660590 Offset: 0x165EF90 VA: 0x181660590
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareKeys
	*/
}
