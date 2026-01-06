public class SyncHashSet<T> : SyncBase, ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 12636
{
	// Fields
	[CompilerGenerated]
	private SyncHashSet.SyncHashSetChanged<T> OnChange; // 0x0
	public readonly ISet<T> Collection; // 0x0
	public readonly ISet<T> ClientHostCollection; // 0x0
	private static List<T> _cache; // 0x0
	private ISet<T> _initialValues; // 0x0
	private readonly IEqualityComparer<T> _comparer; // 0x0
	private readonly List<SyncHashSet.ChangeData<T>> _changed; // 0x0
	private readonly List<SyncHashSet.CachedOnChange<T>> _serverOnChanges; // 0x0
	private readonly List<SyncHashSet.CachedOnChange<T>> _clientOnChanges; // 0x0
	private bool _valuesChanged; // 0x0
	private bool _sendAll; // 0x0

	// Properties
	[APIExclude]
	public bool IsReadOnly { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 30
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_OnChange(SyncHashSet.SyncHashSetChanged<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3940 Offset: 0x11F2340 VA: 0x1811F3940
	|-SyncHashSet<__Il2CppFullySharedGenericType>.add_OnChange
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_OnChange(SyncHashSet.SyncHashSetChanged<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3A60 Offset: 0x11F2460 VA: 0x1811F3A60
	|-SyncHashSet<__Il2CppFullySharedGenericType>.remove_OnChange
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3A10 Offset: 0x11F2410 VA: 0x1811F3A10
	|-SyncHashSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	[APIExclude]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3890 Offset: 0x11F2290 VA: 0x1811F3890
	|-SyncHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	[APIExclude]
	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F37D0 Offset: 0x11F21D0 VA: 0x1811F37D0
	|-SyncHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	[APIExclude]
	// RVA: -1 Offset: -1
	public void .ctor(ISet<T> collection, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F32C0 Offset: 0x11F1CC0 VA: 0x1811F32C0
	|-SyncHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Registered() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1190 Offset: 0x11EFB90 VA: 0x1811F1190
	|-SyncHashSet<__Il2CppFullySharedGenericType>.Registered
	*/

	// RVA: -1 Offset: -1
	public HashSet<T> GetCollection(bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFD70 Offset: 0x11EE770 VA: 0x1811EFD70
	|-SyncHashSet<__Il2CppFullySharedGenericType>.GetCollection
	*/

	// RVA: -1 Offset: -1
	private void AddOperation(SyncHashSetOperation operation, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EE790 Offset: 0x11ED190 VA: 0x1811EE790
	|-SyncHashSet<__Il2CppFullySharedGenericType>.AddOperation
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override void OnStartCallback(bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F05E0 Offset: 0x11EEFE0 VA: 0x1811F05E0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.OnStartCallback
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override void WriteDelta(PooledWriter writer, bool resetSyncTick = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2800 Offset: 0x11F1200 VA: 0x1811F2800
	|-SyncHashSet<__Il2CppFullySharedGenericType>.WriteDelta
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override void WriteFull(PooledWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2D30 Offset: 0x11F1730 VA: 0x1811F2D30
	|-SyncHashSet<__Il2CppFullySharedGenericType>.WriteFull
	*/

	[APIExclude]
	// RVA: -1 Offset: -1 Slot: 19
	public override void Read(PooledReader reader, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0AC0 Offset: 0x11EF4C0 VA: 0x1811F0AC0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.Read
	*/

	// RVA: -1 Offset: -1
	private void InvokeOnChange(SyncHashSetOperation operation, T item, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F00C0 Offset: 0x11EEAC0 VA: 0x1811F00C0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.InvokeOnChange
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public override void ResetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1880 Offset: 0x11F0280 VA: 0x1811F1880
	|-SyncHashSet<__Il2CppFullySharedGenericType>.ResetState
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF050 Offset: 0x11EDA50 VA: 0x1811EF050
	|-SyncHashSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private bool Add(T item, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EEDA0 Offset: 0x11ED7A0 VA: 0x1811EEDA0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EEA80 Offset: 0x11ED480 VA: 0x1811EEA80
	|-SyncHashSet<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF160 Offset: 0x11EDB60 VA: 0x1811EF160
	|-SyncHashSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	private void Clear(bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF180 Offset: 0x11EDB80 VA: 0x1811EF180
	|-SyncHashSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF3A0 Offset: 0x11EDDA0 VA: 0x1811EF3A0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F14C0 Offset: 0x11EFEC0 VA: 0x1811F14C0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	private bool Remove(T item, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F15D0 Offset: 0x11EFFD0 VA: 0x1811F15D0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void DirtyAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF5C0 Offset: 0x11EDFC0 VA: 0x1811EF5C0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.DirtyAll
	*/

	// RVA: -1 Offset: -1
	public void Dirty(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF610 Offset: 0x11EE010 VA: 0x1811EF610
	|-SyncHashSet<__Il2CppFullySharedGenericType>.Dirty
	*/

	// RVA: -1 Offset: -1
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFE30 Offset: 0x11EE830 VA: 0x1811EFE30
	|-SyncHashSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[APIExclude]
	// RVA: -1 Offset: -1 Slot: 36
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFE30 Offset: 0x11EE830 VA: 0x1811EFE30
	|-SyncHashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[APIExclude]
	// RVA: -1 Offset: -1 Slot: 37
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFE30 Offset: 0x11EE830 VA: 0x1811EFE30
	|-SyncHashSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public void ExceptWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFA40 Offset: 0x11EE440 VA: 0x1811EFA40
	|-SyncHashSet<__Il2CppFullySharedGenericType>.ExceptWith
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public void IntersectWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFFF0 Offset: 0x11EE9F0 VA: 0x1811EFFF0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.IntersectWith
	*/

	// RVA: -1 Offset: -1
	private void IntersectWith(ISet<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFE80 Offset: 0x11EE880 VA: 0x1811EFE80
	|-SyncHashSet<__Il2CppFullySharedGenericType>.IntersectWith
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public bool IsProperSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0460 Offset: 0x11EEE60 VA: 0x1811F0460
	|-SyncHashSet<__Il2CppFullySharedGenericType>.IsProperSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public bool IsProperSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F04C0 Offset: 0x11EEEC0 VA: 0x1811F04C0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.IsProperSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool IsSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0520 Offset: 0x11EEF20 VA: 0x1811F0520
	|-SyncHashSet<__Il2CppFullySharedGenericType>.IsSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public bool IsSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0580 Offset: 0x11EEF80 VA: 0x1811F0580
	|-SyncHashSet<__Il2CppFullySharedGenericType>.IsSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public bool Overlaps(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F0A60 Offset: 0x11EF460 VA: 0x1811F0A60
	|-SyncHashSet<__Il2CppFullySharedGenericType>.Overlaps
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public bool SetEquals(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1CF0 Offset: 0x11F06F0 VA: 0x1811F1CF0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.SetEquals
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public void SymmetricExceptWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F1D50 Offset: 0x11F0750 VA: 0x1811F1D50
	|-SyncHashSet<__Il2CppFullySharedGenericType>.SymmetricExceptWith
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public void UnionWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F24F0 Offset: 0x11F0EF0 VA: 0x1811F24F0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.UnionWith
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2080 Offset: 0x11F0A80 VA: 0x1811F2080
	|-SyncHashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF4A0 Offset: 0x11EDEA0 VA: 0x1811EF4A0
	|-SyncHashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3190 Offset: 0x11F1B90 VA: 0x1811F3190
	|-SyncHashSet<__Il2CppFullySharedGenericType>..cctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <IntersectWith>g__Intersect|47_0(ISet<T> collection, ref SyncHashSet.<>c__DisplayClass47_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F2190 Offset: 0x11F0B90 VA: 0x1811F2190
	|-SyncHashSet<__Il2CppFullySharedGenericType>.<IntersectWith>g__Intersect|47_0
	*/
}
