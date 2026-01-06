public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList, INotifyCollectionChanged // TypeDefIndex: 11324
{
	// Fields
	[Nullable(2)]
	internal ListChangedEventHandler _listChanged; // 0x30
	[Nullable(2)]
	internal AddingNewEventHandler _addingNew; // 0x38
	[Nullable(2)]
	internal NotifyCollectionChangedEventHandler _collectionChanged; // 0x40
	[Nullable(2)]
	private object _syncRoot; // 0x48
	private bool _busy; // 0x50

	// Properties
	protected abstract IList<JToken> ChildrenTokens { get; }
	public override bool HasValues { get; }
	[Nullable(2)]
	public override JToken First { get; }
	[Nullable(2)]
	public override JToken Last { get; }
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item { get; set; }
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	[Nullable(2)]
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.ComponentModel.IBindingList.AllowEdit { get; }
	private bool System.ComponentModel.IBindingList.AllowNew { get; }
	private bool System.ComponentModel.IBindingList.AllowRemove { get; }
	private bool System.ComponentModel.IBindingList.IsSorted { get; }
	private ListSortDirection System.ComponentModel.IBindingList.SortDirection { get; }
	[Nullable(2)]
	private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get; }
	private bool System.ComponentModel.IBindingList.SupportsChangeNotification { get; }
	private bool System.ComponentModel.IBindingList.SupportsSearching { get; }
	private bool System.ComponentModel.IBindingList.SupportsSorting { get; }

	// Methods

	[AsyncStateMachine(typeof(JContainer.<ReadTokenFromAsync>d__0))]
	// RVA: 0x1DB6610 Offset: 0x1DB5010 VA: 0x181DB6610
	internal Task ReadTokenFromAsync(JsonReader reader, JsonLoadSettings options, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JContainer.<ReadContentFromAsync>d__1))]
	// RVA: 0x1DB5CA0 Offset: 0x1DB46A0 VA: 0x181DB5CA0
	private Task ReadContentFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x1DB8330 Offset: 0x1DB6D30 VA: 0x181DB8330 Slot: 51
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x1DB8700 Offset: 0x1DB7100 VA: 0x181DB8700 Slot: 52
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x1DB81F0 Offset: 0x1DB6BF0 VA: 0x181DB81F0
	public void add_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x1DB85C0 Offset: 0x1DB6FC0 VA: 0x181DB85C0
	public void remove_AddingNew(AddingNewEventHandler value) { }

	[NullableContext(2)]
	// RVA: 0x1DB8290 Offset: 0x1DB6C90 VA: 0x181DB8290 Slot: 73
	public void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[NullableContext(2)]
	// RVA: 0x1DB8660 Offset: 0x1DB7060 VA: 0x181DB8660 Slot: 74
	public void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	// RVA: -1 Offset: -1 Slot: 75
	protected abstract IList<JToken> get_ChildrenTokens();

	// RVA: 0x1DB7EB0 Offset: 0x1DB68B0 VA: 0x181DB7EB0
	internal void .ctor() { }

	// RVA: 0x1DB7F00 Offset: 0x1DB6900 VA: 0x181DB7F00
	internal void .ctor(JContainer other, JsonCloneSettings settings) { }

	// RVA: 0x1DB3DF0 Offset: 0x1DB27F0 VA: 0x181DB3DF0
	internal void CheckReentrancy() { }

	// RVA: 0x1DB4880 Offset: 0x1DB3280 VA: 0x181DB4880 Slot: 76
	internal virtual IList<JToken> CreateChildrenCollection() { }

	// RVA: 0x1DB5BA0 Offset: 0x1DB45A0 VA: 0x181DB5BA0 Slot: 77
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0x1DB5C30 Offset: 0x1DB4630 VA: 0x181DB5C30 Slot: 78
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1DB5BC0 Offset: 0x1DB45C0 VA: 0x181DB5BC0 Slot: 79
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	// RVA: 0x1DB84C0 Offset: 0x1DB6EC0 VA: 0x181DB84C0 Slot: 16
	public override bool get_HasValues() { }

	// RVA: 0x1DB4240 Offset: 0x1DB2C40 VA: 0x181DB4240
	internal bool ContentsEqual(JContainer container) { }

	[NullableContext(2)]
	// RVA: 0x1DB8430 Offset: 0x1DB6E30 VA: 0x181DB8430 Slot: 20
	public override JToken get_First() { }

	[NullableContext(2)]
	// RVA: 0x1DB8530 Offset: 0x1DB6F30 VA: 0x181DB8530 Slot: 21
	public override JToken get_Last() { }

	// RVA: 0x1DB3EA0 Offset: 0x1DB28A0 VA: 0x181DB3EA0 Slot: 22
	public override JEnumerable<JToken> Children() { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 23
	public override IEnumerable<T> Values<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4530 Offset: 0xEE2F30 VA: 0x180EE4530
	|-JContainer.Values<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1DB49F0 Offset: 0x1DB33F0 VA: 0x181DB49F0
	public IEnumerable<JToken> Descendants() { }

	// RVA: 0x1DB49E0 Offset: 0x1DB33E0 VA: 0x181DB49E0
	public IEnumerable<JToken> DescendantsAndSelf() { }

	[IteratorStateMachine(typeof(JContainer.<GetDescendants>d__36))]
	// RVA: 0x1DB4BC0 Offset: 0x1DB35C0 VA: 0x181DB4BC0
	internal IEnumerable<JToken> GetDescendants(bool self) { }

	[NullableContext(2)]
	// RVA: 0x1DB4F90 Offset: 0x1DB3990 VA: 0x181DB4F90
	internal bool IsMultiContent(object content) { }

	// RVA: 0x1DB4A00 Offset: 0x1DB3400 VA: 0x181DB4A00
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 80
	internal abstract int IndexOfItem(JToken item);

	[NullableContext(2)]
	// RVA: 0x1DB4CC0 Offset: 0x1DB36C0 VA: 0x181DB4CC0 Slot: 81
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x1DB6920 Offset: 0x1DB5320 VA: 0x181DB6920 Slot: 82
	internal virtual void RemoveItemAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x1DB6C80 Offset: 0x1DB5680 VA: 0x181DB6C80 Slot: 83
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0x1DB4C50 Offset: 0x1DB3650 VA: 0x181DB4C50 Slot: 84
	internal virtual JToken GetItem(int index) { }

	[NullableContext(2)]
	// RVA: 0x1DB6D80 Offset: 0x1DB5780 VA: 0x181DB6D80 Slot: 85
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0x1DB3F10 Offset: 0x1DB2910 VA: 0x181DB3F10 Slot: 86
	internal virtual void ClearItems() { }

	// RVA: 0x1DB6D20 Offset: 0x1DB5720 VA: 0x181DB6D20 Slot: 87
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	[NullableContext(2)]
	// RVA: 0x1DB4210 Offset: 0x1DB2C10 VA: 0x181DB4210 Slot: 88
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0x1DB4590 Offset: 0x1DB2F90 VA: 0x181DB4590 Slot: 89
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0x1DB5060 Offset: 0x1DB3A60 VA: 0x181DB5060
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0x1DB7D80 Offset: 0x1DB6780 VA: 0x181DB7D80 Slot: 90
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	[NullableContext(2)]
	// RVA: 0x1DB3D60 Offset: 0x1DB2760 VA: 0x181DB3D60 Slot: 91
	public virtual void Add(object content) { }

	[NullableContext(2)]
	// RVA: 0x1DB7B70 Offset: 0x1DB6570 VA: 0x181DB7B70
	internal bool TryAdd(object content) { }

	// RVA: 0x1DB3CA0 Offset: 0x1DB26A0 VA: 0x181DB3CA0
	internal void AddAndSkipParentCheck(JToken token) { }

	[NullableContext(2)]
	// RVA: 0x1DB3D30 Offset: 0x1DB2730 VA: 0x181DB3D30
	public void AddFirst(object content) { }

	[NullableContext(2)]
	// RVA: 0x1DB78E0 Offset: 0x1DB62E0 VA: 0x181DB78E0
	internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x1DB48E0 Offset: 0x1DB32E0 VA: 0x181DB48E0
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0x1DB4980 Offset: 0x1DB3380 VA: 0x181DB4980
	public JsonWriter CreateWriter() { }

	// RVA: 0x1DB6CD0 Offset: 0x1DB56D0 VA: 0x181DB6CD0
	public void ReplaceAll(object content) { }

	// RVA: 0x70D2D0 Offset: 0x70BCD0 VA: 0x18070D2D0
	public void RemoveAll() { }

	// RVA: -1 Offset: -1 Slot: 92
	internal abstract void MergeItem(object content, JsonMergeSettings settings);

	[NullableContext(2)]
	// RVA: 0x1DB5B50 Offset: 0x1DB4550 VA: 0x181DB5B50
	public void Merge(object content) { }

	[NullableContext(2)]
	// RVA: 0x1DB5AF0 Offset: 0x1DB44F0 VA: 0x181DB5AF0
	public void Merge(object content, JsonMergeSettings settings) { }

	// RVA: 0x1DB7C00 Offset: 0x1DB6600 VA: 0x181DB7C00
	private void ValidateContent(object content) { }

	// RVA: 0x1DB6760 Offset: 0x1DB5160 VA: 0x181DB6760
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0x1DB5DF0 Offset: 0x1DB47F0 VA: 0x181DB5DF0
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x1DB63A0 Offset: 0x1DB4DA0 VA: 0x181DB63A0
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	// RVA: 0x1DB43A0 Offset: 0x1DB2DA0 VA: 0x181DB43A0
	internal int ContentsHashCode() { }

	// RVA: 0x1DB78A0 Offset: 0x1DB62A0 VA: 0x181DB78A0 Slot: 39
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x1DB7710 Offset: 0x1DB6110 VA: 0x181DB7710 Slot: 40
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x1D97E10 Offset: 0x1D96810 VA: 0x181D97E10 Slot: 29
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0x1D97E30 Offset: 0x1D96830 VA: 0x181D97E30 Slot: 30
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0x1D98530 Offset: 0x1D96F30 VA: 0x181D98530 Slot: 31
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0x1D98B20 Offset: 0x1D97520 VA: 0x181D98B20 Slot: 27
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0x1D98B40 Offset: 0x1D97540 VA: 0x181D98B40 Slot: 28
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0x1D97860 Offset: 0x1D96260 VA: 0x181D97860 Slot: 34
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0x70D2D0 Offset: 0x70BCD0 VA: 0x18070D2D0 Slot: 35
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0x1D97950 Offset: 0x1D96350 VA: 0x181D97950 Slot: 36
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0x1D97970 Offset: 0x1D96370 VA: 0x181D97970 Slot: 37
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 33
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0x1D98550 Offset: 0x1D96F50 VA: 0x181D98550 Slot: 38
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x1DB4B10 Offset: 0x1DB3510 VA: 0x181DB4B10
	private JToken EnsureValue(object value) { }

	[NullableContext(2)]
	// RVA: 0x1DB7260 Offset: 0x1DB5C60 VA: 0x181DB7260 Slot: 60
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x70D2D0 Offset: 0x70BCD0 VA: 0x18070D2D0 Slot: 62
	private void System.Collections.IList.Clear() { }

	[NullableContext(2)]
	// RVA: 0x1DB72F0 Offset: 0x1DB5CF0 VA: 0x181DB72F0 Slot: 61
	private bool System.Collections.IList.Contains(object value) { }

	[NullableContext(2)]
	// RVA: 0x1DB7320 Offset: 0x1DB5D20 VA: 0x181DB7320 Slot: 65
	private int System.Collections.IList.IndexOf(object value) { }

	[NullableContext(2)]
	// RVA: 0x1DB7350 Offset: 0x1DB5D50 VA: 0x181DB7350 Slot: 66
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 64
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 63
	private bool System.Collections.IList.get_IsReadOnly() { }

	[NullableContext(2)]
	// RVA: 0x1DB73B0 Offset: 0x1DB5DB0 VA: 0x181DB73B0 Slot: 67
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1D98530 Offset: 0x1D96F30 VA: 0x181D98530 Slot: 68
	private void System.Collections.IList.RemoveAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x1D98B20 Offset: 0x1D97520 VA: 0x181D98B20 Slot: 58
	private object System.Collections.IList.get_Item(int index) { }

	[NullableContext(2)]
	// RVA: 0x1DB73E0 Offset: 0x1DB5DE0 VA: 0x181DB73E0 Slot: 59
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1D97970 Offset: 0x1D96370 VA: 0x181D97970 Slot: 69
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1DB83D0 Offset: 0x1DB6DD0 VA: 0x181DB83D0 Slot: 70
	public int get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 72
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1DB71F0 Offset: 0x1DB5BF0 VA: 0x181DB71F0 Slot: 71
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 53
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0x1DB7430 Offset: 0x1DB5E30 VA: 0x181DB7430 Slot: 42
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 43
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 41
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 44
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x1DB7650 Offset: 0x1DB6050 VA: 0x181DB7650 Slot: 54
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x1DB7690 Offset: 0x1DB6090 VA: 0x181DB7690 Slot: 55
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 48
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 56
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0x1DB76D0 Offset: 0x1DB60D0 VA: 0x181DB76D0 Slot: 57
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 50
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	[NullableContext(2)]
	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 49
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 45
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 46
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 47
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x1DB5110 Offset: 0x1DB3B10 VA: 0x181DB5110
	internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings) { }
}
