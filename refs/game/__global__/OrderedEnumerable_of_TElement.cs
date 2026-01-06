internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 15074
{
	// Fields
	internal IEnumerable<TElement> source; // 0x0

	// Methods

	[IteratorStateMachine(typeof(OrderedEnumerable.<GetEnumerator>d__1<TElement>))]
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EEDC0 Offset: 0x10ED7C0 VA: 0x1810EEDC0
	|-OrderedEnumerable<ValueTuple<object, object>>.GetEnumerator
	|-OrderedEnumerable<CoordinateFootprintTilePair>.GetEnumerator
	|-OrderedEnumerable<CoordinateStorageFootprintTilePair>.GetEnumerator
	|
	|-RVA: 0x10EED30 Offset: 0x10ED730 VA: 0x1810EED30
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.GetEnumerator
	|-OrderedEnumerable<Label>.GetEnumerator
	|-OrderedEnumerable<RaycastHit>.GetEnumerator
	|
	|-RVA: 0x10EF030 Offset: 0x10EDA30 VA: 0x1810EF030
	|-OrderedEnumerable<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x10EEEE0 Offset: 0x10ED8E0 VA: 0x1810EEEE0
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.GetEnumerator
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.GetEnumerator
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.GetEnumerator
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0x10EEE50 Offset: 0x10ED850 VA: 0x1810EEE50
	|-OrderedEnumerable<object>.GetEnumerator
	|
	|-RVA: 0x10EEF70 Offset: 0x10ED970 VA: 0x1810EEF70
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.GetEnumerableSorter
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF160 Offset: 0x10EDB60 VA: 0x1810EF160
	|-OrderedEnumerable<ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<CoordinateFootprintTilePair>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<CoordinateStorageFootprintTilePair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10EF200 Offset: 0x10EDC00 VA: 0x1810EF200
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<Label>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<RaycastHit>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10EF340 Offset: 0x10EDD40 VA: 0x1810EF340
	|-OrderedEnumerable<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10EF0C0 Offset: 0x10EDAC0 VA: 0x1810EF0C0
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10EF2A0 Offset: 0x10EDCA0 VA: 0x1810EF2A0
	|-OrderedEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10EF3E0 Offset: 0x10EDDE0 VA: 0x1810EF3E0
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC9B00 Offset: 0xDC8500 VA: 0x180DC9B00
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|
	|-RVA: 0xDC9A30 Offset: 0xDC8430 VA: 0x180DC9A30
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<int>
	|
	|-RVA: 0xDC9960 Offset: 0xDC8360 VA: 0x180DC9960
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	|-OrderedEnumerable<ValueTuple<object, object>>..ctor
	|-OrderedEnumerable<CoordinateFootprintTilePair>..ctor
	|-OrderedEnumerable<CoordinateStorageFootprintTilePair>..ctor
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>..ctor
	|-OrderedEnumerable<Int32Enum>..ctor
	|-OrderedEnumerable<Label>..ctor
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>..ctor
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>..ctor
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>..ctor
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>..ctor
	|-OrderedEnumerable<object>..ctor
	|-OrderedEnumerable<RaycastHit>..ctor
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>..ctor
	*/
}
