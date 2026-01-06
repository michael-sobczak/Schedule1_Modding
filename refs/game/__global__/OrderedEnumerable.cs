private sealed class OrderedEnumerable.<GetEnumerator>d__1<TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 15073
{
	// Fields
	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public OrderedEnumerable<TElement> <>4__this; // 0x0
	private Buffer<TElement> <buffer>5__2; // 0x0
	private int[] <map>5__3; // 0x0
	private int <i>5__4; // 0x0

	// Properties
	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<object, object>>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateFootprintTilePair>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateStorageFootprintTilePair>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<Label>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<object>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>..ctor
	|
	|-RVA: 0xFD0750 Offset: 0xFCF150 VA: 0x180FD0750
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<object, object>>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateFootprintTilePair>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateStorageFootprintTilePair>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<Label>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE5600 Offset: 0xFE4000 VA: 0x180FE5600
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0xFE58F0 Offset: 0xFE42F0 VA: 0x180FE58F0
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateFootprintTilePair>.MoveNext
	|
	|-RVA: 0xFE6500 Offset: 0xFE4F00 VA: 0x180FE6500
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateStorageFootprintTilePair>.MoveNext
	|
	|-RVA: 0xFE6060 Offset: 0xFE4A60 VA: 0x180FE6060
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.MoveNext
	|
	|-RVA: 0xFE5780 Offset: 0xFE4180 VA: 0x180FE5780
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.MoveNext
	|
	|-RVA: 0xFE5460 Offset: 0xFE3E60 VA: 0x180FE5460
	|-OrderedEnumerable.<GetEnumerator>d__1<Label>.MoveNext
	|
	|-RVA: 0xFE5BF0 Offset: 0xFE45F0 VA: 0x180FE5BF0
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.MoveNext
	|
	|-RVA: 0xFE5A70 Offset: 0xFE4470 VA: 0x180FE5A70
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.MoveNext
	|
	|-RVA: 0xFE5D70 Offset: 0xFE4770 VA: 0x180FE5D70
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.MoveNext
	|
	|-RVA: 0xFE6380 Offset: 0xFE4D80 VA: 0x180FE6380
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.MoveNext
	|
	|-RVA: 0xFE5EF0 Offset: 0xFE48F0 VA: 0x180FE5EF0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.MoveNext
	|
	|-RVA: 0xFE61F0 Offset: 0xFE4BF0 VA: 0x180FE61F0
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>.MoveNext
	|
	|-RVA: 0xFE6680 Offset: 0xFE5080 VA: 0x180FE6680
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<object, object>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateFootprintTilePair>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateStorageFootprintTilePair>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xFE6BF0 Offset: 0xFE55F0 VA: 0x180FE6BF0
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x6952D0 Offset: 0x693CD0 VA: 0x1806952D0
	|-OrderedEnumerable.<GetEnumerator>d__1<Label>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xFE6BD0 Offset: 0xFE55D0 VA: 0x180FE6BD0
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xFCD2F0 Offset: 0xFCBCF0 VA: 0x180FCD2F0
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC9ED0 Offset: 0xFC88D0 VA: 0x180FC9ED0
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateFootprintTilePair>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateStorageFootprintTilePair>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<Label>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>.System.Collections.IEnumerator.Reset
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE6CB0 Offset: 0xFE56B0 VA: 0x180FE6CB0
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateFootprintTilePair>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<CoordinateStorageFootprintTilePair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFE6C60 Offset: 0xFE5660 VA: 0x180FE6C60
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<RaycastHit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFCD610 Offset: 0xFCC010 VA: 0x180FCD610
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFE6CE0 Offset: 0xFE56E0 VA: 0x180FE6CE0
	|-OrderedEnumerable.<GetEnumerator>d__1<Label>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFE6C20 Offset: 0xFE5620 VA: 0x180FE6C20
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFCD560 Offset: 0xFCBF60 VA: 0x180FCD560
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}
