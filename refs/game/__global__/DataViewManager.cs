public class DataViewManager : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList // TypeDefIndex: 12922
{
	// Fields
	private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
	private DataSet _dataSet; // 0x28
	private DataViewManagerListItemTypeDescriptor _item; // 0x30
	private bool _locked; // 0x38
	internal int _nViews; // 0x3C
	private static NotSupportedException s_notSupported; // 0x0
	[CompilerGenerated]
	private ListChangedEventHandler ListChanged; // 0x40

	// Properties
	[DefaultValue(null)]
	public DataSet DataSet { get; }
	[DesignerSerializationVisibility(2)]
	public DataViewSettingCollection DataViewSettings { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.ComponentModel.IBindingList.AllowNew { get; }
	private bool System.ComponentModel.IBindingList.AllowEdit { get; }
	private bool System.ComponentModel.IBindingList.AllowRemove { get; }
	private bool System.ComponentModel.IBindingList.SupportsChangeNotification { get; }
	private bool System.ComponentModel.IBindingList.SupportsSearching { get; }
	private bool System.ComponentModel.IBindingList.SupportsSorting { get; }
	private bool System.ComponentModel.IBindingList.IsSorted { get; }
	private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get; }
	private ListSortDirection System.ComponentModel.IBindingList.SortDirection { get; }

	// Methods

	// RVA: 0x208B560 Offset: 0x2089F60 VA: 0x18208B560
	internal void .ctor(DataSet dataSet, bool locked) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public DataSet get_DataSet() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0x208AB90 Offset: 0x2089590 VA: 0x18208AB90 Slot: 44
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 41
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 42
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 43
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 34
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 35
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x208AAF0 Offset: 0x20894F0 VA: 0x18208AAF0 Slot: 40
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 29
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x208AD90 Offset: 0x2089790 VA: 0x18208AD90 Slot: 30
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x208AC70 Offset: 0x2089670 VA: 0x18208AC70 Slot: 31
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x208ACA0 Offset: 0x20896A0 VA: 0x18208ACA0 Slot: 33
	private void System.Collections.IList.Clear() { }

	// RVA: 0x208ACD0 Offset: 0x20896D0 VA: 0x18208ACD0 Slot: 32
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x208ACE0 Offset: 0x20896E0 VA: 0x18208ACE0 Slot: 36
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x208AD00 Offset: 0x2089700 VA: 0x18208AD00 Slot: 37
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x208AD60 Offset: 0x2089760 VA: 0x18208AD60 Slot: 38
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x208AD30 Offset: 0x2089730 VA: 0x18208AD30 Slot: 39
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 12
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x208ADC0 Offset: 0x20897C0 VA: 0x18208ADC0 Slot: 13
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 16
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 17
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 18
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x208AF00 Offset: 0x2089900 VA: 0x18208AF00 Slot: 19
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x208AFA0 Offset: 0x20899A0 VA: 0x18208AFA0 Slot: 20
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x208AF50 Offset: 0x2089950 VA: 0x18208AF50 Slot: 21
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	[CompilerGenerated]
	// RVA: 0x208B790 Offset: 0x208A190 VA: 0x18208B790 Slot: 22
	public void add_ListChanged(ListChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x208B830 Offset: 0x208A230 VA: 0x18208B830 Slot: 23
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 24
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0x208AE10 Offset: 0x2089810 VA: 0x18208AE10 Slot: 25
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x208AE60 Offset: 0x2089860 VA: 0x18208AE60 Slot: 26
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 27
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0x208AEB0 Offset: 0x20898B0 VA: 0x18208AEB0 Slot: 28
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x208B190 Offset: 0x2089B90 VA: 0x18208B190 Slot: 45
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x208AFF0 Offset: 0x20899F0 VA: 0x18208AFF0 Slot: 46
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x208A710 Offset: 0x2089110 VA: 0x18208A710
	public DataView CreateDataView(DataTable table) { }

	// RVA: 0x208A7C0 Offset: 0x20891C0 VA: 0x18208A7C0 Slot: 47
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x208B250 Offset: 0x2089C50 VA: 0x18208B250 Slot: 48
	protected virtual void TableCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x208A8B0 Offset: 0x20892B0 VA: 0x18208A8B0 Slot: 49
	protected virtual void RelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x208B4E0 Offset: 0x2089EE0 VA: 0x18208B4E0
	private static void .cctor() { }
}
