internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement> // TypeDefIndex: 15075
{
	// Fields
	internal OrderedEnumerable<TElement> parent; // 0x0
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF9A0 Offset: 0x10EE3A0 VA: 0x1810EF9A0
	|-OrderedEnumerable<ValueTuple<object, object>, object>..ctor
	|-OrderedEnumerable<object, object>..ctor
	|
	|-RVA: 0x10EF890 Offset: 0x10EE290 VA: 0x1810EF890
	|-OrderedEnumerable<CoordinateFootprintTilePair, int>..ctor
	|-OrderedEnumerable<CoordinateStorageFootprintTilePair, int>..ctor
	|-OrderedEnumerable<Label, int>..ctor
	|-OrderedEnumerable<object, int>..ctor
	|
	|-RVA: 0x10EF670 Offset: 0x10EE070 VA: 0x1810EF670
	|-OrderedEnumerable<GlyphPairAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<object, uint>..ctor
	|
	|-RVA: 0x10EF780 Offset: 0x10EE180 VA: 0x1810EF780
	|-OrderedEnumerable<Int32Enum, float>..ctor
	|-OrderedEnumerable<object, float>..ctor
	|-OrderedEnumerable<RaycastHit, float>..ctor
	|
	|-RVA: 0x10EFAB0 Offset: 0x10EE4B0 VA: 0x1810EFAB0
	|-OrderedEnumerable<object, byte>..ctor
	|
	|-RVA: 0x10EFBC0 Offset: 0x10EE5C0 VA: 0x1810EFBC0
	|-OrderedEnumerable<object, Int32Enum>..ctor
	|
	|-RVA: 0x10EFCD0 Offset: 0x10EE6D0 VA: 0x1810EFCD0
	|-OrderedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF4D0 Offset: 0x10EDED0 VA: 0x1810EF4D0
	|-OrderedEnumerable<ValueTuple<object, object>, object>.GetEnumerableSorter
	|
	|-RVA: 0x10EF400 Offset: 0x10EDE00 VA: 0x1810EF400
	|-OrderedEnumerable<CoordinateFootprintTilePair, int>.GetEnumerableSorter
	|-OrderedEnumerable<CoordinateStorageFootprintTilePair, int>.GetEnumerableSorter
	|-OrderedEnumerable<GlyphPairAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<Int32Enum, float>.GetEnumerableSorter
	|-OrderedEnumerable<Label, int>.GetEnumerableSorter
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<object, byte>.GetEnumerableSorter
	|-OrderedEnumerable<object, int>.GetEnumerableSorter
	|-OrderedEnumerable<object, Int32Enum>.GetEnumerableSorter
	|-OrderedEnumerable<object, object>.GetEnumerableSorter
	|-OrderedEnumerable<object, float>.GetEnumerableSorter
	|-OrderedEnumerable<object, uint>.GetEnumerableSorter
	|-OrderedEnumerable<RaycastHit, float>.GetEnumerableSorter
	|
	|-RVA: 0x10EF5A0 Offset: 0x10EDFA0 VA: 0x1810EF5A0
	|-OrderedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerableSorter
	*/
}
