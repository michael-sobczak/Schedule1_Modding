public class SyncList<T> : SyncBase, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 12642
{
	// Fields
	[CompilerGenerated]
	private SyncList.SyncListChanged<T> OnChange; // 0x0
	public readonly IList<T> Collection; // 0x0
	public readonly IList<T> ClientHostCollection; // 0x0
	private IList<T> _initialValues; // 0x0
	private readonly IEqualityComparer<T> _comparer; // 0x0
	private readonly List<SyncList.ChangeData<T>> _changed; // 0x0
	private readonly List<SyncList.CachedOnChange<T>> _serverOnChanges; // 0x0
	private readonly List<SyncList.CachedOnChange<T>> _clientOnChanges; // 0x0
	private bool _valuesChanged; // 0x0
	private bool _sendAll; // 0x0

	// Properties
	[APIExclude]
	public bool IsReadOnly { get; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 28
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SyncList<int>.get_IsReadOnly
	|-SyncList<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_OnChange(SyncList.SyncListChanged<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3940 Offset: 0x11F2340 VA: 0x1811F3940
	|-SyncList<int>.add_OnChange
	|-SyncList<__Il2CppFullySharedGenericType>.add_OnChange
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_OnChange(SyncList.SyncListChanged<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3A60 Offset: 0x11F2460 VA: 0x1811F3A60
	|-SyncList<int>.remove_OnChange
	|-SyncList<__Il2CppFullySharedGenericType>.remove_OnChange
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3A10 Offset: 0x11F2410 VA: 0x1811F3A10
	|-SyncList<int>.get_Count
	|-SyncList<__Il2CppFullySharedGenericType>.get_Count
	*/

	[APIExclude]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FCE60 Offset: 0x11FB860 VA: 0x1811FCE60
	|-SyncList<int>..ctor
	|
	|-RVA: 0x11F3890 Offset: 0x11F2290 VA: 0x1811F3890
	|-SyncList<__Il2CppFullySharedGenericType>..ctor
	*/

	[APIExclude]
	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FCF00 Offset: 0x11FB900 VA: 0x1811FCF00
	|-SyncList<int>..ctor
	|
	|-RVA: 0x11F37D0 Offset: 0x11F21D0 VA: 0x1811F37D0
	|-SyncList<__Il2CppFullySharedGenericType>..ctor
	*/

	[APIExclude]
	// RVA: -1 Offset: -1
	public void .ctor(IList<T> collection, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FC9E0 Offset: 0x11FB3E0 VA: 0x1811FC9E0
	|-SyncList<int>..ctor
	|
	|-RVA: 0x1204030 Offset: 0x1202A30 VA: 0x181204030
	|-SyncList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Registered() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FB4A0 Offset: 0x11F9EA0 VA: 0x1811FB4A0
	|-SyncList<int>.Registered
	|
	|-RVA: 0x1201E10 Offset: 0x1200810 VA: 0x181201E10
	|-SyncList<__Il2CppFullySharedGenericType>.Registered
	*/

	// RVA: -1 Offset: -1
	public List<T> GetCollection(bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFD70 Offset: 0x11EE770 VA: 0x1811EFD70
	|-SyncList<int>.GetCollection
	|-SyncList<__Il2CppFullySharedGenericType>.GetCollection
	*/

	// RVA: -1 Offset: -1
	private void AddOperation(SyncListOperation operation, int index, T prev, T next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F92E0 Offset: 0x11F7CE0 VA: 0x1811F92E0
	|-SyncList<int>.AddOperation
	|
	|-RVA: 0x11FE680 Offset: 0x11FD080 VA: 0x1811FE680
	|-SyncList<__Il2CppFullySharedGenericType>.AddOperation
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override void OnStartCallback(bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FAD60 Offset: 0x11F9760 VA: 0x1811FAD60
	|-SyncList<int>.OnStartCallback
	|
	|-RVA: 0x1200F80 Offset: 0x11FF980 VA: 0x181200F80
	|-SyncList<__Il2CppFullySharedGenericType>.OnStartCallback
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override void WriteDelta(PooledWriter writer, bool resetSyncTick = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FC450 Offset: 0x11FAE50 VA: 0x1811FC450
	|-SyncList<int>.WriteDelta
	|
	|-RVA: 0x1203680 Offset: 0x1202080 VA: 0x181203680
	|-SyncList<__Il2CppFullySharedGenericType>.WriteDelta
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override void WriteFull(PooledWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FC6E0 Offset: 0x11FB0E0 VA: 0x1811FC6E0
	|-SyncList<int>.WriteFull
	|
	|-RVA: 0x1203C80 Offset: 0x1202680 VA: 0x181203C80
	|-SyncList<__Il2CppFullySharedGenericType>.WriteFull
	*/

	[APIExclude]
	// RVA: -1 Offset: -1 Slot: 19
	public override void Read(PooledReader reader, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FAF30 Offset: 0x11F9930 VA: 0x1811FAF30
	|-SyncList<int>.Read
	|
	|-RVA: 0x1201500 Offset: 0x11FFF00 VA: 0x181201500
	|-SyncList<__Il2CppFullySharedGenericType>.Read
	*/

	// RVA: -1 Offset: -1
	private void InvokeOnChange(SyncListOperation operation, int index, T prev, T next, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FAB30 Offset: 0x11F9530 VA: 0x1811FAB30
	|-SyncList<int>.InvokeOnChange
	|
	|-RVA: 0x1200A20 Offset: 0x11FF420 VA: 0x181200A20
	|-SyncList<__Il2CppFullySharedGenericType>.InvokeOnChange
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public override void ResetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FBD50 Offset: 0x11FA750 VA: 0x1811FBD50
	|-SyncList<int>.ResetState
	|
	|-RVA: 0x1202B80 Offset: 0x1201580 VA: 0x181202B80
	|-SyncList<__Il2CppFullySharedGenericType>.ResetState
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9820 Offset: 0x11F8220 VA: 0x1811F9820
	|-SyncList<int>.Add
	|
	|-RVA: 0x11FED30 Offset: 0x11FD730 VA: 0x1811FED30
	|-SyncList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private void Add(T item, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9680 Offset: 0x11F8080 VA: 0x1811F9680
	|-SyncList<int>.Add
	|
	|-RVA: 0x11FEE40 Offset: 0x11FD840 VA: 0x1811FEE40
	|-SyncList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9490 Offset: 0x11F7E90 VA: 0x1811F9490
	|-SyncList<int>.AddRange
	|
	|-RVA: 0x11FEA10 Offset: 0x11FD410 VA: 0x1811FEA10
	|-SyncList<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9840 Offset: 0x11F8240 VA: 0x1811F9840
	|-SyncList<int>.Clear
	|
	|-RVA: 0x11FF1C0 Offset: 0x11FDBC0 VA: 0x1811FF1C0
	|-SyncList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	private void Clear(bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9990 Offset: 0x11F8390 VA: 0x1811F9990
	|-SyncList<int>.Clear
	|
	|-RVA: 0x11FF1E0 Offset: 0x11FDBE0 VA: 0x1811FF1E0
	|-SyncList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9AE0 Offset: 0x11F84E0 VA: 0x1811F9AE0
	|-SyncList<int>.Contains
	|
	|-RVA: 0x11FF440 Offset: 0x11FDE40 VA: 0x1811FF440
	|-SyncList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9B10 Offset: 0x11F8510 VA: 0x1811F9B10
	|-SyncList<int>.CopyTo
	|-SyncList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FA3E0 Offset: 0x11F8DE0 VA: 0x1811FA3E0
	|-SyncList<int>.IndexOf
	|
	|-RVA: 0x1200090 Offset: 0x11FEA90 VA: 0x181200090
	|-SyncList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FA140 Offset: 0x11F8B40 VA: 0x1811FA140
	|-SyncList<int>.FindIndex
	|
	|-RVA: 0x11FFD10 Offset: 0x11FE710 VA: 0x1811FFD10
	|-SyncList<__Il2CppFullySharedGenericType>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public T Find(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FA240 Offset: 0x11F8C40 VA: 0x1811FA240
	|-SyncList<int>.Find
	|
	|-RVA: 0x11FFE90 Offset: 0x11FE890 VA: 0x1811FFE90
	|-SyncList<__Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	public List<T> FindAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9EC0 Offset: 0x11F88C0 VA: 0x1811F9EC0
	|-SyncList<int>.FindAll
	|
	|-RVA: 0x11FF9B0 Offset: 0x11FE3B0 VA: 0x1811FF9B0
	|-SyncList<__Il2CppFullySharedGenericType>.FindAll
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FA9C0 Offset: 0x11F93C0 VA: 0x1811FA9C0
	|-SyncList<int>.Insert
	|
	|-RVA: 0x12005B0 Offset: 0x11FEFB0 VA: 0x1812005B0
	|-SyncList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	private void Insert(int index, T item, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FA850 Offset: 0x11F9250 VA: 0x1811FA850
	|-SyncList<int>.Insert
	|
	|-RVA: 0x12006C0 Offset: 0x11FF0C0 VA: 0x1812006C0
	|-SyncList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void InsertRange(int index, IEnumerable<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FA510 Offset: 0x11F8F10 VA: 0x1811FA510
	|-SyncList<int>.InsertRange
	|
	|-RVA: 0x1200280 Offset: 0x11FEC80 VA: 0x181200280
	|-SyncList<__Il2CppFullySharedGenericType>.InsertRange
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FBCC0 Offset: 0x11FA6C0 VA: 0x1811FBCC0
	|-SyncList<int>.Remove
	|
	|-RVA: 0x1202A50 Offset: 0x1201450 VA: 0x181202A50
	|-SyncList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FBB00 Offset: 0x11FA500 VA: 0x1811FBB00
	|-SyncList<int>.RemoveAt
	|
	|-RVA: 0x1202740 Offset: 0x1201140 VA: 0x181202740
	|-SyncList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private void RemoveAt(int index, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FBB20 Offset: 0x11FA520 VA: 0x1811FBB20
	|-SyncList<int>.RemoveAt
	|
	|-RVA: 0x1202760 Offset: 0x1201160 VA: 0x181202760
	|-SyncList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public int RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FB740 Offset: 0x11FA140 VA: 0x1811FB740
	|-SyncList<int>.RemoveAll
	|
	|-RVA: 0x1202150 Offset: 0x1200B50 VA: 0x181202150
	|-SyncList<__Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public T get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FCFB0 Offset: 0x11FB9B0 VA: 0x1811FCFB0
	|-SyncList<int>.get_Item
	|
	|-RVA: 0x1204540 Offset: 0x1202F40 VA: 0x181204540
	|-SyncList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public void set_Item(int i, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FD010 Offset: 0x11FBA10 VA: 0x1811FD010
	|-SyncList<int>.set_Item
	|
	|-RVA: 0x1204610 Offset: 0x1203010 VA: 0x181204610
	|-SyncList<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void DirtyAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9BE0 Offset: 0x11F85E0 VA: 0x1811F9BE0
	|-SyncList<int>.DirtyAll
	|
	|-RVA: 0x11FF530 Offset: 0x11FDF30 VA: 0x1811FF530
	|-SyncList<__Il2CppFullySharedGenericType>.DirtyAll
	*/

	// RVA: -1 Offset: -1
	public void Dirty(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9D70 Offset: 0x11F8770 VA: 0x1811F9D70
	|-SyncList<int>.Dirty
	|
	|-RVA: 0x11FF7D0 Offset: 0x11FE1D0 VA: 0x1811FF7D0
	|-SyncList<__Il2CppFullySharedGenericType>.Dirty
	*/

	// RVA: -1 Offset: -1
	public void Dirty(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F9CB0 Offset: 0x11F86B0 VA: 0x1811F9CB0
	|-SyncList<int>.Dirty
	|
	|-RVA: 0x11FF600 Offset: 0x11FE000 VA: 0x1811FF600
	|-SyncList<__Il2CppFullySharedGenericType>.Dirty
	*/

	// RVA: -1 Offset: -1
	public void Set(int index, T value, bool force = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FC3A0 Offset: 0x11FADA0 VA: 0x1811FC3A0
	|-SyncList<int>.Set
	|
	|-RVA: 0x12034A0 Offset: 0x1201EA0 VA: 0x1812034A0
	|-SyncList<__Il2CppFullySharedGenericType>.Set
	*/

	// RVA: -1 Offset: -1
	private void Set(int index, T value, bool asServer, bool force) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FC150 Offset: 0x11FAB50 VA: 0x1811FC150
	|-SyncList<int>.Set
	|
	|-RVA: 0x1203000 Offset: 0x1201A00 VA: 0x181203000
	|-SyncList<__Il2CppFullySharedGenericType>.Set
	*/

	// RVA: -1 Offset: -1
	public SyncList.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FA3A0 Offset: 0x11F8DA0 VA: 0x1811FA3A0
	|-SyncList<int>.GetEnumerator
	|
	|-RVA: 0x11FFFE0 Offset: 0x11FE9E0 VA: 0x1811FFFE0
	|-SyncList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[APIExclude]
	// RVA: -1 Offset: -1 Slot: 34
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FC3E0 Offset: 0x11FADE0 VA: 0x1811FC3E0
	|-SyncList<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x12035D0 Offset: 0x1201FD0 VA: 0x1812035D0
	|-SyncList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[APIExclude]
	// RVA: -1 Offset: -1 Slot: 35
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FC3E0 Offset: 0x11FADE0 VA: 0x1811FC3E0
	|-SyncList<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12035D0 Offset: 0x1201FD0 VA: 0x1812035D0
	|-SyncList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
